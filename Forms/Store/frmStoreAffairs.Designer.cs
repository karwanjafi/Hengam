namespace Hengam.Forms.Store
{
    partial class frmStoreAffairs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreAffairs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStuffTracking = new Hengam.Controls.HengamAnimatedButton();
            this.btnStoreStuffDetailsAvailableViewer = new Hengam.Controls.HengamAnimatedButton();
            this.btnSellEditor = new Hengam.Controls.HengamAnimatedButton();
            this.btnStuffShopHistory = new Hengam.Controls.HengamAnimatedButton();
            this.btnStuffBuy = new Hengam.Controls.HengamAnimatedButton();
            this.btnSellItem = new Hengam.Controls.HengamAnimatedButton();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Size = new System.Drawing.Size(863, 461);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(290, 206);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.btnStuffTracking);
            this.groupBox1.Controls.Add(this.btnStoreStuffDetailsAvailableViewer);
            this.groupBox1.Controls.Add(this.btnSellEditor);
            this.groupBox1.Controls.Add(this.btnStuffShopHistory);
            this.groupBox1.Controls.Add(this.btnStuffBuy);
            this.groupBox1.Controls.Add(this.btnSellItem);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت غرفه";
            // 
            // btnStuffTracking
            // 
            this.btnStuffTracking.BackColor = System.Drawing.Color.Transparent;
            this.btnStuffTracking.Image = ((System.Drawing.Image)(resources.GetObject("btnStuffTracking.Image")));
            this.btnStuffTracking.Location = new System.Drawing.Point(204, 365);
            this.btnStuffTracking.Name = "btnStuffTracking";
            this.btnStuffTracking.Size = new System.Drawing.Size(229, 75);
            this.btnStuffTracking.TabIndex = 2;
            this.btnStuffTracking.TextToSet = "رهگیری خرید و فروش";
            this.btnStuffTracking.Clicked += new System.EventHandler(this.btnStuffTracking_Clicked);
            // 
            // btnStoreStuffDetailsAvailableViewer
            // 
            this.btnStoreStuffDetailsAvailableViewer.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreStuffDetailsAvailableViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreStuffDetailsAvailableViewer.Image")));
            this.btnStoreStuffDetailsAvailableViewer.Location = new System.Drawing.Point(479, 365);
            this.btnStoreStuffDetailsAvailableViewer.Name = "btnStoreStuffDetailsAvailableViewer";
            this.btnStoreStuffDetailsAvailableViewer.Size = new System.Drawing.Size(229, 75);
            this.btnStoreStuffDetailsAvailableViewer.TabIndex = 1;
            this.btnStoreStuffDetailsAvailableViewer.TextToSet = "بررسی موجودی غرفه";
            this.btnStoreStuffDetailsAvailableViewer.Clicked += new System.EventHandler(this.btnStoreStuffDetailsAvailableViewer_Clicked);
            // 
            // btnSellEditor
            // 
            this.btnSellEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnSellEditor.Image = ((System.Drawing.Image)(resources.GetObject("btnSellEditor.Image")));
            this.btnSellEditor.Location = new System.Drawing.Point(602, 242);
            this.btnSellEditor.Name = "btnSellEditor";
            this.btnSellEditor.Size = new System.Drawing.Size(229, 75);
            this.btnSellEditor.TabIndex = 1;
            this.btnSellEditor.TextToSet = "ویرایش فروش";
            this.btnSellEditor.Clicked += new System.EventHandler(this.btnSellEditor_Clicked);
            // 
            // btnStuffShopHistory
            // 
            this.btnStuffShopHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnStuffShopHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnStuffShopHistory.Image")));
            this.btnStuffShopHistory.Location = new System.Drawing.Point(34, 242);
            this.btnStuffShopHistory.Name = "btnStuffShopHistory";
            this.btnStuffShopHistory.Size = new System.Drawing.Size(229, 75);
            this.btnStuffShopHistory.TabIndex = 1;
            this.btnStuffShopHistory.TextToSet = "بررسی فروش روزانه";
            this.btnStuffShopHistory.Clicked += new System.EventHandler(this.btnStuffShopHistory_Clicked);
            // 
            // btnStuffBuy
            // 
            this.btnStuffBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnStuffBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnStuffBuy.Image")));
            this.btnStuffBuy.Location = new System.Drawing.Point(107, 77);
            this.btnStuffBuy.Name = "btnStuffBuy";
            this.btnStuffBuy.Size = new System.Drawing.Size(229, 75);
            this.btnStuffBuy.TabIndex = 1;
            this.btnStuffBuy.TextToSet = "اضافه کردن کالا به غرفه";
            this.btnStuffBuy.Clicked += new System.EventHandler(this.btnStuffBuy_Clicked);
            // 
            // btnSellItem
            // 
            this.btnSellItem.BackColor = System.Drawing.Color.Transparent;
            this.btnSellItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSellItem.Image")));
            this.btnSellItem.Location = new System.Drawing.Point(528, 77);
            this.btnSellItem.Name = "btnSellItem";
            this.btnSellItem.Size = new System.Drawing.Size(224, 75);
            this.btnSellItem.TabIndex = 0;
            this.btnSellItem.TextToSet = "فروش کالا";
            this.btnSellItem.Clicked += new System.EventHandler(this.btnSellItem_Clicked);
            // 
            // frmStoreAffairs
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(887, 485);
            this.Name = "frmStoreAffairs";
            this.Text = "امور غرفه";
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Hengam.Controls.HengamAnimatedButton btnSellItem;
        private Hengam.Controls.HengamAnimatedButton btnStoreStuffDetailsAvailableViewer;
        private Hengam.Controls.HengamAnimatedButton btnSellEditor;
        private Hengam.Controls.HengamAnimatedButton btnStuffShopHistory;
        private Hengam.Controls.HengamAnimatedButton btnStuffBuy;
        private Hengam.Controls.HengamAnimatedButton btnStuffTracking;
    }
}
