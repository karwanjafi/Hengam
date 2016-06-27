﻿using System;
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

namespace Hengam.Forms
{
    public partial class frmClassManager : HengamWidgets.FormBaseTableEditor
    {
        public frmClassManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            ClassBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات کلاسی به نام " + item.ClassName));
                    GotoAddMode();
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
            dataGridSection.RefreshDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            ClassBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات کلاسی به نام " + item.ClassName));
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
            ClassBO item = GetGUIKey();
            if (item == null) return;
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
                dataGridSection.RefreshDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void DoNothing()
        {
        }

        private void frmClassManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن کلاس", ActionAdd, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف کلاس انتخاب شده از سیستم", ActionDelete, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<MajorBO>.FillCombo(cboMajorID, MajorBO.List());
            ComboFiller<ContractTypeBO>.FillCombo(cboContractTypeID, ContractTypeBO.List());

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            //hanieh
            if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                DataAccessNamespace.ClassDA.allclasses = ClassBO.List();
            //
            DataGridFiller<ClassBO>.FillDataGrid(dataGridSection, DataAccessNamespace.ClassDA.allclasses,
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Class.ClassID,
                    //DatabaseSchema.Teacher.LastName,
                    DatabaseSchema.Class.ClassName,
                    DatabaseSchema.Major.MajorName,
                    DatabaseSchema.Teacher.FirstName,
                });
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((ClassBO)e.Row.Tag);
            GotoUpdateMode();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            //if (FormState == FormEditingState.Adding)
            floaterTeacherPicker.Show();
        }

        ClassBO guiItem = new ClassBO();
        private ClassBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtClassName.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassName = UtilityTxt.GetString(txtClassName.Text);

                if (!cboMajorID.Accepted)
                    err.Add("رشته");
                else
                    guiItem.MajorID = ComboFiller<MajorBO>.GetFromCombo(cboMajorID).MajorID;

                if (!cboContractTypeID.Accepted)
                    err.Add("نوع قرارداد");
                else
                    guiItem.ContractTypeID = ComboFiller<ContractTypeBO>.GetFromCombo(cboContractTypeID).ContractTypeID;

                if (!txtContractValue.Accepted)
                    err.Add("مبلغ");
                else
                    guiItem.ContractValue = UtilityTxt.GetInt(txtContractValue.Text);

                if (!txtTeacherID.Accepted)
                    err.Add("استاد");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

                if (!txtPrice.Accepted)
                    err.Add("قیمت");
                else
                    guiItem.Price = UtilityTxt.GetInt(txtPrice.Text);

                if (!txtSchoolPrice.Accepted)
                    err.Add("سهم موسسه");
                else
                    guiItem.SchoolPrice = UtilityTxt.GetInt(txtSchoolPrice.Text);

                if (!txtSessionCount.Accepted)
                    err.Add("تعداد جلسات");
                else
                    guiItem.SessionCount = UtilityTxt.GetInt(txtSessionCount.Text);

                if (!txtClassDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.ClassDescription = UtilityTxt.GetString(txtClassDescription.Text);

                guiItem.GroupFlag = chkGroupFlag.Checked;

                if (!txtRegistrationExpireDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.RegistrationExpireDate = UtilityTxt.GetString(txtRegistrationExpireDate.Text);

                guiItem.ActivityStatus = chkActivityStatus.Checked;


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

        
        private ClassBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کد کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                guiItem.ClassName = txtClassName.Text;

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
        private void SetGUI(ClassBO guiItem)
        {
            this.guiItem = guiItem;
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
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new ClassBO();

            txtClassID.Text = ClassBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
            txtClassName.Text = "";
            cboMajorID.SelectedItem = null;
            txtTeacherID.Text = "";
            txtTeacherName.Text = "";
            txtPrice.Text = "";
            txtSchoolPrice.Text = "";
            txtSessionCount.Text = "";
            txtClassDescription.Text = "";
            chkGroupFlag.Checked = false;
            chkActivityStatus.Checked = false;

            cboContractTypeID.SelectedItem = null;
            txtContractValue.Text = "";

            txtClassID.Enabled = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtClassID.Enabled = false;

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

    }
}
