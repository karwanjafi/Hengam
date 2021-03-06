using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolTimeBox : StandardWidgets.CoolValidatorTextBox
    {
        public CoolTimeBox()
        {
            InitializeComponent();
            CanAccept += CanAcceptFunc;
            //Mask = "00:00";
            TextAlign = HorizontalAlignment.Right;
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

            if (str.Length != 5)
            {
                Message = "طول کم";
                return false;
            }

            string[] splits = str.Split(':');

            if (splits.Length != 2)
            {
                Message = "فرمت غلط";
                return false;
            }

            int tmp = 0;
            if (int.TryParse(splits[0], out tmp))
            {
                if (tmp < 0 || tmp > 24)
                {
                    Message = "ساعت";
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
                if (tmp > 60 || tmp < 0)
                {
                    Message = "دقیقه";
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

        public int Hour
        {
            get
            {
                int res = 0;
                try
                {
                    res = int.Parse( Text.Substring(0, 2));
                }
                catch (Exception) { }

                return res;
            }
        }

        public int Minute
        {
            get
            {
                int res = 0;
                try
                {
                    res = int.Parse(Text.Substring(3, 2));
                }
                catch (Exception) { }

                return res;
            }
        }
    }
}

