namespace Hengam.Forms
{
    partial class frmClassSessionScheduleSetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassSessionScheduleSetter));
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtClassDate = new HengamWidgets.CoolDateBox();
            this.cboRoomNo = new HengamWidgets.CoolComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFreeTimes = new HengamWidgets.CoolButton();
            this.lblClassStatus = new HengamWidgets.CoolLabel();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.floaterClassPicker = new HengamWidgets.PanelFloater();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.tabDailySchedule = new FarsiLibrary.Win.FATabStripItem();
            this.chkScheduleCheck = new HengamWidgets.CoolCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStudentAbsence = new HengamWidgets.CoolCheckBox();
            this.chkTeacherAbsence = new HengamWidgets.CoolCheckBox();
            this.txtSuccesorTeacherName = new HengamWidgets.CoolTextBox();
            this.txtSuccessorTeacher = new HengamWidgets.CoolTextBox();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.cboSessionStatus = new HengamWidgets.CoolComboBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.cboTimeID = new Hengam.Controls.TimeBox();
            this.tabWeeklySchedule = new FarsiLibrary.Win.FATabStripItem();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.cboTypicalTimeID = new Hengam.Controls.TimeBox();
            this.txtWeekCount = new HengamWidgets.CoolNumberBox();
            this.txtStartDate = new HengamWidgets.CoolDateBox();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.cboTypicalDayID = new HengamWidgets.CoolComboBox();
            this.chkFreeTimeCheck = new HengamWidgets.CoolCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.floaterTimePicker = new HengamWidgets.PanelFloater();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabDailySchedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabWeeklySchedule.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.pnlGroup);
            this.groupItemDetails.Controls.Add(this.groupBox3);
            this.groupItemDetails.Location = new System.Drawing.Point(3, 69);
            this.groupItemDetails.Size = new System.Drawing.Size(683, 165);
            this.groupItemDetails.Text = "جزئیات جلسه";
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.pnlGroup, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(7, 72);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterTimePicker);
            this.pnlMain.Size = new System.Drawing.Size(689, 399);
            this.pnlMain.Controls.SetChildIndex(this.floaterTimePicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 240);
            this.groupDatagrid.Size = new System.Drawing.Size(683, 156);
            this.groupDatagrid.Text = "جلسات ثبت شده برای کلاس";
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            // 
            // dataGridSection
            // 
            this.dataGridSection.MultiSelect = true;
            this.dataGridSection.Size = new System.Drawing.Size(671, 130);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridSection_KeyDown);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(215, 47);
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
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(65, 17);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(56, 21);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد کلاس:";
            this.coolLabel1.Visible = false;
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(621, 17);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(56, 21);
            this.coolLabel2.TabIndex = 3;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "کلاس:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(576, 64);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(82, 21);
            this.coolLabel3.TabIndex = 3;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "ساعت تشکیل:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(576, 37);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(82, 21);
            this.coolLabel5.TabIndex = 3;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ تشکیل:";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(576, 91);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(94, 21);
            this.coolLabel6.TabIndex = 3;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "اتاق محل تشکیل:";
            // 
            // txtClassID
            // 
            this.txtClassID.Accepted = false;
            this.txtClassID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassID.BackColor = System.Drawing.Color.Transparent;
            this.txtClassID.CursorLocation = 0;
            this.txtClassID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassID.HaveCurrencySeperator = true;
            this.txtClassID.IsEmpty = false;
            this.txtClassID.LengthMax = 40;
            this.txtClassID.LengthMin = 0;
            this.txtClassID.Location = new System.Drawing.Point(15, 17);
            this.txtClassID.Mask = "";
            this.txtClassID.Message = "خالی";
            this.txtClassID.MustFill = true;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.NumberMax = ((long)(9999999));
            this.txtClassID.NumberMin = ((long)(0));
            this.txtClassID.ReadOnly = false;
            this.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassID.Size = new System.Drawing.Size(44, 21);
            this.txtClassID.TabIndex = 4;
            this.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassID.TextToSet = "";
            this.txtClassID.Visible = false;
            // 
            // txtClassDate
            // 
            this.txtClassDate.Accepted = false;
            this.txtClassDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassDate.BackColor = System.Drawing.Color.Transparent;
            this.txtClassDate.CursorLocation = 8;
            this.txtClassDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassDate.IsEmpty = false;
            this.txtClassDate.Location = new System.Drawing.Point(391, 37);
            this.txtClassDate.Mask = "0000/00/00";
            this.txtClassDate.Message = "طول کم";
            this.txtClassDate.MustFill = true;
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.ReadOnly = false;
            this.txtClassDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassDate.Size = new System.Drawing.Size(179, 21);
            this.txtClassDate.TabIndex = 3;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassDate.TextToSet = "    /  /";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomNo.DisplayMember = "";
            this.cboRoomNo.Location = new System.Drawing.Point(391, 91);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboRoomNo.SelectedItem = null;
            this.cboRoomNo.Size = new System.Drawing.Size(179, 21);
            this.cboRoomNo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFreeTimes);
            this.groupBox2.Controls.Add(this.lblClassStatus);
            this.groupBox2.Controls.Add(this.txtClassName);
            this.groupBox2.Controls.Add(this.coolLabel1);
            this.groupBox2.Controls.Add(this.txtClassID);
            this.groupBox2.Controls.Add(this.coolLabel2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب کلاس";
            // 
            // btnFreeTimes
            // 
            this.btnFreeTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFreeTimes.Location = new System.Drawing.Point(8, 30);
            this.btnFreeTimes.Name = "btnFreeTimes";
            this.btnFreeTimes.Size = new System.Drawing.Size(94, 30);
            this.btnFreeTimes.TabIndex = 7;
            this.btnFreeTimes.TextToSet = "زمان‌های آزاد";
            this.btnFreeTimes.Clicked += new System.EventHandler(this.btnFreeTimes_Clicked);
            // 
            // lblClassStatus
            // 
            this.lblClassStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblClassStatus.Location = new System.Drawing.Point(186, 41);
            this.lblClassStatus.Name = "lblClassStatus";
            this.lblClassStatus.Size = new System.Drawing.Size(429, 21);
            this.lblClassStatus.TabIndex = 6;
            this.lblClassStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClassStatus.TextToSet = "-";
            // 
            // txtClassName
            // 
            this.txtClassName.Accepted = false;
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.BackColor = System.Drawing.Color.Transparent;
            this.txtClassName.CursorLocation = 0;
            this.txtClassName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassName.IsEmpty = false;
            this.txtClassName.LengthMax = 1000000;
            this.txtClassName.LengthMin = 0;
            this.txtClassName.Location = new System.Drawing.Point(186, 17);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = false;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(429, 21);
            this.txtClassName.TabIndex = 5;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
            // 
            // floaterClassPicker
            // 
            this.floaterClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterClassPicker.Location = new System.Drawing.Point(9, 47);
            this.floaterClassPicker.Name = "floaterClassPicker";
            this.floaterClassPicker.Size = new System.Drawing.Size(673, 343);
            this.floaterClassPicker.TabIndex = 3;
            this.floaterClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterClassPicker.TitleText = "";
            this.floaterClassPicker.Visible = false;
            this.floaterClassPicker.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterClassPicker_Closed);
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(9, 184);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(672, 206);
            this.floaterTeacherPicker.TabIndex = 9;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.AlwaysShowClose = false;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabMain.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabDailySchedule,
            this.tabWeeklySchedule});
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedItem = this.tabWeeklySchedule;
            this.tabMain.Size = new System.Drawing.Size(677, 145);
            this.tabMain.TabIndex = 27;
            this.tabMain.Text = "سیستم آموزشی زیتون";
            // 
            // tabDailySchedule
            // 
            this.tabDailySchedule.CanClose = false;
            this.tabDailySchedule.Controls.Add(this.chkScheduleCheck);
            this.tabDailySchedule.Controls.Add(this.cboRoomNo);
            this.tabDailySchedule.Controls.Add(this.coolLabel3);
            this.tabDailySchedule.Controls.Add(this.groupBox1);
            this.tabDailySchedule.Controls.Add(this.coolLabel5);
            this.tabDailySchedule.Controls.Add(this.txtClassDate);
            this.tabDailySchedule.Controls.Add(this.coolLabel6);
            this.tabDailySchedule.Controls.Add(this.cboSessionStatus);
            this.tabDailySchedule.Controls.Add(this.coolLabel8);
            this.tabDailySchedule.Controls.Add(this.cboTimeID);
            this.tabDailySchedule.Image = ((System.Drawing.Image)(resources.GetObject("tabDailySchedule.Image")));
            this.tabDailySchedule.IsDrawn = true;
            this.tabDailySchedule.Name = "tabDailySchedule";
            this.tabDailySchedule.Size = new System.Drawing.Size(675, 124);
            this.tabDailySchedule.TabIndex = 0;
            this.tabDailySchedule.Title = "برنامه‌ی روزانه";
            // 
            // chkScheduleCheck
            // 
            this.chkScheduleCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkScheduleCheck.Checked = true;
            this.chkScheduleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScheduleCheck.Location = new System.Drawing.Point(434, 11);
            this.chkScheduleCheck.Name = "chkScheduleCheck";
            this.chkScheduleCheck.Size = new System.Drawing.Size(224, 17);
            this.chkScheduleCheck.TabIndex = 6;
            this.chkScheduleCheck.TextToSet = "بررسی تداخل با کلاس‌های استاد";
            this.chkScheduleCheck.ThreeState = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkStudentAbsence);
            this.groupBox1.Controls.Add(this.chkTeacherAbsence);
            this.groupBox1.Controls.Add(this.txtSuccesorTeacherName);
            this.groupBox1.Controls.Add(this.txtSuccessorTeacher);
            this.groupBox1.Controls.Add(this.coolLabel7);
            this.groupBox1.Location = new System.Drawing.Point(82, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات";
            this.groupBox1.Visible = false;
            // 
            // chkStudentAbsence
            // 
            this.chkStudentAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStudentAbsence.Checked = false;
            this.chkStudentAbsence.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkStudentAbsence.Location = new System.Drawing.Point(26, 20);
            this.chkStudentAbsence.Name = "chkStudentAbsence";
            this.chkStudentAbsence.Size = new System.Drawing.Size(124, 17);
            this.chkStudentAbsence.TabIndex = 6;
            this.chkStudentAbsence.TextToSet = "غیبت هنرجویان";
            this.chkStudentAbsence.ThreeState = false;
            // 
            // chkTeacherAbsence
            // 
            this.chkTeacherAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTeacherAbsence.Checked = false;
            this.chkTeacherAbsence.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkTeacherAbsence.Location = new System.Drawing.Point(26, 43);
            this.chkTeacherAbsence.Name = "chkTeacherAbsence";
            this.chkTeacherAbsence.Size = new System.Drawing.Size(124, 17);
            this.chkTeacherAbsence.TabIndex = 6;
            this.chkTeacherAbsence.TextToSet = "غیبت استاد";
            this.chkTeacherAbsence.ThreeState = false;
            // 
            // txtSuccesorTeacherName
            // 
            this.txtSuccesorTeacherName.Accepted = false;
            this.txtSuccesorTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuccesorTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.txtSuccesorTeacherName.CursorLocation = 0;
            this.txtSuccesorTeacherName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSuccesorTeacherName.IsEmpty = false;
            this.txtSuccesorTeacherName.LengthMax = 1000000;
            this.txtSuccesorTeacherName.LengthMin = 0;
            this.txtSuccesorTeacherName.Location = new System.Drawing.Point(-70, 66);
            this.txtSuccesorTeacherName.Mask = "";
            this.txtSuccesorTeacherName.Message = "خالی";
            this.txtSuccesorTeacherName.MustFill = true;
            this.txtSuccesorTeacherName.Name = "txtSuccesorTeacherName";
            this.txtSuccesorTeacherName.ReadOnly = true;
            this.txtSuccesorTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSuccesorTeacherName.Size = new System.Drawing.Size(112, 21);
            this.txtSuccesorTeacherName.TabIndex = 5;
            this.txtSuccesorTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSuccesorTeacherName.TextToSet = "";
            this.txtSuccesorTeacherName.Click += new System.EventHandler(this.txtSuccessorTeacher_Click);
            // 
            // txtSuccessorTeacher
            // 
            this.txtSuccessorTeacher.Accepted = false;
            this.txtSuccessorTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuccessorTeacher.BackColor = System.Drawing.Color.Transparent;
            this.txtSuccessorTeacher.CursorLocation = 0;
            this.txtSuccessorTeacher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSuccessorTeacher.IsEmpty = false;
            this.txtSuccessorTeacher.LengthMax = 1000000;
            this.txtSuccessorTeacher.LengthMin = 0;
            this.txtSuccessorTeacher.Location = new System.Drawing.Point(-70, 37);
            this.txtSuccessorTeacher.Mask = "";
            this.txtSuccessorTeacher.Message = "خالی";
            this.txtSuccessorTeacher.MustFill = true;
            this.txtSuccessorTeacher.Name = "txtSuccessorTeacher";
            this.txtSuccessorTeacher.ReadOnly = true;
            this.txtSuccessorTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSuccessorTeacher.Size = new System.Drawing.Size(38, 21);
            this.txtSuccessorTeacher.TabIndex = 5;
            this.txtSuccessorTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSuccessorTeacher.TextToSet = "";
            this.txtSuccessorTeacher.Visible = false;
            this.txtSuccessorTeacher.Click += new System.EventHandler(this.txtSuccessorTeacher_Click);
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(48, 66);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(77, 21);
            this.coolLabel7.TabIndex = 3;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "استاد جایگزین:";
            // 
            // cboSessionStatus
            // 
            this.cboSessionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSessionStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboSessionStatus.DisplayMember = "";
            this.cboSessionStatus.Location = new System.Drawing.Point(82, 7);
            this.cboSessionStatus.Name = "cboSessionStatus";
            this.cboSessionStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboSessionStatus.SelectedItem = null;
            this.cboSessionStatus.Size = new System.Drawing.Size(58, 21);
            this.cboSessionStatus.TabIndex = 3;
            this.cboSessionStatus.Visible = false;
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(146, 7);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(29, 21);
            this.coolLabel8.TabIndex = 3;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "وضعیت تشکیل:";
            this.coolLabel8.Visible = false;
            // 
            // cboTimeID
            // 
            this.cboTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeID.BackColor = System.Drawing.Color.Transparent;
            this.cboTimeID.Location = new System.Drawing.Point(391, 64);
            this.cboTimeID.Name = "cboTimeID";
            this.cboTimeID.SelectedItem = null;
            this.cboTimeID.Size = new System.Drawing.Size(179, 21);
            this.cboTimeID.TabIndex = 9;
            // 
            // tabWeeklySchedule
            // 
            this.tabWeeklySchedule.CanClose = false;
            this.tabWeeklySchedule.Controls.Add(this.coolLabel12);
            this.tabWeeklySchedule.Controls.Add(this.cboTypicalTimeID);
            this.tabWeeklySchedule.Controls.Add(this.txtWeekCount);
            this.tabWeeklySchedule.Controls.Add(this.txtStartDate);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel9);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel11);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel10);
            this.tabWeeklySchedule.Controls.Add(this.cboTypicalDayID);
            this.tabWeeklySchedule.IsDrawn = true;
            this.tabWeeklySchedule.Name = "tabWeeklySchedule";
            this.tabWeeklySchedule.Selected = true;
            this.tabWeeklySchedule.Size = new System.Drawing.Size(675, 124);
            this.tabWeeklySchedule.TabIndex = 1;
            this.tabWeeklySchedule.Title = "برنامه‌ی هفتگی";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(600, 66);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(72, 21);
            this.coolLabel12.TabIndex = 5;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "از تاریخ:";
            // 
            // cboTypicalTimeID
            // 
            this.cboTypicalTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTypicalTimeID.BackColor = System.Drawing.Color.Transparent;
            this.cboTypicalTimeID.Location = new System.Drawing.Point(443, 39);
            this.cboTypicalTimeID.Name = "cboTypicalTimeID";
            this.cboTypicalTimeID.SelectedItem = null;
            this.cboTypicalTimeID.Size = new System.Drawing.Size(151, 21);
            this.cboTypicalTimeID.TabIndex = 10;
            // 
            // txtWeekCount
            // 
            this.txtWeekCount.Accepted = false;
            this.txtWeekCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeekCount.BackColor = System.Drawing.Color.Transparent;
            this.txtWeekCount.CursorLocation = 0;
            this.txtWeekCount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWeekCount.HaveCurrencySeperator = true;
            this.txtWeekCount.IsEmpty = false;
            this.txtWeekCount.LengthMax = 40;
            this.txtWeekCount.LengthMin = 0;
            this.txtWeekCount.Location = new System.Drawing.Point(443, 93);
            this.txtWeekCount.Mask = "";
            this.txtWeekCount.Message = "خالی";
            this.txtWeekCount.MustFill = true;
            this.txtWeekCount.Name = "txtWeekCount";
            this.txtWeekCount.NumberMax = ((long)(9999999));
            this.txtWeekCount.NumberMin = ((long)(0));
            this.txtWeekCount.ReadOnly = false;
            this.txtWeekCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWeekCount.Size = new System.Drawing.Size(151, 21);
            this.txtWeekCount.TabIndex = 2;
            this.txtWeekCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWeekCount.TextToSet = "";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Accepted = false;
            this.txtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartDate.BackColor = System.Drawing.Color.Transparent;
            this.txtStartDate.CursorLocation = 8;
            this.txtStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStartDate.IsEmpty = false;
            this.txtStartDate.Location = new System.Drawing.Point(443, 66);
            this.txtStartDate.Mask = "0000/00/00";
            this.txtStartDate.Message = "طول کم";
            this.txtStartDate.MustFill = true;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = false;
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartDate.Size = new System.Drawing.Size(151, 21);
            this.txtStartDate.TabIndex = 4;
            this.txtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartDate.TextToSet = "    /  /";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(600, 39);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(72, 21);
            this.coolLabel9.TabIndex = 6;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "ساعت:";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(600, 93);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 21);
            this.coolLabel11.TabIndex = 4;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "تعداد جلسات:";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(600, 12);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(72, 21);
            this.coolLabel10.TabIndex = 4;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "روز:";
            // 
            // cboTypicalDayID
            // 
            this.cboTypicalDayID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTypicalDayID.BackColor = System.Drawing.Color.Transparent;
            this.cboTypicalDayID.DisplayMember = "";
            this.cboTypicalDayID.Location = new System.Drawing.Point(443, 12);
            this.cboTypicalDayID.Name = "cboTypicalDayID";
            this.cboTypicalDayID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboTypicalDayID.SelectedItem = null;
            this.cboTypicalDayID.Size = new System.Drawing.Size(151, 21);
            this.cboTypicalDayID.TabIndex = 5;
            // 
            // chkFreeTimeCheck
            // 
            this.chkFreeTimeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFreeTimeCheck.Checked = false;
            this.chkFreeTimeCheck.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkFreeTimeCheck.Location = new System.Drawing.Point(2, 25);
            this.chkFreeTimeCheck.Name = "chkFreeTimeCheck";
            this.chkFreeTimeCheck.Size = new System.Drawing.Size(224, 17);
            this.chkFreeTimeCheck.TabIndex = 6;
            this.chkFreeTimeCheck.TextToSet = "بررسی زمان آزاد اعلام شده توسط استاد";
            this.chkFreeTimeCheck.ThreeState = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkFreeTimeCheck);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox3.Location = new System.Drawing.Point(151, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 75);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بررسی تداخل‌ها";
            this.groupBox3.Visible = false;
            // 
            // floaterTimePicker
            // 
            this.floaterTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTimePicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTimePicker.Location = new System.Drawing.Point(8, 44);
            this.floaterTimePicker.Name = "floaterTimePicker";
            this.floaterTimePicker.Size = new System.Drawing.Size(673, 343);
            this.floaterTimePicker.TabIndex = 10;
            this.floaterTimePicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTimePicker.TitleText = "";
            this.floaterTimePicker.Visible = false;
            // 
            // pnlGroup
            // 
            this.pnlGroup.Controls.Add(this.tabMain);
            this.pnlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGroup.Location = new System.Drawing.Point(3, 17);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(677, 145);
            this.pnlGroup.TabIndex = 28;
            // 
            // frmClassSessionScheduleSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(705, 427);
            this.Name = "frmClassSessionScheduleSetter";
            this.Text = "تنظیم برنامه‌ی کلاس";
            this.LoadForm += new System.EventHandler(this.frmClassSessionManager_LoadForm);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabDailySchedule.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabWeeklySchedule.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolDateBox txtClassDate;
        private HengamWidgets.CoolComboBox cboRoomNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.PanelFloater floaterClassPicker;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private FarsiLibrary.Win.FATabStrip tabMain;
        private FarsiLibrary.Win.FATabStripItem tabDailySchedule;
        private FarsiLibrary.Win.FATabStripItem tabWeeklySchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolCheckBox chkStudentAbsence;
        private HengamWidgets.CoolCheckBox chkTeacherAbsence;
        private HengamWidgets.CoolTextBox txtSuccesorTeacherName;
        private HengamWidgets.CoolTextBox txtSuccessorTeacher;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolComboBox cboSessionStatus;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolNumberBox txtWeekCount;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboTypicalDayID;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolDateBox txtStartDate;
        private Hengam.Controls.TimeBox cboTimeID;
        private Hengam.Controls.TimeBox cboTypicalTimeID;
        private System.Windows.Forms.GroupBox groupBox3;
        private HengamWidgets.CoolCheckBox chkScheduleCheck;
        private HengamWidgets.CoolCheckBox chkFreeTimeCheck;
        private HengamWidgets.CoolLabel lblClassStatus;
        private HengamWidgets.PanelFloater floaterTimePicker;
        private HengamWidgets.CoolButton btnFreeTimes;
        private System.Windows.Forms.Panel pnlGroup;
    }
}
