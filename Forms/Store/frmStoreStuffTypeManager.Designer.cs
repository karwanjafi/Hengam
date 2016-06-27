namespace Hengam.Forms.Store
{
    partial class frmStoreStuffTypeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreStuffTypeManager));
            this.coolLabel8 = new HengamWidgets.CoolLabel();
            this.txtStuffID = new HengamWidgets.CoolTextBox();
            this.coolLabel4 = new HengamWidgets.CoolLabel();
            this.cboStuffTypeID = new HengamWidgets.CoolComboBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.txtBuyDate = new HengamWidgets.CoolDateBox();
            this.coolLabel5 = new HengamWidgets.CoolLabel();
            this.txtStuffCount = new HengamWidgets.CoolNumberBox();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.floaterStoreStuffDetails = new HengamWidgets.PanelFloater();
            this.floaterContainter = new HengamWidgets.PanelFloater();
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
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Controls.Add(this.txtStuffCount);
            this.groupItemDetails.Controls.Add(this.txtBuyDate);
            this.groupItemDetails.Controls.Add(this.coolLabel5);
            this.groupItemDetails.Controls.Add(this.coolLabel8);
            this.groupItemDetails.Controls.Add(this.txtStuffName);
            this.groupItemDetails.Controls.Add(this.coolLabel1);
            this.groupItemDetails.Controls.Add(this.txtStuffID);
            this.groupItemDetails.Controls.Add(this.coolLabel4);
            this.groupItemDetails.Controls.Add(this.cboStuffTypeID);
            this.groupItemDetails.Size = new System.Drawing.Size(499, 104);
            this.groupItemDetails.Text = "بررسی موجودی غرفه";
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.cboStuffTypeID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel4, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStuffID, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel1, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStuffName, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel8, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel5, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtBuyDate, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtStuffCount, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 13);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.floaterStoreStuffDetails);
            this.pnlMain.Controls.Add(this.floaterContainter);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainter, 0);
            this.pnlMain.Controls.SetChildIndex(this.floaterStoreStuffDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 113);
            this.groupDatagrid.Size = new System.Drawing.Size(499, 182);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            this.imgButtons.Images.SetKeyName(5, "StuffTracking");
            this.imgButtons.Images.SetKeyName(6, "CheckItems");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Size = new System.Drawing.Size(487, 156);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // coolLabel8
            // 
            this.coolLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel8.Location = new System.Drawing.Point(271, 44);
            this.coolLabel8.Name = "coolLabel8";
            this.coolLabel8.Size = new System.Drawing.Size(56, 21);
            this.coolLabel8.TabIndex = 8;
            this.coolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel8.TextToSet = "نوع کالا:";
            this.coolLabel8.Visible = false;
            // 
            // txtStuffID
            // 
            this.txtStuffID.Accepted = false;
            this.txtStuffID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffID.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffID.CursorLocation = 0;
            this.txtStuffID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffID.IsEmpty = false;
            this.txtStuffID.LengthMax = 1000000;
            this.txtStuffID.LengthMin = 0;
            this.txtStuffID.Location = new System.Drawing.Point(113, 17);
            this.txtStuffID.Mask = "";
            this.txtStuffID.Message = "خالی";
            this.txtStuffID.MustFill = true;
            this.txtStuffID.Name = "txtStuffID";
            this.txtStuffID.ReadOnly = true;
            this.txtStuffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffID.Size = new System.Drawing.Size(152, 21);
            this.txtStuffID.TabIndex = 9;
            this.txtStuffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffID.TextToSet = "";
            this.txtStuffID.Visible = false;
            // 
            // coolLabel4
            // 
            this.coolLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel4.Location = new System.Drawing.Point(271, 17);
            this.coolLabel4.Name = "coolLabel4";
            this.coolLabel4.Size = new System.Drawing.Size(56, 21);
            this.coolLabel4.TabIndex = 6;
            this.coolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel4.TextToSet = "کد کالا:";
            this.coolLabel4.Visible = false;
            // 
            // cboStuffTypeID
            // 
            this.cboStuffTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStuffTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboStuffTypeID.DisplayMember = "";
            this.cboStuffTypeID.Location = new System.Drawing.Point(19, 44);
            this.cboStuffTypeID.Name = "cboStuffTypeID";
            this.cboStuffTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboStuffTypeID.SelectedItem = null;
            this.cboStuffTypeID.Size = new System.Drawing.Size(246, 21);
            this.cboStuffTypeID.TabIndex = 7;
            this.cboStuffTypeID.Visible = false;
            this.cboStuffTypeID.SelectedValueChanged += new System.EventHandler(this.cboStuffTypeID_SelectedValueChanged);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(271, 71);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(56, 21);
            this.coolLabel1.TabIndex = 6;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "نام کالا:";
            this.coolLabel1.Visible = false;
            // 
            // txtStuffName
            // 
            this.txtStuffName.Accepted = false;
            this.txtStuffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffName.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffName.CursorLocation = 0;
            this.txtStuffName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffName.IsEmpty = false;
            this.txtStuffName.LengthMax = 1000000;
            this.txtStuffName.LengthMin = 0;
            this.txtStuffName.Location = new System.Drawing.Point(19, 71);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = false;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(246, 21);
            this.txtStuffName.TabIndex = 9;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            this.txtStuffName.Visible = false;
            // 
            // txtBuyDate
            // 
            this.txtBuyDate.Accepted = false;
            this.txtBuyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyDate.CursorLocation = 8;
            this.txtBuyDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtBuyDate.IsEmpty = false;
            this.txtBuyDate.Location = new System.Drawing.Point(157, 41);
            this.txtBuyDate.Mask = "0000/00/00";
            this.txtBuyDate.Message = "طول کم";
            this.txtBuyDate.MustFill = true;
            this.txtBuyDate.Name = "txtBuyDate";
            this.txtBuyDate.ReadOnly = false;
            this.txtBuyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBuyDate.Size = new System.Drawing.Size(108, 21);
            this.txtBuyDate.TabIndex = 11;
            this.txtBuyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuyDate.TextToSet = "    /  /";
            this.txtBuyDate.Visible = false;
            // 
            // coolLabel5
            // 
            this.coolLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel5.Location = new System.Drawing.Point(271, 41);
            this.coolLabel5.Name = "coolLabel5";
            this.coolLabel5.Size = new System.Drawing.Size(56, 21);
            this.coolLabel5.TabIndex = 10;
            this.coolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel5.TextToSet = "تاریخ خرید:";
            this.coolLabel5.Visible = false;
            // 
            // txtStuffCount
            // 
            this.txtStuffCount.Accepted = true;
            this.txtStuffCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffCount.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffCount.CursorLocation = 0;
            this.txtStuffCount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffCount.HaveCurrencySeperator = true;
            this.txtStuffCount.IsEmpty = false;
            this.txtStuffCount.LengthMax = 40;
            this.txtStuffCount.LengthMin = 0;
            this.txtStuffCount.Location = new System.Drawing.Point(19, 42);
            this.txtStuffCount.Mask = "";
            this.txtStuffCount.Message = "خالی";
            this.txtStuffCount.MustFill = true;
            this.txtStuffCount.Name = "txtStuffCount";
            this.txtStuffCount.NumberMax = ((long)(9999999));
            this.txtStuffCount.NumberMin = ((long)(1));
            this.txtStuffCount.ReadOnly = false;
            this.txtStuffCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffCount.Size = new System.Drawing.Size(70, 21);
            this.txtStuffCount.TabIndex = 12;
            this.txtStuffCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStuffCount.TextToSet = "1";
            this.txtStuffCount.Visible = false;
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(95, 41);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(56, 21);
            this.coolLabel2.TabIndex = 13;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "تعداد:";
            this.coolLabel2.Visible = false;
            // 
            // floaterStoreStuffDetails
            // 
            this.floaterStoreStuffDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterStoreStuffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterStoreStuffDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterStoreStuffDetails.Location = new System.Drawing.Point(3, 3);
            this.floaterStoreStuffDetails.Name = "floaterStoreStuffDetails";
            this.floaterStoreStuffDetails.Size = new System.Drawing.Size(499, 292);
            this.floaterStoreStuffDetails.TabIndex = 2;
            this.floaterStoreStuffDetails.TitleColor = System.Drawing.Color.Orange;
            this.floaterStoreStuffDetails.TitleText = "";
            this.floaterStoreStuffDetails.Visible = false;
            // 
            // floaterContainter
            // 
            this.floaterContainter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainter.Location = new System.Drawing.Point(3, 3);
            this.floaterContainter.Name = "floaterContainter";
            this.floaterContainter.Size = new System.Drawing.Size(499, 292);
            this.floaterContainter.TabIndex = 3;
            this.floaterContainter.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainter.TitleText = "";
            this.floaterContainter.Visible = false;
            this.floaterContainter.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterContainter_Closed);
            // 
            // frmStoreStuffTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmStoreStuffTypeManager";
            this.Text = "موجودی غرفه";
            this.LoadForm += new System.EventHandler(this.frmStoreStuffTypeManager_LoadForm);
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

        private HengamWidgets.CoolLabel coolLabel8;
        private HengamWidgets.CoolTextBox txtStuffID;
        private HengamWidgets.CoolLabel coolLabel4;
        private HengamWidgets.CoolComboBox cboStuffTypeID;
        private HengamWidgets.CoolTextBox txtStuffName;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolNumberBox txtStuffCount;
        private HengamWidgets.CoolDateBox txtBuyDate;
        private HengamWidgets.CoolLabel coolLabel5;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.PanelFloater floaterStoreStuffDetails;
        private HengamWidgets.PanelFloater floaterContainter;
    }
}
