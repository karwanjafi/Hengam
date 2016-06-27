﻿namespace Hengam.Forms.Student
{
    partial class frmStudentFinancialDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentFinancialDetails));
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterStudentPicker = new HengamWidgets.PanelFloater();
            this.floaterClassPicker = new HengamWidgets.PanelFloater();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.lblClassPrice = new HengamWidgets.CoolLabel();
            this.lblPayed = new HengamWidgets.CoolLabel();
            this.lblMustPay = new HengamWidgets.CoolLabel();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel7 = new HengamWidgets.CoolLabel();
            this.groupSessionDetails = new System.Windows.Forms.GroupBox();
            this.lblContinuousAbsence = new HengamWidgets.CoolLabel();
            this.lblStudentAbsence = new HengamWidgets.CoolLabel();
            this.lblTeacherAbsence = new HengamWidgets.CoolLabel();
            this.lblHeld = new HengamWidgets.CoolLabel();
            this.lblNotHeld = new HengamWidgets.CoolLabel();
            this.lblTotalSessions = new HengamWidgets.CoolLabel();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.coolLabel9 = new HengamWidgets.CoolLabel();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.floaterContainer = new HengamWidgets.PanelFloater();
            this.groupFinancialDetails = new System.Windows.Forms.GroupBox();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.lblBalancedAmount = new HengamWidgets.CoolLabel();
            this.lblReturnedForTeacherAmount = new HengamWidgets.CoolLabel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupSessionDetails.SuspendLayout();
            this.groupFinancialDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupSessionDetails);
            this.groupItemDetails.Controls.Add(this.groupFinancialDetails);
            this.groupItemDetails.Controls.Add(this.txtStudentID);
            this.groupItemDetails.Controls.Add(this.txtClassID);
            this.groupItemDetails.Controls.Add(this.txtClassName);
            this.groupItemDetails.Controls.Add(this.txtStudentName);
            this.groupItemDetails.Controls.Add(this.coolLabel7);
            this.groupItemDetails.Controls.Add(this.coolLabel3);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Size = new System.Drawing.Size(772, 272);
            this.groupItemDetails.Text = "اطلاعات هنرجو";
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel3, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel7, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupFinancialDetails, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupSessionDetails, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 181);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterStudentPicker);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.Add(this.floaterContainer);
            this.pnlMain.Size = new System.Drawing.Size(778, 529);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainer, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 281);
            this.groupDatagrid.Size = new System.Drawing.Size(772, 245);
            this.groupDatagrid.Text = "جزئیات پرداخت‌ها";
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
            this.imgButtons.Images.SetKeyName(6, "MoneyBack");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Size = new System.Drawing.Size(760, 219);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(260, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
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
            this.txtStudentID.Location = new System.Drawing.Point(45, 17);
            this.txtStudentID.Mask = "";
            this.txtStudentID.Message = "خالی";
            this.txtStudentID.MustFill = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentID.Size = new System.Drawing.Size(64, 21);
            this.txtStudentID.TabIndex = 18;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentID.TextToSet = "";
            this.txtStudentID.Visible = false;
            this.txtStudentID.TextAccepted += new System.EventHandler(this.txtStudentID_TextAccepted);
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
            this.txtClassID.Location = new System.Drawing.Point(45, 44);
            this.txtClassID.Mask = "";
            this.txtClassID.Message = "خالی";
            this.txtClassID.MustFill = true;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.NumberMax = ((long)(9999999));
            this.txtClassID.NumberMin = ((long)(0));
            this.txtClassID.ReadOnly = false;
            this.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassID.Size = new System.Drawing.Size(64, 21);
            this.txtClassID.TabIndex = 17;
            this.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClassID.TextToSet = "";
            this.txtClassID.Visible = false;
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
            this.txtClassName.Location = new System.Drawing.Point(286, 47);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(424, 21);
            this.txtClassName.TabIndex = 16;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
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
            this.txtStudentName.Location = new System.Drawing.Point(286, 20);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(424, 21);
            this.txtStudentName.TabIndex = 15;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            this.txtStudentName.Click += new System.EventHandler(this.txtStudentName_Click);
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(716, 47);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(41, 22);
            this.coolLabel3.TabIndex = 13;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "کلاس:";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(716, 20);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(50, 21);
            this.coolLabel2.TabIndex = 14;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "هنرجو:";
            // 
            // floaterStudentPicker
            // 
            this.floaterStudentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentPicker.Location = new System.Drawing.Point(6, 47);
            this.floaterStudentPicker.Name = "floaterStudentPicker";
            this.floaterStudentPicker.Size = new System.Drawing.Size(765, 473);
            this.floaterStudentPicker.TabIndex = 15;
            this.floaterStudentPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentPicker.TitleText = "";
            this.floaterStudentPicker.Visible = false;
            // 
            // floaterClassPicker
            // 
            this.floaterClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterClassPicker.Location = new System.Drawing.Point(6, 77);
            this.floaterClassPicker.Name = "floaterClassPicker";
            this.floaterClassPicker.Size = new System.Drawing.Size(765, 443);
            this.floaterClassPicker.TabIndex = 16;
            this.floaterClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterClassPicker.TitleText = "";
            this.floaterClassPicker.Visible = false;
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(387, 20);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(72, 22);
            this.coolLabel1.TabIndex = 13;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "هزینه کلاس:";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(389, 48);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(85, 22);
            this.coolLabel4.TabIndex = 13;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "دریافت از هنرجو:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(389, 76);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(72, 22);
            this.coolLabel5.TabIndex = 13;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "وضعیت:";
            // 
            // lblClassPrice
            // 
            this.lblClassPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblClassPrice.Location = new System.Drawing.Point(292, 20);
            this.lblClassPrice.Name = "lblClassPrice";
            this.lblClassPrice.Size = new System.Drawing.Size(91, 22);
            this.lblClassPrice.TabIndex = 13;
            this.lblClassPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClassPrice.TextToSet = "-";
            // 
            // lblPayed
            // 
            this.lblPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayed.BackColor = System.Drawing.Color.Transparent;
            this.lblPayed.Location = new System.Drawing.Point(292, 48);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(91, 22);
            this.lblPayed.TabIndex = 13;
            this.lblPayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPayed.TextToSet = "-";
            // 
            // lblMustPay
            // 
            this.lblMustPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMustPay.BackColor = System.Drawing.Color.Transparent;
            this.lblMustPay.Location = new System.Drawing.Point(125, 76);
            this.lblMustPay.Name = "lblMustPay";
            this.lblMustPay.Size = new System.Drawing.Size(258, 22);
            this.lblMustPay.TabIndex = 13;
            this.lblMustPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMustPay.TextToSet = "-";
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
            // coolLabel7
            // 
            this.coolLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel7.Location = new System.Drawing.Point(527, 75);
            this.coolLabel7.Name = "coolLabel7";
            this.coolLabel7.Size = new System.Drawing.Size(72, 22);
            this.coolLabel7.TabIndex = 13;
            this.coolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel7.TextToSet = "تشکیل شده:";
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
            this.groupSessionDetails.Location = new System.Drawing.Point(286, 75);
            this.groupSessionDetails.Name = "groupSessionDetails";
            this.groupSessionDetails.Size = new System.Drawing.Size(480, 71);
            this.groupSessionDetails.TabIndex = 19;
            this.groupSessionDetails.TabStop = false;
            this.groupSessionDetails.Text = "وضعیت تشکیل جلسات";
            // 
            // lblContinuousAbsence
            // 
            this.lblContinuousAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContinuousAbsence.BackColor = System.Drawing.Color.Transparent;
            this.lblContinuousAbsence.Location = new System.Drawing.Point(193, 43);
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
            this.coolLabel10.Location = new System.Drawing.Point(241, 41);
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
            // floaterContainer
            // 
            this.floaterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainer.Location = new System.Drawing.Point(3, 7);
            this.floaterContainer.Name = "floaterContainer";
            this.floaterContainer.Size = new System.Drawing.Size(772, 520);
            this.floaterContainer.TabIndex = 17;
            this.floaterContainer.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainer.TitleText = "";
            this.floaterContainer.Visible = false;
            this.floaterContainer.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterContainer_Closed);
            // 
            // groupFinancialDetails
            // 
            this.groupFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFinancialDetails.Controls.Add(this.coolLabel14);
            this.groupFinancialDetails.Controls.Add(this.coolLabel1);
            this.groupFinancialDetails.Controls.Add(this.coolLabel16);
            this.groupFinancialDetails.Controls.Add(this.coolLabel4);
            this.groupFinancialDetails.Controls.Add(this.coolLabel5);
            this.groupFinancialDetails.Controls.Add(this.lblMustPay);
            this.groupFinancialDetails.Controls.Add(this.lblBalancedAmount);
            this.groupFinancialDetails.Controls.Add(this.lblReturnedForTeacherAmount);
            this.groupFinancialDetails.Controls.Add(this.lblPayed);
            this.groupFinancialDetails.Controls.Add(this.lblClassPrice);
            this.groupFinancialDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupFinancialDetails.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupFinancialDetails.Location = new System.Drawing.Point(286, 152);
            this.groupFinancialDetails.Name = "groupFinancialDetails";
            this.groupFinancialDetails.Size = new System.Drawing.Size(480, 108);
            this.groupFinancialDetails.TabIndex = 20;
            this.groupFinancialDetails.TabStop = false;
            this.groupFinancialDetails.Text = "جزئیات مالی";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(125, 20);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(164, 22);
            this.coolLabel14.TabIndex = 13;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "هزینه کلاس‌های تشکیل نشده:";
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(125, 48);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(140, 22);
            this.coolLabel16.TabIndex = 13;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "پرداخت بابت تسویه حساب:";
            // 
            // lblBalancedAmount
            // 
            this.lblBalancedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalancedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBalancedAmount.Location = new System.Drawing.Point(28, 48);
            this.lblBalancedAmount.Name = "lblBalancedAmount";
            this.lblBalancedAmount.Size = new System.Drawing.Size(91, 22);
            this.lblBalancedAmount.TabIndex = 13;
            this.lblBalancedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBalancedAmount.TextToSet = "-";
            // 
            // lblReturnedForTeacherAmount
            // 
            this.lblReturnedForTeacherAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnedForTeacherAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnedForTeacherAmount.Location = new System.Drawing.Point(33, 20);
            this.lblReturnedForTeacherAmount.Name = "lblReturnedForTeacherAmount";
            this.lblReturnedForTeacherAmount.Size = new System.Drawing.Size(91, 22);
            this.lblReturnedForTeacherAmount.TabIndex = 13;
            this.lblReturnedForTeacherAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReturnedForTeacherAmount.TextToSet = "-";
            // 
            // frmStudentFinancialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 557);
            this.Name = "frmStudentFinancialDetails";
            this.Text = "جزئیات وضعیت مالی هنرجو";
            this.LoadForm += new System.EventHandler(this.frmStudentFinancialDetails_LoadForm);
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
            this.groupFinancialDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterStudentPicker;
        private HengamWidgets.PanelFloater floaterClassPicker;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel lblMustPay;
        private HengamWidgets.CoolLabel lblPayed;
        private HengamWidgets.CoolLabel lblClassPrice;
        private System.Windows.Forms.GroupBox groupSessionDetails;
        private HengamWidgets.CoolLabel coolLabel9;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel7;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel lblContinuousAbsence;
        private HengamWidgets.CoolLabel lblStudentAbsence;
        private HengamWidgets.CoolLabel lblTeacherAbsence;
        private HengamWidgets.CoolLabel lblHeld;
        private HengamWidgets.CoolLabel lblTotalSessions;
        private HengamWidgets.CoolLabel lblNotHeld;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.PanelFloater floaterContainer;
        private System.Windows.Forms.GroupBox groupFinancialDetails;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel lblReturnedForTeacherAmount;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel lblBalancedAmount;
    }
}
