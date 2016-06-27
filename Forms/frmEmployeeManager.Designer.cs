namespace Hengam.Forms
{
    partial class frmEmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.tabPrimaryInfo = new FarsiLibrary.Win.FATabStripItem();
            this.picImage = new HengamWidgets.CoolImageContainer();
            this.nextTabber1 = new Hengam.Controls.NextTabber();
            this.txtFatherName = new HengamWidgets.CoolTextBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.txtLastName = new HengamWidgets.CoolTextBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.txtFirstName = new HengamWidgets.CoolTextBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.txtEmployeeID = new HengamWidgets.CoolTextBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.tabAdditionalInfo = new FarsiLibrary.Win.FATabStripItem();
            this.nextTabber2 = new Hengam.Controls.NextTabber();
            this.cboMartialStatus = new HengamWidgets.CoolComboBox();
            this.cboGender = new HengamWidgets.CoolComboBox();
            this.coolLabel19 = new HengamWidgets.CoolLabel();
            this.coolLabel20 = new HengamWidgets.CoolLabel();
            this.txtIssuePlace = new HengamWidgets.CoolTextBox();
            this.txtBornPlace = new HengamWidgets.CoolTextBox();
            this.txtNationalNumber = new HengamWidgets.CoolTextBox();
            this.txtBornProvince = new HengamWidgets.CoolTextBox();
            this.txtBornCountry = new HengamWidgets.CoolTextBox();
            this.txtBirthDate = new HengamWidgets.CoolDateBox();
            this.txtCertificationNumber = new HengamWidgets.CoolNumberBox();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.tabEducationInfo = new FarsiLibrary.Win.FATabStripItem();
            this.chkStudyStatus = new HengamWidgets.CoolCheckBox();
            this.cboDegreeTypeID = new HengamWidgets.CoolComboBox();
            this.cboDegreeLevelID = new HengamWidgets.CoolComboBox();
            this.txtJob = new HengamWidgets.CoolTextBox();
            this.txtSchool = new HengamWidgets.CoolTextBox();
            this.txtStudyMajor = new HengamWidgets.CoolTextBox();
            this.coolLabel17 = new HengamWidgets.CoolLabel();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.nextTabber3 = new Hengam.Controls.NextTabber();
            this.tabLocationInfo = new FarsiLibrary.Win.FATabStripItem();
            this.nextTabber4 = new Hengam.Controls.NextTabber();
            this.cboHowtoFindID = new HengamWidgets.CoolComboBox();
            this.txtGuarantorID = new HengamWidgets.CoolTextBox();
            this.txtGurarantorName = new HengamWidgets.CoolTextBox();
            this.txtCellPhone = new HengamWidgets.CoolTextBox();
            this.txtHomeTell = new HengamWidgets.CoolTextBox();
            this.txtHomeAddress = new HengamWidgets.CoolTextBox();
            this.coolLabel26 = new HengamWidgets.CoolLabel();
            this.coolLabel18 = new HengamWidgets.CoolLabel();
            this.coolLabel25 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.coolLabel30 = new HengamWidgets.CoolLabel();
            this.coolLabel28 = new HengamWidgets.CoolLabel();
            this.tabUserInfo = new FarsiLibrary.Win.FATabStripItem();
            this.nextTabber5 = new Hengam.Controls.NextTabber();
            this.chkActivityStatus = new HengamWidgets.CoolCheckBox();
            this.floaterGuarantorPicker = new HengamWidgets.PanelFloater();
            this.floaterContainter = new HengamWidgets.PanelFloater();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPrimaryInfo.SuspendLayout();
            this.tabAdditionalInfo.SuspendLayout();
            this.tabEducationInfo.SuspendLayout();
            this.tabLocationInfo.SuspendLayout();
            this.tabUserInfo.SuspendLayout();
            this.pnlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.pnlGroup);
            this.groupItemDetails.Size = new System.Drawing.Size(672, 162);
            this.groupItemDetails.TabIndex = 0;
            this.groupItemDetails.Text = "اطلاعات کارمند";
            this.groupItemDetails.Controls.SetChildIndex(this.pnlGroup, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupButtons.Location = new System.Drawing.Point(6, 70);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterContainter);
            this.pnlMain.Controls.Add(this.floaterGuarantorPicker);
            this.pnlMain.Size = new System.Drawing.Size(678, 314);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Controls.SetChildIndex(this.floaterGuarantorPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainter, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 171);
            this.groupDatagrid.Size = new System.Drawing.Size(672, 140);
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
            this.dataGridSection.Size = new System.Drawing.Size(660, 114);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_LoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(210, 47);
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
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabMain.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabPrimaryInfo,
            this.tabAdditionalInfo,
            this.tabEducationInfo,
            this.tabLocationInfo,
            this.tabUserInfo});
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedItem = this.tabPrimaryInfo;
            this.tabMain.Size = new System.Drawing.Size(666, 142);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "سیستم آموزشی زیتون";
            // 
            // tabPrimaryInfo
            // 
            this.tabPrimaryInfo.CanClose = false;
            this.tabPrimaryInfo.Controls.Add(this.picImage);
            this.tabPrimaryInfo.Controls.Add(this.nextTabber1);
            this.tabPrimaryInfo.Controls.Add(this.txtFatherName);
            this.tabPrimaryInfo.Controls.Add(this.coolLabel4);
            this.tabPrimaryInfo.Controls.Add(this.txtLastName);
            this.tabPrimaryInfo.Controls.Add(this.coolLabel3);
            this.tabPrimaryInfo.Controls.Add(this.txtFirstName);
            this.tabPrimaryInfo.Controls.Add(this.coolLabel2);
            this.tabPrimaryInfo.Controls.Add(this.txtEmployeeID);
            this.tabPrimaryInfo.Controls.Add(this.coolLabel1);
            this.tabPrimaryInfo.Image = ((System.Drawing.Image)(resources.GetObject("tabPrimaryInfo.Image")));
            this.tabPrimaryInfo.IsDrawn = true;
            this.tabPrimaryInfo.Name = "tabPrimaryInfo";
            this.tabPrimaryInfo.Selected = true;
            this.tabPrimaryInfo.Size = new System.Drawing.Size(664, 121);
            this.tabPrimaryInfo.TabIndex = 0;
            this.tabPrimaryInfo.Title = "اطلاعات پایه";
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.Image = null;
            this.picImage.Location = new System.Drawing.Point(339, 13);
            this.picImage.MustFill = false;
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(86, 99);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // nextTabber1
            // 
            this.nextTabber1.BackColor = System.Drawing.Color.Transparent;
            this.nextTabber1.Location = new System.Drawing.Point(4, 3);
            this.nextTabber1.Name = "nextTabber1";
            this.nextTabber1.NextTabIndex = -1;
            this.nextTabber1.Size = new System.Drawing.Size(35, 27);
            this.nextTabber1.TabIndex = 3;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Accepted = true;
            this.txtFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFatherName.BackColor = System.Drawing.Color.Transparent;
            this.txtFatherName.CursorLocation = 0;
            this.txtFatherName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFatherName.IsEmpty = false;
            this.txtFatherName.LengthMax = 20;
            this.txtFatherName.LengthMin = 0;
            this.txtFatherName.Location = new System.Drawing.Point(431, 92);
            this.txtFatherName.Mask = "";
            this.txtFatherName.Message = "خالی";
            this.txtFatherName.MustFill = true;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.ReadOnly = false;
            this.txtFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFatherName.Size = new System.Drawing.Size(126, 21);
            this.txtFatherName.TabIndex = 2;
            this.txtFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFatherName.TextToSet = "";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(563, 92);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(88, 21);
            this.coolLabel4.TabIndex = 0;
            this.coolLabel4.TabStop = false;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "نام پدر:";
            // 
            // txtLastName
            // 
            this.txtLastName.Accepted = true;
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.CursorLocation = 0;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtLastName.IsEmpty = false;
            this.txtLastName.LengthMax = 20;
            this.txtLastName.LengthMin = 0;
            this.txtLastName.Location = new System.Drawing.Point(431, 65);
            this.txtLastName.Mask = "";
            this.txtLastName.Message = "خالی";
            this.txtLastName.MustFill = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(126, 21);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.TextToSet = "";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(563, 65);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(88, 21);
            this.coolLabel3.TabIndex = 0;
            this.coolLabel3.TabStop = false;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "نام خانوادگی:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Accepted = true;
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.CursorLocation = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFirstName.IsEmpty = false;
            this.txtFirstName.LengthMax = 20;
            this.txtFirstName.LengthMin = 0;
            this.txtFirstName.Location = new System.Drawing.Point(431, 38);
            this.txtFirstName.Mask = "";
            this.txtFirstName.Message = "خالی";
            this.txtFirstName.MustFill = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(126, 21);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.TextToSet = "";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(563, 38);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(88, 21);
            this.coolLabel2.TabIndex = 0;
            this.coolLabel2.TabStop = false;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "نام:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Accepted = true;
            this.txtEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeID.CursorLocation = 0;
            this.txtEmployeeID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmployeeID.IsEmpty = false;
            this.txtEmployeeID.LengthMax = 20;
            this.txtEmployeeID.LengthMin = 0;
            this.txtEmployeeID.Location = new System.Drawing.Point(431, 11);
            this.txtEmployeeID.Mask = "";
            this.txtEmployeeID.Message = "خالی";
            this.txtEmployeeID.MustFill = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeID.Size = new System.Drawing.Size(126, 21);
            this.txtEmployeeID.TabIndex = 4;
            this.txtEmployeeID.TabStop = false;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeID.TextToSet = "";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(563, 11);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(88, 21);
            this.coolLabel1.TabIndex = 0;
            this.coolLabel1.TabStop = false;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد کارمندی:";
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.CanClose = false;
            this.tabAdditionalInfo.Controls.Add(this.nextTabber2);
            this.tabAdditionalInfo.Controls.Add(this.cboMartialStatus);
            this.tabAdditionalInfo.Controls.Add(this.cboGender);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel19);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel20);
            this.tabAdditionalInfo.Controls.Add(this.txtIssuePlace);
            this.tabAdditionalInfo.Controls.Add(this.txtBornPlace);
            this.tabAdditionalInfo.Controls.Add(this.txtNationalNumber);
            this.tabAdditionalInfo.Controls.Add(this.txtBornProvince);
            this.tabAdditionalInfo.Controls.Add(this.txtBornCountry);
            this.tabAdditionalInfo.Controls.Add(this.txtBirthDate);
            this.tabAdditionalInfo.Controls.Add(this.txtCertificationNumber);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel10);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel9);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel11);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel8);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel7);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel6);
            this.tabAdditionalInfo.Controls.Add(this.coolLabel5);
            this.tabAdditionalInfo.IsDrawn = true;
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.Size = new System.Drawing.Size(664, 121);
            this.tabAdditionalInfo.TabIndex = 0;
            this.tabAdditionalInfo.Title = "اطلاعات تکمیلی";
            // 
            // nextTabber2
            // 
            this.nextTabber2.BackColor = System.Drawing.Color.Transparent;
            this.nextTabber2.Location = new System.Drawing.Point(5, 5);
            this.nextTabber2.Name = "nextTabber2";
            this.nextTabber2.NextTabIndex = -1;
            this.nextTabber2.Size = new System.Drawing.Size(35, 27);
            this.nextTabber2.TabIndex = 9;
            // 
            // cboMartialStatus
            // 
            this.cboMartialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMartialStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboMartialStatus.DisplayMember = "";
            this.cboMartialStatus.Location = new System.Drawing.Point(88, 73);
            this.cboMartialStatus.Name = "cboMartialStatus";
            this.cboMartialStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboMartialStatus.SelectedItem = null;
            this.cboMartialStatus.Size = new System.Drawing.Size(73, 21);
            this.cboMartialStatus.TabIndex = 8;
            // 
            // cboGender
            // 
            this.cboGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.DisplayMember = "";
            this.cboGender.Location = new System.Drawing.Point(88, 46);
            this.cboGender.Name = "cboGender";
            this.cboGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboGender.SelectedItem = null;
            this.cboGender.Size = new System.Drawing.Size(73, 21);
            this.cboGender.TabIndex = 7;
            // 
            // coolLabel19
            // 
            this.coolLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel19.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel19.Location = new System.Drawing.Point(167, 46);
            this.coolLabel19.Name = "coolLabel19";
            this.coolLabel19.Size = new System.Drawing.Size(72, 21);
            this.coolLabel19.TabIndex = 10;
            this.coolLabel19.TabStop = false;
            this.coolLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel19.TextToSet = "جنسیت:";
            // 
            // coolLabel20
            // 
            this.coolLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel20.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel20.Location = new System.Drawing.Point(167, 73);
            this.coolLabel20.Name = "coolLabel20";
            this.coolLabel20.Size = new System.Drawing.Size(72, 21);
            this.coolLabel20.TabIndex = 11;
            this.coolLabel20.TabStop = false;
            this.coolLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel20.TextToSet = "وضعیت تاهل:";
            // 
            // txtIssuePlace
            // 
            this.txtIssuePlace.Accepted = false;
            this.txtIssuePlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuePlace.BackColor = System.Drawing.Color.Transparent;
            this.txtIssuePlace.CursorLocation = 0;
            this.txtIssuePlace.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtIssuePlace.IsEmpty = false;
            this.txtIssuePlace.LengthMax = 50;
            this.txtIssuePlace.LengthMin = 0;
            this.txtIssuePlace.Location = new System.Drawing.Point(88, 19);
            this.txtIssuePlace.Mask = "";
            this.txtIssuePlace.Message = "خالی";
            this.txtIssuePlace.MustFill = true;
            this.txtIssuePlace.Name = "txtIssuePlace";
            this.txtIssuePlace.ReadOnly = false;
            this.txtIssuePlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIssuePlace.Size = new System.Drawing.Size(73, 21);
            this.txtIssuePlace.TabIndex = 6;
            this.txtIssuePlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIssuePlace.TextToSet = "";
            // 
            // txtBornPlace
            // 
            this.txtBornPlace.Accepted = false;
            this.txtBornPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBornPlace.BackColor = System.Drawing.Color.Transparent;
            this.txtBornPlace.CursorLocation = 0;
            this.txtBornPlace.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBornPlace.IsEmpty = false;
            this.txtBornPlace.LengthMax = 50;
            this.txtBornPlace.LengthMin = 0;
            this.txtBornPlace.Location = new System.Drawing.Point(254, 73);
            this.txtBornPlace.Mask = "";
            this.txtBornPlace.Message = "خالی";
            this.txtBornPlace.MustFill = true;
            this.txtBornPlace.Name = "txtBornPlace";
            this.txtBornPlace.ReadOnly = false;
            this.txtBornPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBornPlace.Size = new System.Drawing.Size(90, 21);
            this.txtBornPlace.TabIndex = 5;
            this.txtBornPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBornPlace.TextToSet = "";
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Accepted = false;
            this.txtNationalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalNumber.CursorLocation = 0;
            this.txtNationalNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtNationalNumber.IsEmpty = false;
            this.txtNationalNumber.LengthMax = 10;
            this.txtNationalNumber.LengthMin = 10;
            this.txtNationalNumber.Location = new System.Drawing.Point(445, 46);
            this.txtNationalNumber.Mask = "";
            this.txtNationalNumber.Message = "خالی";
            this.txtNationalNumber.MustFill = true;
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.ReadOnly = false;
            this.txtNationalNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalNumber.Size = new System.Drawing.Size(105, 21);
            this.txtNationalNumber.TabIndex = 1;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNationalNumber.TextToSet = "";
            // 
            // txtBornProvince
            // 
            this.txtBornProvince.Accepted = false;
            this.txtBornProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBornProvince.BackColor = System.Drawing.Color.Transparent;
            this.txtBornProvince.CursorLocation = 0;
            this.txtBornProvince.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBornProvince.IsEmpty = false;
            this.txtBornProvince.LengthMax = 50;
            this.txtBornProvince.LengthMin = 0;
            this.txtBornProvince.Location = new System.Drawing.Point(254, 46);
            this.txtBornProvince.Mask = "";
            this.txtBornProvince.Message = "خالی";
            this.txtBornProvince.MustFill = true;
            this.txtBornProvince.Name = "txtBornProvince";
            this.txtBornProvince.ReadOnly = false;
            this.txtBornProvince.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBornProvince.Size = new System.Drawing.Size(90, 21);
            this.txtBornProvince.TabIndex = 4;
            this.txtBornProvince.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBornProvince.TextToSet = "";
            // 
            // txtBornCountry
            // 
            this.txtBornCountry.Accepted = false;
            this.txtBornCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBornCountry.BackColor = System.Drawing.Color.Transparent;
            this.txtBornCountry.CursorLocation = 0;
            this.txtBornCountry.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBornCountry.IsEmpty = false;
            this.txtBornCountry.LengthMax = 50;
            this.txtBornCountry.LengthMin = 0;
            this.txtBornCountry.Location = new System.Drawing.Point(254, 19);
            this.txtBornCountry.Mask = "";
            this.txtBornCountry.Message = "خالی";
            this.txtBornCountry.MustFill = true;
            this.txtBornCountry.Name = "txtBornCountry";
            this.txtBornCountry.ReadOnly = false;
            this.txtBornCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBornCountry.Size = new System.Drawing.Size(90, 21);
            this.txtBornCountry.TabIndex = 3;
            this.txtBornCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBornCountry.TextToSet = "";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Accepted = false;
            this.txtBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBirthDate.CursorLocation = 8;
            this.txtBirthDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBirthDate.IsEmpty = false;
            this.txtBirthDate.Location = new System.Drawing.Point(445, 73);
            this.txtBirthDate.Mask = "0000/00/00";
            this.txtBirthDate.Message = "طول کم";
            this.txtBirthDate.MustFill = true;
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = false;
            this.txtBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBirthDate.Size = new System.Drawing.Size(105, 21);
            this.txtBirthDate.TabIndex = 2;
            this.txtBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBirthDate.TextToSet = "    /  /";
            // 
            // txtCertificationNumber
            // 
            this.txtCertificationNumber.Accepted = false;
            this.txtCertificationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCertificationNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtCertificationNumber.CursorLocation = 0;
            this.txtCertificationNumber.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCertificationNumber.HaveCurrencySeperator = false;
            this.txtCertificationNumber.IsEmpty = false;
            this.txtCertificationNumber.LengthMax = 20;
            this.txtCertificationNumber.LengthMin = 1;
            this.txtCertificationNumber.Location = new System.Drawing.Point(445, 19);
            this.txtCertificationNumber.Mask = "";
            this.txtCertificationNumber.Message = "خالی";
            this.txtCertificationNumber.MustFill = true;
            this.txtCertificationNumber.Name = "txtCertificationNumber";
            this.txtCertificationNumber.NumberMax = ((long)(1000000));
            this.txtCertificationNumber.NumberMin = ((long)(0));
            this.txtCertificationNumber.ReadOnly = false;
            this.txtCertificationNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCertificationNumber.Size = new System.Drawing.Size(105, 21);
            this.txtCertificationNumber.TabIndex = 0;
            this.txtCertificationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCertificationNumber.TextToSet = "";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(350, 73);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(88, 21);
            this.coolLabel10.TabIndex = 3;
            this.coolLabel10.TabStop = false;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "شهر محل تولد:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(350, 46);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(88, 21);
            this.coolLabel9.TabIndex = 3;
            this.coolLabel9.TabStop = false;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "استان محل تولد:";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(167, 19);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 21);
            this.coolLabel11.TabIndex = 3;
            this.coolLabel11.TabStop = false;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "محل صدور:";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(350, 19);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(88, 21);
            this.coolLabel8.TabIndex = 3;
            this.coolLabel8.TabStop = false;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "کشور محل تولد:";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(558, 73);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(88, 21);
            this.coolLabel7.TabIndex = 3;
            this.coolLabel7.TabStop = false;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "تاریخ تولد:";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(558, 46);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(88, 21);
            this.coolLabel6.TabIndex = 3;
            this.coolLabel6.TabStop = false;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "کد ملی:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(558, 19);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(102, 21);
            this.coolLabel5.TabIndex = 3;
            this.coolLabel5.TabStop = false;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "شماره‌ی شناسنامه:";
            // 
            // tabEducationInfo
            // 
            this.tabEducationInfo.CanClose = false;
            this.tabEducationInfo.Controls.Add(this.chkStudyStatus);
            this.tabEducationInfo.Controls.Add(this.cboDegreeTypeID);
            this.tabEducationInfo.Controls.Add(this.cboDegreeLevelID);
            this.tabEducationInfo.Controls.Add(this.txtJob);
            this.tabEducationInfo.Controls.Add(this.txtSchool);
            this.tabEducationInfo.Controls.Add(this.txtStudyMajor);
            this.tabEducationInfo.Controls.Add(this.coolLabel17);
            this.tabEducationInfo.Controls.Add(this.coolLabel16);
            this.tabEducationInfo.Controls.Add(this.coolLabel14);
            this.tabEducationInfo.Controls.Add(this.coolLabel13);
            this.tabEducationInfo.Controls.Add(this.coolLabel12);
            this.tabEducationInfo.Controls.Add(this.nextTabber3);
            this.tabEducationInfo.IsDrawn = true;
            this.tabEducationInfo.Name = "tabEducationInfo";
            this.tabEducationInfo.Size = new System.Drawing.Size(664, 121);
            this.tabEducationInfo.TabIndex = 0;
            this.tabEducationInfo.Title = "اطلاعات تحصیلی";
            // 
            // chkStudyStatus
            // 
            this.chkStudyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStudyStatus.Checked = false;
            this.chkStudyStatus.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkStudyStatus.Location = new System.Drawing.Point(240, 73);
            this.chkStudyStatus.Name = "chkStudyStatus";
            this.chkStudyStatus.Size = new System.Drawing.Size(105, 21);
            this.chkStudyStatus.TabIndex = 5;
            this.chkStudyStatus.TextToSet = "در حال تحصیل";
            this.chkStudyStatus.ThreeState = false;
            // 
            // cboDegreeTypeID
            // 
            this.cboDegreeTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDegreeTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboDegreeTypeID.DisplayMember = "";
            this.cboDegreeTypeID.Location = new System.Drawing.Point(188, 46);
            this.cboDegreeTypeID.Name = "cboDegreeTypeID";
            this.cboDegreeTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboDegreeTypeID.SelectedItem = null;
            this.cboDegreeTypeID.Size = new System.Drawing.Size(157, 21);
            this.cboDegreeTypeID.TabIndex = 4;
            // 
            // cboDegreeLevelID
            // 
            this.cboDegreeLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDegreeLevelID.BackColor = System.Drawing.Color.Transparent;
            this.cboDegreeLevelID.DisplayMember = "";
            this.cboDegreeLevelID.Location = new System.Drawing.Point(188, 19);
            this.cboDegreeLevelID.Name = "cboDegreeLevelID";
            this.cboDegreeLevelID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboDegreeLevelID.SelectedItem = null;
            this.cboDegreeLevelID.Size = new System.Drawing.Size(157, 21);
            this.cboDegreeLevelID.TabIndex = 3;
            // 
            // txtJob
            // 
            this.txtJob.Accepted = false;
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJob.BackColor = System.Drawing.Color.Transparent;
            this.txtJob.CursorLocation = 0;
            this.txtJob.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtJob.IsEmpty = false;
            this.txtJob.LengthMax = 100;
            this.txtJob.LengthMin = 0;
            this.txtJob.Location = new System.Drawing.Point(437, 73);
            this.txtJob.Mask = "";
            this.txtJob.Message = "خالی";
            this.txtJob.MustFill = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = false;
            this.txtJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJob.Size = new System.Drawing.Size(127, 21);
            this.txtJob.TabIndex = 2;
            this.txtJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJob.TextToSet = "";
            // 
            // txtSchool
            // 
            this.txtSchool.Accepted = false;
            this.txtSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSchool.BackColor = System.Drawing.Color.Transparent;
            this.txtSchool.CursorLocation = 0;
            this.txtSchool.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSchool.IsEmpty = false;
            this.txtSchool.LengthMax = 100;
            this.txtSchool.LengthMin = 0;
            this.txtSchool.Location = new System.Drawing.Point(437, 46);
            this.txtSchool.Mask = "";
            this.txtSchool.Message = "خالی";
            this.txtSchool.MustFill = true;
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = false;
            this.txtSchool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSchool.Size = new System.Drawing.Size(127, 21);
            this.txtSchool.TabIndex = 1;
            this.txtSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSchool.TextToSet = "";
            // 
            // txtStudyMajor
            // 
            this.txtStudyMajor.Accepted = false;
            this.txtStudyMajor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudyMajor.BackColor = System.Drawing.Color.Transparent;
            this.txtStudyMajor.CursorLocation = 0;
            this.txtStudyMajor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudyMajor.IsEmpty = false;
            this.txtStudyMajor.LengthMax = 50;
            this.txtStudyMajor.LengthMin = 0;
            this.txtStudyMajor.Location = new System.Drawing.Point(437, 19);
            this.txtStudyMajor.Mask = "";
            this.txtStudyMajor.Message = "خالی";
            this.txtStudyMajor.MustFill = true;
            this.txtStudyMajor.Name = "txtStudyMajor";
            this.txtStudyMajor.ReadOnly = false;
            this.txtStudyMajor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudyMajor.Size = new System.Drawing.Size(127, 21);
            this.txtStudyMajor.TabIndex = 0;
            this.txtStudyMajor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudyMajor.TextToSet = "";
            // 
            // coolLabel17
            // 
            this.coolLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel17.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel17.Location = new System.Drawing.Point(351, 19);
            this.coolLabel17.Name = "coolLabel17";
            this.coolLabel17.Size = new System.Drawing.Size(88, 21);
            this.coolLabel17.TabIndex = 4;
            this.coolLabel17.TabStop = false;
            this.coolLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel17.TextToSet = "سطح تحصیلات:";
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(351, 46);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(88, 21);
            this.coolLabel16.TabIndex = 4;
            this.coolLabel16.TabStop = false;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "نوع مدرک:";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(570, 73);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(88, 21);
            this.coolLabel14.TabIndex = 4;
            this.coolLabel14.TabStop = false;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "شغل:";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(570, 46);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(88, 21);
            this.coolLabel13.TabIndex = 4;
            this.coolLabel13.TabStop = false;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "محل تحصیل:";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(570, 19);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(88, 21);
            this.coolLabel12.TabIndex = 4;
            this.coolLabel12.TabStop = false;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "رشته‌ی تحصیلی:";
            // 
            // nextTabber3
            // 
            this.nextTabber3.BackColor = System.Drawing.Color.Transparent;
            this.nextTabber3.Location = new System.Drawing.Point(5, 5);
            this.nextTabber3.Name = "nextTabber3";
            this.nextTabber3.NextTabIndex = -1;
            this.nextTabber3.Size = new System.Drawing.Size(35, 27);
            this.nextTabber3.TabIndex = 6;
            // 
            // tabLocationInfo
            // 
            this.tabLocationInfo.CanClose = false;
            this.tabLocationInfo.Controls.Add(this.nextTabber4);
            this.tabLocationInfo.Controls.Add(this.cboHowtoFindID);
            this.tabLocationInfo.Controls.Add(this.txtGuarantorID);
            this.tabLocationInfo.Controls.Add(this.txtGurarantorName);
            this.tabLocationInfo.Controls.Add(this.txtCellPhone);
            this.tabLocationInfo.Controls.Add(this.txtHomeTell);
            this.tabLocationInfo.Controls.Add(this.txtHomeAddress);
            this.tabLocationInfo.Controls.Add(this.coolLabel26);
            this.tabLocationInfo.Controls.Add(this.coolLabel18);
            this.tabLocationInfo.Controls.Add(this.coolLabel25);
            this.tabLocationInfo.Controls.Add(this.coolLabel15);
            this.tabLocationInfo.Controls.Add(this.coolLabel30);
            this.tabLocationInfo.Controls.Add(this.coolLabel28);
            this.tabLocationInfo.IsDrawn = true;
            this.tabLocationInfo.Name = "tabLocationInfo";
            this.tabLocationInfo.Size = new System.Drawing.Size(664, 121);
            this.tabLocationInfo.TabIndex = 3;
            this.tabLocationInfo.Title = "آدرس و تلفن";
            // 
            // nextTabber4
            // 
            this.nextTabber4.BackColor = System.Drawing.Color.Transparent;
            this.nextTabber4.Location = new System.Drawing.Point(5, 3);
            this.nextTabber4.Name = "nextTabber4";
            this.nextTabber4.NextTabIndex = -1;
            this.nextTabber4.Size = new System.Drawing.Size(35, 27);
            this.nextTabber4.TabIndex = 5;
            // 
            // cboHowtoFindID
            // 
            this.cboHowtoFindID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHowtoFindID.BackColor = System.Drawing.Color.Transparent;
            this.cboHowtoFindID.DisplayMember = "";
            this.cboHowtoFindID.Location = new System.Drawing.Point(336, 11);
            this.cboHowtoFindID.Name = "cboHowtoFindID";
            this.cboHowtoFindID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboHowtoFindID.SelectedItem = null;
            this.cboHowtoFindID.Size = new System.Drawing.Size(228, 21);
            this.cboHowtoFindID.TabIndex = 0;
            // 
            // txtGuarantorID
            // 
            this.txtGuarantorID.Accepted = false;
            this.txtGuarantorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuarantorID.BackColor = System.Drawing.Color.Transparent;
            this.txtGuarantorID.CursorLocation = 0;
            this.txtGuarantorID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGuarantorID.IsEmpty = false;
            this.txtGuarantorID.LengthMax = 20;
            this.txtGuarantorID.LengthMin = 11;
            this.txtGuarantorID.Location = new System.Drawing.Point(5, 7);
            this.txtGuarantorID.Mask = "";
            this.txtGuarantorID.Message = "خالی";
            this.txtGuarantorID.MustFill = true;
            this.txtGuarantorID.Name = "txtGuarantorID";
            this.txtGuarantorID.ReadOnly = false;
            this.txtGuarantorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuarantorID.Size = new System.Drawing.Size(75, 21);
            this.txtGuarantorID.TabIndex = 13;
            this.txtGuarantorID.TabStop = false;
            this.txtGuarantorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGuarantorID.TextToSet = "";
            this.txtGuarantorID.Visible = false;
            // 
            // txtGurarantorName
            // 
            this.txtGurarantorName.Accepted = false;
            this.txtGurarantorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGurarantorName.BackColor = System.Drawing.Color.Transparent;
            this.txtGurarantorName.CursorLocation = 0;
            this.txtGurarantorName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGurarantorName.IsEmpty = false;
            this.txtGurarantorName.LengthMax = 20;
            this.txtGurarantorName.LengthMin = 11;
            this.txtGurarantorName.Location = new System.Drawing.Point(190, 66);
            this.txtGurarantorName.Mask = "";
            this.txtGurarantorName.Message = "خالی";
            this.txtGurarantorName.MustFill = true;
            this.txtGurarantorName.Name = "txtGurarantorName";
            this.txtGurarantorName.ReadOnly = true;
            this.txtGurarantorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGurarantorName.Size = new System.Drawing.Size(374, 21);
            this.txtGurarantorName.TabIndex = 3;
            this.txtGurarantorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGurarantorName.TextToSet = "";
            this.txtGurarantorName.Click += new System.EventHandler(this.txtGurarantorName_Click);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Accepted = false;
            this.txtCellPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCellPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtCellPhone.CursorLocation = 0;
            this.txtCellPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCellPhone.IsEmpty = false;
            this.txtCellPhone.LengthMax = 20;
            this.txtCellPhone.LengthMin = 11;
            this.txtCellPhone.Location = new System.Drawing.Point(406, 93);
            this.txtCellPhone.Mask = "";
            this.txtCellPhone.Message = "خالی";
            this.txtCellPhone.MustFill = true;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.ReadOnly = false;
            this.txtCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCellPhone.Size = new System.Drawing.Size(158, 21);
            this.txtCellPhone.TabIndex = 4;
            this.txtCellPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCellPhone.TextToSet = "";
            // 
            // txtHomeTell
            // 
            this.txtHomeTell.Accepted = false;
            this.txtHomeTell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomeTell.BackColor = System.Drawing.Color.Transparent;
            this.txtHomeTell.CursorLocation = 0;
            this.txtHomeTell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHomeTell.IsEmpty = false;
            this.txtHomeTell.LengthMax = 1000000;
            this.txtHomeTell.LengthMin = 0;
            this.txtHomeTell.Location = new System.Drawing.Point(195, 38);
            this.txtHomeTell.Mask = "";
            this.txtHomeTell.Message = "خالی";
            this.txtHomeTell.MustFill = true;
            this.txtHomeTell.Name = "txtHomeTell";
            this.txtHomeTell.ReadOnly = false;
            this.txtHomeTell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHomeTell.Size = new System.Drawing.Size(95, 21);
            this.txtHomeTell.TabIndex = 2;
            this.txtHomeTell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHomeTell.TextToSet = "";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Accepted = false;
            this.txtHomeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomeAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtHomeAddress.CursorLocation = 0;
            this.txtHomeAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHomeAddress.IsEmpty = false;
            this.txtHomeAddress.LengthMax = 200;
            this.txtHomeAddress.LengthMin = 0;
            this.txtHomeAddress.Location = new System.Drawing.Point(336, 38);
            this.txtHomeAddress.Mask = "";
            this.txtHomeAddress.Message = "خالی";
            this.txtHomeAddress.MustFill = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.ReadOnly = false;
            this.txtHomeAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHomeAddress.Size = new System.Drawing.Size(228, 21);
            this.txtHomeAddress.TabIndex = 1;
            this.txtHomeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHomeAddress.TextToSet = "";
            // 
            // coolLabel26
            // 
            this.coolLabel26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel26.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel26.Location = new System.Drawing.Point(570, 38);
            this.coolLabel26.Name = "coolLabel26";
            this.coolLabel26.Size = new System.Drawing.Size(67, 21);
            this.coolLabel26.TabIndex = 12;
            this.coolLabel26.TabStop = false;
            this.coolLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel26.TextToSet = "آدرس منزل:";
            // 
            // coolLabel18
            // 
            this.coolLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel18.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel18.Location = new System.Drawing.Point(86, 7);
            this.coolLabel18.Name = "coolLabel18";
            this.coolLabel18.Size = new System.Drawing.Size(53, 21);
            this.coolLabel18.TabIndex = 12;
            this.coolLabel18.TabStop = false;
            this.coolLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel18.TextToSet = "کد ضامن:";
            this.coolLabel18.Visible = false;
            // 
            // coolLabel25
            // 
            this.coolLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel25.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel25.Location = new System.Drawing.Point(296, 38);
            this.coolLabel25.Name = "coolLabel25";
            this.coolLabel25.Size = new System.Drawing.Size(39, 21);
            this.coolLabel25.TabIndex = 12;
            this.coolLabel25.TabStop = false;
            this.coolLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel25.TextToSet = "تلفن:";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(570, 66);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(88, 21);
            this.coolLabel15.TabIndex = 12;
            this.coolLabel15.TabStop = false;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "ضامن:";
            // 
            // coolLabel30
            // 
            this.coolLabel30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel30.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel30.Location = new System.Drawing.Point(568, 11);
            this.coolLabel30.Name = "coolLabel30";
            this.coolLabel30.Size = new System.Drawing.Size(88, 21);
            this.coolLabel30.TabIndex = 12;
            this.coolLabel30.TabStop = false;
            this.coolLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel30.TextToSet = "نحوه‌ی آشنایی:";
            // 
            // coolLabel28
            // 
            this.coolLabel28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel28.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel28.Location = new System.Drawing.Point(570, 93);
            this.coolLabel28.Name = "coolLabel28";
            this.coolLabel28.Size = new System.Drawing.Size(92, 21);
            this.coolLabel28.TabIndex = 12;
            this.coolLabel28.TabStop = false;
            this.coolLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel28.TextToSet = "تلفن همراه ضامن:";
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.Controls.Add(this.nextTabber5);
            this.tabUserInfo.Controls.Add(this.chkActivityStatus);
            this.tabUserInfo.IsDrawn = true;
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Size = new System.Drawing.Size(664, 121);
            this.tabUserInfo.TabIndex = 4;
            this.tabUserInfo.Title = "اطلاعات کاربری";
            // 
            // nextTabber5
            // 
            this.nextTabber5.BackColor = System.Drawing.Color.Transparent;
            this.nextTabber5.Location = new System.Drawing.Point(4, 5);
            this.nextTabber5.Name = "nextTabber5";
            this.nextTabber5.NextTabIndex = 0;
            this.nextTabber5.Size = new System.Drawing.Size(35, 27);
            this.nextTabber5.TabIndex = 1;
            // 
            // chkActivityStatus
            // 
            this.chkActivityStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivityStatus.Checked = false;
            this.chkActivityStatus.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkActivityStatus.Location = new System.Drawing.Point(545, 21);
            this.chkActivityStatus.Name = "chkActivityStatus";
            this.chkActivityStatus.Size = new System.Drawing.Size(105, 21);
            this.chkActivityStatus.TabIndex = 0;
            this.chkActivityStatus.TextToSet = "وضعیت کاربری";
            this.chkActivityStatus.ThreeState = false;
            // 
            // floaterGuarantorPicker
            // 
            this.floaterGuarantorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterGuarantorPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterGuarantorPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterGuarantorPicker.Location = new System.Drawing.Point(3, 133);
            this.floaterGuarantorPicker.Name = "floaterGuarantorPicker";
            this.floaterGuarantorPicker.Size = new System.Drawing.Size(672, 181);
            this.floaterGuarantorPicker.TabIndex = 15;
            this.floaterGuarantorPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterGuarantorPicker.TitleText = "";
            this.floaterGuarantorPicker.Visible = false;
            // 
            // floaterContainter
            // 
            this.floaterContainter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainter.Location = new System.Drawing.Point(9, 3);
            this.floaterContainter.Name = "floaterContainter";
            this.floaterContainter.Size = new System.Drawing.Size(666, 308);
            this.floaterContainter.TabIndex = 16;
            this.floaterContainter.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainter.TitleText = "";
            this.floaterContainter.Visible = false;
            // 
            // pnlGroup
            // 
            this.pnlGroup.Controls.Add(this.tabMain);
            this.pnlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGroup.Location = new System.Drawing.Point(3, 17);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(666, 142);
            this.pnlGroup.TabIndex = 5;
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 342);
            this.Name = "frmEmployeeManager";
            this.Text = "مدیریت کارمندان";
            this.LoadForm += new System.EventHandler(this.frmStudentManager_LoadForm);
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
            this.tabPrimaryInfo.ResumeLayout(false);
            this.tabAdditionalInfo.ResumeLayout(false);
            this.tabEducationInfo.ResumeLayout(false);
            this.tabLocationInfo.ResumeLayout(false);
            this.tabUserInfo.ResumeLayout(false);
            this.pnlGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip tabMain;
        private FarsiLibrary.Win.FATabStripItem tabPrimaryInfo;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolTextBox txtEmployeeID;
        private HengamWidgets.CoolTextBox txtFatherName;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolTextBox txtLastName;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolTextBox txtFirstName;
        private HengamWidgets.CoolLabel coolLabel2;
        private FarsiLibrary.Win.FATabStripItem tabAdditionalInfo;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel5;
        private FarsiLibrary.Win.FATabStripItem tabEducationInfo;
        private HengamWidgets.CoolNumberBox txtCertificationNumber;
        private HengamWidgets.CoolDateBox txtBirthDate;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolTextBox txtBornPlace;
        private HengamWidgets.CoolTextBox txtBornProvince;
        private HengamWidgets.CoolTextBox txtBornCountry;
        private HengamWidgets.CoolTextBox txtIssuePlace;
        private HengamWidgets.CoolTextBox txtStudyMajor;
        private HengamWidgets.CoolLabel coolLabel17;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolComboBox cboMartialStatus;
        private HengamWidgets.CoolComboBox cboGender;
        private HengamWidgets.CoolLabel coolLabel19;
        private HengamWidgets.CoolLabel coolLabel20;
        private HengamWidgets.CoolComboBox cboDegreeTypeID;
        private HengamWidgets.CoolComboBox cboDegreeLevelID;
        private HengamWidgets.CoolTextBox txtJob;
        private HengamWidgets.CoolTextBox txtSchool;
        private FarsiLibrary.Win.FATabStripItem tabLocationInfo;
        private HengamWidgets.CoolLabel coolLabel26;
        private HengamWidgets.CoolLabel coolLabel25;
        private HengamWidgets.CoolLabel coolLabel30;
        private HengamWidgets.CoolLabel coolLabel28;
        private HengamWidgets.CoolTextBox txtCellPhone;
        private HengamWidgets.CoolTextBox txtHomeTell;
        private HengamWidgets.CoolTextBox txtHomeAddress;
        private HengamWidgets.CoolComboBox cboHowtoFindID;
        private FarsiLibrary.Win.FATabStripItem tabUserInfo;
        private HengamWidgets.CoolCheckBox chkActivityStatus;
        private HengamWidgets.CoolCheckBox chkStudyStatus;
        private HengamWidgets.CoolImageContainer picImage;
        private HengamWidgets.CoolTextBox txtNationalNumber;
        private HengamWidgets.CoolTextBox txtGuarantorID;
        private HengamWidgets.CoolTextBox txtGurarantorName;
        private HengamWidgets.CoolLabel coolLabel18;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.PanelFloater floaterGuarantorPicker;
        private System.Windows.Forms.Panel pnlGroup;
        private HengamWidgets.PanelFloater floaterContainter;
        private Hengam.Controls.NextTabber nextTabber1;
        private Hengam.Controls.NextTabber nextTabber2;
        private Hengam.Controls.NextTabber nextTabber3;
        private Hengam.Controls.NextTabber nextTabber4;
        private Hengam.Controls.NextTabber nextTabber5;
    }
}
