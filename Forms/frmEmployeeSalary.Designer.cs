namespace Hengam.Forms
{
    partial class frmEmployeeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeSalary));
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.txtDateTo = new HengamWidgets.CoolDateBox();
            this.txtDateFrom = new HengamWidgets.CoolDateBox();
            this.txtEmployeeID = new HengamWidgets.CoolTextBox();
            this.txtEmployeeName = new HengamWidgets.CoolTextBox();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.txtDescription = new HengamWidgets.CoolTextBox();
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.txtCheckDate = new HengamWidgets.CoolDateBox();
            this.txtPayDate = new HengamWidgets.CoolDateBox();
            this.txtDiscount = new HengamWidgets.CoolNumberBox();
            this.txtFee = new HengamWidgets.CoolNumberBox();
            this.coolLabel6 = new HengamWidgets.CoolLabel();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.txtPayID = new HengamWidgets.CoolTextBox();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.floaterStudentPicker = new HengamWidgets.PanelFloater();
            this.floaterEmployeePicker = new HengamWidgets.PanelFloater();
            this.coolLabel10 = new HengamWidgets.CoolLabel();
            this.cboPayTypeID = new HengamWidgets.CoolComboBox();
            this.txtCheckNumber = new HengamWidgets.CoolTextBox();
            this.coolLabel11 = new HengamWidgets.CoolLabel();
            this.floaterTeacherClassPicker = new HengamWidgets.PanelFloater();
            this.floaterStudentClassPicker = new HengamWidgets.PanelFloater();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupBox1);
            this.groupItemDetails.Controls.Add(this.coolLabel14);
            this.groupItemDetails.Controls.Add(this.coolLabel15);
            this.groupItemDetails.Controls.Add(this.txtDateTo);
            this.groupItemDetails.Controls.Add(this.txtDateFrom);
            this.groupItemDetails.Controls.Add(this.txtEmployeeID);
            this.groupItemDetails.Controls.Add(this.txtEmployeeName);
            this.groupItemDetails.Controls.Add(this.coolLabel13);
            this.groupItemDetails.Size = new System.Drawing.Size(638, 209);
            this.groupItemDetails.Text = "اطلاعات حقوق";
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel13, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtEmployeeName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtEmployeeID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateFrom, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateTo, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel15, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel14, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(8, 120);
            this.groupButtons.Size = new System.Drawing.Size(45, 85);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterEmployeePicker);
            this.pnlMain.Controls.Add(this.floaterStudentPicker);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterStudentClassPicker);
            this.pnlMain.Controls.Add(this.floaterTeacherClassPicker);
            this.pnlMain.Size = new System.Drawing.Size(644, 428);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterEmployeePicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 218);
            this.groupDatagrid.Size = new System.Drawing.Size(638, 207);
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
            this.dataGridSection.Size = new System.Drawing.Size(626, 181);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(193, 47);
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
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(406, 41);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(19, 21);
            this.coolLabel14.TabIndex = 15;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "تا";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(551, 41);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(81, 21);
            this.coolLabel15.TabIndex = 14;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "حقوق مربوط به:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Accepted = false;
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTo.CursorLocation = 8;
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateTo.IsEmpty = false;
            this.txtDateTo.Location = new System.Drawing.Point(286, 41);
            this.txtDateTo.Mask = "0000/00/00";
            this.txtDateTo.Message = "طول کم";
            this.txtDateTo.MustFill = true;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.ReadOnly = false;
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTo.Size = new System.Drawing.Size(114, 21);
            this.txtDateTo.TabIndex = 17;
            this.txtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateTo.TextToSet = "    /  /";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Accepted = false;
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtDateFrom.CursorLocation = 8;
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateFrom.IsEmpty = false;
            this.txtDateFrom.Location = new System.Drawing.Point(431, 41);
            this.txtDateFrom.Mask = "0000/00/00";
            this.txtDateFrom.Message = "طول کم";
            this.txtDateFrom.MustFill = true;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.ReadOnly = false;
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateFrom.Size = new System.Drawing.Size(114, 21);
            this.txtDateFrom.TabIndex = 16;
            this.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateFrom.TextToSet = "    /  /";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Accepted = false;
            this.txtEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeID.CursorLocation = 0;
            this.txtEmployeeID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmployeeID.IsEmpty = false;
            this.txtEmployeeID.LengthMax = 1000000;
            this.txtEmployeeID.LengthMin = 0;
            this.txtEmployeeID.Location = new System.Drawing.Point(244, 14);
            this.txtEmployeeID.Mask = "";
            this.txtEmployeeID.Message = "خالی";
            this.txtEmployeeID.MustFill = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = false;
            this.txtEmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeID.Size = new System.Drawing.Size(26, 21);
            this.txtEmployeeID.TabIndex = 12;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeID.TextToSet = "";
            this.txtEmployeeID.Visible = false;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Accepted = false;
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeName.CursorLocation = 0;
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtEmployeeName.IsEmpty = false;
            this.txtEmployeeName.LengthMax = 1000000;
            this.txtEmployeeName.LengthMin = 0;
            this.txtEmployeeName.Location = new System.Drawing.Point(286, 14);
            this.txtEmployeeName.Mask = "";
            this.txtEmployeeName.Message = "خالی";
            this.txtEmployeeName.MustFill = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(259, 21);
            this.txtEmployeeName.TabIndex = 11;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TextToSet = "";
            this.txtEmployeeName.Click += new System.EventHandler(this.txtEmployeeName_Click);
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(551, 14);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(47, 21);
            this.coolLabel13.TabIndex = 13;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "کارمند:";
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
            this.txtDescription.Location = new System.Drawing.Point(8, 101);
            this.txtDescription.Mask = "";
            this.txtDescription.Message = "خالی";
            this.txtDescription.MustFill = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(347, 21);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextToSet = "";
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(361, 100);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(57, 21);
            this.coolLabel8.TabIndex = 4;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "توضیحات:";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.Accepted = false;
            this.txtCheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckDate.CursorLocation = 8;
            this.txtCheckDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCheckDate.IsEmpty = false;
            this.txtCheckDate.Location = new System.Drawing.Point(8, 47);
            this.txtCheckDate.Mask = "0000/00/00";
            this.txtCheckDate.Message = "طول کم";
            this.txtCheckDate.MustFill = true;
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.ReadOnly = false;
            this.txtCheckDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckDate.Size = new System.Drawing.Size(114, 21);
            this.txtCheckDate.TabIndex = 7;
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
            this.txtPayDate.Location = new System.Drawing.Point(8, 20);
            this.txtPayDate.Mask = "0000/00/00";
            this.txtPayDate.Message = "طول کم";
            this.txtPayDate.MustFill = true;
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.ReadOnly = false;
            this.txtPayDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayDate.Size = new System.Drawing.Size(114, 21);
            this.txtPayDate.TabIndex = 7;
            this.txtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayDate.TextToSet = "    /  /";
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
            this.txtDiscount.Location = new System.Drawing.Point(241, 47);
            this.txtDiscount.Mask = "";
            this.txtDiscount.Message = "خالی";
            this.txtDiscount.MustFill = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.NumberMax = ((long)(999999999));
            this.txtDiscount.NumberMin = ((long)(0));
            this.txtDiscount.ReadOnly = false;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(114, 21);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.TextToSet = "0";
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
            this.txtFee.Location = new System.Drawing.Point(241, 20);
            this.txtFee.Mask = "";
            this.txtFee.Message = "خالی";
            this.txtFee.MustFill = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.NumberMax = ((long)(9999999999));
            this.txtFee.NumberMin = ((long)(0));
            this.txtFee.ReadOnly = false;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFee.Size = new System.Drawing.Size(114, 21);
            this.txtFee.TabIndex = 6;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFee.TextToSet = "";
            // 
            // coolLabel6
            // 
            this.coolLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel6.Location = new System.Drawing.Point(128, 47);
            this.coolLabel6.Name = "coolLabel6";
            this.coolLabel6.Size = new System.Drawing.Size(81, 21);
            this.coolLabel6.TabIndex = 4;
            this.coolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel6.TextToSet = "تاریخ چک:";
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(128, 20);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(81, 21);
            this.coolLabel5.TabIndex = 4;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ پرداخت:";
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(361, 47);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(81, 21);
            this.coolLabel4.TabIndex = 4;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "تخفیف:";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(361, 20);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(81, 21);
            this.coolLabel3.TabIndex = 4;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "مبلغ:";
            // 
            // txtPayID
            // 
            this.txtPayID.Accepted = false;
            this.txtPayID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayID.BackColor = System.Drawing.Color.Transparent;
            this.txtPayID.CursorLocation = 0;
            this.txtPayID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPayID.IsEmpty = false;
            this.txtPayID.LengthMax = 1000000;
            this.txtPayID.LengthMin = 0;
            this.txtPayID.Location = new System.Drawing.Point(206, 20);
            this.txtPayID.Mask = "";
            this.txtPayID.Message = "خالی";
            this.txtPayID.MustFill = true;
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.ReadOnly = true;
            this.txtPayID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayID.Size = new System.Drawing.Size(29, 21);
            this.txtPayID.TabIndex = 3;
            this.txtPayID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayID.TextToSet = "";
            this.txtPayID.Visible = false;
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(9, 165);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(626, 255);
            this.floaterTeacherPicker.TabIndex = 16;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
            // 
            // floaterStudentPicker
            // 
            this.floaterStudentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentPicker.Location = new System.Drawing.Point(9, 164);
            this.floaterStudentPicker.Name = "floaterStudentPicker";
            this.floaterStudentPicker.Size = new System.Drawing.Size(626, 255);
            this.floaterStudentPicker.TabIndex = 17;
            this.floaterStudentPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentPicker.TitleText = "";
            this.floaterStudentPicker.Visible = false;
            // 
            // floaterEmployeePicker
            // 
            this.floaterEmployeePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterEmployeePicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterEmployeePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterEmployeePicker.Location = new System.Drawing.Point(9, 164);
            this.floaterEmployeePicker.Name = "floaterEmployeePicker";
            this.floaterEmployeePicker.Size = new System.Drawing.Size(626, 255);
            this.floaterEmployeePicker.TabIndex = 18;
            this.floaterEmployeePicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterEmployeePicker.TitleText = "";
            this.floaterEmployeePicker.Visible = false;
            // 
            // coolLabel10
            // 
            this.coolLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel10.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel10.Location = new System.Drawing.Point(361, 74);
            this.coolLabel10.Name = "coolLabel10";
            this.coolLabel10.Size = new System.Drawing.Size(77, 21);
            this.coolLabel10.TabIndex = 4;
            this.coolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel10.TextToSet = "نحوه‌ی پرداخت:";
            // 
            // cboPayTypeID
            // 
            this.cboPayTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboPayTypeID.DisplayMember = "";
            this.cboPayTypeID.Location = new System.Drawing.Point(241, 74);
            this.cboPayTypeID.Name = "cboPayTypeID";
            this.cboPayTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPayTypeID.SelectedItem = null;
            this.cboPayTypeID.Size = new System.Drawing.Size(114, 21);
            this.cboPayTypeID.TabIndex = 5;
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
            this.txtCheckNumber.Location = new System.Drawing.Point(8, 73);
            this.txtCheckNumber.Mask = "";
            this.txtCheckNumber.Message = "خالی";
            this.txtCheckNumber.MustFill = true;
            this.txtCheckNumber.Name = "txtCheckNumber";
            this.txtCheckNumber.ReadOnly = false;
            this.txtCheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCheckNumber.Size = new System.Drawing.Size(114, 21);
            this.txtCheckNumber.TabIndex = 9;
            this.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckNumber.TextToSet = "";
            // 
            // coolLabel11
            // 
            this.coolLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel11.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel11.Location = new System.Drawing.Point(128, 73);
            this.coolLabel11.Name = "coolLabel11";
            this.coolLabel11.Size = new System.Drawing.Size(81, 21);
            this.coolLabel11.TabIndex = 10;
            this.coolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel11.TextToSet = "شماره‌ی چک:";
            // 
            // floaterTeacherClassPicker
            // 
            this.floaterTeacherClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherClassPicker.Location = new System.Drawing.Point(9, 165);
            this.floaterTeacherClassPicker.Name = "floaterTeacherClassPicker";
            this.floaterTeacherClassPicker.Size = new System.Drawing.Size(626, 255);
            this.floaterTeacherClassPicker.TabIndex = 19;
            this.floaterTeacherClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherClassPicker.TitleText = "";
            this.floaterTeacherClassPicker.Visible = false;
            // 
            // floaterStudentClassPicker
            // 
            this.floaterStudentClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentClassPicker.Location = new System.Drawing.Point(12, 165);
            this.floaterStudentClassPicker.Name = "floaterStudentClassPicker";
            this.floaterStudentClassPicker.Size = new System.Drawing.Size(626, 255);
            this.floaterStudentClassPicker.TabIndex = 19;
            this.floaterStudentClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentClassPicker.TitleText = "";
            this.floaterStudentClassPicker.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.coolLabel3);
            this.groupBox1.Controls.Add(this.coolLabel10);
            this.groupBox1.Controls.Add(this.txtPayID);
            this.groupBox1.Controls.Add(this.cboPayTypeID);
            this.groupBox1.Controls.Add(this.coolLabel6);
            this.groupBox1.Controls.Add(this.coolLabel8);
            this.groupBox1.Controls.Add(this.coolLabel5);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtCheckDate);
            this.groupBox1.Controls.Add(this.txtPayDate);
            this.groupBox1.Controls.Add(this.coolLabel11);
            this.groupBox1.Controls.Add(this.txtCheckNumber);
            this.groupBox1.Controls.Add(this.coolLabel4);
            this.groupBox1.Controls.Add(this.txtFee);
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(181, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات پرداخت";
            // 
            // frmEmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(660, 456);
            this.Name = "frmEmployeeSalary";
            this.Text = "پرداخت حقوق کارمندان";
            this.LoadForm += new System.EventHandler(this.frmOutcomeManager_LoadForm);
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
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDateBox txtCheckDate;
        private HengamWidgets.CoolDateBox txtPayDate;
        private HengamWidgets.CoolNumberBox txtDiscount;
        private HengamWidgets.CoolNumberBox txtFee;
        private HengamWidgets.CoolLabel coolLabel6;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolTextBox txtPayID;
        private HengamWidgets.CoolTextBox txtDescription;
        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.PanelFloater floaterEmployeePicker;
        private HengamWidgets.PanelFloater floaterStudentPicker;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.CoolTextBox txtCheckNumber;
        private HengamWidgets.CoolLabel coolLabel11;
        private HengamWidgets.CoolLabel coolLabel10;
        private HengamWidgets.CoolComboBox cboPayTypeID;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.CoolDateBox txtDateTo;
        private HengamWidgets.CoolDateBox txtDateFrom;
        private HengamWidgets.CoolTextBox txtEmployeeID;
        private HengamWidgets.CoolTextBox txtEmployeeName;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.PanelFloater floaterStudentClassPicker;
        private HengamWidgets.PanelFloater floaterTeacherClassPicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
