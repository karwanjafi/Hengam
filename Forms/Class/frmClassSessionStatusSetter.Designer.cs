namespace Hengam.Forms
{
    partial class frmClassSessionStatusSetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassSessionStatusSetter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTeacherAbsence = new HengamWidgets.CoolCheckBox();
            this.lblTeacherName = new HengamWidgets.CoolLabel();
            this.pnlSuccessor = new System.Windows.Forms.Panel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.txtSuccessorTeacher = new HengamWidgets.CoolTextBox();
            this.txtSuccesorTeacherName = new HengamWidgets.CoolTextBox();
            this.chkStudentAbsence = new HengamWidgets.CoolCheckBox();
            this.chkContinuousAbsenece = new HengamWidgets.CoolCheckBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.cboSessionStatus = new HengamWidgets.CoolComboBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.cboTimeID = new HengamWidgets.CoolComboBox();
            this.txtClassDate = new HengamWidgets.CoolDateBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboRoomNo = new HengamWidgets.CoolComboBox();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.floaterPresenceManager = new HengamWidgets.PanelFloater();
            this.floaterFinancialStatus = new HengamWidgets.PanelFloater();
            this.btnClassStatus = new Hengam.Controls.HengamAnimatedButtonSmall();
            this.btnPresenceManager = new Hengam.Controls.HengamAnimatedButtonSmall();
            this.btnFinancial = new Hengam.Controls.HengamAnimatedButtonSmall();
            this.hengamAnimatedButtonSmall1 = new Hengam.Controls.HengamAnimatedButtonSmall();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSuccessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClassStatus);
            this.pnlMain.Controls.Add(this.btnPresenceManager);
            this.pnlMain.Controls.Add(this.btnFinancial);
            this.pnlMain.Controls.Add(this.cboRoomNo);
            this.pnlMain.Controls.Add(this.coolLabel6);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.cboTimeID);
            this.pnlMain.Controls.Add(this.txtClassDate);
            this.pnlMain.Controls.Add(this.coolLabel3);
            this.pnlMain.Controls.Add(this.coolLabel5);
            this.pnlMain.Controls.Add(this.txtClassName);
            this.pnlMain.Controls.Add(this.coolLabel2);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.txtClassID);
            this.pnlMain.Controls.Add(this.floaterPresenceManager);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterFinancialStatus);
            this.pnlMain.Size = new System.Drawing.Size(535, 289);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterFinancialStatus, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterPresenceManager, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtClassID, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel2, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtClassName, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel5, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel3, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtClassDate, 0);
            this.pnlMain.Controls.SetChildIndex(this.cboTimeID, 0);
            this.pnlMain.Controls.SetChildIndex(this.panel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel6, 0);
            this.pnlMain.Controls.SetChildIndex(this.cboRoomNo, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnFinancial, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnPresenceManager, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnClassStatus, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(130, 110);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkTeacherAbsence);
            this.groupBox1.Controls.Add(this.lblTeacherName);
            this.groupBox1.Controls.Add(this.hengamAnimatedButtonSmall1);
            this.groupBox1.Controls.Add(this.pnlSuccessor);
            this.groupBox1.Controls.Add(this.chkStudentAbsence);
            this.groupBox1.Controls.Add(this.chkContinuousAbsenece);
            this.groupBox1.Controls.Add(this.coolLabel8);
            this.groupBox1.Controls.Add(this.cboSessionStatus);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 104);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات";
            // 
            // chkTeacherAbsence
            // 
            this.chkTeacherAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTeacherAbsence.Checked = false;
            this.chkTeacherAbsence.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkTeacherAbsence.Location = new System.Drawing.Point(96, 15);
            this.chkTeacherAbsence.Name = "chkTeacherAbsence";
            this.chkTeacherAbsence.Size = new System.Drawing.Size(191, 21);
            this.chkTeacherAbsence.TabIndex = 6;
            this.chkTeacherAbsence.TextToSet = "غیبت استاد";
            this.chkTeacherAbsence.ThreeState = false;
            this.chkTeacherAbsence.CheckedChanged += new System.EventHandler(this.chkTeacherAbsence_CheckedChanged);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherName.Location = new System.Drawing.Point(11, 15);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(79, 21);
            this.lblTeacherName.TabIndex = 15;
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeacherName.TextToSet = "-";
            this.lblTeacherName.Visible = false;
            // 
            // pnlSuccessor
            // 
            this.pnlSuccessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuccessor.Controls.Add(this.coolLabel7);
            this.pnlSuccessor.Controls.Add(this.txtSuccessorTeacher);
            this.pnlSuccessor.Controls.Add(this.txtSuccesorTeacherName);
            this.pnlSuccessor.Enabled = false;
            this.pnlSuccessor.Location = new System.Drawing.Point(88, 42);
            this.pnlSuccessor.Name = "pnlSuccessor";
            this.pnlSuccessor.Size = new System.Drawing.Size(282, 23);
            this.pnlSuccessor.TabIndex = 10;
            // 
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(205, 1);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(77, 21);
            this.coolLabel7.TabIndex = 3;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "استاد جایگزین:";
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
            this.txtSuccessorTeacher.Location = new System.Drawing.Point(8, 1);
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
            this.txtSuccesorTeacherName.Location = new System.Drawing.Point(52, 1);
            this.txtSuccesorTeacherName.Mask = "";
            this.txtSuccesorTeacherName.Message = "خالی";
            this.txtSuccesorTeacherName.MustFill = true;
            this.txtSuccesorTeacherName.Name = "txtSuccesorTeacherName";
            this.txtSuccesorTeacherName.ReadOnly = true;
            this.txtSuccesorTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSuccesorTeacherName.Size = new System.Drawing.Size(147, 21);
            this.txtSuccesorTeacherName.TabIndex = 5;
            this.txtSuccesorTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSuccesorTeacherName.TextToSet = "";
            this.txtSuccesorTeacherName.TextChanged += new System.EventHandler(this.txtSuccesorTeacherName_TextChanged);
            this.txtSuccesorTeacherName.Click += new System.EventHandler(this.txtSuccesorTeacherName_Click);
            // 
            // chkStudentAbsence
            // 
            this.chkStudentAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStudentAbsence.Checked = false;
            this.chkStudentAbsence.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkStudentAbsence.Location = new System.Drawing.Point(293, 15);
            this.chkStudentAbsence.Name = "chkStudentAbsence";
            this.chkStudentAbsence.Size = new System.Drawing.Size(229, 21);
            this.chkStudentAbsence.TabIndex = 6;
            this.chkStudentAbsence.TextToSet = "غیبت هنرجویان";
            this.chkStudentAbsence.ThreeState = false;
            this.chkStudentAbsence.CheckedChanged += new System.EventHandler(this.chkStudentAbsence_CheckedChanged);
            // 
            // chkContinuousAbsenece
            // 
            this.chkContinuousAbsenece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContinuousAbsenece.Checked = false;
            this.chkContinuousAbsenece.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkContinuousAbsenece.Enabled = false;
            this.chkContinuousAbsenece.Location = new System.Drawing.Point(404, 44);
            this.chkContinuousAbsenece.Name = "chkContinuousAbsenece";
            this.chkContinuousAbsenece.Size = new System.Drawing.Size(118, 21);
            this.chkContinuousAbsenece.TabIndex = 6;
            this.chkContinuousAbsenece.TextToSet = "غیبت مستمر";
            this.chkContinuousAbsenece.ThreeState = false;
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(438, 71);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(84, 21);
            this.coolLabel8.TabIndex = 8;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "وضعیت تشکیل:";
            // 
            // cboSessionStatus
            // 
            this.cboSessionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSessionStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboSessionStatus.DisplayMember = "";
            this.cboSessionStatus.Location = new System.Drawing.Point(140, 71);
            this.cboSessionStatus.Name = "cboSessionStatus";
            this.cboSessionStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboSessionStatus.SelectedItem = null;
            this.cboSessionStatus.Size = new System.Drawing.Size(292, 21);
            this.cboSessionStatus.TabIndex = 9;
            this.cboSessionStatus.SelectedValueChanged += new System.EventHandler(this.cboSessionStatus_SelectedValueChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.Accepted = false;
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.BackColor = System.Drawing.Color.Transparent;
            this.txtClassName.CursorLocation = 0;
            this.txtClassName.Enabled = false;
            this.txtClassName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassName.IsEmpty = false;
            this.txtClassName.LengthMax = 1000000;
            this.txtClassName.LengthMin = 0;
            this.txtClassName.Location = new System.Drawing.Point(3, 3);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = false;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(484, 21);
            this.txtClassName.TabIndex = 12;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(493, 3);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(39, 21);
            this.coolLabel2.TabIndex = 11;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "کلاس:";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(264, 3);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(56, 21);
            this.coolLabel1.TabIndex = 13;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کد کلاس:";
            this.coolLabel1.Visible = false;
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
            this.txtClassID.Location = new System.Drawing.Point(214, 3);
            this.txtClassID.Mask = "";
            this.txtClassID.Message = "خالی";
            this.txtClassID.MustFill = true;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.NumberMax = ((long)(9999999));
            this.txtClassID.NumberMin = ((long)(0));
            this.txtClassID.ReadOnly = false;
            this.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassID.Size = new System.Drawing.Size(44, 21);
            this.txtClassID.TabIndex = 14;
            this.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassID.TextToSet = "";
            this.txtClassID.Visible = false;
            // 
            // cboTimeID
            // 
            this.cboTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeID.BackColor = System.Drawing.Color.Transparent;
            this.cboTimeID.DisplayMember = "";
            this.cboTimeID.Enabled = false;
            this.cboTimeID.Location = new System.Drawing.Point(214, 30);
            this.cboTimeID.Name = "cboTimeID";
            this.cboTimeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboTimeID.SelectedItem = null;
            this.cboTimeID.Size = new System.Drawing.Size(89, 21);
            this.cboTimeID.TabIndex = 17;
            // 
            // txtClassDate
            // 
            this.txtClassDate.Accepted = false;
            this.txtClassDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassDate.BackColor = System.Drawing.Color.Transparent;
            this.txtClassDate.CursorLocation = 8;
            this.txtClassDate.Enabled = false;
            this.txtClassDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtClassDate.IsEmpty = false;
            this.txtClassDate.Location = new System.Drawing.Point(368, 30);
            this.txtClassDate.Mask = "0000/00/00";
            this.txtClassDate.Message = "طول کم";
            this.txtClassDate.MustFill = true;
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.ReadOnly = false;
            this.txtClassDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassDate.Size = new System.Drawing.Size(88, 21);
            this.txtClassDate.TabIndex = 18;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassDate.TextToSet = "    /  /";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(304, 30);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(44, 21);
            this.coolLabel3.TabIndex = 15;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "ساعت:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(462, 30);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(69, 21);
            this.coolLabel5.TabIndex = 16;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ تشکیل:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 10);
            this.panel1.TabIndex = 19;
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomNo.DisplayMember = "";
            this.cboRoomNo.Enabled = false;
            this.cboRoomNo.Location = new System.Drawing.Point(3, 30);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboRoomNo.SelectedItem = null;
            this.cboRoomNo.Size = new System.Drawing.Size(139, 21);
            this.cboRoomNo.TabIndex = 5;
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(143, 30);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(69, 21);
            this.coolLabel6.TabIndex = 4;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "محل تشکیل:";
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(0, 3);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(532, 283);
            this.floaterTeacherPicker.TabIndex = 21;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // floaterPresenceManager
            // 
            this.floaterPresenceManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterPresenceManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterPresenceManager.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterPresenceManager.Location = new System.Drawing.Point(1, 0);
            this.floaterPresenceManager.Name = "floaterPresenceManager";
            this.floaterPresenceManager.Size = new System.Drawing.Size(532, 283);
            this.floaterPresenceManager.TabIndex = 22;
            this.floaterPresenceManager.TitleColor = System.Drawing.Color.Orange;
            this.floaterPresenceManager.TitleText = "";
            this.floaterPresenceManager.Visible = false;
            // 
            // floaterFinancialStatus
            // 
            this.floaterFinancialStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterFinancialStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterFinancialStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterFinancialStatus.Location = new System.Drawing.Point(1, 3);
            this.floaterFinancialStatus.Name = "floaterFinancialStatus";
            this.floaterFinancialStatus.Size = new System.Drawing.Size(532, 283);
            this.floaterFinancialStatus.TabIndex = 23;
            this.floaterFinancialStatus.TitleColor = System.Drawing.Color.Orange;
            this.floaterFinancialStatus.TitleText = "";
            this.floaterFinancialStatus.Visible = false;
            // 
            // btnClassStatus
            // 
            this.btnClassStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnClassStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnClassStatus.Image")));
            this.btnClassStatus.Location = new System.Drawing.Point(276, 183);
            this.btnClassStatus.Name = "btnClassStatus";
            this.btnClassStatus.Size = new System.Drawing.Size(125, 64);
            this.btnClassStatus.TabIndex = 24;
            this.btnClassStatus.TextToSet = "وضعیت جلسات";
            this.btnClassStatus.Clicked += new System.EventHandler(this.btnClassStatus_Clicked);
            // 
            // btnPresenceManager
            // 
            this.btnPresenceManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresenceManager.BackColor = System.Drawing.Color.Transparent;
            this.btnPresenceManager.Image = ((System.Drawing.Image)(resources.GetObject("btnPresenceManager.Image")));
            this.btnPresenceManager.Location = new System.Drawing.Point(130, 183);
            this.btnPresenceManager.Name = "btnPresenceManager";
            this.btnPresenceManager.Size = new System.Drawing.Size(128, 64);
            this.btnPresenceManager.TabIndex = 16;
            this.btnPresenceManager.TextToSet = "حضور غیاب";
            this.btnPresenceManager.Clicked += new System.EventHandler(this.btnPresence_Clicked);
            // 
            // btnFinancial
            // 
            this.btnFinancial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinancial.BackColor = System.Drawing.Color.Transparent;
            this.btnFinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancial.Image")));
            this.btnFinancial.Location = new System.Drawing.Point(407, 183);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Size = new System.Drawing.Size(125, 64);
            this.btnFinancial.TabIndex = 16;
            this.btnFinancial.TextToSet = "وضعیت مالی";
            this.btnFinancial.Clicked += new System.EventHandler(this.btnFinancialStatus_Clicked);
            // 
            // hengamAnimatedButtonSmall1
            // 
            this.hengamAnimatedButtonSmall1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hengamAnimatedButtonSmall1.BackColor = System.Drawing.Color.Transparent;
            this.hengamAnimatedButtonSmall1.Image = ((System.Drawing.Image)(resources.GetObject("hengamAnimatedButtonSmall1.Image")));
            this.hengamAnimatedButtonSmall1.Location = new System.Drawing.Point(82, 28);
            this.hengamAnimatedButtonSmall1.Name = "hengamAnimatedButtonSmall1";
            this.hengamAnimatedButtonSmall1.Size = new System.Drawing.Size(50, 77);
            this.hengamAnimatedButtonSmall1.TabIndex = 16;
            this.hengamAnimatedButtonSmall1.TextToSet = "ثبت";
            this.hengamAnimatedButtonSmall1.Clicked += new System.EventHandler(this.btnSetPresenceInfo_Click);
            // 
            // frmClassSessionStatusSetter
            // 
            this.ClientSize = new System.Drawing.Size(559, 313);
            this.Name = "frmClassSessionStatusSetter";
            this.Text = "تعیین وضعیت تشکیل کلاس";
            this.LoadForm += new System.EventHandler(this.frmClassSessionPresenceOneManager_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlSuccessor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolCheckBox chkStudentAbsence;
        private HengamWidgets.CoolCheckBox chkTeacherAbsence;
        private HengamWidgets.CoolTextBox txtSuccesorTeacherName;
        private HengamWidgets.CoolTextBox txtSuccessorTeacher;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolComboBox cboSessionStatus;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolComboBox cboTimeID;
        private HengamWidgets.CoolDateBox txtClassDate;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel5;
        private System.Windows.Forms.Panel panel1;
        private HengamWidgets.CoolComboBox cboRoomNo;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.CoolCheckBox chkContinuousAbsenece;
        private System.Windows.Forms.Panel pnlSuccessor;
        private HengamWidgets.CoolLabel lblTeacherName;
        private HengamWidgets.PanelFloater floaterPresenceManager;
        private HengamWidgets.PanelFloater floaterFinancialStatus;
        private Hengam.Controls.HengamAnimatedButtonSmall hengamAnimatedButtonSmall1;
        private Hengam.Controls.HengamAnimatedButtonSmall btnPresenceManager;
        private Hengam.Controls.HengamAnimatedButtonSmall btnFinancial;
        private Hengam.Controls.HengamAnimatedButtonSmall btnClassStatus;

    }
}
