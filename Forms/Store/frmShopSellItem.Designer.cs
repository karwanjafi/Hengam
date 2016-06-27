namespace Hengam.Forms.Store
{
    partial class frmShopSellItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopSellItem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtStuffID = new HengamWidgets.CoolTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
            this.txtCustomerName = new HengamWidgets.CoolTextBox();
            this.chkMiscCustomer = new HengamWidgets.CoolCheckBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.txtCustomerID = new HengamWidgets.CoolTextBox();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtShopID = new HengamWidgets.CoolTextBox();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.txtShopCount = new HengamWidgets.CoolNumberBox();
            this.txtShopDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.txtShopDate = new HengamWidgets.CoolDateBox();
            this.floaterStuffPicker = new HengamWidgets.PanelFloater();
            this.floaterStudentPicker = new HengamWidgets.PanelFloater();
            this.txtFilterDate = new HengamWidgets.CoolDateBox();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupBox3);
            this.groupItemDetails.Controls.Add(this.groupPay);
            this.groupItemDetails.Controls.Add(this.groupBox2);
            this.groupItemDetails.Controls.Add(this.groupBox1);
            this.groupItemDetails.Size = new System.Drawing.Size(675, 308);
            this.groupItemDetails.TabIndex = 0;
            this.groupItemDetails.Text = "اطلاعات فروش";
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupPay, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox3, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 217);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterStuffPicker);
            this.pnlMain.Controls.Add(this.floaterStudentPicker);
            this.pnlMain.Size = new System.Drawing.Size(681, 429);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStuffPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.coolLabel14);
            this.groupDatagrid.Controls.Add(this.txtFilterDate);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 317);
            this.groupDatagrid.Size = new System.Drawing.Size(675, 109);
            this.groupDatagrid.Controls.SetChildIndex(this.txtFilterDate, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel14, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
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
            this.dataGridSection.Location = new System.Drawing.Point(6, 46);
            this.dataGridSection.Size = new System.Drawing.Size(663, 57);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(211, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtStuffName);
            this.groupBox1.Controls.Add(this.coolLabel1);
            this.groupBox1.Controls.Add(this.txtStuffID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(268, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب کالا";
            // 
            // txtStuffName
            // 
            this.txtStuffName.Accepted = false;
            this.txtStuffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffName.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffName.CursorLocation = 0;
            this.txtStuffName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffName.IsEmpty = false;
            this.txtStuffName.LengthMax = 1000000;
            this.txtStuffName.LengthMin = 0;
            this.txtStuffName.Location = new System.Drawing.Point(6, 20);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = false;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(336, 21);
            this.txtStuffName.TabIndex = 0;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            this.txtStuffName.Click += new System.EventHandler(this.txtStuffName_Click);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(348, 20);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(47, 21);
            this.coolLabel1.TabIndex = 1;
            this.coolLabel1.TabStop = false;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "نام کالا:";
            // 
            // txtStuffID
            // 
            this.txtStuffID.Accepted = false;
            this.txtStuffID.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffID.CursorLocation = 0;
            this.txtStuffID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffID.IsEmpty = false;
            this.txtStuffID.LengthMax = 1000000;
            this.txtStuffID.LengthMin = 0;
            this.txtStuffID.Location = new System.Drawing.Point(6, 20);
            this.txtStuffID.Mask = "";
            this.txtStuffID.Message = "خالی";
            this.txtStuffID.MustFill = true;
            this.txtStuffID.Name = "txtStuffID";
            this.txtStuffID.ReadOnly = false;
            this.txtStuffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffID.Size = new System.Drawing.Size(32, 21);
            this.txtStuffID.TabIndex = 0;
            this.txtStuffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffID.TextToSet = "";
            this.txtStuffID.TextAccepted += new System.EventHandler(this.txtStuffID_TextAccepted);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtStudentName);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.chkMiscCustomer);
            this.groupBox2.Controls.Add(this.coolLabel2);
            this.groupBox2.Controls.Add(this.txtCustomerID);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(268, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب مشتری";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Accepted = false;
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentName.CursorLocation = 0;
            this.txtStudentName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentName.IsEmpty = false;
            this.txtStudentName.LengthMax = 1000000;
            this.txtStudentName.LengthMin = 0;
            this.txtStudentName.Location = new System.Drawing.Point(6, 20);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = false;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(294, 21);
            this.txtStudentName.TabIndex = 0;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            this.txtStudentName.Click += new System.EventHandler(this.txtStudentName_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Accepted = false;
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.CursorLocation = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerName.IsEmpty = false;
            this.txtCustomerName.LengthMax = 1000000;
            this.txtCustomerName.LengthMin = 0;
            this.txtCustomerName.Location = new System.Drawing.Point(6, 47);
            this.txtCustomerName.Mask = "";
            this.txtCustomerName.Message = "خالی";
            this.txtCustomerName.MustFill = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomerName.Size = new System.Drawing.Size(294, 21);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.TextToSet = "";
            // 
            // chkMiscCustomer
            // 
            this.chkMiscCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMiscCustomer.Checked = false;
            this.chkMiscCustomer.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkMiscCustomer.Location = new System.Drawing.Point(300, 47);
            this.chkMiscCustomer.Name = "chkMiscCustomer";
            this.chkMiscCustomer.Size = new System.Drawing.Size(95, 21);
            this.chkMiscCustomer.TabIndex = 1;
            this.chkMiscCustomer.TextToSet = "مشتری دیگر:";
            this.chkMiscCustomer.ThreeState = false;
            this.chkMiscCustomer.CheckedChanged += new System.EventHandler(this.chkMiscCustomer_CheckedChanged);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(306, 20);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(89, 21);
            this.coolLabel2.TabIndex = 1;
            this.coolLabel2.TabStop = false;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "نام هنرجو:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Accepted = false;
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.CursorLocation = 0;
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerID.IsEmpty = false;
            this.txtCustomerID.LengthMax = 1000000;
            this.txtCustomerID.LengthMin = 0;
            this.txtCustomerID.Location = new System.Drawing.Point(6, 20);
            this.txtCustomerID.Mask = "";
            this.txtCustomerID.Message = "خالی";
            this.txtCustomerID.MustFill = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = false;
            this.txtCustomerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomerID.Size = new System.Drawing.Size(32, 21);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerID.TextToSet = "";
            // 
            // groupPay
            // 
            this.groupPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPay.Controls.Add(this.txtCheckNumber);
            this.groupPay.Controls.Add(this.coolLabel11);
            this.groupPay.Controls.Add(this.coolLabel10);
            this.groupPay.Controls.Add(this.cboPayTypeID);
            this.groupPay.Controls.Add(this.txtDescription);
            this.groupPay.Controls.Add(this.coolLabel8);
            this.groupPay.Controls.Add(this.coolLabel6);
            this.groupPay.Controls.Add(this.coolLabel5);
            this.groupPay.Controls.Add(this.coolLabel3);
            this.groupPay.Controls.Add(this.txtCheckDate);
            this.groupPay.Controls.Add(this.txtPayDate);
            this.groupPay.Controls.Add(this.coolLabel4);
            this.groupPay.Controls.Add(this.txtFee);
            this.groupPay.Controls.Add(this.txtDiscount);
            this.groupPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPay.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupPay.Location = new System.Drawing.Point(268, 161);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(401, 131);
            this.groupPay.TabIndex = 2;
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
            this.txtCheckNumber.LengthMax = 1000000;
            this.txtCheckNumber.LengthMin = 0;
            this.txtCheckNumber.Location = new System.Drawing.Point(0, 73);
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
            this.coolLabel11.Location = new System.Drawing.Point(120, 73);
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
            this.cboPayTypeID.TabIndex = 2;
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
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(317, 101);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(57, 21);
            this.coolLabel8.TabIndex = 13;
            this.coolLabel8.TabStop = false;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "توضیحات:";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(120, 47);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(72, 21);
            this.coolLabel6.TabIndex = 17;
            this.coolLabel6.TabStop = false;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "تاریخ چک:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(120, 20);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(72, 21);
            this.coolLabel5.TabIndex = 15;
            this.coolLabel5.TabStop = false;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(317, 20);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(81, 21);
            this.coolLabel3.TabIndex = 14;
            this.coolLabel3.TabStop = false;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "مبلغ:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(0, 47);
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
            // txtPayDate
            // 
            this.txtPayDate.Accepted = false;
            this.txtPayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayDate.BackColor = System.Drawing.Color.Transparent;
            this.txtPayDate.CursorLocation = 8;
            this.txtPayDate.Enabled = false;
            this.txtPayDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPayDate.IsEmpty = false;
            this.txtPayDate.Location = new System.Drawing.Point(0, 20);
            this.txtPayDate.Mask = "0000/00/00";
            this.txtPayDate.Message = "طول کم";
            this.txtPayDate.MustFill = true;
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = false;
            this.txtPayDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayDate.Size = new System.Drawing.Size(114, 21);
            this.txtPayDate.TabIndex = 3;
            this.txtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayDate.TextToSet = "    /  /";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(317, 47);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(81, 21);
            this.coolLabel4.TabIndex = 12;
            this.coolLabel4.TabStop = false;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "تخفیف:";
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
            this.txtFee.ReadOnly = true;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 0;
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
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
            this.txtDiscount.TextAccepted += new System.EventHandler(this.txtDiscount_TextAccepted);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtShopID);
            this.groupBox3.Controls.Add(this.coolLabel13);
            this.groupBox3.Controls.Add(this.coolLabel12);
            this.groupBox3.Controls.Add(this.txtShopCount);
            this.groupBox3.Controls.Add(this.txtShopDescription);
            this.groupBox3.Controls.Add(this.coolLabel9);
            this.groupBox3.Controls.Add(this.coolLabel7);
            this.groupBox3.Controls.Add(this.txtShopDate);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox3.Location = new System.Drawing.Point(8, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فروش";
            // 
            // txtShopID
            // 
            this.txtShopID.Accepted = false;
            this.txtShopID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShopID.BackColor = System.Drawing.Color.Transparent;
            this.txtShopID.CursorLocation = 0;
            this.txtShopID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtShopID.IsEmpty = false;
            this.txtShopID.LengthMax = 1000000;
            this.txtShopID.LengthMin = 0;
            this.txtShopID.Location = new System.Drawing.Point(6, 20);
            this.txtShopID.Mask = "";
            this.txtShopID.Message = "خالی";
            this.txtShopID.MustFill = true;
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.ReadOnly = false;
            this.txtShopID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShopID.Size = new System.Drawing.Size(172, 21);
            this.txtShopID.TabIndex = 0;
            this.txtShopID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtShopID.TextToSet = "";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(184, 20);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(63, 21);
            this.coolLabel13.TabIndex = 30;
            this.coolLabel13.TabStop = false;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "کد فروش:";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(184, 47);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(41, 21);
            this.coolLabel12.TabIndex = 27;
            this.coolLabel12.TabStop = false;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "تعداد:";
            // 
            // txtShopCount
            // 
            this.txtShopCount.Accepted = true;
            this.txtShopCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShopCount.BackColor = System.Drawing.Color.Transparent;
            this.txtShopCount.CursorLocation = 0;
            this.txtShopCount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtShopCount.HaveCurrencySeperator = true;
            this.txtShopCount.IsEmpty = false;
            this.txtShopCount.LengthMax = 40;
            this.txtShopCount.LengthMin = 0;
            this.txtShopCount.Location = new System.Drawing.Point(84, 47);
            this.txtShopCount.Mask = "";
            this.txtShopCount.Message = "خالی";
            this.txtShopCount.MustFill = true;
            this.txtShopCount.Name = "txtShopCount";
            this.txtShopCount.NumberMax = ((long)(1000000));
            this.txtShopCount.NumberMin = ((long)(0));
            this.txtShopCount.ReadOnly = false;
            this.txtShopCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShopCount.Size = new System.Drawing.Size(94, 21);
            this.txtShopCount.TabIndex = 1;
            this.txtShopCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtShopCount.TextToSet = "1";
            this.txtShopCount.TextAccepted += new System.EventHandler(this.txtShopCount_TextAccepted);
            // 
            // txtShopDescription
            // 
            this.txtShopDescription.Accepted = false;
            this.txtShopDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShopDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtShopDescription.CursorLocation = 0;
            this.txtShopDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtShopDescription.IsEmpty = false;
            this.txtShopDescription.LengthMax = 1000000;
            this.txtShopDescription.LengthMin = 0;
            this.txtShopDescription.Location = new System.Drawing.Point(6, 125);
            this.txtShopDescription.Mask = "";
            this.txtShopDescription.Message = "خالی";
            this.txtShopDescription.MustFill = true;
            this.txtShopDescription.Name = "txtShopDescription";
            this.txtShopDescription.ReadOnly = false;
            this.txtShopDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShopDescription.Size = new System.Drawing.Size(241, 21);
            this.txtShopDescription.TabIndex = 3;
            this.txtShopDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtShopDescription.TextToSet = "";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(111, 101);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(137, 21);
            this.coolLabel9.TabIndex = 26;
            this.coolLabel9.TabStop = false;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel9.TextToSet = "توضیحات مربوط به فروش:";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(184, 74);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(63, 21);
            this.coolLabel7.TabIndex = 23;
            this.coolLabel7.TabStop = false;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "تاریخ فروش:";
            // 
            // txtShopDate
            // 
            this.txtShopDate.Accepted = false;
            this.txtShopDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShopDate.BackColor = System.Drawing.Color.Transparent;
            this.txtShopDate.CursorLocation = 8;
            this.txtShopDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtShopDate.IsEmpty = false;
            this.txtShopDate.Location = new System.Drawing.Point(84, 74);
            this.txtShopDate.Mask = "0000/00/00";
            this.txtShopDate.Message = "طول کم";
            this.txtShopDate.MustFill = true;
            this.txtShopDate.Name = "txtShopDate";
            this.txtShopDate.ReadOnly = false;
            this.txtShopDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShopDate.Size = new System.Drawing.Size(94, 21);
            this.txtShopDate.TabIndex = 2;
            this.txtShopDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtShopDate.TextToSet = "    /  /";
            this.txtShopDate.TextAccepted += new System.EventHandler(this.txtShopDate_TextAccepted);
            // 
            // floaterStuffPicker
            // 
            this.floaterStuffPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStuffPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStuffPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStuffPicker.Location = new System.Drawing.Point(9, 68);
            this.floaterStuffPicker.Name = "floaterStuffPicker";
            this.floaterStuffPicker.Size = new System.Drawing.Size(664, 350);
            this.floaterStuffPicker.TabIndex = 4;
            this.floaterStuffPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStuffPicker.TitleText = "";
            this.floaterStuffPicker.Visible = false;
            // 
            // floaterStudentPicker
            // 
            this.floaterStudentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentPicker.Location = new System.Drawing.Point(8, 124);
            this.floaterStudentPicker.Name = "floaterStudentPicker";
            this.floaterStudentPicker.Size = new System.Drawing.Size(664, 296);
            this.floaterStudentPicker.TabIndex = 5;
            this.floaterStudentPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentPicker.TitleText = "";
            this.floaterStudentPicker.Visible = false;
            // 
            // txtFilterDate
            // 
            this.txtFilterDate.Accepted = false;
            this.txtFilterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDate.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDate.CursorLocation = 8;
            this.txtFilterDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDate.IsEmpty = false;
            this.txtFilterDate.Location = new System.Drawing.Point(407, 19);
            this.txtFilterDate.Mask = "0000/00/00";
            this.txtFilterDate.Message = "طول کم";
            this.txtFilterDate.MustFill = true;
            this.txtFilterDate.Name = "txtFilterDate";
            this.txtFilterDate.ReadOnly = false;
            this.txtFilterDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDate.Size = new System.Drawing.Size(102, 21);
            this.txtFilterDate.TabIndex = 24;
            this.txtFilterDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDate.TextToSet = "    /  /";
            this.txtFilterDate.TextChanged += new System.EventHandler(this.txtFilterDate_TextAccepted);
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(515, 19);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(154, 21);
            this.coolLabel14.TabIndex = 23;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "نمایش اطلاعات فروش مربوط به:";
            // 
            // frmShopSellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(697, 457);
            this.Name = "frmShopSellItem";
            this.Text = "فروش کالا";
            this.LoadForm += new System.EventHandler(this.frmShopSellItem_LoadForm);
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
            this.groupBox2.ResumeLayout(false);
            this.groupPay.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolTextBox txtStuffName;
        private HengamWidgets.CoolTextBox txtStuffID;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolTextBox txtCustomerID;
        private HengamWidgets.CoolTextBox txtCustomerName;
        private HengamWidgets.CoolCheckBox chkMiscCustomer;
        private System.Windows.Forms.GroupBox groupPay;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private System.Windows.Forms.GroupBox groupBox3;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolNumberBox txtShopCount;
        private HengamWidgets.CoolTextBox txtShopDescription;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolDateBox txtShopDate;
        private HengamWidgets.PanelFloater floaterStuffPicker;
        private HengamWidgets.CoolTextBox txtShopID;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.PanelFloater floaterStudentPicker;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolDateBox txtFilterDate;


    }
}
