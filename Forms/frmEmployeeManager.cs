using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataGridFiller;
using BusinessObjectNamespace;
using DatabaseSchemaNamespace;
using Tools;
using Hengam.Tools;
using Hengam.ComboManager;
using FarsiMessageBox;
using Hengam.Forms.ItemPickers;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmEmployeeManager : HengamWidgets.FormBaseTableEditor
    {
        public frmEmployeeManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            EmployeeBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!item.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات کارمندی به نام " + item.FullName));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کارمندی به نام " + item.FullName));
                        break;
                    case 8152:// Dont Remember? 
                        MessageBoxEx.Show("اطلاعات فرم صحیح نمی‌باشد، لطفاً دوباره بررسی کنید" + ".");
                        break;

                    default:
                        MessageBox.Show(se.Number.ToString() + ", \n" + se.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            EmployeeBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!item.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات کارمندی به نام " + item.FullName));
                    GotoAddMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionDelete(object seneder, EventArgs e)
        {
            EmployeeBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کارمند به نام " + item.FullName), "", "حذف کارمند", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف کارمند...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات کارمندی به نام " + item.FullName));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این کارمند نیستید. قبل از حذف باید تمامی اطلاعات این کارمند از سیستم حذف شود.");
                            break;

                        default:
                            MessageBox.Show("Error " + se.Number.ToString() + ",\n" + se.Message);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                HideMsg();
                dataGridSection.RefreshDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionPrint(object seneder, EventArgs e)
        {
            SetMsg("در حال آماده سازی گزارش...");
            EmployeeBO employee = GetGUIKey();
            if (employee == null) return;
            frmReportViewer report = Reports.ReportFiller.ReportEmployeeInformation(employee.EmployeeID);
            if (report == null)
            {
                HideMsg();
                MessageBoxEx.Show("شما اجازه‌ی دسترسی به این قسمت را ندارید.");
                return;
            }
            floaterContainter.LoadPanel(report);
            floaterContainter.Show();
            HideMsg();
        }

        private void ActionSalary(object seneder, EventArgs e)
        {
            SetMsg("در بررسی اطلاعات...");
            EmployeeBO employee = GetGUIKey();
            if (employee == null) return;
            Form f = FormRequester.EmployeeSalary();
            if (f == null)
            {
                HideMsg();
                MessageBoxEx.Show("شما اجازه‌ی دسترسی به این قسمت را ندارید.");
                return;
            }
            frmEmployeeSalary fSalary = (frmEmployeeSalary)f;
            floaterContainter.LoadPanel(fSalary);
            fSalary.Set(employee);
            floaterContainter.Show();
            HideMsg();
        }

        private void frmStudentManager_LoadForm(object sender, EventArgs e)
        {
            //dataGridSection.OnLoadDataGrid += dataGridSection_LoadDataGrid;
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن کارمند", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف کارمند انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("چاپ", "Printer", "چاپ مشخصات کارمند", ActionPrint, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            if (Program.User.CanEmployeeSalary)
                AddButton("حقوق", "Printer", "پرداخت حقوق کارمند", ActionSalary, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            ComboFiller<HowtoFindBO>.FillCombo(cboHowtoFindID, HowtoFindBO.List());
            ComboFiller<DegreeLevelBO>.FillCombo(cboDegreeLevelID, DegreeLevelBO.List());
            ComboFiller<DegreeTypeBO>.FillCombo(cboDegreeTypeID, DegreeTypeBO.List());
            ComboFiller<Gender>.FillCombo(cboGender, Gender.List());
            ComboFiller<MartialStatus>.FillCombo(cboMartialStatus, MartialStatus.List());

            frmGuarantorPicker fGuarantorPicker = new frmGuarantorPicker();
            floaterGuarantorPicker.LoadPanel(fGuarantorPicker);
            fGuarantorPicker.HookTo(txtGuarantorID, txtGurarantorName);
            
            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        private void LoadDataGrid()
        {
            //hanieh
            if (DataAccessNamespace.EmployeeDA.allEmployee.Count == 0)
                DataAccessNamespace.EmployeeDA.allEmployee = EmployeeBO.List();
            //

            DataGridFiller<EmployeeBO>.FillDataGrid(dataGridSection, DataAccessNamespace.EmployeeDA.allEmployee,
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Employee.EmployeeID,
                    DatabaseSchema.Employee.FirstName,
                    DatabaseSchema.Employee.LastName,
                    DatabaseSchema.Employee.FatherName
                });

        }

        private void dataGridSection_LoadDataGrid(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void DoNothing()
        {

        }

        #region Application Layer
        EmployeeBO guiItem = new EmployeeBO();
        private EmployeeBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtEmployeeID.Accepted)
                    err.Add("شماره‌ی کارمند");
                else
                    guiItem.EmployeeID = UtilityTxt.GetString(txtEmployeeID.Text);

                if (!txtFirstName.Accepted)
                    err.Add("نام");
                else
                    guiItem.FirstName = UtilityTxt.GetString(txtFirstName.Text);

                if (!txtLastName.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.LastName = UtilityTxt.GetString(txtLastName.Text);

                if (!txtFatherName.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.FatherName = UtilityTxt.GetString(txtFatherName.Text);

                if (!cboGender.Accepted)
                    err.Add("جنسیت");
                else
                    guiItem.Gender = ComboFiller<Gender>.GetFromCombo(cboGender).GenderValue;

                if (!txtCertificationNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CertificationNumber = UtilityTxt.GetString(txtCertificationNumber.Text);

                if (!txtNationalNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.NationalNumber = UtilityTxt.GetString(txtNationalNumber.Text);


                if (!txtBornPlace.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BornPlace = UtilityTxt.GetString(txtBornPlace.Text);

                if (!txtBornProvince.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BornProvince = UtilityTxt.GetString(txtBornProvince.Text);

                if (!txtBornCountry.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BornCountry = UtilityTxt.GetString(txtBornCountry.Text);

                if (!txtIssuePlace.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.IssuePlace = UtilityTxt.GetString(txtIssuePlace.Text);

                if (!cboMartialStatus.Accepted)
                    err.Add("وضعیت تاهل");
                else
                    guiItem.MartialStatus = ComboFiller<MartialStatus>.GetFromCombo(cboMartialStatus).MartialStatusValue.Value;

                if (!txtHomeAddress.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.HomeAddress = UtilityTxt.GetString(txtHomeAddress.Text);

                if (!txtHomeTell.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.HomeTell = UtilityTxt.GetString(txtHomeTell.Text);

                if (!txtCellPhone.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CellPhone = UtilityTxt.GetString(txtCellPhone.Text);

                if (!cboDegreeTypeID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.DegreeTypeID = ComboFiller<DegreeTypeBO>.GetFromCombo(cboDegreeTypeID).DegreeTypeID;

                if (!cboDegreeLevelID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.DegreeLevelID = ComboFiller<DegreeLevelBO>.GetFromCombo(cboDegreeLevelID).DegreeLevelID;

                if (!txtStudyMajor.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.StudyMajor = UtilityTxt.GetString(txtStudyMajor.Text);

                guiItem.StudyStatus = chkStudyStatus.Checked;

                if (!txtJob.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Job = UtilityTxt.GetString(txtJob.Text);

                if (!cboHowtoFindID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.HowtoFindID = ComboFiller<HowtoFindBO>.GetFromCombo(cboHowtoFindID).HowtoFindID;

                if (!txtSchool.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.School = UtilityTxt.GetString(txtSchool.Text);

                guiItem.ActivityStatus = chkActivityStatus.Checked;

                if (!txtGuarantorID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.GuarantorID = UtilityTxt.GetString(txtGuarantorID.Text);

                if (!picImage.Accepted)
                    guiItem.Image = null;
                else
                    guiItem.Image = picImage.Image;

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
        private EmployeeBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtEmployeeID.Accepted)
                    err.Add("شماره‌ی کارمند");
                else
                    guiItem.EmployeeID = UtilityTxt.GetString(txtEmployeeID.Text);

                guiItem.FirstName = txtFirstName.Text;
                guiItem.LastName = txtLastName.Text;

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
        private void SetGUI(EmployeeBO guiItem)
        {
            this.guiItem = guiItem;
            txtEmployeeID.Text = guiItem.EmployeeID;

            txtFirstName.Text = guiItem.FirstName;

            txtLastName.Text = guiItem.LastName;

            txtFatherName.Text = guiItem.FatherName;

            ComboFiller<Gender>.SetCombo(cboGender, new Gender( guiItem.Gender));

            txtCertificationNumber.Text = guiItem.CertificationNumber;

            txtNationalNumber.Text = guiItem.NationalNumber;


            txtBornPlace.Text = guiItem.BornPlace;

            txtBornProvince.Text = guiItem.BornProvince;

            txtBornCountry.Text = guiItem.BornCountry;

            txtIssuePlace.Text = guiItem.IssuePlace;

            ComboFiller<MartialStatus>.SetCombo(cboMartialStatus, new MartialStatus( guiItem.MartialStatus));

            txtHomeAddress.Text = guiItem.HomeAddress;

            txtHomeTell.Text = guiItem.HomeTell;

            txtCellPhone.Text = guiItem.CellPhone;

            //ComboFiller<DegreeTypeBO>.SetCombo(cboDegreeTypeID, new DegreeTypeBO( guiItem.DegreeTypeID.HasValue?new DegreeTypeBO(guiItem.DegreeTypeID.Value):null));
            ComboFiller<DegreeTypeBO>.SetCombo(cboDegreeTypeID, Utility.GetObject<DegreeTypeBO>(guiItem.DegreeTypeID));

            ComboFiller<DegreeLevelBO>.SetCombo(cboDegreeLevelID, Utility.GetObject<DegreeLevelBO>(guiItem.DegreeLevelID));

            txtStudyMajor.Text = guiItem.StudyMajor;

            chkStudyStatus.Checked = guiItem.StudyStatus;

            txtJob.Text = guiItem.Job;

            ComboFiller<HowtoFindBO>.SetCombo(cboHowtoFindID, Utility.GetObject<HowtoFindBO>(guiItem.HowtoFindID));

            txtSchool.Text = guiItem.School;

            chkActivityStatus.Checked = guiItem.ActivityStatus;

            txtGuarantorID.Text = guiItem.GuarantorID;
            if ( guiItem.GuarantorID != null )
                txtGuarantorID.Text = guiItem.RelGuarantor.FullName;

            picImage.Image = guiItem.Image;

        }
        private new void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new EmployeeBO();
            txtEmployeeID.Text = EmployeeBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            cboGender.SelectedItem = null;
            txtCertificationNumber.Text = "";
            txtNationalNumber.Text = "";
            txtBornPlace.Text = "";
            txtBornProvince.Text = "";
            txtBornCountry.Text = "";
            txtIssuePlace.Text = "";
            cboMartialStatus.SelectedItem = null;
            txtHomeAddress.Text = "";
            txtHomeTell.Text = "";
            txtCellPhone.Text = "";
            cboDegreeTypeID.SelectedItem = null;
            cboDegreeLevelID.SelectedItem = null;
            txtStudyMajor.Text = "";
            chkStudyStatus.Checked = false;
            txtJob.Text = "";
            cboHowtoFindID.SelectedItem = null;
            txtSchool.Text = "";
            chkActivityStatus.Checked = false;
            txtGuarantorID.Text = "";
            picImage.Image = null;

            txtGurarantorName.Text = "";

            //txtEmployeeID.Enabled = true;

        }
        private new void GotoUpdateMode()
        {
            base.GotoUpdateMode();

            //txtEmployeeID.Enabled = false;

        }

        #endregion


        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((EmployeeBO)e.Row.Tag);
            GotoUpdateMode();
            ShowSuggestions();
        }

        private void txtGurarantorName_Click(object sender, EventArgs e)
        {
            //if (FormState == FormEditingState.Adding)
            floaterGuarantorPicker.Show();
        }






        //private void txtStudentID_Leave(object sender, EventArgs e)
        //{
        //    coolLabel1.Text = txtStudentID.Text;
        //}

        //private void frmStudentManager_Load(object sender, EventArgs e)
        //{
        //}
    }
}
