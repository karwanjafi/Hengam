using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataGridFiller;
using BusinessObjectNamespace;
using FarsiMessageBox;
using DatabaseSchemaNamespace;
using Hengam.ComboManager;
using Hengam.Forms.ItemPickers;
using Hengam.Tools;
using Tools;

namespace Hengam.Forms
{
    public partial class frmTimeManager : HengamWidgets.FormBaseTableEditor
    {
        public frmTimeManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            if (tabMain.SelectedItem == tabWeeklySchedule)
            {
                SetMsg("در حال ساخت زمان‌ها");
                if (!CheckTimeIntervalGUI())
                {
                    HideMsg();
                    return;
                }

                int gap = UtilityTxt.GetInt(txtGap.Text);
                int duration = UtilityTxt.GetInt(txtDuration.Text);

                List<TimeBO> times = TimeBO.CreateTimeInterval(txtTimeFromInterval.Hour, txtTimeFromInterval.Minute, txtTimeToInterval.Hour, txtTimeToInterval.Minute, duration, gap);
                foreach (TimeBO time in times)
                {
                    try
                    {
                        SetMsg("در حال اضافه کردن");
                        if (!time.Add())
                        {
                            MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                        }
                        else
                        {
                            Program.SetStatus(MessageCreator.Added("مشخصات زمانی به نام " + time.ToString()));
                            GotoAddMode();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException se)
                    {
                        switch (se.Number)
                        {
                            case 2627:
                                MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات زمانی به نام " + time.ToString()));
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
                }
            }
            else
            {
                TimeBO item = GetGUI();
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
                        Program.SetStatus(MessageCreator.Added("مشخصات زمانی به نام " + item.ToString()));
                        GotoAddMode();
                    }

                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 2627:
                            MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات زمانی به نام " + item.ToString()));
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
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            TimeBO item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات زمانی به نام " + item.ToString()));
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
            TimeBO item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات زمانی به نام " + item.ToString()), "", "حذف زمان", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف جلسه‌...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات زمانی به نام " + item.ToString()));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این زمان نیستید. قبل از حذف باید تمامی اطلاعات این جلسه‌ از سیستم حذف شود.");
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

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<TimeBO>.FillDataGrid(dataGridSection, TimeBO.List(), new List<ColumnDefinition>()
            {
                DatabaseSchema.Time.TimeName,
                DatabaseSchema.Time.Duration,
                DatabaseSchema.Time.StartHour,
                DatabaseSchema.Time.StartMin,
                DatabaseSchema.Time.FinishHour,
                DatabaseSchema.Time.FinishMin
            });
        }

        private void frmClassSessionManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            AddButton("اضافه کردن", "Add", "اضافه کردن زمان", ActionAdd, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            //AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف زمان انتخاب شده از سیستم", ActionDelete, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }
        TimeBO guiItem = new TimeBO();
        private TimeBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtTimeFrom.Accepted)
                    err.Add("از ساعت");
                else
                {
                    guiItem.StartHour = txtTimeFrom.Hour;
                    guiItem.StartMin = txtTimeFrom.Minute;
                }

                if (!txtTimeTo.Accepted)
                    err.Add("تا ساعت");
                else
                {
                    guiItem.FinishHour = txtTimeTo.Hour;
                    guiItem.FinishMin = txtTimeTo.Minute;
                }

                if (txtTimeID.Accepted)
                    guiItem.TimeID = UtilityTxt.GetInt(txtTimeID.Text);

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
        private TimeBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtTimeTo.Accepted)
                    err.Add("زمان");
                else
                {
                    guiItem.TimeID = UtilityTxt.GetInt(txtTimeID.Text);
                }

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
        private void SetGUI(TimeBO guiItem)
        {
            this.guiItem = guiItem;
            txtTimeID.Text = UtilityTxt.GetString(guiItem.TimeID);
            txtTimeFrom.Text = string.Format("{0}:{1}", guiItem.StartHour, guiItem.StartMin);
            txtTimeTo.Text = string.Format("{0}:{1}", guiItem.FinishHour, guiItem.FinishMin);
        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new TimeBO();

            txtTimeID.Text = "";
            txtTimeFrom.Text = "";
            txtTimeTo.Text = "";

            tabWeeklySchedule.Visible = true;
            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();

            tabWeeklySchedule.Visible = false;
            tabMain.SelectedItem = tabDailySchedule;
            //EditingState = FormState.Updating;
        }
        
        private bool CheckTimeIntervalGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtTimeFromInterval.Accepted)
                    err.Add("از ساعت");

                if (!txtTimeToInterval.Accepted)
                    err.Add("تا ساعت");


                if (!txtDuration.Accepted)
                    err.Add("مدت زمان");

                if (!txtGap.Accepted)
                    err.Add("فاصله‌ی زمان‌ها");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (err.HasError)
            {
                err.ShowErrMsg();
                return false;
            }
            return true;
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((TimeBO)e.Row.Tag);
            GotoUpdateMode();
        }
    }
}
