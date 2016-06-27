using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Tools;
using Hengam.Tools;
using Hengam.ComboManager;
using FarsiMessageBox;

namespace Hengam.Forms
{
    public partial class frmSchoolSpecification : HengamWidgets.FormBaseSimple
    {
        public frmSchoolSpecification()
        {
            InitializeComponent();
        }

        private void txtAddress_Load(object sender, EventArgs e)
        {

        }


        SchoolSpecificationBO guiItem = new SchoolSpecificationBO();
        private SchoolSpecificationBO GetGUI()
{
	ErrorCollector err = new ErrorCollector();
    try
    {
        if (!txtSchoolID.Accepted)
            err.Add("کد آموزشگاه");
        else
            guiItem.SchoolID = UtilityTxt.GetInt(txtSchoolID.Text);

        if (!txtSchoolName.Accepted)
            err.Add("نام آموزشگاه");
        else
            guiItem.SchoolName = UtilityTxt.GetString(txtSchoolName.Text);

        guiItem.SchoolLogo = picSchoolLogo.Image;

        if (!txtAddress.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Address = UtilityTxt.GetString(txtAddress.Text);

        if (!txtManagerFirstName.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ManagerFirstName = UtilityTxt.GetString(txtManagerFirstName.Text);

        if (!txtManagerLastName.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ManagerLastName = UtilityTxt.GetString(txtManagerLastName.Text);

        if (!txtManagerBirthDate.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ManagerBirthDate = UtilityTxt.GetString(txtManagerBirthDate.Text);

        if (!cboDegreeLevelID.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.DegreeLevelID = ComboFiller<DegreeLevelBO>.GetFromCombo(cboDegreeLevelID).DegreeLevelID;

        if (!txtManagerStudeyMajor.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ManagerStudeyMajor = UtilityTxt.GetString(txtManagerStudeyMajor.Text);

        if (!txtJustificationID.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.JustificationID = UtilityTxt.GetString(txtJustificationID.Text);

        if (!txtJustificationName.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.JustificationName = UtilityTxt.GetString(txtJustificationName.Text);

        if (!txtFondYear.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.FondYear = UtilityTxt.GetString(txtFondYear.Text);

        if (!txtEmployeeNumber.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.EmployeeNumber = UtilityTxt.GetInt(txtEmployeeNumber.Text);

        if (!txtWorkHour.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.WorkHour = UtilityTxt.GetString(txtWorkHour.Text);

        if (!txtSchoolGrade.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.SchoolGrade = UtilityTxt.GetString(txtSchoolGrade.Text);

        if (!txtProvince.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Province = UtilityTxt.GetString(txtProvince.Text);

        if (string.IsNullOrEmpty(txtStudentPayFooterDesc.Text))
            DoNothing();
        else
            guiItem.ReportPayFactorFooterDesc = UtilityTxt.GetString(txtStudentPayFooterDesc.Text);

        if (!txtCity.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.City = UtilityTxt.GetString(txtCity.Text);

        if (!txtStreet.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Street = UtilityTxt.GetString(txtStreet.Text);

        if (!txtPostalCode.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.PostalCode = UtilityTxt.GetString(txtPostalCode.Text);

        if (!txtTell.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Tell = UtilityTxt.GetString(txtTell.Text);

        if (!txtFax.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Fax = UtilityTxt.GetString(txtFax.Text);

        if (!txtMail.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.Mail = UtilityTxt.GetString(txtMail.Text);

        guiItem.BackgroundImage = picBackgroundImage.Image;

        if (!txtReportTitle.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ReportTitle = UtilityTxt.GetString(txtReportTitle.Text);

        guiItem.ReportLogo = picReportLogo.Image;

        if (!txtReportAddress.Accepted)
            DoNothing();//Do Nothing...
        else
            guiItem.ReportAddress = UtilityTxt.GetString(txtReportAddress.Text);

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
	if (err.HasError)
	{
		err.ShowErrMsg();
		return null;
	}
	return guiItem;
}

        private void DoNothing()
        {
            
        }
        private SchoolSpecificationBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtSchoolID.Accepted)
                    err.Add("کد آموزشگاه");
                else
                    guiItem.SchoolID = UtilityTxt.GetInt(txtSchoolID.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (err.HasError)
            {
                err.ShowErrMsg();
                return null;
            }
            return guiItem;
        }
        private void SetGUI(SchoolSpecificationBO guiItem)
        {
            this.guiItem = guiItem;

            txtSchoolID.Text = guiItem.SchoolID.ToString();

            txtSchoolName.Text = guiItem.SchoolName;

            picSchoolLogo.Image = guiItem.SchoolLogo;

            txtAddress.Text = guiItem.Address;

            txtManagerFirstName.Text = guiItem.ManagerFirstName;

            txtManagerLastName.Text = guiItem.ManagerLastName;

            txtManagerBirthDate.Text = guiItem.ManagerBirthDate;

            ComboFiller<DegreeLevelBO>.SetCombo(cboDegreeLevelID, Utility.GetObject<DegreeLevelBO>(guiItem.DegreeLevelID));

            txtManagerStudeyMajor.Text = guiItem.ManagerStudeyMajor;

            txtJustificationID.Text = guiItem.JustificationID;

            txtJustificationName.Text = guiItem.JustificationName;

            txtFondYear.Text = guiItem.FondYear;

            txtEmployeeNumber.Text = UtilityTxt.GetString(guiItem.EmployeeNumber);

            txtWorkHour.Text = guiItem.WorkHour;

            txtSchoolGrade.Text = guiItem.SchoolGrade;

            txtProvince.Text = guiItem.Province;

            txtStudentPayFooterDesc.Text = guiItem.ReportPayFactorFooterDesc;
            
            txtCity.Text = guiItem.City;

            txtStreet.Text = guiItem.Street;

            txtPostalCode.Text = guiItem.PostalCode;

            txtTell.Text = guiItem.Tell;

            txtFax.Text = guiItem.Fax;

            txtMail.Text = guiItem.Mail;

            picBackgroundImage.Image = guiItem.BackgroundImage;

            txtReportTitle.Text = guiItem.ReportTitle;

            picReportLogo.Image = guiItem.ReportLogo;

            txtReportAddress.Text = guiItem.ReportAddress;

        }

        private void frmSchoolSpecification_LoadForm(object sender, EventArgs e)
        {
            ComboFiller<DegreeLevelBO>.FillCombo(cboDegreeLevelID, DegreeLevelBO.List());
            List<SchoolSpecificationBO> specis = SchoolSpecificationBO.List();
            if (specis.Count == 0)
            {
                MessageBoxEx.Show("مشخصات آموزشگاه وجود ندارد.");
                return;
            }

            SchoolSpecificationBO speci = specis[0];

            SetGUI(speci);


        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            SchoolSpecificationBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (item.Update() || item.Add())
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات آموزشگاه "));
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
        }

        private void picSchoolLogo_Load(object sender, EventArgs e)
        {

        }
        
    }
}
