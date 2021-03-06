using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolTextBox : StandardWidgets.CoolValidatorTextBox
    {
        public CoolTextBox()
        {
            InitializeComponent();
            Mask = "";
            CanAccept += CanAcceptFunc;
        }

        

        private int mLengthMin = 0;

        public int LengthMin
        {
            get { return mLengthMin; }
            set { mLengthMin = value; }
        }

        private int mLengthMax = 1000000;

        public int LengthMax
        {
            get { return mLengthMax; }
            set { mLengthMax = value; }
        }

        private bool CanAcceptFunc(string str)
        {
            if (str == "")
            {
                if (MustFill)
                {
                    Message = "خالی";
                    return false;
                }
                else
                    return true;
            }
            int len = str.Length;
            if (len < LengthMin || len > LengthMax)
            {
                Message = "طول";
                return false;
            }
            return true;
        }

   
    }
}

