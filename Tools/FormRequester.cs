using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms;
using Hengam.Forms.Store;
using Hengam.Forms.Student;
using Hengam.Reports.ReportForms;
using BusinessObjectNamespace;
using Hengam.Forms.Teacher;
using Hengam.Forms.ItemPickers;

namespace Hengam.Tools
{
    static class FormRequester
    {
        static DesktopUsersBO User
        {
            get { return Program.User; }
        }

        #region Student
        public static Form StudentManager()
        {
            if (!User.CanStudentManager)
                return null;
            return new frmStudentManager();
        }

        public static Form StudentRegisterationManager()
        {
            if (!User.CanStudentRegisterationManager)
                return null;
            return new frmStudentRegisterationManager();
        }

        public static Form StudentClassBalance()
        {
            if (!User.CanStudentClassBalance)
                return null;
            return new frmStudentClassBalance();
        }

        public static Form StudentFinancialDetails()
        {
            if (!User.CanStudentFinancialDetails)
                return null;
            return new frmStudentFinancialDetails();
        }

        public static Form StudentPayForClass()
        {
            if (!User.CanStudentPayForClass)
                return null;
            return new frmStudentPayForClass();
        }

        public static Form StudentAffairs()
        {
            if (!User.CanStudentAffairs)
                return null;
            return new frmStudentAffairs();
        }

        //public static Form StudentRegisterationManager(string studentID)
        //{
        //    Program.SetMsg("در حال بازیابی اطلاعات ثبت نام");
        //    frmStudentRegisterationManager frmStudReg = (frmStudentRegisterationManager)StudentRegisterationManager();
        //    if (frmStudReg != null) frmStudReg.SetStudent(studentID);
        //    Program.HideMsg();
        //    return frmStudReg;
        //}

        public static Form StudentFinancialStatus()
        {
            if (!User.CanStudentFinancialStatus)
                return null;
            return new frmStudentFinancialStatus();
        }

        internal static Form StudentSessionDetails()
        {
            if (!User.CanStudentSessionDetails)
                return null;
            return new frmStudentSessionDetails();
        }

        #endregion

        #region Teacher
        public static Form TeacherManager()
        {
            if (!User.CanTeacherManager)
                return null;
            return new frmTeacherManager();
        }

        public static Form TeacherTimeSelector()
        {
            if (!User.CanTeacherTimeSelector)
                return null;
            return new frmTeacherTimePicker();
        }

        public static Form TeacherClassBalance()
        {
            if (!User.CanTeacherClassBalance)
                return null;
            return new frmTeacherClassBalance();
        }

        public static Form TeacherFinancialStatus()
        {
            if (!User.CanTeacherFinancialStatus)
                return null;
            return new frmTeacherFinancialStatus();
        }

        //public static Form TeacherFinancialSessionDetails()
        //{
        //    if (!User.CanTeacherFinancialSessionDetails)
        //        return null;
        //    return new frmTeacherFinancialSessionDetails();
        //}

        public static Form MajorTeacherManager()
        {
            if (!User.CanMajorTeacherManager)
                return null;
            return new frmMajorTeacherManager();
        }

        internal static Form TeacherSessionDetails()
        {
            return new frmTeacherSessionDetails();
        }

        internal static Form TeacherFinancialDetails()
        {
            return new frmTeacherFinancialDetails();
        }

        internal static Form TeacherBalance()
        {
            return new frmTeacherClassBalance();
        }

        public static Form TeacherPayForClass()
        {
            return new frmTeacherPayForClass();
        }

        internal static Form TeacherAggregatedPay()
        {
            return new frmTeacherFinancialStatusAggregatePay();
        }

        #endregion

        #region Class
        public static Form ClassManagerPrivate()
        {
            if (!User.CanClassManagerPrivate)
                return null;
            return new frmClassManagerPrivate();
        }

        public static Form ClassManagerPublic()
        {
            if (!User.CanClassManagerPublic)
                return null;
            return new frmClassManagerPublic();
        }

        public static Form PresenceManager()
        {
            //return null;//return new frmPresenceManagerPrivate();
            if (!User.CanPresenceManager)
                return null;
            return new frmPresenceManager();
        }

        public static Form CalssDailyStatus()
        {
            if (!User.CanClassDailyStatus)
                return null;
            return new frmCalssDailyStatus();
        }

        public static Form ClassSessionScheduleSetter()
        {
            if (!User.CanClassSessionScheduleSetter)
                return null;
            return new frmClassSessionScheduleSetter();
        }

        public static Form ClassSessionStatusSetter()
        {
            if (!User.CanClassSessionStatusSetter)
                return null;
            return new frmClassSessionStatusSetter();
        }
        
        //public static Form ClassManager()
        //{
        //    if (!User.CanClassManager`)
        //        return null;
        //    return new frmClassManager();
        //}

        //public static Form ClassSessionManager()
        //{
        //    if (!User.CanClassSessionManager)
        //        return null;
        //    return new frmClassSessionManager();
        //}

        //internal static frmClassSessionStatusSetter SessionStatusSetter()
        //{
        //    return new frmClassSessionStatusSetter();
        //}

        #endregion

        #region Misc
        public static Form TimeManager()
        {
            if (!User.CanTimeManager)
                return null;
            return new frmTimeManager();
        }

        public static Form EmployeeManager()
        {
            if (!User.CanEmployeeManager)
                return null;
            return new frmEmployeeManager();
        }

        public static Form DBSettings()
        {
            if (!User.CanDBSettings)
                return null;
            return new frmDBSettings(true);
        }

        public static Form GuarantorManager()
        {
            if (!User.CanGuarantorManager)
                return null;
            return new frmGuarantorManager();
        }

        public static Form OutcomeManager()
        {
            if (!User.CanOutcomeManager)
                return null;
            return new frmOutcomeManager();
        }

        public static Form IncomeManager()
        {
            if (!User.CanIncomeManager)
                return null;
            return new frmIncomeManager();
        }

        public static Form ActivityManager()
        {
            if (!User.CanActivityManager)
                return null;
            return new frmActivityManager();
        }


        public static Form EmployeeSalary()
        {
            if (!User.CanEmployeeSalary)
                return null;
            return new frmEmployeeSalary();
        }
        public static Form SchoolSpecification()
        {
            if (!User.CanSchoolSpecification)
                return null;
            return new frmSchoolSpecification();
        }
        public static Form ComboManager()
        {
            if (!User.CanComboManager)
                return null;
            return new frmComboManager();
        }

        public static Form DesktopUserManager()
        {
            if (!User.CanDesktopUsers)
                return null;
            return new frmDesktopUserManager();
        }

        public static Form InternetUpdater()
        {
            if (!User.CanSynchDatabase)
                return null;
            return new frmInternetUpdater();
        }
        #endregion

        #region Store
        public static Form StoreSalesTracking()
        {
            if (!User.CanStoreSalesTracking)
                return null;
            return new frmStoreSalesTracking();
        }

        public static Form StoreShopHistoryViewer()
        {
            if (!User.CanStoreShopHistoryViewer)
                return null;
            return new frmStoreShopHistoryViewer();
        }

        public static Form StoreStuffBuyManager()
        {
            if (!User.CanStoreStuffBuyManager)
                return null;
            return new frmStoreStuffBuyManager();
        }

        public static Form StoreStuffSellItem()
        {
            if (!User.CanStoreStuffSellItem)
                return null;
            return new frmShopSellItem();
        }

        public static Form StoreStuffSellItemManager()
        {
            if (!User.CanStoreStuffSellItemManager)
                return null;
            return new frmShopSellItemManager();
        }

        public static Form StoreStuffTypeManager()
        {
            if (!User.CanStoreStuffTypeManager)
                return null;
            return new frmStoreStuffTypeManager();
        }

        public static Form StoreAffairs()
        {
            if (!User.CanStoreAffairs)
                return null;
            return new frmStoreAffairs();
        }

        public static Form StoreStuffAvailableViewer()
        {
            if (!User.CanStoreStuffAvailableViewer)
                return null;
            return new frmStoreStuffDetailsAvailableViewer();
        }
        #endregion

        #region Report

        public static Form ReportStudentPayFactor()
        {
            if (!User.CanReportStudentPayFactor)
                return null;
            return new frmReportStudentPayFactor();
        }

        public static Form ReportIncomeInterval()
        {
            if (!User.CanReportIncomeInterval)
                return null;
            return new frmReportIncomeInterval();
        }

        //-------------

        public static Form ReportStudentListOfMajor()
        {
            if (!User.CanReportStudentListOfMajor)
                return null;
            return new frmReportStudentListOfMajor();
        }

        public static Form ReportPaysOfTeacherInterval()
        {
            if (!User.CanReportPaysOfTeacherInterval)
                return null;
            return new frmReportPaysOfTeacherInterval();
        }

        public static Form ReportSessionsOfTeacherInterval()
        {
            if (!User.CanReportSessionsOfTeacherInterval)
                return null;
            return new frmReportSessionsOfTeacherInterval();
        }

        //hanieh------------------------------------------
        public static Form ReportSessionsOfTeacher3months()
        {
            if (!User.CanReportSessionsOfTeacherInterval)
                return null;
            return new frmReportSessionsOfTeacher3months();
        }
        //------------------------------------------------
        public static Form ReportClassesOfTeacherInterval()
        {
            if (!User.CanReportClassesOfTeacherInterval)
                return null;
            return new frmReportClassesOfTeacherInterval();
        }

        public static Form ReportMinistryReport()
        {
            if (!User.CanReportMinistryReport)
                return null;
            return new frmReportMinistryReport();
        }

        public static Form ReportTypicalOutcomeYear()
        {
            if (!User.CanReportTypicalOutcomeYear)
                return null;
            return new frmReportTypicalOutcomeYear();
        }



        public static Form ReportRegisteredStudentsPerEmployee()
        {
            if (!User.CanReportRegisteredStudentsPerEmployee)
                return null;
            return new frmReportRegisteredStudentsPerEmployee();
        }

        public static Form ReportTeacherPayFactor()
        {
            if (!User.CanReportTeacherPayFactor)
                return null;
            return new frmReportTeacherPayFactor();
        }

        public static Form ReportEmployeePayFactor()
        {
            if (!User.CanReportEmployeePayFactor)
                return null;
            return new frmReportEmployeePayFactor();
        }

        public static Form ReportStudentOfPublicClass()
        {
            if (!User.CanReportStudentOfPublicClass)
                return null;
            return new frmReportStudentsOfPublicClass();
        }

        public static Form ReportAffairs()
        {
            return null;//return new frmReportAffairs();
        }

        #endregion


        // Customized calls...









        
    }
}
