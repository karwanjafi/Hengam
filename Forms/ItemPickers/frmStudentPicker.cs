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

namespace Hengam.Forms.ItemPickers
{
    public partial class frmStudentPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmStudentPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public StudentBO SelectedStudent = null;
        private CoolTextBox hookedTextBoxStudentID = null;
        private CoolTextBox hookedTextBoxStudentName = null;

        public void HookTo(CoolTextBox txtStudentID, CoolTextBox txtStudentName)
        {
            hookedTextBoxStudentID = txtStudentID;
            hookedTextBoxStudentName = txtStudentName;
        }

        private void frmStudentPicker_LoadForm(object sender, EventArgs e)
        {
            //dgvStudents.OnLoadDataGrid += new EventHandler(LoadDataGrid);
            dgvStudents.RefreshDataGrid();

        }

        

        void LoadDataGrid()
        {
            //hanieh
            List<StudentBO> list = null;
            if (activitySelector.ActivityStatus == null)
            {
                if (DataAccessNamespace.StudentDA.allStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allStudents = StudentBO.List();
                list = DataAccessNamespace.StudentDA.allStudents;
            }
            else if (activitySelector.ActivityStatus == true)
            {
                if (DataAccessNamespace.StudentDA.allActiveStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allActiveStudents = StudentBO.List(null, null, true);
                list = DataAccessNamespace.StudentDA.allActiveStudents;
            }
            else if (activitySelector.ActivityStatus == false)
            {
                if (DataAccessNamespace.StudentDA.allinActiveStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allinActiveStudents = StudentBO.List(null, null, false);
                list = DataAccessNamespace.StudentDA.allinActiveStudents;
            }
            //list= StudentBO.List(null, null, activitySelector.ActivityStatus);
             /////  
            DataGridFiller<StudentBO>.FillDataGrid(dgvStudents, list,

                new List<ColumnDefinition>
                {
                    DatabaseSchema.Student.StudentID,
                    DatabaseSchema.Student.FirstName,
                    DatabaseSchema.Student.LastName
                });
        
        }

        private void dgvStudents_OnLoadDataGrid(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void dgvStudents_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedStudent = (StudentBO)e.Row.Tag;
            if ( hookedTextBoxStudentID != null )
                hookedTextBoxStudentID.Text = SelectedStudent.StudentID;
            if ( hookedTextBoxStudentName != null )
                hookedTextBoxStudentName.Text = SelectedStudent.FullName;
            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void chkJustActives_CheckedChanged(object sender, EventArgs e)
        {
            dgvStudents.RefreshDataGrid();
        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
    }
}
