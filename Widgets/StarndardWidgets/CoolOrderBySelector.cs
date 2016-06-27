using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolOrderbySelector : UserControl
    {
        public CoolOrderbySelector()
        {
            InitializeComponent();
        }

        public class ColumnItem
        {
            public ColumnItem()
            {

            }

            public ColumnItem(string columnName, string columnHeaderName, bool isPreselected)
            {
                this.ColumnName = columnName;
                this.ColumnHeaderName = columnHeaderName;
                this.IsPreselected = isPreselected;
            }
            public string ColumnName;
            public string ColumnHeaderName;
            public bool IsPreselected;

            public override string ToString()
            {
                return ColumnHeaderName;
            }
        }

        [Browsable(true), Category("Misc")]
        public override string Text
        {
            get
            {
                return lblHeader.Text;
            }
            set
            {
                lblHeader.Text = value;
            }
        }

        private void CoolOrderbySelector_ForeColorChanged(object sender, EventArgs e)
        {
            lblHeader.ForeColor = ForeColor;
            chklstSearchOptions.ForeColor = ForeColor;
        }

        public Color BackColorList
        {
            get { return chklstSearchOptions.BackColor; }
            set { chklstSearchOptions.BackColor = value; }
        }

        public void ShowList()
        {
            Height = chklstSearchOptions.Top + 116;//+ chklstSearchOptions.PreferredHeight+2;
            chklstSearchOptions.Visible = true;
            mIsDropped = true;
        }

        public void HideList()
        {
            Height = chklstSearchOptions.Top;
            chklstSearchOptions.Visible = false;
            mIsDropped = false;
        }

        private bool mIsDropped;
        public bool IsDropped
        {
            get { return mIsDropped; }
        }

        public string OrderText
        {
            get
            {
                if (chklstSearchOptions.CheckedItems.Count == 0) return "";
                string res = " ORDER BY ";
                foreach (Object obj in chklstSearchOptions.CheckedItems)
                {
                    ColumnItem item = (ColumnItem)obj;
                    res += item.ColumnName + ", ";
                }
                return res.TrimEnd(' ', ',');
            }

        }

        public List<ColumnItem> mItems = new List<ColumnItem>();
        public List<ColumnItem> Items
        {
            get { return mItems; }
        }

        public void AddItem(ColumnItem column)
        {
            mItems.Add(column);
            chklstSearchOptions.Items.Add(column, column.IsPreselected);
        }

        public void SynchList()
        {
            chklstSearchOptions.Items.Clear();
            foreach (ColumnItem item in mItems)
            {
                chklstSearchOptions.Items.Add(item, item.IsPreselected);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (chklstSearchOptions.SelectedItem == null) return;
            int thisIndex = chklstSearchOptions.SelectedIndex;

            if (thisIndex == chklstSearchOptions.Items.Count-1)
            {
                return;
            }

            int belowIndex = thisIndex + 1;

            object tempThis = chklstSearchOptions.Items[thisIndex];
            object tempBelow = chklstSearchOptions.Items[belowIndex];

            bool checkedThis = chklstSearchOptions.CheckedItems.Contains(tempThis);
            bool checkedBelow = chklstSearchOptions.CheckedItems.Contains(tempBelow);

            chklstSearchOptions.Items.RemoveAt(thisIndex);
            chklstSearchOptions.Items.RemoveAt(thisIndex);

            chklstSearchOptions.Items.Insert(thisIndex, tempBelow);
            chklstSearchOptions.Items.Insert(belowIndex, tempThis);

            chklstSearchOptions.SetItemChecked(thisIndex, checkedBelow);
            chklstSearchOptions.SetItemChecked(belowIndex, checkedThis);
            
            chklstSearchOptions.SelectedIndex = belowIndex;
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (chklstSearchOptions.SelectedItem == null) return;
            int thisIndex = chklstSearchOptions.SelectedIndex;

            if (thisIndex == 0)
            {
                return;
            }

            int aboveIndex = thisIndex - 1;

            object tempThis = chklstSearchOptions.Items[thisIndex];
            object tempAbove = chklstSearchOptions.Items[aboveIndex];

            bool checkedThis = chklstSearchOptions.CheckedItems.Contains(tempThis);
            bool checkedAbove = chklstSearchOptions.CheckedItems.Contains(tempAbove);

            chklstSearchOptions.Items.RemoveAt(aboveIndex);
            chklstSearchOptions.Items.RemoveAt(aboveIndex);

            chklstSearchOptions.Items.Insert(aboveIndex, tempThis);
            chklstSearchOptions.Items.Insert(thisIndex, tempAbove);

            chklstSearchOptions.SetItemChecked(thisIndex, checkedAbove);
            chklstSearchOptions.SetItemChecked(aboveIndex, checkedThis);

            chklstSearchOptions.SelectedIndex = aboveIndex;
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
            if (IsDropped)
                HideList();
            else
                ShowList();
        }
    }


}
