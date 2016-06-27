namespace Hengam.Forms
{
    partial class frmPresenceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresenceManager));
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtClassDate = new HengamWidgets.CoolDateBox();
            this.cboPresenceStatus = new HengamWidgets.CoolComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.cboTimeID = new Hengam.Controls.TimeBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterSessionPicker = new HengamWidgets.PanelFloater();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.floaterFinancialStatus = new HengamWidgets.PanelFloater();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.coolLabel8);
            this.groupItemDetails.Controls.Add(this.txtStudentName);
            this.groupItemDetails.Controls.Add(this.coolLabel6);
            this.groupItemDetails.Controls.Add(this.txtStudentID);
            this.groupItemDetails.Controls.Add(this.txtDescription);
            this.groupItemDetails.Controls.Add(this.coolLabel4);
            this.groupItemDetails.Controls.Add(this.cboPresenceStatus);
            this.groupItemDetails.Location = new System.Drawing.Point(3, 78);
            this.groupItemDetails.Size = new System.Drawing.Size(683, 117);
            this.groupItemDetails.Text = "جزئیات جلسه";
            this.groupItemDetails.Controls.SetChildIndex(this.cboPresenceStatus, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel4, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDescription, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel6, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel8, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(8, 26);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.floaterSessionPicker);
            this.pnlMain.Controls.Add(this.floaterFinancialStatus);
            this.pnlMain.Size = new System.Drawing.Size(689, 348);
            this.pnlMain.Controls.SetChildIndex(this.floaterFinancialStatus, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterSessionPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 201);
            this.groupDatagrid.Size = new System.Drawing.Size(683, 144);
            this.groupDatagrid.Text = "هنرجویان ثبت‌نام شده در کلاس";
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "Present");
            this.imgButtons.Images.SetKeyName(5, "Absent");
            this.imgButtons.Images.SetKeyName(6, "Money");
            // 
            // dataGridSection
            // 
            this.dataGridSection.MultiSelect = true;
            this.dataGridSection.Size = new System.Drawing.Size(671, 118);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.RowsSelected += new StandardWidgets.CoolDataGrid.RowsSelectionEventHandler(this.dataGridSection_RowsSelected);
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
            this.coolLabel1.Location = new System.Drawing.Point(160, 17);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(56, 21);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد کلاس:";
            this.coolLabel1.Visible = false;
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(407, 42);
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
            this.coolLabel5.Location = new System.Drawing.Point(609, 42);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(68, 21);
            this.coolLabel5.TabIndex = 3;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ تشکیل:";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(596, 47);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(81, 21);
            this.coolLabel8.TabIndex = 3;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "حضور غیاب:";
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
            this.txtClassID.Location = new System.Drawing.Point(110, 17);
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
            this.txtClassDate.Location = new System.Drawing.Point(495, 42);
            this.txtClassDate.Mask = "0000/00/00";
            this.txtClassDate.Message = "طول کم";
            this.txtClassDate.MustFill = true;
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.ReadOnly = true;
            this.txtClassDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassDate.Size = new System.Drawing.Size(108, 21);
            this.txtClassDate.TabIndex = 3;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassDate.TextToSet = "    /  /";
            this.txtClassDate.Click += new System.EventHandler(this.ttxtClassName_Click);
            // 
            // cboPresenceStatus
            // 
            this.cboPresenceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPresenceStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboPresenceStatus.DisplayMember = "";
            this.cboPresenceStatus.Location = new System.Drawing.Point(178, 47);
            this.cboPresenceStatus.Name = "cboPresenceStatus";
            this.cboPresenceStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPresenceStatus.SelectedItem = null;
            this.cboPresenceStatus.Size = new System.Drawing.Size(412, 21);
            this.cboPresenceStatus.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtClassName);
            this.groupBox2.Controls.Add(this.coolLabel1);
            this.groupBox2.Controls.Add(this.txtClassDate);
            this.groupBox2.Controls.Add(this.txtClassID);
            this.groupBox2.Controls.Add(this.cboTimeID);
            this.groupBox2.Controls.Add(this.coolLabel2);
            this.groupBox2.Controls.Add(this.coolLabel5);
            this.groupBox2.Controls.Add(this.coolLabel3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب جلسه";
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
            this.txtClassName.Location = new System.Drawing.Point(224, 17);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(379, 21);
            this.txtClassName.TabIndex = 5;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
            // 
            // cboTimeID
            // 
            this.cboTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeID.BackColor = System.Drawing.Color.Transparent;
            this.cboTimeID.Enabled = false;
            this.cboTimeID.Location = new System.Drawing.Point(224, 42);
            this.cboTimeID.Name = "cboTimeID";
            this.cboTimeID.SelectedItem = null;
            this.cboTimeID.Size = new System.Drawing.Size(177, 21);
            this.cboTimeID.TabIndex = 9;
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(609, 17);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(56, 21);
            this.coolLabel2.TabIndex = 3;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "کلاس:";
            // 
            // floaterSessionPicker
            // 
            this.floaterSessionPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterSessionPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterSessionPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterSessionPicker.Location = new System.Drawing.Point(9, 47);
            this.floaterSessionPicker.Name = "floaterSessionPicker";
            this.floaterSessionPicker.Size = new System.Drawing.Size(673, 292);
            this.floaterSessionPicker.TabIndex = 3;
            this.floaterSessionPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterSessionPicker.TitleText = "";
            this.floaterSessionPicker.Visible = false;
            this.floaterSessionPicker.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterClassPicker_Closed);
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(596, 20);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(56, 21);
            this.coolLabel4.TabIndex = 3;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "هنرجو:";
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
            this.txtStudentName.Location = new System.Drawing.Point(178, 20);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(412, 21);
            this.txtStudentName.TabIndex = 5;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(596, 74);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(56, 21);
            this.coolLabel6.TabIndex = 3;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "توضیحات:";
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
            this.txtDescription.Location = new System.Drawing.Point(178, 74);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(412, 21);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            this.txtDescription.Click += new System.EventHandler(this.txtClassName_Click);
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
            this.txtStudentID.Location = new System.Drawing.Point(122, 20);
            this.txtStudentID.Mask = "";
            this.txtStudentID.Message = "خالی";
            this.txtStudentID.MustFill = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentID.Size = new System.Drawing.Size(50, 21);
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentID.TextToSet = "";
            this.txtStudentID.Visible = false;
            // 
            // floaterFinancialStatus
            // 
            this.floaterFinancialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterFinancialStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterFinancialStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterFinancialStatus.Location = new System.Drawing.Point(3, 3);
            this.floaterFinancialStatus.Name = "floaterFinancialStatus";
            this.floaterFinancialStatus.Size = new System.Drawing.Size(683, 342);
            this.floaterFinancialStatus.TabIndex = 24;
            this.floaterFinancialStatus.TitleColor = System.Drawing.Color.Orange;
            this.floaterFinancialStatus.TitleText = "";
            this.floaterFinancialStatus.Visible = false;
            // 
            // frmPresenceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(705, 376);
            this.Name = "frmPresenceManager";
            this.Text = "حضور غیاب";
            this.LoadForm += new System.EventHandler(this.frmPresenceManager_LoadForm);
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
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolDateBox txtClassDate;
        private HengamWidgets.CoolComboBox cboPresenceStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.PanelFloater floaterSessionPicker;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolLabel coolLabel2;
        private Hengam.Controls.TimeBox cboTimeID;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.PanelFloater floaterFinancialStatus;
    }
}
