using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using HengamWidgets;

namespace Hengam.Forms.ItemPickers
{
    public partial class frmEmployeePicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmEmployeePicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public EmployeeBO SelectedEmployee = null;
        private CoolTextBox hookedTextBoxEmployeeID = null;
        private CoolTextBox hookedTextBoxEmployeeName = null;

        public void HookTo(CoolTextBox txtGuarantorID, CoolTextBox txtGuarantorName)
        {
            hookedTextBoxEmployeeID = txtGuarantorID;
            hookedTextBoxEmployeeName = txtGuarantorName;
        }

        private void dgvEmployees_OnLoadDataGrid(object sender, EventArgs e)
        {
            //hanieh
            if (DataAccessNamespace.EmployeeDA.allEmployee.Count == 0)
                DataAccessNamespace.EmployeeDA.allEmployee = EmployeeBO.List();
            //

            DataGridFiller<EmployeeBO>.FillDataGrid(dgvEmployees, DataAccessNamespace.EmployeeDA.allEmployee, new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.Employee.EmployeeID,
                DatabaseSchema.Employee.FirstName,
                DatabaseSchema.Employee.LastName
            });
        }

        private void dgvEmployees_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedEmployee = (EmployeeBO)e.Row.Tag;
            if ( hookedTextBoxEmployeeID != null)
                hookedTextBoxEmployeeID.Text = SelectedEmployee.EmployeeID;
            if ( hookedTextBoxEmployeeName != null)
                hookedTextBoxEmployeeName.Text = SelectedEmployee.FullName;

            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void frmEmployeePicker_LoadForm(object sender, EventArgs e)
        {
            dgvEmployees.RefreshDataGrid();
        }
    }
}
