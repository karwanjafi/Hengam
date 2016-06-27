using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ComboManager;

namespace StandardWidgets
{
    public partial class CoolComboBox : UserControl
    {
        public CoolComboBox()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.ComboBox.ObjectCollection Items
        {
            get { return cbo.Items; }
        }

        public string DisplayMember
        {
            get { return cbo.DisplayMember; }
            set { cbo.DisplayMember = value; }
        }

        public object SelectedItem
        {
            get { return cbo.SelectedItem; }
            set { cbo.SelectedItem = value; }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Occurs when selected value changed.")]
        public event EventHandler SelectedValueChanged;

        private void cbo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo.SelectedItem != null)
            {
                if (cbo.SelectedItem is IComboFillable)
                {
                    IComboFillable ic = (IComboFillable)cbo.SelectedItem;
                    toolTip1.SetToolTip(cbo, ic.ComboDescription);
                }
            }
            if (SelectedValueChanged != null)
                SelectedValueChanged(sender, e);
            
            if (Accepted)
            {
                picOK.Visible = true;
                picError.Visible = false;
            }
            else
            {
                picError.Visible = true;
                picOK.Visible = false;
            }
        }

        /// <summary>
        /// Gets the acceptence status of CoolCombo.
        /// </summary>
        public bool Accepted
        {
            get { return cbo.SelectedItem != null; }
        }

        private void cbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                cbo.SelectedItem = null;
        }

    }
}
