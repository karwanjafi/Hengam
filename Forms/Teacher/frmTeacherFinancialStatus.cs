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
using Hengam.Forms.Teacher;

namespace Hengam.Forms
{
    public partial class frmTeacherFinancialStatus : HengamWidgets.FormBaseTableEditor
    {
        public frmTeacherFinancialStatus()
        {
            InitializeComponent();
        }

        //private void ActionFinancialDetails(object sender, EventArgs e)
        //{
        //    if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
        //    ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
        //    int classID = status.ClassID;

        //    if (txtTeacherID.Accepted)
        //    {
        //        SetMsg("در حال بازیابی اطلاعات...");
        //        Form f = FormRequester.StudentFinancialDetails();
        //        if (f == null)
        //        {
        //            MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
        //            HideMsg();
        //            return;
        //        }
        //        else
        //        {
        //            frmStudentFinancialDetails fDetails = (frmStudentFinancialDetails)f;
        //            fDetails.Set(StudentBO.Find(txtTeacherID.Text), ClassBO.Find(classID));
        //            floaterContainer.LoadPanel(fDetails);
        //            floaterContainer.Show();
        //        }
        //        HideMsg();
        //    }
        //}

        private void ActionFinancialDetails(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwTeacherFinancialStatusBO status = (ViwTeacherFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;

            if (txtTeacherID.Accepted)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.TeacherFinancialDetails();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    frmTeacherFinancialDetails fDetails = (frmTeacherFinancialDetails)f;
                    fDetails.Set(TeacherBO.Find(txtTeacherID.Text), ClassBO.Find(classID));
                    floaterContainer.LoadPanel(fDetails);
                    floaterContainer.Show();
                }
                HideMsg();
            }
        }

        private void ActionAggregatedPay(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            var status = (ViwTeacherFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;

            if (txtTeacherID.Accepted)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.TeacherAggregatedPay();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    var fDetails = (frmTeacherFinancialStatusAggregatePay)f;
                    fDetails.Set(TeacherBO.Find(txtTeacherID.Text));
                    floaterContainer.LoadPanel(fDetails);
                    floaterContainer.Show();
                }
                HideMsg();
            }
        }

        private void ActionSessionDetails(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwTeacherFinancialStatusBO status = (ViwTeacherFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;

            if (txtTeacherID.Accepted)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.TeacherSessionDetails();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    frmTeacherSessionDetails fDetails = (frmTeacherSessionDetails)f;
                    fDetails.Set(TeacherBO.Find(txtTeacherID.Text), ClassBO.Find(classID));
                    floaterContainer.LoadPanel(fDetails);
                    floaterContainer.Show();
                }
                HideMsg();
            }
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            ViwTeacherFinancialStatusBO status = (ViwTeacherFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;
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

        private void frmStudentFinancialStatus_LoadForm(object sender, EventArgs e)
        {
            //AddButton("جزئیات مالی", "Money", "مشاهده‌ی جزئیات مالی و ریز حقوق", ActionFinancialDetails, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanTeacherFinancialDetails)
                AddButton("جزئیات مالی", "Money", "مشاهده‌ی جزئیات مالی و ریز دریافت‌ها", ActionFinancialDetails, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanTeacherSessionDetails)
                AddButton("جلسه به جلسه", "Session", "مشاهده‌ی جلسات تشکیل شده و وضعیت آن‌ها", ActionSessionDetails, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanTeacherPayForClass)
                AddButton("پرداخت حقوق", "MoneyMoney", "پرداخت حقوق استاد بابت این کلاس", ActionPay, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            if (Program.User.CanTeacherPayForClass)
                AddButton("پرداخت همه", "MoneyMoney", "پرداخت حقوق استاد بابت تمام کلاس‌ها", ActionAggregatedPay, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            if (Program.User.CanTeacherPayForClass)
                AddButton("پرداخت همه", "MoneyMoney", "پرداخت حقوق استاد بابت تمام کلاس‌ها", ActionAggregatedPay, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtTacherName_TextAccepted(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<ViwTeacherFinancialStatusBO>.FillDataGrid(dataGridSection, ViwTeacherFinancialStatusBO.List(null, null, txtTeacherID.Text, activitySelector.ActivityStatus), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwTeacherFinancialStatus.ClassID,
                DatabaseSchema.ViwTeacherFinancialStatus.ClassName,
                DatabaseSchema.ViwTeacherFinancialStatus.ClassRegisterationDate,
                DatabaseSchema.ViwStudentFinancialStatus.FinancialStatus,
                DatabaseSchema.ViwTeacherFinancialStatus.IsSuccessorTeacher
                //DatabaseSchema.ViwStudentFinancialStatus.ClassTotalPrice,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentPayedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.BalancedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay
            });
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            ViwTeacherFinancialStatusBO status = (ViwTeacherFinancialStatusBO)(e.Row.Tag);
            if (status == null) return;

            lblClassTotalFee.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
            lblHavePaid.Text = UtilityTxt.ToFarsiCurrency(status.PaidToTeacher.ToString());
            if (status.MustPayToTeacherAmount == 0)
                lblMustPay.Text = "بی حساب";
            else
                lblMustPay.Text = "استاد " + UtilityTxt.ToFarsiCurrency(Math.Abs(status.MustPayToTeacherAmount).ToString()) + " "
                    + (status.MustPayToTeacherAmount < 0 ? "بدهکار" : "طلبکار") + " است.";
            //lblBalancedAmount.Text = UtilityTxt.ToFarsiCurrency(status.GotFromTeacherBalance.ToString());
            //lblReturnedForTeacherAmount.Text = UtilityTxt.ToFarsiCurrency(status.ReturnMoneyForTeacherAbsentAmount.ToString());

            lblEachSessionAmount.Text = UtilityTxt.ToFarsiCurrency(status.TeacherEachSessionPortion.ToString());
            lblHeldSessionsAmount.Text = UtilityTxt.ToFarsiCurrency((status.TeacherEachSessionPortion * status.MustPaySessionCount).Value.ToString());
            lblTeacherPortion.Text = UtilityTxt.ToFarsiCurrency(status.TeacherTotalPortion.ToString());
            
            
            ClassBO cls = ClassBO.Find(status.ClassID);
            if (cls != null && cls.IsBalancedFinalWithTeacher) lblMustPay.Text += " - " + "تسویه شده";

            ViwTeacherSessionStatusBO sessions = ViwTeacherSessionStatusBO.Find(status.ClassID);

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
