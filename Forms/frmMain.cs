using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XPExplorerBar;
using BusinessObjectNamespace;
using StandardWidgets;
using FarsiMessageBox;
using Hengam.Tools;
using Hengam.Forms.Student;
using Tools;
using Hengam.Forms.Store;
using FarsiLibrary.Utils;
using Hengam.Forms.ItemPickers;
using DataGridFiller;
using BusinessObjectNamespace;
using DatabaseSchemaNamespace;

namespace Hengam.Forms
{
    public partial class frmMain : HengamWidgets.FormBaseMain
    {
        //private frmStudentManager fStudentManager = null;
        //public bool LoggedIn = false;
        //private static DesktopUsersBO UserBO;
        //public static string Username
        //{
        //    get { return UserBO.Username; }
        //}

        //private static Guid mLoginID;
        //public static Guid LoginID
        //{
        //    get { return mLoginID; }
        //    set { mLoginID = value; }
        //}

        public frmMain()
        {
            InitializeComponent();
        }

        private void DBSettings(object sender, EventArgs e)
        {
            frmDBSettings fDB = new frmDBSettings(true);
            this.AddForm(fDB);
        }

        
        private void SignOut()
        {
            if (MessageBoxEx.Show("آیا می‌خواهید از سیستم خارج شوید؟", "", "هشدار", true) == DialogResult.OK)
                Application.Exit();
        }

        #region Part Runners

        public void RunForm(Form f)
        {
            if (f == null)
            {
                MessageBoxEx.Show("دسترسی به این قسمت امکان پذیر نمی‌باشد.");
                return;
            }
            if (!(f is IPaneled))
            {
                MessageBox.Show("Form haven't impleneted IPaneled.");
                return;
            }
            IPaneled p = f as IPaneled;
            //this.AddForm(f);// hanieh
            this.AddForm(p.MainPanel,f.Text); //hanieh
        }

        public void RunStudentManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات هنرجویان...");
            RunForm(FormRequester.StudentManager());
            HideMsg();
        }

        public void RunTimeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات زمان‌ها");
            RunForm(FormRequester.TimeManager());
            HideMsg();
        }

        public void RunEmployeeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کارمندان...");
            RunForm(FormRequester.EmployeeManager());
            HideMsg();
        }

        public void RunDBSettings(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات پایگاه داده...");
            RunForm(FormRequester.DBSettings());
            HideMsg();
        }

        public void RunTeacherManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات اساتید...");
            RunForm(FormRequester.TeacherManager());
            HideMsg();
        }

        public void RunMajorTeacherManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات اساتید");
            RunForm(FormRequester.MajorTeacherManager());
            HideMsg();
        }

        public void RunTeacherFreeTimeViewer(object sender,  EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            frmTeacherTimePicker f = (frmTeacherTimePicker)(FormRequester.TeacherTimeSelector());
            f.Set(null, FaDate.CurrentFaDateString);
            RunForm(f);
            HideMsg();
        }

        public void RunGuarantorManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات ضامن‌ها...");
            RunForm(FormRequester.GuarantorManager());
            HideMsg();
        }

        public void RunInternetUpdater(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی تنظیمات اینترنت...");
            RunForm(FormRequester.InternetUpdater());
            HideMsg();
        }

        public void RunTeacherTimeSelector(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات اساتید...");
            RunForm(FormRequester.TeacherTimeSelector());
            HideMsg();
        }

        //public void RunClassManager(object sender, EventArgs e)
        //{
        //    SetMsg("در حال بازیابی اطلاعات کلاس‌ها...");
        //    RunForm(FormRequester.ClassManager());
        //    HideMsg();
        //}

        public void RunClassSessionScheduleSetter(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات جلسات...");
            RunForm(FormRequester.ClassSessionScheduleSetter());
            HideMsg();
        }

        public void RunOutcomeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات هزینه‌ها");
            RunForm(FormRequester.OutcomeManager());
            HideMsg();
        }

        public void RunIncomeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات درآمدها...");
            RunForm(FormRequester.IncomeManager());
            HideMsg();
        }

        public void RunStudentRegisterationManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات ثبت‌نام هنرجویان");
            RunForm(FormRequester.StudentRegisterationManager());
            HideMsg();
        }

        public void RunTeacherClassBalance(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات حقوق اساتید");
            RunForm(FormRequester.TeacherClassBalance());
            HideMsg();
        }

        public void RunOutcomeStudentClass(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات تسویه‌حساب هنرجویان");
            RunForm(FormRequester.StudentClassBalance());
            HideMsg();
        }

        public void RunTeacherFinancialStatus(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی وضعیت مالی اساتید");
            RunForm(FormRequester.TeacherFinancialStatus());
            HideMsg();
        }

        public void RunTeacherSessionDetails(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات مالی");
            RunForm(FormRequester.TeacherSessionDetails());
            HideMsg();
        }

        public void RunClassManagerPrivate(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کلاس...");
            RunForm(FormRequester.ClassManagerPrivate());
            HideMsg();
        }

        public void RunClassManagerPublic(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کلاس...");
            RunForm(FormRequester.ClassManagerPublic());
            HideMsg();
        }

        public void RunPresenceManagerPrivate(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات حضور غیاب...");
            RunForm(FormRequester.PresenceManager());
            HideMsg();
        }

        public void RunCalssDailyStatus(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی کلاس‌های روزانه...");
            RunForm(FormRequester.CalssDailyStatus());
            HideMsg();
        }

        public void RunCanStoreStuffAvailableViewer(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کالاها...");
            RunForm(FormRequester.StoreStuffAvailableViewer());
            HideMsg();
        }

        public void RunSchoolSpecification(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات آموزشگاه...");
            RunForm(FormRequester.SchoolSpecification());
            HideMsg();
        }

        public void RunCanStoreStuffTypeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کالاها...");
            RunForm(FormRequester.StoreStuffTypeManager());
            HideMsg();
        }

        public void RunCanStoreStuffBuyManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کالاها...");
            RunForm(FormRequester.StoreStuffBuyManager());
            HideMsg();
        }

        public void RunCanStoreStuffSellItemManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات فروش...");
            RunForm(FormRequester.StoreStuffSellItemManager());
            HideMsg();
        }

        public void RunCanStoreShopHistoryViewer(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات غرفه...");
            RunForm(FormRequester.StoreShopHistoryViewer());
            HideMsg();
        }

        public void RunCanStoreAffairs(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات غرفه...");
            RunForm(FormRequester.StoreAffairs());
            HideMsg();
        }

        public void RunCanEmployeeSalary(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کارمندان...");
            RunForm(FormRequester.EmployeeSalary());
            HideMsg();
        }

        public void RunDesktopUsers(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات کاربران...");
            RunForm(FormRequester.DesktopUserManager());
            HideMsg();
        }

        //public void RunCanStudentInformationReport(object sender, EventArgs e)
        //{
        //    SetMsg("در حال بازیابی اطلاعات حضور غیاب...");
        //    RunForm(FormRequester.StudentInformationReport());
        //    HideMsg();
        //}

        public void RunCanStudentPayForClass(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات مالی هنرجویان...");
            RunForm(FormRequester.StudentPayForClass());
            HideMsg();
        }

        public void RunCanStudentAffairs(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات هنرجویان...");
            RunForm(FormRequester.StudentAffairs());
            HideMsg();
        }

        public void RunCanActivityManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات فعالیت‌ها...");
            RunForm(FormRequester.ActivityManager());
            HideMsg();
        }

        public void RunStoreSalesTracking(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی خرید و فروش...");
            RunForm(FormRequester.StoreSalesTracking());
            HideMsg();
        }

        public void RunStoreStuffSellItem(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات فروش...");
            RunForm(FormRequester.StoreStuffSellItem());
            HideMsg();
        }
        //------------

        public void RunStuffTypeManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات انواع کالاها...");
            RunForm(FormRequester.StoreStuffTypeManager());
            HideMsg();
        }

        public void RunReportStudentListOfMajor(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportStudentListOfMajor());
            HideMsg();
        }

        public void RunReportPaysOfTeacherInterval(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportPaysOfTeacherInterval());
            HideMsg();
        }

        public void RunReportSessionsOfTeacherInterval(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportSessionsOfTeacherInterval());
            HideMsg();
        }

        //hanieh-------------------------------------------------------
        public void RunReportSessionsOfTeacher3months(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportSessionsOfTeacher3months());
            HideMsg();
        }
        //-------------------------------------------------------------

        public void RunReportClassesOfTeacherInterval(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportClassesOfTeacherInterval());
            HideMsg();
        }

        public void RunReportMinistryReport(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportMinistryReport());
            HideMsg();
        }

        public void RunReportStudentPayFactor(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportStudentPayFactor());
            HideMsg();
        }

        public void RunReportTypicalOutcomeYear(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportTypicalOutcomeYear());
            HideMsg();
        }

        public void RunReportIncomeInterval(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportIncomeInterval());
            HideMsg();
        }

        public void RunReportRegisteredStudentsPerEmployee(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportRegisteredStudentsPerEmployee());
            HideMsg();
        }

        public void RunReportTeacherPayFactor(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportTeacherPayFactor());
            HideMsg();
        }

        public void RunReportEmployeePayFactor(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportEmployeePayFactor());
            HideMsg();
        }

        public void RunReportStudentOfPublicClass(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportStudentOfPublicClass());
            HideMsg();
        }

        public void RunComboManager(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ComboManager());
            HideMsg();
        }

        public void RunReportAffairs(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            RunForm(FormRequester.ReportAffairs());
            HideMsg();
        }

        public void RunStudentFinancialStatus(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات مالی...");
            RunForm(FormRequester.StudentFinancialStatus());
            HideMsg();
        }

        public void RunTeacherPayForCalass(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات مالی...");
            RunForm(FormRequester.TeacherPayForClass());
            HideMsg();
        }



        #endregion

        public enum Capablity
        {
            // Students
            CanStudentManager,
            CanStudentFinancialStatus,
            CanStudentInformationReport,
            CanStudentPayForClass,
            CanStudentAffairs,
            CanStudentRegisterationManager,
            CanStudentClassBalance,
            CanStudentFinancialDetails,
            CanStudentSessionDetails,

            // Class
            CanClassManagerPrivate,
            CanClassManagerPublic,
            //CanPresenceManagerPrivate,
            CanPresenceManager,
            //CanClassManager,
            CanClassSessionScheduleSetter,
            CanClassDailyStatus,
            CanClassSessionStatusSetter,

            //Teacher
            CanTeacherManager,
            CanMajorTeacherManager,
            CanTeacherFinancialStatus,
            CanTeacherFinancialDetails,
            CanTeacherTimeSelector,
            CanTeacherClassBalance,
            CanTeacherPayForClass,
            CanTeacherSessionDetails,

            // Misc
            CanTimeManager,
            CanEmployeeManager,
            CanDBSettings,
            CanGuarantorManager,
            CanOutcomeManager,
            CanIncomeManager,
            CanEmployeeSalary,
            CanActivityManager,
            CanSchoolSpecification,
            CanDesktopUsers,
            CanComboManager,
            CanSynchDatabase,

            // Store
            CanStoreStuffAvailableViewer,
            CanStoreStuffTypeManager,
            CanStoreStuffBuyManager,
            CanStoreStuffSellItemManager,
            CanStoreShopHistoryViewer,
            CanStoreAffairs,
            CanStoreSalesTracking,
            CanStoreStuffSellItem,
            

            
            // Report
            CanReportStudentListOfMajor,
            CanReportPaysOfTeacherInterval,
            CanReportSessionsOfTeacherInterval,
            CanReportClassesOfTeacherInterval,
            CanReportMinistryReport,
            CanReportStudentPayFactor,
            CanReportTypicalOutcomeYear,
            CanReportIncomeInterval,
            CanReportRegisteredStudentsPerEmployee,
            CanReportTeacherPayFactor,
            CanReportEmployeePayFactor,
            CanReportStudentOfPublicClass,
            CanReportAffairs,

            
        }
        void AddCapablity(Capablity cap)
        {
            switch (cap)
            {
                #region Students
                case Capablity.CanStudentManager:
                    coolMenu1.AddToExpando(gStudentJobs, "اطلاعات اولیه هنرجویان", "Music", RunStudentManager);
                    //coolMenu1.AddToExpando(gStudentJobs, "اطلاعات اولیه هنرجویان", "Music", RunStudentManager);
                    frmStudentAffairs.CanStudentManager = true;
                    break;

                case Capablity.CanStudentRegisterationManager:
                    //coolMenu1.AddToExpando(gStudentJobs, "ثبت‌نام در کلاس عمومی", "Music", RunStudentRegisterationManager);
                    frmStudentAffairs.CanStudentRegisteration = true;
                    break;

                case Capablity.CanStudentClassBalance:
                    //coolMenu1.AddToExpando(gStudentJobs, "تسویه حساب هنرجو", "Music", RunOutcomeStudentClass);
                    frmStudentAffairs.CanStudentBalance = true;
                    break;

                case Capablity.CanStudentInformationReport:
                    //coolMenu1.AddToExpando(gStudentJobs, "چاپ مشخصات هنرجو", "Music", RunCanStudentInformationReport);
                    break;

                case Capablity.CanStudentPayForClass:
                    //coolMenu1.AddToExpando(gStudentJobs, "امور مالی هنرجو", "Music", RunCanStudentFinancialDetails);
                    frmStudentAffairs.CanStudentPayForClass = true;
                    break;

                case Capablity.CanStudentAffairs:
                    //coolMenu1.AddToExpando(gStudentJobs, "امور هنرجو", "Music", RunCanStudentAffairs);
                    break;

                case Capablity.CanStudentFinancialStatus:
                    coolMenu1.AddToExpando(gStudentJobs, "وضعیت کلاس های هنرجو", "Music", RunStudentFinancialStatus);
                    break;

                #endregion

                #region Teahcers
                case Capablity.CanTeacherManager:
                    coolMenu1.AddToExpando(gTeacherJobs, "اطلاعات اولیه اساتید", "Music", RunTeacherManager);
                    frmClassManagerPublic.CanSeeContactDetails = true;
                    break;

                case Capablity.CanMajorTeacherManager:
                    //coolMenu1.AddToExpando(gTeacherJobs, "تنظیم رشته‌ی اساتید", "Music", RunMajorTeacherManager);
                    break;

                case Capablity.CanTeacherFinancialStatus:
                    coolMenu1.AddToExpando(gTeacherJobs, "وضعیت مالی استاد", "Music", RunTeacherFinancialStatus);
                    break;

                case Capablity.CanTeacherSessionDetails:
                    //coolMenu1.AddToExpando(gTeacherJobs, "جزئیات مالی جلسات", "Music", RunTeacherFinancialSessionDetails);
                    break;

                case Capablity.CanTeacherTimeSelector:
                    coolMenu1.AddToExpando(gTeacherJobs, "زمان‌های آزاد استاد", "Music", RunTeacherFreeTimeViewer);
                    break;

                case Capablity.CanTeacherClassBalance:
                    //coolMenu1.AddToExpando(gTeacherJobs, "تسویه حساب استاد", "Music", RunTeacherClassBalance);
                    break;

                case Capablity.CanTeacherPayForClass:
                    //coolMenu1.AddToExpando(gTeacherJobs, "حقوق استاد", "Music", RunTeacherPayForCalass);
                    break;
                #endregion

                #region Class
                //case Capablity.CanClassManager:
                //    coolMenu1.AddToExpando(gSystemManager, "مدیریت کلاس‌ها", "Music", RunClassManager);
                //    break;

                case Capablity.CanClassManagerPrivate:
                    coolMenu1.AddToExpando(gClassJobs, "کلاس خصوصی", "Music", RunClassManagerPrivate);
                    break;

                case Capablity.CanClassManagerPublic:
                    coolMenu1.AddToExpando(gClassJobs, "کلاس عمومی", "Music", RunClassManagerPublic);
                    break;

                case Capablity.CanClassSessionScheduleSetter:
                    //coolMenu1.AddToExpando(gClassJobs, "مدیریت جلسات", "Music", RunClassSessionManager);
                    break;

                case Capablity.CanPresenceManager:
                    coolMenu1.AddToExpando(gClassJobs, "بررسی کلاس روزانه", "Music", RunCalssDailyStatus);
                    break;
                #endregion

                #region Store
                case Capablity.CanStoreStuffAvailableViewer:
                    //coolMenu1.AddToExpando(gStoreJobs, "مشاهده‌ی ریزخرید", "Music", RunCanStoreStuffAvailableViewer);
                    frmStoreAffairs.CanStoreStuffAvailableViewer = true;
                    break;

                case Capablity.CanStoreStuffTypeManager:
                    coolMenu1.AddToExpando(gStoreJobs, "بررسی موجودی غرفه", "Music", RunCanStoreStuffTypeManager);
                    frmStoreAffairs.CanStoreStuffTypeManager = true;
                    break;

                case Capablity.CanStoreStuffBuyManager:
                    //coolMenu1.AddToExpando(gStoreJobs, "مدیریت خرید‌های غرفه", "Music", RunCanStoreStuffBuyManager);
                    frmStoreAffairs.CanStoreStuffBuyManager = true;
                    break;
                case Capablity.CanStoreStuffSellItemManager:
                    coolMenu1.AddToExpando(gStoreJobs, "مدیریت فروش", "Music", RunCanStoreStuffSellItemManager);
                    frmStoreAffairs.CanStoreStuffSellItemManager = true;
                    break;

                case Capablity.CanStoreShopHistoryViewer:
                    coolMenu1.AddToExpando(gStoreJobs, "بررسی فروش روزانه", "Music", RunCanStoreShopHistoryViewer);
                    frmStoreAffairs.CanStoreShopHistoryViewer = true;
                    break;

                case Capablity.CanStoreAffairs:
                    //coolMenu1.AddToExpando(gStoreJobs, "امور غرفه", "Music", RunCanStoreAffairs);
                    break;

                case Capablity.CanStoreSalesTracking:
                    //coolMenu1.AddToExpando(gStoreJobs, "رهگیری خرید و فروش", "Music", RunStoreSalesTracking);
                    frmStoreAffairs.CanStoreSalesTracking = true;
                    break;

                case Capablity.CanStoreStuffSellItem:
                    coolMenu1.AddToExpando(gStoreJobs, "فروش کالا", "Music", RunStoreStuffSellItem);
                    frmStoreAffairs.CanStoreStuffSellItem = true;
                    break;

                
                #endregion

                #region Misc
                case Capablity.CanEmployeeManager:
                    coolMenu1.AddToExpando(gMiscJobs, "اطلاعات اولیه کارمندان", "Music", RunEmployeeManager);
                    break;

                case Capablity.CanDBSettings:
                    coolMenu1.AddToExpando(gSystemManager, "تنظیمات پایگاه‌داده", "Music", RunDBSettings);
                    break;

                case Capablity.CanGuarantorManager:
                    coolMenu1.AddToExpando(gMiscJobs, "اطلاعات اولیه ضامن‌ها", "Music", RunGuarantorManager);
                    break;

                case Capablity.CanOutcomeManager:
                    coolMenu1.AddToExpando(gMiscJobs, "مدیریت هزینه‌ها", "Music", RunOutcomeManager);
                    break;

                case Capablity.CanIncomeManager:
                    coolMenu1.AddToExpando(gMiscJobs, "مدیریت درآمدها", "Music", RunIncomeManager);
                    break;

                case Capablity.CanEmployeeSalary:
                    //coolMenu1.AddToExpando(gMiscJobs, "حقوق کارمندان", "Music", RunCanEmployeeSalary);
                    break;

                case Capablity.CanActivityManager:
                    coolMenu1.AddToExpando(gMiscJobs, "تنظیم فعالیت‌ها", "Music", RunCanActivityManager);
                    break;

                case Capablity.CanSchoolSpecification:
                    coolMenu1.AddToExpando(gSystemManager, "مشخصات آموزشگاه", "Music", RunSchoolSpecification);
                    break;

                case Capablity.CanDesktopUsers:
                    coolMenu1.AddToExpando(gSystemManager, "تنظیم سطح دسترسی کاربران", "Music", RunDesktopUsers );
                //frmStoreAffairs.CanStoreStuffSellItem = true;
                    break;

                case Capablity.CanComboManager:
                    coolMenu1.AddToExpando(gSystemManager, "مدیریت اطلاعات جعبه‌ها", "Music", RunComboManager);
                    break;

                case Capablity.CanTimeManager:
                    coolMenu1.AddToExpando(gSystemManager, "مدیریت زمان‌ها", "Music", RunTimeManager);
                    break;

                case Capablity.CanSynchDatabase:
                    coolMenu1.AddToExpando(gMiscJobs, "به‌روز رسانی اینترنت", "Music", RunInternetUpdater);
                    break;

                #endregion

                #region Reports
                case Capablity.CanReportStudentListOfMajor:
                    coolMenu1.AddToExpando(gReports, "هنرجویان بک رشته", "Music", RunReportStudentListOfMajor);
                    break;

                case Capablity.CanReportPaysOfTeacherInterval:
                    coolMenu1.AddToExpando(gReports, "پرداخت‌های استاد", "Music", RunReportPaysOfTeacherInterval);
                    break;

                case Capablity.CanReportSessionsOfTeacherInterval:
                    {
                        coolMenu1.AddToExpando(gReports, "جلسات استاد", "Music", RunReportSessionsOfTeacherInterval);
                        coolMenu1.AddToExpando(gReports, "جلسات کلاس(3 ماهه(", "Music", RunReportSessionsOfTeacher3months); //hanieh
                    }
                    break;

                case Capablity.CanReportClassesOfTeacherInterval:
                    coolMenu1.AddToExpando(gReports, "کلاس‌های استاد", "Music", RunReportClassesOfTeacherInterval);
                    break;

                case Capablity.CanReportMinistryReport:
                    coolMenu1.AddToExpando(gReports, "گزارش وزارت", "Music", RunReportMinistryReport);
                    break;

                case Capablity.CanReportStudentPayFactor:
                    coolMenu1.AddToExpando(gReports, "فاکتور شهریه هنرجو", "Music", RunReportStudentPayFactor);
                    break;

                case Capablity.CanReportTypicalOutcomeYear:
                    coolMenu1.AddToExpando(gReports, "هزینه سالانه", "Music", RunReportTypicalOutcomeYear);
                    break;

                case Capablity.CanReportIncomeInterval:
                    coolMenu1.AddToExpando(gReports, "درآمد روزانه", "Music", RunReportIncomeInterval);
                    break;

                case Capablity.CanReportRegisteredStudentsPerEmployee:
                    coolMenu1.AddToExpando(gReports, "تعداد ثبت‌نامی کارمندان", "Music", RunReportRegisteredStudentsPerEmployee);
                    break;

                case Capablity.CanReportTeacherPayFactor:
                    coolMenu1.AddToExpando(gReports, "فاکتور پرداخت به استاد", "Music", RunReportTeacherPayFactor);
                    break;

                case Capablity.CanReportEmployeePayFactor:
                    coolMenu1.AddToExpando(gReports, "فاکتور حقوق کارمند", "Music", RunReportEmployeePayFactor);
                    break;

                case Capablity.CanReportStudentOfPublicClass:
                    coolMenu1.AddToExpando(gReports, "هنرجویان کلاس عمومی", "Music", RunReportStudentOfPublicClass);
                    break;

                case Capablity.CanReportAffairs:
                    coolMenu1.AddToExpando(gReports, "گزارش‌ها", "Music", RunReportAffairs);
                    break;
                #endregion

                default:
                    break;
            }

        }

        Expando gStudentJobs = new Expando();
        Expando gMiscJobs = new Expando();
        Expando gTeacherJobs = new Expando();
        Expando gClassJobs = new Expando();
        Expando gFinancialManager = new Expando();
        Expando gSystemManager = new Expando();
        Expando gStoreJobs = new Expando();
        Expando gReports = new Expando();

        void LoadCapablities(DesktopUsersBO user)
        {
            gStudentJobs.Text = "امور هنرجویان";
            gStudentJobs.Items.Clear();
            gStudentJobs.TitleImage = imageListGroups.Images["Student"];

            gMiscJobs.Text = "متفرقه";
            gMiscJobs.Items.Clear();
            gMiscJobs.TitleImage = imageListGroups.Images["Misc"];

            gClassJobs.Text = "امور کلاس‌ها";
            gClassJobs.Items.Clear();
            gClassJobs.TitleImage = imageListGroups.Images["Class"];

            gTeacherJobs.Text = "امور اساتید";
            gTeacherJobs.Items.Clear();
            gTeacherJobs.TitleImage = imageListGroups.Images["Teacher"];

            gSystemManager.Text = "مدیریت سیستم";
            gSystemManager.Items.Clear();
            gSystemManager.TitleImage = imageListGroups.Images["System"];

            gFinancialManager.Text = "امور مالی";
            gFinancialManager.Items.Clear();
            gFinancialManager.TitleImage = imageListGroups.Images["Misc"];

            gStoreJobs.Text = "امور غرفه";
            gStoreJobs.Items.Clear();
            gStoreJobs.TitleImage = imageListGroups.Images["Misc"];

            gReports.Text = "گزارش‌ها";
            gReports.Items.Clear();
            gReports.TitleImage = imageListGroups.Images["Report"];


            #region Student Menu
            if (user.CanStudentAffairs)
                AddCapablity(Capablity.CanStudentAffairs);

            if (user.CanStudentInformationReport)
                AddCapablity(Capablity.CanStudentInformationReport);

            if (user.CanStudentPayForClass)
                AddCapablity(Capablity.CanStudentPayForClass);


            if (user.CanStudentManager)
                AddCapablity(Capablity.CanStudentManager);

            if (user.CanStudentRegisterationManager)
                AddCapablity(Capablity.CanStudentRegisterationManager);

            if (user.CanStudentClassBalance)
                AddCapablity(Capablity.CanStudentClassBalance);



            if (user.CanReportStudentListOfMajor)
                AddCapablity(Capablity.CanReportStudentListOfMajor);
            #endregion

            #region Teacher Menu


            if (user.CanTeacherManager)
                AddCapablity(Capablity.CanTeacherManager);

            if (user.CanMajorTeacherManager)
                AddCapablity(Capablity.CanMajorTeacherManager);

            if (user.CanTeacherTimeSelector)
                AddCapablity(Capablity.CanTeacherTimeSelector);

            if (user.CanTeacherClassBalance)
                AddCapablity(Capablity.CanTeacherClassBalance);

            if (user.CanTeacherFinancialStatus)
                AddCapablity(Capablity.CanTeacherFinancialStatus);

            if (user.CanTeacherSessionDetails)
                AddCapablity(Capablity.CanTeacherSessionDetails);
            #endregion


            #region Class Menu
            //if (user.CanClassManager)
            //    AddCapablity(Capablity.CanClassManager);

            if (user.CanClassManagerPublic)
                AddCapablity(Capablity.CanClassManagerPublic);

            if (user.CanClassManagerPrivate)
                AddCapablity(Capablity.CanClassManagerPrivate);

            if (user.CanClassSessionScheduleSetter)
                AddCapablity(Capablity.CanClassSessionScheduleSetter);

            if (user.CanPresenceManager)
                AddCapablity(Capablity.CanPresenceManager);

            #endregion

            #region Misc Menu
            
            if (user.CanActivityManager)
                            AddCapablity(Capablity.CanActivityManager);

            if (user.CanEmployeeSalary)
                AddCapablity(Capablity.CanEmployeeSalary);

            if (user.CanSchoolSpecification)
                AddCapablity(Capablity.CanSchoolSpecification);

            if (user.CanDesktopUsers)
                AddCapablity(Capablity.CanDesktopUsers);

            if (user.CanTimeManager)
                AddCapablity(Capablity.CanTimeManager);

            if (user.CanEmployeeManager)
                AddCapablity(Capablity.CanEmployeeManager);

            if (user.CanDBSettings)
                AddCapablity(Capablity.CanDBSettings);

            if (user.CanGuarantorManager)
                AddCapablity(Capablity.CanGuarantorManager);

            if (user.CanOutcomeManager)
                AddCapablity(Capablity.CanOutcomeManager);

            if (user.CanIncomeManager)
                AddCapablity(Capablity.CanIncomeManager);

            if (user.CanComboManager)
                AddCapablity(Capablity.CanComboManager);

            if (user.CanSynchDatabase)
                AddCapablity(Capablity.CanSynchDatabase);
            #endregion

            #region Report Menu


            if (user.CanReportPaysOfTeacherInterval)
                AddCapablity(Capablity.CanReportPaysOfTeacherInterval);

            if (user.CanReportSessionsOfTeacherInterval)
                AddCapablity(Capablity.CanReportSessionsOfTeacherInterval);

            if (user.CanReportClassesOfTeacherInterval)
               AddCapablity(Capablity.CanReportClassesOfTeacherInterval);
             
            if (user.CanReportMinistryReport)
                AddCapablity(Capablity.CanReportMinistryReport);

            if (user.CanReportStudentPayFactor)
                AddCapablity(Capablity.CanReportStudentPayFactor);

            if (user.CanReportTypicalOutcomeYear)
                AddCapablity(Capablity.CanReportTypicalOutcomeYear);

            if (user.CanReportIncomeInterval)
                AddCapablity(Capablity.CanReportIncomeInterval);

            if (user.CanReportRegisteredStudentsPerEmployee)
                AddCapablity(Capablity.CanReportRegisteredStudentsPerEmployee);

            if (user.CanReportTeacherPayFactor)
                AddCapablity(Capablity.CanReportTeacherPayFactor);

            if (user.CanReportEmployeePayFactor)
                AddCapablity(Capablity.CanReportEmployeePayFactor);

            if (user.CanReportStudentOfPublicClass)
                AddCapablity(Capablity.CanReportStudentOfPublicClass);

            if (user.CanReportAffairs)
                AddCapablity(Capablity.CanReportAffairs);
            #endregion

            #region Store Menu
            if (user.CanStoreAffairs)
                AddCapablity(Capablity.CanStoreAffairs);

            if (user.CanStoreStuffAvailableViewer)
                AddCapablity(Capablity.CanStoreStuffAvailableViewer);

            if (user.CanStoreStuffTypeManager)
                AddCapablity(Capablity.CanStoreStuffTypeManager);

            if (user.CanStoreStuffBuyManager)
                AddCapablity(Capablity.CanStoreStuffBuyManager);

            if (user.CanStoreShopHistoryViewer)
                AddCapablity(Capablity.CanStoreShopHistoryViewer);

            




            if (user.CanStoreStuffSellItemManager)
                AddCapablity(Capablity.CanStoreStuffSellItemManager);

            if (user.CanStoreStuffSellItem)
                AddCapablity(Capablity.CanStoreStuffSellItem);

            if (user.CanStoreSalesTracking)
                AddCapablity(Capablity.CanStoreSalesTracking);
            #endregion


            

            



            



            // ToDo: Add security

            AddCapablity(Capablity.CanStudentFinancialStatus);
            AddCapablity(Capablity.CanTeacherPayForClass);

            coolMenu1.SuspendLayout();

            if (gStudentJobs.Items.Count > 0)
            {
                coolMenu1.AddExpando(gStudentJobs);
            }
            if (gTeacherJobs.Items.Count > 0)
            {
                coolMenu1.AddExpando(gTeacherJobs);
            }
            if (gClassJobs.Items.Count > 0)
            {
                coolMenu1.AddExpando(gClassJobs);
            }
            if (gFinancialManager.Items.Count > 0)
            {
                coolMenu1.AddExpando(gFinancialManager);
            }

            if (gMiscJobs.Items.Count > 0)
            {
                coolMenu1.AddExpando(gMiscJobs);
            }
            if (gSystemManager.Items.Count > 0)
            {
                coolMenu1.AddExpando(gSystemManager);
            }

            if (gStoreJobs.Items.Count > 0)
            {
                coolMenu1.AddExpando(gStoreJobs);
            }

            if (gReports.Items.Count > 0)
            {
                coolMenu1.AddExpando(gReports);
            }

            coolMenu1.ResumeLayout();

            foreach (Expando exp in coolMenu1.Expandos)
            {
                exp.Animate = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash fSplash = new frmSplash();
            fSplash.Init();
           
            frmLogin fLogin = new frmLogin();
            Program.LoggedIn = false;
            while (!Program.LoggedIn)
            {
                this.Focus();
                Application.DoEvents();
                DialogResult dr = fLogin.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Program.User= fLogin.UserBO;
                    Program.LoggedIn = fLogin.LoggedIn;
                }
                else if (dr == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }
            lblUsername.Text = Program.User.RelEmployee.FullName;
            string loginTime = "";
            try
            {
                loginTime += PersianDate.Now.ToWritten();
                loginTime += "؛ " + string.Format("{0}:{1}", PersianDate.Now.Hour, PersianDate.Now.Minute);
            }
            catch (Exception) { }
            lblLoginTime.Text = loginTime;
            Hengam.Tools.LastChangeManagement.LastChangeFiller.UsernameID = Program.Username;

            //Setting LoginNames...

            Program.LoginID = Guid.NewGuid();
            LoginDetailsBO log = new LoginDetailsBO();
            log.loginID = Program.LoginID;
            log.loginDate = FaDate.CurrentFaDateString;
            log.loginTime = FarsiLibrary.Utils.PersianDate.Now.Time.ToString();
            log.username = Program.Username;
            log.privilegedGrant = "-";
            log.Add();
            JobLogger.loginID = Program.LoginID;
            JobLogger.Enabled = false;

            DesktopUsersBO.SetLoginTime(log.username, log.loginDate, log.loginTime);

            LoadCapablities(Program.User);

            List<SchoolSpecificationBO> spec = SchoolSpecificationBO.List();
            if (spec.Count > 0)
            {
                SetBackGroundImage(spec[0].BackgroundImage);
                
            }
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("FA-fa")); //hanieh

            //added by hanieh for birthday grid
            datagridBday.RefreshDataGrid();
            //---------------------------------
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword fPass = new frmChangePassword();
            floaterChangePassword.LoadPanel(fPass, "تغییر رمز عبور");
            fPass.Set(Program.Username);
            floaterChangePassword.Show();
        }

        //added by hanieh for birthday grid
        private void datagridBday_OnLoadDataGrid(object sender, EventArgs e)
        {   
            string date ="05/14";
            List<string> list = new List<string>();
            list=StudentBO.BirthdayList(date);
            /*DataGridFiller<string>.FillDataGrid(datagridBday, list,
               new List<ColumnDefinition>
                {    

                });
            */
        }
        //-----------------------------------------------------

    }

    
    public static class Extensions
    {
        public static void AddForm(frmMain mainFrm, Form frm) //hanieh Form-->FrmMain
        {
            if (frm is IPaneled)
            {
                IPaneled panel = (frm as IPaneled);
                mainFrm.AddForm(panel.MainPanel, frm.Text);
            }
            else
            {
                mainFrm.SetMsg("این صفحه قابل نمایش نیست.");
            }
        }
    }
}

