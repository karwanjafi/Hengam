namespace Hengam.Forms.Store
{
    partial class frmStoreSalesTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreSalesTracking));
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.coolLabel15 = new HengamWidgets.CoolLabel();
            this.coolLabel14 = new HengamWidgets.CoolLabel();
            this.txtFilterDateTo = new HengamWidgets.CoolDateBox();
            this.txtFilterDateFrom = new HengamWidgets.CoolDateBox();
            this.cboFilterStuffTypeID = new HengamWidgets.CoolComboBox();
            this.chkJustActives = new HengamWidgets.CoolCheckBox();
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
            this.groupItemDetails.Controls.Add(this.chkJustActives);
            this.groupItemDetails.Controls.Add(this.coolLabel16);
            this.groupItemDetails.Controls.Add(this.coolLabel15);
            this.groupItemDetails.Controls.Add(this.coolLabel14);
            this.groupItemDetails.Controls.Add(this.txtFilterDateTo);
            this.groupItemDetails.Controls.Add(this.txtFilterDateFrom);
            this.groupItemDetails.Controls.Add(this.cboFilterStuffTypeID);
            this.groupItemDetails.Size = new System.Drawing.Size(707, 114);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.cboFilterStuffTypeID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtFilterDateFrom, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtFilterDateTo, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel14, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel15, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel16, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.chkJustActives, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 23);
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(713, 298);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 123);
            this.groupDatagrid.Size = new System.Drawing.Size(707, 172);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Size = new System.Drawing.Size(695, 146);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(227, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(656, 55);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(45, 21);
            this.coolLabel16.TabIndex = 38;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "نوع کالا:";
            // 
            // coolLabel15
            // 
            this.coolLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel15.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel15.Location = new System.Drawing.Point(451, 20);
            this.coolLabel15.Name = "coolLabel15";
            this.coolLabel15.Size = new System.Drawing.Size(17, 21);
            this.coolLabel15.TabIndex = 37;
            this.coolLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel15.TextToSet = "تا:";
            // 
            // coolLabel14
            // 
            this.coolLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel14.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel14.Location = new System.Drawing.Point(577, 20);
            this.coolLabel14.Name = "coolLabel14";
            this.coolLabel14.Size = new System.Drawing.Size(124, 21);
            this.coolLabel14.TabIndex = 34;
            this.coolLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel14.TextToSet = "نمایش اطلاعات مربوط به:";
            // 
            // txtFilterDateTo
            // 
            this.txtFilterDateTo.Accepted = false;
            this.txtFilterDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateTo.IsEmpty = false;
            this.txtFilterDateTo.Location = new System.Drawing.Point(343, 20);
            this.txtFilterDateTo.Mask = "0000/00/00";
            this.txtFilterDateTo.Message = "طول کم";
            this.txtFilterDateTo.MustFill = true;
            this.txtFilterDateTo.Name = "txtFilterDateTo";
            this.txtFilterDateTo.ReadOnly = false;
            this.txtFilterDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateTo.Size = new System.Drawing.Size(102, 21);
            this.txtFilterDateTo.TabIndex = 36;
            this.txtFilterDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateTo.TextToSet = "    /  /";
            this.txtFilterDateTo.TextChanged += new System.EventHandler(this.txtFilterDateFrom_TextChanged);
            // 
            // txtFilterDateFrom
            // 
            this.txtFilterDateFrom.Accepted = false;
            this.txtFilterDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtFilterDateFrom.IsEmpty = false;
            this.txtFilterDateFrom.Location = new System.Drawing.Point(469, 20);
            this.txtFilterDateFrom.Mask = "0000/00/00";
            this.txtFilterDateFrom.Message = "طول کم";
            this.txtFilterDateFrom.MustFill = true;
            this.txtFilterDateFrom.Name = "txtFilterDateFrom";
            this.txtFilterDateFrom.ReadOnly = false;
            this.txtFilterDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterDateFrom.Size = new System.Drawing.Size(102, 21);
            this.txtFilterDateFrom.TabIndex = 35;
            this.txtFilterDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterDateFrom.TextToSet = "    /  /";
            this.txtFilterDateFrom.TextChanged += new System.EventHandler(this.txtFilterDateFrom_TextChanged);
            // 
            // cboFilterStuffTypeID
            // 
            this.cboFilterStuffTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStuffTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterStuffTypeID.DisplayMember = "";
            this.cboFilterStuffTypeID.Location = new System.Drawing.Point(343, 55);
            this.cboFilterStuffTypeID.Name = "cboFilterStuffTypeID";
            this.cboFilterStuffTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboFilterStuffTypeID.SelectedItem = null;
            this.cboFilterStuffTypeID.Size = new System.Drawing.Size(307, 21);
            this.cboFilterStuffTypeID.TabIndex = 39;
            this.cboFilterStuffTypeID.SelectedValueChanged += new System.EventHandler(this.cboFilterStuffTypeID_SelectedValueChanged);
            // 
            // chkJustActives
            // 
            this.chkJustActives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJustActives.Checked = false;
            this.chkJustActives.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkJustActives.Location = new System.Drawing.Point(489, 82);
            this.chkJustActives.Name = "chkJustActives";
            this.chkJustActives.Size = new System.Drawing.Size(212, 24);
            this.chkJustActives.TabIndex = 40;
            this.chkJustActives.TextToSet = "فقط تراکنش‌های فعال نشان داده شود.";
            this.chkJustActives.CheckedChanged += new System.EventHandler(this.chkJustActives_CheckedChanged);
            // 
            // frmStoreSalesTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(729, 326);
            this.Name = "frmStoreSalesTracking";
            this.Text = "رهگیری خرید و فروش";
            this.LoadForm += new System.EventHandler(this.frmStoreSalesTracking_LoadForm);
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

        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolLabel coolLabel15;
        private HengamWidgets.CoolLabel coolLabel14;
        private HengamWidgets.CoolDateBox txtFilterDateTo;
        private HengamWidgets.CoolDateBox txtFilterDateFrom;
        private HengamWidgets.CoolComboBox cboFilterStuffTypeID;
        private HengamWidgets.CoolCheckBox chkJustActives;

    }
}
