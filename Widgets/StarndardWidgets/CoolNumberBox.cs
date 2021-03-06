using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolNumberBox : StandardWidgets.CoolValidatorTextBox
    {
        public CoolNumberBox()
        {
            InitializeComponent();

            TextAlign = HorizontalAlignment.Right;
            CanAccept += CanAcceptFunc;
        }

        private long mNumberMin = 0;
        [Browsable(true)]
        public long NumberMin
        {
            get { return mNumberMin; }
            set { mNumberMin = value; }
        }

        private long mNumberMax = 99999999999;
        [Browsable(true)]
        public long NumberMax
        {
            get { return mNumberMax; }
            set { mNumberMax = value; }
        }

        private int mLengthMin = 0;

        public int LengthMin
        {
            get { return mLengthMin; }
            set { mLengthMin = value; }
        }

        private int mLengthMax = 40;

        public int LengthMax
        {
            get { return mLengthMax; }
            set
            { 
                mLengthMax = value;
                //Mask = "";
                //for (int i = 0; i < mLengthMax; i++)
                //    Mask += "0";
            }
        }

        private bool CanAcceptFunc(string str)
        {
            str = ClearSeperator(str);
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
                Message = "طول عدد";
                return false;
            }

            long num = 0;
            if (!long.TryParse(str, out num))
            {
                Message = "فرمت غلط";
                return false;
            }

            if (HaveCurrencySeperator)
            {
                int cursor = CursorLocation;
                int firstLen = base.TextToSet.Length;
                TextToSet = long.Parse(str).ToString();
                if (firstLen == base.TextToSet.Length - 1)
                    CursorLocation = cursor + 1;
                else
                    CursorLocation = cursor;
            }
            if (num > NumberMax || num < NumberMin)
            {
                Message = "محدوده‌ی عدد";
                return false;
            }

            return true;
        }

        private static string ToFarsiCurrency(string currency)
        {
            if (currency == null) return "";
            string ans = "";

            for (int i = currency.Length - 1; i >= 0; i--)
            {
                int j = currency.Length - i - 1;
                if (j > 1 && j % 3 == 0)
                    ans = "," + ans;
                ans = currency[i] + ans;
            }
            return ans;
        }

        private bool mhaveCurrencySeperator = true;
        [Browsable(true), Category("Misc")]
        public bool HaveCurrencySeperator
        {
            get { return mhaveCurrencySeperator; }
            set { mhaveCurrencySeperator = value; }
        }
        


        public new string Text
        {
            get
            {
                return ClearSeperator(base.TextToSet);
            }
            set
            {
                if (!HaveCurrencySeperator)
                    base.TextToSet = value;
                else
                {
                    if (value != "")
                        base.TextToSet = ToFarsiCurrency(value);
                    else
                        base.TextToSet = "";
                }
            }
        }

        private string ClearSeperator(string inStr)
        {
            string tmpStr = inStr;
            string str = "";
            for (int i = 0; i < tmpStr.Length; i++)
            {
                if (tmpStr[i] != ',')
                    str += tmpStr[i];
            }
            return str;
        }

        public new string TextToSet
        {
            get
            {
                return ClearSeperator(base.TextToSet);
            }
            set
            {
                if (!HaveCurrencySeperator)
                    base.TextToSet = value;
                else
                {
                    if (value != "")
                        base.TextToSet = ToFarsiCurrency(value);
                    else
                        base.TextToSet = "";
                }

            }
        }
    }
}

