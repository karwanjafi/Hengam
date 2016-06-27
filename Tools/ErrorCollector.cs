using System;
using System.Collections.Generic;
using System.Text;
using FarsiMessageBox;

namespace Hengam.Tools
{
    public class ErrorCollector
    {
        public List<string> errMsgs = new List<string>();
        public void Add(string errField)
        {
            Add(errField, true);
        }

        public void Add(string Msg, bool CreateMsg)
        {
            string msgEntry = "";
            switch (CreateMsg)
            {
                case false:
                    msgEntry = Msg;
                    break;

                case true:
                    msgEntry = "ورودی در " + Msg + " صحیح نیست.";
                    break;
            }
            errMsgs.Add(msgEntry);
        }

        public void AddComboProblem()
        {
            errMsgs.Add("یکی از مقادیر جعبه های پایین انداختنی هنوز انتخاب نشده.");
        }

        public void ShowErrMsg()
        {
            string msg = "";
            foreach (string s in errMsgs)
            {
                msg += s + "\n";
            }
            MessageBoxEx.Show(msg, "", "ورودی نا معتبر", false);
        }

        public bool HasError
        {
            get { return errMsgs.Count != 0; }
        }
    }
}
