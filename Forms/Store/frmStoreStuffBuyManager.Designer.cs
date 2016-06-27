namespace Hengam.Forms.Store
{
    partial class frmStoreStuffBuyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreStuffBuyManager));
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.txtStuffID = new HengamWidgets.CoolTextBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.cboStuffTypeID = new HengamWidgets.CoolComboBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.txtBuyDate = new HengamWidgets.CoolDateBox();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.txtStuffCount = new HengamWidgets.CoolNumberBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterStoreStuffDetails = new HengamWidgets.PanelFloater();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.cboFilterStuffType = new HengamWidgets.CoolComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.txtUnitPrice = new HengamWidgets.CoolNumberBox();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupPay);
            this.groupItemDetails.Controls.Add(this.groupBox1);
            this.groupItemDetails.Size = new System.Drawing.Size(761, 241);
            this.groupItemDetails.Text = "اطلاعات کالا";
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupPay, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 150);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterStoreStuffDetails);
            this.pnlMain.Size = new System.Drawing.Size(767, 413);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Controls.SetChildIndex(this.floaterStoreStuffDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.coolLabel3);
            this.groupDatagrid.Controls.Add(this.cboFilterStuffType);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 250);
            this.groupDatagrid.Size = new System.Drawing.Size(761, 160);
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.cboFilterStuffType, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel3, 0);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Location = new System.Drawing.Point(6, 47);
            this.dataGridSection.Size = new System.Drawing.Size(749, 107);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(254, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(277, 47);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(56, 21);
            this.coolLabel8.TabIndex = 8;
            this.coolLabel8.TabStop = false;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "نوع کالا:";
            // 
            // txtStuffID
            // 
            this.txtStuffID.Accepted = false;
            this.txtStuffID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffID.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffID.CursorLocation = 0;
            this.txtStuffID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffID.IsEmpty = false;
            this.txtStuffID.LengthMax = 1000000;
            this.txtStuffID.LengthMin = 0;
            this.txtStuffID.Location = new System.Drawing.Point(119, 20);
            this.txtStuffID.Mask = "";
            this.txtStuffID.Message = "خالی";
            this.txtStuffID.MustFill = true;
            this.txtStuffID.Name = "txtStuffID";
            this.txtStuffID.ReadOnly = true;
            this.txtStuffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffID.Size = new System.Drawing.Size(152, 21);
            this.txtStuffID.TabIndex = 0;
            this.txtStuffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffID.TextToSet = "";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(277, 20);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(56, 21);
            this.coolLabel4.TabIndex = 6;
            this.coolLabel4.TabStop = false;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "کد کالا:";
            // 
            // cboStuffTypeID
            // 
            this.cboStuffTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStuffTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboStuffTypeID.DisplayMember = "";
            this.cboStuffTypeID.Location = new System.Drawing.Point(25, 47);
            this.cboStuffTypeID.Name = "cboStuffTypeID";
            this.cboStuffTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboStuffTypeID.SelectedItem = null;
            this.cboStuffTypeID.Size = new System.Drawing.Size(246, 21);
            this.cboStuffTypeID.TabIndex = 1;
            this.cboStuffTypeID.SelectedValueChanged += new System.EventHandler(this.cboStuffTypeID_SelectedValueChanged);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(277, 74);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(56, 21);
            this.coolLabel1.TabIndex = 6;
            this.coolLabel1.TabStop = false;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "نام کالا:";
            // 
            // txtStuffName
            // 
            this.txtStuffName.Accepted = false;
            this.txtStuffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffName.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffName.CursorLocation = 0;
            this.txtStuffName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffName.IsEmpty = false;
            this.txtStuffName.LengthMax = 1000000;
            this.txtStuffName.LengthMin = 0;
            this.txtStuffName.Location = new System.Drawing.Point(25, 74);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = false;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(246, 21);
            this.txtStuffName.TabIndex = 2;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            // 
            // txtBuyDate
            // 
            this.txtBuyDate.Accepted = false;
            this.txtBuyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyDate.CursorLocation = 8;
            this.txtBuyDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBuyDate.IsEmpty = false;
            this.txtBuyDate.Location = new System.Drawing.Point(163, 101);
            this.txtBuyDate.Mask = "0000/00/00";
            this.txtBuyDate.Message = "طول کم";
            this.txtBuyDate.MustFill = true;
            this.txtBuyDate.Name = "txtBuyDate";
            this.txtBuyDate.ReadOnly = false;
            this.txtBuyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBuyDate.Size = new System.Drawing.Size(108, 21);
            this.txtBuyDate.TabIndex = 3;
            this.txtBuyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuyDate.TextToSet = "    /  /";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(277, 101);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(56, 21);
            this.coolLabel5.TabIndex = 10;
            this.coolLabel5.TabStop = false;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ خرید:";
            // 
            // txtStuffCount
            // 
            this.txtStuffCount.Accepted = true;
            this.txtStuffCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffCount.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffCount.CursorLocation = 0;
            this.txtStuffCount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffCount.HaveCurrencySeperator = true;
            this.txtStuffCount.IsEmpty = false;
            this.txtStuffCount.LengthMax = 40;
            this.txtStuffCount.LengthMin = 0;
            this.txtStuffCount.Location = new System.Drawing.Point(25, 102);
            this.txtStuffCount.Mask = "";
            this.txtStuffCount.Message = "خالی";
            this.txtStuffCount.MustFill = true;
            this.txtStuffCount.Name = "txtStuffCount";
            this.txtStuffCount.NumberMax = ((long)(9999999));
            this.txtStuffCount.NumberMin = ((long)(1));
            this.txtStuffCount.ReadOnly = false;
            this.txtStuffCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffCount.Size = new System.Drawing.Size(70, 21);
            this.txtStuffCount.TabIndex = 4;
            this.txtStuffCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStuffCount.TextToSet = "1";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(101, 101);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(56, 21);
            this.coolLabel2.TabIndex = 13;
            this.coolLabel2.TabStop = false;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "تعداد:";
            // 
            // floaterStoreStuffDetails
            // 
            this.floaterStoreStuffDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStoreStuffDetails.BackColor = System.Drawing.Color.DimGray;
            this.floaterStoreStuffDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStoreStuffDetails.Location = new System.Drawing.Point(9, 23);
            this.floaterStoreStuffDetails.Name = "floaterStoreStuffDetails";
            this.floaterStoreStuffDetails.Size = new System.Drawing.Size(749, 381);
            this.floaterStoreStuffDetails.TabIndex = 2;
            this.floaterStoreStuffDetails.TitleColor = System.Drawing.Color.Orange;
            this.floaterStoreStuffDetails.TitleText = "";
            this.floaterStoreStuffDetails.Visible = false;
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(709, 20);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(46, 21);
            this.coolLabel3.TabIndex = 6;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "نوع کالا:";
            // 
            // cboFilterStuffType
            // 
            this.cboFilterStuffType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStuffType.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterStuffType.DisplayMember = "";
            this.cboFilterStuffType.Location = new System.Drawing.Point(447, 20);
            this.cboFilterStuffType.Name = "cboFilterStuffType";
            this.cboFilterStuffType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboFilterStuffType.SelectedItem = null;
            this.cboFilterStuffType.Size = new System.Drawing.Size(256, 21);
            this.cboFilterStuffType.TabIndex = 5;
            this.cboFilterStuffType.SelectedValueChanged += new System.EventHandler(this.cboFilterStuffType_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.coolLabel4);
            this.groupBox1.Controls.Add(this.cboStuffTypeID);
            this.groupBox1.Controls.Add(this.coolLabel2);
            this.groupBox1.Controls.Add(this.txtStuffID);
            this.groupBox1.Controls.Add(this.txtStuffCount);
            this.groupBox1.Controls.Add(this.coolLabel1);
            this.groupBox1.Controls.Add(this.txtBuyDate);
            this.groupBox1.Controls.Add(this.coolLabel9);
            this.groupBox1.Controls.Add(this.txtStuffName);
            this.groupBox1.Controls.Add(this.coolLabel5);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.coolLabel8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(416, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات کالای خریداری شده";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(223, 139);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(110, 21);
            this.coolLabel9.TabIndex = 14;
            this.coolLabel9.TabStop = false;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "قیمت فروش هر واحد:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Accepted = false;
            this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.CursorLocation = 0;
            this.txtUnitPrice.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtUnitPrice.HaveCurrencySeperator = true;
            this.txtUnitPrice.IsEmpty = false;
            this.txtUnitPrice.LengthMax = 40;
            this.txtUnitPrice.LengthMin = 0;
            this.txtUnitPrice.Location = new System.Drawing.Point(101, 139);
            this.txtUnitPrice.Mask = "";
            this.txtUnitPrice.Message = "خالی";
            this.txtUnitPrice.MustFill = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.NumberMax = ((long)(999999999));
            this.txtUnitPrice.NumberMin = ((long)(0));
            this.txtUnitPrice.ReadOnly = false;
            this.txtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitPrice.Size = new System.Drawing.Size(114, 21);
            this.txtUnitPrice.TabIndex = 5;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUnitPrice.TextToSet = "";
            // 
            // groupPay
            // 
            this.groupPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPay.Controls.Add(this.txtCheckNumber);
            this.groupPay.Controls.Add(this.coolLabel11);
            this.groupPay.Controls.Add(this.coolLabel10);
            this.groupPay.Controls.Add(this.cboPayTypeID);
            this.groupPay.Controls.Add(this.txtDescription);
            this.groupPay.Controls.Add(this.coolLabel6);
            this.groupPay.Controls.Add(this.coolLabel7);
            this.groupPay.Controls.Add(this.coolLabel12);
            this.groupPay.Controls.Add(this.txtCheckDate);
            this.groupPay.Controls.Add(this.coolLabel13);
            this.groupPay.Controls.Add(this.txtFee);
            this.groupPay.Controls.Add(this.txtDiscount);
            this.groupPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPay.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupPay.Location = new System.Drawing.Point(8, 11);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(401, 131);
            this.groupPay.TabIndex = 21;
            this.groupPay.TabStop = false;
            this.groupPay.Text = "جزئیات پرداخت";
            // 
            // txtCheckNumber
            // 
            this.txtCheckNumber.Accepted = false;
            this.txtCheckNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckNumber.CursorLocation = 0;
            this.txtCheckNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckNumber.IsEmpty = false;
            this.txtCheckNumber.LengthMax = 999999999;
            this.txtCheckNumber.LengthMin = 0;
            this.txtCheckNumber.Location = new System.Drawing.Point(0, 46);
            this.txtCheckNumber.Mask = "";
            this.txtCheckNumber.Message = "خالی";
            this.txtCheckNumber.MustFill = true;
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.ReadOnly = false;
            this.txtCheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckNumber.Size = new System.Drawing.Size(114, 21);
            this.txtCheckNumber.TabIndex = 5;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckNumber.TextToSet = "";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(120, 46);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 21);
            this.coolLabel11.TabIndex = 24;
            this.coolLabel11.TabStop = false;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "شماره‌ی چک:";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(317, 74);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(77, 21);
            this.coolLabel10.TabIndex = 16;
            this.coolLabel10.TabStop = false;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Location = new System.Drawing.Point(197, 74);
            this.cboPayTypeID.Name = "cboPayTypeID";
            this.cboPayTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPayTypeID.SelectedItem = null;
            this.cboPayTypeID.Size = new System.Drawing.Size(114, 21);
            this.cboPayTypeID.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Accepted = false;
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.CursorLocation = 0;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDescription.IsEmpty = false;
            this.txtDescription.LengthMax = 1000000;
            this.txtDescription.LengthMin = 0;
            this.txtDescription.Location = new System.Drawing.Point(0, 101);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(311, 21);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(317, 101);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(57, 21);
            this.coolLabel6.TabIndex = 13;
            this.coolLabel6.TabStop = false;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "توضیحات:";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(120, 20);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(72, 21);
            this.coolLabel7.TabIndex = 17;
            this.coolLabel7.TabStop = false;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "تاریخ چک:";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(317, 20);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(81, 21);
            this.coolLabel12.TabIndex = 14;
            this.coolLabel12.TabStop = false;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "قیمت کل خرید:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(0, 20);
            this.txtCheckDate.Mask = "0000/00/00";
            this.txtCheckDate.Message = "طول کم";
            this.txtCheckDate.MustFill = true;
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = false;
            this.txtCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckDate.Size = new System.Drawing.Size(114, 21);
            this.txtCheckDate.TabIndex = 4;
            this.txtCheckDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckDate.TextToSet = "    /  /";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(317, 47);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(81, 21);
            this.coolLabel13.TabIndex = 12;
            this.coolLabel13.TabStop = false;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "تخفیف:";
            // 
            // txtFee
            // 
            this.txtFee.Accepted = false;
            this.txtFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFee.BackColor = System.Drawing.Color.Transparent;
            this.txtFee.CursorLocation = 0;
            this.txtFee.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFee.HaveCurrencySeperator = true;
            this.txtFee.IsEmpty = false;
            this.txtFee.LengthMax = 40;
            this.txtFee.LengthMin = 0;
            this.txtFee.Location = new System.Drawing.Point(197, 20);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(999999999));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = false;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 1;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFee.TextToSet = "";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Accepted = true;
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtDiscount.CursorLocation = 0;
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiscount.HaveCurrencySeperator = true;
            this.txtDiscount.IsEmpty = false;
            this.txtDiscount.LengthMax = 40;
            this.txtDiscount.LengthMin = 0;
            this.txtDiscount.Location = new System.Drawing.Point(197, 47);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
            // 
            // frmStoreStuffBuyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(783, 441);
            this.Name = "frmStoreStuffBuyManager";
            this.Text = "مدیریت خریدهای غرفه";
            this.LoadForm += new System.EventHandler(this.frmStoreStuffTypeManager_LoadForm);
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
            this.groupPay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolTextBox txtStuffID;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolComboBox cboStuffTypeID;
        private HengamWidgets.CoolTextBox txtStuffName;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolNumberBox txtStuffCount;
        private HengamWidgets.CoolDateBox txtBuyDate;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterStoreStuffDetails;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolComboBox cboFilterStuffType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupPay;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolNumberBox txtUnitPrice;
    }
}
