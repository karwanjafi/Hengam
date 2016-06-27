namespace Hengam.Forms.Store
{
    partial class frmStoreShopHistoryViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreShopHistoryViewer));
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.txtFilterDateTo = new HengamWidgets.CoolDateBox();
            this.txtFilterDateFrom = new HengamWidgets.CoolDateBox();
            this.cboFilterStuffTypeID = new HengamWidgets.CoolComboBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.lblTotalIncome = new HengamWidgets.CoolLabel();
            this.lblTotalDiscount = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.lblTotalShopCount = new HengamWidgets.CoolLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.lblTotalCustomerCount = new HengamWidgets.CoolLabel();
            this.chkJustManagerShouldBeAware = new HengamWidgets.CoolCheckBox();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.chkJustManagerShouldBeAware);
            this.groupItemDetails.Controls.Add(this.groupBox1);
            this.groupItemDetails.Controls.Add(this.coolLabel16);
            this.groupItemDetails.Controls.Add(this.coolLabel15);
            this.groupItemDetails.Controls.Add(this.coolLabel14);
            this.groupItemDetails.Controls.Add(this.txtFilterDateTo);
            this.groupItemDetails.Controls.Add(this.txtFilterDateFrom);
            this.groupItemDetails.Controls.Add(this.cboFilterStuffTypeID);
            this.groupItemDetails.Size = new System.Drawing.Size(816, 159);
            this.groupItemDetails.Text = "وضعیت فروش";
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.cboFilterStuffTypeID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtFilterDateFrom, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtFilterDateTo, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel14, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel15, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel16, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.chkJustManagerShouldBeAware, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 68);
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(822, 422);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 168);
            this.groupDatagrid.Size = new System.Drawing.Size(816, 251);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            this.imgButtons.Images.SetKeyName(5, "Tick");
            this.imgButtons.Images.SetKeyName(6, "Error");
            this.imgButtons.Images.SetKeyName(7, "StuffTracking");
            // 
            // dataGridSection
            // 
            this.dataGridSection.MultiSelect = true;
            this.dataGridSection.Size = new System.Drawing.Size(804, 225);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowsSelected += new StandardWidgets.CoolDataGrid.RowsSelectionEventHandler(this.dataGridSection_RowsSelected);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(282, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(371, 20);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(45, 21);
            this.coolLabel16.TabIndex = 32;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "نوع کالا:";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(530, 20);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(17, 21);
            this.coolLabel15.TabIndex = 31;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "تا:";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(656, 20);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(154, 21);
            this.coolLabel14.TabIndex = 28;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "نمایش اطلاعات فروش مربوط به:";
            // 
            // txtFilterDateTo
            // 
            this.txtFilterDateTo.Accepted = false;
            this.txtFilterDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateTo.IsEmpty = false;
            this.txtFilterDateTo.Location = new System.Drawing.Point(422, 20);
            this.txtFilterDateTo.Mask = "0000/00/00";
            this.txtFilterDateTo.Message = "طول کم";
            this.txtFilterDateTo.MustFill = true;
            this.txtFilterDateTo.Name = "txtFilterDateTo";
            this.txtFilterDateTo.ReadOnly = false;
            this.txtFilterDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateTo.Size = new System.Drawing.Size(102, 21);
            this.txtFilterDateTo.TabIndex = 30;
            this.txtFilterDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateTo.TextToSet = "    /  /";
            this.txtFilterDateTo.TextChanged += new System.EventHandler(this.txtFilterDateTo_TextChanged);
            // 
            // txtFilterDateFrom
            // 
            this.txtFilterDateFrom.Accepted = false;
            this.txtFilterDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateFrom.IsEmpty = false;
            this.txtFilterDateFrom.Location = new System.Drawing.Point(548, 20);
            this.txtFilterDateFrom.Mask = "0000/00/00";
            this.txtFilterDateFrom.Message = "طول کم";
            this.txtFilterDateFrom.MustFill = true;
            this.txtFilterDateFrom.Name = "txtFilterDateFrom";
            this.txtFilterDateFrom.ReadOnly = false;
            this.txtFilterDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateFrom.Size = new System.Drawing.Size(102, 21);
            this.txtFilterDateFrom.TabIndex = 29;
            this.txtFilterDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateFrom.TextToSet = "    /  /";
            this.txtFilterDateFrom.TextChanged += new System.EventHandler(this.txtFilterDateFrom_TextChanged);
            // 
            // cboFilterStuffTypeID
            // 
            this.cboFilterStuffTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStuffTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterStuffTypeID.DisplayMember = "";
            this.cboFilterStuffTypeID.Location = new System.Drawing.Point(155, 20);
            this.cboFilterStuffTypeID.Name = "cboFilterStuffTypeID";
            this.cboFilterStuffTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboFilterStuffTypeID.SelectedItem = null;
            this.cboFilterStuffTypeID.Size = new System.Drawing.Size(210, 21);
            this.cboFilterStuffTypeID.TabIndex = 33;
            this.cboFilterStuffTypeID.SelectedValueChanged += new System.EventHandler(this.cboFilterStuffTypeID_SelectedValueChanged);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(533, 19);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(116, 21);
            this.coolLabel1.TabIndex = 28;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "درآمد حاصل از فروش:";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(533, 46);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(116, 21);
            this.coolLabel2.TabIndex = 28;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "تخفیف:";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIncome.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIncome.Location = new System.Drawing.Point(449, 19);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(78, 21);
            this.lblTotalIncome.TabIndex = 28;
            this.lblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalIncome.TextToSet = "-";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDiscount.Location = new System.Drawing.Point(449, 46);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(78, 21);
            this.lblTotalDiscount.TabIndex = 28;
            this.lblTotalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalDiscount.TextToSet = "-";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(267, 19);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(138, 21);
            this.coolLabel3.TabIndex = 28;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "تعداد کالاهای فروخته شده:";
            // 
            // lblTotalShopCount
            // 
            this.lblTotalShopCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalShopCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalShopCount.Location = new System.Drawing.Point(183, 19);
            this.lblTotalShopCount.Name = "lblTotalShopCount";
            this.lblTotalShopCount.Size = new System.Drawing.Size(78, 21);
            this.lblTotalShopCount.TabIndex = 28;
            this.lblTotalShopCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalShopCount.TextToSet = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.coolLabel4);
            this.groupBox1.Controls.Add(this.lblTotalCustomerCount);
            this.groupBox1.Controls.Add(this.coolLabel1);
            this.groupBox1.Controls.Add(this.coolLabel3);
            this.groupBox1.Controls.Add(this.coolLabel2);
            this.groupBox1.Controls.Add(this.lblTotalDiscount);
            this.groupBox1.Controls.Add(this.lblTotalIncome);
            this.groupBox1.Controls.Add(this.lblTotalShopCount);
            this.groupBox1.Location = new System.Drawing.Point(155, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 76);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "آمار فروش";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(267, 46);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(116, 21);
            this.coolLabel4.TabIndex = 30;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "تعداد مشتری‌ها:";
            // 
            // lblTotalCustomerCount
            // 
            this.lblTotalCustomerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCustomerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCustomerCount.Location = new System.Drawing.Point(183, 46);
            this.lblTotalCustomerCount.Name = "lblTotalCustomerCount";
            this.lblTotalCustomerCount.Size = new System.Drawing.Size(78, 21);
            this.lblTotalCustomerCount.TabIndex = 29;
            this.lblTotalCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCustomerCount.TextToSet = "-";
            // 
            // chkJustManagerShouldBeAware
            // 
            this.chkJustManagerShouldBeAware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJustManagerShouldBeAware.Checked = false;
            this.chkJustManagerShouldBeAware.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkJustManagerShouldBeAware.Location = new System.Drawing.Point(618, 129);
            this.chkJustManagerShouldBeAware.Name = "chkJustManagerShouldBeAware";
            this.chkJustManagerShouldBeAware.Size = new System.Drawing.Size(192, 21);
            this.chkJustManagerShouldBeAware.TabIndex = 35;
            this.chkJustManagerShouldBeAware.TextToSet = "فقط تائید نشده‌ها نمایش داده شود.";
            this.chkJustManagerShouldBeAware.CheckedChanged += new System.EventHandler(this.chkJustManagerShouldBeAware_CheckedChanged);
            // 
            // frmStoreShopHistoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Name = "frmStoreShopHistoryViewer";
            this.Text = "بررسی فروش روزانه";
            this.LoadForm += new System.EventHandler(this.frmStoreShopHistoryViewer_LoadForm);
            this.groupItemDetails.ResumeLayout(false);
            this.groupButtons.ResumeLayout(false);
            this.groupButtons.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupDatagrid.ResumeLayout(false);
            this.groupDatagrid.PerformLayout();
            this.groupSuggestions.ResumeLayout(false);
            this.groupSuggestions.PerformLayout();
            this.pnlSuggestions.ResumeLayout(false);
            this.pnlSuggestions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolDateBox txtFilterDateTo;
        private HengamWidgets.CoolDateBox txtFilterDateFrom;
        private HengamWidgets.CoolComboBox cboFilterStuffTypeID;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel lblTotalDiscount;
        private HengamWidgets.CoolLabel lblTotalIncome;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel lblTotalShopCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel lblTotalCustomerCount;
        private HengamWidgets.CoolCheckBox chkJustManagerShouldBeAware;
    }
}
