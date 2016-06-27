using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolTiteBar : UserControl
    {
        public CoolTiteBar()
        {
            InitializeComponent();
            Parent = null;
        }

        //[Browsable(true)]
        //public Form Parent = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if ( Parent == null || !(Parent is Form) ) return;
            (Parent as Form).Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Parent == null || !(Parent is Form)) return;
            if ( (Parent as Form).WindowState != FormWindowState.Maximized)
                (Parent as Form).WindowState = FormWindowState.Maximized;
            else
                (Parent as Form).WindowState = FormWindowState.Normal;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Parent == null || !(Parent is Form)) return;
            (Parent as Form).WindowState = FormWindowState.Minimized;
        }

        Point LastMousePosition;

        private void picBack_Click(object sender, EventArgs e)
        {
            /// Saving the location of mouse.
            LastMousePosition = MousePosition;
        }

        private void lblTitleText_DoubleClick(object sender, EventArgs e)
        {
            btnMax_Click(sender, e);
        }

        private void lblTitleText_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point Here = MousePosition;
                Point Offset = new Point(Here.X - LastMousePosition.X, Here.Y - LastMousePosition.Y);
                //Point Offset = new Point( - LastMousePosition.X,  - LastMousePosition.Y);
                Point newLocation = new Point(Parent.Location.X + Offset.X , Parent.Location.Y + Offset.Y );
                //Point newLocation = new Point(Offset.X,  Offset.Y);
                LastMousePosition = Here;
                Parent.Location = newLocation;
            }

        }

        private void lblTitleText_MouseHover(object sender, EventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        private void lblTitleText_MouseDown(object sender, MouseEventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        [Browsable(true)]
        public string TitleText
        {
            get { return lblTitleText.Text; }
            set { lblTitleText.Text = value; }
        }
    }
}