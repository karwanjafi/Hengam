using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemPickers;
using Tools;
using BusinessObjectNamespace;
using DatabaseSchemaNamespace;
using FarsiMessageBox;
using DataGridFiller;
using StandardWidgets;
using Hengam.Tools;


namespace Hengam.Forms
{
    public partial class frmTeacherSessionDetails : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmTeacherSessionDetails()
        {
            InitializeComponent();
        }

        private void ActionPay(object sender, EventArgs e)
        {
            //if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            //ViwTeacherSessionDetailsBO status = (ViwTeacherSessionDetailsBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            if (!txtClassID.Accepted) return;
            int classID = UtilityTxt.GetInt(txtClassID.Text);
            if (txtTeacherID.Accepted)
            {
                Form f = FormRequester.TeacherPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmTeacherPayForClass fPay = (frmTeacherPayForClass)f;
                    fPay.Set(ClassBO.Find(classID), TeacherBO.Find(txtTeacherID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void ActionStatusSetter(object sender, EventArgs e)
        {

            if (dataGridSection.DataGrid.SelectedRows.Count >0)
            {
                ViwTeacherSessionDetailsBO detail = (ViwTeacherSessionDetailsBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
                Form f = FormRequester.ClassSessionStatusSetter();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmClassSessionStatusSetter frmStatusSetterPublic = (frmClassSessionStatusSetter)f;
                    frmStatusSetterPublic.Set(ClasssessionBO.Find(detail.ClassID, detail.ClassDate, detail.TimeID)); //hanieh
                    floaterContainer.LoadPanel(frmStatusSetterPublic);
                    //frmStatusSetterPublic.Set(ClasssessionBO.Find(detail.ClassID, detail.ClassDate, detail.TimeID)); //hanieh
                    floaterContainer.Show();
                }
            }
        }

        frmClassPicker fClassPicker = new frmClassPicker();

        private void frmTeacherSessionDetails_LoadForm(object sender, EventArgs e)
        {
            if (Program.User.CanTeacherPayForClass)
            {
                AddButton("پرداخت حقوق", "Money", "پرداخت حقوق استاد بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
                AddButton("پرداخت حقوق", "Money", "پرداخت حقوق استاد بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            }
            
            if (Program.User.CanClassSessionStatusSetter)
                AddButton("وضعیت جلسه", "Session", "تنظیم وضعیت تشکیل جلسه", ActionStatusSetter, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            frmClassPicker.StudentAccepted = false; //hanieh
            frmClassPicker.TeacherAccepted = true; //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);
        }
        bool setting = false;
        private void txtTeacherID_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return;
            dataGridSection.RefreshDataGrid();
        }

        private void txtClassID_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return;
            if (txtTeacherID.Accepted) fClassPicker.Set(TeacherBO.Find(txtTeacherID.Text));
            dataGridSection.RefreshDataGrid();
        }

        public void Set(TeacherBO teacher, ClassBO cls)
        {
            setting = true;
            if (teacher != null)
            {
                txtTeacherID.Text = teacher.TeacherID;
                txtTeacherName.Text = teacher.FullName;
            }

            if (cls != null)
            {
                txtClassID.Text = cls.ClassID.ToString();
                txtClassName.Text = cls.ClassName;
            }
            setting = false;
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if (txtTeacherID.Accepted && txtClassID.Accepted)
            {
                string teacherID = txtTeacherID.Text;
                int classID = UtilityTxt.GetInt(txtClassID.Text);

                ViwTeacherFinancialStatusBO status = ViwTeacherFinancialStatusBO.Find(classID, teacherID);

                //if (status != null)
                //{
                //    lblClassPrice.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
                //    lblPayed.Text = UtilityTxt.ToFarsiCurrency(status.StudentFinalPay.ToString());
                //    lblMustPay.Text = UtilityTxt.ToFarsiCurrency(status.StudentMustPay.ToString());
                //}

                ViwTeacherSessionStatusBO sessions = ViwTeacherSessionStatusBO.Find(classID);

                if (sessions != null)
                {
                    lblContinuousAbsence.Text = UtilityTxt.GetString(sessions.ContinuousAbseneceCount ?? 0);
                    lblHeld.Text = UtilityTxt.GetString(sessions.HeldCount ?? 0);
                    lblStudentAbsence.Text = UtilityTxt.GetString(sessions.StudentAbseneceCount ?? 0);
                    lblTeacherAbsence.Text = UtilityTxt.GetString(sessions.TeacherAbsenceCount ?? 0);
                    lblTotalSessions.Text = UtilityTxt.GetString(sessions.TotalDedicatedSessions ?? 0);
                    lblNotHeld.Text = UtilityTxt.GetString(sessions.WillHeldCount ?? 0);
                }

                DataGridFiller<ViwTeacherSessionDetailsBO>.FillDataGrid(dataGridSection, ViwTeacherSessionDetailsBO.List(null, classID, null, null, teacherID), new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    DatabaseSchema.ViwTeacherSessionDetails.ClassDate,
                    DatabaseSchema.ViwTeacherSessionDetails.TimeID,
                    DatabaseSchema.ViwTeacherSessionDetails.SessionStatus,
                    DatabaseSchema.ViwTeacherSessionDetails.StudentAbsence,
                    DatabaseSchema.ViwTeacherSessionDetails.TeacherAbsence,
                    DatabaseSchema.ViwTeacherSessionDetails.SuccessorTeacher,
                    DatabaseSchema.ViwTeacherSessionDetails.ContinuousAbsence,
                    DatabaseSchema.ViwTeacherFinancialStatus.IsSuccessorTeacher,
                });


                

                //ClassBO cls = ClassBO.Find(status.ClassID);
                int totalSessions = status.TeacherEachSessionPortion.Value * status.MustPaySessionCount;
                int eachSession = status.TeacherEachSessionPortion.Value;
                int teacherPayed = status.FinalPaidToTeacher.Value;
                int remaindMoney = teacherPayed;
                foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
                {
                    ViwTeacherSessionDetailsBO fDet = ((ViwTeacherSessionDetailsBO)row.Tag);
                    if (fDet.TeacherAbsence)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        continue;
                    }
                    remaindMoney -= eachSession;
                    if (remaindMoney >= 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        if (ClasssessionBO.Find(fDet.ClassID, fDet.ClassDate, fDet.TimeID).SessionStatus == (int)SessionStatus.SessionStatusType.WillHold)
                            row.DefaultCellStyle.BackColor = Color.White;
                        else
                            row.DefaultCellStyle.BackColor = Color.Plum;
                    }

                }
            }
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void floaterContainer_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowsSelected(CoolDataGrid.RowsSelectionEventArgs e)
        {
            GotoUpdateMode();
        }
    }
}
