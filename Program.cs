using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hengam.Forms;
using Hengam.Forms.Store;
using StandardWidgets;

namespace Hengam
{
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //testTimeSchedule();
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //MainForm = new CoolFrom.CoolForm();
            MainForm = new frmMain();
            Application.Run(MainForm);
            //Application.Run(new frmStoreAffairs());
        }

        //public static CoolFrom.CoolForm MainForm;

        public static frmMain MainForm;
        public static BusinessObjectNamespace.DesktopUsersBO User;

        public static void AddForm(IPaneled panel, string caption)
        {
            MainForm.AddForm(panel.MainPanel, caption);
        }

        public static void AddForm(Form form)
        {
            MainForm.AddForm(form);
        }

        public static void SetMsg(string msg)
        {
            MainForm.SetMsg(msg);
        }

        public static void HideMsg()
        {
            MainForm.HideMsg();
        }

        public static void SetStatus(string msg)
        {
            MainForm.SetStatus(msg);
        }

        public static string Username
        {
            get { return User.Username; }
        }

        public static bool LoggedIn = false;

        private static Guid mLoginID;
        public static Guid LoginID
        {
            get { return mLoginID; }
            set { mLoginID = value; }
        }
    }
}