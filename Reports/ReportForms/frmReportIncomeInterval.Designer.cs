namespace Hengam.Reports.ReportForms
{
    partial class frmReportIncomeInterval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportIncomeInterval));
            this.txtDateFrom = new HengamWidgets.CoolDateBox();
            this.coolLabel12 = new HengamWidgets.CoolLabel();
            this.coolLabel13 = new HengamWidgets.CoolLabel();
            this.txtDateTo = new HengamWidgets.CoolDateBox();
            this.orderSelector = new HengamWidgets.CoolOrderbySelector();
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
            this.groupItemDetails.Controls.Add(this.txtDateFrom);
            this.groupItemDetails.Controls.Add(this.coolLabel12);
            this.groupItemDetails.Controls.Add(this.coolLabel13);
            this.groupItemDetails.Controls.Add(this.txtDateTo);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateTo, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel13, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel12, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateFrom, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.orderSelector);
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
            // txtDateFrom
            // 
            this.txtDateFrom.Accepted = false;
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtDateFrom.CursorLocation = 8;
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateFrom.IsEmpty = false;
            this.txtDateFrom.Location = new System.Drawing.Point(339, 44);
            this.txtDateFrom.Mask = "0000/00/00";
            this.txtDateFrom.Message = "طول کم";
            this.txtDateFrom.MustFill = true;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.ReadOnly = false;
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateFrom.Size = new System.Drawing.Size(101, 21);
            this.txtDateFrom.TabIndex = 11;
            this.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateFrom.TextToSet = "    /  /";
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
            this.coolLabel12.TextToSet = "از تاریخ:";
            // 
            // coolLabel13
            // 
            this.coolLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel13.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel13.Location = new System.Drawing.Point(314, 44);
            this.coolLabel13.Name = "coolLabel13";
            this.coolLabel13.Size = new System.Drawing.Size(19, 21);
            this.coolLabel13.TabIndex = 8;
            this.coolLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel13.TextToSet = "تا:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Accepted = false;
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTo.CursorLocation = 8;
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateTo.IsEmpty = false;
            this.txtDateTo.Location = new System.Drawing.Point(207, 44);
            this.txtDateTo.Mask = "0000/00/00";
            this.txtDateTo.Message = "طول کم";
            this.txtDateTo.MustFill = true;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.ReadOnly = false;
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTo.Size = new System.Drawing.Size(101, 21);
            this.txtDateTo.TabIndex = 10;
            this.txtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateTo.TextToSet = "    /  /";
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
            // frmReportIncomeInterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmReportIncomeInterval";
            this.Text = "گزارش درآمد روزانه";
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

        private HengamWidgets.CoolDateBox txtDateFrom;
        private HengamWidgets.CoolLabel coolLabel12;
        private HengamWidgets.CoolLabel coolLabel13;
        private HengamWidgets.CoolDateBox txtDateTo;
        private HengamWidgets.CoolOrderbySelector orderSelector;
    }
}
