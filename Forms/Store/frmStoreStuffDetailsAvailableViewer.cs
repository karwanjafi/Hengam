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
    public partial class frmStoreStuffDetailsAvailableViewer : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmStoreStuffDetailsAvailableViewer()
        {
            InitializeComponent();
        }

        private void frmStoreStuffDetailsAvailableViewer_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی");
            ComboFiller<StuffTypeBO>.FillCombo(cboStuffType, StuffTypeBO.List());
            HideMsg();
            dgvStuffs.RefreshDataGrid();
        }

        private void dgvStuffs_OnLoadDataGrid(object sender, EventArgs e)
        {
            int? stuffTypeID = null;

            if (cboStuffType.SelectedItem != null)
                stuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboStuffType).StuffTypeID;

            //if (stuffTypeID == null) return;

            DataGridFiller<ViwStuffAvailableDetailsBO>.FillDataGrid(dgvStuffs, ViwStuffAvailableDetailsBO.List(stuffTypeID, null, null, null, null, null, null, null, null), new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.ViwStuffAvailableDetails.StuffName,
                DatabaseSchema.ViwStuffAvailableDetails.BuyDate,
                DatabaseSchema.ViwStuffAvailableDetails.InitCount,
                DatabaseSchema.ViwStuffAvailableDetails.SoldCount,
                DatabaseSchema.ViwStuffAvailableDetails.AvailableCount
            });

            //foreach (DataGridViewRow row in dgvStuffs.dgvDataGrid.Rows)
            //{
            //    if (((ViwStuffAvailableDetailsBO)row.Tag).AvailableCount <= 0)
            //        row.DefaultCellStyle.BackColor = Color.Pink;
            //}
        }

        private void cboStuffType_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvStuffs.RefreshDataGrid();
        }

        public void Set(StuffTypeBO stuffType)
        {
            ComboFiller<StuffTypeBO>.SetCombo(cboStuffType, stuffType);
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater { get; set; }

        #endregion

    }
}
