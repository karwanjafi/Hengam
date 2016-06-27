using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Tools;
using StandardWidgets;

namespace Hengam.Forms.Student
{
    public partial class frmStudentAffairs : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmStudentAffairs()
        {
            InitializeComponent();

            btnStudentBalance.Enabled = CanStudentBalance;
            btnStudentManager.Enabled = CanStudentManager;
            btnStudentPayForClass.Enabled = CanStudentPayForClass;
            btnStudentRegisteration.Enabled = CanStudentRegisteration;
        }
        public static bool CanStudentPayForClass = false;
        public static bool CanStudentBalance = false;
        public static bool CanStudentManager = false;
        public static bool CanStudentRegisteration = false;

        private void btnStudentPayForClass_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StudentPayForClass());
        }

        private void btnStudentBalance_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StudentClassBalance());
        }

        private void btnStudentManager_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StudentManager());
        }

        private void btnStudentRegisteration_Clicked(object sender, EventArgs e)
        {
            Program.MainForm.RunForm(FormRequester.StudentRegisterationManager());
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater { get; set; }

        #endregion
    }
}
