namespace Hengam.Forms
{
    partial class frmTeacherFinancialStatusAggregatePay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherFinancialStatusAggregatePay));
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.lblContinuousAbsence = new HengamWidgets.CoolLabel();
            this.lblStudentAbsence = new HengamWidgets.CoolLabel();
            this.lblTeacherAbsence = new HengamWidgets.CoolLabel();
            this.lblHeld = new HengamWidgets.CoolLabel();
            this.lblNotHeld = new HengamWidgets.CoolLabel();
            this.groupSessionDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalSessions = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.floaterContainer = new HengamWidgets.PanelFloater();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel17 = new HengamWidgets.CoolLabel();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.lblHeldSessionsAmount = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.lblEachSessionAmount = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.lblTeacherPortion = new HengamWidgets.CoolLabel();
            this.lblClassTotalFee = new HengamWidgets.CoolLabel();
            this.lblMustPay = new HengamWidgets.CoolLabel();
            this.lblHavePaid = new HengamWidgets.CoolLabel();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.lblStatus = new HengamWidgets.CoolLabel();
            this.btnPay = new HengamWidgets.CoolButton();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.coolLabel18 = new HengamWidgets.CoolLabel();
            this.coolLabel19 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.coolLabel20 = new HengamWidgets.CoolLabel();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.activitySelector = new Hengam.Controls.ActivitySelector();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupSessionDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupBox2);
            this.groupItemDetails.Controls.Add(this.groupSessionDetails);
            this.groupItemDetails.Controls.Add(this.txtTeacherID);
            this.groupItemDetails.Controls.Add(this.txtTeacherName);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Size = new System.Drawing.Size(727, 239);
            this.groupItemDetails.Text = "انتخاب استاد";
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtTeacherName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtTeacherID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupSessionDetails, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 148);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterContainer);
            this.pnlMain.Size = new System.Drawing.Size(733, 554);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainer, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.groupPay);
            this.groupDatagrid.Controls.Add(this.activitySelector);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 248);
            this.groupDatagrid.Size = new System.Drawing.Size(727, 303);
            this.groupDatagrid.Text = "لیست کلاس‌ها و وضعیت مالی آنها";
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.activitySelector, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.groupPay, 0);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            this.imgButtons.Images.SetKeyName(5, "Money");
            this.imgButtons.Images.SetKeyName(6, "Session");
            this.imgButtons.Images.SetKeyName(7, "MoneyMoney");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Location = new System.Drawing.Point(6, 49);
            this.dataGridSection.Size = new System.Drawing.Size(715, 109);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            // 
            // coolMessage
            // 
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(237, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
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
            this.txtTeacherID.Location = new System.Drawing.Point(0, 17);
            this.txtTeacherID.Mask = "";
            this.txtTeacherID.Message = "خالی";
            this.txtTeacherID.MustFill = true;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = false;
            this.txtTeacherID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherID.Size = new System.Drawing.Size(64, 21);
            this.txtTeacherID.TabIndex = 21;
            this.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherID.TextToSet = "";
            this.txtTeacherID.Visible = false;
            this.txtTeacherID.TextAccepted += new System.EventHandler(this.txtTacherName_TextAccepted);
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
            this.txtTeacherName.Location = new System.Drawing.Point(234, 20);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(431, 21);
            this.txtTeacherName.TabIndex = 20;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            this.txtTeacherName.Click += new System.EventHandler(this.txtTeacherName_Click);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(671, 20);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(50, 21);
            this.coolLabel2.TabIndex = 19;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "استاد:";
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(3, 47);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(727, 498);
            this.floaterTeacherPicker.TabIndex = 16;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // lblContinuousAbsence
            // 
            this.lblContinuousAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContinuousAbsence.BackColor = System.Drawing.Color.Transparent;
            this.lblContinuousAbsence.Location = new System.Drawing.Point(188, 43);
            this.lblContinuousAbsence.Name = "lblContinuousAbsence";
            this.lblContinuousAbsence.Size = new System.Drawing.Size(42, 22);
            this.lblContinuousAbsence.TabIndex = 14;
            this.lblContinuousAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContinuousAbsence.TextToSet = "-";
            // 
            // lblStudentAbsence
            // 
            this.lblStudentAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentAbsence.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentAbsence.Location = new System.Drawing.Point(9, 41);
            this.lblStudentAbsence.Name = "lblStudentAbsence";
            this.lblStudentAbsence.Size = new System.Drawing.Size(70, 22);
            this.lblStudentAbsence.TabIndex = 14;
            this.lblStudentAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStudentAbsence.TextToSet = "-";
            // 
            // lblTeacherAbsence
            // 
            this.lblTeacherAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeacherAbsence.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherAbsence.Location = new System.Drawing.Point(9, 13);
            this.lblTeacherAbsence.Name = "lblTeacherAbsence";
            this.lblTeacherAbsence.Size = new System.Drawing.Size(70, 22);
            this.lblTeacherAbsence.TabIndex = 14;
            this.lblTeacherAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeacherAbsence.TextToSet = "-";
            // 
            // lblHeld
            // 
            this.lblHeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeld.BackColor = System.Drawing.Color.Transparent;
            this.lblHeld.Location = new System.Drawing.Point(173, 13);
            this.lblHeld.Name = "lblHeld";
            this.lblHeld.Size = new System.Drawing.Size(57, 22);
            this.lblHeld.TabIndex = 14;
            this.lblHeld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeld.TextToSet = "-";
            // 
            // lblNotHeld
            // 
            this.lblNotHeld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotHeld.BackColor = System.Drawing.Color.Transparent;
            this.lblNotHeld.Location = new System.Drawing.Point(316, 41);
            this.lblNotHeld.Name = "lblNotHeld";
            this.lblNotHeld.Size = new System.Drawing.Size(80, 22);
            this.lblNotHeld.TabIndex = 14;
            this.lblNotHeld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotHeld.TextToSet = "-";
            // 
            // groupSessionDetails
            // 
            this.groupSessionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSessionDetails.Controls.Add(this.lblContinuousAbsence);
            this.groupSessionDetails.Controls.Add(this.lblStudentAbsence);
            this.groupSessionDetails.Controls.Add(this.lblTeacherAbsence);
            this.groupSessionDetails.Controls.Add(this.lblHeld);
            this.groupSessionDetails.Controls.Add(this.lblNotHeld);
            this.groupSessionDetails.Controls.Add(this.lblTotalSessions);
            this.groupSessionDetails.Controls.Add(this.coolLabel10);
            this.groupSessionDetails.Controls.Add(this.coolLabel11);
            this.groupSessionDetails.Controls.Add(this.coolLabel9);
            this.groupSessionDetails.Controls.Add(this.coolLabel8);
            this.groupSessionDetails.Controls.Add(this.coolLabel12);
            this.groupSessionDetails.Controls.Add(this.coolLabel6);
            this.groupSessionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupSessionDetails.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupSessionDetails.Location = new System.Drawing.Point(241, 151);
            this.groupSessionDetails.Name = "groupSessionDetails";
            this.groupSessionDetails.Size = new System.Drawing.Size(480, 71);
            this.groupSessionDetails.TabIndex = 22;
            this.groupSessionDetails.TabStop = false;
            this.groupSessionDetails.Text = "وضعیت تشکیل جلسات";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSessions.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSessions.Location = new System.Drawing.Point(316, 13);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(80, 22);
            this.lblTotalSessions.TabIndex = 14;
            this.lblTotalSessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalSessions.TextToSet = "-";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(236, 41);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(91, 22);
            this.coolLabel10.TabIndex = 13;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "غیبت مستمر:";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(85, 41);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 22);
            this.coolLabel11.TabIndex = 13;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "غیبت هنرجو:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(85, 13);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(72, 22);
            this.coolLabel9.TabIndex = 13;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "غیبت استاد:";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(236, 13);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(74, 22);
            this.coolLabel8.TabIndex = 13;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "تشکیل شده:";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(402, 41);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(62, 22);
            this.coolLabel12.TabIndex = 13;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "مانده:";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(402, 13);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(62, 22);
            this.coolLabel6.TabIndex = 13;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "کل جلسات:";
            // 
            // floaterContainer
            // 
            this.floaterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainer.Location = new System.Drawing.Point(3, 3);
            this.floaterContainer.Name = "floaterContainer";
            this.floaterContainer.Size = new System.Drawing.Size(727, 548);
            this.floaterContainer.TabIndex = 36;
            this.floaterContainer.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainer.TitleText = "";
            this.floaterContainer.Visible = false;
            this.floaterContainer.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterContainer_Closed);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.coolLabel5);
            this.groupBox2.Controls.Add(this.coolLabel17);
            this.groupBox2.Controls.Add(this.coolLabel16);
            this.groupBox2.Controls.Add(this.coolLabel14);
            this.groupBox2.Controls.Add(this.lblHeldSessionsAmount);
            this.groupBox2.Controls.Add(this.coolLabel4);
            this.groupBox2.Controls.Add(this.lblEachSessionAmount);
            this.groupBox2.Controls.Add(this.coolLabel1);
            this.groupBox2.Controls.Add(this.lblTeacherPortion);
            this.groupBox2.Controls.Add(this.lblClassTotalFee);
            this.groupBox2.Controls.Add(this.lblMustPay);
            this.groupBox2.Controls.Add(this.lblHavePaid);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(93, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 98);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(573, 73);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(46, 21);
            this.coolLabel5.TabIndex = 9;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "وضعیت:";
            // 
            // coolLabel17
            // 
            this.coolLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel17.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel17.Location = new System.Drawing.Point(478, 47);
            this.coolLabel17.Name = "coolLabel17";
            this.coolLabel17.Size = new System.Drawing.Size(144, 21);
            this.coolLabel17.TabIndex = 9;
            this.coolLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel17.TextToSet = "مبلغ کلاس‌های تشکیل شده:";
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(123, 20);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(94, 21);
            this.coolLabel16.TabIndex = 9;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "مبلغ هر جلسه:";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(331, 20);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(94, 21);
            this.coolLabel14.TabIndex = 9;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "کل سهم استاد:";
            // 
            // lblHeldSessionsAmount
            // 
            this.lblHeldSessionsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeldSessionsAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblHeldSessionsAmount.Location = new System.Drawing.Point(370, 47);
            this.lblHeldSessionsAmount.Name = "lblHeldSessionsAmount";
            this.lblHeldSessionsAmount.Size = new System.Drawing.Size(102, 21);
            this.lblHeldSessionsAmount.TabIndex = 7;
            this.lblHeldSessionsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeldSessionsAmount.TextToSet = "-";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(542, 20);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(77, 21);
            this.coolLabel4.TabIndex = 9;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "هزینه‌ی کلاس:";
            // 
            // lblEachSessionAmount
            // 
            this.lblEachSessionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEachSessionAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblEachSessionAmount.Location = new System.Drawing.Point(15, 20);
            this.lblEachSessionAmount.Name = "lblEachSessionAmount";
            this.lblEachSessionAmount.Size = new System.Drawing.Size(102, 21);
            this.lblEachSessionAmount.TabIndex = 7;
            this.lblEachSessionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEachSessionAmount.TextToSet = "-";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(296, 47);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(77, 21);
            this.coolLabel1.TabIndex = 9;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "پرداخت شده:";
            // 
            // lblTeacherPortion
            // 
            this.lblTeacherPortion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeacherPortion.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherPortion.Location = new System.Drawing.Point(223, 20);
            this.lblTeacherPortion.Name = "lblTeacherPortion";
            this.lblTeacherPortion.Size = new System.Drawing.Size(102, 21);
            this.lblTeacherPortion.TabIndex = 7;
            this.lblTeacherPortion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeacherPortion.TextToSet = "-";
            // 
            // lblClassTotalFee
            // 
            this.lblClassTotalFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassTotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lblClassTotalFee.Location = new System.Drawing.Point(464, 20);
            this.lblClassTotalFee.Name = "lblClassTotalFee";
            this.lblClassTotalFee.Size = new System.Drawing.Size(72, 21);
            this.lblClassTotalFee.TabIndex = 7;
            this.lblClassTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClassTotalFee.TextToSet = "-";
            // 
            // lblMustPay
            // 
            this.lblMustPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMustPay.BackColor = System.Drawing.Color.Transparent;
            this.lblMustPay.Location = new System.Drawing.Point(321, 73);
            this.lblMustPay.Name = "lblMustPay";
            this.lblMustPay.Size = new System.Drawing.Size(249, 21);
            this.lblMustPay.TabIndex = 7;
            this.lblMustPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMustPay.TextToSet = "-";
            // 
            // lblHavePaid
            // 
            this.lblHavePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHavePaid.BackColor = System.Drawing.Color.Transparent;
            this.lblHavePaid.Location = new System.Drawing.Point(201, 47);
            this.lblHavePaid.Name = "lblHavePaid";
            this.lblHavePaid.Size = new System.Drawing.Size(89, 21);
            this.lblHavePaid.TabIndex = 7;
            this.lblHavePaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHavePaid.TextToSet = "-";
            // 
            // groupPay
            // 
            this.groupPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPay.Controls.Add(this.lblStatus);
            this.groupPay.Controls.Add(this.btnPay);
            this.groupPay.Controls.Add(this.txtCheckNumber);
            this.groupPay.Controls.Add(this.coolLabel3);
            this.groupPay.Controls.Add(this.coolLabel7);
            this.groupPay.Controls.Add(this.cboPayTypeID);
            this.groupPay.Controls.Add(this.txtDescription);
            this.groupPay.Controls.Add(this.coolLabel13);
            this.groupPay.Controls.Add(this.coolLabel15);
            this.groupPay.Controls.Add(this.coolLabel18);
            this.groupPay.Controls.Add(this.coolLabel19);
            this.groupPay.Controls.Add(this.txtCheckDate);
            this.groupPay.Controls.Add(this.txtPayDate);
            this.groupPay.Controls.Add(this.coolLabel20);
            this.groupPay.Controls.Add(this.txtFee);
            this.groupPay.Controls.Add(this.txtDiscount);
            this.groupPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPay.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupPay.Location = new System.Drawing.Point(11, 156);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(704, 136);
            this.groupPay.TabIndex = 21;
            this.groupPay.TabStop = false;
            this.groupPay.Text = "پرداخت حقوق برای تمام کلاس‌ها";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(502, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(192, 21);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.TextToSet = "-";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPay.Location = new System.Drawing.Point(119, 75);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(168, 21);
            this.btnPay.TabIndex = 25;
            this.btnPay.TextToSet = "پرداخت";
            this.btnPay.Clicked += new System.EventHandler(this.btnPay_Clicked);
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
            this.txtCheckNumber.Location = new System.Drawing.Point(291, 75);
            this.txtCheckNumber.Mask = "";
            this.txtCheckNumber.Message = "خالی";
            this.txtCheckNumber.MustFill = true;
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.ReadOnly = false;
            this.txtCheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckNumber.Size = new System.Drawing.Size(114, 21);
            this.txtCheckNumber.TabIndex = 23;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckNumber.TextToSet = "";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(411, 75);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(72, 21);
            this.coolLabel3.TabIndex = 24;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "شماره‌ی چک:";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(617, 76);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(77, 21);
            this.coolLabel7.TabIndex = 16;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Location = new System.Drawing.Point(497, 76);
            this.cboPayTypeID.Name = "cboPayTypeID";
            this.cboPayTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPayTypeID.SelectedItem = null;
            this.cboPayTypeID.Size = new System.Drawing.Size(114, 21);
            this.cboPayTypeID.TabIndex = 18;
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
            this.txtDescription.Location = new System.Drawing.Point(98, 105);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(513, 21);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(617, 105);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(51, 21);
            this.coolLabel13.TabIndex = 13;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "توضیحات:";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(411, 49);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(72, 21);
            this.coolLabel15.TabIndex = 17;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "تاریخ چک:";
            // 
            // coolLabel18
            // 
            this.coolLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel18.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel18.Location = new System.Drawing.Point(411, 22);
            this.coolLabel18.Name = "coolLabel18";
            this.coolLabel18.Size = new System.Drawing.Size(72, 21);
            this.coolLabel18.TabIndex = 15;
            this.coolLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel18.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel19
            // 
            this.coolLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel19.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel19.Location = new System.Drawing.Point(617, 22);
            this.coolLabel19.Name = "coolLabel19";
            this.coolLabel19.Size = new System.Drawing.Size(81, 21);
            this.coolLabel19.TabIndex = 14;
            this.coolLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel19.TextToSet = "مبلغ:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(291, 49);
            this.txtCheckDate.Mask = "0000/00/00";
            this.txtCheckDate.Message = "طول کم";
            this.txtCheckDate.MustFill = true;
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = false;
            this.txtCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckDate.Size = new System.Drawing.Size(114, 21);
            this.txtCheckDate.TabIndex = 21;
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
            this.txtPayDate.Location = new System.Drawing.Point(291, 22);
            this.txtPayDate.Mask = "0000/00/00";
            this.txtPayDate.Message = "طول کم";
            this.txtPayDate.MustFill = true;
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = false;
            this.txtPayDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayDate.Size = new System.Drawing.Size(114, 21);
            this.txtPayDate.TabIndex = 22;
            this.txtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayDate.TextToSet = "    /  /";
            // 
            // coolLabel20
            // 
            this.coolLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel20.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel20.Location = new System.Drawing.Point(214, 22);
            this.coolLabel20.Name = "coolLabel20";
            this.coolLabel20.Size = new System.Drawing.Size(81, 21);
            this.coolLabel20.TabIndex = 12;
            this.coolLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel20.TextToSet = "تخفیف:";
            this.coolLabel20.Visible = false;
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
            this.txtFee.Location = new System.Drawing.Point(497, 22);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(10000000000000));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = true;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 19;
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
            this.txtDiscount.Location = new System.Drawing.Point(94, 22);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 20;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
            this.txtDiscount.Visible = false;
            // 
            // activitySelector
            // 
            this.activitySelector.ActivityStatus = true;
            this.activitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activitySelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activitySelector.ForeColor = System.Drawing.Color.Orange;
            this.activitySelector.Location = new System.Drawing.Point(547, 20);
            this.activitySelector.Name = "activitySelector";
            this.activitySelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activitySelector.Size = new System.Drawing.Size(174, 23);
            this.activitySelector.TabIndex = 3;
            this.activitySelector.StatusChanged += new System.EventHandler(this.activitySelector_StatusChanged);
            // 
            // frmTeacherFinancialStatusAggregatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 582);
            this.Name = "frmTeacherFinancialStatusAggregatePay";
            this.Text = "پرداخت تجمیعی حقوق";
            this.LoadForm += new System.EventHandler(this.frmStudentFinancialStatus_LoadForm);
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
            this.groupSessionDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupPay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolTextBox txtTeacherID;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private System.Windows.Forms.GroupBox groupSessionDetails;
        private HengamWidgets.CoolLabel lblContinuousAbsence;
        private HengamWidgets.CoolLabel lblStudentAbsence;
        private HengamWidgets.CoolLabel lblTeacherAbsence;
        private HengamWidgets.CoolLabel lblHeld;
        private HengamWidgets.CoolLabel lblNotHeld;
        private HengamWidgets.CoolLabel lblTotalSessions;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.PanelFloater floaterContainer;
        private Hengam.Controls.ActivitySelector activitySelector;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel17;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel lblHeldSessionsAmount;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel lblEachSessionAmount;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel lblTeacherPortion;
        private HengamWidgets.CoolLabel lblClassTotalFee;
        private HengamWidgets.CoolLabel lblMustPay;
        private HengamWidgets.CoolLabel lblHavePaid;
        private System.Windows.Forms.GroupBox groupPay;
        private HengamWidgets.CoolLabel lblStatus;
        private HengamWidgets.CoolButton btnPay;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.CoolLabel coolLabel18;
        private HengamWidgets.CoolLabel coolLabel19;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolLabel coolLabel20;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolNumberBox txtDiscount;
    }
}
