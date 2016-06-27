using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Tools;
using Hengam.ComboManager;
using BusinessObjectNamespace;
using Hengam.Forms.ItemPickers;
using Tools;
using StandardWidgets;

namespace Hengam.Reports.ReportForms
{
    public partial class frmReportTeacherPayFactor : HengamWidgets.FormBaseReport, IFloatable
    {
        public frmReportTeacherPayFactor()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                string teacherID = txtTeacherID.Text;
                int classID = UtilityTxt.GetInt(txtClassID.Text);
                //string dateFrom = null;
                //string dateTo = null;

                //if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                //if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportTeacherPayFactor(teacherID, classID, null, orderText));
            }
            HideMsg();
        }

        public void SetFactor(string groupPayID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportTeacherPayFactor(null, null, groupPayID, orderText));

            HideMsg();
        }

        public void SetFactor(string teacherID, int? classID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportTeacherPayFactor(teacherID, classID, null, orderText));
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!txtTeacherID.Accepted)
                err.Add("هنرجو");

            if (!txtClassID.Accepted)
                err.Add("کلاس");

            if (err.HasError)
            {
                err.ShowErrMsg();
                return false;
            }
            else
                return true;
        }

        frmClassPicker fClassPicker = new frmClassPicker();

        private void frmReportStudentListOfMajor_LoadForm(object sender, EventArgs e)
        {
            AddButton("تهیه گزارش", "Printer", "تهیه‌ی گزارش با پارامترهای انتخاب شده", ActionGenerateReport, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            //removed by hanieh
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            //floaterClassPicker.LoadPanel(fClassPicker);
            //fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            //orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentFirstName", "نام خانوادگی هنرجو", true));
            //orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentLastName", "نام هنرجو", true));
        }

        public List<ClassBO> GetClassListOfStudent()
        {
            if (!txtTeacherID.Accepted)
                //hanieh
                if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                    return ClassBO.List();
                else
                    return DataAccessNamespace.ClassDA.allclasses;
            //
            else
                return ClassBO.ListClassesOfTeacher(txtTeacherID.Text, null);
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            //hanieh
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            if (txtTeacherID.Text != null)
                fClassPicker.RefreshDatagrid(); //hanieh
            //
            floaterClassPicker.Show();
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {
            fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
        }
    }
}
