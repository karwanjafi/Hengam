using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolCheckBox : UserControl
    {
        public CoolCheckBox()
        {
            InitializeComponent();
        }

        public bool Checked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        public CheckState CheckState
        {
            get { return checkBox.CheckState; }
            set { checkBox.CheckState = value; }
        }

        public bool ThreeState
        {
            get { return checkBox.ThreeState; }
            set { checkBox.ThreeState = value; }
        }

        [Browsable(true)]
        public new Color BackColor
        {
            get { return checkBox.BackColor; }
            set { checkBox.BackColor = value; }
        }

        public new Color ForeColor
        {
            get { return checkBox.ForeColor; }
            set { checkBox.ForeColor = value; }
        }

        [Browsable(true), Category("Misc")]
        public new string Text
        {
            get { return checkBox.Text; }
            set { checkBox.Text = value; }
        }

        [Browsable(true), Category("Misc")]
        public string TextToSet
        {
            get { return checkBox.Text; }
            set { checkBox.Text = value; }
        }

        [Browsable(true), Category("Action")]
        public event EventHandler CheckedChanged = null;
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedChanged != null) CheckedChanged(sender, e);
        }
    }
}
