using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Tools;
using Hengam.Tools;
using Hengam.ComboManager;
using FarsiMessageBox;
using DataGridFiller;
using DatabaseSchemaNamespace;
using StandardWidgets;

namespace Hengam.Forms.Store
{
    public partial class frmStoreStuffBuyManager : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmStoreStuffBuyManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            StoreStuffBO item = GetGUIStuff();
            if (item == null) return;
            OutcomeStoreBuyBO itemOutcome = GetGUIPay();
            if (itemOutcome == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (item.Add() && itemOutcome.Add())
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات کالایی به نام " + item.StuffName));
                    GotoAddMode();
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کالایی به نام " + item.StuffName));
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
            LoadDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            StoreStuffBO item = GetGUIStuff();
            if (item == null) return;
            OutcomeStoreBuyBO itemOutcome = GetGUIPay();
            if (itemOutcome == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (item.Update() && itemOutcome.Update())
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات کالایی به نام " + item.StuffName));
                    GotoAddMode();
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            LoadDataGrid();
        }

        private void ActionDelete(object seneder, EventArgs e)
        {
            StoreStuffBO item = GetGUIKey();
            if (item == null) return;
            OutcomeStoreBuyBO itemOutcome = GetGUIKeyPay();
            if (itemOutcome == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کالایی به نام " + item.StuffName), "", "حذف کالا", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف کالا...");
                    if (item.Delete() && itemOutcome.Delete())
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات کالایی به نام " + item.StuffName));
                        GotoAddMode();
                    }
                    else
                    {
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این کالا نیستید. قبل از حذف باید تمامی اطلاعات این کالا از سیستم حذف شود.");
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
                LoadDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        void LoadDataGrid()
        {
            dataGridSection.RefreshDataGrid();
        }




        void DoNothing()
        {
        }
        StoreStuffBO guiItem = new StoreStuffBO();
        private StoreStuffBO GetGUIStuff()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtStuffID.Accepted)
                    err.Add("کد کالا");
                else
                    guiItem.StuffID = UtilityTxt.GetString(txtStuffID.Text);

                if (!cboStuffTypeID.Accepted)
                    err.Add("نوع کالا");
                else
                    guiItem.StuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffTypeID).StuffTypeID;

                if (!txtStuffName.Accepted)
                    err.Add("نام کالا");
                else
                    guiItem.StuffName = UtilityTxt.GetString(txtStuffName.Text);

                if (!txtBuyDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BuyDate = UtilityTxt.GetString(txtBuyDate.Text);

                if (!txtStuffCount.Accepted)
                    err.Add("تعداد");
                else
                    guiItem.StuffCount = UtilityTxt.GetInt(txtStuffCount.Text);

                if (!txtUnitPrice.Accepted)
                    err.Add("قیمت هر واحد");
                else
                    guiItem.StuffPrice = UtilityTxt.GetInt(txtUnitPrice.Text);
                

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
        private StoreStuffBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtStuffID.Accepted)
                    err.Add("کد کالا");
                else
                    guiItem.StuffID = UtilityTxt.GetString(txtStuffID.Text);

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
        private void SetGUI(StoreStuffBO guiItem)
        {
            this.guiItem = guiItem;

            txtStuffID.Text = guiItem.StuffID;

            ComboFiller<StuffTypeBO>.SetCombo(cboStuffTypeID, Utility.GetObject<StuffTypeBO>(guiItem.StuffTypeID));

            txtStuffName.Text = guiItem.StuffName;

            txtBuyDate.Text = guiItem.BuyDate;

            txtStuffCount.Text = UtilityTxt.GetString(guiItem.StuffCount);

            txtUnitPrice.Text = guiItem.StuffPrice.ToString();

        }

        OutcomeStoreBuyBO guiItemPay = new OutcomeStoreBuyBO();
        private OutcomeStoreBuyBO GetGUIPay()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtStuffID.Accepted)
                    err.Add("کد کالا");
                else
                    guiItemPay.StuffID = UtilityTxt.GetString(txtStuffID.Text);

                if (!txtFee.Accepted)
                    err.Add("قیمت کل خرید");
                else
                    guiItemPay.Fee = UtilityTxt.GetInt(txtFee.Text);

                if (!txtDiscount.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.Discount = UtilityTxt.GetInt(txtDiscount.Text);

                if (!txtBuyDate.Accepted)
                    err.Add("تاریخ خرید");
                else
                    guiItemPay.PayDate = UtilityTxt.GetString(txtBuyDate.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    guiItemPay.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtCheckDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

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
            return guiItemPay;
        }

        private OutcomeStoreBuyBO GetGUIKeyPay()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {

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
            return guiItemPay;
        }

        private void SetGUIPay(OutcomeStoreBuyBO guiItem)
        {
            this.guiItemPay = guiItem;
            //txtPayID.Text = guiItem.PayID;

            txtStuffID.Text = guiItem.StuffID;

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            //txtPayDate.Text = guiItem.PayDate;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtCheckDate.Text = guiItem.CheckDate;

            txtDescription.Text = guiItem.Description;

            txtCheckNumber.Text = guiItem.CheckNumber;

        }

        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new StoreStuffBO();

            txtStuffID.Text = "";
            cboStuffTypeID.SelectedItem = null;
            txtStuffName.Text = "";
            txtStuffCount.Text = "1";
            txtBuyDate.Text = FaDate.CurrentFaDateString;
            txtUnitPrice.Text = "";

            txtFee.Text = "";
            txtDiscount.Text = "0";
            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, new PayTypeBO((int)PayTypeBO.PayType.Cash));
            txtDescription.Text = "";
            txtCheckNumber.Text = "";
            txtCheckDate.Text = "";

            txtStuffID.Enabled = true;

            guiItem.IsBalanced = false;
            guiItem.IsSalesPersonAware = false;
            guiItem.ActivityStatus = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtStuffID.Enabled = false;

            //EditingState = FormState.Updating;
        }

        private void cboStuffTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding)
            {
                if (cboStuffTypeID.SelectedItem == null) return;
                int stuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffTypeID).StuffTypeID;
                txtStuffID.Text = StoreStuffBO.GenerateKey(stuffTypeID);
                txtStuffName.Text = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffTypeID).StuffTypeName;
            }
        }

        frmStoreStuffDetailsAvailableViewer fStuffDetails = new frmStoreStuffDetailsAvailableViewer();
        private void frmStoreStuffTypeManager_LoadForm(object sender, EventArgs e)
        {
            AddButton("ثبت کالا", "Add", "اضافه کردن کالا به غرفه", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات در کالا", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف ثبت نام هنرجوی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<StuffTypeBO>.FillCombo(cboStuffTypeID, StuffTypeBO.List());
            ComboFiller<StuffTypeBO>.FillCombo(cboFilterStuffType, StuffTypeBO.List());
            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());

            floaterStoreStuffDetails.LoadPanel(fStuffDetails);
            
            GotoAddMode();
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI(StoreStuffBO.Find(((ViwStuffAvailableDetailsBO)e.Row.Tag).StuffID));
            List<OutcomeStoreBuyBO> list = OutcomeStoreBuyBO.List(((ViwStuffAvailableDetailsBO)e.Row.Tag).StuffID,null,null,null,null,null,null);
            if (list.Count > 0)
                SetGUIPay(list[0]);
            //floaterStoreStuffDetails.Show();
            GotoUpdateMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            int? stuffTypeID = null;

            if (cboFilterStuffType.SelectedItem != null)
                stuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboFilterStuffType).StuffTypeID;

            //if (stuffTypeID == null) return;

            DataGridFiller<ViwStuffAvailableDetailsBO>.FillDataGrid(dataGridSection, ViwStuffAvailableDetailsBO.List(stuffTypeID, null, null, null, null, null, null, null, null), new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                //DatabaseSchema.ViwStuffAvailableDetails.StuffID,
                DatabaseSchema.ViwStuffAvailableDetails.StuffName,
                DatabaseSchema.ViwStuffAvailableDetails.BuyDate,
                DatabaseSchema.ViwStuffAvailableDetails.InitCount,
                DatabaseSchema.ViwStuffAvailableDetails.SoldCount,
                DatabaseSchema.ViwStuffAvailableDetails.AvailableCount
            });
        }

        private void cboFilterStuffType_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }


        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

    }
}
