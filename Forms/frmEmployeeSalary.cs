using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Tools;
using Hengam.ComboManager;
using Hengam.Tools;
using DataGridFiller;
using DatabaseSchemaNamespace;
using FarsiMessageBox;
using Hengam.Forms.ItemPickers;
using FarsiLibrary.Win;
using System.Linq;
using FarsiLibrary.Utils;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmEmployeeSalary : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmEmployeeSalary()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            IBusinessObject item = GetGUI();

            if (item == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!item.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات یک حقوق "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات یک حقوق "));
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
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            IBusinessObject item = GetGUI();

            if (item == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!item.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات یک حقوق "));
                    GotoAddMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionDelete(object seneder, EventArgs e)
        {
            IBusinessObject item = GetGUIKey();

            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات یک حقوق "), "", "حذف حقوق‌", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف حقوق‌...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات یک حقوق "));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این حقوق‌ نیستید. قبل از حذف باید تمامی اطلاعات این حقوق‌ از سیستم حذف شود.");
                            break;

                        default:
                            MessageBox.Show("Error " + se.Number.ToString() + ",\n" + se.Message);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                HideMsg();
                dataGridSection.RefreshDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void DoNothing()
        {
        }

        #region Generated ApplicationLayer
        private IBusinessObject GetGUI()
        {
            IBusinessObject item = null;
            //if (tabMain.SelectedItem == tabOutcomeEmployee)
                item = GetGUIOutcomeEmployee();

            return item;
        }
        private IBusinessObject GetGUIKey()
        {
            IBusinessObject item = null;
            //if (tabMain.SelectedItem == tabOutcomeEmployee)
                item = GetGUIKeyOutcomeEmployee();

            return item;
        }
        
        OutcomeEmployeeBO guiItem = new OutcomeEmployeeBO();
        private OutcomeEmployeeBO GetGUIOutcomeEmployee()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtEmployeeID.Accepted)
                    err.Add("کارمند");
                else
                    guiItem.EmployeeID = UtilityTxt.GetString(txtEmployeeID.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtFee.Accepted)
                    err.Add("مبلغ");
                else
                    guiItem.Fee = UtilityTxt.GetInt(txtFee.Text);

                if (!txtDiscount.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Discount = UtilityTxt.GetInt(txtDiscount.Text);

                if (!txtPayDate.Accepted)
                    err.Add("تاریخ پرداخت");
                else
                    guiItem.PayDate = UtilityTxt.GetString(txtPayDate.Text);

                if (!txtCheckDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!txtDateFrom.Accepted)
                    err.Add("از تاریخ");
                else
                    guiItem.DateFrom = UtilityTxt.GetString(txtDateFrom.Text);

                if (!txtDateTo.Accepted)
                    err.Add("تا تاریخ:");
                else
                    guiItem.DateTo = UtilityTxt.GetString(txtDateTo.Text);

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
            return guiItem;
        }
        private OutcomeEmployeeBO GetGUIKeyOutcomeEmployee()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtPayID.Accepted)
                    err.Add("کد پرداخت");
                else
                    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

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
            return guiItem;
        }
        private void SetGUIOutcomeEmployee(OutcomeEmployeeBO guiItem)
        {
            this.guiItem = guiItem;
            
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtEmployeeID.Text = guiItem.EmployeeID;
            txtEmployeeName.Text = guiItem.RelEmployee.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtDateFrom.Text = guiItem.DateFrom;

            txtDateTo.Text = guiItem.DateTo;

            
        }

        public override void GotoAddMode()
        {
            base.GotoAddMode();
            txtPayID.Text = "";
            txtFee.Text = "";
            txtDiscount.Text = "";
            txtDescription.Text = "";
            txtCheckDate.Text = "";
            txtPayDate.Text = FaDate.CurrentFaDateString;


            txtPayID.Enabled = true;

            //cboPayTypeID.SelectedItem = null;
            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, PayTypeBO.Find((int)PayTypeBO.PayType.Cash));
            txtCheckNumber.Text = "";

            //txtEmployeeID.Text = txtEmployeeName.Text = "";
            txtDateTo.Text = FaDate.CurrentFaDateString;
            PersianCalendar pc = new PersianCalendar();
            txtDateFrom.Text  = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate( pc.AddMonths(FaDate.Now, -1)).ToString("0000/00/00");
            
            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtPayID.Enabled = false;

            //EditingState = FormState.Updating;
        }

        #endregion

        private void cboOutcomeTypicalTypeID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOutcomeManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن حقوق‌ی مشخص شده", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف حقوق‌ی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            dataGridSection.RefreshDataGrid();

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());

            Application.DoEvents();

            frmEmployeePicker fEmployeePicker = new frmEmployeePicker();
            floaterEmployeePicker.LoadPanel(fEmployeePicker);
            fEmployeePicker.HookTo(txtEmployeeID, txtEmployeeName);



            HideMsg();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string employeeID = null;
            string dateFrom = null;
            string dateTo = null;

            if (!txtEmployeeID.Accepted) return;
            employeeID = txtEmployeeID.Text;

            if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
            if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;

            List<ViwEmployeeSalaryDetailsBO> list = ViwEmployeeSalaryDetailsBO.List(employeeID, null, null, null, null, null, null, null, null, null, null, null, null, null);
            //List<ViwOutcomeOveralBO> list = ViwOutcomeOveralBO.List((int)OutcomeOveralTypeBO.OutcomeOveralType.Employee, null, null, null, null);
            DataGridFiller<ViwEmployeeSalaryDetailsBO>.FillDataGrid(dataGridSection, list, new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwEmployeeSalaryDetails.DateFrom,
                DatabaseSchema.ViwEmployeeSalaryDetails.DateTo,
                DatabaseSchema.ViwEmployeeSalaryDetails.Fee,
                DatabaseSchema.ViwEmployeeSalaryDetails.PayDate
            });
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات حقوق");
            ViwEmployeeSalaryDetailsBO obj = (ViwEmployeeSalaryDetailsBO)e.Row.Tag;
            SetGUIOutcomeEmployee(OutcomeEmployeeBO.Find(obj.PayID));
            HideMsg();
            GotoUpdateMode();
        }

        public void Set(EmployeeBO employee)
        {
            txtEmployeeID.Text = employee.EmployeeID;
            txtEmployeeName.Text = employee.FullName;
        }

        private void txtEmployeeName_Click(object sender, EventArgs e)
        {
            floaterEmployeePicker.Show();
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.Accepted) dataGridSection.RefreshDataGrid();
        }


        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            set;
            get;
        }

        #endregion

    }
}
