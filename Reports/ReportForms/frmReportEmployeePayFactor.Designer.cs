namespace Hengam.Reports.ReportForms
{
    partial class frmReportEmployeePayFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportEmployeePayFactor));
            this.orderSelector = new HengamWidgets.CoolOrderbySelector();
            this.floaterEmployeePicker = new HengamWidgets.PanelFloater();
            this.txtEmployeeID = new HengamWidgets.CoolTextBox();
            this.txtEmployeeName = new HengamWidgets.CoolTextBox();
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
            this.groupItemDetails.Controls.Add(this.txtEmployeeID);
            this.groupItemDetails.Controls.Add(this.txtEmployeeName);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtEmployeeName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtEmployeeID, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.orderSelector);
            this.pnlMain.Controls.Add(this.floaterEmployeePicker);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterEmployeePicker, 0);
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
            // floaterEmployeePicker
            // 
            this.floaterEmployeePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterEmployeePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterEmployeePicker.Location = new System.Drawing.Point(8, 86);
            this.floaterEmployeePicker.Name = "floaterEmployeePicker";
            this.floaterEmployeePicker.Size = new System.Drawing.Size(488, 209);
            this.floaterEmployeePicker.TabIndex = 16;
            this.floaterEmployeePicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterEmployeePicker.Visible = false;
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
            this.txtEmployeeID.Location = new System.Drawing.Point(137, 28);
            this.txtEmployeeID.Mask = "";
            this.txtEmployeeID.Message = "خالی";
            this.txtEmployeeID.MustFill = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = false;
            this.txtEmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeID.Size = new System.Drawing.Size(64, 21);
            this.txtEmployeeID.TabIndex = 18;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeID.TextToSet = "";
            this.txtEmployeeID.Visible = false;
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
            this.txtEmployeeName.Location = new System.Drawing.Point(207, 28);
            this.txtEmployeeName.Mask = "";
            this.txtEmployeeName.Message = "خالی";
            this.txtEmployeeName.MustFill = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(224, 21);
            this.txtEmployeeName.TabIndex = 15;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TextToSet = "";
            this.txtEmployeeName.Click += new System.EventHandler(this.txtStudentName_Click);
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
            this.coolLabel2.TextToSet = "کارمند:";
            // 
            // floaterClassPicker
            // 
            this.floaterClassPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterClassPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterClassPicker.Location = new System.Drawing.Point(8, 85);
            this.floaterClassPicker.Name = "floaterClassPicker";
            this.floaterClassPicker.Size = new System.Drawing.Size(488, 209);
            this.floaterClassPicker.TabIndex = 17;
            this.floaterClassPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterClassPicker.Visible = false;
            // 
            // frmReportEmployeePayFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmReportEmployeePayFactor";
            this.Text = "فاکتورهای مربوط به پرداخت کارمند";
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
        private HengamWidgets.PanelFloater floaterEmployeePicker;
        private HengamWidgets.CoolTextBox txtEmployeeID;
        private HengamWidgets.CoolTextBox txtEmployeeName;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterClassPicker;
    }
}
