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
using Hengam.Reports.ReportForms;
using FarsiLibrary.Utils;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmIncomeManager : HengamWidgets.FormBaseTableEditor
    {
        public frmIncomeManager()
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

        private IBusinessObject GetGUI()
        {
            IBusinessObject item = null;
            if (tabMain.SelectedItem == tabIncomeTypical)
                item = GetGUITypicalIncome();
            //else if (tabMain.SelectedItem == tabIncomeSellStuff)
            //    item = GetGUISellStuff();
            //else if (tabMain.SelectedItem == tabIncomeStudentFee)
            //    item = GetGUIStudent();
            //else if (tabMain.SelectedItem == tabTeacherBalance)
            //    item = GetGUITeacher();

            return item;
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
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات یک هزینه "), "", "حذف درآمد", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف درآمد...");
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
                            MessageBoxEx.Show("شما قادر به حذف این درآمد نیستید. قبل از حذف باید تمامی اطلاعات این درآمد از سیستم حذف شود.");
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

        private IBusinessObject GetGUIKey()
        {
            IBusinessObject item = null;
            if (tabMain.SelectedItem == tabIncomeTypical)
                item = GetGUIKeyTypicalIncome();
            else if (tabMain.SelectedItem == tabIncomeSellStuff)
                item = GetGUIKeyBuyStuff();
            else if (tabMain.SelectedItem == tabIncomeStudentFee)
                item = GetGUIKeyStudent();
            else if (tabMain.SelectedItem == tabTeacherBalance)
                item = GetGUIKeyTeacher();
            return item;
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionPrint(object sender, EventArgs e)
        {
            if (txtFilterDateFrom.Accepted && txtFilterDateTo.Accepted)
            {
                SetMsg("در حال بازیابی");
                Form f = FormRequester.ReportIncomeInterval();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                frmReportIncomeInterval report = (frmReportIncomeInterval)f;

                report.SetReport(txtFilterDateFrom.Text, txtFilterDateTo.Text);
                //hanieh
                //Program.MainForm.AddForm(report);
                Program.AddForm(report);
                //-----------------
                HideMsg();
            }
            else
            {
                MessageBoxEx.Show("تاریخ ها برای گزارش گیری مشخص نشده‌اند.");
            }
        }

        private void DoNothing()
        {
        }

        #region Generated ApplicationLayer
        private IncomeTypicalBO GetGUITypicalIncome()
        {
            IncomeTypicalBO guiItem = new IncomeTypicalBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtPayID.Accepted)
                    DoNothing();//err.Add("کد هزینه");
                else
                {
                    int tmp;
                    if (int.TryParse(txtPayID.Text, out tmp)) guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);
                }

                if (!cboIncomeTypicalTypeID.Accepted)
                    err.Add("نوع درآمد");
                else
                    guiItem.IncomeTypicalTypeID = ComboFiller<IncomeTypicalTypeBO>.GetFromCombo(cboIncomeTypicalTypeID).IncomeTypicalTypeID;

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

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

                if (cboPayTypeID.Accepted)
                    guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;
                else
                {
                    err.Add("نحوه‌ی پرداخت");
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
            return guiItem;
        }


        private IncomeTypicalBO GetGUIKeyTypicalIncome()
        {
            IncomeTypicalBO guiItem = new IncomeTypicalBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtPayID.Accepted)
                    DoNothing();//err.Add("کد پرداخت");
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
        private void SetGUIWithTypicalIncome(IncomeTypicalBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            ComboFiller<IncomeTypicalTypeBO>.SetCombo(cboIncomeTypicalTypeID, Utility.GetObject<IncomeTypicalTypeBO>(guiItem.IncomeTypicalTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount.HasValue ? guiItem.Discount.Value : 0);


            //if (guiItem.IncomeTypicalTypeID == (int)IncomeTypicalTypeBO.IncomeTypicalType.StudentFee ||
            //    guiItem.IncomeTypicalTypeID == (int)IncomeTypicalTypeBO.IncomeTypicalType.StudentGift)
            //{
            txtTag.Text = guiItem.Tag;
            //}
            //else
            //{
            //    txtTagID.Text = "";
            //    txtTagName.Text = "";
            //}


            txtDescription.Text = guiItem.Description;

            txtPayDate.Text = UtilityTxt.GetString(guiItem.PayDate);
            txtCheckDate.Text = UtilityTxt.GetString(guiItem.CheckDate);

            txtCheckNumber.Text = guiItem.CheckNumber;

            SetTab(tabIncomeTypical);

            //tabIncomeTypical.Show();

        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            txtPayID.Text = "";
            cboIncomeTypicalTypeID.SelectedItem = null;
            txtFee.Text = "";
            txtDiscount.Text = "";
            txtTag.Text = "";
            txtDescription.Text = "";
            txtCheckDate.Text = "";
            txtPayDate.Text = FaDate.CurrentFaDateString;
            txtCheckNumber.Text = "";
            cboPayTypeID.SelectedItem = null;

            txtStuffCount.Text = "";
            txtStuffName.Text = "";

            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtClassIDStudent.Text = "";
            txtClassNameStudent.Text = "";

            txtPayID.Enabled = true;

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

        private void cboIncomeTypicalTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtTagID.Text = "";
            //txtTagName.Text = "";
            //if (cboIncomeTypicalTypeID.SelectedItem == null)
            //{
            //    groupTag.Visible = false;
            //    return;
            //}

            //switch ((IncomeTypicalTypeBO.IncomeTypicalType)(((IncomeTypicalTypeBO)cboIncomeTypicalTypeID.SelectedItem).IncomeTypicalTypeID))
            //{
            //    case IncomeTypicalTypeBO.IncomeTypicalType.StudentFee:
            //    case IncomeTypicalTypeBO.IncomeTypicalType.StudentGift:
            //        lblTagName.Text = "هنرجو:";
            //        groupTag.Visible = true;
            //        break;

            //    default:
            //        groupTag.Visible = false;
            //        break;
            //}
        }

        private void frmIncomeManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن درآمد مشخص شده", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف درآمد انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("چاپ", "Printer", "چاپ گزارش درآمد در بازه‌ی زمانی انتخاب شده", ActionPrint, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);

            txtDailyDate.Text = FaDate.CurrentFaDateString;

            dataGridSection.RefreshDataGrid();

            ComboFiller<IncomeTypicalTypeBO>.FillCombo(cboIncomeTypicalTypeID, IncomeTypicalTypeBO.List());
            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());
            Application.DoEvents();


            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            frmClassPicker fClassPicker = new frmClassPicker();
            floaterStudentClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassIDStudent, txtClassNameStudent);


            HideMsg();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string dateFrom = null;
            string dateTo = null;
            if ( txtFilterDateFrom.Accepted) dateFrom = txtFilterDateFrom.Text;
            if ( txtFilterDateTo.Accepted) dateTo = txtFilterDateTo.Text;

            //hanieh
            List<ViwIncomeOveralBO> list = new List<ViwIncomeOveralBO>(); // ViwIncomeOveralBO.List(null, dateFrom, dateTo, null, null);
            if (dateFrom == null && dateTo == null)
            {
                if (DataAccessNamespace.ViwIncomeOveralDA.allViwIncomeO.Count == 0)
                    DataAccessNamespace.ViwIncomeOveralDA.allViwIncomeO = ViwIncomeOveralBO.List();

                list = DataAccessNamespace.ViwIncomeOveralDA.allViwIncomeO;
            }
            else
                list = ViwIncomeOveralBO.List(null, dateFrom, dateTo, null, null);
            //

            
            DataGridFiller<ViwIncomeOveralBO>.FillDataGrid(dataGridSection, list, new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.ViwIncomeOveral.PayName,
                DatabaseSchema.ViwIncomeOveral.Fee,
                DatabaseSchema.ViwIncomeOveral.PayDate,
                DatabaseSchema.ViwIncomeOveral.CheckNumber,
                DatabaseSchema.ViwIncomeOveral.Description
            });
            lblIncomeSum.Text = UtilityTxt.ToFarsiCurrency( list.Sum(inc=>inc.Fee).ToString());
            lblIncomeSum.ForeColor = Color.White;

            ShowSuggestions();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات هزینه");
            ViwIncomeOveralBO obj = (ViwIncomeOveralBO)e.Row.Tag;
            SetGUI(obj);
            HideMsg();
            GotoUpdateMode();
        }

        private void SetGUI(ViwIncomeOveralBO obj)
        {
            switch ((IncomeOveralTypeBO.IncomeOveralType)obj.IncomeOveralTypeID)
            {
                case IncomeOveralTypeBO.IncomeOveralType.Typical:
                    SetGUIWithTypicalIncome(IncomeTypicalBO.Find(obj.PayID));
                    break;

                case IncomeOveralTypeBO.IncomeOveralType.SellStuff:
                    SetGUIStoreSell(IncomeStoreSellBO.Find(obj.PayID));
                    break;

                case IncomeOveralTypeBO.IncomeOveralType.StudentFee:
                    SetGUIStudent(IncomeStudentBO.Find(obj.PayID));
                    break;

                case IncomeOveralTypeBO.IncomeOveralType.TeacherBalance:
                    SetGUITeacher(IncomeTeacherBO.Find(obj.PayID));
                    break;

                default:
                    SetMsg("درآمد ناشناخته.");
                    break;
            }
        }



        //private IncomeStoreSellBO GetGUISellStuff()
        //{
        //    IncomeStoreSellBO guiItem = new IncomeStoreSellBO();
        //    ErrorCollector err = new ErrorCollector();
        //    try
        //    {
        //        if (!txtPayID.Accepted)
        //            DoNothing();//err.Add("کد هزینه");
        //        else
        //            guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

        //        if (!txtFee.Accepted)
        //            err.Add("");
        //        else
        //            guiItem.Fee = UtilityTxt.GetInt(txtFee.Text);

        //        if (!txtDiscount.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Discount = UtilityTxt.GetInt(txtDiscount.Text);

        //        if (!txtPayDate.Accepted)
        //            err.Add("تاریخ پرداخت");
        //        else
        //            guiItem.PayDate = UtilityTxt.GetString(txtPayDate.Text);

        //        if (!txtCheckDate.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

        //        if (!txtStuffName.Accepted)
        //            err.Add("بابت");
        //        else
        //            guiItem.StuffName = UtilityTxt.GetString(txtStuffName.Text);

        //        if (!txtStuffCount.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.StuffCount = UtilityTxt.GetInt(txtStuffCount.Text);

        //        if (!txtDescription.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

        //        if (!txtCheckNumber.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    if (err.HasError)
        //    {
        //        err.ShowErrMsg();
        //        return null;
        //    }
        //    return guiItem;
        //}
        private IncomeStoreSellBO GetGUIKeyBuyStuff()
        {
            IncomeStoreSellBO guiItem = new IncomeStoreSellBO();
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
        private void SetGUIStoreSell(IncomeStoreSellBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtStuffName.Text = guiItem.RelShop.RelStuff.StuffName;
            txtStuffCount.Text = guiItem.RelShop.ShopCount.ToString();
            txtCustomer.Text = guiItem.RelShop.FinalCustomerName;
            //txtStudentID.Text = guiItem.StudentID;

            //txtStudentName.Text = guiItem.RelStudent.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            tabMain.SelectedItem = tabIncomeSellStuff;

            SetTab(tabIncomeSellStuff);
        }


        //private IncomeStudentBO GetGUIStudent()
        //{
        //    IncomeStudentBO guiItem = new IncomeStudentBO();
        //    ErrorCollector err = new ErrorCollector();
        //    try
        //    {
        //        //if (!txtPayID.Accepted)
        //        //    err.Add("کد پرداخت");
        //        //else
        //        //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

        //        if (!txtStudentID.Accepted)
        //            err.Add("دانشجو");
        //        else
        //            guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

        //        if (!cboPayTypeID.Accepted)
        //            err.Add("نوع پرداخت");
        //        else
        //            guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

        //        if (!txtFee.Accepted)
        //            err.Add("مبلغ");
        //        else
        //            guiItem.Fee = UtilityTxt.GetInt(txtFee.Text);

        //        if (!txtDiscount.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Discount = UtilityTxt.GetInt(txtDiscount.Text);

        //        if (!txtPayDate.Accepted)
        //            err.Add("تاریخ پرداخت");
        //        else
        //            guiItem.PayDate = UtilityTxt.GetString(txtPayDate.Text);

        //        if (!txtCheckDate.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

        //        if (!txtCheckNumber.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

        //        if (!txtDescription.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

        //        if (!txtClassIDStudent.Accepted)
        //            err.Add("کلاس");
        //        else
        //            guiItem.ClassID = UtilityTxt.GetInt(txtClassIDStudent.Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    if (err.HasError)
        //    {
        //        err.ShowErrMsg();
        //        return null;
        //    }
        //    return guiItem;
        //}
        private IncomeStudentBO GetGUIKeyStudent()
        {
            IncomeStudentBO guiItem = new IncomeStudentBO();
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
        private void SetGUIStudent(IncomeStudentBO guiItem)
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

            txtClassIDStudent.Text = guiItem.ClassID.ToString();

            txtClassNameStudent.Text = guiItem.RelClass.ClassName;

            txtDescription.Text = guiItem.Description;

            tabMain.SelectedItem = tabIncomeStudentFee;

            SetTab(tabIncomeStudentFee);
        }
        //private IncomeTeacherBO GetGUITeacher()
        //{
        //    IncomeTeacherBO guiItem = new IncomeTeacherBO();
        //    ErrorCollector err = new ErrorCollector();
        //    try
        //    {
        //        //if (!txtPayID.Accepted)
        //        //    err.Add("کد پرداخت");
        //        //else
        //        //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

        //        if (!txtStudentID.Accepted)
        //            err.Add("استاد");
        //        else
        //            guiItem.TeacherID = UtilityTxt.GetString(txtTeace.Text);

        //        if (!cboPayTypeID.Accepted)
        //            err.Add("نوع پرداخت");
        //        else
        //            guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

        //        if (!txtFee.Accepted)
        //            err.Add("مبلغ");
        //        else
        //            guiItem.Fee = UtilityTxt.GetInt(txtFee.Text);

        //        if (!txtDiscount.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Discount = UtilityTxt.GetInt(txtDiscount.Text);

        //        if (!txtPayDate.Accepted)
        //            err.Add("تاریخ پرداخت");
        //        else
        //            guiItem.PayDate = UtilityTxt.GetString(txtPayDate.Text);

        //        if (!txtCheckDate.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

        //        if (!txtCheckNumber.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

        //        if (!txtDescription.Accepted)
        //            DoNothing();//Do Nothing...
        //        else
        //            guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

        //        if (!txtClassIDStudent.Accepted)
        //            err.Add("کلاس");
        //        else
        //            guiItem.ClassID = UtilityTxt.GetInt(txtClassIDStudent.Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    if (err.HasError)
        //    {
        //        err.ShowErrMsg();
        //        return null;
        //    }
        //    return guiItem;
        //}
        private IncomeTeacherBO GetGUIKeyTeacher()
        {
            IncomeTeacherBO guiItem = new IncomeTeacherBO();
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
        private void SetGUITeacher(IncomeTeacherBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            //txtTeacherName.Text = guiItem.StudentID;

            txtTeacherName.Text = guiItem.RelTeacher.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtClassIDStudent.Text = guiItem.ClassID.ToString();

            txtTeacherClassName.Text = guiItem.RelClass.ClassName;

            txtDescription.Text = guiItem.Description;

            tabMain.SelectedItem = tabTeacherBalance;

            SetTab(tabTeacherBalance);
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
            if(!setting)dataGridSection.RefreshDataGrid();
        }

        private void btnPreviousDay_Clicked(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                PersianDate date = new PersianDate(txtDailyDate.Text);
                txtDailyDate.Text = new PersianDate(pc.AddDays(date, -1)).ToString("yyyy/mm/dd");
            }
            catch (Exception) { }
        }

        private void btnNextDay_Clicked(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                PersianDate date = new PersianDate(txtDailyDate.Text);
                txtDailyDate.Text = new PersianDate(pc.AddDays(date, 1)).ToString("yyyy/mm/dd");
            }
            catch (Exception) { }
        }
        bool setting = false;
        private void txtDailyDate_TextAccepted(object sender, EventArgs e)
        {
            setting = true;
            txtFilterDateFrom.Text = txtFilterDateTo.Text = txtDailyDate.Text;
            setting = false;
            dataGridSection.RefreshDataGrid();
        }
    }
}
