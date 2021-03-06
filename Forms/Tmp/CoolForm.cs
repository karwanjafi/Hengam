using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoolMenu;
using FarsiMessageBox;
using FarsiLibrary.Win;
using FarsiLibrary.Win.Controls;
using FarsiLibrary.Win.Enums;
using Hengam;
using BusinessObjectNamespace;
using Tools;
using Hengam.Tools;
using Hengam.Forms;

namespace CoolFrom
{
    public partial class CoolForm : Form
    {
        public CoolForm()
        {
            InitializeComponent();

            // Loading Theme...
            CoolMenuTheme theme = new CoolMenuTheme();
            string[] parts = Application.ExecutablePath.Split('\\');
            string path = "";
            for (int i = 0; i < parts.Length - 1; i++)
            {
                path += parts[i] + "\\";
            }
            path += "Theme\\";
            theme.RootPath = path;
            theme.Load(path + "theme.xml");

            try
            {
                theme.Use(coolMenu1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private frmStudentManager fStudentManager = null;
        public bool LoggedIn = false;
        private static DesktopUserDetailsBO UserBO;
        public static string Username
        {
            get { return UserBO.Username; }
        }

        private static Guid mLoginID;
        public static Guid LoginID
        {
            get { return mLoginID; }
            set { mLoginID = value; }
        }

        private void DBSettings(object sender, EventArgs e)
        {
            frmDBSettings fDB = new frmDBSettings();
            AddForm(fDB);
        }


        PanelModifier pmCourses;
        frmChangePassword fChangePassword;

        private void Form1_Load(object sender, EventArgs e)
        {
            frmSplash fSplash = new frmSplash();
            fSplash.Init();
            

            lblLoginTime.Text = FaDate.Now.ToWritten() + " ساعت " + FaDate.CurrentTimeString;
            // Security

            frmLogin fLogin = new frmLogin();
            LoggedIn = false;
            while (!LoggedIn)
            {
                DialogResult dr = fLogin.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    UserBO = fLogin.UserBO;
                    LoggedIn = fLogin.LoggedIn;
                }
                else if (dr == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                    break;
                }
            }

            lblUsername.Text = UserBO.Username;
            lblEmployeeName.Text = UserBO.EmployeeFirstName + " " + UserBO.EmployeeLastName;

            mLoginID = Guid.NewGuid();
            LoginDetailsBO log = new LoginDetailsBO();
            log.loginID = LoginID;
            log.loginDate = FaDate.CurrentFaDateString;
            log.loginTime = FarsiLibrary.Utils.PersianDate.Now.Time.ToString();
            log.username = UserBO.Username;
            log.privilegedGrant = "-";
            log.Add();
            JobLogger.loginID = LoginID;
            JobLogger.Enabled = false;


            //lblTerm.Text = "سال " + Term.CurrentTerm.Year.ToString() + " ترم " + Term.CurrentTerm.Season.ToString();

            // Setting Change password panel.

            pmCourses = new PanelModifier(pnlChangePassword);
            fChangePassword = new frmChangePassword(pmCourses);
            Panel pnlCourse = (fChangePassword as IPaneled).MainPanel;
            pnlChangePassword.Controls.Add(pnlCourse);
            pnlCourse.Dock = DockStyle.Fill;
            
            
            
            
            
            
            LoadCapablities(UserBO);

        }

        void ShowMsgBox(object obj, EventArgs e)
        {
            //MessageBox.Show("اين يك پيغام فارسي در پنجره پيغام فارسي است", "هنوز آيكون نداره"+"!");
            MessageBoxEx.Show("اين يك پيغام فارسي در پنجره پيغام فارسي است");
        }

        /// <summary>
        /// Adds a tab to the MainTabStrip of the Main Form.
        /// </summary>
        /// <param name="f">A form that supposed to have IPaneled Interface</param>
        /// <param name="Title">Title which will be shown on the strip</param>
        public void AddForm(IPaneled f, string Title)
        {
            /*
            if (!(f is IPaneled))
            {
                MessageBox.Show("Programming Error, Cant add this type of form. Forms to add suppose to have IPaneled Interface.");
                return;
            }*/
            //IPaneled ip = (IPaneled)f;
            IPaneled ip = f;
            Panel backPan = new Panel();

            backPan.SuspendLayout();
            ip.MainPanel.SuspendLayout();
            tabMain.SuspendLayout();
            this.SuspendLayout();
            backPan.Visible = false;
            ip.MainPanel.Visible = false;
            {
                backPan.BackColor = Color.White;
                backPan.Padding = new Padding(3);
                backPan.Controls.Add(ip.MainPanel);
                backPan.Dock = DockStyle.Fill;
                ip.MainPanel.Dock = DockStyle.Fill;

                // ToDo: Setting Nexter.

                FATabStripItem tab = new FATabStripItem(Title, backPan);
                //tabMain.AddTab(tab, true);
                tabMain.Items.Insert((tabMain.Items.Count>0?tabMain.Items.Count:0), tab);
                tabMain.SelectedItem = tab;
                //tabMain.SelectedItem = tab;
            }

            backPan.ResumeLayout();
            tabMain.ResumeLayout();
            ip.MainPanel.ResumeLayout();
            this.ResumeLayout();
            backPan.Visible = true;
            Application.DoEvents();
            try
            {
                ip.MainPanel.Visible = true;
            }
            catch (InvalidOperationException)
            {
                ip.MainPanel.Visible = true;
            }
        }

        /// <summary>
        /// Adds a tab to the MainTabStrip of the Main Form.
        /// </summary>
        /// <param name="f">A form that supposed to have IPaneled Interface, Title will consider as the form's Title</param>
        public void AddForm(Form f)
        {
            AddForm((IPaneled)f, f.Text);
        }


        private Control FindNextControl(Control cc)
        {
            Control nextControl = cc.Parent.GetNextControl(cc, true);
            return nextControl;


            /*
            Control actControl;
            do
            {
                actControl = this.ActiveControl;
                if (actControl is FarsiLibrary.Win.FATabStripItem)
                {
                    actControl = actControl.Controls[0];
                }
                this.SelectNextControl(actControl, true, true, true, true);
            } while (!(actControl is TextBox || actControl is ComboBox));
            */
        }

        private void btnNexter_Click(object sender, EventArgs e)
        {
            Control actControl = this.ActiveControl;
            if (actControl == null) return;

            try
            {
                while (actControl != actControl.GetContainerControl().ActiveControl)
                {
                    actControl = actControl.GetContainerControl().ActiveControl;
                }
            }
            catch (Exception) { }

            //SendKeys.Send("\t");

            this.SelectNextControl(actControl, true, true, true, true);

        }

        private void lblSignOut_MouseHover(object sender, EventArgs e)
        {
            lblSignOut.ForeColor = Color.Red;
        }

        private void lblSignOut_MouseLeave(object sender, EventArgs e)
        {
            lblSignOut.ForeColor = Color.Blue;
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            SignOut();
        }

        private void SignOut()
        {
            if (MessageBoxEx.Show("آیا می‌خواهید از سیستم خارج شوید؟", "", "هشدار", true) == DialogResult.OK)
                Application.Exit();
            //Application.Exit();
            /*
            coolMenu1.BeginUpdate();
            {
                coolMenu1.CoolGroups.Clear();
            }
            coolMenu1.EndUpdate();

            Application.DoEvents();

            tabMain.Items.Clear();
            Form1_Load(null, null);
            */ 
        }


        private CoolGroup gEducationBasicinfo = new CoolGroup();
        private CoolGroup gEducationOperations = new CoolGroup();
        private CoolGroup gEducationReports = new CoolGroup();
        private CoolGroup gFinancialReports = new CoolGroup();
        private CoolGroup gSystemManager = new CoolGroup();
        private CoolGroup gFinancialManager = new CoolGroup();

        
        public enum Capablity
        {
            CanStudentManager,
            CanProfessorManager,
            CanEmployeeManager,
            CanComboDefaultManager,
            CanCourseManager,
            CanCoursePriceManager,
            CanCourseSelectionValidationAmoozesh,
            CanCourseSelectionValidationFinancial,
            CanDefaultProgramManager,
            CanDepartmentManager,
            CanDesktopUserManager,
            CanEnforcedCorequisiteManager,
            CanFacultyManager,
            CanMajorManager,
            CanScoreManager,
            CanSectionManager,
            CanTimeManager,
            CanExamList,
            CanCourseSelectionManagerSystem,
            CanCourseSelectionManagerAmoozesh,
            CanStudentChecklist,
            CanSpecifyStudentID,
            CanPayList, 
            CanStudentGuestOutManager,
            CanStudentTransferInManager,
            CanStudentTransferOutManager,
            CanMinstaryMajorCodeManager,
            CanCourseEquivalenceManager,
            CanDBSettings,
            CanConstantFeeManager,
            CanStudentGuestInManager,
            CanStudentDiscountManager,
            CanCourseSelectionPayManager,
            CanPresenceList,
            CanMustPayList,
            CanStudentPayStatus,
            CanSectionMovement,
            CanStudentGiveUpManager,
            CanStudentBreakManager,
            CanStudentList,
            CanRegisterationInformation,
            CanSpecialStudentManager,
            CanTermTranscript,
            CanSectionCapacityDetails,
            CanOveralTranscript,
            CanMohsenStudents,
            CanAverageAStudents,
            CanStudentCard,
            CanFinancialSummary,
            CanDuplicateStudentCard,
            CanIntroSectionManager
        }
        void AddCapablity(Capablity cap)
        {
            switch (cap)
            {
 
                //case Capablity.CanIntroSectionManager:
                //    gEducationOperations.AddLink("معرفی به استاد", "Reports", IntroSectionManager);
                //    break;

                default:
                    break;
            }

        }

        void LoadCapablities(DesktopUserBO user)
        {



            gEducationBasicinfo.BeginUpdate();
            gEducationOperations.BeginUpdate();
            gFinancialReports.BeginUpdate();
            gEducationReports.BeginUpdate();
            gFinancialManager.BeginUpdate();
            gSystemManager.BeginUpdate();
            {
                /*
                gEducationBasicinfo.ContentsBackgroundImage = pictureBox2.Image;
                gEducationBasicinfo.BackgroundColor = Color.Transparent;
                gEducationBasicinfo.TitleBackgroundImage = pictureBox3.Image;

                gEducationOperations.ContentsBackgroundImage = pictureBox2.Image;
                gEducationOperations.BackgroundColor = Color.Transparent;
                gEducationOperations.TitleBackgroundImage = pictureBox3.Image;

                gEducationReports.ContentsBackgroundImage = pictureBox2.Image;
                gEducationReports.BackgroundColor = Color.Transparent;
                gEducationReports.TitleBackgroundImage = pictureBox3.Image;

                gFinancialManager.ContentsBackgroundImage = pictureBox2.Image;
                gFinancialManager.BackgroundColor = Color.Transparent;
                gFinancialManager.TitleBackgroundImage = pictureBox3.Image;

                gSystemManager.ContentsBackgroundImage = pictureBox2.Image;
                gSystemManager.BackgroundColor = Color.Transparent;
                gSystemManager.TitleBackgroundImage = pictureBox3.Image;

                */



                gEducationBasicinfo.Text = "اطلاعات پایه آموزش";
                gEducationBasicinfo.links.Clear();

                gEducationOperations.Text = "عملیات آموزش";
                gEducationOperations.links.Clear();

                gEducationReports.Text = "گزارش‌های آموزش";
                gEducationReports.links.Clear();

                gFinancialReports.Text = "گزارش‌های مالی";
                gFinancialReports.links.Clear();

                gSystemManager.Text = "مدیریت سیستم";
                gSystemManager.links.Clear();

                gFinancialManager.Text = "امور مالی";
                gFinancialManager.links.Clear();


                if (user.CanStudentManager)
                    AddCapablity(Capablity.CanStudentManager);

                if (user.CanProfessorManager)
                    AddCapablity(Capablity.CanProfessorManager);

                if (user.CanEmployeeManager)
                    AddCapablity(Capablity.CanEmployeeManager);
                
                if (user.CanComboDefaultManager)
                    AddCapablity(Capablity.CanComboDefaultManager);

                if (user.CanCourseManager)
                    AddCapablity(Capablity.CanCourseManager);

                if (user.CanCoursePriceManager)
                    AddCapablity(Capablity.CanCoursePriceManager);

                if (user.CanCourseSelectionValidationAmoozesh)
                    AddCapablity(Capablity.CanCourseSelectionValidationAmoozesh);

                if (user.CanCourseSelectionValidationFinancial)
                    AddCapablity(Capablity.CanCourseSelectionValidationFinancial);

                if (user.CanDefaultProgramManager)
                    AddCapablity(Capablity.CanDefaultProgramManager);

                if (user.CanDepartmentManager)
                    AddCapablity(Capablity.CanDepartmentManager);

                if (user.CanDesktopUserManager)
                    AddCapablity(Capablity.CanDesktopUserManager);



                if (user.CanEnforcedCorequisiteManager)
                    AddCapablity(Capablity.CanEnforcedCorequisiteManager);

                if (user.CanExamList)
                    AddCapablity(Capablity.CanExamList);

                if (user.CanFacultyManager)
                    AddCapablity(Capablity.CanFacultyManager);

                if (user.CanMajorManager)
                    AddCapablity(Capablity.CanMajorManager);



                if (user.CanScoreManager)
                    AddCapablity(Capablity.CanScoreManager);

                if (user.CanSectionManager)
                    AddCapablity(Capablity.CanSectionManager);



                if (user.CanTimeManager)
                    AddCapablity(Capablity.CanTimeManager);

                if (user.CanSpecifyStudentID)
                    AddCapablity(Capablity.CanSpecifyStudentID);

                if ( user.CanStudentCheckList)
                    AddCapablity(Capablity.CanStudentChecklist);

                if ( user.CanCourseSelectionManagerAmoozesh)
                    AddCapablity(Capablity.CanCourseSelectionManagerAmoozesh);

                if ( user.CanCourseSelectionManagerSystem )
                    AddCapablity(Capablity.CanCourseSelectionManagerSystem);

                if ( user.CanPayList)
                    AddCapablity(Capablity.CanPayList);
                
                if (user.CanStudentTransferInManager)
                    AddCapablity(Capablity.CanStudentTransferInManager);

                if ( user.CanStudentTransferOutManager)
                    AddCapablity(Capablity.CanStudentTransferOutManager);

                if (user.CanStudentGuestInManager)
                    AddCapablity(Capablity.CanStudentGuestInManager);
                
                if ( user.CanStudentGuestOutManager)
                    AddCapablity(Capablity.CanStudentGuestOutManager);

                if ( user.CanMinstaryMajorCodeManager )
                    AddCapablity(Capablity.CanMinstaryMajorCodeManager);

                if ( user.CanCourseEquivalenceManager)
                    AddCapablity(Capablity.CanCourseEquivalenceManager);

                if ( user.CanDBSettings)
                    AddCapablity(Capablity.CanDBSettings);

                if ( user.CanConstantFeeManager)
                    AddCapablity(Capablity.CanConstantFeeManager);

                if (user.CanStudentDiscountManager)
                    AddCapablity(Capablity.CanStudentDiscountManager);

                if (user.CanPresenceList)
                    AddCapablity(Capablity.CanPresenceList);

                if (user.CanMustPayList)
                    AddCapablity(Capablity.CanMustPayList);

                if (user.CanCourseSelectionPayManager)
                    AddCapablity(Capablity.CanCourseSelectionPayManager);

                if (user.CanStudentPayManager)
                    AddCapablity(Capablity.CanStudentPayStatus);

                if (user.CanSectionMovement)
                    AddCapablity(Capablity.CanSectionMovement);

                if (user.CanStudentGiveUpManager)
                    AddCapablity(Capablity.CanStudentGiveUpManager);

                if (user.CanStudentBreakManager)
                    AddCapablity(Capablity.CanStudentBreakManager);

                if (user.CanStudentList)
                    AddCapablity(Capablity.CanStudentList);

                if ( user.CanRegisterationInformation)
                    AddCapablity(Capablity.CanRegisterationInformation);
                
                if ( user.CanSpecialStudents)
                    AddCapablity(Capablity.CanSpecialStudentManager);

                if (user.CanSectionCapacityDetails)
                    AddCapablity(Capablity.CanSectionCapacityDetails);

                if (user.CanTermTranscript)
                    AddCapablity(Capablity.CanTermTranscript);

                if (user.CanOveralTranscript)
                    AddCapablity(Capablity.CanOveralTranscript);

                if (user.CanMohsenStudents)
                    AddCapablity(Capablity.CanMohsenStudents);

                if (user.CanAverageAStudents)
                    AddCapablity(Capablity.CanAverageAStudents);

                if (user.CanStudentCard)
                    AddCapablity(Capablity.CanStudentCard);

                if (user.CanFinancialSummary)
                    AddCapablity(Capablity.CanFinancialSummary);

                if (user.CanDuplicateStudentCard)
                    AddCapablity(Capablity.CanDuplicateStudentCard);

                if (user.CanIntroSectionManager)
                    AddCapablity(Capablity.CanIntroSectionManager);

            }
            /*
            gEducationBasicinfo.EndUpdate();
            gEducationOperations.EndUpdate();
            gEducationReports.EndUpdate();
            gFinancialManager.EndUpdate();
            gSystemManager.EndUpdate();*/

            //CoolMenuTheme theme = new CoolMenuTheme();
            //string[] parts = Application.ExecutablePath.Split('\\');
            //string path = "";
            //for (int i = 0; i < parts.Length - 1; i++)
            //{
            //    path += parts[i] + "\\";
            //}
            //path += "Theme\\";
            //theme.RootPath = path;
            //theme.Load(path + "theme.xml");

            //try
            //{
            //    theme.Use(coolMenu1);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            coolMenu1.BeginUpdate();
            {
                //coolMenu1.VerticalMargin = 170;
                coolMenu1.DistanceBetweenBoxes = 10;
                coolMenu1.ImageList = imageList1;
                coolMenu1.CoolGroups.Clear();

                if (gEducationBasicinfo.links.Count > 0)
                {
                    gEducationBasicinfo.EndUpdate();
                    coolMenu1.AddGroup(gEducationBasicinfo);
                }
                if (gEducationOperations.links.Count > 0)
                {
                    gEducationOperations.EndUpdate();
                    coolMenu1.AddGroup(gEducationOperations);
                }

                if (gFinancialReports.links.Count > 0)
                {
                    gFinancialReports.EndUpdate();
                    coolMenu1.AddGroup(gFinancialReports);
                }

                if (gEducationReports.links.Count > 0)
                {
                    gEducationReports.EndUpdate();
                    coolMenu1.AddGroup(gEducationReports);
                }
                if (gFinancialManager.links.Count > 0)
                {
                    gFinancialManager.EndUpdate();
                    coolMenu1.AddGroup(gFinancialManager);
                }
                if (gSystemManager.links.Count > 0)
                {
                    gSystemManager.EndUpdate();
                    coolMenu1.AddGroup(gSystemManager);
                }
            }

            foreach (CoolGroup gg in coolMenu1.CoolGroups)
            {
                {
                    gg.lblTitle_LinkClicked(null, null);
                }
            }

            coolMenu1.EndUpdate();




        }

        public static void SetStatus(string Msg)
        {
            Program.MainForm.lblStatus.Text = Msg;
        }

        public static void StartImportantMsg(string msg)
        {
            StartImportantMsg(msg, false, 0);
        }

        public static void StartImportantMsg(string msg, bool ShowProgressBar, int progressValue)
        {

            CoolForm f = Program.MainForm;
            Panel p = Program.MainForm.pnlImportantMsg;
            f.prgrsJobState.Value = progressValue;
            f.lblImportantMsg.Text = msg;
            p.Left = (f.tabMain.Width - p.Width) / 2;
            p.Top = (f.tabMain.Height - p.Height) / 2;
            p.Visible = true;
            p.BringToFront();
            Application.DoEvents();
        }

        public static void EndImportantMsg()
        {
            Application.DoEvents();
            Program.MainForm.pnlImportantMsg.Visible = false; ;
            Program.MainForm.lblImportantMsg.Text = "";
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            fChangePassword.Set(Username);
            pmCourses.Show();
        }

        private void lblChangePassword_MouseHover(object sender, EventArgs e)
        {
            lblChangePassword.ForeColor = Color.Red;
        }

        private void lblChangePassword_MouseLeave(object sender, EventArgs e)
        {
            lblChangePassword.ForeColor = Color.Blue;
        }

        private void CoolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            JobLogger.CommitAll();
        }
   }   
}