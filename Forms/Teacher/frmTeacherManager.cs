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
using Hengam.Forms.Teacher;
using Hengam.Forms.ItemPickers;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmTeacherManager : HengamWidgets.FormBaseTableEditor
    {
        public frmTeacherManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            TeacherBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات استاد به نام " + item.FullName));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات استادی به نام " + item.FullName));
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
            LoadDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            TeacherBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات استادی به نام " + item.FullName));
                    GotoAddMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            LoadDataGrid();
        }

        private void ActionDelete(object seneder, EventArgs e)
        {
            TeacherBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات استادی به نام " + item.FullName), "", "حذف استاد", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف استاد...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات استادی به نام " + item.FullName));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این استاد نیستید. قبل از حذف باید تمامی اطلاعات این استاد از سیستم حذف شود.");
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
                LoadDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionTimeManager(object sender, EventArgs e)
        {
            frmTeacherTimePicker fTime = (frmTeacherTimePicker)FormRequester.TeacherTimeSelector();
            if (fTime == null)
            {
                MessageBoxEx.Show("شما قادر به استفاده از این قسمت نیستید.");
                return;
            }
            Program.SetMsg("در حال بازیابی");
            floaterContainer.LoadPanel(fTime);
            fTime.Set(TeacherBO.Find(txtTeacherID.Text), FaDate.CurrentFaDateString);
            floaterContainer.Show();
            Program.HideMsg();
        }

        private void ActionFinancial(object sender, EventArgs e)
        {
            frmTeacherFinancialDetails fFinancial = new frmTeacherFinancialDetails();
            if (fFinancial == null)
            {
                MessageBoxEx.Show("شما قادر به استفاده از این قسمت نیستید.");
                return;
            }
            Program.SetMsg("در حال بازیابی");
            fFinancial.Set(TeacherBO.Find(txtTeacherID.Text), null); 
            floaterContainer.LoadPanel(fFinancial);
            //fFinancial.Set(TeacherBO.Find(txtTeacherID.Text), null);//hanieh
            floaterContainer.Show();
            Program.HideMsg();
        }

        private void ActionMajors(object sender, EventArgs e)
        {
            frmMajorTeacherManager fMajor = new frmMajorTeacherManager();
            if (fMajor == null)
            {
                MessageBoxEx.Show("شما قادر به استفاده از این قسمت نیستید.");
                return;
            }
            Program.SetMsg("در حال بازیابی");
            //Program.MainForm.RunForm(fMajor);
            floaterContainer.LoadPanel(fMajor);
            fMajor.Set(txtTeacherID.Text);
            floaterContainer.Show();
            Program.HideMsg();
        }

        private void ActionPrint(object seneder, EventArgs e)
        {
            TeacherBO teacher = GetGUIKey();
            if (teacher == null) return;

            frmReportViewer fReport = Reports.ReportFiller.ReportTeacherInformation(teacher.TeacherID);
            if (fReport == null)
            {
                MessageBoxEx.Show("شما قادر به استفاده از این قسمت نیستید.");
                return;
            }
            Program.SetMsg("در حال بازیابی");
            floaterContainer.LoadPanel(fReport);
            floaterContainer.Show();
            Program.HideMsg();
        }


        private void frmTeacherManager_LoadForm(object sender, EventArgs e)
        {
            //dataGridSection.OnLoadDataGrid += dataGridSection_LoadDataGrid;
            AddButton("اضافه کردن", "Add", "اضافه کردن استاد", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف استادی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            if (Program.User.CanTeacherTimeSelector)
                AddButton("زمان‌های آزاد", "Times", "بررسی آزاد استاد", ActionTimeManager, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            
            if (Program.User.CanMajorTeacherManager)
                AddButton("رشته‌های استاد", "Majors", "تنظیم رشته‌های تخصصی و غیرتخصصی استاد", ActionMajors, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            
            //hanieh---------
            //if (Program.User.CanTeacherFinancialStatus)
             //   AddButton("وضعیت مالی", "Financial", "بررسی وضعیت مالی استاد", ActionFinancial, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            //----------------
            AddButton("چاپ", "Printer", "چاپ مشخصات استاد", ActionPrint, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            
            ComboFiller<ContractTypeBO>.FillCombo(cboContractTypeID, ContractTypeBO.List());
            ComboFiller<DegreeLevelBO>.FillCombo(cboDegreeLevelID, DegreeLevelBO.List());
            ComboFiller<DegreeTypeBO>.FillCombo(cboDegreeTypeID, DegreeTypeBO.List());
            ComboFiller<Gender>.FillCombo(cboGender, Gender.List());
            ComboFiller<MartialStatus>.FillCombo(cboMartialStatus, MartialStatus.List());
            ComboFiller<MajorBO>.FillCombo(cboFilterMajor, MajorBO.List());

            dataGridSection.RefreshDataGrid();

            GotoAddMode();
        }

        private void LoadDataGrid()
        {
            int? majorID = null;
            if (cboFilterMajor.Accepted)
                majorID = ComboFiller<MajorBO>.GetFromCombo(cboFilterMajor).MajorID;

            DataGridFiller<TeacherBO>.FillDataGrid(dataGridSection, TeacherBO.List(majorID, activitySelector.ActivityStatus),
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Teacher.TeacherID,
                    DatabaseSchema.Teacher.FirstName,
                    DatabaseSchema.Teacher.LastName,
                    DatabaseSchema.Teacher.FatherName
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
        TeacherBO guiItem = new TeacherBO();
        private TeacherBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtTeacherID.Accepted)
                    err.Add("کد استاد");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

                if (!txtFirstName.Accepted)
                    err.Add("نام");
                else
                    guiItem.FirstName = UtilityTxt.GetString(txtFirstName.Text);

                if (!txtLastName.Accepted)
                    err.Add("نام خانوادگی");
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

                if (!txtBirthDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BirthDate = UtilityTxt.GetString(txtBirthDate.Text);

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

                if (!txtWorkAddress.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.WorkAddress = UtilityTxt.GetString(txtWorkAddress.Text);

                if (!txtWorkTell.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.WorkTell = UtilityTxt.GetString(txtWorkTell.Text);

                if (!txtCellPhone.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CellPhone = UtilityTxt.GetString(txtCellPhone.Text);

                if (!cboDegreeTypeID.Accepted)
                    err.Add("مدرک تحصیلی");
                else
                    guiItem.DegreeTypeID = ComboFiller<DegreeTypeBO>.GetFromCombo(cboDegreeTypeID).DegreeTypeID;

                if (!cboDegreeLevelID.Accepted)
                    err.Add("سطح تحصیلات");
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

                if (!txtIntroducer.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Introducer = UtilityTxt.GetString(txtIntroducer.Text);

                if (!txtQulificationCardID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.QulificationCardID = UtilityTxt.GetString(txtQulificationCardID.Text);

                if (!txtTeachers.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Teachers = UtilityTxt.GetString(txtTeachers.Text);

                if (!txtTeachingExprience.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.TeachingExprience = UtilityTxt.GetString(txtTeachingExprience.Text);

                if (!txtSchool.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.School = UtilityTxt.GetString(txtSchool.Text);

                if (!cboContractTypeID.Accepted)
                    err.Add("نوع قرارداد");
                else
                    guiItem.ContractTypeID = ComboFiller<ContractTypeBO>.GetFromCombo(cboContractTypeID).ContractTypeID;

                if (!txtContractValue.Accepted)
                    err.Add("مبلغ قرارداد");
                else
                    guiItem.ContractValue = UtilityTxt.GetInt(txtContractValue.Text);


                if (!txtUsername.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Username = UtilityTxt.GetString(txtUsername.Text);

                if (!txtPassword.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Password = UtilityTxt.GetString(txtPassword.Text);

                guiItem.ActivityStatus = chkActivityStatus.Checked;
                guiItem.CanShowOnWeb = chkCanShowOnWeb.Checked;

                if (!picImage.Accepted)
                    DoNothing();
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
        private TeacherBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtTeacherID.Accepted)
                    err.Add("کد استاد");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

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
        private void SetGUI(TeacherBO guiItem)
        {
            this.guiItem = guiItem;
            txtTeacherID.Text = guiItem.TeacherID;

            txtFirstName.Text = guiItem.FirstName;

            txtLastName.Text = guiItem.LastName;

            txtFatherName.Text = guiItem.FatherName;

            ComboFiller<Gender>.SetCombo(cboGender, Utility.GetObject<Gender>(guiItem.Gender));

            txtCertificationNumber.Text = guiItem.CertificationNumber;

            txtNationalNumber.Text = guiItem.NationalNumber;

            txtBirthDate.Text = guiItem.BirthDate;

            txtBornPlace.Text = guiItem.BornPlace;

            txtBornProvince.Text = guiItem.BornProvince;

            txtBornCountry.Text = guiItem.BornCountry;

            txtIssuePlace.Text = guiItem.IssuePlace;

            ComboFiller<MartialStatus>.SetCombo(cboMartialStatus, Utility.GetObject<MartialStatus>(guiItem.MartialStatus));

            txtHomeAddress.Text = guiItem.HomeAddress;

            txtHomeTell.Text = guiItem.HomeTell;

            txtWorkAddress.Text = guiItem.WorkAddress;

            txtWorkTell.Text = guiItem.WorkTell;

            txtCellPhone.Text = guiItem.CellPhone;

            ComboFiller<DegreeTypeBO>.SetCombo(cboDegreeTypeID, Utility.GetObject<DegreeTypeBO>(guiItem.DegreeTypeID));

            ComboFiller<DegreeLevelBO>.SetCombo(cboDegreeLevelID, Utility.GetObject<DegreeLevelBO>(guiItem.DegreeLevelID));

            txtStudyMajor.Text = guiItem.StudyMajor;

            chkStudyStatus.Checked = guiItem.StudyStatus;

            txtJob.Text = guiItem.Job;

            txtIntroducer.Text = guiItem.Introducer;

            txtQulificationCardID.Text = guiItem.QulificationCardID;

            txtTeachers.Text = guiItem.Teachers;

            txtTeachingExprience.Text = guiItem.TeachingExprience;

            txtSchool.Text = guiItem.School;

            ComboFiller<ContractTypeBO>.SetCombo(cboContractTypeID, Utility.GetObject<ContractTypeBO>(guiItem.ContractTypeID));

            txtContractValue.Text = UtilityTxt.GetString(guiItem.ContractValue);

            picImage.Image = guiItem.Image;

            txtUsername.Text = guiItem.Username;

            txtPassword.Text = guiItem.Password;

            chkActivityStatus.Checked = guiItem.ActivityStatus;
            chkCanShowOnWeb.Checked = guiItem.CanShowOnWeb;

        }
        private new void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new TeacherBO();
            txtTeacherID.Text = TeacherBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            cboGender.SelectedItem = null;
            txtCertificationNumber.Text = "";
            txtNationalNumber.Text = "";
            txtBirthDate.Text = "";
            txtBornPlace.Text = "";
            txtBornProvince.Text = "";
            txtBornCountry.Text = "";
            txtIssuePlace.Text = "";
            cboMartialStatus.SelectedItem = null;
            txtHomeAddress.Text = "";
            txtHomeTell.Text = "";
            txtWorkAddress.Text = "";
            txtWorkTell.Text = "";
            txtCellPhone.Text = "";
            cboDegreeTypeID.SelectedItem = null;
            cboDegreeLevelID.SelectedItem = null;
            txtStudyMajor.Text = "";
            chkStudyStatus.Checked = false;
            txtJob.Text = "";
            txtIntroducer.Text = "";
            txtQulificationCardID.Text = "";
            txtTeachers.Text = "";
            txtTeachingExprience.Text = "";
            txtSchool.Text = "";
            cboContractTypeID.SelectedItem = null;
            txtContractValue.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            chkActivityStatus.Checked = true;
            chkCanShowOnWeb.Checked = true;
            picImage.Image = null;



            //txtTeacherID.Enabled = true;

            //EditingState = FormState.Adding;
        }
        private new void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            ShowSuggestions();
            //txtTeacherID.Enabled = false;

            //EditingState = FormState.Updating;
        }

        #endregion

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((TeacherBO)e.Row.Tag);
            GotoUpdateMode();
        }

        private void activitySelector1_StatusChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void coolComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }






        //private void txtitemID_Leave(object sender, EventArgs e)
        //{
        //    coolLabel1.Text = txtitemID.Text;
        //}

        //private void frmitemManager_Load(object sender, EventArgs e)
        //{
        //}
    }
}
