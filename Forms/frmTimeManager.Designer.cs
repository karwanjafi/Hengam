namespace Hengam.Forms
{
    partial class frmTimeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeManager));
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.tabDailySchedule = new FarsiLibrary.Win.FATabStripItem();
            this.txtTimeID = new StandardWidgets.CoolTextBox();
            this.txtTimeTo = new HengamWidgets.CoolTimeBox();
            this.txtTimeFrom = new HengamWidgets.CoolTimeBox();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.tabWeeklySchedule = new FarsiLibrary.Win.FATabStripItem();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtDuration = new HengamWidgets.CoolNumberBox();
            this.txtTimeToInterval = new HengamWidgets.CoolTimeBox();
            this.txtTimeFromInterval = new HengamWidgets.CoolTimeBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.txtGap = new HengamWidgets.CoolNumberBox();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabDailySchedule.SuspendLayout();
            this.tabWeeklySchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.tabMain);
            this.groupItemDetails.Size = new System.Drawing.Size(683, 175);
            this.groupItemDetails.Text = "جزئیات زمان";
            this.groupItemDetails.Controls.SetChildIndex(this.tabMain, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(7, 82);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Size = new System.Drawing.Size(689, 399);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 184);
            this.groupDatagrid.Size = new System.Drawing.Size(683, 212);
            this.groupDatagrid.Text = "لیست زمان‌های موجود در سیستم";
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
            this.dataGridSection.Size = new System.Drawing.Size(671, 186);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
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
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(9, 184);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(672, 206);
            this.floaterTeacherPicker.TabIndex = 9;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
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
            this.tabMain.Location = new System.Drawing.Point(3, 17);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedItem = this.tabWeeklySchedule;
            this.tabMain.Size = new System.Drawing.Size(677, 155);
            this.tabMain.TabIndex = 27;
            this.tabMain.Text = "هنگام";
            // 
            // tabDailySchedule
            // 
            this.tabDailySchedule.CanClose = false;
            this.tabDailySchedule.Controls.Add(this.txtTimeID);
            this.tabDailySchedule.Controls.Add(this.txtTimeTo);
            this.tabDailySchedule.Controls.Add(this.txtTimeFrom);
            this.tabDailySchedule.Controls.Add(this.coolLabel5);
            this.tabDailySchedule.Controls.Add(this.coolLabel3);
            this.tabDailySchedule.Controls.Add(this.coolLabel4);
            this.tabDailySchedule.Image = ((System.Drawing.Image)(resources.GetObject("tabDailySchedule.Image")));
            this.tabDailySchedule.IsDrawn = true;
            this.tabDailySchedule.Name = "tabDailySchedule";
            this.tabDailySchedule.Size = new System.Drawing.Size(675, 134);
            this.tabDailySchedule.TabIndex = 0;
            this.tabDailySchedule.Title = "تنظیم یک زمان";
            // 
            // txtTimeID
            // 
            this.txtTimeID.Accepted = false;
            this.txtTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeID.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeID.CursorLocation = 0;
            this.txtTimeID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeID.IsEmpty = false;
            this.txtTimeID.LengthMax = 1000000;
            this.txtTimeID.LengthMin = 0;
            this.txtTimeID.Location = new System.Drawing.Point(444, 18);
            this.txtTimeID.Mask = "";
            this.txtTimeID.Message = "خالی";
            this.txtTimeID.MustFill = true;
            this.txtTimeID.Name = "txtTimeID";
            this.txtTimeID.ReadOnly = false;
            this.txtTimeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeID.Size = new System.Drawing.Size(151, 21);
            this.txtTimeID.TabIndex = 16;
            this.txtTimeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimeID.TextToSet = "";
            this.txtTimeID.Visible = false;
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Accepted = false;
            this.txtTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeTo.CursorLocation = 0;
            this.txtTimeTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeTo.IsEmpty = false;
            this.txtTimeTo.Location = new System.Drawing.Point(444, 72);
            this.txtTimeTo.Mask = "";
            this.txtTimeTo.Message = "دقیقه";
            this.txtTimeTo.MustFill = true;
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.ReadOnly = false;
            this.txtTimeTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeTo.Size = new System.Drawing.Size(151, 21);
            this.txtTimeTo.TabIndex = 14;
            this.txtTimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeTo.TextToSet = "21:00";
            // 
            // txtTimeFrom
            // 
            this.txtTimeFrom.Accepted = false;
            this.txtTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeFrom.CursorLocation = 0;
            this.txtTimeFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeFrom.IsEmpty = false;
            this.txtTimeFrom.Location = new System.Drawing.Point(444, 45);
            this.txtTimeFrom.Mask = "";
            this.txtTimeFrom.Message = "دقیقه";
            this.txtTimeFrom.MustFill = true;
            this.txtTimeFrom.Name = "txtTimeFrom";
            this.txtTimeFrom.ReadOnly = false;
            this.txtTimeFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeFrom.Size = new System.Drawing.Size(151, 21);
            this.txtTimeFrom.TabIndex = 15;
            this.txtTimeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeFrom.TextToSet = "08:00";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(601, 18);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(56, 21);
            this.coolLabel5.TabIndex = 12;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "کد زمان:";
            this.coolLabel5.Visible = false;
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(601, 45);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(56, 21);
            this.coolLabel3.TabIndex = 12;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "از ساعت:";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(601, 72);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(56, 21);
            this.coolLabel4.TabIndex = 13;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "تا ساعت:";
            // 
            // tabWeeklySchedule
            // 
            this.tabWeeklySchedule.CanClose = false;
            this.tabWeeklySchedule.Controls.Add(this.coolLabel2);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel1);
            this.tabWeeklySchedule.Controls.Add(this.txtDuration);
            this.tabWeeklySchedule.Controls.Add(this.txtTimeToInterval);
            this.tabWeeklySchedule.Controls.Add(this.txtTimeFromInterval);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel12);
            this.tabWeeklySchedule.Controls.Add(this.txtGap);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel9);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel11);
            this.tabWeeklySchedule.Controls.Add(this.coolLabel10);
            this.tabWeeklySchedule.IsDrawn = true;
            this.tabWeeklySchedule.Name = "tabWeeklySchedule";
            this.tabWeeklySchedule.Selected = true;
            this.tabWeeklySchedule.Size = new System.Drawing.Size(675, 134);
            this.tabWeeklySchedule.TabIndex = 1;
            this.tabWeeklySchedule.Title = "تنظیم چند زمان";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(390, 101);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(82, 21);
            this.coolLabel2.TabIndex = 13;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel2.TextToSet = "دقیقه";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(390, 74);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(82, 21);
            this.coolLabel1.TabIndex = 13;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "دقیقه";
            // 
            // txtDuration
            // 
            this.txtDuration.Accepted = true;
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.BackColor = System.Drawing.Color.Transparent;
            this.txtDuration.CursorLocation = 0;
            this.txtDuration.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDuration.HaveCurrencySeperator = true;
            this.txtDuration.IsEmpty = false;
            this.txtDuration.LengthMax = 40;
            this.txtDuration.LengthMin = 0;
            this.txtDuration.Location = new System.Drawing.Point(478, 73);
            this.txtDuration.Mask = "";
            this.txtDuration.Message = "خالی";
            this.txtDuration.MustFill = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.NumberMax = ((long)(9999999));
            this.txtDuration.NumberMin = ((long)(0));
            this.txtDuration.ReadOnly = false;
            this.txtDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDuration.Size = new System.Drawing.Size(94, 21);
            this.txtDuration.TabIndex = 12;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDuration.TextToSet = "30";
            // 
            // txtTimeToInterval
            // 
            this.txtTimeToInterval.Accepted = false;
            this.txtTimeToInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeToInterval.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeToInterval.CursorLocation = 0;
            this.txtTimeToInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeToInterval.IsEmpty = false;
            this.txtTimeToInterval.Location = new System.Drawing.Point(421, 47);
            this.txtTimeToInterval.Mask = "";
            this.txtTimeToInterval.Message = "دقیقه";
            this.txtTimeToInterval.MustFill = true;
            this.txtTimeToInterval.Name = "txtTimeToInterval";
            this.txtTimeToInterval.ReadOnly = false;
            this.txtTimeToInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeToInterval.Size = new System.Drawing.Size(151, 21);
            this.txtTimeToInterval.TabIndex = 11;
            this.txtTimeToInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeToInterval.TextToSet = "21:00";
            // 
            // txtTimeFromInterval
            // 
            this.txtTimeFromInterval.Accepted = false;
            this.txtTimeFromInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeFromInterval.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeFromInterval.CursorLocation = 0;
            this.txtTimeFromInterval.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTimeFromInterval.IsEmpty = false;
            this.txtTimeFromInterval.Location = new System.Drawing.Point(421, 20);
            this.txtTimeFromInterval.Mask = "";
            this.txtTimeFromInterval.Message = "دقیقه";
            this.txtTimeFromInterval.MustFill = true;
            this.txtTimeFromInterval.Name = "txtTimeFromInterval";
            this.txtTimeFromInterval.ReadOnly = false;
            this.txtTimeFromInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTimeFromInterval.Size = new System.Drawing.Size(151, 21);
            this.txtTimeFromInterval.TabIndex = 11;
            this.txtTimeFromInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeFromInterval.TextToSet = "08:00";
            // 
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(578, 20);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(82, 21);
            this.coolLabel12.TabIndex = 5;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "از ساعت:";
            // 
            // txtGap
            // 
            this.txtGap.Accepted = true;
            this.txtGap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGap.BackColor = System.Drawing.Color.Transparent;
            this.txtGap.CursorLocation = 0;
            this.txtGap.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtGap.HaveCurrencySeperator = true;
            this.txtGap.IsEmpty = false;
            this.txtGap.LengthMax = 40;
            this.txtGap.LengthMin = 0;
            this.txtGap.Location = new System.Drawing.Point(478, 101);
            this.txtGap.Mask = "";
            this.txtGap.Message = "خالی";
            this.txtGap.MustFill = true;
            this.txtGap.Name = "txtGap";
            this.txtGap.NumberMax = ((long)(9999999));
            this.txtGap.NumberMin = ((long)(0));
            this.txtGap.ReadOnly = false;
            this.txtGap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGap.Size = new System.Drawing.Size(94, 21);
            this.txtGap.TabIndex = 2;
            this.txtGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGap.TextToSet = "0";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(578, 47);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(82, 21);
            this.coolLabel9.TabIndex = 6;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "تا ساعت:";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(578, 101);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(82, 21);
            this.coolLabel11.TabIndex = 4;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "فاصله‌ی زمان‌ها:";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(578, 74);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(82, 21);
            this.coolLabel10.TabIndex = 4;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "مدت زمان:";
            // 
            // frmTimeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(705, 427);
            this.Name = "frmTimeManager";
            this.Text = "تنظیم زمان‌های سیستم";
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
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabDailySchedule.ResumeLayout(false);
            this.tabWeeklySchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private FarsiLibrary.Win.FATabStrip tabMain;
        private FarsiLibrary.Win.FATabStripItem tabDailySchedule;
        private FarsiLibrary.Win.FATabStripItem tabWeeklySchedule;
        private HengamWidgets.CoolNumberBox txtGap;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolTimeBox txtTimeFromInterval;
        private HengamWidgets.CoolTimeBox txtTimeToInterval;
        private HengamWidgets.CoolNumberBox txtDuration;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolTimeBox txtTimeTo;
        private HengamWidgets.CoolTimeBox txtTimeFrom;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel4;
        private StandardWidgets.CoolTextBox txtTimeID;
        private HengamWidgets.CoolLabel coolLabel5;
    }
}
