using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win;

namespace Hengam.Controls
{
    public partial class NextTabber : UserControl
    {
        public NextTabber()
        {
            InitializeComponent();
        }

        private int nextTabIndex = -1;
        [Browsable(true), Category("Misc")]
        public int NextTabIndex
        {
            get { return nextTabIndex; }
            set { nextTabIndex = value; }
        }

        private void NextTabber_Enter(object sender, EventArgs e)
        {
            if (Parent == null) return;
            if (Parent is FarsiLibrary.Win.FATabStripItem)
            {
                FATabStripItem tabItem = (FATabStripItem)Parent;
                FATabStrip tab = (FATabStrip)tabItem.Parent;
                if (NextTabIndex == -1)
                {
                    int current = 0;
                    for (int i = 0; i < tab.Items.Count; i++ )
                    {
                        current = i;
                        if (tab.SelectedItem == tab.Items[i])
                            break;
                    }
                    int next;
                    if (current == tab.Items.Count-1)
                    {
                        next = 0;
                    }
                    else
                    {
                        next = current + 1;
                    }
                    tab.SelectedItem = tab.Items[next];
                }
                else
                {
                    try
                    {
                        tab.SelectedItem = tab.Items[NextTabIndex];
                    }
                    catch(Exception){}
                }
                Control ctl = null;
                while (ctl == null || ctl.TabStop == false)
                    ctl = tab.SelectedItem.GetNextControl(ctl, true);
                ctl.Focus();
            }
        }
    }
}
