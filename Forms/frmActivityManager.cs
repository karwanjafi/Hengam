using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Tools;
using BusinessObjectNamespace;
using ComboManager;
using DataGridFiller;
using FarsiMessageBox;

namespace Hengam.Forms
{
    public partial class frmActivityManager : HengamWidgets.FormBaseTableEditor
    {
        public frmActivityManager()
        {
            InitializeComponent();
        }

        private class ComboItem : IComboFillable
        {
            public IActivityStatus activitiManager;
            public string ItemName;

            #region IComboFillable Members

            public string ComboDescription
            {
                get { return ""; }
            }

            public string ComboText
            {
                get { return ItemName; }
            }

            #endregion
        }

        private void ActionActivate(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSection.DataGrid.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                IActivityStatus act = (IActivityStatus)row.Tag;

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
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionDeactivate(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridSection.DataGrid.SelectedRows;

            foreach (DataGridViewRow row in rows)
            {
                IActivityStatus act = (IActivityStatus)row.Tag;

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
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void frmActivityManager_LoadForm(object sender, EventArgs e)
        {
            lblDeactiveRule.ForeColor= lblItemStatus.ForeColor = Color.White;
            AddButton("فعال", "Activate", "فعال‌سازی سطر‌های انتخاب شده", ActionActivate, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("غیر‌فعال", "Deactivate", "غیر‌فعال‌سازی سطر‌های انتخاب شده", ActionDeactivate, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر ", ActionCancel, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            List<ComboItem> activityManagerItems = new List<ComboItem>()
            {
                new ComboItem(){ activitiManager = new StudentBO(), ItemName = "هنرجو"},
                new ComboItem(){ activitiManager = new ClassBO(), ItemName = "کلاس"},
                new ComboItem(){ activitiManager = new StoreStuffBO(), ItemName = "کالا"},
                new ComboItem(){ activitiManager = new TeacherBO(), ItemName = "استاد"}
            };
            ComboFiller<ComboItem>.FillCombo(cboActivityItems, activityManagerItems);
        }

        private void cboActivityItems_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();            
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if (cboActivityItems.SelectedItem == null)
            {
                dataGridSection.DataGrid.Rows.Clear();
                lblCountLable.Text = "-";
                lblDeactiveRule.Text = "-";
            }
            else
            {
                IActivityStatus actStat = ((ComboItem)(cboActivityItems.SelectedItem)).activitiManager;

                lblDeactiveRule.Text = actStat.DeactiveRule;


                int candidatesCount = 0;
                if (actStat is IActivityManager<StudentBO>)
                {
                    IActivityManager<StudentBO> actManager = actStat as IActivityManager<StudentBO>;
                    List<StudentBO> listDeactiveCandidates = actManager.ListDeactiveCandidates();
                    candidatesCount = listDeactiveCandidates.Count;

                    if(radioJustCandidates.Checked)
                        DataGridFiller<StudentBO>.FillDataGrid(dataGridSection, listDeactiveCandidates, actStat.StatusInfoColumns);
                    else if (radioJustDeactives.Checked)
                        DataGridFiller<StudentBO>.FillDataGrid(dataGridSection, actManager.List(false), actStat.StatusInfoColumns);
                    else if (radioJustActives.Checked)
                        DataGridFiller<StudentBO>.FillDataGrid(dataGridSection, actManager.List(true), actStat.StatusInfoColumns);
                    else
                        DataGridFiller<StudentBO>.FillDataGrid(dataGridSection, actManager.List(null), actStat.StatusInfoColumns);
                }
                else if (actStat is IActivityManager<ClassBO>)
                {
                    IActivityManager<ClassBO> actManager = actStat as IActivityManager<ClassBO>;
                    List<ClassBO> listDeactiveCandidates = actManager.ListDeactiveCandidates();
                    candidatesCount = listDeactiveCandidates.Count;

                    if (radioJustCandidates.Checked)
                        DataGridFiller<ClassBO>.FillDataGrid(dataGridSection, listDeactiveCandidates, actStat.StatusInfoColumns);
                    else if (radioJustDeactives.Checked)
                        DataGridFiller<ClassBO>.FillDataGrid(dataGridSection, actManager.List(false), actStat.StatusInfoColumns);
                    else if (radioJustActives.Checked)
                        DataGridFiller<ClassBO>.FillDataGrid(dataGridSection, actManager.List(true), actStat.StatusInfoColumns);
                    else
                        DataGridFiller<ClassBO>.FillDataGrid(dataGridSection, actManager.List(null), actStat.StatusInfoColumns);
                }
                else if (actStat is IActivityManager<StoreStuffBO>)
                {
                    IActivityManager<StoreStuffBO> actManager = actStat as IActivityManager<StoreStuffBO>;
                    List<StoreStuffBO> listDeactiveCandidates = actManager.ListDeactiveCandidates();
                    candidatesCount = listDeactiveCandidates.Count;

                    if (radioJustCandidates.Checked)
                        DataGridFiller<StoreStuffBO>.FillDataGrid(dataGridSection, listDeactiveCandidates, actStat.StatusInfoColumns);
                    else if (radioJustDeactives.Checked)
                        DataGridFiller<StoreStuffBO>.FillDataGrid(dataGridSection, actManager.List(false), actStat.StatusInfoColumns);
                    else if (radioJustActives.Checked)
                        DataGridFiller<StoreStuffBO>.FillDataGrid(dataGridSection, actManager.List(true), actStat.StatusInfoColumns);
                    else
                        DataGridFiller<StoreStuffBO>.FillDataGrid(dataGridSection, actManager.List(null), actStat.StatusInfoColumns);
                }
                else if (actStat is IActivityManager<TeacherBO>)
                {
                    IActivityManager<TeacherBO> actManager = actStat as IActivityManager<TeacherBO>;
                    List<TeacherBO> listDeactiveCandidates = actManager.ListDeactiveCandidates();
                    candidatesCount = listDeactiveCandidates.Count;

                    if (radioJustCandidates.Checked)
                        DataGridFiller<TeacherBO>.FillDataGrid(dataGridSection, listDeactiveCandidates, actStat.StatusInfoColumns);
                    else if (radioJustDeactives.Checked)
                        DataGridFiller<TeacherBO>.FillDataGrid(dataGridSection, actManager.List(false), actStat.StatusInfoColumns);
                    else if (radioJustActives.Checked)
                        DataGridFiller<TeacherBO>.FillDataGrid(dataGridSection, actManager.List(true), actStat.StatusInfoColumns);
                    else
                        DataGridFiller<TeacherBO>.FillDataGrid(dataGridSection, actManager.List(null), actStat.StatusInfoColumns);
                }

                lblCountLable.Text = "تعداد " + actStat.CaseNameI + "‌هایی که نامزد غیرفعال شدن هستند: " + candidatesCount.ToString();


                foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
                {
                    IActivityStatus act = (IActivityStatus)row.Tag;
                    if (act.ActivityStatus)
                        row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    else
                        row.DefaultCellStyle.BackColor = Color.Pink;
                }

                //Type type = cboActivityItems.SelectedItem.GetType();
                //IActivityManager<type> actManager = (IActivityManager<type>)(actStat);
            }
        }

        private void radioJustCandidates_Click(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetMsg("در حال بررسی اطلاعات...");
            if (e.Row == null) return;
            IActivityStatus act = (IActivityStatus)e.Row.Tag;
            lblItemStatus.Text = act.StatusDescription;
            lblItemAdditional.Text = act.AdditionalInformation;
            HideMsg();
        }

        private void dataGridSection_RowsSelected(StandardWidgets.CoolDataGrid.RowsSelectionEventArgs e)
        {
            if (e.Rows.Count > 0)
                GotoUpdateMode();
            else
                GotoAddMode();
        }
    }
}
