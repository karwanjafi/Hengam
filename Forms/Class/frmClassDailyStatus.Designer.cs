namespace Hengam.Forms
{
    partial class frmCalssDailyStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridSection = new HengamWidgets.CoolDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreviousDay = new HengamWidgets.CoolButton();
            this.btnNextDay = new HengamWidgets.CoolButton();
            this.txtClassDate = new HengamWidgets.CoolDateBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtDateTo = new HengamWidgets.CoolDateBox();
            this.txtDateFrom = new HengamWidgets.CoolDateBox();
            this.floaterStatusSetterPublic = new HengamWidgets.PanelFloater();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.floaterStatusSetterPublic);
            this.pnlMain.Size = new System.Drawing.Size(718, 537);
            this.pnlMain.Controls.SetChildIndex(this.floaterStatusSetterPublic, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(218, 244);
            // 
            // datagridSection
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridSection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridSection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datagridSection.Location = new System.Drawing.Point(6, 20);
            this.datagridSection.MultiSelect = false;
            this.datagridSection.Name = "datagridSection";
            this.datagridSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridSection.Searchable = true;
            this.datagridSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSection.Size = new System.Drawing.Size(700, 414);
            this.datagridSection.TabIndex = 2;
            this.datagridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.datagridSection_RowDoubleClick);
            this.datagridSection.OnLoadDataGrid += new System.EventHandler(this.datagridSection_OnLoadDataGrid);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.datagridSection);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(3, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 440);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست جلسات";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPreviousDay);
            this.groupBox2.Controls.Add(this.btnNextDay);
            this.groupBox2.Controls.Add(this.txtClassDate);
            this.groupBox2.Controls.Add(this.coolLabel2);
            this.groupBox2.Controls.Add(this.coolLabel3);
            this.groupBox2.Controls.Add(this.coolLabel4);
            this.groupBox2.Controls.Add(this.coolLabel1);
            this.groupBox2.Controls.Add(this.txtDateTo);
            this.groupBox2.Controls.Add(this.txtDateFrom);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشاهده‌ی جلسات روزانه";
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreviousDay.Location = new System.Drawing.Point(562, 51);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(63, 27);
            this.btnPreviousDay.TabIndex = 29;
            this.btnPreviousDay.TextToSet = "روز قبل";
            this.btnPreviousDay.Clicked += new System.EventHandler(this.btnPreviousDay_Clicked);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNextDay.Location = new System.Drawing.Point(459, 49);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(63, 27);
            this.btnNextDay.TabIndex = 30;
            this.btnNextDay.TextToSet = "روز بعد";
            this.btnNextDay.Clicked += new System.EventHandler(this.btnNextDay_Clicked);
            // 
            // txtClassDate
            // 
            this.txtClassDate.Accepted = false;
            this.txtClassDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassDate.BackColor = System.Drawing.Color.Transparent;
            this.txtClassDate.CursorLocation = 8;
            this.txtClassDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassDate.IsEmpty = false;
            this.txtClassDate.Location = new System.Drawing.Point(459, 22);
            this.txtClassDate.Mask = "0000/00/00";
            this.txtClassDate.Message = "طول کم";
            this.txtClassDate.MustFill = true;
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.ReadOnly = false;
            this.txtClassDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassDate.Size = new System.Drawing.Size(97, 21);
            this.txtClassDate.TabIndex = 28;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassDate.TextToSet = "    /  /";
            this.txtClassDate.TextAccepted += new System.EventHandler(this.txtClassDate_TextAccepted);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(155, 20);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(17, 23);
            this.coolLabel2.TabIndex = 1;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "تا:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(562, 22);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(144, 23);
            this.coolLabel3.TabIndex = 1;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "مشاهده‌ی کلاس‌ها در تاریخ:";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(386, 20);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(16, 23);
            this.coolLabel4.TabIndex = 1;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "یا";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(294, 20);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(50, 23);
            this.coolLabel1.TabIndex = 1;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "از تاریخ:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Accepted = false;
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTo.CursorLocation = 8;
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateTo.IsEmpty = false;
            this.txtDateTo.Location = new System.Drawing.Point(39, 22);
            this.txtDateTo.Mask = "0000/00/00";
            this.txtDateTo.Message = "طول کم";
            this.txtDateTo.MustFill = true;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.ReadOnly = false;
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTo.Size = new System.Drawing.Size(110, 21);
            this.txtDateTo.TabIndex = 0;
            this.txtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateTo.TextToSet = "    /  /";
            this.txtDateTo.TextAccepted += new System.EventHandler(this.txtDateTo_TextAccepted);
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Accepted = false;
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtDateFrom.CursorLocation = 8;
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateFrom.IsEmpty = false;
            this.txtDateFrom.Location = new System.Drawing.Point(178, 22);
            this.txtDateFrom.Mask = "0000/00/00";
            this.txtDateFrom.Message = "طول کم";
            this.txtDateFrom.MustFill = true;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.ReadOnly = false;
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateFrom.Size = new System.Drawing.Size(110, 21);
            this.txtDateFrom.TabIndex = 0;
            this.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateFrom.TextToSet = "    /  /";
            this.txtDateFrom.TextAccepted += new System.EventHandler(this.txtDateFrom_TextAccepted);
            // 
            // floaterStatusSetterPublic
            // 
            this.floaterStatusSetterPublic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStatusSetterPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterStatusSetterPublic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStatusSetterPublic.Location = new System.Drawing.Point(3, 7);
            this.floaterStatusSetterPublic.Name = "floaterStatusSetterPublic";
            this.floaterStatusSetterPublic.Size = new System.Drawing.Size(712, 527);
            this.floaterStatusSetterPublic.TabIndex = 12;
            this.floaterStatusSetterPublic.TitleColor = System.Drawing.Color.Orange;
            this.floaterStatusSetterPublic.TitleText = "";
            this.floaterStatusSetterPublic.Visible = false;
            this.floaterStatusSetterPublic.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterStatusSetterPublic_Closed);
            // 
            // frmCalssDailyStatus
            // 
            this.ClientSize = new System.Drawing.Size(742, 561);
            this.Name = "frmCalssDailyStatus";
            this.Text = "کلاس روزانه";
            this.LoadForm += new System.EventHandler(this.frmPresenceManager_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid datagridSection;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.CoolDateBox txtDateTo;
        private HengamWidgets.CoolDateBox txtDateFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.PanelFloater floaterStatusSetterPublic;
        private HengamWidgets.CoolButton btnPreviousDay;
        private HengamWidgets.CoolButton btnNextDay;
        private HengamWidgets.CoolDateBox txtClassDate;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel4;

    }
}
