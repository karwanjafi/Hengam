using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.ComboManager;
using BusinessObjectNamespace;
using DatabaseSchemaNamespace;
using Hengam.Forms.ItemPickers;
using Hengam.Tools;
using FarsiMessageBox;
using DataGridFiller;
using Tools;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmMajorTeacherManager : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmMajorTeacherManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            MajorTeacherBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات استادی به نام " + item.RelTeacher.FullName));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات استادی به نام " + item.RelTeacher.FullName));
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
            MajorTeacherBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات استادی به نام " + item.RelTeacher.FullName));
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
            MajorTeacherBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات استاد به نام " + item.RelTeacher.FullName), "", "حذف استاد", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف استاد...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات استادی به نام " + item.RelTeacher.FullName));
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
                dataGridSection.RefreshDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void frmMajorTeacherManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن استاد", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف استاد انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<MajorBO>.FillCombo(cboMajorID, MajorBO.List(true));

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        private void LoadDataGrid()
        {
            string teacherID = null;
            if (txtTeacherID.Accepted) teacherID = txtTeacherID.Text;

            DataGridFiller<MajorTeacherBO>.FillDataGrid(dataGridSection, MajorTeacherBO.List(null, teacherID, null),
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Teacher.FirstName,
                    //DatabaseSchema.Teacher.LastName,
                    DatabaseSchema.Major.MajorName,
                    DatabaseSchema.MajorTeacher.SpecialMajorFlag
                });

        }

        private void dataGridSection_LoadDataGrid(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void DoNothing()
        {

        }

        MajorTeacherBO guiItem = new MajorTeacherBO();
        private MajorTeacherBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!cboMajorID.Accepted)
                    err.Add("کد رشته");
                else
                    guiItem.MajorID = ComboFiller<MajorBO>.GetFromCombo(cboMajorID).MajorID;

                if (!txtTeacherID.Accepted)
                    err.Add("کد استاد");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

                guiItem.SpecialMajorFlag = chkSpecialMajorFlag.Checked;

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
        private MajorTeacherBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!cboMajorID.Accepted)
                    err.Add("کد رشته");
                else
                    guiItem.MajorID = ComboFiller<MajorBO>.GetFromCombo(cboMajorID).MajorID;

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
        private void SetGUI(MajorTeacherBO guiItem)
        {
            this.guiItem = guiItem;
            ComboFiller<MajorBO>.SetCombo(cboMajorID, Utility.GetObject<MajorBO>(guiItem.MajorID));

            txtTeacherID.Text = guiItem.TeacherID;
            txtTeacherName.Text = guiItem.RelTeacher.FullName;

            chkSpecialMajorFlag.Checked = guiItem.SpecialMajorFlag;

        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new MajorTeacherBO();
            cboMajorID.SelectedItem = null;
            //txtTeacherID.Text = "";
            chkSpecialMajorFlag.Checked = false;

            //txtTeacherName.Text = "";

            cboMajorID.Enabled = true;
            txtTeacherID.Enabled = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();

            cboMajorID.Enabled = false;
            txtTeacherID.Enabled = false;

            //EditingState = FormState.Updating;
        }


        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((MajorTeacherBO)e.Row.Tag);
            GotoUpdateMode();
        }

        private void txtGurarantorName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding)
                floaterTeacherPicker.Show();
        }

        public void Set(TeacherBO teahcer)
        {
            txtTeacherID.Text = teahcer.TeacherID;
            txtTeacherName.Text = teahcer.FullName;
        }

        public void Set(string teacherID)
        {
            TeacherBO teacher = TeacherBO.Find(teacherID);
            Set(teacher);
        }

        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion
    }
}
