using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolDataGrid : UserControl
    {
        public CoolDataGrid()
        {
            InitializeComponent();
        }

        public static implicit operator DataGridView(CoolDataGrid dvdDataGrid)
        {
            return dvdDataGrid.dgvDataGrid;
        }

        /// <summary>
        /// Gets the DataGridView used in CoolDataGrid
        /// </summary>
        [Browsable(true)]
        public DataGridView DataGrid
        {
            get { return dgvDataGrid; }
        }

        /// <summary>
        /// Gets the ComboBox used as FastBox.
        /// </summary>
        [Browsable(true)]
        public ComboBox FastBox
        {
            get { return cboFastSearch; }
        }

        private bool mSearchable = true;
        /// <summary>
        /// Specifies whether is CoolDataGrid Searchable.
        /// </summary>
        [Browsable(true)]
        public bool Searchable
        {
            get { return mSearchable; }
            set
            {
                mSearchable = value;
                if (!mSearchable)
                {
                    //dgvDataGrid.Dock = DockStyle.Fill;
                    dgvDataGrid.Height = this.Height;
                }
                else
                {
                    //dgvDataGrid.Dock = DockStyle.Top;
                    //dgvDataGrid.Width = this.Width-6;
                    dgvDataGrid.Height = this.Height - cboFastSearch.Height - 2*(this.Height-cboFastSearch.Height-cboFastSearch.Top);
                }
            }
        }

        #region Declaring Events...

        /// <summary>
        /// Occurs when user want to LoadDataGrid.
        /// You should set this function to DataGridView Loader.
        /// </summary>
        [Description("Occurs when user want to LoadDataGrid.\nYou should set this function to DataGridView Loader.")]
        [Browsable(true)]
        [Category("Action")]
        public event EventHandler OnLoadDataGrid;
        
        /// <summary>
        /// Holds a DataGridViewRow.
        /// </summary>
        public class RowsSelectionEventArgs : EventArgs
        {
            public DataGridViewSelectedRowCollection Rows = null;
        }

        /// <summary>
        /// Holds SelectedRows.
        /// </summary>
        public class RowSelectionEventArgs : EventArgs
        {
            public DataGridViewRow Row = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Stores the selected rows.</param>
        public delegate void RowsSelectionEventHandler(RowsSelectionEventArgs e);
        
        /// <summary>
        /// Occurs when RowHeader OnceClicked!
        /// </summary>
        [Browsable(true)]
        [Category("Action")]
        public event RowSelectionEventHandler RowDoubleClick = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Holds A row that is selected.</param>
        public delegate void RowSelectionEventHandler(RowSelectionEventArgs e);
        
        /// <summary>
        /// Occurs when selection changed.
        /// </summary>
        [Browsable(true)]
        [Category("Action")]
        public event RowsSelectionEventHandler RowsSelected = null;

        #endregion

        /// <summary>
        /// Refreshes the DataGridView using introduced method.
        /// </summary>
        public void RefreshDataGrid()
        {
            if (OnLoadDataGrid != null)
            {
                SetMsg("در حال واکشی اطلاعات...");

                this.SuspendLayout();
                dgvDataGrid.SuspendLayout();
                
                
                OnLoadDataGrid(null, null);
                
                RefreshSearch(true);
                HideMsg();

                this.ResumeLayout();
                dgvDataGrid.ResumeLayout();
                
            }
            else
            {
                btnRefresh.Enabled = false;
            }
        }

        private void RefreshSearch(bool defaultChecked)
        {
            chklstSearchOptions.Items.Clear();
            foreach (DataGridViewColumn col in dgvDataGrid.Columns)
            {
                chklstSearchOptions.Items.Add(new ComboColumn(col.Name, col.HeaderText), defaultChecked);
            }

            var selectAll = new ComboColumn(SelectAllColumn, "انتخاب همه");
            //selectAll.OnClick += new EventHandler(selectAll_OnClick);
            SelectAllIndex = chklstSearchOptions.Items.Add(selectAll);
            chklstSearchOptions.ItemCheck += new ItemCheckEventHandler(chklstSearchOptions_ItemCheck);
                
            btnRefresh.Enabled = true;
            btnSelectSearch.Enabled = true;
            cboFastSearch.Text = "";
        }

        private string SelectAllColumn = "SelectAll";
        private int SelectAllIndex = 0;
        void chklstSearchOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == SelectAllIndex)
            {
                //Todo: check it karwan!!!![
                //if (e.NewValue != CheckState.Indeterminate)
                //    RefreshSearch(e.NewValue == CheckState.Checked );
            }
        }

        void selectAll_OnClick(object sender, EventArgs e)
        {
            foreach(var item in chklstSearchOptions.CheckedItems)
            {
                
            }
        }

        private class ComboColumn
        {
            public ComboColumn(string ColumnName, string ColumnText)
            {
                this.ColumnName = ColumnName;
                this.ColumnText = ColumnText;
            }
            public string ColumnName;
            public string ColumnText;
            public override string ToString()
            {
                return ColumnText;
            }

            public event EventHandler OnClick;
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            coolMessage.Show();
        }

        /// <summary>
        /// Sets a message showing on the datagrid.
        /// </summary>
        /// <param name="message">Message to be shown.</param>
        public void SetMsg(string message)
        {
            coolMessage.Show(message);
            Application.DoEvents();
        }

        /// <summary>
        /// Hides the message.
        /// </summary>
        public void HideMsg()
        {
            coolMessage.Hide();
            Application.DoEvents();
        }

        private void dgvDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDataGrid.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex+1).ToString();
        }

        private void dgvDataGrid_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDataGrid.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void cboFastSearch_MouseHover(object sender, EventArgs e)
        {
            lblFastSearch.Visible = false;
        }

        private void cboFastSearch_MouseLeave(object sender, EventArgs e)
        {
            lblFastSearch.Visible = true;
        }

        private void dgvDataGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (mSearchable)
            //{
            //    lblFastSearch.Text = "جستجو بر اساس " + dgvDataGrid.Columns[e.ColumnIndex].HeaderText;
            //    fastSearchColumn = dgvDataGrid.Columns[e.ColumnIndex].Name;
            //}
        }

        private void lblFastSearch_MouseHover(object sender, EventArgs e)
        {
            lblFastSearch.Visible = false;
        }

        private void cboFastSearch_Layout(object sender, LayoutEventArgs e)
        {
            lblFastSearch.Visible = true;
        }

        private void cboFastSearch_Enter(object sender, EventArgs e)
        {
            lblFastSearch.Visible = false;
        }
        //private string fastSearchColumn = "";
        private void cboFastSearch_TextChanged(object sender, EventArgs e)
        {
            SearchGrid();
        }

        private static string CorrectKY(string inStr)
        {
            string res = inStr;

            string badK = "ك";
            string goodK = "ک";
            res = res.Replace(badK, goodK);

            string badY = "ي";
            string goodY = "ی";
            res = res.Replace(badY, goodY);

            return res;
        }

        private void SearchGrid()
        {
            if (!mSearchable) return;
            lblFastSearch.Visible = false;
            //if (fastSearchColumn == "") return;
            foreach (DataGridViewRow row in dgvDataGrid.Rows)
            {
                string strToSearch = CorrectKY(cboFastSearch.Text);
                bool foundMatch = false;
                string colText = "";
                foreach (object obj in chklstSearchOptions.CheckedItems)
                {
                    string colName = ((ComboColumn)obj).ColumnName;
                    if (colName == SelectAllColumn)
                        continue;
                    colText = ((ComboColumn)obj).ColumnText;
                    if (CorrectKY(row.Cells[colName].Value.ToString()).Contains(strToSearch))
                    {
                        foundMatch = true;
                        break;
                    }
                }
                if (!foundMatch)
                    row.Visible = false;
                else
                {
                    row.Visible = true;
                    //row.Cells[0].ToolTipText = colText;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void dgvDataGrid_DoubleClick(object sender, EventArgs e)
        {
            // This event occurs even just ColumnHeaders double clicked.

            //if (RowDoubleClick != null)
            //{
            //    if (dgvDataGrid.SelectedRows.Count == 0) return;
            //    RowSelectionEventArgs ee = new RowSelectionEventArgs();
            //    ee.Row = dgvDataGrid.SelectedRows[0];
            //    RowDoubleClick(ee);
            //}
        }

        private void dgvDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (RowDoubleClick != null)
            {
                RowSelectionEventArgs ee = new RowSelectionEventArgs();
                ee.Row = dgvDataGrid.Rows[e.RowIndex];
                RowDoubleClick(ee);
            }
        }

        private void lblFastSearch_Click(object sender, EventArgs e)
        {
            lblFastSearch.Visible = false;
            cboFastSearch.Focus();
        }

        private void dgvDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (RowsSelected != null)
            {
                RowsSelectionEventArgs ee = new RowsSelectionEventArgs();
                ee.Rows = dgvDataGrid.SelectedRows;
                RowsSelected(ee);
            }
        }

        [Browsable(true), Category("Misc")]
        public DataGridViewCellStyle AlternatingRowsDefaultCellStyle
        {
            get { return dgvDataGrid.AlternatingRowsDefaultCellStyle; }
            set { dgvDataGrid.AlternatingRowsDefaultCellStyle = value; }
        }

        [Browsable(true), Category("Misc")]
        public DataGridViewSelectionMode SelectionMode
        {
            get { return DataGrid.SelectionMode; }
            set { DataGrid.SelectionMode = value; }
        }

        [Browsable(true), Category("Misc")]
        public bool MultiSelect
        {
            get { return DataGrid.MultiSelect; }
            set { DataGrid.MultiSelect = value; }
        }

        private void btnSelectSearch_Click(object sender, EventArgs e)
        {
            if (chklstSearchOptions.Items.Count == 0) return;
            chklstSearchOptions.Visible = true;
            chklstSearchOptions.BringToFront();
            chklstSearchOptions.Focus();
        }

        private void chklstSearchOptions_Leave(object sender, EventArgs e)
        {
            chklstSearchOptions.Visible = false;
            SearchGrid();
        }
    }
}