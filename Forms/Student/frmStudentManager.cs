using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataGridFiller;
using BusinessObjectNamespace;
using Cloner;
using DatabaseSchemaNamespace;
using Tools;
using Hengam.Tools;
using Hengam.ComboManager;
using FarsiMessageBox;
using Hengam.Tools.LastChangeManagement;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmStudentManager : HengamWidgets.FormBaseTableEditor
    {
        public frmStudentManager()
        {
            InitializeComponent();
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (txtStudentID.Accepted)
            {
                Form f = FormRequester.StudentPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmStudentPayForClass fPay = (frmStudentPayForClass)f;
                    fPay.Set(null, StudentBO.Find(txtStudentID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            StudentBO student = GetGUI();
            if (student == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!student.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات هنرجویی به نام " + student.FullName));
                    SetGUI(student);
                    GotoUpdateMode();
                    ShowSuggestions();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات هنرجویی به نام " + student.FullName));
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
            DataAccessNamespace.StudentDA.allActiveStudents = StudentBO.List(null, null, true); //hanieh
            LoadDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            StudentBO student = GetGUI();
            if (student == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!student.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات هنرجویی به نام " + student.FullName));
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
            StudentBO student = GetGUIKey();
            if (student == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات هنرجویی به نام " + student.FullName), "", "حذف هنرجو", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف هنرجو...");
                    if (!student.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات هنرجویی به نام " + student.FullName));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این هنرجو نیستید. قبل از حذف باید تمامی اطلاعات این هنرجو از سیستم حذف شود.");
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

        private void ActionPrint(object seneder, EventArgs e)
        {
            StudentBO student = GetGUIKey();
            if (student == null) return;
            Program.MainForm.RunForm(Reports.ReportFiller.StudentInformation(student.StudentID));
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionRegister(object seneder, EventArgs e)
        {
            StudentBO student = GetGUIKey();
            if (student == null) return;
            SetMsg("در حال بررسی اطلاعات کلاس‌های عمومی...");
            Form f = FormRequester.StudentRegisterationManager();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                HideMsg();
                return;
            }
            frmStudentRegisterationManager fReg = (frmStudentRegisterationManager)f;
            fReg.SetStudent(student.StudentID);
            fReg.ShowMode = frmStudentRegisterationManager.ShowModeEnum.ShowClasses;
            //Program.MainForm.RunForm(fReg);
            floaterContainer.LoadPanel(fReg);
            HideMsg();
            floaterContainer.Show();
        }

        private void ActionRegisterPrivate(object seneder, EventArgs e)
        {
            StudentBO student = GetGUIKey();
            if (student == null) return;
            SetMsg("در حال بررسی اطلاعات کلاس‌های خصوصی...");
            Form f = FormRequester.ClassManagerPrivate();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                HideMsg();
                return;
            }
            frmClassManagerPrivate fReg = (frmClassManagerPrivate)f;
            fReg.Set(student, null); //hanieh
            //fReg.ShowMode = frmStudentRegisterationManager.ShowModeEnum.ShowClasses;
            //Program.MainForm.RunForm(fReg);
            floaterContainer.LoadPanel(fReg);
            HideMsg();
            floaterContainer.Show();
            //fReg.Set(student, null); //hanieh

        }

        public override void ActionCloseSuggestion(object sender, EventArgs e)
        {
            base.ActionCloseSuggestion(sender, e);
            //GotoAddMode();
        }

        private void frmStudentManager_LoadForm(object sender, EventArgs e)
        {

            //dataGridSection.OnLoadDataGrid += dataGridSection_LoadDataGrid;
            AddButton("اضافه کردن", "Add", "اضافه کردن هنرجو", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف هنرجوی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            if (Program.User.CanStudentRegisterationManager)
                AddButton("کلاس عمومی", "Class", "ثبت نام هنرجو در یک کلاس عمومی", ActionRegister, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            if (Program.User.CanClassManagerPrivate)
                AddButton("کلاس خصوصی", "Class", "ثبت نام هنرجو در یک کلاس خصوصی", ActionRegisterPrivate, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            if (Program.User.CanStudentInformationReport)
                AddButton("چاپ", "Printer", "چاپ مشخصات هنرجو", ActionPrint, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("دریافت شهریه", "MoneyMoney", "دریافت شهریه از هنرجو بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<HowtoFindBO>.FillCombo(cboHowtoFindID, HowtoFindBO.List());
            ComboFiller<AreaBO>.FillCombo(cboAreaID, AreaBO.List());
            ComboFiller<DegreeLevelBO>.FillCombo(cboDegreeLevelID, DegreeLevelBO.List());
            ComboFiller<DegreeTypeBO>.FillCombo(cboDegreeTypeID, DegreeTypeBO.List());
            ComboFiller<Gender>.FillCombo(cboGender, Gender.List());
            ComboFiller<MartialStatus>.FillCombo(cboMartialStatus, MartialStatus.List());

            dataGridSection.RefreshDataGrid();

            GotoAddMode();
        }

        private void LoadDataGrid()
        {
            dataGridSection.RefreshDataGrid();
        }

        List<StudentBO> list = new List<StudentBO>();
        private void dataGridSection_LoadDataGrid(object sender, EventArgs e)
        {
            //hanieh   
            if (activitySelector.ActivityStatus == true)
            {
                if (DataAccessNamespace.StudentDA.allActiveStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allActiveStudents = StudentBO.List(null, null, true);
                list = DataAccessNamespace.StudentDA.allActiveStudents;
            }
            else if (activitySelector.ActivityStatus == false)
            {
                if (DataAccessNamespace.StudentDA.allinActiveStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allinActiveStudents = StudentBO.List(null, null, false);
                list = DataAccessNamespace.StudentDA.allinActiveStudents;
            }
            else
            {
                if (DataAccessNamespace.StudentDA.allStudents.Count == 0)
                    DataAccessNamespace.StudentDA.allStudents = StudentBO.List();
                list = DataAccessNamespace.StudentDA.allStudents;
            }

 

            DataGridFiller<StudentBO>.FillDataGrid(dataGridSection, list ,
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Student.StudentID,
                    DatabaseSchema.Student.FirstName,
                    DatabaseSchema.Student.LastName,
                    DatabaseSchema.Student.FatherName,
                    //DatabaseSchema.Student.Job,  //hanih
                    DatabaseSchema.Student.TellHome,
                    DatabaseSchema.Student.CellPhone,
                    DatabaseSchema.Student.TellWork 
                });
        }

        static DataTable ConvertListToDataTable(List<StudentBO> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = list.Count;



            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
        private void DoNothing()
        {

        }
        StudentBO guiItem = new StudentBO();
        private StudentBO GetGUI()
        {

            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

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
                    DoNothing();//Do Nothing... //hanieh
                //err.Add("جنسیت");//hanieh
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
                    //err.Add("وضعیت تاهل");//hanieh
                    DoNothing();//Do Nothing...//hanie
                else
                    guiItem.MartialStatus = ComboFiller<MartialStatus>.GetFromCombo(cboMartialStatus).MartialStatusValue.Value;

                if (!cboAreaID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.AreaID = ComboFiller<AreaBO>.GetFromCombo(cboAreaID).AreaID;

                if (!txtAddressHome.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.AddressHome = UtilityTxt.GetString(txtAddressHome.Text);

                if (!txtTellHome.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.TellHome = UtilityTxt.GetString(txtTellHome.Text);

                if (!txtAddressWork.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.AddressWork = UtilityTxt.GetString(txtAddressWork.Text);

                if (!txtTellWork.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.TellWork = UtilityTxt.GetString(txtTellWork.Text);

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

                if (!txtSchoolName.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.SchoolName = UtilityTxt.GetString(txtSchoolName.Text);

                guiItem.ActivityStatus = chkActivityStatus.Checked;

                // ToDo: WidgetType havent Declared for Image. You should write code your self.
                //NotImplemented;
                guiItem.Image = picImage.Image;

                if (!txtUsername.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Username = UtilityTxt.GetString(txtUsername.Text);

                if (!txtPassword.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Password = UtilityTxt.GetString(txtPassword.Text);

                if (!txtParentUserName.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.ParentUserName = UtilityTxt.GetString(txtParentUserName.Text);

                if (!txtParentPassword.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.ParentPassword = UtilityTxt.GetString(txtParentPassword.Text);

                guiItem.BirthDate = txtBirthDate.Text;
                //if (!txtLastChangeID.Accepted)
                //    DoNothing();//Do Nothing...
                //else
                //    guiItem.LastChangeID = UtilityTxt.GetString(txtLastChangeID.Text);

                //if (!txtLastChangeDate.Accepted)
                //    DoNothing();//Do Nothing...
                //else
                //    guiItem.LastChangeDate = UtilityTxt.GetString(txtLastChangeDate.Text);

                //if (!txtLastChangeTime.Accepted)
                //    DoNothing();//Do Nothing...
                //else
                //    guiItem.LastChangeTime = UtilityTxt.GetString(txtLastChangeTime.Text);

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
        private StudentBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

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
        private void SetGUI(StudentBO guiItem)
        {
            this.guiItem = DataAccessNamespace.StudentDA.Find(guiItem.StudentID);
            //this.guiItem = guiItem;

            txtStudentID.Text = guiItem.StudentID;

            txtFirstName.Text = guiItem.FirstName;

            txtLastName.Text = guiItem.LastName;

            txtFatherName.Text = guiItem.FatherName;

            ComboFiller<Gender>.SetCombo(cboGender, new Gender(guiItem.Gender));

            txtCertificationNumber.Text = guiItem.CertificationNumber;

            txtNationalNumber.Text = UtilityTxt.GetString(guiItem.NationalNumber);


            txtBornPlace.Text = guiItem.BornPlace;

            txtBornProvince.Text = guiItem.BornProvince;

            txtBornCountry.Text = guiItem.BornCountry;

            txtIssuePlace.Text = guiItem.IssuePlace;

            ComboFiller<MartialStatus>.SetCombo(cboMartialStatus, new MartialStatus(guiItem.MartialStatus));

            ComboFiller<AreaBO>.SetCombo(cboAreaID, guiItem.AreaID.HasValue ? new AreaBO(guiItem.AreaID.Value) : null);

            txtAddressHome.Text = guiItem.AddressHome;

            txtTellHome.Text = guiItem.TellHome;

            txtAddressWork.Text = guiItem.AddressWork;

            txtTellWork.Text = guiItem.TellWork;

            txtCellPhone.Text = guiItem.CellPhone;

            ComboFiller<DegreeTypeBO>.SetCombo(cboDegreeTypeID, guiItem.DegreeTypeID.HasValue ? new DegreeTypeBO(guiItem.DegreeTypeID.Value) : null);

            ComboFiller<DegreeLevelBO>.SetCombo(cboDegreeLevelID, guiItem.DegreeLevelID.HasValue ? new DegreeLevelBO(guiItem.DegreeLevelID.Value) : null);

            txtStudyMajor.Text = guiItem.StudyMajor;

            chkStudyStatus.Checked = guiItem.StudyStatus;

            txtJob.Text = guiItem.Job;

            ComboFiller<HowtoFindBO>.SetCombo(cboHowtoFindID, guiItem.HowtoFindID.HasValue ? new HowtoFindBO(guiItem.HowtoFindID.Value) : null);

            txtSchoolName.Text = guiItem.SchoolName;

            chkActivityStatus.Checked = guiItem.ActivityStatus;

            picImage.Image = guiItem.Image;

            txtUsername.Text = guiItem.Username;

            txtPassword.Text = guiItem.Password;

            txtParentUserName.Text = guiItem.ParentUserName;

            txtParentPassword.Text = guiItem.ParentPassword;

            txtBirthDate.Text = guiItem.BirthDate;

            //txtLastChangeID.Text = guiItem.LastChangeID;

            //txtLastChangeDate.Text = guiItem.LastChangeDate;

            //txtLastChangeTime.Text = guiItem.LastChangeTime;

        }
        private new void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new StudentBO();

            txtStudentID.Text = StudentBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
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
            cboAreaID.SelectedItem = null;
            txtAddressHome.Text = "";
            txtTellHome.Text = "";
            txtAddressWork.Text = "";
            txtTellWork.Text = "";
            txtCellPhone.Text = "";
            cboDegreeTypeID.SelectedItem = null;
            cboDegreeLevelID.SelectedItem = null;
            txtStudyMajor.Text = "";
            chkStudyStatus.Checked = false;
            txtJob.Text = "";
            cboHowtoFindID.SelectedItem = null;
            txtSchoolName.Text = "";
            chkActivityStatus.Checked = false;
            picImage.Image = null;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtParentUserName.Text = "";
            txtParentPassword.Text = "";
            //txtLastChangeID.Text = "";
            //txtLastChangeDate.Text = "";
            //txtLastChangeTime.Text = "";


            //txtStudentID.Enabled = true;

        }
        private new void GotoUpdateMode()
        {
            base.GotoUpdateMode();

            //txtStudentID.Enabled = false;

        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((StudentBO)e.Row.Tag);
            GotoUpdateMode();
            ShowSuggestions();
        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
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
