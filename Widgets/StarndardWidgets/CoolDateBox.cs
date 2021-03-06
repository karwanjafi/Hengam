using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Utils;

namespace StandardWidgets
{
    public partial class CoolDateBox : StandardWidgets.CoolValidatorTextBox
    {
        public CoolDateBox()
        {
            InitializeComponent();

            CanAccept += CanAcceptFunc;
            Mask = "0000/00/00";
            TextAlign = HorizontalAlignment.Right;
            //RightToLeft = RightToLeft.No;
        }

        private bool CanAcceptFunc(string str)
        {
            if (str.Trim() == "")
            {
                if (MustFill)
                {
                    Message = "خالی";
                    return false;
                }
                else
                    return true;
            }

            if (str.Length != 10)
            {
                Message = "طول کم";
                return false;
            }

            string[] splits = str.Split('/');

            if (splits.Length != 3)
            {
                Message = "فرمت غلط";
                return false;
            }

            int tmp = 0;
            if (int.TryParse(splits[0], out tmp))
            {
                if (tmp < 1)
                {
                    Message = "سال";
                    return false;
                }
            }
            else
            {
                Message = "فرمت غلط";
                return false;
            }

            tmp = 0;
            if (int.TryParse(splits[1], out tmp))
            {
                if (tmp > 12 || tmp < 1)
                {
                    Message = "ماه";
                    return false;
                }
            }
            else
            {
                Message = "فرمت غلط";
                return false;
            }

            tmp = 0;
            if (int.TryParse(splits[2], out tmp))
            {
                if (tmp > 31 || tmp < 1)
                {
                    Message = "روز";
                    return false;
                }
            }
            else
            {
                Message = "فرمت غلط";
                return false;
            }
            return true;
        }

        private void datePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                updating = true;
                Text = ((PersianDate)datePicker.SelectedDateTime).ToString("d");
                updating = false;
            }
        }
        bool updating = false;
        private void CoolDateBox_Click(object sender, EventArgs e)
        {
            //if (Accepted) datePicker.Text = Text;
            if (ReadOnly) return;
            datePicker.ShowDropDown();
            Application.DoEvents();
            this.Focus();
        }

        private void CoolDateBox_TextAccepted(object sender, EventArgs e)
        {
            if (!updating)
            {
                updating = true;
                datePicker.Text = Text;
                //if (this.Focused) datePicker.ShowDropDown();
                updating = false;
            }
        }
    }
}

