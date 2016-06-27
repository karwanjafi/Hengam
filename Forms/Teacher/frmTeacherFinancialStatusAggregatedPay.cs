using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hengam.ComboManager;
using Hengam.Forms.ItemPickers;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Hengam.Reports.ReportForms;
using Tools;
using Hengam.Tools;
using FarsiMessageBox;
using Hengam.Forms.Teacher;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmTeacherFinancialStatusAggregatePay : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmTeacherFinancialStatusAggregatePay()
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

        public void Set(TeacherBO teacher)
        {
            if (teacher != null)
            {
                txtTeacherName.Text = teacher.FullName;
                txtTeacherID.Text = teacher.TeacherID;
                dataGridSection.RefreshDataGrid();
            }
        }
        
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
                AddButton("جزئیات مالی", "Money", "مشاهده‌ی جزئیات مالی و ریز دریافت‌ها", ActionFinancialDetails, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanTeacherSessionDetails)
                AddButton("جلسه به جلسه", "Session", "مشاهده‌ی جلسات تشکیل شده و وضعیت آن‌ها", ActionSessionDetails, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanTeacherPayForClass)
                AddButton("پرداخت حقوق", "MoneyMoney", "پرداخت حقوق استاد بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());
            txtPayDate.Text = FaDate.Now.ToString();
            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            dataGridSection.dgvDataGrid.CellValueChanged += new DataGridViewCellEventHandler(dgvDataGrid_CellValueChanged);
        }

        void dgvDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ReSumTotalFee();
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
            var list = ViwTeacherFinancialStatusBO.List(null, null, txtTeacherID.Text, activitySelector.ActivityStatus);
            var filteredList = (from item in list
                               where item.MustPayToTeacherAmount > 0
                               select item).ToList();
            DataGridFiller<ViwTeacherFinancialStatusBO>.FillDataGrid(dataGridSection, filteredList, new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwTeacherFinancialStatus.ClassID,
                DatabaseSchema.ViwTeacherFinancialStatus.ClassName,
                DatabaseSchema.ViwTeacherFinancialStatus.ClassRegisterationDate,
                DatabaseSchema.ViwStudentFinancialStatus.FinancialStatus,
                DatabaseSchema.ViwTeacherFinancialStatus.IsSuccessorTeacher,
                DatabaseSchema.ViwTeacherFinancialStatus.PayableAmount
                //DatabaseSchema.ViwStudentFinancialStatus.ClassTotalPrice,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentPayedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.BalancedAmount,
                //DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay
            });
            ReSumTotalFee();
            txtPayDate.Text = FaDate.Now.ToString();
            dataGridSection.dgvDataGrid.ReadOnly = false;
            dataGridSection.dgvDataGrid.Columns[DatabaseSchema.ViwTeacherFinancialStatus.PayableAmount.Name].ReadOnly = false;
        }

        public int GetSelectedAmount(DataGridViewRow row)
        {
            try
            {
                var x = int.Parse(row.Cells[DatabaseSchema.ViwTeacherFinancialStatus.PayableAmount.Name].Value.ToString());
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void ReSumTotalFee()
        {
            var sum = 0;
            foreach (var row in dataGridSection.dgvDataGrid.Rows)
            {
                var selected = GetSelectedAmount((DataGridViewRow) row);
                sum += selected;
            }
            txtFee.Text = sum.ToString();
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

        public PanelFloater ContainerFloater
        {
            get; set;
        }

        private void DoNothing()
        {
            
        }

        private List<OutcomeTeacherBO> GetGUIOutcomeTeacher()
        {
            OutcomeTeacherBO typicalTeacherOutcome = new OutcomeTeacherBO();
            ErrorCollector err = new ErrorCollector();
            var resultList = new List<OutcomeTeacherBO>();

            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtTeacherID.Accepted)
                    err.Add("شماره‌ی هنرجو");
                else
                    typicalTeacherOutcome.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    typicalTeacherOutcome.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtFee.Accepted)
                    err.Add("مبلغ");
                else
                    typicalTeacherOutcome.Fee = UtilityTxt.GetInt(txtFee.Text);

                if (!txtDiscount.Accepted)
                    DoNothing();//Do Nothing...
                else
                    typicalTeacherOutcome.Discount = UtilityTxt.GetInt(txtDiscount.Text);

                if (!txtPayDate.Accepted)
                    err.Add("تاریخ پرداخت");
                else
                    typicalTeacherOutcome.PayDate = UtilityTxt.GetString(txtPayDate.Text);

                if (!txtCheckDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    typicalTeacherOutcome.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    typicalTeacherOutcome.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    typicalTeacherOutcome.Description = UtilityTxt.GetString(txtDescription.Text);

                

                if (dataGridSection.dgvDataGrid.Rows.Count == 0)
                    err.Add("تعدادی کلاس");
                else
                {
                    var groupPayID = Guid.NewGuid().ToString();
                    foreach (var row in dataGridSection.dgvDataGrid.Rows)
                    {
                        var selectedClass = ((ViwTeacherFinancialStatusBO)((DataGridViewRow)row).Tag);
                        var copyOutcome = new OutcomeTeacherBO(typicalTeacherOutcome);
                        copyOutcome.ClassID = selectedClass.ClassID;
                        copyOutcome.GroupPayID = groupPayID;
                        copyOutcome.Fee = GetSelectedAmount((DataGridViewRow) row);
                        resultList.Add(copyOutcome);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (err.HasError)
            {
                err.ShowErrMsg();
                return null;
            }
            return resultList;
        }


        private void btnPay_Clicked(object sender, EventArgs e)
        {
            List<OutcomeTeacherBO> outcomes = GetGUIOutcomeTeacher();

            if (outcomes == null) return;
            try
            {
                SetMsg("در حال پرداخت حقوق");
                if (!outcomes.All(outcome=>outcome.Add()))
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات حقوق "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات حقوق "));
                        break;
                    case 8152:// Dont Remember? 
                        MessageBoxEx.Show("اطلاعات فرم صحیح نمی‌باشد، لطفاً دوباره بررسی کنید" + ".");
                        break;

                    default:
                        MessageBox.Show(se.Number.ToString() + ", \n" + se.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
            SetMsg("در حال بررسی اطلاعات...");
            OutcomeTeacherBO income = outcomes[0];
            Form f = FormRequester.ReportTeacherPayFactor();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                HideMsg();
                return;
            }
            frmReportTeacherPayFactor factor = (frmReportTeacherPayFactor)f;
            //Program.MainForm.RunForm(factor);
            floaterContainer.LoadPanel(factor);
            factor.SetFactor(income.GroupPayID);
            floaterContainer.Show();
            HideMsg();

        }
    }
}
