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
    public partial class CoolTimeSlot : UserControl
    {
        public CoolTimeSlot()
        {
            InitializeComponent();
        }

        PersianDate startTime = new PersianDate(2005, 1, 1, 6, 0);

        public PersianDate StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }


        PersianDate finishTime = new PersianDate(2005, 1, 1, 23, 30);

        public PersianDate FinishTime
        {
            get { return finishTime; }
            set { finishTime = value; }
        }

        private Color timeColor = Color.White;

        [Browsable(true), Category("Misc")]
        public Color TimeColor
        {
            get { return timeColor; }
            set
            {
                timeColor = value;
                BackColor = timeColor;
                btnTime.BackColor = timeColor;
            }
        }

        [Browsable(true), Category("Misc")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                btnTime.ForeColor = value;
            }
        }

        [Browsable(true), Category("Misc")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                btnTime.Font = value;
            }
        }

        public void SetTimeSlot(PersianDate startTime, PersianDate finishTime, string name, string description, Color color, EventHandler clicked , object tag)
        {
            btnTime.Text = name;
            lblLink.Text = name;
            toolTip1.SetToolTip(btnTime, description);
            toolTip1.SetToolTip(lblLink, description);
            btnTime.Click += clicked;
            lblLink.Click += clicked;
            TimeColor = color;
            StartTime = startTime;
            FinishTime = finishTime;
        }

        private void btnTime_MouseEnter(object sender, EventArgs e)
        {
            if (TimeSlotHovered != null)
                TimeSlotHovered(this, e);
        }

        public event EventHandler TimeSlotHovered;
        public event EventHandler TimeSlotClicked;

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (TimeSlotClicked != null)
                TimeSlotClicked(this, e);
        }
    }
}
