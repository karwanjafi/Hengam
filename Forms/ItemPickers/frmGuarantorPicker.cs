using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HengamWidgets;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Hengam.Tools;
using FarsiMessageBox;

namespace Hengam.Forms.ItemPickers
{
    public partial class frmGuarantorPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmGuarantorPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public GuarantorBO SelectedGuarantor = null;
        private CoolTextBox hookedTextBoxGuarantorID = null;
        private CoolTextBox hookedTextBoxGuarantorName = null;

        public void HookTo(CoolTextBox txtGuarantorID, CoolTextBox txtGuarantorName)
        {
            hookedTextBoxGuarantorID = txtGuarantorID;
            hookedTextBoxGuarantorName = txtGuarantorName;
        }

        private void frmGuarantorPicker_LoadForm(object sender, EventArgs e)
        {
            //dgvGuarantors.OnLoadDataGrid += new EventHandler(LoadDataGrid);
            dgvGuarantors.RefreshDataGrid();

        }

        void LoadDataGrid()
        {
            //hanieh
            if (DataAccessNamespace.GuarantorDA.allguarantor.Count == 0)
                DataAccessNamespace.GuarantorDA.allguarantor = GuarantorBO.List();
            //

            DataGridFiller<GuarantorBO>.FillDataGrid(dgvGuarantors, DataAccessNamespace.GuarantorDA.allguarantor,

                new List<ColumnDefinition>
                {
                    DatabaseSchema.Guarantor.GuarantorID,
                    DatabaseSchema.Guarantor.FirstName,
                    DatabaseSchema.Guarantor.LastName,
                    DatabaseSchema.Guarantor.Guarantee
                });
        
        }

        private void dgvGuarantors_OnLoadDataGrid(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void dgvGuarantors_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedGuarantor = (GuarantorBO)e.Row.Tag;
            if ( hookedTextBoxGuarantorID != null )
                hookedTextBoxGuarantorID.Text = SelectedGuarantor.GuarantorID;
            if ( hookedTextBoxGuarantorName != null )
                hookedTextBoxGuarantorName.Text = SelectedGuarantor.FullName;
            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void btnAddNew_Clicked(object sender, EventArgs e)
        {
            Form f = FormRequester.GuarantorManager();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                return;
            }
            frmGuarantorManager fGurantor = (frmGuarantorManager)f;
            floaterContainer.LoadPanel(fGurantor);
            floaterContainer.Show();
        }

        private void floaterContainer_Closed()
        {
            dgvGuarantors.RefreshDataGrid();
        }
    }
}
