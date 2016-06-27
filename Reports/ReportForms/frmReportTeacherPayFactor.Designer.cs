namespace Hengam.Reports.ReportForms
{
    partial class frmReportTeacherPayFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportTeacherPayFactor));
            this.orderSelector = new HengamWidgets.CoolOrderbySelector();
            this.floaterTeacherPicker = new HengamWidgets.PanelFloater();
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.txtTeacherName = new HengamWidgets.CoolTextBox();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterClassPicker = new HengamWidgets.PanelFloater();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.txtTeacherID);
            this.groupItemDetails.Controls.Add(this.txtClassID);
            this.groupItemDetails.Controls.Add(this.txtClassName);
            this.groupItemDetails.Controls.Add(this.txtTeacherName);
            this.groupItemDetails.Controls.Add(this.coolLabel3);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel3, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtTeacherName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtTeacherID, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.orderSelector);
            this.pnlMain.Controls.Add(this.floaterTeacherPicker);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterTeacherPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.orderSelector, 0);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            this.imgButtons.Images.SetKeyName(5, "Printer");
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // orderSelector
            // 
            this.orderSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderSelector.BackColor = System.Drawing.Color.Transparent;
            this.orderSelector.BackColorList = System.Drawing.Color.DimGray;
            this.orderSelector.ForeColor = System.Drawing.Color.Orange;
            this.orderSelector.Location = new System.Drawing.Point(210, 98);
            this.orderSelector.Name = "orderSelector";
            this.orderSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderSelector.Size = new System.Drawing.Size(233, 20);
            this.orderSelector.TabIndex = 14;
            // 
            // floaterTeacherPicker
            // 
            this.floaterTeacherPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterTeacherPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterTeacherPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterTeacherPicker.Location = new System.Drawing.Point(8, 86);
            this.floaterTeacherPicker.Name = "floaterTeacherPicker";
            this.floaterTeacherPicker.Size = new System.Drawing.Size(488, 209);
            this.floaterTeacherPicker.TabIndex = 16;
            this.floaterTeacherPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterTeacherPicker.TitleText = "";
            this.floaterTeacherPicker.Visible = false;
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
            this.txtTeacherID.Location = new System.Drawing.Point(137, 28);
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
            this.txtClassID.Location = new System.Drawing.Point(137, 55);
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
            this.txtClassName.Location = new System.Drawing.Point(207, 55);
            this.txtClassName.Mask = "";
            this.txtClassName.Message = "خالی";
            this.txtClassName.MustFill = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(224, 21);
            this.txtClassName.TabIndex = 16;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassName.TextToSet = "";
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
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
            this.txtTeacherName.Location = new System.Drawing.Point(207, 28);
            this.txtTeacherName.Mask = "";
            this.txtTeacherName.Message = "خالی";
            this.txtTeacherName.MustFill = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherName.Size = new System.Drawing.Size(224, 21);
            this.txtTeacherName.TabIndex = 15;
            this.txtTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherName.TextToSet = "";
            this.txtTeacherName.TextChanged += new System.EventHandler(this.txtTeacherName_TextChanged);
            this.txtTeacherName.Click += new System.EventHandler(this.txtStudentName_Click);
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(437, 55);
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
            this.coolLabel2.Location = new System.Drawing.Point(437, 28);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(50, 21);
            this.coolLabel2.TabIndex = 14;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "استاد:";
            // 
            // floaterClassPicker
            // 
            this.floaterClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterClassPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterClassPicker.Location = new System.Drawing.Point(8, 85);
            this.floaterClassPicker.Name = "floaterClassPicker";
            this.floaterClassPicker.Size = new System.Drawing.Size(488, 209);
            this.floaterClassPicker.TabIndex = 17;
            this.floaterClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterClassPicker.TitleText = "";
            this.floaterClassPicker.Visible = false;
            // 
            // frmReportTeacherPayFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmReportTeacherPayFactor";
            this.Text = "فاکتورهای مربوط به پرداخت استاد";
            this.LoadForm += new System.EventHandler(this.frmReportStudentListOfMajor_LoadForm);
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
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolOrderbySelector orderSelector;
        private HengamWidgets.PanelFloater floaterTeacherPicker;
        private HengamWidgets.CoolTextBox txtTeacherID;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolTextBox txtTeacherName;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterClassPicker;
    }
}
