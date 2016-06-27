namespace Hengam.Reports.ReportForms
{
    partial class frmReportStudentPayFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportStudentPayFactor));
            this.orderSelector = new HengamWidgets.CoolOrderbySelector();
            this.floaterStudentPicker = new HengamWidgets.PanelFloater();
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.txtClassID = new HengamWidgets.CoolNumberBox();
            this.txtClassName = new HengamWidgets.CoolTextBox();
            this.txtStudentName = new HengamWidgets.CoolTextBox();
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
            this.groupItemDetails.Controls.Add(this.txtStudentID);
            this.groupItemDetails.Controls.Add(this.txtClassID);
            this.groupItemDetails.Controls.Add(this.txtClassName);
            this.groupItemDetails.Controls.Add(this.txtStudentName);
            this.groupItemDetails.Controls.Add(this.coolLabel3);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel3, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtClassID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStudentID, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.orderSelector);
            this.pnlMain.Controls.Add(this.floaterStudentPicker);
            this.pnlMain.Controls.Add(this.floaterClassPicker);
            this.pnlMain.Controls.SetChildIndex(this.floaterClassPicker, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStudentPicker, 0);
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
            // floaterStudentPicker
            // 
            this.floaterStudentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStudentPicker.BackColor = System.Drawing.Color.DimGray;
            this.floaterStudentPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStudentPicker.Location = new System.Drawing.Point(8, 86);
            this.floaterStudentPicker.Name = "floaterStudentPicker";
            this.floaterStudentPicker.Size = new System.Drawing.Size(488, 209);
            this.floaterStudentPicker.TabIndex = 16;
            this.floaterStudentPicker.TitleColor = System.Drawing.Color.Orange;
            this.floaterStudentPicker.TitleText = "";
            this.floaterStudentPicker.Visible = false;
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
            this.txtStudentID.Location = new System.Drawing.Point(137, 28);
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
            this.txtClassName.Load += new System.EventHandler(this.txtClassName_Load);
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
            this.txtStudentName.Location = new System.Drawing.Point(207, 28);
            this.txtStudentName.Mask = "";
            this.txtStudentName.Message = "خالی";
            this.txtStudentName.MustFill = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.Size = new System.Drawing.Size(224, 21);
            this.txtStudentName.TabIndex = 15;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.TextToSet = "";
            this.txtStudentName.TextAccepted += new System.EventHandler(this.txtStudentName_TextAccepted);
            this.txtStudentName.Click += new System.EventHandler(this.txtStudentName_Click);
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
            this.coolLabel2.TextToSet = "هنرجو:";
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
            // frmReportStudentPayFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmReportStudentPayFactor";
            this.Text = "فاکتورهای مربوط به پرداخت هنرجو";
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
        private HengamWidgets.PanelFloater floaterStudentPicker;
        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.CoolNumberBox txtClassID;
        private HengamWidgets.CoolTextBox txtClassName;
        private HengamWidgets.CoolTextBox txtStudentName;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterClassPicker;
    }
}
