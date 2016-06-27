namespace Hengam.Forms.ItemPickers
{
    partial class frmTeacherPicker
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
            this.dgvTeachers = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel18 = new HengamWidgets.CoolLabel();
            this.cboFilterMajor = new HengamWidgets.CoolComboBox();
            this.activitySelector = new Hengam.Controls.ActivitySelector();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.coolLabel18);
            this.pnlMain.Controls.Add(this.cboFilterMajor);
            this.pnlMain.Controls.Add(this.activitySelector);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.dgvTeachers);
            this.pnlMain.Size = new System.Drawing.Size(429, 275);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.dgvTeachers, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.activitySelector, 0);
            this.pnlMain.Controls.SetChildIndex(this.cboFilterMajor, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel18, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(73, 113);
            // 
            // dgvTeachers
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.Location = new System.Drawing.Point(3, 49);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTeachers.Searchable = true;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(423, 223);
            this.dgvTeachers.TabIndex = 2;
            this.dgvTeachers.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvTeachers_RowDoubleClick);
            this.dgvTeachers.OnLoadDataGrid += new System.EventHandler(this.dgvTeachers_OnLoadDataGrid);
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(271, 0);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(155, 22);
            this.coolLabel1.TabIndex = 3;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolLabel1.TextToSet = "استاد مورد نظر را انتخاب کنید:";
            // 
            // coolLabel18
            // 
            this.coolLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel18.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel18.Location = new System.Drawing.Point(386, 22);
            this.coolLabel18.Name = "coolLabel18";
            this.coolLabel18.Size = new System.Drawing.Size(40, 21);
            this.coolLabel18.TabIndex = 4;
            this.coolLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel18.TextToSet = "رشته:";
            // 
            // cboFilterMajor
            // 
            this.cboFilterMajor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterMajor.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterMajor.DisplayMember = "";
            this.cboFilterMajor.Location = new System.Drawing.Point(195, 24);
            this.cboFilterMajor.Name = "cboFilterMajor";
            this.cboFilterMajor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboFilterMajor.SelectedItem = null;
            this.cboFilterMajor.Size = new System.Drawing.Size(185, 21);
            this.cboFilterMajor.TabIndex = 6;
            this.cboFilterMajor.SelectedValueChanged += new System.EventHandler(this.cboFilterMajor_SelectedValueChanged);
            // 
            // activitySelector
            // 
            this.activitySelector.ActivityStatus = true;
            this.activitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activitySelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activitySelector.ForeColor = System.Drawing.Color.Orange;
            this.activitySelector.Location = new System.Drawing.Point(15, 23);
            this.activitySelector.Name = "activitySelector";
            this.activitySelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activitySelector.Size = new System.Drawing.Size(174, 23);
            this.activitySelector.TabIndex = 5;
            this.activitySelector.StatusChanged += new System.EventHandler(this.activitySelector_StatusChanged);
            // 
            // frmTeacherPicker
            // 
            this.ClientSize = new System.Drawing.Size(453, 299);
            this.Name = "frmTeacherPicker";
            this.Text = "انتخاب استاد";
            this.LoadForm += new System.EventHandler(this.frmTeacherPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvTeachers;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel18;
        private HengamWidgets.CoolComboBox cboFilterMajor;
        private Hengam.Controls.ActivitySelector activitySelector;
    }
}
