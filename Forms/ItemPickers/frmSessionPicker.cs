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
using Hengam.Controls;
using Hengam.ComboManager;

namespace Hengam.Forms.ItemPickers
{
    public partial class frmSessionPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmSessionPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public ClasssessionBO SelectedSession = null;
        public ClassBO SelectedClass = null;
        private CoolNumberBox hookedTextBoxClassID = null;
        private CoolTextBox hookedTextBoxClassName = null;
        private TimeBox hookedTimeBoxTimeID = null;
        private CoolDateBox hookedDateBoxClassDate = null;

        public void HookTo(CoolNumberBox txtClassID, CoolTextBox txtClassName, TimeBox cboTimeBox, CoolDateBox txtClassDate)
        {
            hookedTextBoxClassID = txtClassID;
            hookedTextBoxClassName = txtClassName;
            hookedTimeBoxTimeID = cboTimeBox;
            hookedDateBoxClassDate = txtClassDate;
        }

        private void dgvClasss_OnLoadDataGrid(object sender, EventArgs e)
        {
            //hanieh
            if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                DataAccessNamespace.ClassDA.allclasses = ClassBO.List();
            //
            DataGridFiller<ClassBO>.FillDataGrid(dgvClasses, DataAccessNamespace.ClassDA.allclasses, new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.Class.ClassID,
                DatabaseSchema.Class.ClassName,
                DatabaseSchema.Class.ClassDescription
            });
        }

        private void dgvClasss_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            
            

            SelectedClass = (ClassBO)e.Row.Tag;
            dgvSessions.RefreshDataGrid();

            

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void frmClassPicker_LoadForm(object sender, EventArgs e)
        {
            dgvClasses.RefreshDataGrid();
        }

        private void dgvSessions_OnLoadDataGrid(object sender, EventArgs e)
        {
            if (SelectedClass == null) return;
            int classID = SelectedClass.ClassID;

            DataGridFiller<ClasssessionBO>.FillDataGrid(dgvSessions, ClasssessionBO.List(classID), new List<ColumnDefinition>
            {
                DatabaseSchema.Day.DayName,
                DatabaseSchema.Classsession.TimeID,
                DatabaseSchema.Classsession.ClassDate
            });
        }

        private void dgvSessions_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedSession = (ClasssessionBO)e.Row.Tag;
            if (hookedTextBoxClassID != null)
                hookedTextBoxClassID.Text = SelectedSession.ClassID.ToString();
            if (hookedTextBoxClassName != null)
                hookedTextBoxClassName.Text = SelectedClass.ClassName;
            if (hookedTimeBoxTimeID != null)
                ComboFiller<TimeBO>.SetCombo(hookedTimeBoxTimeID, SelectedSession.RelTime);
            if (hookedDateBoxClassDate != null)
                hookedDateBoxClassDate.Text = SelectedSession.ClassDate;

            CloseFloater();
        }
    }
}
