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
    public partial class frmStoreStuffTypeManager : HengamWidgets.FormBaseTableEditor
    {
        public frmStoreStuffTypeManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            StoreStuffBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات کالایی به نام " + item.StuffName));
                    GotoAddMode();
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
            StoreStuffBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات کالایی به نام " + item.StuffName));
                    GotoAddMode();
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
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کالایی به نام " + item.StuffName), "", "حذف کالا", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف کالا...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات کالایی به نام " + item.StuffName));
                        GotoAddMode();
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

        private void ActionSalesTracking(object sender, EventArgs e)
        {
            string filterDateFrom = null;
            string filterDateTo = null;
            int? filterStuffTypeID = null;
            //bool? filterJustNotManagerValidates = null;

            //if (chkJustManagerShouldBeAware.Checked) filterJustNotManagerValidates = true;
            //if (txtFilterDateFrom.Accepted) filterDateFrom = txtFilterDateFrom.Text;
            //if (txtFilterDateTo.Accepted) filterDateTo = txtFilterDateTo.Text;
            //if (cboStuffTypeID.Accepted) filterStuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffTypeID).StuffTypeID;
            if (dataGridSection.DataGrid.SelectedRows.Count > 0) filterStuffTypeID = ((ViwStuffTypeAvailableDetailsBO)dataGridSection.DataGrid.SelectedRows[0].Tag).StuffTypeID;

            frmStoreSalesTracking fTrack = (frmStoreSalesTracking)FormRequester.StoreSalesTracking();
            if (fTrack == null)
                return;
            else
            {
                floaterContainter.LoadPanel(fTrack);
                fTrack.Set(filterDateFrom, filterDateTo, filterStuffTypeID);
                floaterContainter.Show();
            }
        }

        private void ActionStuffDetails(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0)
            {
                MessageBoxEx.Show("هیچ سطری برای مشاهده‌ی ریزخرید انتخاب نشده است.");
                return;
            }
            fStuffDetails.Set(StuffTypeBO.Find(((ViwStuffTypeAvailableDetailsBO)dataGridSection.DataGrid.SelectedRows[0].Tag).StuffTypeID));
            floaterStoreStuffDetails.Show();
        }
        
        private void ActionStuffBuy(object sender, EventArgs e)
        {
            //if (dataGridSection.DataGrid.SelectedRows.Count == 0)
            //{
            //    MessageBoxEx.Show("هیچ سطری برای مشاهده‌ی ریزخرید انتخاب نشده است.");
            //    return;
            //}
            Form f = FormRequester.StoreStuffBuyManager();
            if (f==null) 
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                return;
            }
            frmStoreStuffBuyManager fBuy = (frmStoreStuffBuyManager)f;
            floaterContainter.LoadPanel(fBuy);
            floaterContainter.Show();
 
        }

        void LoadDataGrid()
        {
            dataGridSection.RefreshDataGrid();
        }




        void DoNothing()
        {
        }
        StoreStuffBO guiItem = new StoreStuffBO();
        private StoreStuffBO GetGUI()
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

        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new StoreStuffBO();

            txtStuffID.Text = "";
            cboStuffTypeID.SelectedItem = null;
            txtStuffName.Text = "";
            txtStuffCount.Text = "1";

            txtStuffID.Enabled = true;

            guiItem = new StoreStuffBO();
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
                StuffTypeBO stuffObj = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffTypeID);
                int stuffTypeID = stuffObj.StuffTypeID;
                txtStuffID.Text = StoreStuffBO.GenerateKey(stuffTypeID);
                txtStuffName.Text = stuffObj.StuffTypeName;
            }
        }

        frmStoreStuffDetailsAvailableViewer fStuffDetails = new frmStoreStuffDetailsAvailableViewer();
        private void frmStoreStuffTypeManager_LoadForm(object sender, EventArgs e)
        {
            //AddButton("ثبت خرید", "Add", "اضافه کردن کالا به غرفه", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            //AddButton("ثبت", "Update", "اعمال تغییرات در کالا", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            //AddButton("حذف", "Delete", "حذف ثبت نام هنرجوی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            //AddButton("پاک کردن", "Cancel", "پاک کردن تمامی فلیدها و آماده سازی برای ورود اطلاعات خرید جدید", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            if (Program.User.CanStoreStuffAvailableViewer)
                AddButton("ریز خرید", "CheckItems", "نمایش لیست ریز خرید کالا", ActionStuffDetails, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            if (Program.User.CanStoreSalesTracking)
                AddButton("رهگیری", "StuffTracking", " رهگیری خرید و فروش کالاها", ActionSalesTracking, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            if (Program.User.CanStoreStuffBuyManager)
                AddButton("خرید جدید", "StuffTracking", " خرید کالای جدید برای غرفه", ActionStuffBuy, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            ComboFiller<StuffTypeBO>.FillCombo(cboStuffTypeID, StuffTypeBO.List());

            floaterStoreStuffDetails.LoadPanel(fStuffDetails);
            
            GotoAddMode();
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            //ActionStuffDetails(null, null);
            ShowSuggestions();
        }

        

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<ViwStuffTypeAvailableDetailsBO>.FillDataGrid(dataGridSection, ViwStuffTypeAvailableDetailsBO.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.ViwStuffTypeAvailableDetails.StuffTypeName,
                DatabaseSchema.ViwStuffTypeAvailableDetails.InitCount,
                DatabaseSchema.ViwStuffTypeAvailableDetails.SoldCount,
                DatabaseSchema.ViwStuffTypeAvailableDetails.AvailableCount
            });
        }

        private void floaterContainter_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

    }
}
