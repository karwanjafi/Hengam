using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Tools;
using FarsiLibrary.Utils;
using Hengam.Tools;
using FarsiMessageBox;

namespace Hengam.Forms
{
    public partial class frmCalssDailyStatus : HengamWidgets.FormBaseSimple
    {
        public frmCalssDailyStatus()
        {
            InitializeComponent();
        }

        //frmClassSessionStatusSetterPrivate frmPresenceOneManager = new frmClassSessionStatusSetterPrivate();
        frmClassSessionStatusSetter frmStatusSetterPublic;// = new frmClassSessionStatusSetterPublic();

        private void frmPresenceManager_LoadForm(object sender, EventArgs e)
        {
            //FormEditingState = EditingState.Setting;
            FormEditingState = EditingState.Normal;
            txtClassDate.Text = FaDate.CurrentFaDateString;

            //floaterPresence.LoadPanel(frmPresenceOneManager);
            //frmStatusSetterPublic = FormRequester.StatusSetterPublic();

            
            
            datagridSection.RefreshDataGrid();
            
        }

        private void datagridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if (!txtDateFrom.Accepted || !txtDateTo.Accepted)
            {
                //SetMsg("تاریخ‌ها درست تنظیم نشده اند.");
                return;
            }
            string dateFrom = txtDateFrom.Text;
            string dateTo = txtDateTo.Text;
            DataGridFiller<ClasssessionBO>.FillDataGrid(datagridSection, ClasssessionBO.ListSessions(dateFrom, dateTo), new List<ColumnDefinition>
            {
                DatabaseSchema.Class.ClassName,
                DatabaseSchema.Day.DayName,
                DatabaseSchema.Classsession.TimeID,
                DatabaseSchema.Classsession.ClassDate,
                DatabaseSchema.Classsession.SessionStatus,
                DatabaseSchema.Major.MajorName,
                DatabaseSchema.Student.LastName,
                DatabaseSchema.Classsession.RemainedSessions,
                DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay,
                DatabaseSchema.Student.TellHome
            });
        }

        private void Set(string dateFrom, string dateTo)
        {
            FormEditingState = EditingState.Setting;
            txtDateFrom.Text = dateFrom;
            txtDateTo.Text = dateTo;
            FormEditingState = EditingState.Normal;
            datagridSection.RefreshDataGrid();
        }

        private enum EditingState
        {
            Normal,
            Setting
        }

        private EditingState FormEditingState { get; set; }
        
        private void txtDateFrom_TextAccepted(object sender, EventArgs e)
        {
            if (FormEditingState == EditingState.Normal)
            {
                FiltersChanged();
            }
        }

        private void txtDateTo_TextAccepted(object sender, EventArgs e)
        {
            if (FormEditingState == EditingState.Normal)
            {
                FiltersChanged();
            }
        }

        private void FiltersChanged()
        {
            if (FormEditingState != EditingState.Setting)
            {
                if (!txtDateFrom.Accepted || !txtDateTo.Accepted)
                {
                    //SetMsg("تاریخ‌ها درست تنظیم نشده اند.");
                    return;
                }
                datagridSection.RefreshDataGrid();
            }
        }

        private void datagridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            
            ClasssessionBO session = (ClasssessionBO)e.Row.Tag;

            //if (session.RelClass.GroupFlag)
            //{
            Form f = FormRequester.ClassSessionStatusSetter();
            if (f == null)
            {
                MessageBoxEx.Show("شما به قسمت تنظیم وضعیت جلسات دسترسی ندارید.");
                return;
            }
            else
            {
                frmStatusSetterPublic = (frmClassSessionStatusSetter)f;
                floaterStatusSetterPublic.LoadPanel(frmStatusSetterPublic);
                frmStatusSetterPublic.Set(session);
                floaterStatusSetterPublic.Show();
            }

            
            //}
            //else
            //{
            //    frmPresenceOneManager.Set((ClasssessionBO)e.Row.Tag);
            //    floaterPresence.Show();
            //}
        }

        private void floaterPresence_Closed()
        {
            datagridSection.RefreshDataGrid();
        }

        private void txtClassDate_TextAccepted(object sender, EventArgs e)
        {
            FormEditingState = EditingState.Setting;
            txtDateFrom.Text = txtDateTo.Text = txtClassDate.Text;
            FormEditingState = EditingState.Normal;
            FiltersChanged();
        }

        private void btnNextDay_Clicked(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            PersianDate date = new PersianDate(txtClassDate.Text);
            txtClassDate.Text = new PersianDate(pc.AddDays(date, 1)).ToString("yyyy/mm/dd");
        }

        private void btnPreviousDay_Clicked(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            PersianDate date = new PersianDate(txtClassDate.Text);
            txtClassDate.Text = new PersianDate(pc.AddDays(date, -1)).ToString("yyyy/mm/dd");
        }

        private void floaterStatusSetterPublic_Closed()
        {
            datagridSection.RefreshDataGrid();
        }
    }
}
