using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Tools;

namespace Hengam.Forms.Store
{
    public partial class frmStoreAffairs : HengamWidgets.FormBaseSimple
    {
        public frmStoreAffairs()
        {
            InitializeComponent();

            btnSellEditor.Enabled = CanStoreStuffSellItemManager;
            btnSellItem.Enabled = CanStoreStuffSellItem;
            btnStoreStuffDetailsAvailableViewer.Enabled = CanStoreStuffAvailableViewer;
            btnStuffShopHistory.Enabled = CanStoreShopHistoryViewer;
            btnStuffTracking.Enabled = CanStoreSalesTracking;
            btnStuffBuy.Enabled = CanStoreStuffBuyManager;
        }

        public static bool CanStoreStuffAvailableViewer = false;
        public static bool CanStoreStuffTypeManager = false;
        public static bool CanStoreStuffBuyManager = false;
        public static bool CanStoreStuffSellItemManager = false;
        public static bool CanStoreStuffSellItem = false;
        public static bool CanStoreSalesTracking = false;
        public static bool CanStoreShopHistoryViewer = false;

        private void btnStuffShopHistory_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreShopHistoryViewer());
        }

        private void btnStuffBuy_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreStuffBuyManager());
        }

        private void btnSellItem_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreStuffSellItem());
        }

        private void btnSellEditor_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreStuffSellItemManager());
        }

        private void btnStoreStuffDetailsAvailableViewer_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreStuffTypeManager());
        }

        private void btnStuffTracking_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StoreSalesTracking());
        }
    }
}
