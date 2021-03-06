namespace StandardWidgets
{
    partial class CoolDataGrid
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolDataGrid));
            this.dgvDataGrid = new System.Windows.Forms.DataGridView();
            this.cboFastSearch = new System.Windows.Forms.ComboBox();
            this.lblFastSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectSearch = new System.Windows.Forms.Button();
            this.chklstSearchOptions = new System.Windows.Forms.CheckedListBox();
            this.toolTipRow = new System.Windows.Forms.ToolTip(this.components);
            this.coolMessage = new StandardWidgets.CoolMessage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataGrid
            // 
            this.dgvDataGrid.AllowUserToAddRows = false;
            this.dgvDataGrid.AllowUserToDeleteRows = false;
            this.dgvDataGrid.AllowUserToOrderColumns = true;
            this.dgvDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvDataGrid.MultiSelect = false;
            this.dgvDataGrid.Name = "dgvDataGrid";
            this.dgvDataGrid.ReadOnly = true;
            this.dgvDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataGrid.RowHeadersWidth = 51;
            this.dgvDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataGrid.Size = new System.Drawing.Size(391, 211);
            this.dgvDataGrid.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvDataGrid, "می‌توانید با جابجا کردن ستون‌ها آرایش آنها را تغییر دهید. با یک بار کلیک کردن بر " +
                    "تیتر یک ستون می‌توانید اطلاعات را بر حسب آن ستون مرتب کنید");
            this.dgvDataGrid.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataGrid_ColumnHeaderMouseDoubleClick);
            this.dgvDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataGrid_RowHeaderMouseClick);
            this.dgvDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDataGrid_RowsAdded);
            this.dgvDataGrid.SelectionChanged += new System.EventHandler(this.dgvDataGrid_SelectionChanged);
            this.dgvDataGrid.Sorted += new System.EventHandler(this.dgvDataGrid_Sorted);
            this.dgvDataGrid.DoubleClick += new System.EventHandler(this.dgvDataGrid_DoubleClick);
            // 
            // cboFastSearch
            // 
            this.cboFastSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFastSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboFastSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboFastSearch.FormattingEnabled = true;
            this.cboFastSearch.Location = new System.Drawing.Point(27, 215);
            this.cboFastSearch.Name = "cboFastSearch";
            this.cboFastSearch.Size = new System.Drawing.Size(362, 21);
            this.cboFastSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboFastSearch, "عبارت مورد نظر را برای جستجو تایپ کنید");
            this.cboFastSearch.TextChanged += new System.EventHandler(this.cboFastSearch_TextChanged);
            this.cboFastSearch.Enter += new System.EventHandler(this.cboFastSearch_Enter);
            this.cboFastSearch.Layout += new System.Windows.Forms.LayoutEventHandler(this.cboFastSearch_Layout);
            this.cboFastSearch.MouseLeave += new System.EventHandler(this.cboFastSearch_MouseLeave);
            this.cboFastSearch.MouseHover += new System.EventHandler(this.cboFastSearch_MouseHover);
            // 
            // lblFastSearch
            // 
            this.lblFastSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFastSearch.BackColor = System.Drawing.Color.White;
            this.lblFastSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblFastSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblFastSearch.Location = new System.Drawing.Point(125, 219);
            this.lblFastSearch.Name = "lblFastSearch";
            this.lblFastSearch.Size = new System.Drawing.Size(167, 13);
            this.lblFastSearch.TabIndex = 3;
            this.lblFastSearch.Text = "جستجو بر اساس ستون‌های انتخاب شده";
            this.lblFastSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFastSearch.Click += new System.EventHandler(this.lblFastSearch_Click);
            this.lblFastSearch.MouseHover += new System.EventHandler(this.lblFastSearch_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(0, 215);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 21);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "-";
            this.toolTip1.SetToolTip(this.btnRefresh, "برای بازیابی مجدد جدول از این دکمه استفاده نمایید");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 410;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 82;
            this.toolTip1.UseFading = false;
            // 
            // btnSelectSearch
            // 
            this.btnSelectSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectSearch.Enabled = false;
            this.btnSelectSearch.Location = new System.Drawing.Point(30, 217);
            this.btnSelectSearch.Name = "btnSelectSearch";
            this.btnSelectSearch.Size = new System.Drawing.Size(41, 17);
            this.btnSelectSearch.TabIndex = 6;
            this.btnSelectSearch.Text = "^";
            this.toolTip1.SetToolTip(this.btnSelectSearch, "ستون‌های مورد استفاده برای جستجو را انتخاب کنید");
            this.btnSelectSearch.UseVisualStyleBackColor = true;
            this.btnSelectSearch.Click += new System.EventHandler(this.btnSelectSearch_Click);
            // 
            // chklstSearchOptions
            // 
            this.chklstSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chklstSearchOptions.BackColor = System.Drawing.Color.DimGray;
            this.chklstSearchOptions.CheckOnClick = true;
            this.chklstSearchOptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chklstSearchOptions.ForeColor = System.Drawing.Color.Orange;
            this.chklstSearchOptions.FormattingEnabled = true;
            this.chklstSearchOptions.Location = new System.Drawing.Point(27, 68);
            this.chklstSearchOptions.Name = "chklstSearchOptions";
            this.chklstSearchOptions.Size = new System.Drawing.Size(144, 148);
            this.chklstSearchOptions.TabIndex = 7;
            this.chklstSearchOptions.Visible = false;
            this.chklstSearchOptions.Leave += new System.EventHandler(this.chklstSearchOptions_Leave);
            // 
            // toolTipRow
            // 
            this.toolTipRow.AutomaticDelay = 0;
            this.toolTipRow.AutoPopDelay = 6000;
            this.toolTipRow.InitialDelay = 410;
            this.toolTipRow.IsBalloon = true;
            this.toolTipRow.ReshowDelay = 82;
            this.toolTipRow.UseFading = false;
            // 
            // coolMessage
            // 
            this.coolMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coolMessage.BackColorToSet = System.Drawing.Color.DimGray;
            this.coolMessage.BorderColor = System.Drawing.Color.Orange;
            this.coolMessage.ForeColorToSet = System.Drawing.Color.Orange;
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(85, 73);
            this.coolMessage.Name = "coolMessage";
            this.coolMessage.Size = new System.Drawing.Size(221, 47);
            this.coolMessage.TabIndex = 5;
            this.coolMessage.Visible = false;
            // 
            // CoolDataGrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSelectSearch);
            this.Controls.Add(this.coolMessage);
            this.Controls.Add(this.dgvDataGrid);
            this.Controls.Add(this.lblFastSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboFastSearch);
            this.Controls.Add(this.chklstSearchOptions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CoolDataGrid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(391, 239);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFastSearch;
        private System.Windows.Forms.Label lblFastSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dgvDataGrid;
        private System.Windows.Forms.Button btnSelectSearch;
        private System.Windows.Forms.CheckedListBox chklstSearchOptions;
        private System.Windows.Forms.ToolTip toolTipRow;
        public CoolMessage coolMessage;


    }
}
