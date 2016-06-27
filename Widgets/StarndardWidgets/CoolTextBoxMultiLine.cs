using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolTextBoxMultiLine : UserControl
    {
        public CoolTextBoxMultiLine()
        {
            InitializeComponent();
        }

        public bool Accepted
        {
            get { return true; }

        }

        public new virtual string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
      
    }
}

