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
    public partial class frmReportStudentPayFactor : HengamWidgets.FormBaseReport, IFloatable
    {
        public frmReportStudentPayFactor()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                string studentID = txtStudentID.Text;
                int classID = UtilityTxt.GetInt(txtClassID.Text);
                //string dateFrom = null;
                //string dateTo = null;

                //if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                //if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportStudentPayFactor(studentID, classID, null, orderText));
            }
            HideMsg();
        }

        public void SetFactor(int payID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportStudentPayFactor(null, null, payID, orderText));

            HideMsg();
        }

        public void SetFactor(string studentID, int? classID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            txtStudentID.Text = studentID; //hanieh
            txtClassID.Text = UtilityTxt.GetString(classID);//hanieh
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportStudentPayFactor(studentID, classID, null, orderText));
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!txtStudentID.Accepted)
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

            //hanieh
            //frmClassPicker.StudentAccepted = true;
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            //floaterClassPicker.LoadPanel(fClassPicker);
            //fClassPicker.HookTo(txtClassID, txtClassName);
            ////fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            //

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentFirstName", "نام خانوادگی هنرجو", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentLastName", "نام هنرجو", true));
        }

        public List<ClassBO> GetClassListOfStudent()
        {
            if (!txtStudentID.Accepted)
                //hanieh
                if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                    return ClassBO.List();
                else
                    return DataAccessNamespace.ClassDA.allclasses;
                //
            else
                return ClassBO.ListClassesOfStudent(txtStudentID.Text, null);
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            //hanieh
            frmClassPicker.StudentAccepted = true;
            fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //
            if (txtStudentID.Text!=null)
                fClassPicker.RefreshDatagrid(); 
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

        private void txtStudentName_TextAccepted(object sender, EventArgs e)
        {

        }

        private void txtClassName_Load(object sender, EventArgs e)
        {

        }

        //hanieh
        public void Set(ClassBO classObj, StudentBO student)
        {
            if (classObj != null)
            {
                txtClassID.Text = classObj.ClassID.ToString();
                txtClassName.Text = classObj.ClassName;
            }
            if (student != null)
            {
                txtStudentID.Text = student.StudentID;
                txtStudentName.Text = student.FullName;
            }
        }
    }
}
