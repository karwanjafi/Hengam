using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using HengamWidgets;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Hengam.ComboManager;

namespace Hengam.Forms.ItemPickers
{
    public partial class frmStuffPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmStuffPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public StoreStuffBO SelectedStoreStuff = null;
        private CoolTextBox hookedTextBoxStoreStuffID = null;
        private CoolTextBox hookedTextBoxStoreStuffName = null;

        public void HookTo(CoolTextBox txtStoreStuffID, CoolTextBox txtStoreStuffName)
        {
            hookedTextBoxStoreStuffID = txtStoreStuffID;
            hookedTextBoxStoreStuffName = txtStoreStuffName;
        }

        private void frmStoreStuffPicker_LoadForm(object sender, EventArgs e)
        {
            //dgvStoreStuffs.OnLoadDataGrid += new EventHandler(LoadDataGrid);
            ComboFiller<StuffTypeBO>.FillCombo(cboFilterStuffTypeID, StuffTypeBO.List());
            dgvStoreStuffs.RefreshDataGrid();

        }

        void LoadDataGrid()
        {
            int? filterStuffTypeID = null;
            bool? filterJustActives = null;

            if (cboFilterStuffTypeID.Accepted) filterStuffTypeID = ComboFiller<StuffTypeBO>.GetFromCombo(cboFilterStuffTypeID).StuffTypeID;
            if (chkJustActives.Checked) filterJustActives = true;

            DataGridFiller<StoreStuffBO>.FillDataGrid(dgvStoreStuffs, StoreStuffBO.List(filterStuffTypeID, null, null, filterJustActives, null, null, null),

                new List<ColumnDefinition>
                {
                    DatabaseSchema.StoreStuff.StuffID,
                    DatabaseSchema.StoreStuff.StuffName,
                });
        
        }

        private void dgvStoreStuffs_OnLoadDataGrid(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void dgvStoreStuffs_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedStoreStuff = (StoreStuffBO)e.Row.Tag;
            if ( hookedTextBoxStoreStuffID != null )
                hookedTextBoxStoreStuffID.Text = SelectedStoreStuff.StuffID;
            if ( hookedTextBoxStoreStuffName != null )
                hookedTextBoxStoreStuffName.Text = SelectedStoreStuff.StuffName;
            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }
        bool setting = false;
        private void cboFilterStuffTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!setting)
                dgvStoreStuffs.RefreshDataGrid();
        }

        private void chkJustActives_CheckedChanged(object sender, EventArgs e)
        {
            if (!setting)
                dgvStoreStuffs.RefreshDataGrid();
        }
    }
}
