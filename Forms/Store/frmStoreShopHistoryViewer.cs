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
using Hengam.ComboManager;
using Tools;
using Hengam.Tools;
using FarsiMessageBox;
using StandardWidgets;

namespace Hengam.Forms.Store
{
    public partial class frmStoreShopHistoryViewer : HengamWidgets.FormBaseTableEditor
    {
        public frmStoreShopHistoryViewer()
        {
            InitializeComponent();
        }

        private void ActionSalesTracking(object sender, EventArgs e)
        {
            string filterDateFrom = null;
            string filterDateTo = null;
            int? filterStuffTypeID = null;
            //bool? filterJustNotManagerValidates = null;

            //if (chkJustManagerShouldBeAware.Checked) filterJustNotManagerValidates = true;
            if (txtFilterDateFrom.Accepted) filterDateFrom = txtFilterDateFrom.Text;
            if (txtFilterDateTo.Accepted) filterDateTo = txtFilterDateTo.Text;
            if (cboFilterStuffTypeID.Accepted) filterStuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboFilterStuffTypeID).StuffTypeID;

            frmStoreSalesTracking fTrack = (frmStoreSalesTracking)FormRequester.StoreSalesTracking();
            if (fTrack == null)
                return;
            else
            {
                Program.MainForm.RunForm(fTrack);
                fTrack.Set(filterDateFrom, filterDateTo, filterStuffTypeID);
            }
        }

        private void ActionManagerNotAwared(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSection.DataGrid.SelectedRows;
            if (rows.Count == 0)
                MessageBoxEx.Show("هیچ فروشی برای حذف تائید انتخاب نشده است.");

            if (MessageBoxEx.Show("شما در حال حذف تائید اطلاعات مربوط به " + rows.Count + " فروش هستید. آیا مطمئنید؟", "", "حذف تائید اطلاعات فروش", true) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in rows)
                {
                    StoreShopBO shop = StoreShopBO.Find(((ViwStoreSalesHistoryBO)row.Tag).ShopID);
                    SetMsg("در حال حذف تائید فروش '" + shop.RelStuff.StuffName + "' به '" + shop.FinalCustomerName + "'");
                    shop.SetManagerAware(false);
                    HideMsg();
                }
            }
            dataGridSection.RefreshDataGrid();
        }

        private void ActionManagerAwared(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSection.DataGrid.SelectedRows;
            if (rows.Count == 0)
                MessageBoxEx.Show("هیچ فروشی برای تائید انتخاب نشده است.");

            if (MessageBoxEx.Show("شما در حال تائید اطلاعات مربوط به " + rows.Count + " فروش هستید. آیا مطمئنید؟", "", "تائید اطلاعات فروش", true) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in rows)
                {
                    StoreShopBO shop = StoreShopBO.Find(((ViwStoreSalesHistoryBO)row.Tag).ShopID);
                    SetMsg("در حال تائید فروش '" + shop.RelStuff.StuffName + "' به '" + shop.FinalCustomerName + "'");
                    shop.SetManagerAware(true);
                    HideMsg();
                }
            }
            dataGridSection.RefreshDataGrid();
        }


        private void frmStoreShopHistoryViewer_LoadForm(object sender, EventArgs e)
        {
            if (Program.User.CanStoreSalesTracking)
                AddButton("رهگیری", "StuffTracking", "رهگیری خرید و فروش کالاها", ActionSalesTracking, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("تائید", "Tick", "تائید فروش توسط مدیر", ActionManagerAwared, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("حذف تائید", "Error", "حذف تائید مربوط به فروش", ActionManagerNotAwared, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            
            ComboFiller<StuffTypeBO>.FillCombo(cboFilterStuffTypeID, StuffTypeBO.List());

            string curDate = FaDate.CurrentFaDateString;
            txtFilterDateFrom.Text = curDate;
            txtFilterDateTo.Text = curDate;

            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string filterDateFrom = null;
            string filterDateTo = null;
            int? filterStuffTypeID = null;
            bool? filterJustNotManagerValidates = null;

            if (chkJustManagerShouldBeAware.Checked) filterJustNotManagerValidates = true;
            if (txtFilterDateFrom.Accepted) filterDateFrom = txtFilterDateFrom.Text;
            if (txtFilterDateTo.Accepted) filterDateTo = txtFilterDateTo.Text;
            if (cboFilterStuffTypeID.Accepted) filterStuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboFilterStuffTypeID).StuffTypeID;

            DataGridFiller<ViwStoreSalesHistoryBO>.FillDataGrid(dataGridSection, ViwStoreSalesHistoryBO.ListInterval(filterStuffTypeID, filterDateFrom, filterDateTo, filterJustNotManagerValidates),
                new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.ViwStoreSalesHistory.CustomerName,
                DatabaseSchema.ViwStoreSalesHistory.StuffName,
                DatabaseSchema.ViwStoreSalesHistory.StuffTypeName,
                DatabaseSchema.ViwStoreSalesHistory.ShopCount,
                DatabaseSchema.ViwStoreSalesHistory.Fee,
                DatabaseSchema.ViwStoreSalesHistory.ShopDate
            });


            int totalFee = 0;
            int totalDiscount = 0;
            int totalCustomerCount = 0;
            int totalShopCount = 0;

            foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
            {
                ViwStoreSalesHistoryBO sale = (ViwStoreSalesHistoryBO)row.Tag;
                totalFee += sale.Fee;
                totalDiscount += sale.Discount.Value;
                totalCustomerCount += sale.CustomerCount.Value;
                totalShopCount += sale.ShopCount;

                if (sale.IsManagerAware)
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    row.DefaultCellStyle.BackColor = Color.Pink;
            }

            lblTotalIncome.Text = UtilityTxt.ToFarsiCurrency(totalFee.ToString());
            lblTotalDiscount.Text = UtilityTxt.ToFarsiCurrency(totalDiscount.ToString());
            lblTotalShopCount.Text = UtilityTxt.ToFarsiCurrency(totalShopCount.ToString());
            lblTotalCustomerCount.Text = UtilityTxt.ToFarsiCurrency(totalCustomerCount.ToString());

            //DataGridFiller<ViwStoreSalesHistoryBO>.FillDataGrid(dataGridSection, ViwStoreSalesHistoryBO.ListGroup(filterStuffTypeID, filterDateFrom, filterDateTo), new List<DatabaseSchemaNamespace.ColumnDefinition>
            //{
            //    DatabaseSchema.ViwStoreSalesHistory.StuffTypeName,
            //    DatabaseSchema.ViwStoreSalesHistory.ShopCount,
            //    DatabaseSchema.ViwStoreSalesHistory.Fee,
            //    DatabaseSchema.ViwStoreSalesHistory.Discount,
            //    DatabaseSchema.ViwStoreSalesHistory.IsManagerAware
            //});
        }
        bool setting = false;
        private void txtFilterDateFrom_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void txtFilterDateTo_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void cboFilterStuffTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void chkJustManagerShouldBeAware_CheckedChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowsSelected(StandardWidgets.CoolDataGrid.RowsSelectionEventArgs e)
        {
            if (e.Rows.Count > 0)
                ShowSuggestions();
            else
                HideSuggestions();
        }
    }
}
