namespace Hengam.Forms
{
    partial class frmComboManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComboManager));
            this.txtLiteralID = new HengamWidgets.CoolNumberBox();
            this.txtLiteralName = new HengamWidgets.CoolTextBox();
            this.txtLiteralDescription = new HengamWidgets.CoolTextBox();
            this.lblLiteralID = new HengamWidgets.CoolLabel();
            this.lblLiteralName = new HengamWidgets.CoolLabel();
            this.lblLiteralDescription = new HengamWidgets.CoolLabel();
            this.cboLiteralType = new HengamWidgets.CoolComboBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
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
            this.groupItemDetails.Controls.Add(this.lblLiteralDescription);
            this.groupItemDetails.Controls.Add(this.lblLiteralName);
            this.groupItemDetails.Controls.Add(this.lblLiteralID);
            this.groupItemDetails.Controls.Add(this.txtLiteralDescription);
            this.groupItemDetails.Controls.Add(this.txtLiteralID);
            this.groupItemDetails.Controls.Add(this.txtLiteralName);
            this.groupItemDetails.Location = new System.Drawing.Point(3, 32);
            this.groupItemDetails.Size = new System.Drawing.Size(499, 102);
            this.groupItemDetails.Text = "اطلاعات سطر جعبه";
            this.groupItemDetails.Controls.SetChildIndex(this.txtLiteralName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtLiteralID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtLiteralDescription, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.lblLiteralID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.lblLiteralName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.lblLiteralDescription, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 11);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboLiteralType);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.cboLiteralType, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
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
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // btnSampleButton
            // 
            this.btnSampleButton.Location = new System.Drawing.Point(60, 38);
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // txtLiteralID
            // 
            this.txtLiteralID.Accepted = false;
            this.txtLiteralID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiteralID.BackColor = System.Drawing.Color.Transparent;
            this.txtLiteralID.CursorLocation = 0;
            this.txtLiteralID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtLiteralID.HaveCurrencySeperator = false;
            this.txtLiteralID.IsEmpty = false;
            this.txtLiteralID.LengthMax = 40;
            this.txtLiteralID.LengthMin = 0;
            this.txtLiteralID.Location = new System.Drawing.Point(260, 18);
            this.txtLiteralID.Mask = "";
            this.txtLiteralID.Message = "خالی";
            this.txtLiteralID.MustFill = true;
            this.txtLiteralID.Name = "txtLiteralID";
            this.txtLiteralID.NumberMax = ((long)(99999999999));
            this.txtLiteralID.NumberMin = ((long)(0));
            this.txtLiteralID.ReadOnly = false;
            this.txtLiteralID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLiteralID.Size = new System.Drawing.Size(119, 21);
            this.txtLiteralID.TabIndex = 1;
            this.txtLiteralID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLiteralID.TextToSet = "";
            // 
            // txtLiteralName
            // 
            this.txtLiteralName.Accepted = false;
            this.txtLiteralName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiteralName.BackColor = System.Drawing.Color.Transparent;
            this.txtLiteralName.CursorLocation = 0;
            this.txtLiteralName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtLiteralName.IsEmpty = false;
            this.txtLiteralName.LengthMax = 1000000;
            this.txtLiteralName.LengthMin = 0;
            this.txtLiteralName.Location = new System.Drawing.Point(158, 45);
            this.txtLiteralName.Mask = "";
            this.txtLiteralName.Message = "خالی";
            this.txtLiteralName.MustFill = true;
            this.txtLiteralName.Name = "txtLiteralName";
            this.txtLiteralName.ReadOnly = false;
            this.txtLiteralName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLiteralName.Size = new System.Drawing.Size(221, 21);
            this.txtLiteralName.TabIndex = 2;
            this.txtLiteralName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLiteralName.TextToSet = "";
            // 
            // txtLiteralDescription
            // 
            this.txtLiteralDescription.Accepted = false;
            this.txtLiteralDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiteralDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtLiteralDescription.CursorLocation = 0;
            this.txtLiteralDescription.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtLiteralDescription.IsEmpty = false;
            this.txtLiteralDescription.LengthMax = 1000000;
            this.txtLiteralDescription.LengthMin = 0;
            this.txtLiteralDescription.Location = new System.Drawing.Point(158, 72);
            this.txtLiteralDescription.Mask = "";
            this.txtLiteralDescription.Message = "خالی";
            this.txtLiteralDescription.MustFill = true;
            this.txtLiteralDescription.Name = "txtLiteralDescription";
            this.txtLiteralDescription.ReadOnly = false;
            this.txtLiteralDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLiteralDescription.Size = new System.Drawing.Size(221, 21);
            this.txtLiteralDescription.TabIndex = 3;
            this.txtLiteralDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLiteralDescription.TextToSet = "";
            // 
            // lblLiteralID
            // 
            this.lblLiteralID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiteralID.BackColor = System.Drawing.Color.Transparent;
            this.lblLiteralID.Location = new System.Drawing.Point(384, 18);
            this.lblLiteralID.Name = "lblLiteralID";
            this.lblLiteralID.Size = new System.Drawing.Size(94, 21);
            this.lblLiteralID.TabIndex = 4;
            this.lblLiteralID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLiteralID.TextToSet = "کد:";
            // 
            // lblLiteralName
            // 
            this.lblLiteralName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiteralName.BackColor = System.Drawing.Color.Transparent;
            this.lblLiteralName.Location = new System.Drawing.Point(385, 45);
            this.lblLiteralName.Name = "lblLiteralName";
            this.lblLiteralName.Size = new System.Drawing.Size(94, 25);
            this.lblLiteralName.TabIndex = 5;
            this.lblLiteralName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLiteralName.TextToSet = "نام:";
            // 
            // lblLiteralDescription
            // 
            this.lblLiteralDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiteralDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblLiteralDescription.Location = new System.Drawing.Point(384, 72);
            this.lblLiteralDescription.Name = "lblLiteralDescription";
            this.lblLiteralDescription.Size = new System.Drawing.Size(94, 22);
            this.lblLiteralDescription.TabIndex = 6;
            this.lblLiteralDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLiteralDescription.TextToSet = "توضیحات:";
            // 
            // cboLiteralType
            // 
            this.cboLiteralType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLiteralType.BackColor = System.Drawing.Color.Transparent;
            this.cboLiteralType.DisplayMember = "";
            this.cboLiteralType.Location = new System.Drawing.Point(213, 7);
            this.cboLiteralType.Name = "cboLiteralType";
            this.cboLiteralType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboLiteralType.SelectedItem = null;
            this.cboLiteralType.Size = new System.Drawing.Size(209, 21);
            this.cboLiteralType.TabIndex = 7;
            this.cboLiteralType.SelectedValueChanged += new System.EventHandler(this.cboLiteralType_SelectedValueChanged);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(428, 7);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(68, 21);
            this.coolLabel1.TabIndex = 7;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "انتخاب جعبه:";
            // 
            // frmComboManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmComboManager";
            this.Text = "تنظیم گزینه‌های موجود در جعبه ها";
            this.LoadForm += new System.EventHandler(this.frmComboManager_LoadForm);
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

        private HengamWidgets.CoolNumberBox txtLiteralID;
        private HengamWidgets.CoolComboBox cboLiteralType;
        private HengamWidgets.CoolLabel lblLiteralDescription;
        private HengamWidgets.CoolLabel lblLiteralName;
        private HengamWidgets.CoolLabel lblLiteralID;
        private HengamWidgets.CoolTextBox txtLiteralDescription;
        private HengamWidgets.CoolTextBox txtLiteralName;
        private HengamWidgets.CoolLabel coolLabel1;
    }
}
