using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using StandardWidgets;
using Tools;
using FarsiLibrary.Utils;

namespace Hengam.Forms.ItemPickers
{
    public partial class frmTeacherTimePicker : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmTeacherTimePicker()
        {
            InitializeComponent();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void frmTeacherTimePicker_LoadForm(object sender, EventArgs e)
        {
            frmTeacherPicker fTeacher = new frmTeacherPicker();
            fTeacher.HookTo(txtTeacherID, txtTeacherName);
            floaterTeacherPicker.LoadPanel(fTeacher, "انتخاب استاد");
        }
        bool setting = false;
        public void Set(TeacherBO teacher, string date)
        {
            setting = true;
            if (teacher != null)
            {
                txtTeacherID.Text = teacher.TeacherID;
                txtTeacherName.Text = teacher.FullName;
            }
            txtClassDate.Text = date;
            setting = false;
            RefreshWeek();
        }

        public void RefreshWeek()
        {
            timePicker.ClearTimes();
            if (txtTeacherID.Accepted && txtClassDate.Accepted)
            {
                SetWeek();
                Schedule sched = Schedule.GetTeacherSchedule(TeacherBO.Find(txtTeacherID.Text));
                foreach (Schedule.ScheduleItem item in sched.scheduleItems)
                {
                    ClassBO cls = ClassBO.Find((int)(item.Tag));
                    timePicker.AddTimeSchedule(item.StartTimeToPersianDate(), item.FinishTimeToPersianDate(),
                        cls.GroupFlag ? "ع" : "خ", item.Date + "\n" + cls.ClassName, Color.YellowGreen, cls.ClassID, null);
                }
            }
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void timePicker_TimeSlotSelected(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        {
            ClassBO cls = ClassBO.Find((int)(((CoolTimeSlot)sender).Tag));
            txtDescription.Text = cls.ClassName;
        }

        private void txtClassDate_TextAccepted(object sender, EventArgs e)
        {
            if (!setting)
                RefreshWeek();
        }

        private void SetWeek()
        {
            timePicker.WeekDate = new PersianDate(txtClassDate.Text);
            lblDay.Text = timePicker.WeekDate.LocalizedWeekDayName;

            timePicker.WeekName = "برنامه‌ی هفتگی استاد " + txtTeacherName.Text + "      از تاریخ " + timePicker.WeekStartDate.ToString("yyyy/mm/dd")
                + " تا " + timePicker.WeekFinishDate.ToString("yyyy/mm/dd");
        }

        private void timePicker_FreeTimeSelected(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        {
            txtTimeFromInterval.Text = UtilityTxt.To2Digit(e.StartTime.Hour) + ":" + UtilityTxt.To2Digit(e.StartTime.Minute);
            txtTimeToInterval.Text = UtilityTxt.To2Digit(e.FinishTime.Hour) + ":" + UtilityTxt.To2Digit(e.FinishTime.Minute);
            SelectedFreeTime = e;
            lblDateName.Text = e.StartTime.LocalizedWeekDayName + " " + e.StartTime.ToString("yyyy/mm/dd");
        }

        public event EventHandler FreeTimeSelected;

        public CoolDayTimePicker.TimeSelectedEventArgs SelectedFreeTime = null;

        private void btnFreeTimeSelected_Clicked(object sender, EventArgs e)
        {
            if (SelectedFreeTime == null) return;
            SelectedFreeTime.StartTime.Hour = txtTimeFromInterval.Hour;
            SelectedFreeTime.StartTime.Minute = txtTimeFromInterval.Minute;
            SelectedFreeTime.FinishTime.Hour = txtTimeToInterval.Hour;
            SelectedFreeTime.FinishTime.Minute = txtTimeToInterval.Minute;
            if (ContainerFloater != null) ContainerFloater.Hide();
            if (FreeTimeSelected != null) FreeTimeSelected(sender, SelectedFreeTime);
        }

        private void btnNextWeek_Clicked(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            PersianDate date = new PersianDate(txtClassDate.Text);
            txtClassDate.Text = new PersianDate(pc.AddDays(date, 7)).ToString("yyyy/mm/dd");
        }

        private void btnPreviousWeek_Clicked(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            PersianDate date = new PersianDate(txtClassDate.Text);
            txtClassDate.Text = new PersianDate(pc.AddDays(date, -7)).ToString("yyyy/mm/dd");
        }

        public bool CanSetFreeTime
        {
            get { return pnlFreeTimeDetails.Visible; }
            set { pnlFreeTimeDetails.Visible = value; }
        }
    }
}
