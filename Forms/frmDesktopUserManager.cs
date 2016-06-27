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
using FarsiMessageBox;
using Hengam.Tools;
using Tools;
using Hengam.Forms.ItemPickers;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmDesktopUserManager : HengamWidgets.FormBaseTableEditor
    {
        public frmDesktopUserManager()
        {
            InitializeComponent();
        }

                private void ActionAdd(object sender, EventArgs e)
        {
            DesktopUsersBO user = GetGUI();
            if (user == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!user.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات کاربری به نام " + user.Username));
                    SetGUI(user);
                    GotoUpdateMode();
                    ShowSuggestions();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کاربری به نام " + user.Username));
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
            DesktopUsersBO user = GetGUI();
            if (user == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!user.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات کاربری به نام " + user.Username));
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
            DesktopUsersBO user = GetGUIKey();
            if (user == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات کاربری به نام " + user.Username), "", "حذف کاربر", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف کاربر...");
                    if (!user.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات کاربر به نام " + user.Username));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این کاربر نیستید. قبل از حذف باید تمامی اطلاعات این کاربر از سیستم حذف شود.");
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

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<DesktopUsersBO>.FillDataGrid(dataGridSection, DesktopUsersBO.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.DesktopUsers.Username,
                DatabaseSchema.DesktopUsers.EmployeeID,
                DatabaseSchema.DesktopUsers.LastLoginDate,
                DatabaseSchema.DesktopUsers.LastLoginTime
            });
        }

        private void frmDesktopUserManager_LoadForm(object sender, EventArgs e)
        {
            AddButton("اضافه کردن", "Add", "اضافه کردن کاربر", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف کاربر انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            frmEmployeePicker fEmployeePicker =  new frmEmployeePicker();
            floaterEmployeePicker.LoadPanel(fEmployeePicker);
            fEmployeePicker.HookTo(txtEmployeeID, txtEmployeeName);

            dataGridSection.RefreshDataGrid();
        }


        DesktopUsersBO guiItem = new DesktopUsersBO();
        private DesktopUsersBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtUsername.Accepted)
                    err.Add("نام کاربری");
                else
                    guiItem.Username = UtilityTxt.GetString(txtUsername.Text);

                if (!txtPassword.Accepted)
                    err.Add("رمز عبور");
                else
                    guiItem.Password = UtilityTxt.GetString(txtPassword.Text);

                

                if (!txtEmployeeID.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.EmployeeID = UtilityTxt.GetString(txtEmployeeID.Text);

                guiItem.CanStudentManager = chkCanStudentManager.Checked;

                guiItem.CanStudentRegisterationManager = chkCanStudentRegisterationManager.Checked;

                guiItem.CanStudentInformationReport = chkCanStudentInformationReport.Checked;

                guiItem.CanStudentPayForClass = chkCanStudentPayForClass.Checked;

                guiItem.CanStudentSessionDetails = chkCanStudentSessionDetails.Checked;

                guiItem.CanStudentFinancialDetails = chkCanStudentFinancialDetails.Checked;

                guiItem.CanStudentFinancialStatus = chkCanStudentFinancialStatus.Checked;

                guiItem.CanStudentClassBalance = chkCanStudentClassBalance.Checked;

                guiItem.CanStudentAffairs = chkCanStudentAffairs.Checked;

                guiItem.CanTeacherFinancialStatus = chkCanTeacherFinancialStatus.Checked;

                guiItem.CanTeacherFinancialDetails = chkCanTeacherFinancialDetails.Checked;

                guiItem.CanTeacherSessionDetails = chkCanTeacherSessionDetails.Checked;

                guiItem.CanTeacherManager = chkCanTeacherManager.Checked;

                guiItem.CanMajorTeacherManager = chkCanMajorTeacherManager.Checked;

                guiItem.CanTeacherClassBalance = chkCanTeacherClassBalance.Checked;

                guiItem.CanTeacherPayForClass = chkCanTeacherPayForClass.Checked;

                guiItem.CanTeacherTimeSelector = chkCanTeacherTimeSelector.Checked;

                guiItem.CanClassSessionStatusSetter = chkCanClassSessionStatusSetter.Checked;

                guiItem.CanClassSessionScheduleSetter = chkCanClassSessionScheduleSetter.Checked;

                guiItem.CanClassManagerPrivate = chkCanClassManagerPrivate.Checked;

                guiItem.CanClassManagerPublic = chkCanClassManagerPublic.Checked;

                guiItem.CanClassDailyStatus = chkCanClassDailyStatus.Checked;

                guiItem.CanPresenceManager = chkCanPresenceManager.Checked;

                guiItem.CanTimeManager = chkCanTimeManager.Checked;

                guiItem.CanEmployeeManager = chkCanEmployeeManager.Checked;

                guiItem.CanEmployeeSalary = chkCanEmployeeSalary.Checked;

                guiItem.CanComboManager = chkCanComboManager.Checked;

                guiItem.CanActivityManager = chkCanActivityManager.Checked;

                guiItem.CanDBSettings = chkCanDBSettings.Checked;

                guiItem.CanGuarantorManager = chkCanGuarantorManager.Checked;

                guiItem.CanSchoolSpecification = chkCanSchoolSpecification.Checked;

                guiItem.CanDesktopUsers = chkCanDesktopUsers.Checked;

                guiItem.CanOutcomeManager = chkCanOutcomeManager.Checked;

                guiItem.CanIncomeManager = chkCanIncomeManager.Checked;

                guiItem.CanSynchDatabase = chkCanSynchDatabase.Checked;

                guiItem.CanStoreStuffAvailableViewer = chkCanStoreStuffAvailableViewer.Checked;

                guiItem.CanStoreStuffTypeManager = chkCanStoreStuffTypeManager.Checked;

                guiItem.CanStoreStuffBuyManager = chkCanStoreStuffBuyManager.Checked;

                guiItem.CanStoreStuffSellItemManager = chkCanStoreStuffSellItemManager.Checked;

                guiItem.CanStoreShopHistoryViewer = chkCanStoreShopHistoryViewer.Checked;

                guiItem.CanStoreAffairs = chkCanStoreAffairs.Checked;

                guiItem.CanStoreStuffSellItem = chkCanStoreStuffSellItem.Checked;

                guiItem.CanStoreSalesTracking = chkCanStoreSalesTracking.Checked;

                guiItem.CanReportStudentListOfMajor = chkCanReportStudentListOfMajor.Checked;

                guiItem.CanReportPaysOfTeacherInterval = chkCanReportPaysOfTeacherInterval.Checked;

                guiItem.CanReportSessionsOfTeacherInterval = chkCanReportSessionsOfTeacherInterval.Checked;

                guiItem.CanReportClassesOfTeacherInterval = chkCanReportClassesOfTeacherInterval.Checked;

                guiItem.CanReportMinistryReport = chkCanReportMinistryReport.Checked;

                guiItem.CanReportStudentPayFactor = chkCanReportStudentPayFactor.Checked;

                guiItem.CanReportTypicalOutcomeYear = chkCanReportTypicalOutcomeYear.Checked;

                guiItem.CanReportIncomeInterval = chkCanReportIncomeInterval.Checked;

                guiItem.CanReportRegisteredStudentsPerEmployee = chkCanReportRegisteredStudentsPerEmployee.Checked;

                guiItem.CanReportTeacherPayFactor = chkCanReportTeacherPayFactor.Checked;

                guiItem.CanReportEmployeePayFactor = chkCanReportEmployeePayFactor.Checked;

                guiItem.CanReportStudentOfPublicClass = chkCanReportStudentOfPublicClass.Checked;

                guiItem.CanReportAffairs = chkCanReportAffairs.Checked;

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
        private DesktopUsersBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtUsername.Accepted)
                    err.Add("نام کاربری");
                else
                    guiItem.Username = UtilityTxt.GetString(txtUsername.Text);

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
        private void SetGUI(DesktopUsersBO guiItem)
        {
            this.guiItem = guiItem;

            txtUsername.Text = guiItem.Username;

            txtPassword.Text = guiItem.Password;

            txtEmployeeID.Text = guiItem.EmployeeID;

            txtEmployeeName.Text = guiItem.RelEmployee == null ? "": guiItem.RelEmployee.FullName;

            chkCanStudentManager.Checked = guiItem.CanStudentManager;

            chkCanStudentRegisterationManager.Checked = guiItem.CanStudentRegisterationManager;

            chkCanStudentInformationReport.Checked = guiItem.CanStudentInformationReport;

            chkCanStudentPayForClass.Checked = guiItem.CanStudentPayForClass;

            chkCanStudentSessionDetails.Checked = guiItem.CanStudentSessionDetails;

            chkCanStudentFinancialDetails.Checked = guiItem.CanStudentFinancialDetails;

            chkCanStudentFinancialStatus.Checked = guiItem.CanStudentFinancialStatus;

            chkCanStudentClassBalance.Checked = guiItem.CanStudentClassBalance;

            chkCanStudentAffairs.Checked = guiItem.CanStudentAffairs;

            chkCanTeacherFinancialStatus.Checked = guiItem.CanTeacherFinancialStatus;

            chkCanTeacherFinancialDetails.Checked = guiItem.CanTeacherFinancialDetails;

            chkCanTeacherSessionDetails.Checked = guiItem.CanTeacherSessionDetails;

            chkCanTeacherManager.Checked = guiItem.CanTeacherManager;

            chkCanMajorTeacherManager.Checked = guiItem.CanMajorTeacherManager;

            chkCanTeacherClassBalance.Checked = guiItem.CanTeacherClassBalance;

            chkCanTeacherPayForClass.Checked = guiItem.CanTeacherPayForClass;

            chkCanTeacherTimeSelector.Checked = guiItem.CanTeacherTimeSelector;

            chkCanClassSessionStatusSetter.Checked = guiItem.CanClassSessionStatusSetter;

            chkCanClassSessionScheduleSetter.Checked = guiItem.CanClassSessionScheduleSetter;

            chkCanClassManagerPrivate.Checked = guiItem.CanClassManagerPrivate;

            chkCanClassManagerPublic.Checked = guiItem.CanClassManagerPublic;

            chkCanClassDailyStatus.Checked = guiItem.CanClassDailyStatus;

            chkCanPresenceManager.Checked = guiItem.CanPresenceManager;

            chkCanTimeManager.Checked = guiItem.CanTimeManager;

            chkCanEmployeeManager.Checked = guiItem.CanEmployeeManager;

            chkCanEmployeeSalary.Checked = guiItem.CanEmployeeSalary;

            chkCanComboManager.Checked = guiItem.CanComboManager;

            chkCanActivityManager.Checked = guiItem.CanActivityManager;

            chkCanDBSettings.Checked = guiItem.CanDBSettings;

            chkCanGuarantorManager.Checked = guiItem.CanGuarantorManager;

            chkCanSchoolSpecification.Checked = guiItem.CanSchoolSpecification;

            chkCanDesktopUsers.Checked = guiItem.CanDesktopUsers;

            chkCanOutcomeManager.Checked = guiItem.CanOutcomeManager;

            chkCanIncomeManager.Checked = guiItem.CanIncomeManager;

            chkCanSynchDatabase.Checked = guiItem.CanSynchDatabase;

            chkCanStoreStuffAvailableViewer.Checked = guiItem.CanStoreStuffAvailableViewer;

            chkCanStoreStuffTypeManager.Checked = guiItem.CanStoreStuffTypeManager;

            chkCanStoreStuffBuyManager.Checked = guiItem.CanStoreStuffBuyManager;

            chkCanStoreStuffSellItemManager.Checked = guiItem.CanStoreStuffSellItemManager;

            chkCanStoreShopHistoryViewer.Checked = guiItem.CanStoreShopHistoryViewer;

            chkCanStoreAffairs.Checked = guiItem.CanStoreAffairs;

            chkCanStoreStuffSellItem.Checked = guiItem.CanStoreStuffSellItem;

            chkCanStoreSalesTracking.Checked = guiItem.CanStoreSalesTracking;

            chkCanReportStudentListOfMajor.Checked = guiItem.CanReportStudentListOfMajor;

            chkCanReportPaysOfTeacherInterval.Checked = guiItem.CanReportPaysOfTeacherInterval;

            chkCanReportSessionsOfTeacherInterval.Checked = guiItem.CanReportSessionsOfTeacherInterval;

            chkCanReportClassesOfTeacherInterval.Checked = guiItem.CanReportClassesOfTeacherInterval;

            chkCanReportMinistryReport.Checked = guiItem.CanReportMinistryReport;

            chkCanReportStudentPayFactor.Checked = guiItem.CanReportStudentPayFactor;

            chkCanReportTypicalOutcomeYear.Checked = guiItem.CanReportTypicalOutcomeYear;

            chkCanReportIncomeInterval.Checked = guiItem.CanReportIncomeInterval;

            chkCanReportRegisteredStudentsPerEmployee.Checked = guiItem.CanReportRegisteredStudentsPerEmployee;

            chkCanReportTeacherPayFactor.Checked = guiItem.CanReportTeacherPayFactor;

            chkCanReportEmployeePayFactor.Checked = guiItem.CanReportEmployeePayFactor;

            chkCanReportStudentOfPublicClass.Checked = guiItem.CanReportStudentOfPublicClass;

            chkCanReportAffairs.Checked = guiItem.CanReportAffairs;

        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new DesktopUsersBO();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            chkCanStudentManager.Checked = false;
            chkCanStudentRegisterationManager.Checked = false;
            chkCanStudentInformationReport.Checked = false;
            chkCanStudentPayForClass.Checked = false;
            chkCanStudentSessionDetails.Checked = false;
            chkCanStudentFinancialDetails.Checked = false;
            chkCanStudentFinancialStatus.Checked = false;
            chkCanStudentClassBalance.Checked = false;
            chkCanStudentAffairs.Checked = false;
            chkCanTeacherFinancialStatus.Checked = false;
            chkCanTeacherFinancialDetails.Checked = false;
            chkCanTeacherSessionDetails.Checked = false;
            chkCanTeacherManager.Checked = false;
            chkCanMajorTeacherManager.Checked = false;
            chkCanTeacherClassBalance.Checked = false;
            chkCanTeacherPayForClass.Checked = false;
            chkCanTeacherTimeSelector.Checked = false;
            chkCanClassSessionStatusSetter.Checked = false;
            chkCanClassSessionScheduleSetter.Checked = false;
            chkCanClassManagerPrivate.Checked = false;
            chkCanClassManagerPublic.Checked = false;
            chkCanClassDailyStatus.Checked = false;
            chkCanPresenceManager.Checked = false;
            chkCanTimeManager.Checked = false;
            chkCanEmployeeManager.Checked = false;
            chkCanEmployeeSalary.Checked = false;
            chkCanComboManager.Checked = false;
            chkCanActivityManager.Checked = false;
            chkCanDBSettings.Checked = false;
            chkCanGuarantorManager.Checked = false;
            chkCanSchoolSpecification.Checked = false;
            chkCanDesktopUsers.Checked = false;
            chkCanOutcomeManager.Checked = false;
            chkCanIncomeManager.Checked = false;
            chkCanSynchDatabase.Checked = false;
            chkCanStoreStuffAvailableViewer.Checked = false;
            chkCanStoreStuffTypeManager.Checked = false;
            chkCanStoreStuffBuyManager.Checked = false;
            chkCanStoreStuffSellItemManager.Checked = false;
            chkCanStoreShopHistoryViewer.Checked = false;
            chkCanStoreAffairs.Checked = false;
            chkCanStoreStuffSellItem.Checked = false;
            chkCanStoreSalesTracking.Checked = false;
            chkCanReportStudentListOfMajor.Checked = false;
            chkCanReportPaysOfTeacherInterval.Checked = false;
            chkCanReportSessionsOfTeacherInterval.Checked = false;
            chkCanReportClassesOfTeacherInterval.Checked = false;
            chkCanReportMinistryReport.Checked = false;
            chkCanReportStudentPayFactor.Checked = false;
            chkCanReportTypicalOutcomeYear.Checked = false;
            chkCanReportIncomeInterval.Checked = false;
            chkCanReportRegisteredStudentsPerEmployee.Checked = false;
            chkCanReportTeacherPayFactor.Checked = false;
            chkCanReportEmployeePayFactor.Checked = false;
            chkCanReportStudentOfPublicClass.Checked = false;
            chkCanReportAffairs.Checked = false;


            txtUsername.Enabled = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtUsername.Enabled = false;

            //EditingState = FormState.Updating;
        }

        private void DoNothing()
        { }
        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            DesktopUsersBO user = (DesktopUsersBO)(e.Row.Tag);
            SetGUI(user);
            GotoUpdateMode();
        }

        private void txtEmployeeName_Click(object sender, EventArgs e)
        {
            //if (FormState == FormEditingState.Adding)
                floaterEmployeePicker.Show();
        }

    }
}
