using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hengam.Controls
{
    public partial class ActivitySelector : UserControl
    {
        public ActivitySelector()
        {
            InitializeComponent();
        }

        public bool? ActivityStatus
        {
            get
            {
                if (radioAll.Checked)
                    return null;
                else if (radioActive.Checked)
                    return true;
                else if (radioDeactive.Checked)
                    return false;
                return null;
            }
            set
            {
                switch (value)
                {
                    case null:
                        radioAll.Checked = true;
                        break;
                    case true:
                        radioActive.Checked = true;
                        break;
                    case false:
                        radioDeactive.Checked = false;
                        break;
                }
            }
        }

        public event EventHandler StatusChanged;

        private void radioActive_CheckedChanged(object sender, EventArgs e)
        {
            if ( ((RadioButton)sender).Checked )
                if (StatusChanged != null)
                    StatusChanged(sender, e);
        }
    }
}
