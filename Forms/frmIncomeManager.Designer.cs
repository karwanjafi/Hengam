namespace Hengam.Forms
{
    partial class frmIncomeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncomeManager));
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.tabIncomeTypical = new FarsiLibrary.Win.FATabStripItem();
            this.txtTag = new HengamWidgets.CoolTextBox();
            this.lblTagName = new HengamWidgets.CoolLabel();
            this.cboIncomeTypicalTypeID = new HengamWidgets.CoolComboBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.tabIncomeSellStuff = new FarsiLibrary.Win.FATabStripItem();
            this.txtStuffCount = new HengamWidgets.CoolNumberBox();
            this.txtCustomer = new HengamWidgets.CoolTextBox();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.tabIncomeStudentFee = new FarsiLibrary.Win.FATabStripItem();
            this.txtClassIDStudent = new HengamWidgets.CoolNumberBox();
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.txtClassNameStudent = new HengamWidgets.CoolTextBox();
            this.coolLabel17 = new HengamWidgets.CoolLabel();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.tabTeacherBalance = new FarsiLibrary.Win.FATabStripItem();
            this.txtTeacherClassName = new HengamWidgets.CoolTextBox();
            this.coolLabel18 = new HengamWidgets.CoolLabel();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.coolLabel19 = new HengamWidgets.CoolLabel();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtPayID = new HengamWidgets.CoolTextBox();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.floaterStudentPicker = new HengamWidgets.PanelFloater();
            this.floaterEmployeePicker = new HengamWidgets.PanelFloater();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.floaterStudentClassPicker = new HengamWidgets.PanelFloater();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtFilterDateFrom = new HengamWidgets.CoolDateBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.txtFilterDateTo = new HengamWidgets.CoolDateBox();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.lblIncomeSum = new HengamWidgets.CoolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreviousDay = new HengamWidgets.CoolButton();
            this.btnNextDay = new HengamWidgets.CoolButton();
            this.txtDailyDate = new HengamWidgets.CoolDateBox();
            this.coolLabel20 = new HengamWidgets.CoolLabel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabIncomeTypical.SuspendLayout();
            this.tabIncomeSellStuff.SuspendLayout();
            this.tabIncomeStudentFee.SuspendLayout();
            this.tabTeacherBalance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.panel1);
            this.groupItemDetails.Controls.Add(this.txtPayID);
            this.groupItemDetails.Controls.Add(this.coolLabel1);
            this.groupItemDetails.Controls.Add(this.coolLabel11);
            this.groupItemDetails.Controls.Add(this.cboPayTypeID);
            this.groupItemDetails.Controls.Add(this.txtDescription);
            this.groupItemDetails.Controls.Add(this.coolLabel8);
            this.groupItemDetails.Controls.Add(this.txtCheckNumber);
            this.groupItemDetails.Controls.Add(this.coolLabel6);
            this.groupItemDetails.Controls.Add(this.coolLabel5);
            this.groupItemDetails.Controls.Add(this.coolLabel3);
            this.groupItemDetails.Controls.Add(this.coolLabel10);
            this.groupItemDetails.Controls.Add(this.txtCheckDate);
            this.groupItemDetails.Controls.Add(this.txtPayDate);
            this.groupItemDetails.Controls.Add(this.txtFee);
            this.groupItemDetails.Controls.Add(this.coolLabel4);
            this.groupItemDetails.Controls.Add(this.txtDiscount);
            this.groupItemDetails.Size = new System.Drawing.Size(638, 215);
            this.groupItemDetails.Text = "اطلاعات درآمد";
            this.groupItemDetails.Controls.SetChildIndex(this.txtDiscount, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel4, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtFee, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtPayDate, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtCheckDate, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel10, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel3, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel5, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel6, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtCheckNumber, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel8, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDescription, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.cboPayTypeID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel11, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtPayID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.panel1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(7, 122);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterEmployeePicker);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterStudentClassPicker);
            this.pnlMain.Controls.Add(this.floaterStudentPicker);
            this.pnlMain.Size = new System.Drawing.Size(644, 455);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterEmployeePicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.btnPreviousDay);
            this.groupDatagrid.Controls.Add(this.btnNextDay);
            this.groupDatagrid.Controls.Add(this.txtDailyDate);
            this.groupDatagrid.Controls.Add(this.txtFilterDateFrom);
            this.groupDatagrid.Controls.Add(this.coolLabel20);
            this.groupDatagrid.Controls.Add(this.coolLabel12);
            this.groupDatagrid.Controls.Add(this.coolLabel13);
            this.groupDatagrid.Controls.Add(this.txtFilterDateTo);
            this.groupDatagrid.Controls.Add(this.coolLabel14);
            this.groupDatagrid.Controls.Add(this.lblIncomeSum);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 224);
            this.groupDatagrid.Size = new System.Drawing.Size(638, 228);
            this.groupDatagrid.Controls.SetChildIndex(this.lblIncomeSum, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel14, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.txtFilterDateTo, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel13, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel12, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.coolLabel20, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.txtFilterDateFrom, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.txtDailyDate, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.btnNextDay, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.btnPreviousDay, 0);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "Printer");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Location = new System.Drawing.Point(6, 83);
            this.dataGridSection.Size = new System.Drawing.Size(626, 139);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(193, 47);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Size = new System.Drawing.Size(39, 65);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Size = new System.Drawing.Size(39, 65);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // tabMain
            // 
            this.tabMain.AlwaysShowClose = false;
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabMain.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabIncomeTypical,
            this.tabIncomeSellStuff,
            this.tabIncomeStudentFee,
            this.tabTeacherBalance});
            this.tabMain.Location = new System.Drawing.Point(2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedItem = this.tabTeacherBalance;
            this.tabMain.Size = new System.Drawing.Size(624, 109);
            this.tabMain.TabIndex = 8;
            this.tabMain.Text = "سیستم آموزشی زیتون";
            // 
            // tabIncomeTypical
            // 
            this.tabIncomeTypical.CanClose = false;
            this.tabIncomeTypical.Controls.Add(this.txtTag);
            this.tabIncomeTypical.Controls.Add(this.lblTagName);
            this.tabIncomeTypical.Controls.Add(this.cboIncomeTypicalTypeID);
            this.tabIncomeTypical.Controls.Add(this.coolLabel2);
            this.tabIncomeTypical.IsDrawn = true;
            this.tabIncomeTypical.Name = "tabIncomeTypical";
            this.tabIncomeTypical.Size = new System.Drawing.Size(622, 88);
            this.tabIncomeTypical.TabIndex = 0;
            this.tabIncomeTypical.Title = "سایر درآمدها";
            // 
            // txtTag
            // 
            this.txtTag.Accepted = false;
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.BackColor = System.Drawing.Color.Transparent;
            this.txtTag.CursorLocation = 0;
            this.txtTag.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTag.IsEmpty = false;
            this.txtTag.LengthMax = 1000000;
            this.txtTag.LengthMin = 0;
            this.txtTag.Location = new System.Drawing.Point(294, 43);
            this.txtTag.Mask = "";
            this.txtTag.Message = "خالی";
            this.txtTag.MustFill = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = false;
            this.txtTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTag.Size = new System.Drawing.Size(244, 21);
            this.txtTag.TabIndex = 3;
            this.txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTag.TextToSet = "";
            // 
            // lblTagName
            // 
            this.lblTagName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagName.BackColor = System.Drawing.Color.Transparent;
            this.lblTagName.Location = new System.Drawing.Point(544, 43);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(70, 21);
            this.lblTagName.TabIndex = 4;
            this.lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTagName.TextToSet = "توضیحات:";
            // 
            // cboIncomeTypicalTypeID
            // 
            this.cboIncomeTypicalTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIncomeTypicalTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboIncomeTypicalTypeID.DisplayMember = "";
            this.cboIncomeTypicalTypeID.Location = new System.Drawing.Point(294, 16);
            this.cboIncomeTypicalTypeID.Name = "cboIncomeTypicalTypeID";
            this.cboIncomeTypicalTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboIncomeTypicalTypeID.SelectedItem = null;
            this.cboIncomeTypicalTypeID.Size = new System.Drawing.Size(244, 21);
            this.cboIncomeTypicalTypeID.TabIndex = 5;
            this.cboIncomeTypicalTypeID.SelectedValueChanged += new System.EventHandler(this.cboIncomeTypicalTypeID_SelectedValueChanged);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(544, 16);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(60, 21);
            this.coolLabel2.TabIndex = 4;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "نوع درآمد:";
            // 
            // tabIncomeSellStuff
            // 
            this.tabIncomeSellStuff.CanClose = false;
            this.tabIncomeSellStuff.Controls.Add(this.txtStuffCount);
            this.tabIncomeSellStuff.Controls.Add(this.txtCustomer);
            this.tabIncomeSellStuff.Controls.Add(this.coolLabel15);
            this.tabIncomeSellStuff.Controls.Add(this.txtStuffName);
            this.tabIncomeSellStuff.Controls.Add(this.coolLabel7);
            this.tabIncomeSellStuff.Controls.Add(this.coolLabel9);
            this.tabIncomeSellStuff.IsDrawn = true;
            this.tabIncomeSellStuff.Name = "tabIncomeSellStuff";
            this.tabIncomeSellStuff.Size = new System.Drawing.Size(622, 88);
            this.tabIncomeSellStuff.TabIndex = 1;
            this.tabIncomeSellStuff.Title = "فروش کالا";
            // 
            // txtStuffCount
            // 
            this.txtStuffCount.Accepted = false;
            this.txtStuffCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffCount.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffCount.CursorLocation = 0;
            this.txtStuffCount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffCount.HaveCurrencySeperator = true;
            this.txtStuffCount.IsEmpty = false;
            this.txtStuffCount.LengthMax = 40;
            this.txtStuffCount.LengthMin = 0;
            this.txtStuffCount.Location = new System.Drawing.Point(182, 12);
            this.txtStuffCount.Mask = "";
            this.txtStuffCount.Message = "خالی";
            this.txtStuffCount.MustFill = true;
            this.txtStuffCount.Name = "txtStuffCount";
            this.txtStuffCount.NumberMax = ((long)(1000000));
            this.txtStuffCount.NumberMin = ((long)(0));
            this.txtStuffCount.ReadOnly = false;
            this.txtStuffCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffCount.Size = new System.Drawing.Size(88, 21);
            this.txtStuffCount.TabIndex = 10;
            this.txtStuffCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffCount.TextToSet = "";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Accepted = false;
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomer.CursorLocation = 0;
            this.txtCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomer.IsEmpty = false;
            this.txtCustomer.LengthMax = 1000000;
            this.txtCustomer.LengthMin = 0;
            this.txtCustomer.Location = new System.Drawing.Point(325, 42);
            this.txtCustomer.Mask = "";
            this.txtCustomer.Message = "خالی";
            this.txtCustomer.MustFill = true;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = false;
            this.txtCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomer.Size = new System.Drawing.Size(245, 21);
            this.txtCustomer.TabIndex = 7;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomer.TextToSet = "";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(576, 42);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(43, 21);
            this.coolLabel15.TabIndex = 8;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "خریدار:";
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
            this.txtStuffName.Location = new System.Drawing.Point(325, 12);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = false;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(245, 21);
            this.txtStuffName.TabIndex = 7;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(576, 12);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(43, 21);
            this.coolLabel7.TabIndex = 8;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "نام کالا:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(276, 12);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(43, 21);
            this.coolLabel9.TabIndex = 9;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "تعداد:";
            // 
            // tabIncomeStudentFee
            // 
            this.tabIncomeStudentFee.CanClose = false;
            this.tabIncomeStudentFee.Controls.Add(this.txtClassIDStudent);
            this.tabIncomeStudentFee.Controls.Add(this.txtStudentID);
            this.tabIncomeStudentFee.Controls.Add(this.txtClassNameStudent);
            this.tabIncomeStudentFee.Controls.Add(this.coolLabel17);
            this.tabIncomeStudentFee.Controls.Add(this.txtStudentName);
            this.tabIncomeStudentFee.Controls.Add(this.coolLabel16);
            this.tabIncomeStudentFee.IsDrawn = true;
            this.tabIncomeStudentFee.Name = "tabIncomeStudentFee";
            this.tabIncomeStudentFee.Size = new System.Drawing.Size(622, 88);
            this.tabIncomeStudentFee.TabIndex = 2;
            this.tabIncomeStudentFee.Title = "شهریه‌ی هنرجو";
            // 
            // txtClassIDStudent
            // 
            this.txtClassIDStudent.Accepted = false;
            this.txtClassIDStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassIDStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtClassIDStudent.CursorLocation = 0;
            this.txtClassIDStudent.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassIDStudent.HaveCurrencySeperator = true;
            this.txtClassIDStudent.IsEmpty = false;
            this.txtClassIDStudent.LengthMax = 40;
            this.txtClassIDStudent.LengthMin = 0;
            this.txtClassIDStudent.Location = new System.Drawing.Point(219, 49);
            this.txtClassIDStudent.Mask = "";
            this.txtClassIDStudent.Message = "خالی";
            this.txtClassIDStudent.MustFill = true;
            this.txtClassIDStudent.Name = "txtClassIDStudent";
            this.txtClassIDStudent.NumberMax = ((long)(1000000));
            this.txtClassIDStudent.NumberMin = ((long)(0));
            this.txtClassIDStudent.ReadOnly = false;
            this.txtClassIDStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassIDStudent.Size = new System.Drawing.Size(51, 21);
            this.txtClassIDStudent.TabIndex = 23;
            this.txtClassIDStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassIDStudent.TextToSet = "";
            this.txtClassIDStudent.Visible = false;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Accepted = false;
            this.txtStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentID.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentID.CursorLocation = 0;
            this.txtStudentID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentID.IsEmpty = false;
            this.txtStudentID.LengthMax = 1000000;
            this.txtStudentID.LengthMin = 0;
            this.txtStudentID.Location = new System.Drawing.Point(219, 22);
            this.txtStudentID.Mask = "";
            this.txtStudentID.Message = "خالی";
            this.txtStudentID.MustFill = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentID.Size = new System.Drawing.Size(51, 21);
            this.txtStudentID.TabIndex = 21;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentID.TextToSet = "";
            this.txtStudentID.Visible = false;
            // 
            // txtClassNameStudent
            // 
            this.txtClassNameStudent.Accepted = false;
            this.txtClassNameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassNameStudent.BackColor = System.Drawing.Color.Transparent;
            this.txtClassNameStudent.CursorLocation = 0;
            this.txtClassNameStudent.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassNameStudent.IsEmpty = false;
            this.txtClassNameStudent.LengthMax = 1000000;
            this.txtClassNameStudent.LengthMin = 0;
            this.txtClassNameStudent.Location = new System.Drawing.Point(276, 49);
            this.txtClassNameStudent.Mask = "";
            this.txtClassNameStudent.Message = "خالی";
            this.txtClassNameStudent.MustFill = true;
            this.txtClassNameStudent.Name = "txtClassNameStudent";
            this.txtClassNameStudent.ReadOnly = true;
            this.txtClassNameStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassNameStudent.Size = new System.Drawing.Size(281, 21);
            this.txtClassNameStudent.TabIndex = 18;
            this.txtClassNameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassNameStudent.TextToSet = "";
            this.txtClassNameStudent.Click += new System.EventHandler(this.txtClassNameStudent_Click);
            // 
            // coolLabel17
            // 
            this.coolLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel17.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel17.Location = new System.Drawing.Point(563, 49);
            this.coolLabel17.Name = "coolLabel17";
            this.coolLabel17.Size = new System.Drawing.Size(47, 21);
            this.coolLabel17.TabIndex = 19;
            this.coolLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel17.TextToSet = "کلاس:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Accepted = false;
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentName.CursorLocation = 0;
            this.txtStudentName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentName.IsEmpty = false;
            this.txtStudentName.LengthMax = 1000000;
            this.txtStudentName.LengthMin = 0;
            this.txtStudentName.Location = new System.Drawing.Point(276, 22);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(281, 21);
            this.txtStudentName.TabIndex = 20;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            this.txtStudentName.Click += new System.EventHandler(this.txtStudentName_Click);
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(563, 22);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(47, 21);
            this.coolLabel16.TabIndex = 22;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "هنرجو:";
            // 
            // tabTeacherBalance
            // 
            this.tabTeacherBalance.Controls.Add(this.txtTeacherClassName);
            this.tabTeacherBalance.Controls.Add(this.coolLabel18);
            this.tabTeacherBalance.Controls.Add(this.txtTeacherName);
            this.tabTeacherBalance.Controls.Add(this.coolLabel19);
            this.tabTeacherBalance.IsDrawn = true;
            this.tabTeacherBalance.Name = "tabTeacherBalance";
            this.tabTeacherBalance.Selected = true;
            this.tabTeacherBalance.Size = new System.Drawing.Size(622, 88);
            this.tabTeacherBalance.TabIndex = 3;
            this.tabTeacherBalance.Title = "تسویه حساب استاد";
            // 
            // txtTeacherClassName
            // 
            this.txtTeacherClassName.Accepted = false;
            this.txtTeacherClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherClassName.BackColor = System.Drawing.Color.Transparent;
            this.txtTeacherClassName.CursorLocation = 0;
            this.txtTeacherClassName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTeacherClassName.IsEmpty = false;
            this.txtTeacherClassName.LengthMax = 1000000;
            this.txtTeacherClassName.LengthMin = 0;
            this.txtTeacherClassName.Location = new System.Drawing.Point(274, 46);
            this.txtTeacherClassName.Mask = "";
            this.txtTeacherClassName.Message = "خالی";
            this.txtTeacherClassName.MustFill = true;
            this.txtTeacherClassName.Name = "txtTeacherClassName";
            this.txtTeacherClassName.ReadOnly = true;
            this.txtTeacherClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherClassName.Size = new System.Drawing.Size(281, 21);
            this.txtTeacherClassName.TabIndex = 23;
            this.txtTeacherClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherClassName.TextToSet = "";
            // 
            // coolLabel18
            // 
            this.coolLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel18.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel18.Location = new System.Drawing.Point(561, 46);
            this.coolLabel18.Name = "coolLabel18";
            this.coolLabel18.Size = new System.Drawing.Size(47, 21);
            this.coolLabel18.TabIndex = 24;
            this.coolLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel18.TextToSet = "کلاس:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Accepted = false;
            this.txtTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.txtTeacherName.CursorLocation = 0;
            this.txtTeacherName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTeacherName.IsEmpty = false;
            this.txtTeacherName.LengthMax = 1000000;
            this.txtTeacherName.LengthMin = 0;
            this.txtTeacherName.Location = new System.Drawing.Point(274, 19);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(281, 21);
            this.txtTeacherName.TabIndex = 25;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            // 
            // coolLabel19
            // 
            this.coolLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel19.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel19.Location = new System.Drawing.Point(561, 19);
            this.coolLabel19.Name = "coolLabel19";
            this.coolLabel19.Size = new System.Drawing.Size(47, 21);
            this.coolLabel19.TabIndex = 26;
            this.coolLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel19.TextToSet = "استاد:";
            // 
            // txtDescription
            // 
            this.txtDescription.Accepted = false;
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.CursorLocation = 0;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDescription.IsEmpty = false;
            this.txtDescription.LengthMax = 999999999;
            this.txtDescription.LengthMin = 0;
            this.txtDescription.Location = new System.Drawing.Point(43, 44);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(165, 21);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(157, 17);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(51, 21);
            this.coolLabel8.TabIndex = 4;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "توضیحات:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(214, 44);
            this.txtCheckDate.Mask = "0000/00/00";
            this.txtCheckDate.Message = "طول کم";
            this.txtCheckDate.MustFill = true;
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = false;
            this.txtCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckDate.Size = new System.Drawing.Size(114, 21);
            this.txtCheckDate.TabIndex = 7;
            this.txtCheckDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckDate.TextToSet = "    /  /";
            // 
            // txtPayDate
            // 
            this.txtPayDate.Accepted = false;
            this.txtPayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayDate.BackColor = System.Drawing.Color.Transparent;
            this.txtPayDate.CursorLocation = 8;
            this.txtPayDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPayDate.IsEmpty = false;
            this.txtPayDate.Location = new System.Drawing.Point(214, 17);
            this.txtPayDate.Mask = "0000/00/00";
            this.txtPayDate.Message = "طول کم";
            this.txtPayDate.MustFill = true;
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = false;
            this.txtPayDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayDate.Size = new System.Drawing.Size(114, 21);
            this.txtPayDate.TabIndex = 7;
            this.txtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayDate.TextToSet = "    /  /";
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
            this.txtDiscount.Location = new System.Drawing.Point(436, 44);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
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
            this.txtFee.Location = new System.Drawing.Point(436, 17);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(10000000000));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = false;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 6;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFee.TextToSet = "";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(334, 44);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(81, 21);
            this.coolLabel6.TabIndex = 4;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "تاریخ چک:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(334, 17);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(81, 21);
            this.coolLabel5.TabIndex = 4;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(556, 44);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(81, 21);
            this.coolLabel4.TabIndex = 4;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "تخفیف:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(556, 17);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(81, 21);
            this.coolLabel3.TabIndex = 4;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "مبلغ:";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(59, 20);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(54, 21);
            this.coolLabel1.TabIndex = 4;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد درآمد:";
            this.coolLabel1.Visible = false;
            // 
            // txtPayID
            // 
            this.txtPayID.Accepted = false;
            this.txtPayID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayID.BackColor = System.Drawing.Color.Transparent;
            this.txtPayID.CursorLocation = 0;
            this.txtPayID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPayID.IsEmpty = false;
            this.txtPayID.LengthMax = 1000000;
            this.txtPayID.LengthMin = 0;
            this.txtPayID.Location = new System.Drawing.Point(7, 20);
            this.txtPayID.Mask = "";
            this.txtPayID.Message = "خالی";
            this.txtPayID.MustFill = true;
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.ReadOnly = true;
            this.txtPayID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayID.Size = new System.Drawing.Size(46, 21);
            this.txtPayID.TabIndex = 3;
            this.txtPayID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayID.TextToSet = "";
            this.txtPayID.Visible = false;
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(9, 165);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(626, 282);
            this.floaterTeacherPicker.TabIndex = 16;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // floaterStudentPicker
            // 
            this.floaterStudentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentPicker.Location = new System.Drawing.Point(9, 165);
            this.floaterStudentPicker.Name = "floaterStudentPicker";
            this.floaterStudentPicker.Size = new System.Drawing.Size(626, 282);
            this.floaterStudentPicker.TabIndex = 17;
            this.floaterStudentPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentPicker.TitleText = "";
            this.floaterStudentPicker.Visible = false;
            // 
            // floaterEmployeePicker
            // 
            this.floaterEmployeePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterEmployeePicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterEmployeePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterEmployeePicker.Location = new System.Drawing.Point(9, 164);
            this.floaterEmployeePicker.Name = "floaterEmployeePicker";
            this.floaterEmployeePicker.Size = new System.Drawing.Size(626, 282);
            this.floaterEmployeePicker.TabIndex = 18;
            this.floaterEmployeePicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterEmployeePicker.TitleText = "";
            this.floaterEmployeePicker.Visible = false;
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(334, 71);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(74, 21);
            this.coolLabel10.TabIndex = 4;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "شماره‌ی چک:";
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
            this.txtCheckNumber.Location = new System.Drawing.Point(214, 71);
            this.txtCheckNumber.Mask = "";
            this.txtCheckNumber.Message = "خالی";
            this.txtCheckNumber.MustFill = true;
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.ReadOnly = false;
            this.txtCheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckNumber.Size = new System.Drawing.Size(114, 21);
            this.txtCheckNumber.TabIndex = 3;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckNumber.TextToSet = "";
            // 
            // floaterStudentClassPicker
            // 
            this.floaterStudentClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentClassPicker.Location = new System.Drawing.Point(10, 165);
            this.floaterStudentClassPicker.Name = "floaterStudentClassPicker";
            this.floaterStudentClassPicker.Size = new System.Drawing.Size(626, 282);
            this.floaterStudentClassPicker.TabIndex = 20;
            this.floaterStudentClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentClassPicker.TitleText = "";
            this.floaterStudentClassPicker.Visible = false;
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(556, 71);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(77, 21);
            this.coolLabel11.TabIndex = 6;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Location = new System.Drawing.Point(436, 71);
            this.cboPayTypeID.Name = "cboPayTypeID";
            this.cboPayTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPayTypeID.SelectedItem = null;
            this.cboPayTypeID.Size = new System.Drawing.Size(114, 21);
            this.cboPayTypeID.TabIndex = 7;
            // 
            // txtFilterDateFrom
            // 
            this.txtFilterDateFrom.Accepted = false;
            this.txtFilterDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateFrom.CursorLocation = 8;
            this.txtFilterDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateFrom.IsEmpty = false;
            this.txtFilterDateFrom.Location = new System.Drawing.Point(299, 20);
            this.txtFilterDateFrom.Mask = "0000/00/00";
            this.txtFilterDateFrom.Message = "طول کم";
            this.txtFilterDateFrom.MustFill = true;
            this.txtFilterDateFrom.Name = "txtFilterDateFrom";
            this.txtFilterDateFrom.ReadOnly = false;
            this.txtFilterDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateFrom.Size = new System.Drawing.Size(101, 21);
            this.txtFilterDateFrom.TabIndex = 7;
            this.txtFilterDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateFrom.TextToSet = "    /  /";
            this.txtFilterDateFrom.TextChanged += new System.EventHandler(this.txtFilterDateFrom_TextChanged);
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(559, 20);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(63, 21);
            this.coolLabel12.TabIndex = 4;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "گزارش روز:";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(274, 20);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(19, 21);
            this.coolLabel13.TabIndex = 4;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "تا:";
            // 
            // txtFilterDateTo
            // 
            this.txtFilterDateTo.Accepted = false;
            this.txtFilterDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateTo.CursorLocation = 8;
            this.txtFilterDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateTo.IsEmpty = false;
            this.txtFilterDateTo.Location = new System.Drawing.Point(167, 20);
            this.txtFilterDateTo.Mask = "0000/00/00";
            this.txtFilterDateTo.Message = "طول کم";
            this.txtFilterDateTo.MustFill = true;
            this.txtFilterDateTo.Name = "txtFilterDateTo";
            this.txtFilterDateTo.ReadOnly = false;
            this.txtFilterDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateTo.Size = new System.Drawing.Size(101, 21);
            this.txtFilterDateTo.TabIndex = 7;
            this.txtFilterDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateTo.TextToSet = "    /  /";
            this.txtFilterDateTo.TextChanged += new System.EventHandler(this.txtFilterDateFrom_TextChanged);
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(290, 47);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(159, 21);
            this.coolLabel14.TabIndex = 4;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "کل درآمد در تاریخ مشخص شده:";
            // 
            // lblIncomeSum
            // 
            this.lblIncomeSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeSum.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeSum.Location = new System.Drawing.Point(167, 47);
            this.lblIncomeSum.Name = "lblIncomeSum";
            this.lblIncomeSum.Size = new System.Drawing.Size(117, 21);
            this.lblIncomeSum.TabIndex = 4;
            this.lblIncomeSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIncomeSum.TextToSet = "-";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(5, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 111);
            this.panel1.TabIndex = 9;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreviousDay.Location = new System.Drawing.Point(545, 45);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(63, 27);
            this.btnPreviousDay.TabIndex = 32;
            this.btnPreviousDay.TextToSet = "روز قبل";
            this.btnPreviousDay.Clicked += new System.EventHandler(this.btnPreviousDay_Clicked);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextDay.Location = new System.Drawing.Point(476, 45);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(63, 27);
            this.btnNextDay.TabIndex = 33;
            this.btnNextDay.TextToSet = "روز بعد";
            this.btnNextDay.Clicked += new System.EventHandler(this.btnNextDay_Clicked);
            // 
            // txtDailyDate
            // 
            this.txtDailyDate.Accepted = false;
            this.txtDailyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDailyDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDailyDate.CursorLocation = 8;
            this.txtDailyDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDailyDate.IsEmpty = false;
            this.txtDailyDate.Location = new System.Drawing.Point(456, 20);
            this.txtDailyDate.Mask = "0000/00/00";
            this.txtDailyDate.Message = "طول کم";
            this.txtDailyDate.MustFill = true;
            this.txtDailyDate.Name = "txtDailyDate";
            this.txtDailyDate.ReadOnly = false;
            this.txtDailyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDailyDate.Size = new System.Drawing.Size(97, 21);
            this.txtDailyDate.TabIndex = 31;
            this.txtDailyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDailyDate.TextToSet = "    /  /";
            this.txtDailyDate.TextAccepted += new System.EventHandler(this.txtDailyDate_TextAccepted);
            // 
            // coolLabel20
            // 
            this.coolLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel20.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel20.Location = new System.Drawing.Point(407, 20);
            this.coolLabel20.Name = "coolLabel20";
            this.coolLabel20.Size = new System.Drawing.Size(30, 21);
            this.coolLabel20.TabIndex = 4;
            this.coolLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel20.TextToSet = "از:";
            // 
            // frmIncomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(660, 483);
            this.Name = "frmIncomeManager";
            this.Text = "مدیریت درآمدها";
            this.LoadForm += new System.EventHandler(this.frmIncomeManager_LoadForm);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabIncomeTypical.ResumeLayout(false);
            this.tabIncomeSellStuff.ResumeLayout(false);
            this.tabIncomeStudentFee.ResumeLayout(false);
            this.tabTeacherBalance.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip tabMain;
        private FarsiLibrary.Win.FATabStripItem tabIncomeTypical;
        private FarsiLibrary.Win.FATabStripItem tabIncomeSellStuff;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolComboBox cboIncomeTypicalTypeID;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolTextBox txtPayID;
        private HengamWidgets.CoolTextBox txtTag;
        private HengamWidgets.CoolLabel lblTagName;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.PanelFloater floaterEmployeePicker;
        private HengamWidgets.PanelFloater floaterStudentPicker;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.CoolNumberBox txtStuffCount;
        private HengamWidgets.CoolTextBox txtStuffName;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel10;
        private FarsiLibrary.Win.FATabStripItem tabIncomeStudentFee;
        private HengamWidgets.CoolNumberBox txtClassIDStudent;
        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.CoolTextBox txtClassNameStudent;
        private HengamWidgets.CoolLabel coolLabel17;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.PanelFloater floaterStudentClassPicker;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolDateBox txtFilterDateFrom;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.CoolDateBox txtFilterDateTo;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel lblIncomeSum;
        private System.Windows.Forms.Panel panel1;
        private HengamWidgets.CoolTextBox txtCustomer;
        private HengamWidgets.CoolLabel coolLabel15;
        private FarsiLibrary.Win.FATabStripItem tabTeacherBalance;
        private HengamWidgets.CoolTextBox txtTeacherClassName;
        private HengamWidgets.CoolLabel coolLabel18;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.CoolLabel coolLabel19;
        private HengamWidgets.CoolButton btnPreviousDay;
        private HengamWidgets.CoolButton btnNextDay;
        private HengamWidgets.CoolDateBox txtDailyDate;
        private HengamWidgets.CoolLabel coolLabel20;
    }
}
