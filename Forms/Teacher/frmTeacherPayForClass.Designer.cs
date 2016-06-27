namespace Hengam.Forms
{
    partial class frmTeacherPayForClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherPayForClass));
            this.datagridSection = new HengamWidgets.CoolDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.btnPrintFactor = new Hengam.Controls.HengamAnimatedButtonSmall();
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.floaterClassPicker = new HengamWidgets.PanelFloater();
            this.floaterOutcomeDetails = new HengamWidgets.PanelFloater();
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
            this.btnPay = new HengamWidgets.CoolButton();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.lblStatus = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.floaterContainter = new HengamWidgets.PanelFloater();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupPay);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.Add(this.floaterOutcomeDetails);
            this.pnlMain.Controls.Add(this.floaterContainter);
            this.pnlMain.Size = new System.Drawing.Size(634, 475);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainter, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterOutcomeDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupPay, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(176, 213);
            // 
            // datagridSection
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridSection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridSection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datagridSection.Location = new System.Drawing.Point(3, 67);
            this.datagridSection.MultiSelect = false;
            this.datagridSection.Name = "datagridSection";
            this.datagridSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridSection.Searchable = true;
            this.datagridSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSection.Size = new System.Drawing.Size(617, 135);
            this.datagridSection.TabIndex = 2;
            this.datagridSection.OnLoadDataGrid += new System.EventHandler(this.datagridSection_OnLoadDataGrid);
            this.datagridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.datagridSection_RowDoubleClick);
            this.datagridSection.RowsSelected += new StandardWidgets.CoolDataGrid.RowsSelectionEventHandler(this.datagridSection_RowsSelected);
            this.datagridSection.Load += new System.EventHandler(this.datagridSection_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست پرداخت‌ها";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.coolLabel2);
            this.panel1.Controls.Add(this.btnPrintFactor);
            this.panel1.Controls.Add(this.datagridSection);
            this.panel1.Controls.Add(this.txtTeacherID);
            this.panel1.Controls.Add(this.coolLabel3);
            this.panel1.Controls.Add(this.txtClassID);
            this.panel1.Controls.Add(this.txtTeacherName);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 206);
            this.panel1.TabIndex = 19;
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(569, 3);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(50, 21);
            this.coolLabel2.TabIndex = 8;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "استاد:";
            // 
            // btnPrintFactor
            // 
            this.btnPrintFactor.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintFactor.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintFactor.Image")));
            this.btnPrintFactor.Location = new System.Drawing.Point(10, 3);
            this.btnPrintFactor.Name = "btnPrintFactor";
            this.btnPrintFactor.Size = new System.Drawing.Size(61, 58);
            this.btnPrintFactor.TabIndex = 18;
            this.btnPrintFactor.TextToSet = "چاپ فاکتور";
            this.btnPrintFactor.Clicked += new System.EventHandler(this.btnPrintFactor_Clicked);
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
            this.txtTeacherID.Location = new System.Drawing.Point(129, 3);
            this.txtTeacherID.Mask = "";
            this.txtTeacherID.Message = "خالی";
            this.txtTeacherID.MustFill = true;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = false;
            this.txtTeacherID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherID.Size = new System.Drawing.Size(64, 21);
            this.txtTeacherID.TabIndex = 12;
            this.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherID.TextToSet = "";
            this.txtTeacherID.Visible = false;
            this.txtTeacherID.TextChanged += new System.EventHandler(this.txtTeacherName_TextAccepted);
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(569, 30);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(41, 22);
            this.coolLabel3.TabIndex = 7;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "کلاس:";
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
            this.txtClassID.Location = new System.Drawing.Point(129, 30);
            this.txtClassID.Mask = "";
            this.txtClassID.Message = "خالی";
            this.txtClassID.MustFill = true;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.NumberMax = ((long)(9999999));
            this.txtClassID.NumberMin = ((long)(0));
            this.txtClassID.ReadOnly = false;
            this.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassID.Size = new System.Drawing.Size(64, 21);
            this.txtClassID.TabIndex = 11;
            this.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClassID.TextToSet = "";
            this.txtClassID.Visible = false;
            this.txtClassID.TextChanged += new System.EventHandler(this.txtClassName_TextAccepted);
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
            this.txtTeacherName.Location = new System.Drawing.Point(205, 3);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(358, 21);
            this.txtTeacherName.TabIndex = 9;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            this.txtTeacherName.Click += new System.EventHandler(this.txtTeacherName_Click);
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
            this.txtClassName.Location = new System.Drawing.Point(205, 30);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(358, 21);
            this.txtClassName.TabIndex = 10;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(7, 46);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(623, 426);
            this.floaterTeacherPicker.TabIndex = 14;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // floaterClassPicker
            // 
            this.floaterClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterClassPicker.Location = new System.Drawing.Point(3, 76);
            this.floaterClassPicker.Name = "floaterClassPicker";
            this.floaterClassPicker.Size = new System.Drawing.Size(625, 399);
            this.floaterClassPicker.TabIndex = 13;
            this.floaterClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterClassPicker.TitleText = "";
            this.floaterClassPicker.Visible = false;
            // 
            // floaterOutcomeDetails
            // 
            this.floaterOutcomeDetails.BackColor = System.Drawing.Color.DimGray;
            this.floaterOutcomeDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterOutcomeDetails.Location = new System.Drawing.Point(16, 85);
            this.floaterOutcomeDetails.Name = "floaterOutcomeDetails";
            this.floaterOutcomeDetails.Size = new System.Drawing.Size(418, 214);
            this.floaterOutcomeDetails.TabIndex = 15;
            this.floaterOutcomeDetails.TitleColor = System.Drawing.Color.Orange;
            this.floaterOutcomeDetails.TitleText = "";
            this.floaterOutcomeDetails.Visible = false;
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
            this.groupBox2.Location = new System.Drawing.Point(3, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 98);
            this.groupBox2.TabIndex = 4;
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
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPay.Location = new System.Drawing.Point(43, 75);
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
            this.txtCheckNumber.Location = new System.Drawing.Point(215, 75);
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
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(335, 75);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(72, 21);
            this.coolLabel11.TabIndex = 24;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "شماره‌ی چک:";
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(541, 76);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(77, 21);
            this.coolLabel10.TabIndex = 16;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // groupPay
            // 
            this.groupPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPay.Controls.Add(this.lblStatus);
            this.groupPay.Controls.Add(this.btnPay);
            this.groupPay.Controls.Add(this.txtCheckNumber);
            this.groupPay.Controls.Add(this.coolLabel11);
            this.groupPay.Controls.Add(this.coolLabel10);
            this.groupPay.Controls.Add(this.cboPayTypeID);
            this.groupPay.Controls.Add(this.txtDescription);
            this.groupPay.Controls.Add(this.coolLabel8);
            this.groupPay.Controls.Add(this.coolLabel6);
            this.groupPay.Controls.Add(this.coolLabel7);
            this.groupPay.Controls.Add(this.coolLabel9);
            this.groupPay.Controls.Add(this.txtCheckDate);
            this.groupPay.Controls.Add(this.txtPayDate);
            this.groupPay.Controls.Add(this.coolLabel12);
            this.groupPay.Controls.Add(this.txtFee);
            this.groupPay.Controls.Add(this.txtDiscount);
            this.groupPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPay.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupPay.Location = new System.Drawing.Point(3, 336);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(628, 136);
            this.groupPay.TabIndex = 20;
            this.groupPay.TabStop = false;
            this.groupPay.Text = "پرداخت حقوق به استاد";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(426, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(192, 21);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.TextToSet = "-";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Location = new System.Drawing.Point(421, 76);
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
            this.txtDescription.Location = new System.Drawing.Point(22, 105);
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
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(541, 105);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(51, 21);
            this.coolLabel8.TabIndex = 13;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "توضیحات:";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(335, 49);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(72, 21);
            this.coolLabel6.TabIndex = 17;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "تاریخ چک:";
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(335, 22);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(72, 21);
            this.coolLabel7.TabIndex = 15;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel9
            // 
            this.coolLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel9.Location = new System.Drawing.Point(541, 22);
            this.coolLabel9.Name = "coolLabel9";
            this.coolLabel9.Size = new System.Drawing.Size(81, 21);
            this.coolLabel9.TabIndex = 14;
            this.coolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel9.TextToSet = "مبلغ:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(215, 49);
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
            this.txtPayDate.Location = new System.Drawing.Point(215, 22);
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
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(138, 22);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(81, 21);
            this.coolLabel12.TabIndex = 12;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "تخفیف:";
            this.coolLabel12.Visible = false;
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
            this.txtFee.Location = new System.Drawing.Point(421, 22);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(10000000000000));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = false;
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
            this.txtDiscount.Location = new System.Drawing.Point(18, 22);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 20;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
            this.txtDiscount.Visible = false;
            // 
            // floaterContainter
            // 
            this.floaterContainter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainter.Location = new System.Drawing.Point(3, 3);
            this.floaterContainter.Name = "floaterContainter";
            this.floaterContainter.Size = new System.Drawing.Size(628, 469);
            this.floaterContainter.TabIndex = 21;
            this.floaterContainter.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainter.TitleText = "";
            this.floaterContainter.Visible = false;
            // 
            // frmTeacherPayForClass
            // 
            this.ClientSize = new System.Drawing.Size(658, 499);
            this.Name = "frmTeacherPayForClass";
            this.Text = "پرداخت حقوق استاد";
            this.LoadForm += new System.EventHandler(this.frmTeacherPayForClass_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupPay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid datagridSection;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolTextBox txtTeacherID;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.PanelFloater floaterClassPicker;
        private HengamWidgets.PanelFloater floaterOutcomeDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel lblMustPay;
        private HengamWidgets.CoolLabel lblHavePaid;
        private HengamWidgets.CoolLabel lblClassTotalFee;
        private System.Windows.Forms.GroupBox groupPay;
        private HengamWidgets.CoolButton btnPay;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private HengamWidgets.CoolLabel lblStatus;
        private Hengam.Controls.HengamAnimatedButtonSmall btnPrintFactor;
        private System.Windows.Forms.Panel panel1;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel lblTeacherPortion;
        private HengamWidgets.CoolLabel coolLabel17;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel lblHeldSessionsAmount;
        private HengamWidgets.CoolLabel lblEachSessionAmount;
        private HengamWidgets.PanelFloater floaterContainter;
    }
}
