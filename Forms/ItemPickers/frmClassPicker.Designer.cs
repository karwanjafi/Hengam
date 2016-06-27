namespace Hengam.Forms.ItemPickers
{
    partial class frmClassPicker
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
            this.dgvClasses = new HengamWidgets.CoolDataGrid();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.btnClear = new HengamWidgets.CoolButton();
            this.txtStudentID = new HengamWidgets.CoolTextBox();
            this.txtTeacherID = new HengamWidgets.CoolTextBox();
            this.activitySelector = new Hengam.Controls.ActivitySelector();
            this.chkPublics = new HengamWidgets.CoolCheckBox();
            this.chkPrivate = new HengamWidgets.CoolCheckBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.activitySelector);
            this.pnlMain.Controls.Add(this.txtTeacherID);
            this.pnlMain.Controls.Add(this.txtStudentID);
            this.pnlMain.Controls.Add(this.chkPrivate);
            this.pnlMain.Controls.Add(this.chkPublics);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.coolLabel1);
            this.pnlMain.Controls.Add(this.dgvClasses);
            this.pnlMain.Controls.SetChildIndex(this.dgvClasses, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolLabel1, 0);
            this.pnlMain.Controls.SetChildIndex(this.btnClear, 0);
            this.pnlMain.Controls.SetChildIndex(this.chkPublics, 0);
            this.pnlMain.Controls.SetChildIndex(this.chkPrivate, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtStudentID, 0);
            this.pnlMain.Controls.SetChildIndex(this.txtTeacherID, 0);
            this.pnlMain.Controls.SetChildIndex(this.activitySelector, 0);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            // 
            // dgvClasses
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvClasses.Location = new System.Drawing.Point(3, 59);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClasses.Searchable = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(387, 226);
            this.dgvClasses.TabIndex = 2;
            this.dgvClasses.RowDoubleClick += new StandardWidgets.CoolDataGrid.RowSelectionEventHandler(this.dgvClasss_RowDoubleClick);
            this.dgvClasses.OnLoadDataGrid += new System.EventHandler(this.dgvClasss_OnLoadDataGrid);
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
            this.coolLabel1.TextToSet = "کلاس مورد نظر را انتخاب کنید:";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 22);
            this.btnClear.TabIndex = 4;
            this.btnClear.TextToSet = "پاک کردن انتخاب";
            this.btnClear.Clicked += new System.EventHandler(this.btnClear_Clicked);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Accepted = false;
            this.txtStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentID.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentID.CursorLocation = 0;
            this.txtStudentID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStudentID.IsEmpty = false;
            this.txtStudentID.LengthMax = 1000000;
            this.txtStudentID.LengthMin = 0;
            this.txtStudentID.Location = new System.Drawing.Point(125, 5);
            this.txtStudentID.Mask = "";
            this.txtStudentID.Message = "خالی";
            this.txtStudentID.MustFill = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentID.Size = new System.Drawing.Size(64, 21);
            this.txtStudentID.TabIndex = 19;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentID.TextToSet = "";
            this.txtStudentID.Visible = false;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Accepted = false;
            this.txtTeacherID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherID.BackColor = System.Drawing.Color.Transparent;
            this.txtTeacherID.CursorLocation = 0;
            this.txtTeacherID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTeacherID.IsEmpty = false;
            this.txtTeacherID.LengthMax = 1000000;
            this.txtTeacherID.LengthMin = 0;
            this.txtTeacherID.Location = new System.Drawing.Point(195, 3);
            this.txtTeacherID.Mask = "";
            this.txtTeacherID.Message = "خالی";
            this.txtTeacherID.MustFill = true;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = false;
            this.txtTeacherID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTeacherID.Size = new System.Drawing.Size(64, 21);
            this.txtTeacherID.TabIndex = 19;
            this.txtTeacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherID.TextToSet = "";
            this.txtTeacherID.Visible = false;
            this.txtTeacherID.TextChanged += new System.EventHandler(this.txtTeacherID_TextChanged);
            // 
            // activitySelector
            // 
            this.activitySelector.ActivityStatus = true;
            this.activitySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activitySelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activitySelector.ForeColor = System.Drawing.Color.Orange;
            this.activitySelector.Location = new System.Drawing.Point(216, 32);
            this.activitySelector.Name = "activitySelector";
            this.activitySelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activitySelector.Size = new System.Drawing.Size(174, 23);
            this.activitySelector.TabIndex = 20;
            this.activitySelector.StatusChanged += new System.EventHandler(this.activitySelector_StatusChanged);
            // 
            // chkPublics
            // 
            this.chkPublics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPublics.Checked = true;
            this.chkPublics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPublics.Location = new System.Drawing.Point(14, 32);
            this.chkPublics.Name = "chkPublics";
            this.chkPublics.Size = new System.Drawing.Size(116, 21);
            this.chkPublics.TabIndex = 5;
            this.chkPublics.TextToSet = "کلاس‌های عمومی";
            this.chkPublics.ThreeState = false;
            this.chkPublics.Visible = false;
            // 
            // chkPrivate
            // 
            this.chkPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrivate.Checked = true;
            this.chkPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrivate.Location = new System.Drawing.Point(61, 32);
            this.chkPrivate.Name = "chkPrivate";
            this.chkPrivate.Size = new System.Drawing.Size(125, 21);
            this.chkPrivate.TabIndex = 6;
            this.chkPrivate.TextToSet = "کلاس‌های خصوصی";
            this.chkPrivate.ThreeState = false;
            this.chkPrivate.Visible = false;
            // 
            // frmClassPicker
            // 
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Name = "frmClassPicker";
            this.Text = "انتخاب کلاس";
            this.LoadForm += new System.EventHandler(this.frmClassPicker_LoadForm);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolDataGrid dgvClasses;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolButton btnClear;
        private HengamWidgets.CoolTextBox txtStudentID;
        private HengamWidgets.CoolTextBox txtTeacherID;
        private Hengam.Controls.ActivitySelector activitySelector;
        private HengamWidgets.CoolCheckBox chkPrivate;
        private HengamWidgets.CoolCheckBox chkPublics;
    }
}
