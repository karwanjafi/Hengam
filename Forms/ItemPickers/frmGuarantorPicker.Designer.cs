namespace Hengam.Forms.ItemPickers
{
    partial class frmGuarantorPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGuarantors = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.floaterContainer = new HengamWidgets.PanelFloater();
            this.btnAddNew = new HengamWidgets.CoolButton();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAddNew);
            this.pnlMain.Controls.Add(this.dgvGuarantors);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.floaterContainer);
            this.pnlMain.Controls.SetChildIndex(this.floaterContainer, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.dgvGuarantors, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnAddNew, 0);
            // 
            // dgvGuarantors
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuarantors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuarantors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuarantors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvGuarantors.Location = new System.Drawing.Point(3, 28);
            this.dgvGuarantors.MultiSelect = false;
            this.dgvGuarantors.Name = "dgvGuarantors";
            this.dgvGuarantors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvGuarantors.Searchable = true;
            this.dgvGuarantors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuarantors.Size = new System.Drawing.Size(387, 259);
            this.dgvGuarantors.TabIndex = 2;
            this.dgvGuarantors.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvGuarantors_RowDoubleClick);
            this.dgvGuarantors.OnLoadDataGrid += new System.EventHandler(this.dgvGuarantors_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(225, 8);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(165, 14);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "ضامن مورد نظر را انتخاب کنید.:";
            // 
            // floaterContainer
            // 
            this.floaterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floaterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.floaterContainer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterContainer.Location = new System.Drawing.Point(3, 3);
            this.floaterContainer.Name = "floaterContainer";
            this.floaterContainer.Size = new System.Drawing.Size(387, 284);
            this.floaterContainer.TabIndex = 4;
            this.floaterContainer.TitleColor = System.Drawing.Color.Orange;
            this.floaterContainer.TitleText = "";
            this.floaterContainer.Visible = false;
            this.floaterContainer.Closed += new StandardWidgets.PanelFloater.ClosedDelegate(this.floaterContainer_Closed);
            // 
            // btnAddNew
            // 
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(94, 22);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.TextToSet = "ضامن جدید";
            this.btnAddNew.Clicked += new System.EventHandler(this.btnAddNew_Clicked);
            // 
            // frmGuarantorPicker
            // 
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Name = "frmGuarantorPicker";
            this.Text = "انتخاب ضامن";
            this.LoadForm += new System.EventHandler(this.frmGuarantorPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvGuarantors;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolButton btnAddNew;
        private HengamWidgets.PanelFloater floaterContainer;
    }
}
