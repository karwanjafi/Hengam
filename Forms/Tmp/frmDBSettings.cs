using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CoolFrom;
using System.IO;
using FarsiMessageBox;
using FarsiLibrary.Utils;
using Tools;
using Hengam.Tools;

namespace Hengam.Forms
{
    public partial class frmDBSettings : Form, IPaneled
    {
      
        public frmDBSettings()
        {
            InitializeComponent();

            DialogResult = DialogResult.None;
            LoadBackups();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ApplicationConfig config = new ApplicationConfig();
                config.ServerAddress = txtServerAddress.Text;
                string path = Utility.ApplicationPath();
                config.Save(path += "Config\\Config.xml");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBoxEx.Show("مشکلی در هنگام ذخیره‌سازی پیش آمد." + "\n" + "آدرس مربوط به فایل تنظیمات صحیح نمی‌باشد.");
            }
            DialogResult = DialogResult.None;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ApplicationConfig config = new ApplicationConfig();
            try
            {
                string path = Utility.ApplicationPath();
                config.Load(path += "Config\\Config.xml");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBoxEx.Show("مشکلی در هنگام ذخیره‌سازی پیش آمد." + "\n" + "آدرس مربوط به فایل تنظیمات صحیح نمی‌باشد.");
            }
            txtServerAddress.Text = config.ServerAddress;
            DialogResult = DialogResult.None;
        }

        public static string GetConnectionString()
        {
            ApplicationConfig config = new ApplicationConfig();

            try
            {
                string path = Utility.ApplicationPath();
                config.Load(path += "Config\\Config.xml");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBoxEx.Show("مشکلی در هنگام ذخیره‌سازی پیش آمد." + "\n" + "آدرس مربوط به فایل تنظیمات صحیح نمی‌باشد.");
            }

            //string conStr = string.Format(@"Data Source={0}\SQLEXPRESS;Initial Catalog=daneshvaran;User ID=sa;Password=philips541khamid", config.ServerAddress);
            string conStr = string.Format(@"Data Source={0};Initial Catalog=hengam;User ID=sa;Password=philips541khamid", config.ServerAddress);
            // Data Source=SERVERC\SQLEXPRESS;Initial Catalog=daneshvaran;User ID=sa
            return conStr;
        }

        public static bool IsDatabaseOK(string conStr, out string ErrorMsg)
        {
            SqlConnection con = new SqlConnection(conStr);
            string errMsg = "";
            try
            {
                con.Open();
                con.Close();
            }
            catch (SqlException sqlEx)
            {
                errMsg = sqlEx.Number.ToString() + "\n" + sqlEx.Message;
            }
            catch (Exception ex)
            {
                errMsg += "\n" + ex.Message;
            }

            if (errMsg == "")
            {
                ErrorMsg = "";
                return true;
            }
            else
            {
                ErrorMsg = errMsg;
                return false;
            }
        }

        public static bool IsDatabaseOK(out string ErrorMsg)
        {
            return IsDatabaseOK(GetConnectionString(), out ErrorMsg);
        }

        private void btnTestDB_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            txtTestResult.Text = "Testing progress is started,\nPlease wait a few seconds...";
            Application.DoEvents();
            if (!IsDatabaseOK(out errMsg))
            {
                txtTestResult.Text = "There's an error with these details:\n" + errMsg;
            }
            else
            {
                txtTestResult.Text = "Everything is Ok with Database.";
            }
            DialogResult = DialogResult.None;
        }

        public string BackupPath = "Backup\\";
        private void LoadBackups()
        {
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(Utility.ApplicationPath() + BackupPath);
                FileInfo[] files = dirs.GetFiles("Zeitoon*.bak");

                lstBackups.Items.Clear();
                foreach (FileInfo file in files)
                {
                    int i =lstBackups.Items.Add(new BackupFile(file));
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("مشکلی در پیدا کردن فایل‌های پشتیبان پیش آمد.");
            }
        }

        #region IPaneled Members

        public Panel MainPanel
        {
            get { return pnlMain; }
        }

        #endregion

        private void lstBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBackups.SelectedItem == null) return;
            FileInfo f = ((BackupFile)lstBackups.SelectedItem).fileInfo;
            lblFileName.Text = f.Name;

            string dtString = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(f.CreationTimeUtc).ToWritten();
            lblFileDate.Text = dtString;
        }

        private void frmDBSettings_Load(object sender, EventArgs e)
        {

        }


        private bool BackupDateBase(string filePath)
        {
            bool Success = true;

            string commandString =
                string.Format(@" BACKUP DATABASE [zeitoon] TO  DISK = N'{0}' WITH NOFORMAT, NOINIT,  NAME = N'zeitoon-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 "+
                " ", filePath);

            SqlCommand command = new SqlCommand();
            command.CommandText = commandString;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessNamespace.DataAccess.connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    //command.CommandText = commandString;
                    int tmp =(JobLogger.RunCommandNonQuery(command));
                }
            }
            catch (Exception)
            {
                Success = false;
            }
            return Success;
        }


        private bool ResotreDatabase(string filePath)
        {
            bool Success = true;

            string commandString =
                string.Format(@" RESTORE DATABASE [zeitoon] FROM  DISK = N'{0}' WITH  FILE = 3,  NOUNLOAD,  REPLACE,  STATS = 10 " +
                " ", filePath);

            SqlCommand command = new SqlCommand();
            command.CommandText = commandString;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessNamespace.DataAccess.connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    //command.CommandText = commandString;
                    int tmp = (JobLogger.RunCommandNonQuery(command));
                }
            }
            catch (Exception)
            {
                Success = false;
            }
            return Success;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            PersianDate pd = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(DateTime.UtcNow);

            string fName = "Zeitoon" + pd.Year.ToString() + UtilityTxt.To2Digit(pd.Month) + UtilityTxt.To2Digit(pd.Day) + ".bak";
            string path = Utility.ApplicationPath() + BackupPath;

            dlgSaveBackup.FileName = fName;
            dlgSaveBackup.DefaultExt = "bak";
            dlgSaveBackup.InitialDirectory = path;
            dlgSaveBackup.Title = "Select the path to make backup.";

            dlgSaveBackup.ShowDialog();

            path = dlgSaveBackup.FileName;
            
            bool IsSure = true;

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                IsSure = (MessageBoxEx.Show("نسخه‌ی پشتیبانی با تاریخ امروز وجود دارد، آیا می‌خواهید نسخه‌ی جدید ذخیره و نسخه‌ی قلبی از بین برود؟", "", "پشتیبانی", true)== DialogResult.OK);
            }

            if (IsSure)
            {
                lblBackupStatus.Text = "در حال گرفتن پشتیبان، لطفاً چند لحظه صبر کنید...";
                Application.DoEvents();
                BackupDateBase(path);
                lblBackupStatus.Text = "پشتیبان‌گیری با موفقیت انجام شد.";

                LoadBackups();
            }
            else
            {
                lblBackupStatus.Text = "پشتیبان گرفته نشد.";
            }

            DialogResult = DialogResult.None;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (lstBackups.SelectedItem == null)
            {
                lblRestoreStatus.Text = "هیچ فایلی انتخاب نشده است.";
            }
            else
            {

                PersianDate pd = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(DateTime.UtcNow);

                string fName = "Zeitoon" + pd.Year.ToString() + UtilityTxt.To2Digit(pd.Month) + UtilityTxt.To2Digit(pd.Day) + "[BeforeResotre].bak";
                string path = Utility.ApplicationPath() + BackupPath + fName;
                lblRestoreStatus.Text = "در حال گرفتن پشتیبان از اطلاعات موجود، لطفاً چند لحظه صبر کنید...";
                Application.DoEvents();

                if (BackupDateBase(path))
                {
                    lblRestoreStatus.Text = "پشتیبان‌گیری قبل از بازیابی با موفقیت انجام شد،" + "\n" + "در حال بازیابی...";
                    Application.DoEvents();
                    string restorePath = ((BackupFile)lstBackups.SelectedItem).fileInfo.FullName;
                    ResotreDatabase(restorePath);

                    lblRestoreStatus.Text = "بازیابی با موفقیت انجام شد.";
                }
                else
                {
                    lblRestoreStatus.Text = "مشکلی در پشتیبان گیری قبل از بازیابی پیش آمد.";
                }

                LoadBackups();
            }
            DialogResult = DialogResult.None;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }

    class BackupFile
    {
        public FileInfo fileInfo;
        public BackupFile(FileInfo f)
        {
            fileInfo = f;
        }
        public override string ToString()
        {
            return fileInfo.Name;
        }
    }
}