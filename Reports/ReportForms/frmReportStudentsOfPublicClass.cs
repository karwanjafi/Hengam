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
    public partial class frmReportStudentsOfPublicClass : HengamWidgets.FormBaseReport
    {
        public frmReportStudentsOfPublicClass()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                int classID = UtilityTxt.GetInt(txtClassID.Text);

                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportStudentsOfPublicClass(classID, orderText));
            }
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!txtClassID.Accepted)
                err.Add("کلاس");

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

            frmClassPicker fClassPicker = new frmClassPicker();
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);

            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("lastname", "نام خانوادگی", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("firstName", "نام", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("registrationDate", "تاریخ ثبت‌نام", true));
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterClassPicker.Show();
        }
    }
}
