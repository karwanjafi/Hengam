namespace Hengam.Forms.ItemPickers
{
    partial class frmEmployeePicker
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
            this.dgvEmployees = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.dgvEmployees);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.dgvEmployees, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.Location = new System.Drawing.Point(3, 26);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvEmployees.Searchable = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(387, 259);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvEmployees_RowDoubleClick);
            this.dgvEmployees.OnLoadDataGrid += new System.EventHandler(this.dgvEmployees_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(228, 4);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(155, 22);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "کارمند مورد نظر را انتخاب کنید:";
            // 
            // frmEmployeePicker
            // 
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Name = "frmEmployeePicker";
            this.Text = "انتخاب کارمند";
            this.LoadForm += new System.EventHandler(this.frmEmployeePicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvEmployees;
        private HengamWidgets.CoolLabel coolLabel1;
    }
}
