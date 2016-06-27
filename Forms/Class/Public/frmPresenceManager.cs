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
using System.Linq;
using StandardWidgets;
using Hengam.Forms.Student;

namespace Hengam.Forms
{
    public partial class frmPresenceManager : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmPresenceManager()
        {
            InitializeComponent();
        }

        //private void ActionAdd(object sender, EventArgs e)
        //{
        //    SessionPresenceBO item = GetGUI();
        //    if (item == null) return;
        //    try
        //    {
        //        SetMsg("در حال اضافه کردن");
        //        if (!item.Add())
        //        {
        //            MessageBoxEx.Show(MessageCreator.ErrorInAdding());
        //        }
        //        else
        //        {
        //            Program.SetStatus(MessageCreator.Added("مشخصات جلسه‌ای به نام " + item.ToString()));
        //            GotoAddMode();
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException se)
        //    {
        //        switch (se.Number)
        //        {
        //            case 2627:
        //                MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات جلسه‌ای به نام " + item.ToString()));
        //                break;
        //            case 8152:// Dont Remember? 
        //                MessageBoxEx.Show("اطلاعات فرم صحیح نمی‌باشد، لطفاً دوباره بررسی کنید" + ".");
        //                break;

        //            default:
        //                MessageBox.Show(se.Number.ToString() + ", \n" + se.Message);
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    HideMsg();
        //    dataGridSection.RefreshDataGrid();
        //}

        private void ActionUpdate(object sender, EventArgs e)
        {
            SessionPresenceBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if ( item.Update() || item.Add())
                {
                    Program.SetStatus(MessageCreator.Updated("وضعیت حضور‌غیاب هنرجویی به نام " + item.RelStudent.FullName));
                    GotoAddMode();
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionSetPresent(object sender, EventArgs e)
        {
            SetMsg("در حال به‌روز رسانی...");
            foreach (DataGridViewRow row in dataGridSection.DataGrid.SelectedRows)
            {
                SessionPresenceBO item = (SessionPresenceBO)(row.Tag);
                item.PresenceStatusID = 1;
                if (item == null) return;
                try
                {
                    if (item.Update() || item.Add())
                    {
                        Program.SetStatus(MessageCreator.Updated("وضعیت حضور‌غیاب هنرجویی به نام " + item.RelStudent.FullName));
                    }
                    else
                    {
                        MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            GotoAddMode();
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionSetAbsent(object sender, EventArgs e)
        {
            SetMsg("در حال به‌روز رسانی...");
            foreach (DataGridViewRow row in dataGridSection.DataGrid.SelectedRows)
            {
                SessionPresenceBO item = (SessionPresenceBO)(row.Tag);
                item.PresenceStatusID = 0;
                if (item == null) return;
                try
                {
                    if (item.Update() || item.Add())
                    {
                        Program.SetStatus(MessageCreator.Updated("وضعیت حضور‌غیاب هنرجویی به نام " + item.RelStudent.FullName));
                    }
                    else
                    {
                        MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            GotoAddMode();
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionStudentFinancialStatus(object sender, EventArgs e)
        {
            frmStudentFinancialDetails fStudFinancial = new frmStudentFinancialDetails();
            List<RegistrationBO> regs = RegistrationBO.List(guiItem.ClassID, guiItem.StudentID, null, null);
            if (regs.Count > 0)
            {
                fStudFinancial.Set(regs[0].RelStudent, regs[0].RelClass);
                floaterFinancialStatus.LoadPanel(fStudFinancial);
                floaterFinancialStatus.Show();
            }
        }
        //private void ActionDelete(object seneder, EventArgs e)
        //{
        //    SessionPresenceBO item = GetGUIKey();
        //    if (item == null) return;
        //    if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات جلسه‌ به نام " + item.ToString()), "", "حذف جلسه‌", true) == DialogResult.OK)
        //    {
        //        try
        //        {
        //            SetMsg("در حال حذف جلسه‌...");
        //            if (!item.Delete())
        //                MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
        //            else
        //            {
        //                Program.SetStatus(MessageCreator.Removed("مشخصات جلسه‌ای به نام " + item.ToString()));
        //                GotoAddMode();
        //            }
        //        }
        //        catch (System.Data.SqlClient.SqlException se)
        //        {
        //            switch (se.Number)
        //            {
        //                case 547:
        //                    MessageBoxEx.Show("شما قادر به حذف این جلسه‌ نیستید. قبل از حذف باید تمامی اطلاعات این جلسه‌ از سیستم حذف شود.");
        //                    break;

        //                default:
        //                    MessageBox.Show("Error " + se.Number.ToString() + ",\n" + se.Message);
        //                    break;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        HideMsg();
        //        dataGridSection.RefreshDataGrid();
        //    }
        //}

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void DoNothing()
        {
        }

        private void ttxtClassName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding)
                floaterSessionPicker.Show();
        }

        private void floaterClassPicker_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if ( !txtClassID.Accepted || !txtClassDate.Accepted || !cboTimeID.Accepted)
            {
                Program.SetStatus("هنوز کلاسی انتخاب نشده است.");
                return;
            }
            List<SessionPresenceBO> dbPresenceList = SessionPresenceBO.List(UtilityTxt.GetInt(txtClassID.Text), txtClassDate.Text, ((TimeBO)cboTimeID.SelectedItem).TimeID, null, null);
            List<RegistrationBO> regStuds = RegistrationBO.List(UtilityTxt.GetInt(txtClassID.Text), null, null, null);
            
            List<SessionPresenceBO> presenceList = new List<SessionPresenceBO>();
            foreach (RegistrationBO stud in regStuds)
            {
                SessionPresenceBO sessionPresence = new SessionPresenceBO()
                {
                    ClassID = stud.ClassID,
                    ClassDate = txtClassDate.Text,
                    PresenceStatusID = (int)PresenceStatusBO.PresenceStatus.NotHeldYet,
                    StudentID = stud.StudentID,
                    TimeID = ((TimeBO)cboTimeID.SelectedItem).TimeID
                };
                SessionPresenceBO found = null;
                if ( (found = dbPresenceList.Find(p=>(p.ClassDate == sessionPresence.ClassDate && p.TimeID == sessionPresence.TimeID && p.StudentID == sessionPresence.StudentID && p.ClassID == sessionPresence.ClassID))) != null)
                {
                    sessionPresence = found;
                }
                presenceList.Add(sessionPresence);
            }

            DataGridFiller<SessionPresenceBO>.FillDataGrid(dataGridSection, presenceList, new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.Student.FirstName,
                DatabaseSchema.PresenceStatus.PresenceStatusName,
                DatabaseSchema.Day.DayName,
                DatabaseSchema.SessionPresence.TimeID,
                DatabaseSchema.SessionPresence.ClassDate
            });


            foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
            {
                SessionPresenceBO item = (SessionPresenceBO)row.Tag;
                if (item.PresenceStatusID == 1)
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    row.DefaultCellStyle.BackColor = Color.Pink;
            }
            HideSuggestions();
        }

        private void frmPresenceManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            //AddButton("اضافه کردن", "Add", "اضافه کردن جلسه‌", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "ثبت وضعیت حضور‌غیاب در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            
            if(Program.User.CanStudentFinancialStatus)
                AddButton("وضعیت مالی", "Money", "بررسی وضعیت مالی هنرجو", ActionStudentFinancialStatus, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حاضر", "Present", "ثبت وضعیت حضور‌غیاب در سیستم", ActionSetPresent, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            AddButton("غایب", "Absent", "ثبت وضعیت حضور‌غیاب در سیستم", ActionSetAbsent, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            //AddButton("حذف", "Delete", "حذف جلسه‌ انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("خالی کردن", "Cancel", "خالی کردن جعبه‌ها", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            //ComboFiller<TimeBO>.FillCombo(cboTimeID, TimeBO.List());
            cboTimeID.Fill(TimeBO.List());
            ComboFiller<PresenceStatusBO>.FillCombo(cboPresenceStatus, PresenceStatusBO.List());

            frmSessionPicker fSessionPicker = new frmSessionPicker();
            floaterSessionPicker.LoadPanel(fSessionPicker);
            fSessionPicker.HookTo(txtClassID, txtClassName, cboTimeID, txtClassDate);

            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }
        SessionPresenceBO guiItem = new SessionPresenceBO();
        private SessionPresenceBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtClassDate.Accepted)
                    err.Add("تاریخ");
                else
                    guiItem.ClassDate = UtilityTxt.GetString(txtClassDate.Text);

                if (!cboTimeID.Accepted)
                    err.Add("ساعت");
                else
                    guiItem.TimeID = ComboFiller<TimeBO>.GetFromCombo(cboTimeID).TimeID;

                if (!txtStudentID.Accepted)
                    err.Add("هنرجو");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

                if (!cboPresenceStatus.Accepted)
                    err.Add("وضعیت حضور غیاب");
                else
                    guiItem.PresenceStatusID = ComboFiller<PresenceStatusBO>.GetFromCombo(cboPresenceStatus).PresenceStatusID;

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

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
        private SessionPresenceBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);


                if (!cboTimeID.Accepted)
                    err.Add("ساعت");
                else
                    guiItem.TimeID = ComboFiller<TimeBO>.GetFromCombo(cboTimeID).TimeID;

                if (!txtStudentID.Accepted)
                    err.Add("هنرجو");
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
        private void SetGUI(SessionPresenceBO guiItem)
        {
            this.guiItem = guiItem;
            //txtClassID.Text = UtilityTxt.GetString(guiItem.ClassID);
            

            //txtClassDate.Text = guiItem.ClassDate;

            //ComboFiller<TimeBO>.SetCombo(cboTimeID, Utility.GetObject<TimeBO>(guiItem.TimeID));

            txtStudentID.Text = guiItem.StudentID;
            txtStudentName.Text = guiItem.RelStudent.FullName;

            ComboFiller<PresenceStatusBO>.SetCombo(cboPresenceStatus, Utility.GetObject<PresenceStatusBO>(guiItem.PresenceStatusID));

            txtDescription.Text = guiItem.Description;

        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new SessionPresenceBO();
            //txtClassID.Text = "";
            //cboTimeID.SelectedItem = null;
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            cboPresenceStatus.SelectedItem = null;
            txtDescription.Text = "";


            //txtClassID.Enabled = true;
            //cboTimeID.Enabled = true;
            //txtStudentID.Enabled = true;

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            //txtClassID.Enabled = false;
            //cboTimeID.Enabled = false;
            //txtStudentID.Enabled = false;

            //EditingState = FormState.Updating;
        }



        private void txtClassName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding)
                floaterSessionPicker.Show();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((SessionPresenceBO)e.Row.Tag);
            //frmPresenceManager.Set((SessionPresenceBO)e.Row.Tag);
            //floaterPresence.Show();
            GotoUpdateMode();
        }

        private void floaterPresence_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        public void Set(ClasssessionBO session)
        {
            txtClassID.Text = session.ClassID.ToString();
            txtClassName.Text = session.RelClass.ClassName;
            txtClassDate.Text = session.ClassDate;
            ComboFiller<TimeBO>.SetCombo(cboTimeID, session.RelTime);

            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_RowsSelected(StandardWidgets.CoolDataGrid.RowsSelectionEventArgs e)
        {
            ShowSuggestions();
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
