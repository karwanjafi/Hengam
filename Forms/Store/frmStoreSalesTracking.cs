using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Hengam.ComboManager;
using DataGridFiller;
using DatabaseSchemaNamespace;
using StandardWidgets;

namespace Hengam.Forms.Store
{
    public partial class frmStoreSalesTracking : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmStoreSalesTracking()
        {
            InitializeComponent();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string filterDateFrom = null;
            string filterDateTo = null;
            int? filterStuffTypeID = null;
            bool? filterJustActives = null;

            if (txtFilterDateFrom.Accepted) filterDateFrom = txtFilterDateFrom.Text;
            if (txtFilterDateTo.Accepted) filterDateTo = txtFilterDateTo.Text;
            if (cboFilterStuffTypeID.Accepted) filterStuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboFilterStuffTypeID).StuffTypeID;
            if (chkJustActives.Checked) filterJustActives = true;

            DataGridFiller<ViwSalesTrackingBO>.FillDataGrid(dataGridSection, ViwSalesTrackingBO.ListInterval(null, null, null, filterDateFrom, filterDateTo, filterStuffTypeID, null, filterJustActives), new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.ViwSalesTracking.IsSaleText,
                DatabaseSchema.ViwSalesTracking.ItemName,
                DatabaseSchema.ViwSalesTracking.ItemDate,
                DatabaseSchema.ViwSalesTracking.ItemCount,

            });


            foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
            {
                ViwSalesTrackingBO saleObj = (ViwSalesTrackingBO)row.Tag;
                if (!saleObj.IsSale)
                    row.DefaultCellStyle.BackColor = Color.Pink;
                else
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;

            }
        }

        private void txtFilterDateFrom_TextChanged(object sender, EventArgs e)
        {
            if (!setting)
                dataGridSection.RefreshDataGrid();
        }

        private void cboFilterStuffTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!setting)
                dataGridSection.RefreshDataGrid();
        }

        private void frmStoreSalesTracking_LoadForm(object sender, EventArgs e)
        {
            ComboFiller<StuffTypeBO>.FillCombo(cboFilterStuffTypeID, StuffTypeBO.List());

            dataGridSection.RefreshDataGrid();
        }

        private void chkJustActives_CheckedChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }
        
        bool setting = false;
        public void Set(string dateFrom, string dateTo, int? stuffTypeID)
        {
            setting = true;
            this.txtFilterDateFrom.Text = dateFrom;
            this.txtFilterDateTo.Text = dateTo;
            if (stuffTypeID.HasValue)
                ComboFiller<StuffTypeBO>.SetCombo(cboFilterStuffTypeID, StuffTypeBO.Find(stuffTypeID.Value));
            else
                cboFilterStuffTypeID.SelectedItem = null;
            setting = false;
            dataGridSection.RefreshDataGrid();
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion
    }
}
