using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using ComboManager;
using Tools;
using FarsiLibrary.Utils;
using HengamWidgets;

namespace Hengam.Controls
{
    public partial class TimeBox : UserControl
    {
        public TimeBox()
        {
            InitializeComponent();
        }

        public static implicit operator CoolComboBox(TimeBox timeBox)
        {
            return timeBox.cboTimes;
        }

        /// <summary>
        /// Gets the acceptence status of CoolCombo.
        /// </summary>
        public bool Accepted
        {
            get { return cboTimes.Accepted; }
        }

        public object SelectedItem
        {
            get { return cboTimes.SelectedItem; }
            set 
            {
                ComboFiller<TimeBO>.FillCombo(cboTimes, storedTimes);
                cboTimes.SelectedItem = value; 
            }
        }

        private class TimeInterval
        {
            TimeSpan timeSpan;
            public TimeInterval(TimeSpan pTimeSpan)
            {
                timeSpan = pTimeSpan;
            }
            public override string ToString()
            {
                return timeSpan.Hours.ToString() + ":" + timeSpan.Minutes.ToString();
            }
            public int Duration
            {
                get { return timeSpan.Minutes; }
            }
        }

        private List<TimeBO> storedTimes;
        public void Fill(List<TimeBO> times)
        {
            storedTimes = times;
            
            //ComboFiller<TimeBO>.FillCombo(cboTimes, times);
            HashSet<int> h = new HashSet<int>();
            foreach (TimeBO time in times)
            {
                TimeInterval interval = new TimeInterval(time.TimeSpan);
                if (!h.Contains(interval.Duration))
                {
                    h.Add(interval.Duration);
                    cboIntervals.Items.Add(interval);
                }
            }
            cboIntervals_SelectedValueChanged(null, null);
        }

        private void cboIntervals_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TimeBO> toFill = new List<TimeBO>();
            if (cboIntervals.SelectedItem != null)
            {
                foreach (TimeBO time in storedTimes)
                {
                    if (time.TimeSpan.Minutes == ((TimeInterval)cboIntervals.SelectedItem).Duration)
                        toFill.Add(time);
                }
            }
            else
            {
                toFill = Cloner.ListCloner<TimeBO>.Clone(storedTimes);
            }
            ComboFiller<TimeBO>.FillCombo(cboTimes, toFill);
        }

        private void cboTimes_MouseEnter(object sender, EventArgs e)
        {
            ShowBoth();
        }

        private void cboTimes_MouseLeave(object sender, EventArgs e)
        {
            ShowOne();
        }

        private void ShowBoth()
        {
            //cboTimes.Width = Width - cboTimes.Left - cboIntervals.Width;
        }

        private void ShowOne()
        {
            //cboTimes.Width = Width - cboTimes.Left;
        }

        private void cboTimes_MouseMove(object sender, MouseEventArgs e)
        {
            //ShowBoth();
        }

        private void TimeBox_MouseHover(object sender, EventArgs e)
        {
            ShowBoth();
        }

        private void TimeBox_MouseLeave(object sender, EventArgs e)
        {
            ShowOne();
        }

        private void TimeBox_MouseEnter(object sender, EventArgs e)
        {
            ShowBoth();
        }

        private void cboTimes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectedValueChanged != null)
            {
                SelectedValueChanged(sender, e);
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Occurs when selected value changed.")]
        public event EventHandler SelectedValueChanged;
    }
}
