using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolNumberFloatBox : StandardWidgets.CoolValidatorTextBox
    {
        public CoolNumberFloatBox()
        {
            InitializeComponent();
            TextAlign = HorizontalAlignment.Right;
            CanAccept += CanAcceptFunc;
        }

        private double mNumberMin = 0;
        [Browsable(true)]
        public double NumberMin
        {
            get { return mNumberMin; }
            set { mNumberMin = value; }
        }

        private double mNumberMax = 1000000.0;
        [Browsable(true)]
        public double NumberMax
        {
            get { return mNumberMax; }
            set { mNumberMax = value; }
        }

        private int mPrecisionLengthMin = 0;

        public int PrecisionLengthMin
        {
            get { return mPrecisionLengthMin; }
            set { mPrecisionLengthMin = value; }
        }

        private int mPrecisionLengthMax = 2;

        public int PrecisionLengthMax
        {
            get { return mPrecisionLengthMax; }
            set
            { 
                mPrecisionLengthMax = value;
                //Mask = "";
                //for (int i = 0; i < mLengthMax; i++)
                //    Mask += "0";
            }
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


            double num = 0;
            if (!double.TryParse(str, out num))
            {
                Message = "فرمت غلط";
                return false;
            }

            if (num > NumberMax || num < NumberMin)
            {
                Message = "محدوده‌ی عدد";
                return false;
            }

            int len = 0;
            string[] splits = str.Trim().Split('.');
            if (splits.Length == 1) len = 1;
            else len = splits[1].Length;
            if (len < PrecisionLengthMin || len > PrecisionLengthMax)
            {
                Message = "طول اعشار";
                return false;
            }

            return true;
        }
    }
}

