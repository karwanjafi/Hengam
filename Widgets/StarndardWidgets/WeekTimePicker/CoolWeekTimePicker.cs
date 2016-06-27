using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Utils;

namespace StandardWidgets
{
    public partial class CoolWeekTimePicker : UserControl
    {
        public CoolWeekTimePicker()
        {
            InitializeComponent();

            
            //AddTimeSchedule(new PersianDate(1387, 1, 1, 14, 0),
            //    new PersianDate(1387, 1, 1, 20, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);
        }

        public void AddTimeSchedule(PersianDate startTime, PersianDate finishTime, string scheduleName, string scheduleDescription, Color color, object tag, EventHandler clicked)
        {
            if (IsInWeek(startTime))
            {
                PersianCalendar pc = new PersianCalendar();
                DayOfWeek dayOfWeek = pc.GetDayOfWeek(startTime);
                CoolDayTimePicker timePicker = GetDayPicker(((int)dayOfWeek+8)%7);
                timePicker.AddTime(startTime, finishTime, scheduleName, scheduleDescription, color, tag, clicked);
            }
        }

        public void ClearTimes()
        {
            coolDayTimePicker0.Clear();
            coolDayTimePicker1.Clear();
            coolDayTimePicker2.Clear();
            coolDayTimePicker3.Clear();
            coolDayTimePicker4.Clear();
            coolDayTimePicker5.Clear();
            coolDayTimePicker6.Clear();
        }

        public string WeekName
        {
            get { return txtWeekName.Text; }
            set { txtWeekName.Text = value; }
        }

        private CoolDayTimePicker GetDayPicker(int index)
        {
            switch (index)
            {
                case 0:
                    return coolDayTimePicker0;

                case 1:
                    return coolDayTimePicker1;

                case 2:
                    return coolDayTimePicker2;

                case 3:
                    return coolDayTimePicker3;

                case 4:
                    return coolDayTimePicker4;

                case 5:
                    return coolDayTimePicker5;

                case 6:
                    return coolDayTimePicker6;
                default:
                    return null;
            }
        }

        public event StandardWidgets.CoolDayTimePicker.TimeSelectedEventHandler FreeTimeSelected;
        public event StandardWidgets.CoolDayTimePicker.TimeSelectedEventHandler TimeSlotSelected;
        public event StandardWidgets.CoolDayTimePicker.TimeSelectedEventHandler TimeSlotHovered;

        private void coolDayTimePicker0_FreeTimeSelected(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        {
            if (FreeTimeSelected != null)
                FreeTimeSelected(sender, e);
        }

        private void coolDayTimePicker0_TimeSlotHovered(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        {
            if (TimeSlotHovered != null)
                TimeSlotHovered(sender, e);
        }

        private void coolDayTimePicker0_TimeSlotSelected(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        {
            if (TimeSlotSelected != null)
            {
                TimeSlotSelected(sender, null);
            }
        }


        private PersianDate weekDate;
        public PersianDate WeekDate
        {
            get { return weekDate; }
            set
            {
                if (value == null) return;
                weekDate = value;
                PersianCalendar pc = new PersianCalendar();
                DayOfWeek day = pc.GetDayOfWeek(weekDate);
                int offset = ((int)day + 8) % 7;

                weekStartDate = pc.AddDays(weekDate, -offset);
                weekFinishDate = pc.AddDays(weekDate, 6 - offset);

                PersianDate tmp = (PersianDate)weekStartDate.Clone();

                
                toolTip.SetToolTip(txtDay0, tmp.ToWritten());
                coolDayTimePicker0.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay1, tmp.ToWritten());
                coolDayTimePicker1.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay2, tmp.ToWritten());
                coolDayTimePicker2.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay3, tmp.ToWritten());
                coolDayTimePicker3.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay4, tmp.ToWritten());
                coolDayTimePicker4.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay5, tmp.ToWritten());
                coolDayTimePicker5.DayDate = tmp;

                tmp = pc.AddDays(tmp, 1);
                toolTip.SetToolTip(txtDay6, tmp.ToWritten());
                coolDayTimePicker6.DayDate = tmp;

                //tmp = pc.AddDays(tmp, 1);
                //toolTip.SetToolTip(txtDay6, tmp.ToWritten());
                //coolDayTimePicker6.DayDate = tmp;

            }
        }

        public bool IsInWeek(PersianDate date)
        {
            if (date >= weekStartDate && date <= weekFinishDate)
                return true;
            else
                return false;
        }

        private PersianDate weekStartDate;
        public PersianDate WeekStartDate
        {
            get { return weekStartDate; }
            //set { weekStartDate = value; }
        }

        private PersianDate weekFinishDate;
        public PersianDate WeekFinishDate
        {
            get { return weekFinishDate; }
            //set { weekFinishDate = value; }
        }

    }
}
