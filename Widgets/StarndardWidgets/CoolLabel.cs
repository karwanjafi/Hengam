using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolLabel : UserControl
    {
        public CoolLabel()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public ContentAlignment TextAlign
        {
            get { return lblLabel.TextAlign; }
            set { lblLabel.TextAlign = value; }
        }
        [Browsable(true), Description("Text which label shows it."), Category("Misc")]
        public new string Text
        {
            get { return lblLabel.Text; }
            set { lblLabel.Text = value; }
        }

        [Browsable(true), Description("Text which label shows it."), Category("Misc")]
        public string TextToSet
        {
            get { return lblLabel.Text; }
            set { lblLabel.Text = value; }
        }

        [Browsable(true), Description("The ForeColor of label")]
        public new Color ForeColor
        {
            get { return lblLabel.ForeColor;}
            set { lblLabel.ForeColor = value; }
        }
        [Browsable(true)]
        public new bool AutoSize
        {
            get { return lblLabel.AutoSize; }
            set 
            { 
                lblLabel.AutoSize = value;
                CoolLabel_Resize(null, null);
            }
        }

        private void CoolLabel_Resize(object sender, EventArgs e)
        {
            if (lblLabel.AutoSize)
            {
                this.Height = lblLabel.PreferredHeight;
                this.Width = lblLabel.PreferredWidth;
            }
        }

    }
}
