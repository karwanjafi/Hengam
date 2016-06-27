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

namespace Hengam.Reports.ReportForms
{
    public partial class frmReportEmployeePayFactor : HengamWidgets.FormBaseReport
    {
        public frmReportEmployeePayFactor()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                string employeeID = txtEmployeeID.Text;
                //string dateFrom = null;
                //string dateTo = null;

                //if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                //if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportEmployeePayFactor(employeeID, null, orderText));
            }
            HideMsg();
        }

        public void SetFactor(int payID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportEmployeePayFactor(null, payID, orderText));

            HideMsg();
        }

        public void SetFactor(string employeeID)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            string orderText = orderSelector.OrderText;
            SetReport(ReportFiller.ReportEmployeePayFactor(employeeID, null, orderText));
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!txtEmployeeID.Accepted)
                err.Add("هنرجو");

            if (err.HasError)
            {
                err.ShowErrMsg();
                return false;
            }
            else
                return true;
        }

        private void frmReportStudentListOfMajor_LoadForm(object sender, EventArgs e)
        {
            AddButton("تهیه گزارش", "Printer", "تهیه‌ی گزارش با پارامترهای انتخاب شده", ActionGenerateReport, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);


            frmEmployeePicker fEmployeePicker = new frmEmployeePicker();
            floaterEmployeePicker.LoadPanel(fEmployeePicker);
            fEmployeePicker.HookTo(txtEmployeeID, txtEmployeeName);

            //orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentFirstName", "نام خانوادگی هنرجو", true));
            //orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("studentLastName", "نام هنرجو", true));
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterEmployeePicker.Show();
        }

    }
}
