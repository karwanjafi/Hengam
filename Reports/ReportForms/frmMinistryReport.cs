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

namespace Hengam.Reports.ReportForms
{
    public partial class frmReportMinistryReport : HengamWidgets.FormBaseReport
    {
        public frmReportMinistryReport()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                string dateFrom = null;
                string dateTo = null;

                if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportMinistryReport(dateFrom, dateTo, orderText));
            }
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

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


            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("classRegisterationDate", "تاریخ ثبت کلاس", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("majorName", "نام کلاس", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("firstName", "نام استاد", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("lastName", "نام خانوادگی استاد", true));
        }

    }
}
