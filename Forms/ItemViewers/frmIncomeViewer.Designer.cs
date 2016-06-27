namespace Hengam.Forms.ItemViewers
{
    partial class frmIncomeViewer
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
            this.groupOutcomeDetails = new System.Windows.Forms.GroupBox();
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.tabIncomeStoreSell = new FarsiLibrary.Win.FATabStripItem();
            this.txtStuffCount = new HengamWidgets.CoolNumberBox();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.tabIncomeStudent = new FarsiLibrary.Win.FATabStripItem();
            this.txtClassIDStudent = new HengamWidgets.CoolNumberBox();
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.txtClassNameStudent = new HengamWidgets.CoolTextBox();
            this.coolLabel17 = new HengamWidgets.CoolLabel();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.tabIncomeTypical = new FarsiLibrary.Win.FATabStripItem();
            this.txtTag = new HengamWidgets.CoolTextBox();
            this.lblTagName = new HengamWidgets.CoolLabel();
            this.cboIncomeTypicalTypeID = new HengamWidgets.CoolComboBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.tabOutcomeTeacher = new FarsiLibrary.Win.FATabStripItem();
            this.txtClassIDTeacher = new HengamWidgets.CoolNumberBox();
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.txtClassNameTeacher = new HengamWidgets.CoolTextBox();
            this.lblTeacherClassName = new HengamWidgets.CoolLabel();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.tabOutcomeEmployee = new FarsiLibrary.Win.FATabStripItem();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.txtDateTo = new HengamWidgets.CoolDateBox();
            this.txtDateFrom = new HengamWidgets.CoolDateBox();
            this.txtEmployeeID = new HengamWidgets.CoolTextBox();
            this.txtEmployeeName = new HengamWidgets.CoolTextBox();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtPayID = new HengamWidgets.CoolTextBox();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.pnlMain.SuspendLayout();
            this.groupOutcomeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabIncomeStoreSell.SuspendLayout();
            this.tabIncomeStudent.SuspendLayout();
            this.tabIncomeTypical.SuspendLayout();
            this.tabOutcomeTeacher.SuspendLayout();
            this.tabOutcomeEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupOutcomeDetails);
            this.pnlMain.Size = new System.Drawing.Size(412, 288);
            this.pnlMain.BackColorChanged += new System.EventHandler(this.pnlMain_BackColorChanged);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupOutcomeDetails, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(65, 120);
            // 
            // groupOutcomeDetails
            // 
            this.groupOutcomeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutcomeDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupOutcomeDetails.Controls.Add(this.tabMain);
            this.groupOutcomeDetails.Controls.Add(this.txtCheckNumber);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel11);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel10);
            this.groupOutcomeDetails.Controls.Add(this.cboPayTypeID);
            this.groupOutcomeDetails.Controls.Add(this.txtPayID);
            this.groupOutcomeDetails.Controls.Add(this.txtDescription);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel8);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel1);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel6);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel5);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel3);
            this.groupOutcomeDetails.Controls.Add(this.txtCheckDate);
            this.groupOutcomeDetails.Controls.Add(this.txtPayDate);
            this.groupOutcomeDetails.Controls.Add(this.coolLabel4);
            this.groupOutcomeDetails.Controls.Add(this.txtFee);
            this.groupOutcomeDetails.Controls.Add(this.txtDiscount);
            this.groupOutcomeDetails.Location = new System.Drawing.Point(3, 3);
            this.groupOutcomeDetails.Name = "groupOutcomeDetails";
            this.groupOutcomeDetails.Size = new System.Drawing.Size(406, 282);
            this.groupOutcomeDetails.TabIndex = 2;
            this.groupOutcomeDetails.TabStop = false;
            this.groupOutcomeDetails.Text = "جزئیات";
            // 
            // tabMain
            // 
            this.tabMain.AlwaysShowClose = false;
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabMain.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabIncomeStoreSell,
            this.tabIncomeStudent,
            this.tabIncomeTypical,
            this.tabOutcomeTeacher,
            this.tabOutcomeEmployee});
            this.tabMain.Location = new System.Drawing.Point(10, 105);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedItem = this.tabIncomeStudent;
            this.tabMain.Size = new System.Drawing.Size(389, 109);
            this.tabMain.TabIndex = 27;
            this.tabMain.Text = "سیستم آموزشی زیتون";
            // 
            // tabIncomeStoreSell
            // 
            this.tabIncomeStoreSell.Controls.Add(this.txtStuffCount);
            this.tabIncomeStoreSell.Controls.Add(this.txtStuffName);
            this.tabIncomeStoreSell.Controls.Add(this.coolLabel7);
            this.tabIncomeStoreSell.Controls.Add(this.coolLabel9);
            this.tabIncomeStoreSell.IsDrawn = true;
            this.tabIncomeStoreSell.Name = "tabIncomeStoreSell";
            this.tabIncomeStoreSell.Size = new System.Drawing.Size(387, 88);
            this.tabIncomeStoreSell.TabIndex = 1;
            this.tabIncomeStoreSell.Title = "هزینه‌ی خرید وسایل";
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
            this.txtStuffCount.Location = new System.Drawing.Point(221, 47);
            this.txtStuffCount.Mask = "";
            this.txtStuffCount.Message = "خالی";
            this.txtStuffCount.MustFill = true;
            this.txtStuffCount.Name = "txtStuffCount";
            this.txtStuffCount.NumberMax = ((long)(1000000));
            this.txtStuffCount.NumberMin = ((long)(0));
            this.txtStuffCount.ReadOnly = true;
            this.txtStuffCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffCount.Size = new System.Drawing.Size(114, 21);
            this.txtStuffCount.TabIndex = 10;
            this.txtStuffCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffCount.TextToSet = "";
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
            this.txtStuffName.Location = new System.Drawing.Point(7, 20);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = true;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(328, 21);
            this.txtStuffName.TabIndex = 7;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(341, 20);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(43, 21);
            this.coolLabel7.TabIndex = 8;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "بابت:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(341, 47);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(43, 21);
            this.coolLabel9.TabIndex = 9;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "تعداد:";
            // 
            // tabIncomeStudent
            // 
            this.tabIncomeStudent.Controls.Add(this.txtClassIDStudent);
            this.tabIncomeStudent.Controls.Add(this.txtStudentID);
            this.tabIncomeStudent.Controls.Add(this.txtClassNameStudent);
            this.tabIncomeStudent.Controls.Add(this.coolLabel17);
            this.tabIncomeStudent.Controls.Add(this.txtStudentName);
            this.tabIncomeStudent.Controls.Add(this.coolLabel16);
            this.tabIncomeStudent.IsDrawn = true;
            this.tabIncomeStudent.Name = "tabIncomeStudent";
            this.tabIncomeStudent.Selected = true;
            this.tabIncomeStudent.Size = new System.Drawing.Size(387, 88);
            this.tabIncomeStudent.TabIndex = 4;
            this.tabIncomeStudent.Title = "تسویه حساب هنرجو";
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
            this.txtClassIDStudent.Location = new System.Drawing.Point(-7, 47);
            this.txtClassIDStudent.Mask = "";
            this.txtClassIDStudent.Message = "خالی";
            this.txtClassIDStudent.MustFill = true;
            this.txtClassIDStudent.Name = "txtClassIDStudent";
            this.txtClassIDStudent.NumberMax = ((long)(1000000));
            this.txtClassIDStudent.NumberMin = ((long)(0));
            this.txtClassIDStudent.ReadOnly = false;
            this.txtClassIDStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassIDStudent.Size = new System.Drawing.Size(51, 21);
            this.txtClassIDStudent.TabIndex = 17;
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
            this.txtStudentID.Location = new System.Drawing.Point(-7, 20);
            this.txtStudentID.Mask = "";
            this.txtStudentID.Message = "خالی";
            this.txtStudentID.MustFill = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentID.Size = new System.Drawing.Size(51, 21);
            this.txtStudentID.TabIndex = 15;
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
            this.txtClassNameStudent.Location = new System.Drawing.Point(-7, 47);
            this.txtClassNameStudent.Mask = "";
            this.txtClassNameStudent.Message = "خالی";
            this.txtClassNameStudent.MustFill = true;
            this.txtClassNameStudent.Name = "txtClassNameStudent";
            this.txtClassNameStudent.ReadOnly = true;
            this.txtClassNameStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassNameStudent.Size = new System.Drawing.Size(338, 21);
            this.txtClassNameStudent.TabIndex = 11;
            this.txtClassNameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassNameStudent.TextToSet = "";
            // 
            // coolLabel17
            // 
            this.coolLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel17.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel17.Location = new System.Drawing.Point(337, 47);
            this.coolLabel17.Name = "coolLabel17";
            this.coolLabel17.Size = new System.Drawing.Size(47, 21);
            this.coolLabel17.TabIndex = 13;
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
            this.txtStudentName.Location = new System.Drawing.Point(-7, 20);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(338, 21);
            this.txtStudentName.TabIndex = 14;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(337, 20);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(47, 21);
            this.coolLabel16.TabIndex = 16;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "هنرجو:";
            // 
            // tabIncomeTypical
            // 
            this.tabIncomeTypical.CanClose = false;
            this.tabIncomeTypical.Controls.Add(this.txtTag);
            this.tabIncomeTypical.Controls.Add(this.lblTagName);
            this.tabIncomeTypical.Controls.Add(this.cboIncomeTypicalTypeID);
            this.tabIncomeTypical.Controls.Add(this.coolLabel2);
            this.tabIncomeTypical.Name = "tabIncomeTypical";
            this.tabIncomeTypical.Size = new System.Drawing.Size(401, 88);
            this.tabIncomeTypical.TabIndex = 0;
            this.tabIncomeTypical.Title = "سایر هزینه‌ها";
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
            this.txtTag.Location = new System.Drawing.Point(7, 45);
            this.txtTag.Mask = "";
            this.txtTag.Message = "خالی";
            this.txtTag.MustFill = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = true;
            this.txtTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTag.Size = new System.Drawing.Size(307, 21);
            this.txtTag.TabIndex = 3;
            this.txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTag.TextToSet = "";
            // 
            // lblTagName
            // 
            this.lblTagName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagName.BackColor = System.Drawing.Color.Transparent;
            this.lblTagName.Location = new System.Drawing.Point(320, 45);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(81, 21);
            this.lblTagName.TabIndex = 4;
            this.lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTagName.TextToSet = "اطلاعات دیگر:";
            // 
            // cboIncomeTypicalTypeID
            // 
            this.cboIncomeTypicalTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIncomeTypicalTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboIncomeTypicalTypeID.DisplayMember = "";
            this.cboIncomeTypicalTypeID.Enabled = false;
            this.cboIncomeTypicalTypeID.Location = new System.Drawing.Point(7, 18);
            this.cboIncomeTypicalTypeID.Name = "cboIncomeTypicalTypeID";
            this.cboIncomeTypicalTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboIncomeTypicalTypeID.SelectedItem = null;
            this.cboIncomeTypicalTypeID.Size = new System.Drawing.Size(307, 21);
            this.cboIncomeTypicalTypeID.TabIndex = 5;
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(320, 18);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(60, 21);
            this.coolLabel2.TabIndex = 4;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "نوع هزینه:";
            // 
            // tabOutcomeTeacher
            // 
            this.tabOutcomeTeacher.CanClose = false;
            this.tabOutcomeTeacher.Controls.Add(this.txtClassIDTeacher);
            this.tabOutcomeTeacher.Controls.Add(this.txtTeacherID);
            this.tabOutcomeTeacher.Controls.Add(this.txtClassNameTeacher);
            this.tabOutcomeTeacher.Controls.Add(this.lblTeacherClassName);
            this.tabOutcomeTeacher.Controls.Add(this.txtTeacherName);
            this.tabOutcomeTeacher.Controls.Add(this.coolLabel12);
            this.tabOutcomeTeacher.Name = "tabOutcomeTeacher";
            this.tabOutcomeTeacher.Size = new System.Drawing.Size(611, 88);
            this.tabOutcomeTeacher.TabIndex = 2;
            this.tabOutcomeTeacher.Title = "حقوق استاد";
            // 
            // txtClassIDTeacher
            // 
            this.txtClassIDTeacher.Accepted = false;
            this.txtClassIDTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassIDTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtClassIDTeacher.CursorLocation = 0;
            this.txtClassIDTeacher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassIDTeacher.HaveCurrencySeperator = true;
            this.txtClassIDTeacher.IsEmpty = false;
            this.txtClassIDTeacher.LengthMax = 40;
            this.txtClassIDTeacher.LengthMin = 0;
            this.txtClassIDTeacher.Location = new System.Drawing.Point(331, 47);
            this.txtClassIDTeacher.Mask = "";
            this.txtClassIDTeacher.Message = "خالی";
            this.txtClassIDTeacher.MustFill = true;
            this.txtClassIDTeacher.Name = "txtClassIDTeacher";
            this.txtClassIDTeacher.NumberMax = ((long)(1000000));
            this.txtClassIDTeacher.NumberMin = ((long)(0));
            this.txtClassIDTeacher.ReadOnly = false;
            this.txtClassIDTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassIDTeacher.Size = new System.Drawing.Size(51, 21);
            this.txtClassIDTeacher.TabIndex = 18;
            this.txtClassIDTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassIDTeacher.TextToSet = "";
            this.txtClassIDTeacher.Visible = false;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Accepted = false;
            this.txtTeacherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherID.BackColor = System.Drawing.Color.Transparent;
            this.txtTeacherID.CursorLocation = 0;
            this.txtTeacherID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTeacherID.IsEmpty = false;
            this.txtTeacherID.LengthMax = 1000000;
            this.txtTeacherID.LengthMin = 0;
            this.txtTeacherID.Location = new System.Drawing.Point(331, 20);
            this.txtTeacherID.Mask = "";
            this.txtTeacherID.Message = "خالی";
            this.txtTeacherID.MustFill = true;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = false;
            this.txtTeacherID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherID.Size = new System.Drawing.Size(51, 21);
            this.txtTeacherID.TabIndex = 9;
            this.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherID.TextToSet = "";
            this.txtTeacherID.Visible = false;
            // 
            // txtClassNameTeacher
            // 
            this.txtClassNameTeacher.Accepted = false;
            this.txtClassNameTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassNameTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtClassNameTeacher.CursorLocation = 0;
            this.txtClassNameTeacher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassNameTeacher.IsEmpty = false;
            this.txtClassNameTeacher.LengthMax = 1000000;
            this.txtClassNameTeacher.LengthMin = 0;
            this.txtClassNameTeacher.Location = new System.Drawing.Point(400, 47);
            this.txtClassNameTeacher.Mask = "";
            this.txtClassNameTeacher.Message = "خالی";
            this.txtClassNameTeacher.MustFill = true;
            this.txtClassNameTeacher.Name = "txtClassNameTeacher";
            this.txtClassNameTeacher.ReadOnly = true;
            this.txtClassNameTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassNameTeacher.Size = new System.Drawing.Size(148, 21);
            this.txtClassNameTeacher.TabIndex = 9;
            this.txtClassNameTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassNameTeacher.TextToSet = "";
            // 
            // lblTeacherClassName
            // 
            this.lblTeacherClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeacherClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherClassName.Location = new System.Drawing.Point(554, 47);
            this.lblTeacherClassName.Name = "lblTeacherClassName";
            this.lblTeacherClassName.Size = new System.Drawing.Size(47, 21);
            this.lblTeacherClassName.TabIndex = 10;
            this.lblTeacherClassName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTeacherClassName.TextToSet = "کلاس:";
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
            this.txtTeacherName.Location = new System.Drawing.Point(400, 20);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(148, 21);
            this.txtTeacherName.TabIndex = 9;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(554, 20);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(47, 21);
            this.coolLabel12.TabIndex = 10;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "استاد:";
            // 
            // tabOutcomeEmployee
            // 
            this.tabOutcomeEmployee.CanClose = false;
            this.tabOutcomeEmployee.Controls.Add(this.coolLabel14);
            this.tabOutcomeEmployee.Controls.Add(this.coolLabel15);
            this.tabOutcomeEmployee.Controls.Add(this.txtDateTo);
            this.tabOutcomeEmployee.Controls.Add(this.txtDateFrom);
            this.tabOutcomeEmployee.Controls.Add(this.txtEmployeeID);
            this.tabOutcomeEmployee.Controls.Add(this.txtEmployeeName);
            this.tabOutcomeEmployee.Controls.Add(this.coolLabel13);
            this.tabOutcomeEmployee.Name = "tabOutcomeEmployee";
            this.tabOutcomeEmployee.Size = new System.Drawing.Size(611, 88);
            this.tabOutcomeEmployee.TabIndex = 3;
            this.tabOutcomeEmployee.Title = "حقوق کارمند";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(382, 37);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(19, 21);
            this.coolLabel14.TabIndex = 15;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "تا";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(527, 37);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(81, 21);
            this.coolLabel15.TabIndex = 14;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "حقوق مربوط به:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Accepted = false;
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTo.CursorLocation = 8;
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateTo.IsEmpty = false;
            this.txtDateTo.Location = new System.Drawing.Point(262, 37);
            this.txtDateTo.Mask = "0000/00/00";
            this.txtDateTo.Message = "طول کم";
            this.txtDateTo.MustFill = true;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.ReadOnly = true;
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTo.Size = new System.Drawing.Size(114, 21);
            this.txtDateTo.TabIndex = 17;
            this.txtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateTo.TextToSet = "    /  /";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Accepted = false;
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtDateFrom.CursorLocation = 8;
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateFrom.IsEmpty = false;
            this.txtDateFrom.Location = new System.Drawing.Point(407, 37);
            this.txtDateFrom.Mask = "0000/00/00";
            this.txtDateFrom.Message = "طول کم";
            this.txtDateFrom.MustFill = true;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.ReadOnly = true;
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateFrom.Size = new System.Drawing.Size(114, 21);
            this.txtDateFrom.TabIndex = 16;
            this.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateFrom.TextToSet = "    /  /";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Accepted = false;
            this.txtEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeID.CursorLocation = 0;
            this.txtEmployeeID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmployeeID.IsEmpty = false;
            this.txtEmployeeID.LengthMax = 1000000;
            this.txtEmployeeID.LengthMin = 0;
            this.txtEmployeeID.Location = new System.Drawing.Point(338, 10);
            this.txtEmployeeID.Mask = "";
            this.txtEmployeeID.Message = "خالی";
            this.txtEmployeeID.MustFill = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = false;
            this.txtEmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeID.Size = new System.Drawing.Size(51, 21);
            this.txtEmployeeID.TabIndex = 12;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeID.TextToSet = "";
            this.txtEmployeeID.Visible = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Accepted = false;
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeName.CursorLocation = 0;
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmployeeName.IsEmpty = false;
            this.txtEmployeeName.LengthMax = 1000000;
            this.txtEmployeeName.LengthMin = 0;
            this.txtEmployeeName.Location = new System.Drawing.Point(407, 10);
            this.txtEmployeeName.Mask = "";
            this.txtEmployeeName.Message = "خالی";
            this.txtEmployeeName.MustFill = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(148, 21);
            this.txtEmployeeName.TabIndex = 11;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TextToSet = "";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(561, 10);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(47, 21);
            this.coolLabel13.TabIndex = 13;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "کارمند:";
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
            this.txtCheckNumber.Location = new System.Drawing.Point(4, 74);
            this.txtCheckNumber.Mask = "";
            this.txtCheckNumber.Message = "خالی";
            this.txtCheckNumber.MustFill = true;
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.ReadOnly = true;
            this.txtCheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckNumber.Size = new System.Drawing.Size(114, 21);
            this.txtCheckNumber.TabIndex = 25;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckNumber.TextToSet = "";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(124, 74);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 21);
            this.coolLabel11.TabIndex = 26;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "شماره‌ی چک:";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(322, 74);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(77, 21);
            this.coolLabel10.TabIndex = 18;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Enabled = false;
            this.cboPayTypeID.Location = new System.Drawing.Point(202, 74);
            this.cboPayTypeID.Name = "cboPayTypeID";
            this.cboPayTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPayTypeID.SelectedItem = null;
            this.cboPayTypeID.Size = new System.Drawing.Size(114, 21);
            this.cboPayTypeID.TabIndex = 20;
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
            this.txtPayID.Location = new System.Drawing.Point(9, 220);
            this.txtPayID.Mask = "";
            this.txtPayID.Message = "خالی";
            this.txtPayID.MustFill = true;
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.ReadOnly = true;
            this.txtPayID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayID.Size = new System.Drawing.Size(46, 21);
            this.txtPayID.TabIndex = 11;
            this.txtPayID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayID.TextToSet = "";
            this.txtPayID.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Accepted = false;
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.CursorLocation = 0;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDescription.IsEmpty = false;
            this.txtDescription.LengthMax = 1000000;
            this.txtDescription.LengthMin = 0;
            this.txtDescription.Location = new System.Drawing.Point(10, 246);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(390, 21);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(343, 219);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(57, 21);
            this.coolLabel8.TabIndex = 17;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "توضیحات:";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(61, 220);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(54, 21);
            this.coolLabel1.TabIndex = 19;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد هزینه:";
            this.coolLabel1.Visible = false;
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(124, 48);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(72, 21);
            this.coolLabel6.TabIndex = 14;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "تاریخ چک:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(124, 21);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(72, 21);
            this.coolLabel5.TabIndex = 16;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(322, 20);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(81, 21);
            this.coolLabel3.TabIndex = 15;
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
            this.txtCheckDate.Location = new System.Drawing.Point(4, 48);
            this.txtCheckDate.Mask = "0000/00/00";
            this.txtCheckDate.Message = "طول کم";
            this.txtCheckDate.MustFill = true;
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = true;
            this.txtCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckDate.Size = new System.Drawing.Size(114, 21);
            this.txtCheckDate.TabIndex = 23;
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
            this.txtPayDate.Location = new System.Drawing.Point(4, 21);
            this.txtPayDate.Mask = "0000/00/00";
            this.txtPayDate.Message = "طول کم";
            this.txtPayDate.MustFill = true;
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = true;
            this.txtPayDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayDate.Size = new System.Drawing.Size(114, 21);
            this.txtPayDate.TabIndex = 24;
            this.txtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayDate.TextToSet = "    /  /";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(322, 47);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(81, 21);
            this.coolLabel4.TabIndex = 13;
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
            this.txtFee.Location = new System.Drawing.Point(202, 20);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(10000000000));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = true;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 21;
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
            this.txtDiscount.Location = new System.Drawing.Point(202, 47);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 22;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
            // 
            // frmIncomeViewer
            // 
            this.ClientSize = new System.Drawing.Size(436, 312);
            this.Name = "frmIncomeViewer";
            this.Text = "مشاهده‌ی جزئیات پرداخت";
            this.LoadForm += new System.EventHandler(this.frmIncomeViewer_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupOutcomeDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabIncomeStoreSell.ResumeLayout(false);
            this.tabIncomeStudent.ResumeLayout(false);
            this.tabIncomeTypical.ResumeLayout(false);
            this.tabOutcomeTeacher.ResumeLayout(false);
            this.tabOutcomeEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOutcomeDetails;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolTextBox txtPayID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private FarsiLibrary.Win.FATabStrip tabMain;
        private FarsiLibrary.Win.FATabStripItem tabIncomeTypical;
        private HengamWidgets.CoolTextBox txtTag;
        private HengamWidgets.CoolLabel lblTagName;
        private HengamWidgets.CoolComboBox cboIncomeTypicalTypeID;
        private HengamWidgets.CoolLabel coolLabel2;
        private FarsiLibrary.Win.FATabStripItem tabIncomeStoreSell;
        private HengamWidgets.CoolNumberBox txtStuffCount;
        private HengamWidgets.CoolTextBox txtStuffName;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel9;
        private FarsiLibrary.Win.FATabStripItem tabOutcomeTeacher;
        private HengamWidgets.CoolNumberBox txtClassIDTeacher;
        private HengamWidgets.CoolTextBox txtTeacherID;
        private HengamWidgets.CoolTextBox txtClassNameTeacher;
        private HengamWidgets.CoolLabel lblTeacherClassName;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.CoolLabel coolLabel12;
        private FarsiLibrary.Win.FATabStripItem tabOutcomeEmployee;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.CoolDateBox txtDateTo;
        private HengamWidgets.CoolDateBox txtDateFrom;
        private HengamWidgets.CoolTextBox txtEmployeeID;
        private HengamWidgets.CoolTextBox txtEmployeeName;
        private HengamWidgets.CoolLabel coolLabel13;
        private FarsiLibrary.Win.FATabStripItem tabIncomeStudent;
        private HengamWidgets.CoolNumberBox txtClassIDStudent;
        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.CoolTextBox txtClassNameStudent;
        private HengamWidgets.CoolLabel coolLabel17;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel16;
    }
}
