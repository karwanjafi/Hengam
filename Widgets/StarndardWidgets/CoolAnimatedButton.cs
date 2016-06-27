using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolAnimatedButton : UserControl
    {
        public CoolAnimatedButton()
        {
            InitializeComponent();
        }

        [Browsable(true), Category("Action")]
        public event EventHandler Clicked = null;

        private void btnAnimatedButton_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(sender, e);
        }

        [Browsable(true), Category("Misc")]
        public string TextToSet
        {
            get { return btnAnimatedButton.Text; }
            set { btnAnimatedButton.Text = value; }
        }

        [Browsable(true), Category("Misc")]
        public new string Text
        {
            get { return btnAnimatedButton.Text; }
            set { btnAnimatedButton.Text = value; }
        }

        [Browsable(true), Category("Misc")]
        public Image Image
        {
            get { return btnAnimatedButton.Image; }
            set { btnAnimatedButton.Image = value; }
        }

        [Browsable(true), Category("Action")]
        public new Font Font
        {
            get { return btnAnimatedButton.Font; }
            set { btnAnimatedButton.Font = value; }
        }
    }
}
