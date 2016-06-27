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
    public partial class frmClassPicker : HengamWidgets.FormBaseSimple, StandardWidgets.IFloatable
    {
        public frmClassPicker()
        {
            InitializeComponent();
        }

        public StandardWidgets.PanelFloater ContainerFloater { get; set; }

        public ClassBO SelectedClass = null;
        private CoolNumberBox hookedTextBoxClassID = null;
        private CoolTextBox hookedTextBoxClassName = null;
        public static bool StudentAccepted = false; //hanieh
        public static bool TeacherAccepted = false; //hanieh

        public void HookTo(CoolNumberBox txtGuarantorID, CoolTextBox txtGuarantorName)
        {
            hookedTextBoxClassID = txtGuarantorID;
            hookedTextBoxClassName = txtGuarantorName;
        }

        private bool? groupFlag = null;
        
        public bool? GroupFlag
        {
            get { return groupFlag; }
            set
            {
                groupFlag = value;
            }
        }

        private void dgvClasss_OnLoadDataGrid(object sender, EventArgs e)
        {
            List<ClassBO> list = null;
            if (ClassListFunction == null)
            {
                bool? activityStatus = activitySelector.ActivityStatus;

                //bool? groupFlag = null;
                //if (chkPrivate.Checked && !chkPublics.Checked)
                //    groupFlag = false;
                //if (!chkPrivate.Checked && chkPublics.Checked)
                //    groupFlag = true;

                if (txtStudentID.Accepted || StudentAccepted)
                    list = ClassBO.ListClassesOfStudent(txtStudentID.Accepted ? txtStudentID.Text : null, activityStatus);
                else if (txtTeacherID.Accepted || TeacherAccepted)
                    list = ClassBO.ListClassesOfTeacher(txtTeacherID.Text, activityStatus);
                else
                    //hanieh
                    if (activityStatus == true && groupFlag != null)
                    {
                        if (groupFlag == true)
                        {
                            if (DataAccessNamespace.ClassDA.allActivePublicClasses.Count == 0)
                                DataAccessNamespace.ClassDA.allActivePublicClasses = ClassBO.List(null, null, GroupFlag, activityStatus, null);
                            list = DataAccessNamespace.ClassDA.allActivePublicClasses;
                        }
                        else
                        {
                            if (DataAccessNamespace.ClassDA.allActivePrivateClasses.Count == 0)
                                DataAccessNamespace.ClassDA.allActivePrivateClasses = ClassBO.List(null, null, GroupFlag, activityStatus, null);
                            list = DataAccessNamespace.ClassDA.allActivePrivateClasses;
                        }
                    }
                    else                         
                        list = ClassBO.List(null, null, GroupFlag, activityStatus, null);
            }
            else
                list = ClassListFunction();
            DataGridFiller<ClassBO>.FillDataGrid(dgvClasses, list, new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.Class.ClassID,
                DatabaseSchema.Class.ClassName,
                DatabaseSchema.Class.ClassDescription
            });
        }

        public void Set(StudentBO student)
        {
            if (student != null) txtStudentID.Text = student.StudentID;
            dgvClasses.RefreshDataGrid();
        }

        public void Set(TeacherBO teacher)
        {
            if (teacher != null) txtTeacherID.Text = teacher.TeacherID;
            dgvClasses.RefreshDataGrid();
        }

        private void dgvClasss_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SelectedClass = (ClassBO)e.Row.Tag;
            if ( hookedTextBoxClassID != null)
                hookedTextBoxClassID.Text = SelectedClass.ClassID.ToString();
            if ( hookedTextBoxClassName != null)
                hookedTextBoxClassName.Text = SelectedClass.ClassName;

            CloseFloater();

        }

        private void CloseFloater()
        {
            if (ContainerFloater != null) ContainerFloater.Hide();
        }

        private void frmClassPicker_LoadForm(object sender, EventArgs e)
        {
            dgvClasses.RefreshDataGrid();
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            if (hookedTextBoxClassID != null)
                hookedTextBoxClassID.Text = "";
            if (hookedTextBoxClassName != null)
                hookedTextBoxClassName.Text = "";

            CloseFloater();
        }

        public delegate List<ClassBO> ClassListDelegate();
        ClassListDelegate ClassListFunction = null;
        public void SetListFunction(ClassListDelegate listDelegate)
        {
            ClassListFunction = listDelegate;
        }



        public void RefreshDatagrid()
        {
            dgvClasses.RefreshDataGrid();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            //dgvClasses.RefreshDataGrid();
        }

        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            dgvClasses.RefreshDataGrid();
        }
    }
}
