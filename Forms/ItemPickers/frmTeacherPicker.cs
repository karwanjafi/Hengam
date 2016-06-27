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
using Hengam.ComboManager;


namespace Hengam.Forms.ItemPickers
{
    public partial class frmTeacherPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmTeacherPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }
        

        public TeacherBO SelectedTeacher = null;
        private CoolTextBox hookedTextBoxTeacherID = null;
        private CoolTextBox hookedTextBoxTeacherName = null;

        public void HookTo(CoolTextBox txtGuarantorID, CoolTextBox txtGuarantorName)
        {
            hookedTextBoxTeacherID = txtGuarantorID;
            hookedTextBoxTeacherName = txtGuarantorName;
        }

        internal static List<TeacherBO> teacherPicker= new List<TeacherBO>();//hanieh
        private void dgvTeachers_OnLoadDataGrid(object sender, EventArgs e)
        {
            int? majorID = null;
            if (cboFilterMajor.Accepted)
                majorID = ComboFiller<MajorBO>.GetFromCombo(cboFilterMajor).MajorID;
            
            teacherPicker = TeacherBO.List(majorID, activitySelector.ActivityStatus); //hanieh
            

            DataGridFiller<TeacherBO>.FillDataGrid(dgvTeachers, teacherPicker, new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.Teacher.TeacherID,
                DatabaseSchema.Teacher.FirstName,
                DatabaseSchema.Teacher.LastName
            });
        }

        private void dgvTeachers_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedTeacher = (TeacherBO)e.Row.Tag;
            if ( hookedTextBoxTeacherID != null)
                hookedTextBoxTeacherID.Text = SelectedTeacher.TeacherID;
            if ( hookedTextBoxTeacherName != null)
                hookedTextBoxTeacherName.Text = SelectedTeacher.FullName;

            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void frmTeacherPicker_LoadForm(object sender, EventArgs e)
        {
            ComboFiller<MajorBO>.FillCombo(cboFilterMajor, MajorBO.List());
            dgvTeachers.RefreshDataGrid();
        }

        private void cboFilterMajor_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvTeachers.RefreshDataGrid();
        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            dgvTeachers.RefreshDataGrid();
        }

        public void Set(int majorID)
        {
            MajorBO major = new MajorBO() { MajorID=majorID };
            Set(major);
        }

        public void Set(MajorBO major)
        {
            ComboFiller<MajorBO>.SetCombo(cboFilterMajor, major);
        }

    }
}
