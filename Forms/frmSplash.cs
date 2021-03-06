using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using Tools;

namespace Hengam.Forms
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public void Log(string str)
        {
            lstLogger.Items.Add(str);
            Application.DoEvents();
        }


        public void Init()
        {
            this.Show();
            Application.DoEvents();

            Log("سیستم در حال بررسی پایگاه داده می‌باشد.");
            if (!TestDB())
            {
                Log("مشکل پایگاه داده رفع نشد.");
                return;
            }
            Log("پایگاه داده با موفقیت بررسی شد.");

            Log("در حال همزمان سازی اطلاعات با پایگاه داده");
            SyncTime();
            Log("همزمان سازی با موفقیت انجام شد.");

            this.Hide();
            Application.DoEvents();
        }

        private static void SyncTime()
        {
            // Synch Date and Time with server.
            FaDate.SynchWithServer();
            

        }

        private bool TestDB()
        {
            // Database Testing...

            
            string errMsg = "";
            while (!frmDBSettings.IsDatabaseOK(out errMsg))
            {
                MessageBoxEx.Show("تنظیمات پایگاه داده صحیح نمی‌باشد.");
                frmDBSettings fDBSettings = new frmDBSettings(false);
                if (fDBSettings.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                    return false;
                }
            }

            DataAccessNamespace.DataAccess.connectionString = frmDBSettings.GetConnectionString();
            DataAccessNamespace.DataAccess.ConnectToDB(); //hanieh
            

            return true;

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}