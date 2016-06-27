namespace Hengam.Forms.Store
{
    partial class frmStoreStuffDetailsAvailableViewer
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
            this.dgvStuffs = new HengamWidgets.CoolDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.cboStuffType = new HengamWidgets.CoolComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Size = new System.Drawing.Size(560, 288);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(139, 120);
            // 
            // dgvStuffs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStuffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStuffs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvStuffs.Location = new System.Drawing.Point(-345, 30);
            this.dgvStuffs.MultiSelect = false;
            this.dgvStuffs.Name = "dgvStuffs";
            this.dgvStuffs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStuffs.Searchable = true;
            this.dgvStuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuffs.Size = new System.Drawing.Size(890, 390);
            this.dgvStuffs.TabIndex = 2;
            this.dgvStuffs.OnLoadDataGrid += new System.EventHandler(this.dgvStuffs_OnLoadDataGrid);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست کالاها";
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(499, 3);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(46, 21);
            this.coolLabel1.TabIndex = 4;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "نوع کالا:";
            // 
            // cboStuffType
            // 
            this.cboStuffType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStuffType.BackColor = System.Drawing.Color.Transparent;
            this.cboStuffType.DisplayMember = "";
            this.cboStuffType.Location = new System.Drawing.Point(182, 3);
            this.cboStuffType.Name = "cboStuffType";
            this.cboStuffType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboStuffType.SelectedItem = null;
            this.cboStuffType.Size = new System.Drawing.Size(311, 21);
            this.cboStuffType.TabIndex = 3;
            this.cboStuffType.SelectedValueChanged += new System.EventHandler(this.cboStuffType_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coolLabel1);
            this.panel1.Controls.Add(this.dgvStuffs);
            this.panel1.Controls.Add(this.cboStuffType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 262);
            this.panel1.TabIndex = 5;
            // 
            // frmStoreStuffDetailsAvailableViewer
            // 
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Name = "frmStoreStuffDetailsAvailableViewer";
            this.Text = "مشاهده‌ی ریزخرید";
            this.LoadForm += new System.EventHandler(this.frmStoreStuffDetailsAvailableViewer_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvStuffs;
        private System.Windows.Forms.GroupBox groupBox1;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolComboBox cboStuffType;
        private System.Windows.Forms.Panel panel1;
    }
}
