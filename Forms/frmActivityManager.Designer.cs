namespace Hengam.Forms
{
    partial class frmActivityManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityManager));
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.groupItemSelection = new System.Windows.Forms.GroupBox();
            this.pnlSelectedItemDetails = new System.Windows.Forms.Panel();
            this.lblDeactiveRule = new HengamWidgets.CoolLabel();
            this.lblCountLable = new HengamWidgets.CoolLabel();
            this.cboActivityItems = new HengamWidgets.CoolComboBox();
            this.radioJustCandidates = new System.Windows.Forms.RadioButton();
            this.radioJustDeactives = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.lblItemAdditional = new HengamWidgets.CoolLabel();
            this.lblItemStatus = new HengamWidgets.CoolLabel();
            this.radioJustActives = new System.Windows.Forms.RadioButton();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupItemSelection.SuspendLayout();
            this.pnlSelectedItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.lblItemAdditional);
            this.groupItemDetails.Controls.Add(this.lblItemStatus);
            this.groupItemDetails.Controls.Add(this.coolLabel2);
            this.groupItemDetails.Location = new System.Drawing.Point(3, 143);
            this.groupItemDetails.Size = new System.Drawing.Size(510, 101);
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel2, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.lblItemStatus, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.lblItemAdditional, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 10);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupItemSelection);
            this.pnlMain.Size = new System.Drawing.Size(516, 422);
            this.pnlMain.Controls.SetChildIndex(this.groupItemDetails, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupDatagrid, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnSampleButton, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupItemSelection, 0);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Controls.Add(this.radioJustCandidates);
            this.groupDatagrid.Controls.Add(this.radioJustDeactives);
            this.groupDatagrid.Controls.Add(this.radioJustActives);
            this.groupDatagrid.Controls.Add(this.radioAll);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 250);
            this.groupDatagrid.Size = new System.Drawing.Size(510, 169);
            this.groupDatagrid.Controls.SetChildIndex(this.radioAll, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.radioJustActives, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.radioJustDeactives, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.radioJustCandidates, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.dataGridSection, 0);
            this.groupDatagrid.Controls.SetChildIndex(this.pnlSuggestions, 0);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Cancel");
            this.imgButtons.Images.SetKeyName(1, "Deactivate");
            this.imgButtons.Images.SetKeyName(2, "Activate");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Location = new System.Drawing.Point(6, 45);
            this.dataGridSection.Size = new System.Drawing.Size(498, 118);
            this.dataGridSection.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dataGridSection_RowDoubleClick);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            this.dataGridSection.RowsSelected += new StandardWidgets.CoolDataGrid.RowsSelectionEventHandler(this.dataGridSection_RowsSelected);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(129, 47);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(341, 20);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(163, 22);
            this.coolLabel1.TabIndex = 1;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "گزینه‌ی مورد نظر را انتخاب کنید:";
            // 
            // groupItemSelection
            // 
            this.groupItemSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupItemSelection.Controls.Add(this.pnlSelectedItemDetails);
            this.groupItemSelection.Controls.Add(this.cboActivityItems);
            this.groupItemSelection.Controls.Add(this.coolLabel1);
            this.groupItemSelection.Location = new System.Drawing.Point(3, 3);
            this.groupItemSelection.Name = "groupItemSelection";
            this.groupItemSelection.Size = new System.Drawing.Size(510, 134);
            this.groupItemSelection.TabIndex = 2;
            this.groupItemSelection.TabStop = false;
            this.groupItemSelection.Text = "گزارش کلی";
            // 
            // pnlSelectedItemDetails
            // 
            this.pnlSelectedItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectedItemDetails.Controls.Add(this.lblDeactiveRule);
            this.pnlSelectedItemDetails.Controls.Add(this.lblCountLable);
            this.pnlSelectedItemDetails.Location = new System.Drawing.Point(57, 47);
            this.pnlSelectedItemDetails.Name = "pnlSelectedItemDetails";
            this.pnlSelectedItemDetails.Size = new System.Drawing.Size(447, 81);
            this.pnlSelectedItemDetails.TabIndex = 3;
            // 
            // lblDeactiveRule
            // 
            this.lblDeactiveRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeactiveRule.BackColor = System.Drawing.Color.Transparent;
            this.lblDeactiveRule.Location = new System.Drawing.Point(14, 28);
            this.lblDeactiveRule.Name = "lblDeactiveRule";
            this.lblDeactiveRule.Size = new System.Drawing.Size(430, 50);
            this.lblDeactiveRule.TabIndex = 0;
            this.lblDeactiveRule.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDeactiveRule.TextToSet = "-";
            // 
            // lblCountLable
            // 
            this.lblCountLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountLable.BackColor = System.Drawing.Color.Transparent;
            this.lblCountLable.Location = new System.Drawing.Point(74, 3);
            this.lblCountLable.Name = "lblCountLable";
            this.lblCountLable.Size = new System.Drawing.Size(370, 22);
            this.lblCountLable.TabIndex = 1;
            this.lblCountLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountLable.TextToSet = "-";
            // 
            // cboActivityItems
            // 
            this.cboActivityItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivityItems.BackColor = System.Drawing.Color.Transparent;
            this.cboActivityItems.DisplayMember = "";
            this.cboActivityItems.Location = new System.Drawing.Point(131, 20);
            this.cboActivityItems.Name = "cboActivityItems";
            this.cboActivityItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboActivityItems.SelectedItem = null;
            this.cboActivityItems.Size = new System.Drawing.Size(204, 21);
            this.cboActivityItems.TabIndex = 2;
            this.cboActivityItems.SelectedValueChanged += new System.EventHandler(this.cboActivityItems_SelectedValueChanged);
            // 
            // radioJustCandidates
            // 
            this.radioJustCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioJustCandidates.AutoSize = true;
            this.radioJustCandidates.Checked = true;
            this.radioJustCandidates.ForeColor = System.Drawing.Color.Orange;
            this.radioJustCandidates.Location = new System.Drawing.Point(410, 20);
            this.radioJustCandidates.Name = "radioJustCandidates";
            this.radioJustCandidates.Size = new System.Drawing.Size(94, 17);
            this.radioJustCandidates.TabIndex = 2;
            this.radioJustCandidates.TabStop = true;
            this.radioJustCandidates.Text = "نامزدهای حذف";
            this.radioJustCandidates.UseVisualStyleBackColor = true;
            this.radioJustCandidates.Click += new System.EventHandler(this.radioJustCandidates_Click);
            // 
            // radioJustDeactives
            // 
            this.radioJustDeactives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioJustDeactives.AutoSize = true;
            this.radioJustDeactives.ForeColor = System.Drawing.Color.Orange;
            this.radioJustDeactives.Location = new System.Drawing.Point(306, 20);
            this.radioJustDeactives.Name = "radioJustDeactives";
            this.radioJustDeactives.Size = new System.Drawing.Size(98, 17);
            this.radioJustDeactives.TabIndex = 2;
            this.radioJustDeactives.Text = "فقط غیر فعال‌ها";
            this.radioJustDeactives.UseVisualStyleBackColor = true;
            this.radioJustDeactives.Click += new System.EventHandler(this.radioJustCandidates_Click);
            // 
            // radioAll
            // 
            this.radioAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAll.AutoSize = true;
            this.radioAll.ForeColor = System.Drawing.Color.Orange;
            this.radioAll.Location = new System.Drawing.Point(169, 20);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(46, 17);
            this.radioAll.TabIndex = 2;
            this.radioAll.Text = "همه";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.Click += new System.EventHandler(this.radioJustCandidates_Click);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(448, 18);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(53, 25);
            this.coolLabel2.TabIndex = 1;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "وضعیت:";
            // 
            // lblItemAdditional
            // 
            this.lblItemAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemAdditional.BackColor = System.Drawing.Color.Transparent;
            this.lblItemAdditional.Location = new System.Drawing.Point(22, 51);
            this.lblItemAdditional.Name = "lblItemAdditional";
            this.lblItemAdditional.Size = new System.Drawing.Size(479, 41);
            this.lblItemAdditional.TabIndex = 1;
            this.lblItemAdditional.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblItemAdditional.TextToSet = "-";
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblItemStatus.Location = new System.Drawing.Point(57, 18);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(385, 25);
            this.lblItemStatus.TabIndex = 1;
            this.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemStatus.TextToSet = "-";
            // 
            // radioJustActives
            // 
            this.radioJustActives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioJustActives.AutoSize = true;
            this.radioJustActives.ForeColor = System.Drawing.Color.Orange;
            this.radioJustActives.Location = new System.Drawing.Point(221, 20);
            this.radioJustActives.Name = "radioJustActives";
            this.radioJustActives.Size = new System.Drawing.Size(79, 17);
            this.radioJustActives.TabIndex = 2;
            this.radioJustActives.Text = "فقط فعال‌ها";
            this.radioJustActives.UseVisualStyleBackColor = true;
            this.radioJustActives.Click += new System.EventHandler(this.radioJustCandidates_Click);
            // 
            // frmActivityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Name = "frmActivityManager";
            this.Text = "تنظیم فعالیت قسمت‌ها";
            this.LoadForm += new System.EventHandler(this.frmActivityManager_LoadForm);
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
            this.groupItemSelection.ResumeLayout(false);
            this.pnlSelectedItemDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolLabel coolLabel1;
        private System.Windows.Forms.GroupBox groupItemSelection;
        private HengamWidgets.CoolComboBox cboActivityItems;
        private System.Windows.Forms.Panel pnlSelectedItemDetails;
        private HengamWidgets.CoolLabel lblDeactiveRule;
        private HengamWidgets.CoolLabel lblCountLable;
        private System.Windows.Forms.RadioButton radioJustCandidates;
        private System.Windows.Forms.RadioButton radioJustDeactives;
        private System.Windows.Forms.RadioButton radioAll;
        private HengamWidgets.CoolLabel lblItemAdditional;
        private HengamWidgets.CoolLabel lblItemStatus;
        private HengamWidgets.CoolLabel coolLabel2;
        private System.Windows.Forms.RadioButton radioJustActives;
    }
}
