using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemPickers;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Tools;
using Hengam.Tools;
using FarsiMessageBox;
using StandardWidgets;


namespace Hengam.Forms.Student
{
    public partial class frmStudentFinancialStatus : HengamWidgets.FormBaseTableEditor
    {
        public frmStudentFinancialStatus()
        {
            InitializeComponent();
        }

        private void ActionFinancialDetails(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;

            if (txtStudentID.Accepted)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.StudentFinancialDetails();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    frmStudentFinancialDetails fDetails = (frmStudentFinancialDetails)f;
                    fDetails.Set(StudentBO.Find(txtStudentID.Text), ClassBO.Find(classID));
                    floaterContainer.LoadPanel(fDetails);
                    floaterContainer.Show();
                }
                HideMsg();
            }
        }

        private void ActionSessionDetails(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;

            if (txtStudentID.Accepted)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.StudentSessionDetails();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    frmStudentSessionDetails fDetails = (frmStudentSessionDetails)f;
                    fDetails.Set(StudentBO.Find(txtStudentID.Text), ClassBO.Find(classID));
                    floaterContainer.LoadPanel(fDetails);
                    floaterContainer.Show();
                }
                HideMsg();
            }
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;
            if (txtStudentID.Accepted)
            {
                Form f = FormRequester.StudentPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmStudentPayForClass fPay = (frmStudentPayForClass)f;
                    fPay.Set(ClassBO.Find(classID), StudentBO.Find(txtStudentID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void frmStudentFinancialStatus_LoadForm(object sender, EventArgs e)
        {
            if(Program.User.CanStudentFinancialDetails)
                AddButton("جزئیات مالی", "Money", "مشاهده‌ی جزئیات مالی و ریز دریافت‌ها", ActionFinancialDetails, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanStudentSessionDetails)
                AddButton("جلسه به جلسه", "Session", "مشاهده‌ی جلسات تشکیل شده و وضعیت آن‌ها", ActionSessionDetails, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanStudentPayForClass)
                AddButton("دریافت شهریه", "MoneyMoney", "دریافت شهریه از هنرجو بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            
            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtStudentID_TextAccepted(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<ViwStudentFinancialStatusBO>.FillDataGrid(dataGridSection, ViwStudentFinancialStatusBO.List(null, txtStudentID.Text, activitySelector.ActivityStatus), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwStudentFinancialStatus.ClassID,
                DatabaseSchema.ViwStudentFinancialStatus.ClassName,
                DatabaseSchema.ViwStudentFinancialStatus.ClassRegisterationDate,
                DatabaseSchema.ViwStudentFinancialStatus.FinancialStatus
                //DatabaseSchema.ViwStudentFinancialStatus.ClassTotalPrice,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentPayedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.BalancedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay
            });
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(e.Row.Tag);
            if (status == null) return;

            lblClassPrice.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
            lblPayed.Text = UtilityTxt.ToFarsiCurrency(status.StudentPayedAmount.ToString());
            if (status.StudentMustPay == 0)
                lblMustPay.Text = "بی حساب";
            else
                lblMustPay.Text = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(status.StudentMustPay).ToString()) + " "
                    + (status.StudentMustPay > 0 ? "بدهکار" : "طلبکار") + " است.";
            lblBalancedAmount.Text = UtilityTxt.ToFarsiCurrency(status.BalancedAmount.ToString());
            lblReturnedForTeacherAmount.Text = UtilityTxt.ToFarsiCurrency(status.ReturnMoneyForTeacherAbsentAmount.ToString());

            RegistrationBO reg = RegistrationBO.Find(status.ClassID, status.StudentID);
            if (reg != null && reg.IsBalancedFinalWithStudent) lblMustPay.Text += " - " + "تسویه شده";
            
            ViwStudentSessionStatusBO sessions = ViwStudentSessionStatusBO.Find(status.StudentID,status.ClassID);

            if (sessions != null)
            {
                lblContinuousAbsence.Text = UtilityTxt.GetString(sessions.ContinuousAbseneceCount ?? 0);
                lblHeld.Text = UtilityTxt.GetString(sessions.HeldCount ?? 0);
                lblStudentAbsence.Text = UtilityTxt.GetString(sessions.StudentAbseneceCount ?? 0);
                lblTeacherAbsence.Text = UtilityTxt.GetString(sessions.TeacherAbsenceCount ?? 0);
                lblTotalSessions.Text = UtilityTxt.GetString(sessions.TotalDedicatedSessions ?? 0);
                lblNotHeld.Text = UtilityTxt.GetString(sessions.WillHeldCount ?? 0);
            }
            GotoUpdateMode();
        }

        private void floaterContainer_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }
    }
}
