using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Tools;
using FarsiLibrary.Win;
using Hengam.ComboManager;
using StandardWidgets;

namespace Hengam.Forms.ItemViewers
{
    public partial class frmOutcomeViewer : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmOutcomeViewer()
        {
            InitializeComponent();
        }

        public void SetGUI(OutcomeTypicalBO guiItem)
        {
            txtPayID.Text = guiItem.PayID.ToString();

            ComboFiller<OutcomeTypicalTypeBO>.SetCombo(cboOutcomeTypicalTypeID, Utility.GetObject<OutcomeTypicalTypeBO>(guiItem.OutcomeTypicalTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtTag.Text = guiItem.Tag;

            txtDescription.Text = guiItem.Description;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtCheckNumber.Text = guiItem.CheckNumber;

            SetTab(tabOutcomeTypical);

        }

        public void SetGUI(OutcomeStoreBuyBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtStuffName.Text = guiItem.RelStuff.StuffName;

            txtStuffCount.Text = UtilityTxt.GetString(guiItem.RelStuff.StuffCount);

            txtDescription.Text = guiItem.Description;



            txtCheckNumber.Text = guiItem.CheckNumber;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            SetTab(tabOutcomeBuyStuff);

        }
        public void SetGUI(OutcomeEmployeeBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtEmployeeID.Text = guiItem.EmployeeID;
            txtEmployeeName.Text = guiItem.RelEmployee.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtDateFrom.Text = guiItem.DateFrom;

            txtDateTo.Text = guiItem.DateTo;

            SetTab(tabOutcomeEmployee);
        }

        public void SetGUI(OutcomeStudentBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtStudentID.Text = guiItem.StudentID;
            txtStudentName.Text = guiItem.RelStudent.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtClassIDStudent.Text = guiItem.ClassID.ToString();
            txtClassNameStudent.Text = guiItem.RelClass.ClassName;

            SetTab(tabOutcomeStudent);
        }

        public void SetGUI(OutcomeTeacherBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtTeacherID.Text = guiItem.TeacherID;
            txtTeacherName.Text = guiItem.RelTeacher.FullName;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            txtCheckNumber.Text = guiItem.CheckNumber;

            txtDescription.Text = guiItem.Description;

            txtClassIDTeacher.Text = guiItem.ClassID.ToString();
            txtClassNameTeacher.Text = guiItem.RelClass.ClassName;

            SetTab(tabOutcomeTeacher);

        }

        public void SetGUI(ViwOutcomeOveralBO obj)
        {
            switch ((OutcomeOveralTypeBO.OutcomeOveralType)obj.OutcomeOveralTypeID)
            {
                case OutcomeOveralTypeBO.OutcomeOveralType.Typical:
                    SetGUI(OutcomeTypicalBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.BuyStuff:
                    SetGUI(OutcomeStoreBuyBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Employee:
                    SetGUI(OutcomeEmployeeBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Teacher:
                    SetGUI(OutcomeTeacherBO.Find(obj.PayID));
                    break;

                case OutcomeOveralTypeBO.OutcomeOveralType.Student:
                    SetGUI(OutcomeStudentBO.Find(obj.PayID));
                    break;

                default:
                    SetMsg("هزینه‌ی ناشناخته.");
                    break;
            }
        }

        private void SetTab(FATabStripItem tabItem)
        {
            foreach (FATabStripItem tab in tabMain.Items)
            {
                tab.Visible = false;
            }
            tabItem.Visible = true;
            tabMain.SelectedItem = tabItem;
        }

        private void frmOutcomeViewer_LoadForm(object sender, EventArgs e)
        {
            ComboFiller<OutcomeTypicalTypeBO>.FillCombo(cboOutcomeTypicalTypeID, OutcomeTypicalTypeBO.List());
            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());
        }


        #region IFloatable Members

        public PanelFloater ContainerFloater { get; set; }
        
        #endregion

        private void pnlMain_BackColorChanged(object sender, EventArgs e)
        {
            groupOutcomeDetails.BackColor = pnlMain.BackColor;
        }
    }
}
