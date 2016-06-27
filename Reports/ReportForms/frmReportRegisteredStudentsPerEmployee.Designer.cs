namespace Hengam.Reports.ReportForms
{
    partial class frmReportRegisteredStudentsPerEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportRegisteredStudentsPerEmployee));
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.orderSelector = new HengamWidgets.CoolOrderbySelector();
            this.txtYear = new HengamWidgets.CoolYearBox();
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
            this.groupItemDetails.Controls.Add(this.orderSelector);
            this.groupItemDetails.Controls.Add(this.txtYear);
            this.groupItemDetails.Controls.Add(this.coolLabel12);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel12, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtYear, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.orderSelector, 0);
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
            // coolLabel12
            // 
            this.coolLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel12.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel12.Location = new System.Drawing.Point(446, 44);
            this.coolLabel12.Name = "coolLabel12";
            this.coolLabel12.Size = new System.Drawing.Size(43, 21);
            this.coolLabel12.TabIndex = 9;
            this.coolLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel12.TextToSet = "سال:";
            // 
            // orderSelector
            // 
            this.orderSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderSelector.BackColor = System.Drawing.Color.Transparent;
            this.orderSelector.BackColorList = System.Drawing.Color.DimGray;
            this.orderSelector.ForeColor = System.Drawing.Color.Orange;
            this.orderSelector.Location = new System.Drawing.Point(256, 100);
            this.orderSelector.Name = "orderSelector";
            this.orderSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderSelector.Size = new System.Drawing.Size(233, 20);
            this.orderSelector.TabIndex = 14;
            this.orderSelector.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Accepted = false;
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.CursorLocation = 0;
            this.txtYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtYear.HaveCurrencySeperator = false;
            this.txtYear.IsEmpty = false;
            this.txtYear.LengthMax = 4;
            this.txtYear.LengthMin = 0;
            this.txtYear.Location = new System.Drawing.Point(353, 44);
            this.txtYear.Mask = "";
            this.txtYear.Message = "خالی";
            this.txtYear.MustFill = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.NumberMax = ((long)(9999));
            this.txtYear.NumberMin = ((long)(1000));
            this.txtYear.ReadOnly = false;
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtYear.Size = new System.Drawing.Size(87, 21);
            this.txtYear.TabIndex = 10;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtYear.TextToSet = "";
            // 
            // frmReportRegisteredStudentsPerEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmReportRegisteredStudentsPerEmployee";
            this.Text = "گزارش تعداد ثبت‌ها بر اساس کارمند";
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

        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolOrderbySelector orderSelector;
        private HengamWidgets.CoolYearBox txtYear;
    }
}
