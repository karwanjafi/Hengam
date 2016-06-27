using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemPickers;
using BusinessObjectNamespace;
using Hengam.Tools;
using Tools;
using DataGridFiller;
using DatabaseSchemaNamespace;
using StandardWidgets;
using FarsiMessageBox;
using Hengam.Reports;
using Hengam.Reports.ReportForms;

namespace Hengam.Forms
{
    public partial class frmStudentRegisterationManager : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmStudentRegisterationManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            RegistrationBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات ثبت نام هنرجویی به نام " + item.RelStudent.FullName));
                    //GotoUpdateMode();
                    ShowSuggestions();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات ثبت نام هنرجویی به نام " + item.RelStudent.FullName));
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

        private void LoadDataGrid()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            RegistrationBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات ثبت نام هنرجویی به نام " + item.RelStudent.FullName));
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
            RegistrationBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات ثبت نام هنرجویی به نام " + item.RelStudent.FullName), "", "حذف ثبت نام هنرجو", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف ثبت نام هنرجو...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات ثبت نام هنرجویی به نام " + item.RelStudent.FullName));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این ثبت نام هنرجو نیستید. قبل از حذف باید تمامی اطلاعات این ثبت نام هنرجو از سیستم حذف شود.");
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

        private void ActionPrintFactor(object sender, EventArgs e)
        {
            RegistrationBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال بازیابی...");
                Form fReport = ReportFiller.GetReportForm((CrystalDecisions.CrystalReports.Engine.ReportClass)ReportFiller.ReportRegisterationStudentFactor(item.StudentID, item.ClassID, ""), "رسید ثبت نام");
                //Program.MainForm.RunForm(fReport);
                floaterContainer.LoadPanel((frmReportViewer)fReport);
                floaterContainer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
        }

        private void ActionStudentPayForClass(object sender, EventArgs e)
        {
            RegistrationBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال بازیابی...");
                Form f = FormRequester.StudentPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                }
                else
                {
                    frmStudentPayForClass fStudentPayForClass = (frmStudentPayForClass)f;
                    fStudentPayForClass.Set(item.RelClass, item.RelStudent);
                    //Program.MainForm.RunForm(fStudentPayForClass);
                    floaterContainer.LoadPanel(fStudentPayForClass);
                    floaterContainer.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
        }

        private void frmStudentRegisterationManager_LoadForm(object sender, EventArgs e)
        {
            AddButton("ثبت نام", "Add", "ثبت نام هنرجو در کلاس مشخص شده", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف ثبت نام هنرجوی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            
            if (Program.User.CanStudentPayForClass)
                AddButton("شهریه", "Money", "دریافت شهریه از هنرجو بابت ثبت نام در کلاس", ActionStudentPayForClass, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("رسید", "Printer", "چاپ برگه‌ی ثبت‌نام", ActionPrintFactor, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);

            //AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            //AddButton("حذف", "Delete", "حذف ثبت نام هنرجوی انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            //AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);

            frmClassPicker fClassPicker = new frmClassPicker();
            fClassPicker.GroupFlag = true;
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            dataGridSection.RefreshDataGrid();
        }

        RegistrationBO guiItem = new RegistrationBO();

        private RegistrationBO GetGUI()
        {
            // guiItem is global now.
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

                if (!txtRegistrationDate.Accepted)
                    err.Add("تاریخ ثبت نام");
                else
                    guiItem.RegistrationDate = UtilityTxt.GetString(txtRegistrationDate.Text);

                //guiItem.ActivityStatus = chkActivityStatus.Checked;

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
        private RegistrationBO GetGUIKey()
        {
            // guiItem is global now.
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

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
        private void SetGUI(RegistrationBO guiItem)
        {
            this.guiItem = guiItem;
            txtClassID.Text = UtilityTxt.GetString(guiItem.ClassID);
            txtClassName.Text = UtilityTxt.GetString(guiItem.RelClass.ClassName);

            txtStudentID.Text = guiItem.StudentID;
            txtStudentName.Text = guiItem.RelStudent.FullName;
            txtRegistrationDate.Text = guiItem.RegistrationDate;

            //chkActivityStatus.Checked = guiItem.ActivityStatus;
            


        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new RegistrationBO();
            guiItem.ActivityStatus = true;
            
            txtClassID.Text = "";
            txtStudentID.Text = "";

            txtClassName.Text = "";
            txtStudentName.Text = "";

            txtRegistrationDate.Text = FaDate.CurrentFaDateString;

            txtClassID.Enabled = true;
            txtStudentID.Enabled = true;

            txtClassName.Enabled = true;
            txtStudentName.Enabled = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtClassID.Enabled = false;
            txtStudentID.Enabled = false;

            txtClassName.Enabled = false;
            txtStudentName.Enabled = false;

            //EditingState = FormState.Updating;
        }

        public enum ShowModeEnum
        {
            ShowStudents,
            ShowClasses
        }

        public ShowModeEnum ShowMode = ShowModeEnum.ShowStudents;

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            int? classID = null;
            string studentID = null;
            bool activityStatus = true;

            if (!txtStudentID.Accepted && !txtClassID.Accepted) return;
            
            if (txtStudentID.Accepted) studentID = txtStudentID.Text;
            if (txtClassID.Accepted) classID = UtilityTxt.GetInt(txtClassID.Text);

            List<ColumnDefinition> showCols;
            List<RegistrationBO> list;

            if (ShowMode == ShowModeEnum.ShowStudents)
            {
                showCols = new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    DatabaseSchema.Student.FirstName,
                    DatabaseSchema.Registration.RegistrationDate,
                    DatabaseSchema.Class.ClassName,
                    DatabaseSchema.Teacher.TeacherID
                };
                list = RegistrationBO.List(classID, null, activityStatus, null);
            }
            else
            {
                showCols = new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    DatabaseSchema.Class.ClassName,
                    DatabaseSchema.Teacher.FirstName,
                    DatabaseSchema.Registration.RegistrationDate
                };
                list = RegistrationBO.List(null, studentID, activityStatus, null);
            }
            DataGridFiller<RegistrationBO>.FillDataGrid(dataGridSection, list, showCols);
        }

        private void txtStudentID_TextAccepted(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }


        public void SetStudent(string studentID)
        {
            GotoAddMode();
            StudentBO student = StudentBO.Find(studentID);
            txtStudentID.Text = student.StudentID;
            txtStudentName.Text = student.FullName;
        }

        public void SetClass(int classID)
        {
            GotoAddMode();
            ClassBO classObj = ClassBO.Find(classID);
            txtClassID.Text = classObj.ClassID.ToString();
            txtClassName.Text = classObj.ClassName;
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater { get; set; }

        #endregion

        private void dataGridSection_RowDoubleClick(CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((RegistrationBO)e.Row.Tag);
            GotoUpdateMode();
            ShowSuggestions();
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding && ShowMode == ShowModeEnum.ShowStudents)
                floaterStudentPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding && ShowMode == ShowModeEnum.ShowClasses)
                floaterClassPicker.Show();
        }
    }
}
