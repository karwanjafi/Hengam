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
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmOutcomeManager : HengamWidgets.FormBaseTableEditor
    {
        public frmOutcomeManager()
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
                    Program.SetStatus(MessageCreator.Added("مشخصات یک هزینه "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات یک هزینه "));
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات یک هزینه "));
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
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات یک هزینه "), "", "حذف هزینه‌", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف هزینه‌...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات یک هزینه "));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این هزینه‌ نیستید. قبل از حذف باید تمامی اطلاعات این هزینه‌ از سیستم حذف شود.");
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
            if (tabMain.SelectedItem == tabOutcomeTypical)
                item = GetGUIOutcomeTypical();
            //if (tabMain.SelectedItem == tabOutcomeBuyStuff)
            //    item = GetGUIStoreBuy();
            if (tabMain.SelectedItem == tabOutcomeEmployee)
                item = GetGUIOutcomeEmployee();
            //if (tabMain.SelectedItem == tabOutcomeStudent)
            //    item = GetGUIOutcomeStudent();
            //if (tabMain.SelectedItem == tabOutcomeTeacher)
            //    item = GetGUIOutcomeTeacher();

            return item;
        }
        private IBusinessObject GetGUIKey()
        {
            IBusinessObject item = null;
            if (tabMain.SelectedItem == tabOutcomeTypical)
                item = GetGUIKeyOutcomeTypical();
            if (tabMain.SelectedItem == tabOutcomeBuyStuff)
                item = GetGUIKeyStoreBuy();
            if (tabMain.SelectedItem == tabOutcomeEmployee)
                item = GetGUIKeyOutcomeEmployee();
            if (tabMain.SelectedItem == tabOutcomeStudent)
                item = GetGUIKeyOutcomeStudent();
            if (tabMain.SelectedItem == tabOutcomeTeacher)
                item = GetGUIKeyOutcomeTeacher();

            return item;
        }
        private void SetTab(FATabStripItem tabItem)
        {
            foreach (FATabStripItem tab in tabMain.Items)
            {
                tab.Visible = false;
            }
            tabItem.Visible = true;
            tabMain.SelectedItem = tabItem;
        }

        private OutcomeTypicalBO GetGUIOutcomeTypical()
        {
            OutcomeTypicalBO guiItem = new OutcomeTypicalBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtPayID.Accepted)
                    DoNothing();//err.Add("کد پرداخت");
                else
                    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!cboOutcomeTypicalTypeID.Accepted)
                    err.Add("نوع هزینه‌ی ساده");
                else
                    guiItem.OutcomeTypicalTypeID = ComboFiller<OutcomeTypicalTypeBO>.GetFromCombo(cboOutcomeTypicalTypeID).OutcomeTypicalTypeID;

                if (!txtFee.Accepted)
                    err.Add("هزینه");
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

                if (!txtTag.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Tag = UtilityTxt.GetString(txtTag.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

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
        private OutcomeTypicalBO GetGUIKeyOutcomeTypical()
        {
            OutcomeTypicalBO guiItem = new OutcomeTypicalBO();
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
        private void SetGUIOutcomeTypical(OutcomeTypicalBO guiItem)
        {
            txtPayID.Text = guiItem.PayID.ToString();

            ComboFiller<OutcomeTypicalTypeBO>.SetCombo(cboOutcomeTypicalTypeID, Utility.GetObject<OutcomeTypicalTypeBO>(guiItem.OutcomeTypicalTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtTag.Text = guiItem.Tag;

            txtDescription.Text = guiItem.Description;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtCheckNumber.Text = guiItem.CheckNumber;

            SetTab(tabOutcomeTypical);

        }



        private OutcomeStoreBuyBO GetGUIStoreBuy()
        {
            OutcomeStoreBuyBO guiItem = new OutcomeStoreBuyBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد هزینه");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtFee.Accepted)
                    err.Add("fee");
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

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

                if (!cboPayTypeID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

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
        private OutcomeStoreBuyBO GetGUIKeyStoreBuy()
        {
            OutcomeStoreBuyBO guiItem = new OutcomeStoreBuyBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtPayID.Accepted)
                    err.Add("کد هزینه");
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
        private void SetGUIStoreBuy(OutcomeStoreBuyBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtStuffName.Text = guiItem.RelStuff.StuffName;

            txtStuffCount.Text = UtilityTxt.GetString(guiItem.RelStuff.StuffCount);

            txtDescription.Text = guiItem.Description;



            txtCheckNumber.Text = guiItem.CheckNumber;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            SetTab(tabOutcomeBuyStuff);

        }

        private OutcomeEmployeeBO GetGUIOutcomeEmployee()
        {
            OutcomeEmployeeBO guiItem = new OutcomeEmployeeBO();
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
            OutcomeEmployeeBO guiItem = new OutcomeEmployeeBO();
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

            SetTab(tabOutcomeEmployee);
        }

        private OutcomeStudentBO GetGUIOutcomeStudent()
        {
            OutcomeStudentBO guiItem = new OutcomeStudentBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجو");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

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

                if (!txtClassIDStudent.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassIDStudent.Text);

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
        private OutcomeStudentBO GetGUIKeyOutcomeStudent()
        {
            OutcomeStudentBO guiItem = new OutcomeStudentBO();
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
        private void SetGUIOutcomeStudent(OutcomeStudentBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtStudentID.Text = guiItem.StudentID;
            txtStudentName.Text = guiItem.RelStudent.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtClassIDStudent.Text = guiItem.ClassID.ToString();
            txtClassNameStudent.Text = guiItem.RelClass.ClassName;

            SetTab(tabOutcomeStudent);
        }

        private OutcomeTeacherBO GetGUIOutcomeTeacher()
        {
            OutcomeTeacherBO guiItem = new OutcomeTeacherBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtTeacherID.Accepted)
                    err.Add("کد استاد");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

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

                if (!txtClassIDTeacher.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassIDTeacher.Text);

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
        private OutcomeTeacherBO GetGUIKeyOutcomeTeacher()
        {
            OutcomeTeacherBO guiItem = new OutcomeTeacherBO();
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
        private void SetGUIOutcomeTeacher(OutcomeTeacherBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtTeacherID.Text = guiItem.TeacherID;
            txtTeacherName.Text = guiItem.RelTeacher.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtClassIDTeacher.Text = guiItem.ClassID.ToString();
            txtClassNameTeacher.Text = guiItem.RelClass.ClassName;

            SetTab(tabOutcomeTeacher);

        }

        public override void GotoAddMode()
        {
            base.GotoAddMode();
            txtPayID.Text = "";
            cboOutcomeTypicalTypeID.SelectedItem = null;
            txtFee.Text = "";
            txtDiscount.Text = "";
            txtTag.Text = "";
            txtDescription.Text = "";
            txtCheckDate.Text = "";
            txtPayDate.Text = FaDate.CurrentFaDateString;

            txtStuffCount.Text = "";
            txtStuffName.Text = "";

            txtPayID.Enabled = true;

            cboPayTypeID.SelectedItem = null;
            txtCheckNumber.Text = "";

            txtTeacherID.Text = txtTeacherName.Text = "";
            txtClassIDStudent.Text = txtClassNameStudent.Text = "";
            txtClassIDTeacher.Text = txtClassNameTeacher.Text = "";
            txtEmployeeID.Text = txtEmployeeName.Text = "";
            txtStudentID.Text = txtStudentName.Text = "";
            txtDateFrom.Text = txtDateTo.Text = "";

            foreach (FATabStripItem tab in tabMain.Items)
            {
                tab.Visible = true;
            }
            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtPayID.Enabled = false;

            foreach (FATabStripItem tab in tabMain.Items)
            {
                if (tab != tabMain.SelectedItem) tab.Visible = false;
            }

            //EditingState = FormState.Updating;
        }

        #endregion

        private void cboOutcomeTypicalTypeID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOutcomeManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن هزینه‌ی مشخص شده", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف هزینه‌ی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            //dataGridSection.RefreshDataGrid(); //hanieh

            ComboFiller<OutcomeTypicalTypeBO>.FillCombo(cboOutcomeTypicalTypeID, OutcomeTypicalTypeBO.List());
            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());

            Application.DoEvents();

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            frmEmployeePicker fEmployeePicker = new frmEmployeePicker();
            floaterEmployeePicker.LoadPanel(fEmployeePicker);
            fEmployeePicker.HookTo(txtEmployeeID, txtEmployeeName);

            //hanieh
            frmClassPicker fStudentClassPicker = new frmClassPicker();
            floaterStudentClassPicker.LoadPanel(fStudentClassPicker);
            fStudentClassPicker.HookTo(txtClassIDStudent, txtClassNameStudent);

            frmClassPicker fTeacherClassPicker = new frmClassPicker();
            floaterTeacherClassPicker.LoadPanel(fTeacherClassPicker);
            fTeacherClassPicker.HookTo(txtClassIDTeacher, txtClassNameTeacher);
            
            //
            
            HideMsg();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string dateFrom = null;
            string dateTo = null;
            if (txtFilterDateFrom.Accepted) dateFrom = txtFilterDateFrom.Text;
            if (txtFilterDateTo.Accepted) dateTo = txtFilterDateTo.Text;

            //hanieh
            List<ViwOutcomeOveralBO> list = new List<ViwOutcomeOveralBO>();//= ViwOutcomeOveralBO.List(null, dateFrom, dateTo, null, null, null);
            if (dateFrom == null && dateTo == null)
            {
                if (DataAccessNamespace.ViwOutcomeOveralDA.allViwOutcomeO.Count == 0)
                    DataAccessNamespace.ViwOutcomeOveralDA.allViwOutcomeO = ViwOutcomeOveralBO.List();

                list = DataAccessNamespace.ViwOutcomeOveralDA.allViwOutcomeO;
            }
            else
                list = ViwOutcomeOveralBO.List(null, dateFrom, dateTo, null, null, null);
            //


            DataGridFiller<ViwOutcomeOveralBO>.FillDataGrid(dataGridSection, list, new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwOutcomeOveral.PayName,
                DatabaseSchema.ViwOutcomeOveral.Fee,
                DatabaseSchema.ViwOutcomeOveral.PayDate,
                DatabaseSchema.ViwOutcomeOveral.Description
            });
            lblOutcomeSum.Text = UtilityTxt.ToFarsiCurrency(list.Sum(inc => (long)inc.Fee).ToString());
            lblOutcomeSum.ForeColor = Color.White;
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات هزینه");
            ViwOutcomeOveralBO obj = (ViwOutcomeOveralBO)e.Row.Tag;
            SetGUI(obj);
            HideMsg();
            GotoUpdateMode();
        }

        private void SetGUI(ViwOutcomeOveralBO obj)
        {
            switch ((OutcomeOveralTypeBO.OutcomeOveralType)obj.OutcomeOveralTypeID)
            {
                case OutcomeOveralTypeBO.OutcomeOveralType.Typical:
                    SetGUIOutcomeTypical(OutcomeTypicalBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.BuyStuff:
                    SetGUIStoreBuy(OutcomeStoreBuyBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Employee:
                    SetGUIOutcomeEmployee(OutcomeEmployeeBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Teacher:
                    SetGUIOutcomeTeacher(OutcomeTeacherBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Student:
                    SetGUIOutcomeStudent(OutcomeStudentBO.Find(obj.PayID));
                    break;

                default:
                    SetMsg("هزینه‌ی ناشناخته.");
                    break;
            }
        }

        private void txtTagName_Click(object sender, EventArgs e)
        {
            //if (FormState == FormEditingState.Adding)
            {
                switch ((OutcomeTypicalTypeBO.OutcomeTypicalType)(((OutcomeTypicalTypeBO)cboOutcomeTypicalTypeID.SelectedItem).OutcomeTypicalTypeID))
                {
                    case OutcomeTypicalTypeBO.OutcomeTypicalType.EmployeeSalary:
                        floaterEmployeePicker.Show();
                        break;

                    case OutcomeTypicalTypeBO.OutcomeTypicalType.Student:
                        floaterStudentPicker.Show();
                        break;

                    case OutcomeTypicalTypeBO.OutcomeTypicalType.TeacherSalary:
                        floaterTeacherPicker.Show();
                        break;

                    default:
                        break;
                }
            }
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtClassNameTeacher_Click(object sender, EventArgs e)
        {
            floaterTeacherClassPicker.Show();
        }

        private void txtEmployeeName_Click(object sender, EventArgs e)
        {
            floaterEmployeePicker.Show();
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtClassNameStudent_Click(object sender, EventArgs e)
        {
           
            floaterStudentClassPicker.Show();
        }

        private void txtFilterDateFrom_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }


    }
}
