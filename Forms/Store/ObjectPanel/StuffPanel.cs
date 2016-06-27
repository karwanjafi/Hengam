using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;

namespace Hengam.Forms.Store.ObjectPanel
{
    public partial class StuffPanel : UserControl
    {
        public StuffPanel()
        {
            InitializeComponent();
        }

        private StoreStuffBO curStuff;

        public StoreStuffBO CurStuff
        {
            get { return curStuff; }
            set 
            { 
                curStuff = value;
                Set(curStuff);
            }
        }
        private void Set(StoreStuffBO stuff)
        {
            txtStuffID.Text = stuff.StuffID;
            txtStuffName.Text = stuff.StuffName;
        }
    }
}
