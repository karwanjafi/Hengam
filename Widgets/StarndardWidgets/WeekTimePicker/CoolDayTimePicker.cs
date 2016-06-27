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
    public partial class CoolDayTimePicker : UserControl
    {
        public CoolDayTimePicker()
        {
            InitializeComponent();

            //AddTime(new PersianDate(1387, 1, 1, 6, 0),
            //    new PersianDate(1387, 1, 1, 6, 30),
            //    ".",
            //    "تازه بیدار می‌شیم.",
            //    Color.YellowGreen, null, null);
            
            //AddTime(new PersianDate(1387, 1, 1, 7, 0),
            //    new PersianDate(1387, 1, 1, 7, 30),
            //    ".",
            //    "تازه بیدار می‌شیم.",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 8, 0),
            //    new PersianDate(1387, 1, 1, 8, 30),
            //    ".",
            //    "تازه بیدار می‌شیم.",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 9, 0),
            //    new PersianDate(1387, 1, 1, 9, 30),
            //    ".",
            //    "کاملا بیدار می‌شیم",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 10, 0),
            //    new PersianDate(1387, 1, 1, 10, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 11, 0),
            //    new PersianDate(1387, 1, 1, 11, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 12, 0),
            //    new PersianDate(1387, 1, 1, 12, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 12, 0),
            //    new PersianDate(1387, 1, 1, 12, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 13, 0),
            //    new PersianDate(1387, 1, 1, 13, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 14, 0),
            //    new PersianDate(1387, 1, 1, 14, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 15, 0),
            //    new PersianDate(1387, 1, 1, 15, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 16, 0),
            //    new PersianDate(1387, 1, 1, 16, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 17, 0),
            //    new PersianDate(1387, 1, 1, 17, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 18, 0),
            //    new PersianDate(1387, 1, 1, 18, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 19, 0),
            //    new PersianDate(1387, 1, 1, 19, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 20, 0),
            //    new PersianDate(1387, 1, 1, 20, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 21, 0),
            //    new PersianDate(1387, 1, 1, 21, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 22, 0),
            //    new PersianDate(1387, 1, 1, 22, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //AddTime(new PersianDate(1387, 1, 1, 23, 0),
            //    new PersianDate(1387, 1, 1, 23, 30),
            //    ".",
            //    "معلومه دیگه، چت",
            //    Color.YellowGreen, null, null);

            //FreeTimeSelected += new TimeSelectedEventHandler(CoolDayTimePicker_FreeTimeSelected);
        }

        //void CoolDayTimePicker_FreeTimeSelected(object sender, CoolDayTimePicker.TimeSelectedEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //}
        
        private int timeInterval = 30;
        [Browsable(true), Category("Misc"), Description("Time interval in minutes.")]
        public int TimeInterval
        {
            get { return timeInterval; }
            set { timeInterval = value; }
        }

        PersianDate startTime = new PersianDate(1387, 1, 1, 6, 0);

        public void SetTime(PersianDate startTime, PersianDate finishTime)
        {
            this.startTime = startTime;
            this.finishTime = finishTime;
        }

        public PersianDate StartTime
        {
            get { return startTime; }
            //set { startTime = value; }
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public Color BarColor
        {
            get
            {
                return pnlSlotContainter.BackColor;
            }
            set
            {
                pnlSlotContainter.BackColor = value;

            }
        }

        PersianDate finishTime = new PersianDate(1387, 1, 1, 23, 59);
        public PersianDate FinishTime
        {
            get { return finishTime; }
            //set { finishTime = value; }
        }

        public PersianDate DayDate
        {
            get { return startTime; }
            set 
            {
                //dayDate = value;
                startTime.Year = finishTime.Year = value.Year;
                startTime.Month = finishTime.Month = value.Month;
                startTime.Day = finishTime.Day = value.Day;
            }
        }

        public string DayName
        {
            get
            {
                return DayDate.LocalizedWeekDayName;
            }
        }

        public void AddTime(PersianDate startTime, PersianDate finishTime, string name, string description, Color color, object tag, EventHandler clicked )
        {
            CoolTimeSlot timeSlot = new CoolTimeSlot();
            timeSlot.SetTimeSlot(startTime, finishTime, name, description, color, clicked, tag);
            timeSlot.Height = pnlSlotContainter.Height;
            timeSlot.Top = 0;
            timeSlot.Tag = tag;
            timeSlot.TimeSlotHovered += new EventHandler(timeSlot_TimeSlotHovered);
            timeSlot.TimeSlotClicked += new EventHandler(timeSlot_TimeSlotClicked);
            pnlSlotContainter.Controls.Add(timeSlot);
            RefreshSlots();
        }

        public void Clear()
        {
            foreach (Control c in pnlSlotContainter.Controls)
            {
                if (c is CoolTimeSlot)
                    pnlSlotContainter.Controls.Remove(c);
            }
        }

        void timeSlot_TimeSlotClicked(object sender, EventArgs e)
        {
            if (TimeSlotSelected != null)
                TimeSlotSelected(sender, new TimeSelectedEventArgs()
                {
                    color = ((CoolTimeSlot)sender).TimeColor,
                    FinishTime = ((CoolTimeSlot)sender).FinishTime,
                    StartTime = ((CoolTimeSlot)sender).StartTime,
                    Tag = ((CoolTimeSlot)sender).Tag
                });
        }

        void timeSlot_TimeSlotHovered(object sender, EventArgs e)
        {
            if (TimeSlotHovered != null)
                TimeSlotHovered(sender, new TimeSelectedEventArgs()
                {
                    color = ((CoolTimeSlot)sender).TimeColor,
                    FinishTime = ((CoolTimeSlot)sender).FinishTime,
                    StartTime = ((CoolTimeSlot)sender).StartTime,
                    Tag = ((CoolTimeSlot)sender).Tag
                });
        }

        private void RefreshSlots()
        {
            int totalWidth = pnlSlotContainter.Width;
            int totalMinutes = FinishTime.Hour * 60 + FinishTime.Minute - (StartTime.Hour * 60 + StartTime.Minute);

            float unitWidth = (float)totalWidth / totalMinutes;

            //pnlSlotContainter.SuspendLayout();
            foreach (Control c in pnlSlotContainter.Controls)
            {
                if (c is CoolTimeSlot)
                {
                    CoolTimeSlot ts = (CoolTimeSlot)c;
                    int startPos = TimeToX(ts.StartTime.Hour, ts.StartTime.Minute);//;(int)(((ts.StartTime.Hour -StartTime.Hour) * 60 + ts.StartTime.Minute - StartTime.Minute) * unitWidth);
                    ts.Left = startPos;
                    ts.Width = TimeToX(ts.FinishTime.Hour, ts.FinishTime.Minute) - startPos;//(int)(((ts.FinishTime.Hour-StartTime.Hour) * 60 + ts.FinishTime.Minute-StartTime.Minute) * unitWidth) - startPos;
                }
            }
            //pnlSlotContainter.ResumeLayout();
        }

        private int TimeToX(int hour, int minutes)
        {
            int totalWidth = pnlSlotContainter.Width;
            int totalMinutes = FinishTime.Hour * 60 + FinishTime.Minute - (StartTime.Hour * 60 + StartTime.Minute);
            float unitWidth = (float)totalWidth / totalMinutes;

            return (int)(((hour - StartTime.Hour) * 60 + minutes - StartTime.Minute) * unitWidth);
        }

        private int XToTime(int x)
        {
            int totalWidth = pnlSlotContainter.Width;
            int totalMinutes = FinishTime.Hour * 60 + FinishTime.Minute - (StartTime.Hour * 60 + StartTime.Minute);
            float unitWidth = (float)totalWidth / totalMinutes;

            return (int)(x / unitWidth) + StartTime.Hour * 60 + StartTime.Minute;
        }

        private void pnlSlotContainter_Click(object sender, EventArgs e)
        {
            int time = XToTime(PointToClient(MousePosition).X);
            int start = StartTime.Hour * 60 + StartTime.Minute;
            int finish = FinishTime.Hour * 60 + FinishTime.Minute;

            int timeStart = ((time - start) / timeInterval) * timeInterval+start;
            int timeFinish = timeStart + timeInterval;

            if (FreeTimeSelected != null)
            {
                FreeTimeSelected(sender, new TimeSelectedEventArgs()
                {
                    SelectedHour = time / 60,
                    SelectedMinute = time % 60,
                    StartTime = new PersianCalendar().AddMinutes(StartTime, timeStart - start),
                    FinishTime = new PersianCalendar().AddMinutes(FinishTime, timeFinish - finish)
                });
            }

            //MessageBox.Show((time/60).ToString() + ":" + (time%60).ToString() + "\n" +
            //    string.Format("{0}:{1}-{2}:{3}", timeStart/60, timeStart%60, timeFinish/60, timeFinish%60 + "\n" +
            //    "FinishTime:")
            //    );
        }

        public event TimeSelectedEventHandler FreeTimeSelected;
        public event TimeSelectedEventHandler TimeSlotSelected;
        public event TimeSelectedEventHandler TimeSlotHovered;

        public delegate void TimeSelectedEventHandler(object sender, TimeSelectedEventArgs e);
        public class TimeSelectedEventArgs : EventArgs
        {
            public int SelectedHour;
            public int SelectedMinute;
            public PersianDate StartTime;
            public PersianDate FinishTime;
            public object Tag;
            public Color color;
        }

        private void CoolDayTimePicker_Resize(object sender, EventArgs e)
        {
            RefreshSlots();
        }

    }
}
