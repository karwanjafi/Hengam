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

namespace Hengam.Reports.ReportForms
{
    public partial class frmReportStudentListOfMajor : HengamWidgets.FormBaseReport
    {
        public frmReportStudentListOfMajor()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                int majorID = ComboFiller<MajorBO>.GetFromCombo(cboMajorID).MajorID;
                string dateFrom = null;
                string dateTo = null;

                if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportStudentListOfMajor(majorID, dateFrom, dateTo, MajorBO.Find(majorID).MajorName, orderText));
            }
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!cboMajorID.Accepted)
                err.Add("رشته");

            if (!txtDateFrom.Accepted)
                err.Add("تاریخ، از");

            if (!txtDateTo.Accepted)
                err.Add("تاریخ، تا");

            if (err.HasError)
            {
                err.ShowErrMsg();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmReportStudentListOfMajor_LoadForm(object sender, EventArgs e)
        {
            AddButton("تهیه گزارش", "Printer", "تهیه‌ی گزارش با پارامترهای انتخاب شده", ActionGenerateReport, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            ComboFiller<MajorBO>.FillCombo(cboMajorID, MajorBO.List());

            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("firstName", "نام هنرجو", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("lastName", "نام خانوادگی هنرجو", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("registrationDate", "تاریخ ثبت‌نام", true));
        }
    }
}
