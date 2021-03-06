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
using Zeitoon;
using Zeitoon.Reports.Report_Papers;
using Zeitoon.Reports.Datasets;
using System.Data.SqlClient;
using Zeitoon.UtilityForms;
using Zeitoon.Tools;
using Zeitoon;

namespace CoolFrom
{
    public delegate void PanelLoadDelegate(object sender, EventArgs e);
    public interface IPaneled
    {
        Panel MainPanel
        {
            get;
        }
    }
    public partial class CoolForm : Form
    {
        public CoolForm()
        {
            InitializeComponent();
        }

        //private frmStudentManager fStudentManager = null;
        private void RunStudentManager(object sender, EventArgs e)
        {
            frmStudentManager fStudent = new frmStudentManager(UserBO.HasRemoveGrant);
            AddForm(fStudent);
        }

        private void MajorManager(object sender, EventArgs e)
        {
            frmMajorManager mManager = new frmMajorManager(UserBO.HasRemoveGrant);
            AddForm(mManager);
        }

        private void DepartmentManager(object sender, EventArgs e)
        {
            frmDepartmentManager dManager = new frmDepartmentManager(false);
            AddForm(dManager);
        }
        
        private void FacultyManager(object sender, EventArgs e)
        {
            frmFacultyManager fManager = new frmFacultyManager(UserBO.HasRemoveGrant);
            AddForm(fManager);
        }

        private void RunCourseManager(object sender, EventArgs e)
        {
            frmCourseManager fCourse = new frmCourseManager(UserBO.HasRemoveGrant);
            AddForm(fCourse);
        }

        private void RunProfessorManager(object sender, EventArgs e)
        {
            frmProfessorManager fProfessor = new frmProfessorManager(UserBO.HasRemoveGrant);
            AddForm(fProfessor);
        }

        private void RunEmployeeManager(object sender, EventArgs e)
        {
            frmEmployeeManager fEmployee = new frmEmployeeManager();
            AddForm(fEmployee);
        }

        private void ScoreManager(object sender, EventArgs e)
        {
            frmScoreManager fScore = new frmScoreManager();
            AddForm(fScore);
        }
        
        private void CoursePriceManager(object sender, EventArgs e)
        {
            frmCoursePriceManager fCoursePrice = new frmCoursePriceManager();
            AddForm(fCoursePrice);
        }
        
        private void SystemSettings(object sender, EventArgs e)
        {
            frmComboDefaultManager fCombo = new frmComboDefaultManager();
            AddForm(fCombo);
        }

        private void RunStudentFinancialValidation(object sender, EventArgs e)
        {
            frmUnFinancialStudentsManager fValidation = new frmUnFinancialStudentsManager(null);
            AddForm(fValidation);
        }

        private void CourseSelectionManagerSystem(object sender, EventArgs e)
        {
            frmCourseSelectionManager fValidation = new frmCourseSelectionManager();
            AddForm(fValidation);
        }

        private void CourseSelectionManagerAmoozesh(object sender, EventArgs e)
        {
            frmCourseSelectionManagerAmoozesh fValidation = new frmCourseSelectionManagerAmoozesh(UserBO.CanChangeFinancialFlag, UserBO.CanChangeEducationFlag, UserBO.CanChangeStudentFinalFlag);
            AddForm(fValidation);
        }

        private void StudentChecklist(object sender, EventArgs e)
        {
            frmStudentChecklist fValidation = new frmStudentChecklist();
            AddForm(fValidation);
        }

        private void SpecifyStudentID(object sender, EventArgs e)
        {
            frmStudentIDMaker fValidation = new frmStudentIDMaker();
            AddForm(fValidation);
        }
        
        private void PaymentList(object sender, EventArgs e)
        {
            frmPaymentList fPay = new frmPaymentList();
            AddForm(fPay);
        }

        private void StudentGuestOutManager(object sender, EventArgs e)
        {
            frmStudentGuestOutManager fPay = new frmStudentGuestOutManager();
            AddForm(fPay);
        }

        private void StudentTransferManagerIn(object sender, EventArgs e)
        {
            frmStudentTransferInManager fPay = new frmStudentTransferInManager();
            AddForm(fPay);
        }

        private void StudentTransferManagerOut(object sender, EventArgs e)
        {
            frmStudentTransferOutManager fPay = new frmStudentTransferOutManager();
            AddForm(fPay);
        }

        
        private void RunSectionCapacityDetails(object sender, EventArgs e)
        {
            frmSectionCapacityDetails fPay = new frmSectionCapacityDetails();
            AddForm(fPay);
        }

        private void DesktopUserManager(object sender, EventArgs e)
        {
            frmDesktopUserManager fUser = new frmDesktopUserManager();
            AddForm(fUser);
        }

        private void EnforcedCorequisiteManager(object sender, EventArgs e)
        {
            frmEnforcedCorequisiteManager fEnCo = new frmEnforcedCorequisiteManager();
            AddForm(fEnCo);
        }

        private void RunSpecialStudentManager(object sender, EventArgs e)
        {
            frmSpecialStudentManager fEnCo = new frmSpecialStudentManager();
            AddForm(fEnCo);
        }

        private void RunTermTranscript(object sender, EventArgs e)
        {
            frmTranscriptTerm fTransTerm = new frmTranscriptTerm();
            AddForm(fTransTerm);
        }

        private void CourseSelectionAmoozeshValidation(object sender, EventArgs e)
        {
            frmUnEducationalStudentsManager fValidation = new frmUnEducationalStudentsManager(null);
            AddForm(fValidation);
        }

        private void SectionManager(object sender, EventArgs e)
        {
            frmSectionManager fSection = new frmSectionManager(UserBO.HasRemoveGrant);
            AddForm(fSection);
        }

        private void IntroSectionManager(object sender, EventArgs e)
        {
            frmIntroSection fIntro = new frmIntroSection(UserBO.HasRemoveGrant);
            AddForm(fIntro);
        }

        private void DefaultProgrammeManager(object sender, EventArgs e)
        {
            frmDefaultProgramManager fDefProg = new frmDefaultProgramManager();
            AddForm(fDefProg);
        }
        
        private void TimeManager(object sender, EventArgs e)
        {
            frmTimeManager fTimeManager = new frmTimeManager();
            AddForm(fTimeManager);
        }

        private void ExamList(object sender, EventArgs e)
        {
            frmExamList fExam = new frmExamList();
            AddForm(fExam);
        }

        private void MinistaryMajorCodeManager(object sender, EventArgs e)
        {
            frmMinistaryMajorCodeManager fMin = new frmMinistaryMajorCodeManager();
            AddForm(fMin);
        }

        private void CourseEquivalenceManager(object sender, EventArgs e)
        {
            frmCourseEquivalenceManager fEqui = new frmCourseEquivalenceManager();
            AddForm(fEqui);
        }

        private void DBSettings(object sender, EventArgs e)
        {
            frmDBSettings fDB = new frmDBSettings();
            AddForm(fDB);
        }

        private void ConstantFeeManager(object sender, EventArgs e)
        {
            frmConstantFeeManager fcon = new frmConstantFeeManager();
            AddForm(fcon);
        }

        private void StudentGuestInManager(object sender, EventArgs e)
        {
            frmStudentGuestInManager fGuest = new frmStudentGuestInManager();
            AddForm(fGuest);
        }

        private void RunRegisterationInformation(object sender, EventArgs e)
        {
            frmRegisterationInformationManager fGuest = new frmRegisterationInformationManager();
            AddForm(fGuest);
        }

        private void StudentDiscountManager(object sender, EventArgs e)
        {
            frmStudentDiscountManager fDiscount = new frmStudentDiscountManager();
            AddForm(fDiscount);
        }

        private void CourseSelectionPayManager(object sender, EventArgs e)
        {
            frmCourseSelectionPayManager fPay = new frmCourseSelectionPayManager(null);
            AddForm(fPay);
        }

        private void RunStudentPayStatus(object sender, EventArgs e)
        {
            frmStudentPayStatus fStat = new frmStudentPayStatus(true);
            AddForm(fStat);
        }

        private void RunStudentGiveUpManager(object sender, EventArgs e)
        {
            frmStudentGiveUpManager fGive = new frmStudentGiveUpManager();
            AddForm(fGive);
        }

        private void RunStudentBreakManager(object sender, EventArgs e)
        {
            frmStudentBreakManager fBreak = new frmStudentBreakManager();
            AddForm(fBreak);
        }

        private void RunSectionMovement(object sender, EventArgs e)
        {
            frmSectionMovement fSecMov = new frmSectionMovement();
            AddForm(fSecMov);
        }

        private void StudentList(object sender, EventArgs e)
        {
            frmStudentList fStudList = new frmStudentList();
            AddForm(fStudList);
        }

        private void RunMohsenStudentsReport(object sender, EventArgs e)
        {
            frmMohsenStudents fStudList = new frmMohsenStudents();
            AddForm(fStudList);
        }

        private void RunAverageAStudentsReport(object sender, EventArgs e)
        {
            MessageBoxEx.Show("این قسمت هنوز راه اندازی نشده است" + ".");
        }

        private void RunStudentCardReport(object sender, EventArgs e)
        {
            frmStudentCard fCard = new frmStudentCard();
            AddForm(fCard);
        }

        private void RunDuplicateStudentCard(object sender, EventArgs e)
        {
            frmDuplicateStudentCard fDup = new frmDuplicateStudentCard();
            AddForm(fDup);
        }


        private void RunFinancialSummary(object sender, EventArgs e)
        {
            frmPaymentList fPay = new frmPaymentList();
            string dt = Zeitoon.FaDate.CurrentFaDateString;
            fPay.SetAndGenerateStartupReport(dt, dt);
            AddForm(fPay, "وضعیت چک‌های روز");
            //fPay.Text = "وضعیت چک‌های روز";
            //fPay.Show();
        }

        private void NotImplementedYet(object sender, EventArgs e)
        {
            MessageBoxEx.Show("این قسمت هنوز راه اندازی نشده است"+".");
        }



        
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

        PanelModifier pmCourses;
        frmChangePassword fChangePassword;

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            // Database Testing...

            StartImportantMsg("سیستم در حال بررسی پایگاه داده می‌باشد.");
            string errMsg = "";
            while ( !frmDBSettings.IsDatabaseOK(out errMsg) )
            {
                MessageBoxEx.Show("تنظیمات پایگاه داده صحیح نمی‌باشد.");
                frmDBSettings fDBSettings = new frmDBSettings();
                if (fDBSettings.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }
            EndImportantMsg();

            DataAccess.connectionString = frmDBSettings.GetConnectionString();

            // Synch Date and Time with server.
            FaDate.SynchWithServer();
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


            Term.SetCurrentTerm();
            lblTerm.Text = "سال " + Term.CurrentTerm.Year.ToString() + " ترم " + Term.CurrentTerm.Season.ToString();

            // Setting Change password panel.

            pmCourses = new PanelModifier(pnlChangePassword);
            fChangePassword = new frmChangePassword(pmCourses);
            Panel pnlCourse = (fChangePassword as IPaneled).MainPanel;
            pnlChangePassword.Controls.Add(pnlCourse);
            pnlCourse.Dock = DockStyle.Fill;
            
            
            
            
            
            
            LoadCapablities(UserBO);

            //frmTranscriptTerm f = new frmTranscriptTerm();
            //AddForm(f);

            //frmIntroSection fIntro = new frmIntroSection(true);
            //AddForm(fIntro);

            //AddForm(new frmDuplicateStudentCard());
            //AddForm(new frmStudentCard());

            /*frmPaymentList fPayList = new frmPaymentList();
            string dt = FaDate.CurrentFaDateString;
            fPayList.SetAndGenerateStartupReport(dt, dt);
            AddForm(fPayList);*/

            //AddForm(new frmMohsenStudents());

            //AddForm(new frmSectionCapacityDetails());

            //AddForm(new frmStudentEducationStatus(true));

            //AddForm(new frmSpecialStudentManager());
            
            //AddForm(new frmRegisterationInformationManager());

            //AddForm(new frmStudentList());

            //AddForm(new frmChangePassword(null));

            /*
            frmStudentBreakManager fBreak = new frmStudentBreakManager();
            AddForm(fBreak);

            frmStudentGiveUpManager fGive = new frmStudentGiveUpManager();
            AddForm(fGive);
            
            
            frmStudentPayStatus fPayStat = new frmStudentPayStatus(true);
            AddForm(fPayStat);

            
            frmSectionMovement fSecMov = new frmSectionMovement();
            AddForm(fSecMov);
            */
            
            /*
            frmUnFinancialStudentsManager fUnf = new frmUnFinancialStudentsManager(null);
            AddForm(fUnf);
            */
            
            /*frmDiscountAStudentManager fdis = new frmDiscountAStudentManager();
            AddForm(fdis);*/

            /*
            frmDiscountSpecialStudentManager fspedis = new frmDiscountSpecialStudentManager();
            AddForm(fspedis);*/
            /*
            frmDiscountRateManager fRate = new frmDiscountRateManager();
            AddForm(fRate);*/

            

            

            
            

            //frmCourseSelectionPayManager fPay = new frmCourseSelectionPayManager(null, "85630002", "مهران داودی", 2, true);
            //AddForm(fPay);
            
            /*
            frmStudentIDMaker fMaker = new frmStudentIDMaker();
            AddForm(fMaker);

            frmCourseSelectionManagerAmoozesh fCourse = new frmCourseSelectionManagerAmoozesh(true);
            AddForm(fCourse);

            frmStudentChecklist fCheck = new frmStudentChecklist();
            AddForm(fCheck);

            frmCourseSelectionManager frmManager = new frmCourseSelectionManager();
            AddForm(frmManager);
            */
            
            /*
            frmSectionSelector SecSel = new frmSectionSelector(null, null, null, null, null);
            SecSel.Show();
            */
            //coolMenu1.HorizontalMargin = 10;

            /*
            frmDesktopUserManager fUser = new frmDesktopUserManager();
            AddForm(fUser);
            */

            /*
            Form fReport = ReportRepository.SectionScoreList("640101              ", "1                   ", 1, "لیست نمرات درس");
            AddForm(fReport);
            */

            /*
            frmExamList fExam = new frmExamList();
            AddForm(fExam);
            */
            
            /*frmSample frmS = new frmSample();
            AddForm(frmS);
            **/

            /*
            frmEnforcedCorequisiteManager fEnforce = new frmEnforcedCorequisiteManager();
            AddForm(fEnforce);
            */

            /*
            Form fReport = ReportRepository.PresenceList("85164010101         ", "لیست حضور غیاب");
            AddForm(fReport);

            */



            /*
            frmScoreManager fScore = new frmScoreManager();
            AddForm(fScore);
            */

            /*
            frmDefaultProgramManager dForm = new frmDefaultProgramManager();
            AddForm(dForm);
            */

            /*
            frmSectionManager fSection = new frmSectionManager();
            AddForm(fSection);
            */

            /*
            frmCourseSelectionValidationAmoozesh fManager = new frmCourseSelectionValidationAmoozesh(null);
            AddForm(fManager);
            */

            /*frmTimeManager tManager = new frmTimeManager();
            AddForm(tManager);
            */
            /*
            frmCoursePriceManager pManager = new frmCoursePriceManager();
            AddForm(pManager);
            */

            /*
            frmMajorManager mManager = new frmMajorManager();
            AddForm(mManager);
            */

            /*
            frmDepartmentManager dManager = new frmDepartmentManager();
            AddForm(dManager);
            */

            /*
            frmFacultyManager fManager = new frmFacultyManager();
            AddForm(fManager);
            */

            /*frmCourseManager fCourse = new frmCourseManager();
            AddForm(fCourse);
            */

            /*
            frmComboDefaultManager fCombo = new frmComboDefaultManager();
            fCombo.Show();
            */

            /*
            frmLiteralManager fLiteral = new frmLiteralManager();
            fLiteral.SetLiteral(    
                DatabaseSchema.ProfessorLevel.TableName,
                DatabaseSchema.ProfessorLevel.ProfessorLevelName,
                DatabaseSchema.ProfessorLevel.ProfessorLevelID);
            fLiteral.Show();
            */


            //frmStudentManager fStudent = new frmStudentManager();
            //AddForm(fStudent);

            //frmProfessorManager fProfessor = new frmProfessorManager();
            //AddForm(fProfessor);

            //frmEmployeeManager fEmployee = new frmEmployeeManager();
            //AddForm(fEmployee);

        }

        private void PresenceListManager(object sender, EventArgs e)
        {
            frmPresenceList fPres = new frmPresenceList();
            AddForm(fPres);
        }

        private void MustPayListManager(object sender, EventArgs e)
        {
            frmMustPayList fMust = new frmMustPayList();
            AddForm(fMust);
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
                case Capablity.CanComboDefaultManager:
                    gSystemManager.AddLink("تنظیمات سیستم", "Settings", SystemSettings);
                    break;

                case Capablity.CanCourseManager:
                    gEducationBasicinfo.AddLink("مدیریت دروس", "Courses", RunCourseManager);
                    break;

                case Capablity.CanCoursePriceManager:
                    gFinancialManager.AddLink("تعیین قیمت‌ها", "pic", CoursePriceManager);
                    break;

                case Capablity.CanCourseSelectionValidationAmoozesh:
                    gEducationOperations.AddLink("تائید آموزشی انتخاب واحد", "CourseSelection", CourseSelectionAmoozeshValidation);
                    break;

                case Capablity.CanCourseSelectionValidationFinancial:
                    gFinancialManager.AddLink("تائید مالی دانشجویان", "CourseSelection", RunStudentFinancialValidation);
                    break;

                case Capablity.CanDefaultProgramManager:
                    gEducationOperations.AddLink("تنظیم دروس پیش‌فرض", "Time", DefaultProgrammeManager);
                    break;

                case Capablity.CanDepartmentManager:
                    gEducationBasicinfo.AddLink("مدیریت گروه‌ها", "Department", DepartmentManager);
                    break;

                case Capablity.CanDesktopUserManager:
                    gSystemManager.AddLink("مدیریت کاربران", "Settings", DesktopUserManager);
                    break;

                case Capablity.CanEmployeeManager:
                    gEducationBasicinfo.AddLink("مدیریت کارمندان", "Professors", RunEmployeeManager);
                    break;

                case Capablity.CanEnforcedCorequisiteManager:
                    gEducationOperations.AddLink("تنظیم همنیاز اجباری", "pic", EnforcedCorequisiteManager);
                    break;

                case Capablity.CanExamList:
                    gEducationReports.AddLink("لیست امتحانی", "Reports", ExamList);
                    break;

                case Capablity.CanFacultyManager:
                    gEducationBasicinfo.AddLink("مدیریت دانشکده‌ها", "Department", FacultyManager);
                    break;

                case Capablity.CanMajorManager:
                    gEducationBasicinfo.AddLink("مدیریت رشته‌ها", "Major", MajorManager);
                    break;

                case Capablity.CanProfessorManager:
                    gEducationBasicinfo.AddLink("مدیریت اساتید", "Professors", RunProfessorManager);
                    break;

                case Capablity.CanScoreManager:
                    gEducationOperations.AddLink("مدیریت نمره‌ها", "Score", ScoreManager);
                    break;

                case Capablity.CanSectionManager:
                    gEducationOperations.AddLink("دروس ارائه شده", "Section", SectionManager);
                    break;

                case Capablity.CanStudentManager:
                    gEducationBasicinfo.AddLink("مدیریت دانشجویان", "Students", RunStudentManager);
                    break;

                case Capablity.CanTimeManager:
                    gSystemManager.AddLink("ویرایش زمان‌ها", "Time", TimeManager);
                    break;

                case Capablity.CanCourseSelectionManagerSystem:
                    gSystemManager.AddLink("مدیریت انتخاب واحد", "CourseSelection", CourseSelectionManagerSystem);
                    break;

                case Capablity.CanCourseSelectionManagerAmoozesh:
                    gEducationOperations.AddLink("مدیریت انتخاب واحد", "CourseSelection", CourseSelectionManagerAmoozesh);
                    break;

                case Capablity.CanStudentChecklist:
                    gEducationReports.AddLink("مشاهده چک‌لیست", "Reports", StudentChecklist);
                    break;

                case Capablity.CanSpecifyStudentID:
                    gEducationOperations.AddLink("تخصیص شماره دانشجویی", "pic", SpecifyStudentID);
                    break;

                case Capablity.CanPayList:
                    gFinancialReports.AddLink("لیست پرداخت‌ها", "pic", PaymentList);
                    break;

                case Capablity.CanStudentGuestInManager:
                    gEducationOperations.AddLink(" دانشجویان مهمان ورودی", "pic", StudentGuestInManager);
                    break;

                case Capablity.CanStudentGuestOutManager:
                    gEducationOperations.AddLink("دانشجویان مهمان خروجی", "pic", StudentGuestOutManager);
                    break;

                case Capablity.CanStudentTransferInManager:
                    gEducationOperations.AddLink("دانشجویان انتقالی ورودی", "pic", StudentTransferManagerIn);
                    break;

                case Capablity.CanStudentTransferOutManager:
                    gEducationOperations.AddLink("دانشجویان انتقالی خروجی", "pic", StudentTransferManagerOut);
                    break;

                case Capablity.CanMinstaryMajorCodeManager:
                    gEducationOperations.AddLink("تنظیم کد وزارت رشته", "pic", MinistaryMajorCodeManager);
                    break;

                case Capablity.CanCourseEquivalenceManager:
                    gEducationOperations.AddLink("تنظیم دروس معادل", "pic", CourseEquivalenceManager );
                    break;

                case Capablity.CanDBSettings:
                    gSystemManager.AddLink("تنظیمات پایگاه‌داده", "pic", DBSettings);
                    break;

                case Capablity.CanConstantFeeManager:
                    gFinancialManager.AddLink("تنظیم قیمت‌ثابت رشته", "pic", ConstantFeeManager );
                    break;

                case Capablity.CanStudentDiscountManager:
                    gFinancialManager.AddLink("تنظیم تخفیف‌ دانشجویان", "pic", StudentDiscountManager );
                    break;

                case Capablity.CanCourseSelectionPayManager:
                    gFinancialManager.AddLink("مشاهده‌ی پرداخت‌ها", "pic", CourseSelectionPayManager);
                    break;

                case Capablity.CanPresenceList:
                    gEducationReports.AddLink("لیست حضور غیاب", "pic", PresenceListManager);
                    break;

                case Capablity.CanMustPayList:
                    gFinancialReports.AddLink("لیست بدهکار - طلبکار", "pic", MustPayListManager);
                    break;

                case Capablity.CanStudentBreakManager:
                    gEducationOperations.AddLink("مرخصی دانشجویان", "pic", RunStudentBreakManager);
                    break;

                case Capablity.CanStudentGiveUpManager:
                    gEducationOperations.AddLink("انصراف دانشجویان", "pic", RunStudentGiveUpManager);
                    break;

                case Capablity.CanSectionMovement:
                    gEducationOperations.AddLink("تغییر کلاس دانشجویان", "pic", RunSectionMovement);
                    break;

                case Capablity.CanStudentPayStatus:
                    gFinancialManager.AddLink("بررسی وضعیت مالی دانشجو", "pic", RunStudentPayStatus);
                    break;

                case Capablity.CanStudentList:
                    gEducationReports.AddLink("لیست دانشجویان", "Reports", StudentList);
                    break;

                case Capablity.CanRegisterationInformation:
                    gSystemManager.AddLink("تنظیمات سال تحصیلی", "pic", RunRegisterationInformation);
                    break;

                case Capablity.CanSpecialStudentManager:
                    gEducationOperations.AddLink("تنظیمات انتخاب واحد دانشجو","pic", RunSpecialStudentManager);
                    break;

                case Capablity.CanSectionCapacityDetails:
                    gEducationReports.AddLink("وضعیت کلاس‌ها", "Reports", RunSectionCapacityDetails);
                    break;

                case Capablity.CanTermTranscript:
                    gEducationReports.AddLink("کارنامه‌ی ترمی", "Reports", RunTermTranscript);
                    break;

                case Capablity.CanOveralTranscript:
                    break;

                case Capablity.CanMohsenStudents:
                    gEducationReports.AddLink("دانشجویان مشروط", "Reports", RunMohsenStudentsReport);
                    break;

                case Capablity.CanAverageAStudents:
                    gEducationReports.AddLink("دانشجویان معدل الف", "Reports", RunAverageAStudentsReport);
                    break;

                case Capablity.CanStudentCard:
                    gEducationReports.AddLink("کارت دانشجویی", "Reports", RunStudentCardReport);
                    break;

                case Capablity.CanFinancialSummary:
                    // Not implemented yet. For now just show the PaymentList.
                    RunFinancialSummary(null, null);
                    break;

                case Capablity.CanDuplicateStudentCard:
                    gEducationOperations.AddLink("کارت المثنی", "Reports", RunDuplicateStudentCard);
                    break;

                case Capablity.CanIntroSectionManager:
                    gEducationOperations.AddLink("معرفی به استاد", "Reports", IntroSectionManager);
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