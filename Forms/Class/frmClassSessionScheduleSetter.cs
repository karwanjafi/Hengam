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
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmClassSessionScheduleSetter : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmClassSessionScheduleSetter()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            if (tabMain.SelectedItem == tabWeeklySchedule)
            {
                SetMsg("در حال تهیه‌ی برنامه");
                if (!CheckWeeklyGUI())
                {
                    HideMsg();
                    return;
                }

                ClassBO classObj = ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text));

                DayBO dayObj = ComboFiller<DayBO>.GetFromCombo(cboTypicalDayID);
                TimeBO timeObj = ComboFiller<TimeBO>.GetFromCombo(cboTypicalTimeID);
                int weekCount = UtilityTxt.GetInt(txtWeekCount.Text);
                string startDate = txtStartDate.Text;

                List<ClasssessionBO> schedule = ClasssessionBO.CreateWeeklySchedule(classObj, timeObj, dayObj, weekCount, startDate);
                foreach (ClasssessionBO session in schedule)
                {
                    try
                    {
                        SetMsg("در حال اضافه کردن");

                        if (chkScheduleCheck.Checked && HasClassConflict(classObj.TeacherID, session))
                        {
                            if (MessageBoxEx.Show("جلسه‌ی مورد نظر با یکی از کلاس‌های استاد تداخل دارد، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + session.ToString(), "", "", true) != DialogResult.OK)
                                continue;
                        }

                        if (chkFreeTimeCheck.Checked && !IsInFreeTime(classObj.TeacherID, session))
                        {
                            if (MessageBoxEx.Show("استاد این زمان را به عنوان زمان آزاد اعلام نکرده است، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + session.ToString(), "", "", true) != DialogResult.OK)
                                continue;
                        }

                        if (ClasssessionBO.List(session.ClassID).Count >= ClassBO.Find(session.ClassID).SessionCount)
                        {
                            MessageBoxEx.Show("تعداد جلسات کامل شده است. شما نمی‌توانید بیش از جلسات مشخص شده در تنظیمات کلاس، زمانبندی کنید.");
                            break;
                        }
                        
                        if (!session.Add())
                        {
                            MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                        }
                        else
                        {
                            Program.SetStatus(MessageCreator.Added("مشخصات جلسه‌ای به نام " + session.ToString()));
                            GotoAddMode();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException se)
                    {
                        switch (se.Number)
                        {
                            case 2627:
                                MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات جلسه‌ای به نام " + session.ToString()));
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
                ClasssessionBO item = GetGUI();
                if (item == null) return;
                try
                {
                    string teacherID = ClassBO.Find(item.ClassID).TeacherID;
                    if (HasClassConflict(teacherID, item))
                    {
                        if (MessageBoxEx.Show("جلسه‌ی مورد نظر با یکی از کلاس‌های استاد تداخل دارد، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                            return;
                    }

                    if (!IsInFreeTime(teacherID, item))
                    {
                        if (MessageBoxEx.Show("استاد این زمان را به عنوان زمان آزاد اعلام نکرده است، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                            return;
                    }
                    SetMsg("در حال اضافه کردن");

                    if (ClasssessionBO.List(item.ClassID).Count >= ClassBO.Find(item.ClassID).SessionCount)
                    {
                        MessageBoxEx.Show("تعداد جلسات کامل شده است. شما نمی‌توانید بیش از جلسات مشخص شده در تنظیمات کلاس، زمانبندی کنید.");
                    }
                    else
                    {

                        if (!item.Add())
                        {
                            MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                        }
                        else
                        {
                            Program.SetStatus(MessageCreator.Added("مشخصات جلسه‌ای به نام " + item.ToString()));
                            GotoAddMode();
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 2627:
                            MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات جلسه‌ای به نام " + item.ToString()));
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
            ClasssessionBO item = GetGUI();
            if (item == null) return;
            try
            {
                string teacherID = ClassBO.Find(item.ClassID).TeacherID;
                if (chkScheduleCheck.Checked && HasClassConflict(teacherID, item))
                {
                    if (MessageBoxEx.Show("جلسه‌ی مورد نظر با یکی از کلاس‌های استاد تداخل دارد، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                        return;
                }

                if (chkFreeTimeCheck.Checked && !IsInFreeTime(teacherID, item))
                {
                    if (MessageBoxEx.Show("استاد این زمان را به عنوان زمان آزاد اعلام نکرده است، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                        return;
                }
                SetMsg("در حال به‌روز رسانی...");

                if (!item.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات جلسه‌ای به نام " + item.ToString()));
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
            DataGridViewSelectedRowCollection rows = dataGridSection.DataGrid.SelectedRows; //Added by hanieh
            //ClasssessionBO item = GetGUIKey(); //hanieh
            //if (item == null) return; //hanieh
            if (rows.Count == 0) return; //added by hanieh
            //if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات جلسه‌ به نام " + item.ToString()), "", "حذف جلسه/جلسات‌", true) == DialogResult.OK) //hanieh
            if (MessageBoxEx.Show(MessageCreator.SureToRemove(""), "", "حذف جلسه/جلسات‌", true) == DialogResult.OK)
            {
                //hanieh
                foreach (DataGridViewRow row in rows)
                {
                    ClasssessionBO item = ClasssessionBO.Find(((ClasssessionBO)row.Tag).ClassID, 
                        ((ClasssessionBO)row.Tag).ClassDate, ((ClasssessionBO)row.Tag).TimeID); 
                //------------------------
                    try
                    {
                        SetMsg("در حال حذف جلسه‌...");
                        if (!item.Delete())
                            MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                        else
                        {
                            Program.SetStatus(MessageCreator.Removed("مشخصات جلسه‌ای به نام " + item.ToString()));
                            GotoAddMode();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException se)
                    {
                        switch (se.Number)
                        {
                            case 547:
                                MessageBoxEx.Show("شما قادر به حذف این جلسه‌ نیستید. قبل از حذف باید تمامی اطلاعات این جلسه‌ از سیستم حذف شود.");
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

        private void ttxtClassName_Click(object sender, EventArgs e)
        {
            if (FormState == FormEditingState.Adding)
                floaterClassPicker.Show();
        }

        private void floaterClassPicker_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if ( !txtClassID.Accepted )
            {
                Program.SetStatus("هنوز کلاسی انتخاب نشده است.");
                return;
            }
            int classID = int.Parse(txtClassID.Text);
            
            DataGridFiller<ClasssessionBO>.FillDataGrid(dataGridSection, ClasssessionBO.List(classID), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.Day.DayName,
                DatabaseSchema.Classsession.TimeID,
                DatabaseSchema.Classsession.ClassDate
            });


            int sessionCount = ClassBO.Find(classID).SessionCount;
            int schedCount = ClasssessionBO.List(classID).Count;
            lblClassStatus.Text = schedCount.ToString() + " جلسه از " + sessionCount.ToString() + " جسله‌ی این کلاس مشخص شده است.";
        }

        frmTeacherTimePicker fTimePicker = new frmTeacherTimePicker();


        private void frmClassSessionManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");

            lblClassStatus.ForeColor = Color.White;

            AddButton("اضافه کردن", "Add", "اضافه کردن جلسه‌", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف جلسه‌ انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            btnFreeTimes.Visible = Program.User.CanTeacherTimeSelector;

            ComboFiller<TimeBO>.FillCombo(cboTimeID, TimeBO.List());
            ComboFiller<RoomsBO>.FillCombo(cboRoomNo, RoomsBO.List());
            //ComboFiller<TimeBO>.FillCombo(cboTypicalTimeID, TimeBO.List());
            cboTimeID.Fill(TimeBO.List());
            cboTypicalTimeID.Fill(TimeBO.List());
            ComboFiller<DayBO>.FillCombo(cboTypicalDayID, DayBO.List());

            ComboFiller<SessionStatus>.FillCombo(cboSessionStatus, SessionStatus.List());

            //hanieh---------------------------
            
            frmClassPicker fClassPicker = new frmClassPicker();
            //fClassPicker.SetListFunction();
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            /*
            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtSuccessorTeacher, txtSuccesorTeacherName);
            */
            //-----------------------
            floaterTimePicker.LoadPanel(fTimePicker);
            fTimePicker.FreeTimeSelected += new EventHandler(fTimePicker_FreeTimeSelected);
            
            dataGridSection.RefreshDataGrid();

            HideMsg();
            GotoAddMode();
        }

        
        void fTimePicker_FreeTimeSelected(object sender, EventArgs e)
        {
            StandardWidgets.CoolDayTimePicker.TimeSelectedEventArgs ts = fTimePicker.SelectedFreeTime;
            ClasssessionBO item = new ClasssessionBO();
            TimeBO time = TimeBO.Find(ts.StartTime.Hour, ts.StartTime.Minute, ts.FinishTime.Hour, ts.FinishTime.Minute);
            if (time == null)
            {
                time = new TimeBO();
                time.StartHour = ts.StartTime.Hour;
                time.StartMin = ts.StartTime.Minute;
                time.FinishHour = ts.FinishTime.Hour;
                time.FinishMin = ts.FinishTime.Minute;

                try
                {
                    time.Add();
                }
                catch (Exception) { }
            }
            time = TimeBO.Find(ts.StartTime.Hour, ts.StartTime.Minute, ts.FinishTime.Hour, ts.FinishTime.Minute);
            if (time == null)
            {
                MessageBoxEx.Show("سیستم قادر به تولید زمان نیست.");
                return;
            }

            item = GetGUIWithoutTimeRoom();
            item.TimeID = time.TimeID;
            item.ClassDate = ts.StartTime.ToString("yyyy/mm/dd");

            if (item == null) return;
            try
            {
                string teacherID = ClassBO.Find(item.ClassID).TeacherID;
                if (HasClassConflict(teacherID, item))
                {
                    if (MessageBoxEx.Show("جلسه‌ی مورد نظر با یکی از کلاس‌های استاد تداخل دارد، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                        return;
                }

                if (!IsInFreeTime(teacherID, item))
                {
                    if (MessageBoxEx.Show("استاد این زمان را به عنوان زمان آزاد اعلام نکرده است، آیا در هر صورت مایل به ثبت جلسه هستید؟" + "\n" + item.ToString(), "", "", true) != DialogResult.OK)
                        return;
                }
                SetMsg("در حال اضافه کردن");

                if (ClasssessionBO.List(item.ClassID).Count >= ClassBO.Find(item.ClassID).SessionCount)
                {
                    MessageBoxEx.Show("تعداد جلسات کامل شده است. شما نمی‌توانید بیش از جلسات مشخص شده در تنظیمات کلاس، زمانبندی کنید.");
                }
                else
                {

                    if (!item.Add())
                    {
                        MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                    }
                    else
                    {
                        Program.SetStatus(MessageCreator.Added("مشخصات جلسه‌ای به نام " + item.ToString()));
                        GotoAddMode();
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات جلسه‌ای به نام " + item.ToString()));
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

        
        ClasssessionBO guiItem = new ClasssessionBO();
        private ClasssessionBO GetGUIWithoutTimeRoom()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("جلسه‌");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                guiItem.StudentAbsence = chkStudentAbsence.Checked;

                guiItem.TeacherAbsence = chkTeacherAbsence.Checked;

                //if (!cboDayID.Accepted)
                //    err.Add("روز");
                //else
                //    guiItem.DayID = ComboFiller<DayBO>.GetFromCombo(cboDayID).DayID;

                if (!cboSessionStatus.Accepted)
                    err.Add("وضعیت جلسه‌");
                else
                    guiItem.SessionStatus = (int)ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue;

 
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
        private ClasssessionBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("جلسه‌");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtClassDate.Accepted)
                    err.Add("تاریخ تشکیل");
                else
                    guiItem.ClassDate = UtilityTxt.GetString(txtClassDate.Text);

                if (!cboTimeID.Accepted)
                    err.Add("ساعت تشکیل");
                else
                    guiItem.TimeID = ComboFiller<TimeBO>.GetFromCombo(cboTimeID).TimeID;

                guiItem.StudentAbsence = chkStudentAbsence.Checked;

                guiItem.TeacherAbsence = chkTeacherAbsence.Checked;

                //if (!cboDayID.Accepted)
                //    err.Add("روز");
                //else
                //    guiItem.DayID = ComboFiller<DayBO>.GetFromCombo(cboDayID).DayID;

                if (!cboSessionStatus.Accepted)
                    err.Add("وضعیت جلسه‌");
                else
                    guiItem.SessionStatus = (int)ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue;

                if (!cboRoomNo.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.RoomNo = ComboFiller<RoomsBO>.GetFromCombo(cboRoomNo).RoomNo;

                if (!txtSuccessorTeacher.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.SuccessorTeacher = UtilityTxt.GetString(txtSuccessorTeacher.Text);

                
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
        private ClasssessionBO GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("جلسه‌");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);


                if (!cboTimeID.Accepted)
                    err.Add("ساعت تشکیل");
                else
                    guiItem.TimeID = ComboFiller<TimeBO>.GetFromCombo(cboTimeID).TimeID;

                if (!txtClassDate.Accepted)
                    err.Add("تاریخ تشکیل");
                else
                    guiItem.ClassDate = UtilityTxt.GetString(txtClassDate.Text);

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
        private void SetGUI(ClasssessionBO guiItem)
        {
            this.guiItem = guiItem;
            txtClassID.Text = UtilityTxt.GetString(guiItem.ClassID);


            ComboFiller<TimeBO>.SetCombo(cboTimeID, Utility.GetObject<TimeBO>(guiItem.TimeID));

            chkStudentAbsence.Checked = guiItem.StudentAbsence;

            chkTeacherAbsence.Checked = guiItem.TeacherAbsence;

            //ComboFiller<DayBO>.SetCombo(cboDayID, Utility.GetObject<DayBO>(guiItem.DayID));

            ComboFiller<SessionStatus>.SetCombo(cboSessionStatus, Utility.GetObject<SessionStatus>(guiItem.SessionStatus));

            ComboFiller<RoomsBO>.SetCombo(cboRoomNo, Utility.GetObject<RoomsBO>(guiItem.RoomNo));

            ComboFiller<TimeBO>.SetCombo(cboTimeID, Utility.GetObject<TimeBO>(guiItem.TimeID));

            txtSuccessorTeacher.Text = guiItem.SuccessorTeacher;
            txtSuccesorTeacherName.Text = guiItem.RelSuccessorTeacher.FullName;

            txtClassDate.Text = guiItem.ClassDate;
        }
        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new ClasssessionBO();
            //txtClassID.Text = "";
            cboTimeID.SelectedItem = null;
            txtClassDate.Text = FaDate.CurrentFaDateString;
            chkStudentAbsence.Checked = false;
            chkTeacherAbsence.Checked = false;

            cboTypicalDayID.SelectedItem = null;
            cboTypicalTimeID.SelectedItem = null;
            txtWeekCount.Text = "";
            txtStartDate.Text = FaDate.CurrentFaDateString;
            
            cboSessionStatus.SelectedItem = null;
            ComboFiller<SessionStatus>.SetCombo(cboSessionStatus, new SessionStatus(SessionStatus.SessionStatusType.WillHold));
            
            cboRoomNo.SelectedItem = null;
            txtSuccessorTeacher.Text = "";
            txtSuccesorTeacherName.Text = "";

            txtClassID.Enabled = true;
            cboTimeID.Enabled = true;
            txtClassDate.Enabled = true;

            tabWeeklySchedule.Visible = true;
            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtClassID.Enabled = false;
            cboTimeID.Enabled = false;
            txtClassDate.Enabled = false;

            tabWeeklySchedule.Visible = false;
            tabMain.SelectedItem = tabDailySchedule;
            //EditingState = FormState.Updating;
        }

        private bool HasClassConflict(string teacherID, ClasssessionBO session)
        {
            if (!chkScheduleCheck.Checked) return false;
            Schedule teacherSched = Schedule.GetTeacherSchedule(new TeacherBO(){TeacherID = teacherID});
            Schedule.ScheduleItem si = new Schedule.ScheduleItem();
            si.Set(session);
            if (teacherSched.HasConflict(si))
                return true;
            else 
                return false;
        }

        private bool IsInFreeTime(string teacherID, ClasssessionBO session)
        {
            if (!chkFreeTimeCheck.Checked) return true;
            Schedule teacherSched = Schedule.GetTeacherFreeTimes(new TeacherBO() { TeacherID = teacherID });
            Schedule.ScheduleItem si = new Schedule.ScheduleItem();
            si.Set(session);
            if (teacherSched.HasConflict(si))
                return true;
            else
                return false;
        }

        private bool CheckWeeklyGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("کلاس");

                if (!cboTypicalDayID.Accepted)
                    err.Add("روز هفته");


                if (!cboTypicalTimeID.Accepted)
                    err.Add("ساعت تشکیل");

                if (!txtWeekCount.Accepted)
                    err.Add("تعداد هفته‌ها");

                if (!txtStartDate.Accepted)
                    err.Add("تاریخ شروع");
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
        private void txtClassName_Click(object sender, EventArgs e)
        {
            floaterClassPicker.Show();
        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            SetGUI((ClasssessionBO)e.Row.Tag);
            GotoUpdateMode();
        }

        private void txtSuccessorTeacher_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        public void Set(ClassBO classObj)
        {
            txtClassID.Text = classObj.ClassID.ToString();
            txtClassName.Text = classObj.ClassName;
            dataGridSection.RefreshDataGrid();
        }

        private void btnFreeTimes_Clicked(object sender, EventArgs e)
        {
            if (txtClassID.Accepted)
            {
                ClassBO cls = ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text));
                fTimePicker.Set(cls.RelTeacher, txtClassDate.Text);
                floaterTimePicker.Show();
            }
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        //hanieh---------------------
        private void dataGridSection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ActionDelete(this, e);
            }
        }
        //--------------------------
    }
}
