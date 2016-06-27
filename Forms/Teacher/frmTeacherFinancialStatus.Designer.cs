namespace Hengam.Forms
{
    partial class frmTeacherFinancialStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherFinancialStatus));
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
            this.activitySelector = new Hengam.Controls.ActivitySelector();
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
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupSessionDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(733, 486);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainer, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.activitySelector);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 248);
            this.groupDatagrid.Size = new System.Drawing.Size(727, 235);
            this.groupDatagrid.Text = "لیست کلاس‌ها و وضعیت مالی آنها";
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.activitySelector, 0);
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
            this.dataGridSection.Size = new System.Drawing.Size(715, 180);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
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
            this.floaterTeacherPicker.Size = new System.Drawing.Size(727, 430);
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
            this.floaterContainer.Size = new System.Drawing.Size(727, 480);
            this.floaterContainer.TabIndex = 36;
            this.floaterContainer.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainer.TitleText = "";
            this.floaterContainer.Visible = false;
            this.floaterContainer.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterContainer_Closed);
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
            // frmTeacherFinancialStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 514);
            this.Name = "frmTeacherFinancialStatus";
            this.Text = "وضعیت کلاس‌های استاد";
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
    }
}
