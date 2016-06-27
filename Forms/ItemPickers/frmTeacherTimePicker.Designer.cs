namespace Hengam.Forms.ItemPickers
{
    partial class frmTeacherTimePicker
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
            this.timePicker = new StandardWidgets.CoolWeekTimePicker();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.txtClassDate = new HengamWidgets.CoolDateBox();
            this.txtDescription = new HengamWidgets.CoolLabel();
            this.lblDay = new HengamWidgets.CoolLabel();
            this.txtTimeToInterval = new HengamWidgets.CoolTimeBox();
            this.txtTimeFromInterval = new HengamWidgets.CoolTimeBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.btnFreeTimeSelected = new HengamWidgets.CoolButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateName = new HengamWidgets.CoolLabel();
            this.btnNextWeek = new HengamWidgets.CoolButton();
            this.btnPreviousWeek = new HengamWidgets.CoolButton();
            this.pnlFreeTimeDetails = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlFreeTimeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.btnPreviousWeek);
            this.pnlMain.Controls.Add(this.btnNextWeek);
            this.pnlMain.Controls.Add(this.lblDay);
            this.pnlMain.Controls.Add(this.coolLabel5);
            this.pnlMain.Controls.Add(this.txtClassDate);
            this.pnlMain.Controls.Add(this.coolLabel2);
            this.pnlMain.Controls.Add(this.txtTeacherID);
            this.pnlMain.Controls.Add(this.txtTeacherName);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Size = new System.Drawing.Size(676, 455);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtTeacherName, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtTeacherID, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel2, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtClassDate, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel5, 0);
            this.pnlMain.Controls.SetChildIndex(this.lblDay, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnNextWeek, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnPreviousWeek, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(197, 203);
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.BackColor = System.Drawing.Color.Sienna;
            this.timePicker.ForeColor = System.Drawing.Color.Black;
            this.timePicker.Location = new System.Drawing.Point(17, 20);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timePicker.Size = new System.Drawing.Size(639, 305);
            this.timePicker.TabIndex = 2;
            this.timePicker.WeekDate = null;
            this.timePicker.WeekName = "نام هفته";
            this.timePicker.TimeSlotSelected += new StandardWidgets.CoolDayTimePicker.TimeSelectedEventHandler(this.timePicker_TimeSlotSelected);
            this.timePicker.FreeTimeSelected += new StandardWidgets.CoolDayTimePicker.TimeSelectedEventHandler(this.timePicker_FreeTimeSelected);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(628, 3);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(41, 21);
            this.coolLabel2.TabIndex = 16;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "استاد:";
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
            this.txtTeacherID.Location = new System.Drawing.Point(328, 3);
            this.txtTeacherID.Mask = "";
            this.txtTeacherID.Message = "خالی";
            this.txtTeacherID.MustFill = true;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = false;
            this.txtTeacherID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherID.Size = new System.Drawing.Size(64, 21);
            this.txtTeacherID.TabIndex = 18;
            this.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherID.TextToSet = "";
            this.txtTeacherID.Visible = false;
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
            this.txtTeacherName.Location = new System.Drawing.Point(398, 3);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(224, 21);
            this.txtTeacherName.TabIndex = 17;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            this.txtTeacherName.Click += new System.EventHandler(this.txtTeacherName_Click);
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(3, 30);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(670, 411);
            this.floaterTeacherPicker.TabIndex = 19;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(282, 3);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(40, 21);
            this.coolLabel5.TabIndex = 21;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ:";
            // 
            // txtClassDate
            // 
            this.txtClassDate.Accepted = false;
            this.txtClassDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassDate.BackColor = System.Drawing.Color.Transparent;
            this.txtClassDate.CursorLocation = 8;
            this.txtClassDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassDate.IsEmpty = false;
            this.txtClassDate.Location = new System.Drawing.Point(97, 3);
            this.txtClassDate.Mask = "0000/00/00";
            this.txtClassDate.Message = "طول کم";
            this.txtClassDate.MustFill = true;
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.ReadOnly = false;
            this.txtClassDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassDate.Size = new System.Drawing.Size(179, 21);
            this.txtClassDate.TabIndex = 20;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassDate.TextToSet = "    /  /";
            this.txtClassDate.TextAccepted += new System.EventHandler(this.txtClassDate_TextAccepted);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.Location = new System.Drawing.Point(17, 321);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(639, 21);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.TextToSet = "-";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Location = new System.Drawing.Point(20, 3);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(71, 21);
            this.lblDay.TabIndex = 22;
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDay.TextToSet = "-";
            // 
            // txtTimeToInterval
            // 
            this.txtTimeToInterval.Accepted = false;
            this.txtTimeToInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeToInterval.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeToInterval.CursorLocation = 0;
            this.txtTimeToInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeToInterval.IsEmpty = false;
            this.txtTimeToInterval.Location = new System.Drawing.Point(174, 10);
            this.txtTimeToInterval.Mask = "";
            this.txtTimeToInterval.Message = "خالی";
            this.txtTimeToInterval.MustFill = true;
            this.txtTimeToInterval.Name = "txtTimeToInterval";
            this.txtTimeToInterval.ReadOnly = false;
            this.txtTimeToInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeToInterval.Size = new System.Drawing.Size(83, 21);
            this.txtTimeToInterval.TabIndex = 25;
            this.txtTimeToInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeToInterval.TextToSet = "";
            // 
            // txtTimeFromInterval
            // 
            this.txtTimeFromInterval.Accepted = false;
            this.txtTimeFromInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeFromInterval.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeFromInterval.CursorLocation = 0;
            this.txtTimeFromInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeFromInterval.IsEmpty = false;
            this.txtTimeFromInterval.Location = new System.Drawing.Point(289, 10);
            this.txtTimeFromInterval.Mask = "";
            this.txtTimeFromInterval.Message = "خالی";
            this.txtTimeFromInterval.MustFill = true;
            this.txtTimeFromInterval.Name = "txtTimeFromInterval";
            this.txtTimeFromInterval.ReadOnly = false;
            this.txtTimeFromInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeFromInterval.Size = new System.Drawing.Size(80, 21);
            this.txtTimeFromInterval.TabIndex = 26;
            this.txtTimeFromInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeFromInterval.TextToSet = "";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(528, 10);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(108, 21);
            this.coolLabel12.TabIndex = 23;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "زمان آزاد انتخاب شده:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(263, 10);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(20, 21);
            this.coolLabel9.TabIndex = 24;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "تا:";
            // 
            // btnFreeTimeSelected
            // 
            this.btnFreeTimeSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFreeTimeSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFreeTimeSelected.Location = new System.Drawing.Point(74, 4);
            this.btnFreeTimeSelected.Name = "btnFreeTimeSelected";
            this.btnFreeTimeSelected.Size = new System.Drawing.Size(94, 30);
            this.btnFreeTimeSelected.TabIndex = 27;
            this.btnFreeTimeSelected.TextToSet = "انتخاب زمان آزاد";
            this.btnFreeTimeSelected.Clicked += new System.EventHandler(this.btnFreeTimeSelected_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.pnlFreeTimeDetails);
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 392);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "برنامه‌ی هفتگی";
            // 
            // lblDateName
            // 
            this.lblDateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateName.BackColor = System.Drawing.Color.Transparent;
            this.lblDateName.Location = new System.Drawing.Point(375, 10);
            this.lblDateName.Name = "lblDateName";
            this.lblDateName.Size = new System.Drawing.Size(147, 21);
            this.lblDateName.TabIndex = 23;
            this.lblDateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateName.TextToSet = "-";
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextWeek.Location = new System.Drawing.Point(118, 26);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(63, 27);
            this.btnNextWeek.TabIndex = 27;
            this.btnNextWeek.TextToSet = "هفته بعد";
            this.btnNextWeek.Clicked += new System.EventHandler(this.btnNextWeek_Clicked);
            // 
            // btnPreviousWeek
            // 
            this.btnPreviousWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreviousWeek.Location = new System.Drawing.Point(213, 26);
            this.btnPreviousWeek.Name = "btnPreviousWeek";
            this.btnPreviousWeek.Size = new System.Drawing.Size(63, 27);
            this.btnPreviousWeek.TabIndex = 27;
            this.btnPreviousWeek.TextToSet = "هفته قبل";
            this.btnPreviousWeek.Clicked += new System.EventHandler(this.btnPreviousWeek_Clicked);
            // 
            // pnlFreeTimeDetails
            // 
            this.pnlFreeTimeDetails.Controls.Add(this.coolLabel12);
            this.pnlFreeTimeDetails.Controls.Add(this.lblDateName);
            this.pnlFreeTimeDetails.Controls.Add(this.btnFreeTimeSelected);
            this.pnlFreeTimeDetails.Controls.Add(this.txtTimeFromInterval);
            this.pnlFreeTimeDetails.Controls.Add(this.coolLabel9);
            this.pnlFreeTimeDetails.Controls.Add(this.txtTimeToInterval);
            this.pnlFreeTimeDetails.Location = new System.Drawing.Point(17, 344);
            this.pnlFreeTimeDetails.Name = "pnlFreeTimeDetails";
            this.pnlFreeTimeDetails.Size = new System.Drawing.Size(639, 38);
            this.pnlFreeTimeDetails.TabIndex = 28;
            // 
            // frmTeacherTimePicker
            // 
            this.ClientSize = new System.Drawing.Size(700, 479);
            this.Name = "frmTeacherTimePicker";
            this.Text = "انتخاب زمان برای کلاس استاد";
            this.LoadForm += new System.EventHandler(this.frmTeacherTimePicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlFreeTimeDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private StandardWidgets.CoolWeekTimePicker timePicker;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolTextBox txtTeacherID;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolDateBox txtClassDate;
        private HengamWidgets.CoolLabel txtDescription;
        private HengamWidgets.CoolLabel lblDay;
        private HengamWidgets.CoolTimeBox txtTimeToInterval;
        private HengamWidgets.CoolTimeBox txtTimeFromInterval;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolButton btnFreeTimeSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolButton btnPreviousWeek;
        private HengamWidgets.CoolButton btnNextWeek;
        private HengamWidgets.CoolLabel lblDateName;
        private System.Windows.Forms.Panel pnlFreeTimeDetails;
    }
}
