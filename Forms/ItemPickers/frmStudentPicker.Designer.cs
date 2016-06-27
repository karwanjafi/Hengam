namespace Hengam.Forms.ItemPickers
{
    partial class frmStudentPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.activitySelector = new Hengam.Controls.ActivitySelector();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.activitySelector);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.dgvStudents);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.dgvStudents, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.activitySelector, 0);
            // 
            // dgvStudents
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.Location = new System.Drawing.Point(3, 29);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStudents.Searchable = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(387, 256);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvStudents_RowDoubleClick);
            this.dgvStudents.OnLoadDataGrid += new System.EventHandler(this.dgvStudents_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(213, 7);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(177, 14);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "هنرجوی مورد نظر را انتخاب کنید:";
            // 
            // activitySelector
            // 
            this.activitySelector.ActivityStatus = true;
            this.activitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activitySelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activitySelector.ForeColor = System.Drawing.Color.Orange;
            this.activitySelector.Location = new System.Drawing.Point(55, 3);
            this.activitySelector.Name = "activitySelector";
            this.activitySelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activitySelector.Size = new System.Drawing.Size(174, 23);
            this.activitySelector.TabIndex = 6;
            this.activitySelector.StatusChanged += new System.EventHandler(this.activitySelector_StatusChanged);
            // 
            // frmStudentPicker
            // 
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Name = "frmStudentPicker";
            this.Text = "انتخاب هنرجو";
            this.LoadForm += new System.EventHandler(this.frmStudentPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvStudents;
        private HengamWidgets.CoolLabel coolLabel1;
        private Hengam.Controls.ActivitySelector activitySelector;
    }
}
