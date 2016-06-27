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
    public partial class frmIncomeViewer : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmIncomeViewer()
        {
            InitializeComponent();
        }

        
        public void SetGUI(IncomeStoreSellBO guiItem)
        {
            txtPayID.Text = UtilityTxt.GetString(guiItem.PayID);

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            txtCheckDate.Text = guiItem.CheckDate;

            //txtStuffName.Text = guiItem.StuffName;

            //txtStuffCount.Text = UtilityTxt.GetString(guiItem.StuffCount);

            txtDescription.Text = guiItem.Description;



            txtCheckNumber.Text = guiItem.CheckNumber;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            SetTab(tabIncomeStoreSell);

        }

        public void SetGUI(IncomeStudentBO guiItem)
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

            SetTab(tabIncomeStudent);
        }

        
        public void SetGUI(ViwIncomeOveralBO obj)
        {
            switch ((IncomeOveralTypeBO.IncomeOveralType)obj.IncomeOveralTypeID)
            {

                case IncomeOveralTypeBO.IncomeOveralType.StudentFee:
                    SetGUI(IncomeStudentBO.Find(obj.PayID));
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

        private void frmIncomeViewer_LoadForm(object sender, EventArgs e)
        {
            ComboFiller<IncomeTypicalTypeBO>.FillCombo(cboIncomeTypicalTypeID, IncomeTypicalTypeBO.List());
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
