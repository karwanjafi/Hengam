using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.ComboManager;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Hengam.Tools;
using Tools;
using FarsiMessageBox;
using Hengam.Forms.ItemPickers;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmClassManagerPrivate : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmClassManagerPrivate()
        {
            InitializeComponent();
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            var status = (ViwClassesPrivateBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;
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
                    var fPay = (frmStudentPayForClass)f;
                    fPay.Set(ClassBO.Find(classID), StudentBO.Find(txtStudentID.Text));
                    floaterStudentPicker.LoadPanel(fPay);
                    floaterStudentPicker.Show();
                }
            }
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            ClassBO item = GetGUIClass();
            if (item == null) return;
            
            RegistrationBO reg = GetGUIStudent();
            if (reg == null) return;
            
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!item.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات کلاسی به نام " + item.ClassName));
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کلاسی به نام " + item.ClassName));
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


            
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!reg.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات کلاسی "));
                    SetGUIClass(item);
                    SetGUIStudent(reg);
                    GotoUpdateMode();
                    ShowSuggestions();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کلاسی "));
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
            ClassBO item = GetGUIClass();
            if (item == null) return;

            RegistrationBO reg = GetGUIStudent();
            if (reg == null) return;

            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!item.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات کلاسی به نام " + item.ClassName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();

            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!reg.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات کلاسی "));
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
            ClassBO item = GetGUIKeyClass();
            if (item == null) return;

            RegistrationBO reg = GetGUIKeyStudent();
            if (reg == null) return;

                try
                {
                    SetMsg("در حال حذف کلاس...");
                    if (!reg.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        //Program.SetStatus(MessageCreator.Removed("مشخصات کلاسی ")); //hanieh
                        if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کلاس به نام " + item.ClassName), "", "حذف کلاس", true) == DialogResult.OK)
                        {
                            try
                            {
                                SetMsg("در حال حذف کلاس...");
                                if (!item.Delete())
                                    MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                                else
                                {
                                    Program.SetStatus(MessageCreator.Removed("مشخصات کلاسی به نام " + item.ClassName));
                                    GotoAddMode();
                                }
                            }
                            catch (System.Data.SqlClient.SqlException se)
                            {
                                switch (se.Number)
                                {
                                    case 547:
                                        MessageBoxEx.Show("شما قادر به حذف این کلاس نیستید. قبل از حذف باید تمامی اطلاعات این کلاس از سیستم حذف شود.");
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
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این کلاس نیستید. قبل از حذف باید تمامی اطلاعات این کلاس از سیستم حذف شود.");
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

            //-----edited by hanieh ---------------------
               /*
                if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کلاس به نام " + item.ClassName), "", "حذف کلاس", true) == DialogResult.OK)
                {
                    try
                    {
                        SetMsg("در حال حذف کلاس...");
                        if (!item.Delete())
                            MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                        else
                        {
                            Program.SetStatus(MessageCreator.Removed("مشخصات کلاسی به نام " + item.ClassName));
                            GotoAddMode();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException se)
                    {
                        switch (se.Number)
                        {
                            case 547:
                                MessageBoxEx.Show("شما قادر به حذف این کلاس نیستید. قبل از حذف باید تمامی اطلاعات این کلاس از سیستم حذف شود.");
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
                    
            }
            */
            //---------------end edit    
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionSessions(object sender, EventArgs e)
        {
            ClassBO item = GetGUIKeyClass();
            if (item == null) return;

            //hanieh-----
            //frmTeacherPayForClass fPay = (frmTeacherPayForClass)f;
            //fPay.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), TeacherBO.Find(txtTeacherID.Text));
            //floaterContainer.LoadPanel(fPay);
            //floaterContainer.Show();
            //-----------------

            Form session = FormRequester.ClassSessionScheduleSetter();
            //Program.MainForm.RunForm(session);
            if (session == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                return;
            }
            ((frmClassSessionScheduleSetter)session).Set(item); //hanieh
            pnlContainer.LoadPanel((frmClassSessionScheduleSetter)session);
            pnlContainer.Show();
            //((frmClassSessionScheduleSetter)session).Set(item);//hanieh

        }

        //Added By hanieh----------------------
        private void ActionActivate(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            var status = (ViwClassesPrivateBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;
            ClassBO cls = ClassBO.Find(classID);
            IActivityStatus act = (IActivityStatus)cls;

            try
            {
                SetMsg("در حال ثبت اطلاعات");
                if (act.SetStatus(true))
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات فعالیت "));
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات فعالیت "));
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

        private void ActionDeactivate(object sender, EventArgs e)
        {
            if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            var status = (ViwClassesPrivateBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            int classID = status.ClassID;
            ClassBO cls = ClassBO.Find(classID);
            IActivityStatus act = (IActivityStatus)cls;
            try
            {
                SetMsg("در حال ثبت اطلاعات");
                if (act.SetStatus(false))
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات فعالیت "));
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات فعالیت "));
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
        //--end add by hanieh-------------------------------------------

        private void DoNothing()
        {
        }
        frmTeacherPicker fTeacherPicker = new frmTeacherPicker();

        private void frmClassManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن کلاس", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف کلاس انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("دریافت شهریه", "MoneyMoney", "دریافت شهریه از هنرجو بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            if (Program.User.CanClassSessionScheduleSetter)
                AddButton("جلسات", "Schedule", "تنظیم جلسات کلاس", ActionSessions, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("فعال", "Activate", "فعال‌سازی سطر‌های انتخاب شده", ActionActivate, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("غیر‌فعال", "Deactivate", "غیر‌فعال‌سازی سطر‌های انتخاب شده", ActionDeactivate, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);

            ComboFiller<MajorBO>.FillCombo(cboMajorID, MajorBO.List());
            ComboFiller<ContractTypeBO>.FillCombo(cboContractTypeID, ContractTypeBO.List());

            
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string studentID = null;
            if (txtStudentID.Accepted) studentID = txtStudentID.Text;
            DataGridFiller<ViwClassesPrivateBO>.FillDataGrid(dataGridSection, ViwClassesPrivateBO.List(null, studentID, null, null, activitySelector.ActivityStatus),
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.ViwClassesPrivate.ClassName,
                    DatabaseSchema.ViwClassesPrivate.TeacherFirstName,
                    DatabaseSchema.ViwClassesPrivate.StudentFirstName,
                });
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            ViwClassesPrivateBO classPrivate = (ViwClassesPrivateBO)e.Row.Tag;
            ClassBO classObj = ClassBO.Find(classPrivate.ClassID);
            SetGUIClass(classObj);
            RegistrationBO reg = RegistrationBO.Find(classPrivate.ClassID, classPrivate.StudentID);
            SetGUIStudent(reg);
            GotoUpdateMode();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            //if (FormState == FormEditingState.Adding)
            floaterTeacherPicker.Show();
        }
        ClassBO guiItemClass = new ClassBO();
        private ClassBO GetGUIClass()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItemClass.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtClassName.Accepted)
                    err.Add("کلاس");
                else
                    guiItemClass.ClassName = UtilityTxt.GetString(txtClassName.Text);

                if (!cboMajorID.Accepted)
                    err.Add("رشته");
                else
                    guiItemClass.MajorID = ComboFiller<MajorBO>.GetFromCombo(cboMajorID).MajorID;

                if (!cboContractTypeID.Accepted)
                    err.Add("نوع قرارداد");
                else
                    guiItemClass.ContractTypeID = ComboFiller<ContractTypeBO>.GetFromCombo(cboContractTypeID).ContractTypeID;

                if (!txtContractValue.Accepted)
                    err.Add("مبلغ");
                else
                    guiItemClass.ContractValue = UtilityTxt.GetInt(txtContractValue.Text);

                if (!txtTeacherID.Accepted)
                    err.Add("استاد");
                else
                    guiItemClass.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

                if (!txtPrice.Accepted)
                    err.Add("قیمت");
                else
                    guiItemClass.Price = UtilityTxt.GetInt(txtPrice.Text);

                if (!txtSchoolPrice.Accepted)
                    err.Add("سهم موسسه");
                else
                    guiItemClass.SchoolPrice = UtilityTxt.GetInt(txtSchoolPrice.Text);

                if (!txtSessionCount.Accepted)
                    err.Add("تعداد جلسات");
                else
                    guiItemClass.SessionCount = UtilityTxt.GetInt(txtSessionCount.Text);

                if (!txtClassDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemClass.ClassDescription = UtilityTxt.GetString(txtClassDescription.Text);

                guiItemClass.GroupFlag = chkGroupFlag.Checked;

                if (!txtRegistrationExpireDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemClass.RegistrationExpireDate = UtilityTxt.GetString(txtRegistrationExpireDate.Text);

                guiItemClass.ActivityStatus = chkActivityStatus.Checked;


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
            return guiItemClass;
        }

        private ClassBO GetGUIKeyClass()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItemClass.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                guiItemClass.ClassName = txtClassName.Text;

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
            return guiItemClass;
        }
        private void SetGUIClass(ClassBO guiItem)
        {
            this.guiItemClass = guiItem;
            txtClassID.Text = guiItem.ClassID.ToString();

            txtClassName.Text = guiItem.ClassName;

            ComboFiller<MajorBO>.SetCombo(cboMajorID, Utility.GetObject<MajorBO>(guiItem.MajorID));

            txtTeacherID.Text = guiItem.TeacherID;
            txtTeacherName.Text = guiItem.RelTeacher.FullName;

            txtPrice.Text = guiItem.Price.ToString();

            txtSchoolPrice.Text = UtilityTxt.GetString(guiItem.SchoolPrice);

            txtSessionCount.Text = UtilityTxt.GetString(guiItem.SessionCount);

            txtClassDescription.Text = guiItem.ClassDescription;

            chkGroupFlag.Checked = guiItem.GroupFlag;


            chkActivityStatus.Checked = guiItem.ActivityStatus;

            ComboFiller<ContractTypeBO>.SetCombo(cboContractTypeID, Utility.GetObject<ContractTypeBO>(guiItem.ContractTypeID));

            txtContractValue.Text = UtilityTxt.GetString(guiItem.ContractValue);

        }

        private RegistrationBO GetGUIStudent()
        {
            //RegistrationBO guiItemStudent = null;
            // guiItemStudent is global now.
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItemStudent.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItemStudent.StudentID = UtilityTxt.GetString(txtStudentID.Text);

                if (!txtRegistrationDate.Accepted)
                    err.Add("تاریخ ثبت نام");
                else
                    guiItemStudent.RegistrationDate = UtilityTxt.GetString(txtRegistrationDate.Text);

                //guiItemStudent.ActivityStatus = chkActivityStatus.Checked;

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
            return guiItemStudent;
        }
        private RegistrationBO GetGUIKeyStudent()
        {
            //RegistrationBO guiItemStudent = null;
            // guiItemStudent is global now.
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItemStudent.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجویی");
                else
                    guiItemStudent.StudentID = UtilityTxt.GetString(txtStudentID.Text);

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
            return guiItemStudent;
        }
        private void SetGUIStudent(RegistrationBO guiItem)
        {
            //txtClassID.Text = UtilityTxt.GetString(guiItem.ClassID);
            //txtClassName.Text = UtilityTxt.GetString(guiItem.RelClass.ClassName);

            txtStudentID.Text = guiItem.StudentID;
            txtStudentName.Text = guiItem.RelStudent.FullName;
            txtRegistrationDate.Text = guiItem.RegistrationDate;

            //chkActivityStatus.Checked = guiItem.ActivityStatus;
            this.guiItemStudent = guiItem;


        }
        RegistrationBO guiItemStudent = null;
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            txtClassID.Text = ClassBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
            txtClassName.Text = "";
            cboMajorID.SelectedItem = null;
            txtTeacherID.Text = "";
            txtTeacherName.Text = "";
            txtPrice.Text = "";
            txtSchoolPrice.Text = "";
            txtSessionCount.Text = "12"; //hanieh
            txtClassDescription.Text = "";
            chkGroupFlag.Checked = false;
            chkActivityStatus.Checked = true;

            //txtStudentID.Text = "";
            //txtStudentName.Text = "";
            txtRegistrationDate.Text = FaDate.CurrentFaDateString;

            cboContractTypeID.SelectedItem = null;
            txtContractValue.Text = "";

            txtRegistrationExpireDate.Text = FaDate.CurrentFaDateString;

            txtClassName.Enabled = true;
            txtStudentName.Enabled = true;

            guiItemStudent = new RegistrationBO();
            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtClassName.Enabled = false;
            txtStudentName.Enabled = false;
            ShowSuggestions();
            //EditingState = FormState.Updating;
        }

        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {
            if (txtTeacherID.Text != "")
            {
                TeacherBO teacher = TeacherBO.Find(txtTeacherID.Text);
                if (teacher != null)
                {
                    ComboFiller<ContractTypeBO>.SetCombo(cboContractTypeID, new ContractTypeBO(teacher.ContractTypeID));
                    txtContractValue.Text = teacher.ContractValue.ToString();
                }
            }
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            if ( FormState == FormEditingState.Adding )floaterStudentPicker.Show();
        }

        private void SetClassName(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "" || txtTeacherName.Text == "" || cboMajorID.SelectedItem == null)
                txtClassName.Text = "";
            else
                txtClassName.Text = txtStudentName.Text + ", " + txtTeacherName.Text + ", " +
                                    ((MajorBO) cboMajorID.SelectedItem).MajorName;

            
        }

        public void SetConstantFee()
        {
            if (txtPrice.Accepted && txtSchoolPrice.Accepted)
            {
                txtCalcConstantFee.Text = (UtilityTxt.GetInt(txtPrice.Text) - UtilityTxt.GetInt(txtSchoolPrice.Text)).ToString();
            }
        }

        private void txtSchoolPrice_TextChanged(object sender, EventArgs e)
        {
            SetTotalPrice();
        }


        public void SetTotalPrice()
        {
            if (txtCalcConstantFee.Accepted && txtSchoolPrice.Accepted)
            {
                txtPrice.Text = (UtilityTxt.GetInt(txtCalcConstantFee.Text) + UtilityTxt.GetInt(txtSchoolPrice.Text)).ToString();
            }
        }

        private void txtCalcConstantFee_TextChanged(object sender, EventArgs e)
        {
            SetTotalPrice();
        }

        private void cboMajorID_SelectedValueChanged(object sender, EventArgs e)
        {
            MajorBO major = ComboFiller<MajorBO>.GetFromCombo(cboMajorID);
            fTeacherPicker.Set(major);
            SetClassName(sender, e);
        }

        public void Set(StudentBO student, ClassBO cls)
        {
            if (student != null)
            {
                txtStudentID.Text = student.StudentID;
                txtStudentName.Text = student.FullName;
            }
            if (cls != null)
            {
                txtClassID.Text = UtilityTxt.GetString(cls.ClassID);
                txtClassName.Text = cls.ClassName;
            }
        }

        public enum ShowModeEnum
        {
            ShowStudents,
            ShowClasses
        }

        public ShowModeEnum ShowMode = ShowModeEnum.ShowStudents;


        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void activitySelector_StatusChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

    }
}
