namespace Hengam.Forms.ItemPickers
{
    partial class frmSessionPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClasses = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.dgvSessions = new HengamWidgets.CoolDataGrid();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Size = new System.Drawing.Size(400, 288);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.splitContainer1, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(59, 120);
            // 
            // dgvClasses
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasses.Location = new System.Drawing.Point(3, 25);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClasses.Searchable = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(388, 111);
            this.dgvClasses.TabIndex = 2;
            this.dgvClasses.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvClasss_RowDoubleClick);
            this.dgvClasses.OnLoadDataGrid += new System.EventHandler(this.dgvClasss_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(232, 3);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(155, 22);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "کلاس مورد نظر را انتخاب کنید:";
            // 
            // dgvSessions
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSessions.Location = new System.Drawing.Point(0, 27);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSessions.Searchable = true;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(391, 109);
            this.dgvSessions.TabIndex = 2;
            this.dgvSessions.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvSessions_RowDoubleClick);
            this.dgvSessions.OnLoadDataGrid += new System.EventHandler(this.dgvSessions_OnLoadDataGrid);
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(236, -1);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(155, 22);
            this.coolLabel2.TabIndex = 3;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel2.TextToSet = "لیست جلسات:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.coolLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvClasses);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.coolLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSessions);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(394, 282);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmSessionPicker
            // 
            this.ClientSize = new System.Drawing.Size(424, 312);
            this.Name = "frmSessionPicker";
            this.Text = "انتخاب کلاس";
            this.LoadForm += new System.EventHandler(this.frmClassPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvClasses;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolDataGrid dgvSessions;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
