﻿using System;
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
    public partial class frmReportSessionsOfTeacherInterval : HengamWidgets.FormBaseReport
    {
        public frmReportSessionsOfTeacherInterval()
        {
            InitializeComponent();
        }

        private void ActionGenerateReport(object sender, EventArgs e)
        {
            SetMsg("در حال تهیه‌ی گزارش");
            if (CheckInput())
            {
                string teacherID = txtTeacherID.Text;
                string dateFrom = null;
                string dateTo = null;

                if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
                if (txtDateTo.Accepted) dateTo = txtDateTo.Text;
                string orderText = orderSelector.OrderText;
                SetReport(ReportFiller.ReportSessionsOfTeacherInterval(teacherID, dateFrom, dateTo, txtTeacherName.Text, orderText));
            }
            HideMsg();
        }

        private bool CheckInput()
        {
            ErrorCollector err = new ErrorCollector();

            if (!txtTeacherID.Accepted)
                err.Add("استاد");

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
            AddButton("تهیه گزارش", "Printer", "تهیه‌ی گزارش با پارامترهای انتخاب شده", ActionGenerateReport, ButtonShowMode.ShowInAddMode, true);

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("classDate", "تاریخ جلسه", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("ClassName", "نام کلاس", true));
            orderSelector.AddItem(new StandardWidgets.CoolOrderbySelector.ColumnItem("timeName", "زمان", true));
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }
    }
}
