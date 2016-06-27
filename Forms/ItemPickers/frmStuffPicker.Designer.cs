namespace Hengam.Forms.ItemPickers
{
    partial class frmStuffPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStoreStuffs = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.chkJustActives = new HengamWidgets.CoolCheckBox();
            this.coolLabel16 = new HengamWidgets.CoolLabel();
            this.cboFilterStuffTypeID = new HengamWidgets.CoolComboBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkJustActives);
            this.pnlMain.Controls.Add(this.coolLabel16);
            this.pnlMain.Controls.Add(this.cboFilterStuffTypeID);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.dgvStoreStuffs);
            this.pnlMain.Size = new System.Drawing.Size(395, 286);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.dgvStoreStuffs, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.cboFilterStuffTypeID, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel16, 0);
            this.pnlMain.Controls.SetChildIndex(this.chkJustActives, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(56, 119);
            // 
            // dgvStoreStuffs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreStuffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreStuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoreStuffs.Location = new System.Drawing.Point(3, 73);
            this.dgvStoreStuffs.MultiSelect = false;
            this.dgvStoreStuffs.Name = "dgvStoreStuffs";
            this.dgvStoreStuffs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStoreStuffs.Searchable = true;
            this.dgvStoreStuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreStuffs.Size = new System.Drawing.Size(389, 210);
            this.dgvStoreStuffs.TabIndex = 2;
            this.dgvStoreStuffs.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvStoreStuffs_RowDoubleClick);
            this.dgvStoreStuffs.OnLoadDataGrid += new System.EventHandler(this.dgvStoreStuffs_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(215, 1);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(177, 14);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "کالای مورد نظر را انتخاب کنید:";
            // 
            // chkJustActives
            // 
            this.chkJustActives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJustActives.Checked = true;
            this.chkJustActives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJustActives.Location = new System.Drawing.Point(180, 48);
            this.chkJustActives.Name = "chkJustActives";
            this.chkJustActives.Size = new System.Drawing.Size(212, 24);
            this.chkJustActives.TabIndex = 43;
            this.chkJustActives.TextToSet = "فقط تراکنش‌های فعال نشان داده شود";
            this.chkJustActives.ThreeState = false;
            this.chkJustActives.CheckedChanged += new System.EventHandler(this.chkJustActives_CheckedChanged);
            // 
            // coolLabel16
            // 
            this.coolLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel16.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel16.Location = new System.Drawing.Point(347, 21);
            this.coolLabel16.Name = "coolLabel16";
            this.coolLabel16.Size = new System.Drawing.Size(45, 21);
            this.coolLabel16.TabIndex = 41;
            this.coolLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel16.TextToSet = "نوع کالا:";
            // 
            // cboFilterStuffTypeID
            // 
            this.cboFilterStuffTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStuffTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterStuffTypeID.DisplayMember = "";
            this.cboFilterStuffTypeID.Location = new System.Drawing.Point(3, 21);
            this.cboFilterStuffTypeID.Name = "cboFilterStuffTypeID";
            this.cboFilterStuffTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboFilterStuffTypeID.SelectedItem = null;
            this.cboFilterStuffTypeID.Size = new System.Drawing.Size(338, 21);
            this.cboFilterStuffTypeID.TabIndex = 42;
            this.cboFilterStuffTypeID.SelectedValueChanged += new System.EventHandler(this.cboFilterStuffTypeID_SelectedValueChanged);
            // 
            // frmStuffPicker
            // 
            this.ClientSize = new System.Drawing.Size(419, 310);
            this.Name = "frmStuffPicker";
            this.Text = "انتخاب کالا";
            this.LoadForm += new System.EventHandler(this.frmStoreStuffPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvStoreStuffs;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolCheckBox chkJustActives;
        private HengamWidgets.CoolLabel coolLabel16;
        private HengamWidgets.CoolComboBox cboFilterStuffTypeID;
    }
}
