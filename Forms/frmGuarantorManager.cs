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
    public partial class frmGuarantorManager : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmGuarantorManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            GuarantorBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات ضامنی به نام " + item.FullName));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات ضامنی به نام " + item.FullName));
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
            GuarantorBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات ضامنی به نام " + item.FullName));
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
            GuarantorBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات ضامنی به نام " + item.FullName), "", "حذف ضامن", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف ضامن...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات ضامنی به نام " + item.FullName));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این ضامن نیستید. قبل از حذف باید تمامی اطلاعات این ضامن از سیستم حذف شود.");
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


        private void frmStudentManager_LoadForm(object sender, EventArgs e)
        {
            //dataGridSection.OnLoadDataGrid += dataGridSection_LoadDataGrid;
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن ضامن", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف ضامن انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            ComboFiller<DegreeLevelBO>.FillCombo(cboDegreeLevelID, DegreeLevelBO.List());
            ComboFiller<Gender>.FillCombo(cboGender, Gender.List());
            ComboFiller<MartialStatus>.FillCombo(cboMartialStatus, MartialStatus.List());

            
            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        private void LoadDataGrid()
        {
            //hanieh
            if (DataAccessNamespace.GuarantorDA.allguarantor.Count == 0)
                DataAccessNamespace.GuarantorDA.allguarantor = GuarantorBO.List();
            //

            DataGridFiller<GuarantorBO>.FillDataGrid(dataGridSection, DataAccessNamespace.GuarantorDA.allguarantor,
                new List<ColumnDefinition>
                {    
                    DatabaseSchema.Guarantor.GuarantorID,
                    DatabaseSchema.Guarantor.FirstName,
                    DatabaseSchema.Guarantor.LastName,
                    DatabaseSchema.Guarantor.FatherName,
                    DatabaseSchema.Guarantor.Guarantee
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
        GuarantorBO guiItem = new GuarantorBO();
        private GuarantorBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtGuarantorID.Accepted)
                    err.Add("کد ضامن");
                else
                    guiItem.GuarantorID = UtilityTxt.GetString(txtGuarantorID.Text);

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


                if (!txtBornPlace.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.BornPlace = UtilityTxt.GetString(txtBornPlace.Text);

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

                if (!txtJob.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Job = UtilityTxt.GetString(txtJob.Text);

                if (!cboDegreeLevelID.Accepted)
                    err.Add("سطح تحصیلات");
                else
                    guiItem.DegreeLevelID = ComboFiller<DegreeLevelBO>.GetFromCombo(cboDegreeLevelID).DegreeLevelID;

                if (!txtStudyMajor.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.StudyMajor = UtilityTxt.GetString(txtStudyMajor.Text);

                if (!txtGuarantee.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Guarantee = UtilityTxt.GetString(txtGuarantee.Text);

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
        private GuarantorBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtGuarantorID.Accepted)
                    err.Add("کد ضامن");
                else
                    guiItem.GuarantorID = UtilityTxt.GetString(txtGuarantorID.Text);

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
        private void SetGUI(GuarantorBO guiItem)
        {
            this.guiItem = guiItem;
            txtGuarantorID.Text = guiItem.GuarantorID;

            txtFirstName.Text = guiItem.FirstName;

            txtLastName.Text = guiItem.LastName;

            txtFatherName.Text = guiItem.FatherName;

            ComboFiller<Gender>.SetCombo(cboGender, Utility.GetObject<Gender>(guiItem.Gender));

            txtCertificationNumber.Text = guiItem.CertificationNumber;

            txtNationalNumber.Text = guiItem.NationalNumber;


            txtBornPlace.Text = guiItem.BornPlace;

            txtIssuePlace.Text = guiItem.IssuePlace;

            ComboFiller<MartialStatus>.SetCombo(cboMartialStatus, Utility.GetObject<MartialStatus>(guiItem.MartialStatus));

            txtHomeAddress.Text = guiItem.HomeAddress;

            txtHomeTell.Text = guiItem.HomeTell;

            txtWorkAddress.Text = guiItem.WorkAddress;

            txtWorkTell.Text = guiItem.WorkTell;

            txtCellPhone.Text = guiItem.CellPhone;

            txtJob.Text = guiItem.Job;

            ComboFiller<DegreeLevelBO>.SetCombo(cboDegreeLevelID, Utility.GetObject<DegreeLevelBO>(guiItem.DegreeLevelID));

            txtStudyMajor.Text = guiItem.StudyMajor;

            txtGuarantee.Text = guiItem.Guarantee;

            picImage.Image = guiItem.Image;

        }
        private new void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new GuarantorBO();
            txtGuarantorID.Text = GuarantorBO.GenerateKey(FaDate.Now.Year, FaDate.Now.Month);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            cboGender.SelectedItem = null;
            txtCertificationNumber.Text = "";
            txtNationalNumber.Text = "";
            txtBornPlace.Text = "";
            txtIssuePlace.Text = "";
            cboMartialStatus.SelectedItem = null;
            txtHomeAddress.Text = "";
            txtHomeTell.Text = "";
            txtWorkAddress.Text = "";
            txtWorkTell.Text = "";
            txtCellPhone.Text = "";
            txtJob.Text = "";
            cboDegreeLevelID.SelectedItem = null;
            txtStudyMajor.Text = "";
            txtGuarantee.Text = "";
            picImage.Image = null;


        }
        private new void GotoUpdateMode()
        {
            base.GotoUpdateMode();
        }

        
        #endregion


        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((GuarantorBO)e.Row.Tag);
            GotoUpdateMode();
        }




        //private void txtStudentID_Leave(object sender, EventArgs e)
        //{
        //    coolLabel1.Text = txtStudentID.Text;
        //}

        //private void frmStudentManager_Load(object sender, EventArgs e)
        //{
        //}

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion
    }
}
