using System;
using System.Collections.Generic;
using System.Text;
using ComboManager;

namespace DatabaseSchemaNamespace
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
        }
        public ColumnDefinition(string ColName, string ColCaption, string parentTable)
        {
            columnName = ColName;
            Caption = ColCaption;
            ParentTable = parentTable;
        }
        public override string ToString()
        {
            return ParentTable + "." + columnName;
        }

        private string columnName = "";
        public string Name { get { return columnName; } }
        public string Caption = "";
        public string ParentTable = "";

        public static implicit operator string(ColumnDefinition ColumnDef)
        {
            return ColumnDef.Name;
        }
    }
    public class DatabaseSchema
    {
        /*
        public static ColumnDefinition SecondName(ColumnDefinition col)
        {
            ColumnDefinition col2 = new ColumnDefinition(col + "2", col.Caption + " 2", col.ParentTable);
            return col2;
        }
        */
        #region Virtual Tables

        public class EntranceSeason
        {
            public int EntranceSeasonValue;
            public EntranceSeason(int entValue)
            {
                EntranceSeasonValue = entValue;
            }
            public static void FillCombo(System.Windows.Forms.ComboBox cbo)
            {
                cbo.Items.Clear();
                cbo.Items.Add(new DatabaseSchema.EntranceSeason(1));
                cbo.Items.Add(new DatabaseSchema.EntranceSeason(2));
            }
            public override string ToString()
            {
                switch (EntranceSeasonValue)
                {
                    case 1:
                        return "مهر";
                    case 2:
                        return "بهمن";
                    default:
                        return "";
                }
            }
            public static implicit operator int(EntranceSeason es)
            {
                return es.EntranceSeasonValue;
            }
        }

        public class OfferSeason
        {
            public int OfferSeasonValue;
            public OfferSeason(int entValue)
            {
                OfferSeasonValue = entValue;
            }
            public static void FillCombo(System.Windows.Forms.ComboBox cbo)
            {
                cbo.Items.Clear();
                cbo.Items.Add(new DatabaseSchema.OfferSeason(1));
                cbo.Items.Add(new DatabaseSchema.OfferSeason(2));
                cbo.Items.Add(new DatabaseSchema.OfferSeason(3));
                cbo.Items.Add(new DatabaseSchema.OfferSeason(4));
            }
            public override string ToString()
            {
                switch (OfferSeasonValue)
                {
                    case 1:
                        return "مهر";
                    case 2:
                        return "بهمن";
                    case 3:
                        return "تابستان";

                    case 4:
                        return "معرفی به استاد";

                    default:
                        return "";
                }
            }
            public static implicit operator int(OfferSeason es)
            {
                return es.OfferSeasonValue;
            }
        }

        public class OfferYear
        {
            public int OfferYearValue;
            public string OfferYearString
            {
                get { return OfferYearValue.ToString(); }
                set { OfferYearValue = int.Parse(value); }
            }
            public OfferYear(int entValue)
            {
                OfferYearValue = entValue;
            }
            public static void FillCombo(System.Windows.Forms.ComboBox cbo)
            {
                cbo.Items.Clear();
                cbo.Items.Add(new DatabaseSchema.OfferYear(1384));
                cbo.Items.Add(new DatabaseSchema.OfferYear(1385));
                cbo.Items.Add(new DatabaseSchema.OfferYear(1386));
            }
            public override string ToString()
            {
                return OfferYearString;
                /*
                switch (OfferYearValue)
                {
                    case 1384:
                        return "مهر";
                        break;
                    case 1385:
                        return "بهمن";
                        break;
                    default:
                        return "";
                        break;
                }
                */
            }
            public static implicit operator int(OfferYear es)
            {
                return es.OfferYearValue;
            }
        }

        public class StudentTerm
        {
            public int TermValue;
            public StudentTerm(int entValue)
            {
                TermValue = entValue;
            }
            public static void FillCombo(System.Windows.Forms.ComboBox cbo)
            {
                cbo.Items.Clear();
                cbo.Items.Add(new DatabaseSchema.StudentTerm(1));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(2));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(3));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(4));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(5));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(6));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(7));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(8));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(9));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(10));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(11));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(12));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(13));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(14));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(15));
                cbo.Items.Add(new DatabaseSchema.StudentTerm(16));
            }
            public override string ToString()
            {
                switch (TermValue)
                {
                    case 1:
                        return "1";
                    
                    case 2:
                        return "2";

                    case 3:
                        return "3";

                    case 4:
                        return "4";

                    case 5:
                        return "5";
                    
                    case 6:
                        return "6";

                    case 7:
                        return "7";

                    case 8:
                        return "8";

                    case 9:
                        return "9";


                    case 10:
                        return "10";

                    case 11:
                        return "11";

                    case 12:
                        return "12";

                    case 13:
                        return "13";

                    case 14:
                        return "14";

                    case 15:
                        return "15";

                    case 16:
                        return "16";

                    default:
                        return "";
                }
            }
            public static implicit operator int(StudentTerm es)
            {
                return es.TermValue;
            }
        }

        public class EntranceYear
        {
            public int EntranceYearValue;
            public string EntranceYearString
            {
                get { return EntranceYearValue.ToString(); }
                set { EntranceYearValue = int.Parse(value); }
            }
            public EntranceYear(int entValue)
            {
                EntranceYearValue = entValue;
            }
            public static void FillCombo(System.Windows.Forms.ComboBox cbo)
            {
                cbo.Items.Clear();

                cbo.Items.Add(new DatabaseSchema.EntranceYear(1375));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1376));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1377));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1378));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1379));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1380));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1381));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1382));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1383));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1384));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1385));
                cbo.Items.Add(new DatabaseSchema.EntranceYear(1386));
            }
            public override string ToString()
            {
                return EntranceYearString;
                /*
                switch (EntranceYearValue)
                {
                    case 1384:
                        return "مهر";
                        break;
                    case 1385:
                        return "بهمن";
                        break;
                    default:
                        return "";
                        break;
                }
                */
            }
            public static implicit operator int(EntranceYear es)
            {
                return es.EntranceYearValue;
            }
        }

        

        #endregion

        //public static class Time
        //{
        //    public static string TableName = "Time";

        //    public static ColumnDefinition TimeID = new ColumnDefinition("TimeID", "کد زمان", TableName);
        //    public static ColumnDefinition StartHour = new ColumnDefinition("StartHour", "ساعت شروع", TableName);
        //    public static ColumnDefinition StartMin = new ColumnDefinition("StartMin", "دقیقه شروع", TableName);
        //    public static ColumnDefinition FinishHour = new ColumnDefinition("FinishHour", "ساعت پایان", TableName);
        //    public static ColumnDefinition FinishMin = new ColumnDefinition("FinishMin", "دقیقه پایان", TableName);
        //}

        public static class DayCode
        {
            public static string TableName = "DayCode";

            public static ColumnDefinition DayID = new ColumnDefinition("DayID", "کد روز", TableName);
            public static ColumnDefinition DayName = new ColumnDefinition("DayName", "روز", TableName);
        }

        
        //public class DesktopUsers
        //{
        //    public static string TableName = "desktopUsers";

        //    public static ColumnDefinition Username = new ColumnDefinition("username", "username", TableName);
        //    public static ColumnDefinition Password = new ColumnDefinition("password", "password", TableName);
        //    public static ColumnDefinition LastLoginDate = new ColumnDefinition("lastLoginDate", "lastLoginDate", TableName);
        //    public static ColumnDefinition LastLoginTime = new ColumnDefinition("lastLoginTime", "lastLoginTime", TableName);
        //    public static ColumnDefinition EmployeeID = new ColumnDefinition("EmployeeID", "EmployeeID", TableName);
        //    public static ColumnDefinition CanStudentManager = new ColumnDefinition("CanStudentManager", "CanStudentManager", TableName);
        //    public static ColumnDefinition CanTimeManager = new ColumnDefinition("CanTimeManager", "CanTimeManager", TableName);
        //    public static ColumnDefinition CanEmployeeManager = new ColumnDefinition("CanEmployeeManager", "CanEmployeeManager", TableName);
        //    public static ColumnDefinition CanDBSettings = new ColumnDefinition("CanDBSettings", "CanDBSettings", TableName);
        //    public static ColumnDefinition CanTeacherManager = new ColumnDefinition("CanTeacherManager", "CanTeacherManager", TableName);
        //    public static ColumnDefinition CanMajorTeacherManager = new ColumnDefinition("CanMajorTeacherManager", "CanMajorTeacherManager", TableName);
        //    public static ColumnDefinition CanGuarantorManager = new ColumnDefinition("CanGuarantorManager", "CanGuarantorManager", TableName);
        //    public static ColumnDefinition CanTeacherTimeManager = new ColumnDefinition("CanTeacherTimeManager", "CanTeacherTimeManager", TableName);
        //    public static ColumnDefinition CanClassManager = new ColumnDefinition("CanClassManager", "CanClassManager", TableName);
        //    public static ColumnDefinition CanClassSessionManager = new ColumnDefinition("CanClassSessionManager", "CanClassSessionManager", TableName);
        //    public static ColumnDefinition CanOutcomeManager = new ColumnDefinition("CanOutcomeManager", "CanOutcomeManager", TableName);
        //    public static ColumnDefinition CanIncomeManager = new ColumnDefinition("CanIncomeManager", "CanIncomeManager", TableName);
        //    public static ColumnDefinition CanStudentRegisterationManager = new ColumnDefinition("CanStudentRegisterationManager", "CanStudentRegisterationManager", TableName);
        //    public static ColumnDefinition CanOutcomeTeacherClass = new ColumnDefinition("CanOutcomeTeacherClass", "CanOutcomeTeacherClass", TableName);
        //    public static ColumnDefinition CanOutcomeStudentClass = new ColumnDefinition("CanOutcomeStudentClass", "CanOutcomeStudentClass", TableName);
        //    public static ColumnDefinition CanTeacherFinancialDetails = new ColumnDefinition("CanTeacherFinancialDetails", "CanTeacherFinancialDetails", TableName);
        //    public static ColumnDefinition CanTeacherFinancialSessionDetails = new ColumnDefinition("CanTeacherFinancialSessionDetails", "CanTeacherFinancialSessionDetails", TableName);
        //    public static ColumnDefinition CanClassManagerPrivate = new ColumnDefinition("CanClassManagerPrivate", "CanClassManagerPrivate", TableName);
        //    public static ColumnDefinition CanClassManagerPublic = new ColumnDefinition("CanClassManagerPublic", "CanClassManagerPublic", TableName);
        //    public static ColumnDefinition CanPresenceManagerPrivate = new ColumnDefinition("CanPresenceManagerPrivate", "CanPresenceManagerPrivate", TableName);
        //    public static ColumnDefinition CanPresenceManagerPublic = new ColumnDefinition("CanPresenceManagerPublic", "CanPresenceManagerPublic", TableName);
        //    public static ColumnDefinition CanStoreStuffAvailableViewer = new ColumnDefinition("CanStoreStuffAvailableViewer", "CanStoreStuffAvailableViewer", TableName);
        //    public static ColumnDefinition CanStoreStuffTypeManager = new ColumnDefinition("CanStoreStuffTypeManager", "CanStoreStuffTypeManager", TableName);
        //    public static ColumnDefinition CanStoreStuffBuyManager = new ColumnDefinition("CanStoreStuffBuyManager", "CanStoreStuffBuyManager", TableName);
        //    public static ColumnDefinition CanStoreStuffSellItemManager = new ColumnDefinition("CanStoreStuffSellItemManager", "CanStoreStuffSellItemManager", TableName);
        //    public static ColumnDefinition CanStoreShopHistoryViewer = new ColumnDefinition("CanStoreShopHistoryViewer", "CanStoreShopHistoryViewer", TableName);
        //    public static ColumnDefinition CanStoreAffairs = new ColumnDefinition("CanStoreAffairs", "CanStoreAffairs", TableName);
        //    public static ColumnDefinition CanEmployeeSalary = new ColumnDefinition("CanEmployeeSalary", "CanEmployeeSalary", TableName);
        //    public static ColumnDefinition CanStudentInformationReport = new ColumnDefinition("CanStudentInformationReport", "CanStudentInformationReport", TableName);
        //    public static ColumnDefinition CanStudentPayForClass = new ColumnDefinition("CanStudentPayForClass", "CanStudentPayForClass", TableName);
        //    public static ColumnDefinition CanStudentAffairs = new ColumnDefinition("CanStudentAffairs", "CanStudentAffairs", TableName);
        //    public static ColumnDefinition CanActivityManager = new ColumnDefinition("CanActivityManager", "CanActivityManager", TableName);
        //    public static ColumnDefinition CanStoreStuffSellItem = new ColumnDefinition("CanStoreStuffSellItem", "CanStoreStuffSellItem", TableName);
        //    public static ColumnDefinition CanStoreSalesTracking = new ColumnDefinition("CanStoreSalesTracking", "CanStoreSalesTracking", TableName);
        //    public static ColumnDefinition CanSchoolSpecification = new ColumnDefinition("CanSchoolSpecification", "CanSchoolSpecification", TableName);
        //    public static ColumnDefinition CanDesktopUsers = new ColumnDefinition("CanDesktopUsers", "CanDesktopUsers", TableName);
        //    public static ColumnDefinition CanReportStudentListOfMajor = new ColumnDefinition("CanReportStudentListOfMajor", "CanReportStudentListOfMajor", TableName);
        //    public static ColumnDefinition CanReportPaysOfTeacherInterval = new ColumnDefinition("CanReportPaysOfTeacherInterval", "CanReportPaysOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportSessionsOfTeacherInterval = new ColumnDefinition("CanReportSessionsOfTeacherInterval", "CanReportSessionsOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportClassesOfTeacherInterval = new ColumnDefinition("CanReportClassesOfTeacherInterval", "CanReportClassesOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportMinistryReport = new ColumnDefinition("CanReportMinistryReport", "CanReportMinistryReport", TableName);
        //    public static ColumnDefinition CanReportStudentPayFactor = new ColumnDefinition("CanReportStudentPayFactor", "CanReportStudentPayFactor", TableName);
        //    public static ColumnDefinition CanReportTypicalOutcomeYear = new ColumnDefinition("CanReportTypicalOutcomeYear", "CanReportTypicalOutcomeYear", TableName);
        //    public static ColumnDefinition CanReportIncomeInterval = new ColumnDefinition("CanReportIncomeInterval", "CanReportIncomeInterval", TableName);
        //    public static ColumnDefinition CanReportRegisteredStudentsPerEmployee = new ColumnDefinition("CanReportRegisteredStudentsPerEmployee", "CanReportRegisteredStudentsPerEmployee", TableName);
        //    public static ColumnDefinition CanReportTeacherPayFactor = new ColumnDefinition("CanReportTeacherPayFactor", "CanReportTeacherPayFactor", TableName);
        //    public static ColumnDefinition CanReportEmployeePayFactor = new ColumnDefinition("CanReportEmployeePayFactor", "CanReportEmployeePayFactor", TableName);
        //    public static ColumnDefinition CanReportStudentOfPublicClass = new ColumnDefinition("CanReportStudentOfPublicClass", "CanReportStudentOfPublicClass", TableName);
        //    public static ColumnDefinition CanComboManager = new ColumnDefinition("CanComboManager", "CanComboManager", TableName);
        //    public static ColumnDefinition CanReportAffairs = new ColumnDefinition("CanReportAffairs", "CanReportAffairs", TableName);
        //}
        //public class DesktopUsers
        //{
        //    public static string TableName = "desktopUsers";

        //    public static ColumnDefinition Username = new ColumnDefinition("username", "نام کاربری", TableName);
        //    public static ColumnDefinition Password = new ColumnDefinition("password", "رمز عبور", TableName);
        //    public static ColumnDefinition LastLoginDate = new ColumnDefinition("lastLoginDate", "آخرین تاریخ عبور", TableName);
        //    public static ColumnDefinition LastLoginTime = new ColumnDefinition("lastLoginTime", "آخرین زمان ورود", TableName);
        //    public static ColumnDefinition EmployeeID = new ColumnDefinition("EmployeeID", "کارمند مربوطه", TableName);
        //    public static ColumnDefinition CanStudentManager = new ColumnDefinition("CanStudentManager", "CanStudentManager", TableName);
        //    public static ColumnDefinition CanStudentRegisterationManager = new ColumnDefinition("CanStudentRegisterationManager", "CanStudentRegisterationManager", TableName);
        //    public static ColumnDefinition CanStudentInformationReport = new ColumnDefinition("CanStudentInformationReport", "CanStudentInformationReport", TableName);
        //    public static ColumnDefinition CanStudentPayForClass = new ColumnDefinition("CanStudentPayForClass", "CanStudentPayForClass", TableName);
        //    public static ColumnDefinition CanStudentSessionDetails = new ColumnDefinition("CanStudentSessionDetails", "CanStudentSessionDetails", TableName);
        //    public static ColumnDefinition CanStudentFinancialDetails = new ColumnDefinition("CanStudentFinancialDetails", "CanStudentFinancialDetails", TableName);
        //    public static ColumnDefinition CanStudentFinancialStatus = new ColumnDefinition("CanStudentFinancialStatus", "CanStudentFinancialStatus", TableName);
        //    public static ColumnDefinition CanStudentClassBalance = new ColumnDefinition("CanStudentClassBalance", "CanStudentClassBalance", TableName);
        //    public static ColumnDefinition CanStudentAffairs = new ColumnDefinition("CanStudentAffairs", "CanStudentAffairs", TableName);
        //    public static ColumnDefinition CanTeacherFinancialStatus = new ColumnDefinition("CanTeacherFinancialStatus", "CanTeacherFinancialStatus", TableName);
        //    public static ColumnDefinition CanTeacherFinancialDetails = new ColumnDefinition("CanTeacherFinancialDetails", "CanTeacherFinancialDetails", TableName);
        //    public static ColumnDefinition CanTeacherSessionDetails = new ColumnDefinition("CanTeacherSessionDetails", "CanTeacherSessionDetails", TableName);
        //    public static ColumnDefinition CanTeacherManager = new ColumnDefinition("CanTeacherManager", "CanTeacherManager", TableName);
        //    public static ColumnDefinition CanMajorTeacherManager = new ColumnDefinition("CanMajorTeacherManager", "CanMajorTeacherManager", TableName);
        //    public static ColumnDefinition CanTeacherClassBalance = new ColumnDefinition("CanTeacherClassBalance", "CanTeacherClassBalance", TableName);
        //    public static ColumnDefinition CanTeacherPayForClass = new ColumnDefinition("CanTeacherPayForClass", "CanTeacherPayForClass", TableName);
        //    public static ColumnDefinition CanTeacherTimeSelector = new ColumnDefinition("CanTeacherTimeSelector", "CanTeacherTimeSelector", TableName);
        //    public static ColumnDefinition CanClassSessionStatusSetter = new ColumnDefinition("CanClassSessionStatusSetter", "CanClassSessionStatusSetter", TableName);
        //    public static ColumnDefinition CanClassSessionScheduleSetter = new ColumnDefinition("CanClassSessionScheduleSetter", "CanClassSessionScheduleSetter", TableName);
        //    public static ColumnDefinition CanClassManagerPrivate = new ColumnDefinition("CanClassManagerPrivate", "CanClassManagerPrivate", TableName);
        //    public static ColumnDefinition CanClassManagerPublic = new ColumnDefinition("CanClassManagerPublic", "CanClassManagerPublic", TableName);
        //    public static ColumnDefinition CanClassDailyStatus = new ColumnDefinition("CanClassDailyStatus", "CanClassDailyStatus", TableName);
        //    public static ColumnDefinition CanPresenceManager = new ColumnDefinition("CanPresenceManager", "CanPresenceManager", TableName);
        //    public static ColumnDefinition CanTimeManager = new ColumnDefinition("CanTimeManager", "CanTimeManager", TableName);
        //    public static ColumnDefinition CanEmployeeManager = new ColumnDefinition("CanEmployeeManager", "CanEmployeeManager", TableName);
        //    public static ColumnDefinition CanEmployeeSalary = new ColumnDefinition("CanEmployeeSalary", "CanEmployeeSalary", TableName);
        //    public static ColumnDefinition CanComboManager = new ColumnDefinition("CanComboManager", "CanComboManager", TableName);
        //    public static ColumnDefinition CanActivityManager = new ColumnDefinition("CanActivityManager", "CanActivityManager", TableName);
        //    public static ColumnDefinition CanDBSettings = new ColumnDefinition("CanDBSettings", "CanDBSettings", TableName);
        //    public static ColumnDefinition CanGuarantorManager = new ColumnDefinition("CanGuarantorManager", "CanGuarantorManager", TableName);
        //    public static ColumnDefinition CanSchoolSpecification = new ColumnDefinition("CanSchoolSpecification", "CanSchoolSpecification", TableName);
        //    public static ColumnDefinition CanDesktopUsers = new ColumnDefinition("CanDesktopUsers", "CanDesktopUsers", TableName);
        //    public static ColumnDefinition CanOutcomeManager = new ColumnDefinition("CanOutcomeManager", "CanOutcomeManager", TableName);
        //    public static ColumnDefinition CanIncomeManager = new ColumnDefinition("CanIncomeManager", "CanIncomeManager", TableName);
        //    public static ColumnDefinition CanStoreStuffAvailableViewer = new ColumnDefinition("CanStoreStuffAvailableViewer", "CanStoreStuffAvailableViewer", TableName);
        //    public static ColumnDefinition CanStoreStuffTypeManager = new ColumnDefinition("CanStoreStuffTypeManager", "CanStoreStuffTypeManager", TableName);
        //    public static ColumnDefinition CanStoreStuffBuyManager = new ColumnDefinition("CanStoreStuffBuyManager", "CanStoreStuffBuyManager", TableName);
        //    public static ColumnDefinition CanStoreStuffSellItemManager = new ColumnDefinition("CanStoreStuffSellItemManager", "CanStoreStuffSellItemManager", TableName);
        //    public static ColumnDefinition CanStoreShopHistoryViewer = new ColumnDefinition("CanStoreShopHistoryViewer", "CanStoreShopHistoryViewer", TableName);
        //    public static ColumnDefinition CanStoreAffairs = new ColumnDefinition("CanStoreAffairs", "CanStoreAffairs", TableName);
        //    public static ColumnDefinition CanStoreStuffSellItem = new ColumnDefinition("CanStoreStuffSellItem", "CanStoreStuffSellItem", TableName);
        //    public static ColumnDefinition CanStoreSalesTracking = new ColumnDefinition("CanStoreSalesTracking", "CanStoreSalesTracking", TableName);
        //    public static ColumnDefinition CanReportStudentListOfMajor = new ColumnDefinition("CanReportStudentListOfMajor", "CanReportStudentListOfMajor", TableName);
        //    public static ColumnDefinition CanReportPaysOfTeacherInterval = new ColumnDefinition("CanReportPaysOfTeacherInterval", "CanReportPaysOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportSessionsOfTeacherInterval = new ColumnDefinition("CanReportSessionsOfTeacherInterval", "CanReportSessionsOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportClassesOfTeacherInterval = new ColumnDefinition("CanReportClassesOfTeacherInterval", "CanReportClassesOfTeacherInterval", TableName);
        //    public static ColumnDefinition CanReportMinistryReport = new ColumnDefinition("CanReportMinistryReport", "CanReportMinistryReport", TableName);
        //    public static ColumnDefinition CanReportStudentPayFactor = new ColumnDefinition("CanReportStudentPayFactor", "CanReportStudentPayFactor", TableName);
        //    public static ColumnDefinition CanReportTypicalOutcomeYear = new ColumnDefinition("CanReportTypicalOutcomeYear", "CanReportTypicalOutcomeYear", TableName);
        //    public static ColumnDefinition CanReportIncomeInterval = new ColumnDefinition("CanReportIncomeInterval", "CanReportIncomeInterval", TableName);
        //    public static ColumnDefinition CanReportRegisteredStudentsPerEmployee = new ColumnDefinition("CanReportRegisteredStudentsPerEmployee", "CanReportRegisteredStudentsPerEmployee", TableName);
        //    public static ColumnDefinition CanReportTeacherPayFactor = new ColumnDefinition("CanReportTeacherPayFactor", "CanReportTeacherPayFactor", TableName);
        //    public static ColumnDefinition CanReportEmployeePayFactor = new ColumnDefinition("CanReportEmployeePayFactor", "CanReportEmployeePayFactor", TableName);
        //    public static ColumnDefinition CanReportStudentOfPublicClass = new ColumnDefinition("CanReportStudentOfPublicClass", "CanReportStudentOfPublicClass", TableName);
        //    public static ColumnDefinition CanReportAffairs = new ColumnDefinition("CanReportAffairs", "CanReportAffairs", TableName);
        //}

        public class DesktopUsers
        {
            public static string TableName = "desktopUsers";

            public static ColumnDefinition Username = new ColumnDefinition("username", "نام کاربری", TableName);
            public static ColumnDefinition Password = new ColumnDefinition("password", "کلمه‌ی عبور", TableName);
            public static ColumnDefinition LastLoginDate = new ColumnDefinition("lastLoginDate", "آخرین تاریخ ورود", TableName);
            public static ColumnDefinition LastLoginTime = new ColumnDefinition("lastLoginTime", "آخرین زمان ورود", TableName);
            public static ColumnDefinition EmployeeID = new ColumnDefinition("EmployeeID", "نام کارمند", TableName);
            public static ColumnDefinition CanStudentManager = new ColumnDefinition("CanStudentManager", "CanStudentManager", TableName);
            public static ColumnDefinition CanStudentRegisterationManager = new ColumnDefinition("CanStudentRegisterationManager", "CanStudentRegisterationManager", TableName);
            public static ColumnDefinition CanStudentInformationReport = new ColumnDefinition("CanStudentInformationReport", "CanStudentInformationReport", TableName);
            public static ColumnDefinition CanStudentPayForClass = new ColumnDefinition("CanStudentPayForClass", "CanStudentPayForClass", TableName);
            public static ColumnDefinition CanStudentSessionDetails = new ColumnDefinition("CanStudentSessionDetails", "CanStudentSessionDetails", TableName);
            public static ColumnDefinition CanStudentFinancialDetails = new ColumnDefinition("CanStudentFinancialDetails", "CanStudentFinancialDetails", TableName);
            public static ColumnDefinition CanStudentFinancialStatus = new ColumnDefinition("CanStudentFinancialStatus", "CanStudentFinancialStatus", TableName);
            public static ColumnDefinition CanStudentClassBalance = new ColumnDefinition("CanStudentClassBalance", "CanStudentClassBalance", TableName);
            public static ColumnDefinition CanStudentAffairs = new ColumnDefinition("CanStudentAffairs", "CanStudentAffairs", TableName);
            public static ColumnDefinition CanTeacherFinancialStatus = new ColumnDefinition("CanTeacherFinancialStatus", "CanTeacherFinancialStatus", TableName);
            public static ColumnDefinition CanTeacherFinancialDetails = new ColumnDefinition("CanTeacherFinancialDetails", "CanTeacherFinancialDetails", TableName);
            public static ColumnDefinition CanTeacherSessionDetails = new ColumnDefinition("CanTeacherSessionDetails", "CanTeacherSessionDetails", TableName);
            public static ColumnDefinition CanTeacherManager = new ColumnDefinition("CanTeacherManager", "CanTeacherManager", TableName);
            public static ColumnDefinition CanMajorTeacherManager = new ColumnDefinition("CanMajorTeacherManager", "CanMajorTeacherManager", TableName);
            public static ColumnDefinition CanTeacherClassBalance = new ColumnDefinition("CanTeacherClassBalance", "CanTeacherClassBalance", TableName);
            public static ColumnDefinition CanTeacherPayForClass = new ColumnDefinition("CanTeacherPayForClass", "CanTeacherPayForClass", TableName);
            public static ColumnDefinition CanTeacherTimeSelector = new ColumnDefinition("CanTeacherTimeSelector", "CanTeacherTimeSelector", TableName);
            public static ColumnDefinition CanClassSessionStatusSetter = new ColumnDefinition("CanClassSessionStatusSetter", "CanClassSessionStatusSetter", TableName);
            public static ColumnDefinition CanClassSessionScheduleSetter = new ColumnDefinition("CanClassSessionScheduleSetter", "CanClassSessionScheduleSetter", TableName);
            public static ColumnDefinition CanClassManagerPrivate = new ColumnDefinition("CanClassManagerPrivate", "CanClassManagerPrivate", TableName);
            public static ColumnDefinition CanClassManagerPublic = new ColumnDefinition("CanClassManagerPublic", "CanClassManagerPublic", TableName);
            public static ColumnDefinition CanClassDailyStatus = new ColumnDefinition("CanClassDailyStatus", "CanClassDailyStatus", TableName);
            public static ColumnDefinition CanPresenceManager = new ColumnDefinition("CanPresenceManager", "CanPresenceManager", TableName);
            public static ColumnDefinition CanTimeManager = new ColumnDefinition("CanTimeManager", "CanTimeManager", TableName);
            public static ColumnDefinition CanEmployeeManager = new ColumnDefinition("CanEmployeeManager", "CanEmployeeManager", TableName);
            public static ColumnDefinition CanEmployeeSalary = new ColumnDefinition("CanEmployeeSalary", "CanEmployeeSalary", TableName);
            public static ColumnDefinition CanComboManager = new ColumnDefinition("CanComboManager", "CanComboManager", TableName);
            public static ColumnDefinition CanActivityManager = new ColumnDefinition("CanActivityManager", "CanActivityManager", TableName);
            public static ColumnDefinition CanDBSettings = new ColumnDefinition("CanDBSettings", "CanDBSettings", TableName);
            public static ColumnDefinition CanGuarantorManager = new ColumnDefinition("CanGuarantorManager", "CanGuarantorManager", TableName);
            public static ColumnDefinition CanSchoolSpecification = new ColumnDefinition("CanSchoolSpecification", "CanSchoolSpecification", TableName);
            public static ColumnDefinition CanDesktopUsers = new ColumnDefinition("CanDesktopUsers", "CanDesktopUsers", TableName);
            public static ColumnDefinition CanOutcomeManager = new ColumnDefinition("CanOutcomeManager", "CanOutcomeManager", TableName);
            public static ColumnDefinition CanIncomeManager = new ColumnDefinition("CanIncomeManager", "CanIncomeManager", TableName);
            public static ColumnDefinition CanSynchDatabase = new ColumnDefinition("CanSynchDatabase", "CanSynchDatabase", TableName);
            public static ColumnDefinition CanStoreStuffAvailableViewer = new ColumnDefinition("CanStoreStuffAvailableViewer", "CanStoreStuffAvailableViewer", TableName);
            public static ColumnDefinition CanStoreStuffTypeManager = new ColumnDefinition("CanStoreStuffTypeManager", "CanStoreStuffTypeManager", TableName);
            public static ColumnDefinition CanStoreStuffBuyManager = new ColumnDefinition("CanStoreStuffBuyManager", "CanStoreStuffBuyManager", TableName);
            public static ColumnDefinition CanStoreStuffSellItemManager = new ColumnDefinition("CanStoreStuffSellItemManager", "CanStoreStuffSellItemManager", TableName);
            public static ColumnDefinition CanStoreShopHistoryViewer = new ColumnDefinition("CanStoreShopHistoryViewer", "CanStoreShopHistoryViewer", TableName);
            public static ColumnDefinition CanStoreAffairs = new ColumnDefinition("CanStoreAffairs", "CanStoreAffairs", TableName);
            public static ColumnDefinition CanStoreStuffSellItem = new ColumnDefinition("CanStoreStuffSellItem", "CanStoreStuffSellItem", TableName);
            public static ColumnDefinition CanStoreSalesTracking = new ColumnDefinition("CanStoreSalesTracking", "CanStoreSalesTracking", TableName);
            public static ColumnDefinition CanReportStudentListOfMajor = new ColumnDefinition("CanReportStudentListOfMajor", "CanReportStudentListOfMajor", TableName);
            public static ColumnDefinition CanReportPaysOfTeacherInterval = new ColumnDefinition("CanReportPaysOfTeacherInterval", "CanReportPaysOfTeacherInterval", TableName);
            public static ColumnDefinition CanReportSessionsOfTeacherInterval = new ColumnDefinition("CanReportSessionsOfTeacherInterval", "CanReportSessionsOfTeacherInterval", TableName);
            public static ColumnDefinition CanReportClassesOfTeacherInterval = new ColumnDefinition("CanReportClassesOfTeacherInterval", "CanReportClassesOfTeacherInterval", TableName);
            public static ColumnDefinition CanReportMinistryReport = new ColumnDefinition("CanReportMinistryReport", "CanReportMinistryReport", TableName);
            public static ColumnDefinition CanReportStudentPayFactor = new ColumnDefinition("CanReportStudentPayFactor", "CanReportStudentPayFactor", TableName);
            public static ColumnDefinition CanReportTypicalOutcomeYear = new ColumnDefinition("CanReportTypicalOutcomeYear", "CanReportTypicalOutcomeYear", TableName);
            public static ColumnDefinition CanReportIncomeInterval = new ColumnDefinition("CanReportIncomeInterval", "CanReportIncomeInterval", TableName);
            public static ColumnDefinition CanReportRegisteredStudentsPerEmployee = new ColumnDefinition("CanReportRegisteredStudentsPerEmployee", "CanReportRegisteredStudentsPerEmployee", TableName);
            public static ColumnDefinition CanReportTeacherPayFactor = new ColumnDefinition("CanReportTeacherPayFactor", "CanReportTeacherPayFactor", TableName);
            public static ColumnDefinition CanReportEmployeePayFactor = new ColumnDefinition("CanReportEmployeePayFactor", "CanReportEmployeePayFactor", TableName);
            public static ColumnDefinition CanReportStudentOfPublicClass = new ColumnDefinition("CanReportStudentOfPublicClass", "CanReportStudentOfPublicClass", TableName);
            public static ColumnDefinition CanReportAffairs = new ColumnDefinition("CanReportAffairs", "CanReportAffairs", TableName);
        }









        //public static class Employee
        //{
        //    public static string TableName = "Employee";

        //    public static ColumnDefinition EmployeeID = new ColumnDefinition("EmployeeID", "کد کارمند", TableName);
        //    public static ColumnDefinition FirstName = new ColumnDefinition("FirstName", "نام", TableName);
        //    public static ColumnDefinition LastName = new ColumnDefinition("LastName", "نام خانوادگی", TableName);
        //    public static ColumnDefinition ContractTypeID = new ColumnDefinition("ContractTypeID", "سطح استاد", TableName);
        //    public static ColumnDefinition CertificationNumber = new ColumnDefinition("CertificationNumber", "شماره شناسنامه", TableName);
        //    public static ColumnDefinition NationalNumber = new ColumnDefinition("NationalNumber", "کد ملی", TableName);
        //    public static ColumnDefinition Gender = new ColumnDefinition("Gender", "جنسیت", TableName);
        //    public static ColumnDefinition BirthDate = new ColumnDefinition("BirthDate", "تاریخ تولد", TableName);

        //    public static ColumnDefinition FatherName = new ColumnDefinition("FatherName", "نام پدر", TableName);
        //    public static ColumnDefinition EntranceYear = new ColumnDefinition("EntranceYear", "سال ورود", TableName);
        //    public static ColumnDefinition Tell = new ColumnDefinition("Tell", "تلفن", TableName);
        //    public static ColumnDefinition CellPhone = new ColumnDefinition("CellPhone", "موبایل", TableName);
        //    public static ColumnDefinition Address = new ColumnDefinition("Address", "آدرس فعلی", TableName);
        //    public static ColumnDefinition BirthCity = new ColumnDefinition("BirthCity", "شهر محل تولد", TableName);
        //    public static ColumnDefinition Soodoor = new ColumnDefinition("Soodoor", "محل صدور", TableName);
        //    public static ColumnDefinition MilitaryServiceID = new ColumnDefinition("MilitaryServiceID", "وضعیت خدمت سربازی", TableName);
        //    public static ColumnDefinition Email = new ColumnDefinition("Email", "پست الکترونیک", TableName);
        //    public static ColumnDefinition Username = new ColumnDefinition("Username", "نام کاربری", TableName);
        //    public static ColumnDefinition Password = new ColumnDefinition("Password", "رمز ورود", TableName);
        //    public static ColumnDefinition LastLogin = new ColumnDefinition("LastLogin", "آخرین ورود به سیستم", TableName);
        //    public static ColumnDefinition DepartmentID = new ColumnDefinition("DepartmentID", "آخرین ورود به سیستم", TableName);
        //    public static ColumnDefinition MartialStatus = new ColumnDefinition("MartialStatus", "وضعیت تاهل", TableName);
        //    public static ColumnDefinition Picture = new ColumnDefinition("Picture", "عکس", TableName);
        //}

        // CG
        public class Student
        {
            public static string TableName = "student";

            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "کد هنرجو", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام هنرجو", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition FatherName = new ColumnDefinition("fatherName", "نام پدر", TableName);
            public static ColumnDefinition Gender = new ColumnDefinition("gender", "جنسیت", TableName);
            public static ColumnDefinition CertificationNumber = new ColumnDefinition("certificationNumber", "شماره‌ی شناسنامه", TableName);
            public static ColumnDefinition NationalNumber = new ColumnDefinition("nationalNumber", "کد ملی", TableName);
            public static ColumnDefinition BirthDate = new ColumnDefinition("birthDate", "تاریخ تولد", TableName);
            public static ColumnDefinition BornPlace = new ColumnDefinition("bornPlace", "شهر محل تولد", TableName);
            public static ColumnDefinition BornProvince = new ColumnDefinition("bornProvince", "استان محل تولد", TableName);
            public static ColumnDefinition BornCountry = new ColumnDefinition("bornCountry", "کشور محل تولد", TableName);
            public static ColumnDefinition IssuePlace = new ColumnDefinition("issuePlace", "محل صدور", TableName);
            public static ColumnDefinition MartialStatus = new ColumnDefinition("martialStatus", "وضعیت تاهل", TableName);
            public static ColumnDefinition AreaID = new ColumnDefinition("areaID", "منطقه", TableName);
            public static ColumnDefinition AddressHome = new ColumnDefinition("addressHome", "آدرس منزل", TableName);
            public static ColumnDefinition TellHome = new ColumnDefinition("tellHome", "تلفن منزل", TableName);
            public static ColumnDefinition AddressWork = new ColumnDefinition("addressWork", "آدرس محل کار", TableName);
            public static ColumnDefinition TellWork = new ColumnDefinition("tellWork", "تلفن محل کار", TableName);
            public static ColumnDefinition CellPhone = new ColumnDefinition("cellPhone", "تلفن همراه", TableName);
            public static ColumnDefinition DegreeTypeID = new ColumnDefinition("degreeTypeID", "نوع مدرک", TableName);
            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "سطح تحصیلات", TableName);
            public static ColumnDefinition StudyMajor = new ColumnDefinition("studyMajor", "رشته‌ی تحصیلی", TableName);
            public static ColumnDefinition StudyStatus = new ColumnDefinition("studyStatus", "وضعیت تحصیل", TableName);
            public static ColumnDefinition Job = new ColumnDefinition("job", "شغل", TableName);
            public static ColumnDefinition HowtoFindID = new ColumnDefinition("howtoFindID", "نحوه‌ی آشنایی", TableName);
            public static ColumnDefinition SchoolName = new ColumnDefinition("schoolName", "نام موسسه", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعال بودن", TableName);
            public static ColumnDefinition Image = new ColumnDefinition("image", "عکس", TableName);
            public static ColumnDefinition Username = new ColumnDefinition("username", "نام کاربری", TableName);
            public static ColumnDefinition Password = new ColumnDefinition("password", "کلمه‌ی عبور", TableName);
            public static ColumnDefinition ParentUserName = new ColumnDefinition("parentUserName", "نام کاربری والدین", TableName);
            public static ColumnDefinition ParentPassword = new ColumnDefinition("parentPassword", "کلمه‌ی عبور والدین", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "کد تغییر جدول", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "تاریخ تغییر جدول", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "ساعت تغییر جدول", TableName);
        }

        public class Area
        {
            public static string TableName = "area";

            public static ColumnDefinition AreaID = new ColumnDefinition("areaID", "کد ناحیه", TableName);
            public static ColumnDefinition AreaName = new ColumnDefinition("areaName", "ناحیه", TableName);
            public static ColumnDefinition AreaDescription = new ColumnDefinition("areaDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعال بودن", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class HowtoFind
        {
            public static string TableName = "howtoFind";

            public static ColumnDefinition HowtoFindID = new ColumnDefinition("howtoFindID", "کد نحوه‌ی پیدا کردن", TableName);
            public static ColumnDefinition HowtoFindName = new ColumnDefinition("howtoFindName", "نحوه‌ی پیدا کردن", TableName);
            public static ColumnDefinition HowtoFindDescription = new ColumnDefinition("howtoFindDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعال بودن", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class DegreeLevel
        {
            public static string TableName = "degreeLevel";

            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "کد سطح تحصیلی", TableName);
            public static ColumnDefinition DegreeLevelName = new ColumnDefinition("degreeLevelName", "سطح تحصیلی", TableName);
            public static ColumnDefinition DegreeLevelDescription = new ColumnDefinition("degreeLevelDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعال بودن", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class DegreeType
        {
            public static string TableName = "degreeType";

            public static ColumnDefinition DegreeTypeID = new ColumnDefinition("degreeTypeID", "کد نوع مدرک", TableName);
            public static ColumnDefinition DegreeTypeName = new ColumnDefinition("degreeTypeName", "نوع مدرک", TableName);
            public static ColumnDefinition DegreeTypeDescription = new ColumnDefinition("degreeTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Employee
        {
            public static string TableName = "employee";

            public static ColumnDefinition EmployeeID = new ColumnDefinition("employeeID", "شماره‌ی کارمند", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition FatherName = new ColumnDefinition("fatherName", "نام پدر", TableName);
            public static ColumnDefinition Gender = new ColumnDefinition("gender", "جنسیت", TableName);
            public static ColumnDefinition CertificationNumber = new ColumnDefinition("certificationNumber", "شماره‌ی شناسنامه", TableName);
            public static ColumnDefinition NationalNumber = new ColumnDefinition("nationalNumber", "کد ملی", TableName);
            public static ColumnDefinition BirthDate = new ColumnDefinition("birthDate", "تاریخ تولد", TableName);
            public static ColumnDefinition BornPlace = new ColumnDefinition("bornPlace", "شهر محل تولد", TableName);
            public static ColumnDefinition BornProvince = new ColumnDefinition("bornProvince", "استان محل تولد", TableName);
            public static ColumnDefinition BornCountry = new ColumnDefinition("bornCountry", "کشور محل تولد", TableName);
            public static ColumnDefinition IssuePlace = new ColumnDefinition("issuePlace", "محل صدور", TableName);
            public static ColumnDefinition MartialStatus = new ColumnDefinition("martialStatus", "وضعیت تاهل", TableName);
            public static ColumnDefinition HomeAddress = new ColumnDefinition("homeAddress", "آدرس منزل", TableName);
            public static ColumnDefinition HomeTell = new ColumnDefinition("homeTell", "تلفن منزل", TableName);
            public static ColumnDefinition CellPhone = new ColumnDefinition("cellPhone", "تلفن همراه", TableName);
            public static ColumnDefinition DegreeTypeID = new ColumnDefinition("degreeTypeID", "نوع مدرک", TableName);
            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "سطح علمی مدرک", TableName);
            public static ColumnDefinition StudyMajor = new ColumnDefinition("studyMajor", "رشته‌ی تحصیلی", TableName);
            public static ColumnDefinition StudyStatus = new ColumnDefinition("studyStatus", "در حال تحصیل", TableName);
            public static ColumnDefinition Job = new ColumnDefinition("job", "شغل", TableName);
            public static ColumnDefinition HowtoFindID = new ColumnDefinition("howtoFindID", "نحوه‌ی آشنایی", TableName);
            public static ColumnDefinition School = new ColumnDefinition("school", "نام دانشگاه", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت کاربری", TableName);
            public static ColumnDefinition GuarantorID = new ColumnDefinition("guarantorID", "شماره‌ی ضامن", TableName);
            public static ColumnDefinition Image = new ColumnDefinition("image", "عکس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Guarantor
        {
            public static string TableName = "guarantor";

            public static ColumnDefinition GuarantorID = new ColumnDefinition("guarantorID", "شماره‌ی ضامن", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition FatherName = new ColumnDefinition("fatherName", "نام پدر", TableName);
            public static ColumnDefinition Gender = new ColumnDefinition("gender", "جنسیت", TableName);
            public static ColumnDefinition CertificationNumber = new ColumnDefinition("certificationNumber", "شماره‌ی شناسنامه", TableName);
            public static ColumnDefinition NationalNumber = new ColumnDefinition("nationalNumber", "کد ملی", TableName);
            public static ColumnDefinition BirthDate = new ColumnDefinition("birthDate", "تاریخ تولد", TableName);
            public static ColumnDefinition BornPlace = new ColumnDefinition("bornPlace", "محل تولد", TableName);
            public static ColumnDefinition IssuePlace = new ColumnDefinition("issuePlace", "محل صدور", TableName);
            public static ColumnDefinition MartialStatus = new ColumnDefinition("martialStatus", "وضعیت تاهل", TableName);
            public static ColumnDefinition HomeAddress = new ColumnDefinition("homeAddress", "آدرس منزل", TableName);
            public static ColumnDefinition HomeTell = new ColumnDefinition("homeTell", "تلفن منزل", TableName);
            public static ColumnDefinition WorkAddress = new ColumnDefinition("workAddress", "آدرس محل کار", TableName);
            public static ColumnDefinition WorkTell = new ColumnDefinition("workTell", "تلفن محل کار", TableName);
            public static ColumnDefinition CellPhone = new ColumnDefinition("cellPhone", "تلفن همراه", TableName);
            public static ColumnDefinition Job = new ColumnDefinition("job", "شغل", TableName);
            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "سطح تحصیلات", TableName);
            public static ColumnDefinition StudyMajor = new ColumnDefinition("studyMajor", "رشته‌ی تحصیلی", TableName);
            public static ColumnDefinition Guarantee = new ColumnDefinition("guarantee", "ضمانت", TableName);
            public static ColumnDefinition Image = new ColumnDefinition("Image", "عکس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class ContractType
        {
            public static string TableName = "contractType";

            public static ColumnDefinition ContractTypeID = new ColumnDefinition("contractTypeID", "کد نوع قرارداد", TableName);
            public static ColumnDefinition ContractTypeName = new ColumnDefinition("contractTypeName", "نوع قرارداد", TableName);
            public static ColumnDefinition ContractTypeDescription = new ColumnDefinition("contractTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Teacher
        {
            public static string TableName = "teacher";

            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام استاد", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition FatherName = new ColumnDefinition("fatherName", "نام پدر", TableName);
            public static ColumnDefinition Gender = new ColumnDefinition("gender", "جنسیت", TableName);
            public static ColumnDefinition CertificationNumber = new ColumnDefinition("certificationNumber", "شماره‌ی شناسنامه", TableName);
            public static ColumnDefinition NationalNumber = new ColumnDefinition("nationalNumber", "کد ملی", TableName);
            public static ColumnDefinition BirthDate = new ColumnDefinition("birthDate", "تاریخ تولد", TableName);
            public static ColumnDefinition BornPlace = new ColumnDefinition("bornPlace", "شهر محل تولد", TableName);
            public static ColumnDefinition BornProvince = new ColumnDefinition("bornProvince", "استان محل تولد", TableName);
            public static ColumnDefinition BornCountry = new ColumnDefinition("bornCountry", "کشور محل تولد", TableName);
            public static ColumnDefinition IssuePlace = new ColumnDefinition("issuePlace", "محل صدور", TableName);
            public static ColumnDefinition MartialStatus = new ColumnDefinition("martialStatus", "وضعیت تاهل", TableName);
            public static ColumnDefinition HomeAddress = new ColumnDefinition("homeAddress", "آدرس منزل", TableName);
            public static ColumnDefinition HomeTell = new ColumnDefinition("homeTell", "تلفن منزل", TableName);
            public static ColumnDefinition WorkAddress = new ColumnDefinition("workAddress", "آدرس محل کار", TableName);
            public static ColumnDefinition WorkTell = new ColumnDefinition("workTell", "تلفن محل کار", TableName);
            public static ColumnDefinition CellPhone = new ColumnDefinition("cellPhone", "تلفن همراه", TableName);
            public static ColumnDefinition DegreeTypeID = new ColumnDefinition("degreeTypeID", "مدرک تحصیلی", TableName);
            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "سطح تحصیلات", TableName);
            public static ColumnDefinition StudyMajor = new ColumnDefinition("studyMajor", "رشته‌ی تحصیلی", TableName);
            public static ColumnDefinition StudyStatus = new ColumnDefinition("studyStatus", "در حال تحصیل", TableName);
            public static ColumnDefinition Job = new ColumnDefinition("job", "شغل", TableName);
            public static ColumnDefinition Introducer = new ColumnDefinition("introducer", "معرف", TableName);
            public static ColumnDefinition QulificationCardID = new ColumnDefinition("qulificationCardID", "شماره‌ی کارت تدریس", TableName);
            public static ColumnDefinition Teachers = new ColumnDefinition("teachers", "اساتید", TableName);
            public static ColumnDefinition TeachingExprience = new ColumnDefinition("teachingExprience", "تجربه‌ی تدریس", TableName);
            public static ColumnDefinition School = new ColumnDefinition("school", "محل تحصیل", TableName);
            public static ColumnDefinition ContractTypeID = new ColumnDefinition("contractTypeID", "نوع قرارداد", TableName);
            public static ColumnDefinition ContractValue = new ColumnDefinition("contractValue", "مبلغ قرارداد", TableName);
            public static ColumnDefinition Image = new ColumnDefinition("image", "عکس", TableName);
            public static ColumnDefinition Username = new ColumnDefinition("username", "نام کاربری", TableName);
            public static ColumnDefinition Password = new ColumnDefinition("password", "رمز عبور", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت کاربری", TableName);
            public static ColumnDefinition CanShowOnWeb = new ColumnDefinition("canShowOnWeb", "نمایش در اینترنت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Major
        {
            public static string TableName = "major";

            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "کد رشته", TableName);
            public static ColumnDefinition MajorName = new ColumnDefinition("majorName", "نام رشته", TableName);
            public static ColumnDefinition MajorDescription = new ColumnDefinition("majorDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class MajorTeacher
        {
            public static string TableName = "majorTeacher";

            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "کد رشته", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition SpecialMajorFlag = new ColumnDefinition("specialMajorFlag", "رشته‌ی تخصصی", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Day
        {
            public static string TableName = "day";

            public static ColumnDefinition DayID = new ColumnDefinition("dayID", "کد روز", TableName);
            public static ColumnDefinition DayName = new ColumnDefinition("dayName", "روز", TableName);
        }

        public class Time
        {
            public static string TableName = "time";

            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "ساعت", TableName);
            public static ColumnDefinition StartHour = new ColumnDefinition("startHour", "ساعت شروع", TableName);
            public static ColumnDefinition StartMin = new ColumnDefinition("startMin", "دقیقه‌ی شروع", TableName);
            public static ColumnDefinition FinishHour = new ColumnDefinition("finishHour", "ساعت پایان", TableName);
            public static ColumnDefinition FinishMin = new ColumnDefinition("finishMin", "دقیقه‌ی پایان", TableName);
            public static ColumnDefinition Activitystatuse = new ColumnDefinition("activitystatuse", "وضعیت فعالیت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);

            //Utility
            public static ColumnDefinition TimeName = new ColumnDefinition("TimeName", "زمان", TableName);
            public static ColumnDefinition Duration = new ColumnDefinition("Duration", "مدت", TableName);
        }

        public class TeacherTime
        {
            public static string TableName = "teacherTime";

            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "استاد", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "ساعت", TableName);
            public static ColumnDefinition DayID = new ColumnDefinition("dayID", "روز", TableName);
            public static ColumnDefinition StartDate = new ColumnDefinition("startDate", "روز شروع", TableName);
            public static ColumnDefinition FinishDate = new ColumnDefinition("finishDate", "روز پایان", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Class
        {
            public static string TableName = "class";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "رشته", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "استاد", TableName);
            public static ColumnDefinition Price = new ColumnDefinition("price", "قیمت", TableName);
            public static ColumnDefinition SchoolPrice = new ColumnDefinition("schoolPrice", "سهم موسسه", TableName);
            public static ColumnDefinition SessionCount = new ColumnDefinition("sessionCount", "تعداد جلسات", TableName);
            public static ColumnDefinition ClassDescription = new ColumnDefinition("classDescription", "توضیحات", TableName);
            public static ColumnDefinition GroupFlag = new ColumnDefinition("groupFlag", "کلاس گروهی", TableName);
            public static ColumnDefinition RegistrationExpireDate = new ColumnDefinition("registrationExpireDate", "تاریخ پایان ثبت نام", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition ContractTypeID = new ColumnDefinition("ContractTypeID", "کد نوع قرارداد", TableName);
            public static ColumnDefinition ContractValue = new ColumnDefinition("ContractValue", "مبلغ", TableName);
            public static ColumnDefinition IsBalancedFinalWithTeacher = new ColumnDefinition("isBalancedFinalWithTeacher", "تسویه حساب با استاد", TableName);
        }



        public class Rooms
        {
            public static string TableName = "rooms";

            public static ColumnDefinition RoomNo = new ColumnDefinition("roomNo", "کد اتاق", TableName);
            public static ColumnDefinition RoomName = new ColumnDefinition("roomName", "نام اتاق", TableName);
            public static ColumnDefinition RoomDescription = new ColumnDefinition("roomDescription", "توضیحات اتاق", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class Classsession
        {
            public static string TableName = "classsession";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition ClassDate = new ColumnDefinition("classDate", "تاریخ تشکیل", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "ساعت تشکیل", TableName);
            public static ColumnDefinition StudentAbsence = new ColumnDefinition("studentAbsence", "غیبت هنرجویان", TableName);
            public static ColumnDefinition TeacherAbsence = new ColumnDefinition("teacherAbsence", "غیبت استاد", TableName);
            public static ColumnDefinition ContinuousAbsence = new ColumnDefinition("continuousAbsence", "غیبت مستمر", TableName);
            public static ColumnDefinition SessionStatus = new ColumnDefinition("sessionStatus", "وضعیت کلاس", TableName);
            public static ColumnDefinition RoomNo = new ColumnDefinition("roomNo", "اتاق", TableName);
            public static ColumnDefinition SuccessorTeacher = new ColumnDefinition("successorTeacher", "استاد جایگرین", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition RemainedSessions = new ColumnDefinition("remainedSessions", "باقیمانده", TableName);
        }

        public class OutcomeTypical
        {
            public static string TableName = "outcomeTypical";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition OutcomeTypicalTypeID = new ColumnDefinition("outcomeTypicalTypeID", "نوع هزینه‌ی ساده", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "هزینه", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition Tag = new ColumnDefinition("Tag", "شخص مربوطه", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
        }

        public class OutcomeTypicalType
        {
            public static string TableName = "outcomeTypicalType";

            public static ColumnDefinition OutcomeTypicalTypeID = new ColumnDefinition("outcomeTypicalTypeID", "کد نوع هزینه‌ی ساده", TableName);
            public static ColumnDefinition OutcomeTypicalTypeName = new ColumnDefinition("outcomeTypicalTypeName", "نوع هزینه‌ی ساده", TableName);
            public static ColumnDefinition OutcomeTypicalTypeDescription = new ColumnDefinition("outcomeTypicalTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class OutcomeOveralType
        {
            public static string TableName = "outcomeOveralType";

            public static ColumnDefinition OutcomeOveralTypeID = new ColumnDefinition("outcomeOveralTypeID", "کد نوع هزینه", TableName);
            public static ColumnDefinition OutcomeOveralTypeName = new ColumnDefinition("outcomeOveralTypeName", "نوع هزینه", TableName);
            public static ColumnDefinition OutcomeOveralTypeDescription = new ColumnDefinition("outcomeOveralTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class OutcomeBuyStuff
        {
            public static string TableName = "outcomeBuyStuff";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد هزینه", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "fee", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "بابت", TableName);
            public static ColumnDefinition StuffCount = new ColumnDefinition("stuffCount", "تعداد", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
        }

        public class OutcomeStudent
        {
            public static string TableName = "outcomeStudent";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "شماره‌ی هنرجو", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک/حواله/فیش", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/حواله/فیش", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class OutcomeEmployee
        {
            public static string TableName = "outcomeEmployee";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition EmployeeID = new ColumnDefinition("employeeID", "کارمند", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک/فیش/حواله", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition DateFrom = new ColumnDefinition("dateFrom", "از تاریخ", TableName);
            public static ColumnDefinition DateTo = new ColumnDefinition("dateTo", "تا تاریخ:", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class OutcomeTeacher
        {
            public static string TableName = "outcomeTeacher";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک/حواله/فیش", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition GroupPayID = new ColumnDefinition("groupPayID", "کد پرداخت گروهی", TableName);
        }


        public class ViwOutcomeOveral
        {
            public static string TableName = "viwOutcomeOveral";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition OutcomeOveralTypeID = new ColumnDefinition("outcomeOveralTypeID", "نوع کلی هزینه", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "کد پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک/فیش/حواله", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition PayName = new ColumnDefinition("payName", "هزینه", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
        }

        public class PayType
        {
            public static string TableName = "payType";

            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "کد نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition PayTypeName = new ColumnDefinition("payTypeName", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition PayTypeDescription = new ColumnDefinition("payTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class IncomeTypicalType
        {
            public static string TableName = "incomeTypicalType";

            public static ColumnDefinition IncomeTypicalTypeID = new ColumnDefinition("incomeTypicalTypeID", "کد نوع درآمد استاندارد", TableName);
            public static ColumnDefinition IncomeTypicalTypeName = new ColumnDefinition("incomeTypicalTypeName", "نوع درآمد", TableName);
            public static ColumnDefinition IncomeTypicalTypeDescription = new ColumnDefinition("incomeTypicalTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class IncomeOveralType
        {
            public static string TableName = "incomeOveralType";

            public static ColumnDefinition IncomeOveralTypeID = new ColumnDefinition("incomeOveralTypeID", "کد نوع کلی درآمد", TableName);
            public static ColumnDefinition IncomeOveralTypeName = new ColumnDefinition("incomeOveralTypeName", "نوع کلی درآمد", TableName);
            public static ColumnDefinition IncomeOveralTypeDescription = new ColumnDefinition("incomeOveralTypeDescription", "incomeOveralTypeDescription", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class IncomeTypical
        {
            public static string TableName = "incomeTypical";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد درآمد", TableName);
            public static ColumnDefinition IncomeTypicalTypeID = new ColumnDefinition("incomeTypicalTypeID", "نوع درآمد", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition Tag = new ColumnDefinition("Tag", "شخص مربوطه", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class IncomeSellStuff
        {
            public static string TableName = "incomeSellStuff";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد درآمد", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "بابت", TableName);
            public static ColumnDefinition StuffCount = new ColumnDefinition("stuffCount", "تعداد", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
        }

        public class IncomeTeacher
        {
            public static string TableName = "incomeTeacher";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد دریافت", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "استاد", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }


        public class ViwIncomeOveral
        {
            public static string TableName = "viwIncomeOveral";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد درآمد", TableName);
            public static ColumnDefinition IncomeOveralTypeID = new ColumnDefinition("incomeOveralTypeID", "نوع کلی درآمد", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition PayName = new ColumnDefinition("payName", "درآمد", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
        }

        public class Registration
        {
            public static string TableName = "registration";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "شماره‌ی هنرجویی", TableName);
            public static ColumnDefinition RegistrationDate = new ColumnDefinition("registrationDate", "تاریخ ثبت نام", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition IsBalancedFinalWithStudent = new ColumnDefinition("isBalancedFinalWithStudent", "تسویه حساب هنرجو", TableName);
        }


        //public class ViwTeacherFinancialStatusOld
        //{
        //    public static string TableName = "viwTeacherFinancialStatus";

        //    public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
        //    public static ColumnDefinition ClassName = new ColumnDefinition("className", "نام کلاس", TableName);
        //    public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
        //    public static ColumnDefinition FullName = new ColumnDefinition("fullName", "نام استاد", TableName);
        //    public static ColumnDefinition HeldSessionsValue = new ColumnDefinition("heldSessionsValue", "کلاس‌های تشکیل شده", TableName);
        //    public static ColumnDefinition HavePaidValue = new ColumnDefinition("havePaidValue", "پرداخت شده", TableName);
        //    public static ColumnDefinition MustPayValue = new ColumnDefinition("mustPayValue", "قابل پرداخت", TableName);
        //    public static ColumnDefinition IsSuccessor = new ColumnDefinition("isSuccessor", "استاد جایگزین", TableName);
        //    public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
        //}

        public class ViwClassesPrivate
        {
            public static string TableName = "viwClassesPrivate";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition TeacherFirstName = new ColumnDefinition("teacherFirstName", "نام استاد", TableName);
            public static ColumnDefinition TeacherLastName = new ColumnDefinition("teacherLastName", "نام خانوادگی", TableName);
            public static ColumnDefinition StudentFirstName = new ColumnDefinition("studentFirstName", "نام هنرجو", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "شماره‌ی هنرجو", TableName);
            public static ColumnDefinition StudentLastName = new ColumnDefinition("studentLastName", "نام خانوادگی", TableName);
            public static ColumnDefinition RegistrationDate = new ColumnDefinition("registrationDate", "تاریخ ثبت نام", TableName);
            public static ColumnDefinition MajorName = new ColumnDefinition("majorName", "نام رشته", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "شماره‌ی استاد", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "کد رشته", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
        }

        public class ViwTeacherSchedule
        {
            public static string TableName = "viwTeacherSchedule";

            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام استاد", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition ClassDate = new ColumnDefinition("classDate", "تاریخ کلاس", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "ساعت", TableName);
            public static ColumnDefinition StartHour = new ColumnDefinition("startHour", "startHour", TableName);
            public static ColumnDefinition StartMin = new ColumnDefinition("startMin", "startMin", TableName);
            public static ColumnDefinition FinishHour = new ColumnDefinition("finishHour", "finishHour", TableName);
            public static ColumnDefinition FinishMin = new ColumnDefinition("finishMin", "finishMin", TableName);
            public static ColumnDefinition DayID = new ColumnDefinition("dayID", "کد روز", TableName);
            public static ColumnDefinition DayName = new ColumnDefinition("dayName", "روز", TableName);
            public static ColumnDefinition MajorName = new ColumnDefinition("majorName", "رشته", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "کد رشته", TableName);
        }

        public class ViwClassHoldDetails
        {
            public static string TableName = "viwClassHoldDetails";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition HeldCount = new ColumnDefinition("HeldCount", "تشکیل شده", TableName);
            public static ColumnDefinition WillHoldCount = new ColumnDefinition("WillHoldCount", "باقیمانده", TableName);
            public static ColumnDefinition HeldWithSuccessorTeacherCount = new ColumnDefinition("HeldWithSuccessorTeacherCount", "استاد جایگزین", TableName);
            public static ColumnDefinition SuspendendDueTeacherCount = new ColumnDefinition("SuspendendDueTeacherCount", "غیبت استاد", TableName);
            public static ColumnDefinition SuspendedDueStudentCount = new ColumnDefinition("SuspendedDueStudentCount", "غیبت هنرجو", TableName);
            public static ColumnDefinition SuspendedDueNotificationCount = new ColumnDefinition("SuspendedDueNotificationCount", "عدم تشکیل با اطلاع قبلی", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "کد رشته", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
        }

        public class ObseleteViwStudentFinancialStatus
        {
            public static string TableName = "viwStudentFinancialStatus";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "studentID", TableName);
            public static ColumnDefinition FullName = new ColumnDefinition("fullName", "نام", TableName);
            public static ColumnDefinition RegisterationFee = new ColumnDefinition("registerationFee", "هزینه‌ی ثبت‌نام", TableName);
            public static ColumnDefinition HavePaidValue = new ColumnDefinition("havePaidValue", "مبلغ پرداخت شده", TableName);
            public static ColumnDefinition MustPayValue = new ColumnDefinition("mustPayValue", "مبلغ قابل پرداخت", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
        }

        public class SessionPresence
        {
            public static string TableName = "sessionPresence";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition ClassDate = new ColumnDefinition("classDate", "تاریخ", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "ساعت", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "هنرجو", TableName);
            public static ColumnDefinition PresenceStatusID = new ColumnDefinition("presenceStatusID", "وضعیت حضور غیاب", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class PresenceStatus
        {
            public static string TableName = "presenceStatus";

            public static ColumnDefinition PresenceStatusID = new ColumnDefinition("presenceStatusID", "کد وضعیت حضور غیاب", TableName);
            public static ColumnDefinition PresenceStatusName = new ColumnDefinition("presenceStatusName", "وضعیت حضور غیاب", TableName);
            public static ColumnDefinition PresenceStatusDescription = new ColumnDefinition("presenceStatusDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class IncomeStudent
        {
            public static string TableName = "incomeStudent";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "دانشجو", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نوع پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک/فیش/حواله", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک/فیش/حواله", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class StoreStuff
        {
            public static string TableName = "storeStuff";

            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "کد کالا", TableName);
            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "نوع کالا", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "نام کالا", TableName);
            public static ColumnDefinition BuyDate = new ColumnDefinition("buyDate", "تاریخ خرید", TableName);
            public static ColumnDefinition StuffCount = new ColumnDefinition("stuffCount", "تعداد", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition IsBalanced = new ColumnDefinition("isBalanced", "تسویه حساب شده", TableName);
            public static ColumnDefinition IsSalesPersonAware = new ColumnDefinition("isSalesPersonAware", "فروشنده مطلع است", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition StuffPrice = new ColumnDefinition("stuffPrice", "قیمت", TableName);
        }


        public class StoreShop
        {
            public static string TableName = "storeShop";

            public static ColumnDefinition ShopID = new ColumnDefinition("shopID", "کد فروش", TableName);
            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "نام کالا", TableName);
            public static ColumnDefinition CustomerID = new ColumnDefinition("customerID", "نام خریدار", TableName);
            public static ColumnDefinition CustomerName = new ColumnDefinition("customerName", "نام خریدار", TableName);
            public static ColumnDefinition ShopCount = new ColumnDefinition("shopCount", "تعداد", TableName);
            public static ColumnDefinition ShopDescription = new ColumnDefinition("shopDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition IsManagerAware = new ColumnDefinition("isManagerAware", "مدیر مشاهده کرده", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition ShopDate = new ColumnDefinition("shopDate", "تاریخ فروش", TableName);
        }


        public class StuffType
        {
            public static string TableName = "stuffType";

            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "کد نوع کالا", TableName);
            public static ColumnDefinition StuffTypeName = new ColumnDefinition("stuffTypeName", "نام نوع کالا", TableName);
            public static ColumnDefinition StuffTypeDescription = new ColumnDefinition("stuffTypeDescription", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }

        public class ViwStuffAvailableDetails
        {
            public static string TableName = "viwStuffAvailableDetails";

            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "stuffID", TableName);
            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "stuffTypeID", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "نام کالا", TableName);
            public static ColumnDefinition BuyDate = new ColumnDefinition("buyDate", "تاریخ خرید", TableName);
            public static ColumnDefinition InitCount = new ColumnDefinition("initCount", "تعداد اولیه", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition IsBalanced = new ColumnDefinition("isBalanced", "تسویه حساب", TableName);
            public static ColumnDefinition IsSalesPersonAware = new ColumnDefinition("isSalesPersonAware", "فروشنده دیده", TableName);
            public static ColumnDefinition SoldCount = new ColumnDefinition("soldCount", "فروخته شده", TableName);
            public static ColumnDefinition AvailableCount = new ColumnDefinition("availableCount", "موجود", TableName);
        }

        public class ViwStuffTypeAvailableDetails
        {
            public static string TableName = "viwStuffTypeAvailableDetails";

            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "کد نوع کالا", TableName);
            public static ColumnDefinition StuffTypeName = new ColumnDefinition("stuffTypeName", "نام کالا", TableName);
            public static ColumnDefinition InitCount = new ColumnDefinition("initCount", "تعداد اولیه", TableName);
            public static ColumnDefinition SoldCount = new ColumnDefinition("soldCount", "فروخته شده", TableName);
            public static ColumnDefinition AvailableCount = new ColumnDefinition("availableCount", "موجودی", TableName);
        }

        public class ViwShopSalesPerson
        {
            public static string TableName = "viwShopSalesPerson";

            public static ColumnDefinition ShopID = new ColumnDefinition("shopID", "کد فروش", TableName);
            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "نام کالا", TableName);
            public static ColumnDefinition CustomerName = new ColumnDefinition("customerName", "خریدار", TableName);
            public static ColumnDefinition ShopCount = new ColumnDefinition("shopCount", "تعداد", TableName);
            public static ColumnDefinition ShopDate = new ColumnDefinition("shopDate", "تاریخ فروش", TableName);
            public static ColumnDefinition ShopDescription = new ColumnDefinition("shopDescription", "توضیحات", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضیت فعالیت", TableName);
            public static ColumnDefinition IsManagerAware = new ColumnDefinition("isManagerAware", "مدیر مشاهده کرده", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "کد هنرجو", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "نام کالا", TableName);
            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "نوع کالا", TableName);
            public static ColumnDefinition StuffPrice = new ColumnDefinition("stuffPrice", "قیمت", TableName);
            public static ColumnDefinition PaidAmount = new ColumnDefinition("paidAmount", "مبلغ پرداختی", TableName);
        }

        public class IncomeStoreSell
        {
            public static string TableName = "incomeStoreSell";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition ShopID = new ColumnDefinition("shopID", "کد خرید", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "ملبغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
        }

        public class OutcomeStoreBuy
        {
            public static string TableName = "OutcomeStoreBuy";

            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "کد کالا", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "ملبغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه‌ی پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
        }

        public class ViwStoreSalesHistory
        {
            public static string TableName = "viwStoreSalesHistory";

            public static ColumnDefinition ShopID = new ColumnDefinition("shopID", "کد فروش", TableName);
            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "نام کالا", TableName);
            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "نوع کالا", TableName);
            public static ColumnDefinition StuffName = new ColumnDefinition("stuffName", "نام کالا", TableName);
            public static ColumnDefinition StuffTypeName = new ColumnDefinition("stuffTypeName", "نوع کالا", TableName);
            public static ColumnDefinition CustomerID = new ColumnDefinition("customerID", "کد مشتری", TableName);
            public static ColumnDefinition CustomerName = new ColumnDefinition("customerName", "نام مشتری", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition IsManagerAware = new ColumnDefinition("isManagerAware", "تائید مدیر", TableName);
            public static ColumnDefinition ShopDate = new ColumnDefinition("shopDate", "تاریخ فروش", TableName);
            public static ColumnDefinition ShopCount = new ColumnDefinition("shopCount", "تعداد فروش", TableName);
            public static ColumnDefinition CustomerCount = new ColumnDefinition("customerCount", "تعداد مشتری", TableName);
        }

        public class ViwSalesTracking
        {
            public static string TableName = "viwSalesTracking";

            public static ColumnDefinition IsSale = new ColumnDefinition("isSale", "نوع", TableName);
            public static ColumnDefinition IsSaleText = new ColumnDefinition("isSaleText", "نوع", TableName);
            public static ColumnDefinition ItemName = new ColumnDefinition("itemName", "نام کالا/مشتری", TableName);
            public static ColumnDefinition ItemCount = new ColumnDefinition("itemCount", "تعداد", TableName);
            public static ColumnDefinition ItemDate = new ColumnDefinition("itemDate", "تاریخ", TableName);
            public static ColumnDefinition StuffTypeID = new ColumnDefinition("stuffTypeID", "نوع کالا", TableName);
            public static ColumnDefinition StuffID = new ColumnDefinition("stuffID", "کد کالا", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
        }

        public class ViwEmployeeSalaryDetails
        {
            public static string TableName = "viwEmployeeSalaryDetails";

            public static ColumnDefinition EmployeeID = new ColumnDefinition("employeeID", "کد کارمند", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام کارمند", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition ActivityStatus = new ColumnDefinition("activityStatus", "وضعیت فعالیت", TableName);
            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ حقوق", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره‌ی چک", TableName);
            public static ColumnDefinition DateFrom = new ColumnDefinition("dateFrom", "از تاریخ", TableName);
            public static ColumnDefinition DateTo = new ColumnDefinition("dateTo", "تا تاریخ", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "payTypeID", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "discount", TableName);
        }

        public class SchoolSpecification
        {
            public static string TableName = "schoolSpecification";

            public static ColumnDefinition SchoolID = new ColumnDefinition("schoolID", "کد آموزشگاه", TableName);
            public static ColumnDefinition SchoolName = new ColumnDefinition("schoolName", "نام آموزشگاه", TableName);
            public static ColumnDefinition SchoolLogo = new ColumnDefinition("schoolLogo", "آرم آموزشگاه", TableName);
            public static ColumnDefinition Address = new ColumnDefinition("address", "آدرس", TableName);
            public static ColumnDefinition ManagerFirstName = new ColumnDefinition("managerFirstName", "نام مدیر", TableName);
            public static ColumnDefinition ManagerLastName = new ColumnDefinition("managerLastName", "نام خانوادگی مدیر", TableName);
            public static ColumnDefinition ManagerBirthDate = new ColumnDefinition("managerBirthDate", "تاریخ تولد مدیر", TableName);
            public static ColumnDefinition DegreeLevelID = new ColumnDefinition("degreeLevelID", "مدرک تحصیلی", TableName);
            public static ColumnDefinition ManagerStudeyMajor = new ColumnDefinition("managerStudeyMajor", "رشته‌ی تحصیلی", TableName);
            public static ColumnDefinition JustificationID = new ColumnDefinition("justificationID", "شماره‌ی مجوز", TableName);
            public static ColumnDefinition JustificationName = new ColumnDefinition("justificationName", "مجوز به نام", TableName);
            public static ColumnDefinition FondYear = new ColumnDefinition("fondYear", "تاریخ تاسیس", TableName);
            public static ColumnDefinition EmployeeNumber = new ColumnDefinition("employeeNumber", "تعداد کارمندان", TableName);
            public static ColumnDefinition WorkHour = new ColumnDefinition("workHour", "workHour", TableName);
            public static ColumnDefinition SchoolGrade = new ColumnDefinition("schoolGrade", "schoolGrade", TableName);
            public static ColumnDefinition Province = new ColumnDefinition("province", "استان", TableName);
            public static ColumnDefinition City = new ColumnDefinition("city", "شهر", TableName);
            public static ColumnDefinition Street = new ColumnDefinition("street", "خیابان", TableName);
            public static ColumnDefinition PostalCode = new ColumnDefinition("postalCode", "کد پستی", TableName);
            public static ColumnDefinition Tell = new ColumnDefinition("tell", "تلفن", TableName);
            public static ColumnDefinition Fax = new ColumnDefinition("fax", "فکس", TableName);
            public static ColumnDefinition Mail = new ColumnDefinition("mail", "ایمیل", TableName);
            public static ColumnDefinition BackgroundImage = new ColumnDefinition("backgroundImage", "عکس زمینه", TableName);
            public static ColumnDefinition ReportTitle = new ColumnDefinition("reportTitle", "تیتر گزارش", TableName);
            public static ColumnDefinition ReportLogo = new ColumnDefinition("reportLogo", "آرم گزارش", TableName);
            public static ColumnDefinition ReportAddress = new ColumnDefinition("reportAddress", "آدرس گزارش", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
            public static ColumnDefinition ReportPayFactorFooterDesc = new ColumnDefinition("reportPayFactorFooterDesc", "reportPayFactorFooterDesc", TableName);
        }

        public class Literal
        {
            public static string TableName = "Tablename";

            public static ColumnDefinition LiteralID = new ColumnDefinition("LiteralID", "کد", TableName);
            public static ColumnDefinition LiteralName = new ColumnDefinition("LiteralName", "نام", TableName);
            public static ColumnDefinition LiteralDescription = new ColumnDefinition("LiteralDescription", "توضیحات", TableName);
        }

        public class ViwStudentFinancialDetails
        {
            public static string TableName = "viwStudentFinancialDetails";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "کد هنرجو", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "نام کلاس", TableName);
            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نوع پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition IsIncome = new ColumnDefinition("IsIncome", "نوع", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام هنرجو", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "رشته", TableName);
            public static ColumnDefinition ClassRegisterationDate = new ColumnDefinition("classRegisterationDate", "تاریخ ثبت کلاس", TableName);
            public static ColumnDefinition PayTypeName = new ColumnDefinition("payTypeName", "نحوه پرداخت", TableName);
        }

        public class ViwStudentFinancialStatus
        {
            public static string TableName = "viwStudentFinancialStatus";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "کد هنرجو", TableName);
            public static ColumnDefinition StudentPayedAmount = new ColumnDefinition("studentPayedAmount", "دریافتی هنرجو", TableName);
            public static ColumnDefinition BalancedAmount = new ColumnDefinition("balancedAmount", "مبلغ تسویه حساب", TableName);
            public static ColumnDefinition StudentFinalPay = new ColumnDefinition("studentFinalPay", "دریافت نهایی هنرجو", TableName);
            public static ColumnDefinition StudentMustPay = new ColumnDefinition("studentMustPay", "مانده", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام هنرجو", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "نام کلاس", TableName);
            public static ColumnDefinition ClassRegisterationDate = new ColumnDefinition("classRegisterationDate", "تاریخ ثبت کلاس", TableName);
            public static ColumnDefinition ClassTotalPrice = new ColumnDefinition("classTotalPrice", "شهریه‌ی کلاس", TableName);
            public static ColumnDefinition ReturnMoneyForTeacherAbsentCount = new ColumnDefinition("returnMoneyForTeacherAbsentCount", "تعداد جلسات تودیع شهریه", TableName);
            public static ColumnDefinition ReturnMoneyForTeacherAbsentAmount = new ColumnDefinition("returnMoneyForTeacherAbsentAmount", "هزینه‌ی غیبت استاد", TableName);

            public static ColumnDefinition FinancialStatus = new ColumnDefinition("FinancialStatus", "وضعیت مالی", TableName);


            public static ColumnDefinition FinalClassPrice = new ColumnDefinition("FinalClassPrice", "هزینه‌ی نهایی کلاس", TableName);
        }

        public class ViwStudentSessionStatus
        {
            public static string TableName = "viwStudentSessionStatus";

            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "هنرجو", TableName);
            public static ColumnDefinition StudentAbseneceCount = new ColumnDefinition("studentAbseneceCount", "غیبت هنرجو", TableName);
            public static ColumnDefinition ContinuousAbseneceCount = new ColumnDefinition("continuousAbseneceCount", "غیبت مستمر", TableName);
            public static ColumnDefinition TeacherAbsenceCount = new ColumnDefinition("teacherAbsenceCount", "غیبت استاد", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کلاس", TableName);
            public static ColumnDefinition WillHeldCount = new ColumnDefinition("willHeldCount", "برگزار خواهد شد", TableName);
            public static ColumnDefinition HeldCount = new ColumnDefinition("heldCount", "تشکیل شده", TableName);
            public static ColumnDefinition NotlHeldCount = new ColumnDefinition("notlHeldCount", "تشکیل نشده", TableName);
            public static ColumnDefinition TotalDedicatedSessions = new ColumnDefinition("totalDedicatedSessions", "تخصیص داده شده", TableName);
        }

        public class ViwStudentSessionDetails
        {
            public static string TableName = "viwStudentSessionDetails";

            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition StudentID = new ColumnDefinition("studentID", "هنرجو", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام هنرجو", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition ClassDate = new ColumnDefinition("classDate", "تاریخ ثبت کلاس", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "زمان", TableName);
            public static ColumnDefinition StudentAbsence = new ColumnDefinition("studentAbsence", "غیبت هنرجو", TableName);
            public static ColumnDefinition ContinuousAbsence = new ColumnDefinition("continuousAbsence", "غیبت مستمر", TableName);
            public static ColumnDefinition TeacherAbsence = new ColumnDefinition("teacherAbsence", "غیبت استاد", TableName);
            public static ColumnDefinition SuccessorTeacher = new ColumnDefinition("successorTeacher", "استاد جایگزین", TableName);
            public static ColumnDefinition SessionStatus = new ColumnDefinition("sessionStatus", "وضعیت", TableName);
            public static ColumnDefinition RoomNo = new ColumnDefinition("roomNo", "اتاق تشکیل", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
        }

        public class ViwTeacherFinancialDetails
        {
            public static string TableName = "viwTeacherFinancialDetails";

            public static ColumnDefinition IsSuccessorTeacher = new ColumnDefinition("isSuccessorTeacher", "استاد جایگزین", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition IsIncome = new ColumnDefinition("IsIncome", "نوع پرداخت", TableName);
            public static ColumnDefinition MajorID = new ColumnDefinition("majorID", "رشته", TableName);
            public static ColumnDefinition ClassRegisterationDate = new ColumnDefinition("classRegisterationDate", "تاریخ ثبت کلاس", TableName);
            public static ColumnDefinition PayTypeName = new ColumnDefinition("payTypeName", "نحوه پرداخت", TableName);
            public static ColumnDefinition PayID = new ColumnDefinition("payID", "کد پرداخت", TableName);
            public static ColumnDefinition PayTypeID = new ColumnDefinition("payTypeID", "نحوه پرداخت", TableName);
            public static ColumnDefinition Fee = new ColumnDefinition("fee", "مبلغ", TableName);
            public static ColumnDefinition Discount = new ColumnDefinition("discount", "تخفیف", TableName);
            public static ColumnDefinition PayDate = new ColumnDefinition("payDate", "تاریخ پرداخت", TableName);
            public static ColumnDefinition CheckDate = new ColumnDefinition("checkDate", "تاریخ چک", TableName);
            public static ColumnDefinition CheckNumber = new ColumnDefinition("checkNumber", "شماره چک", TableName);
            public static ColumnDefinition Description = new ColumnDefinition("description", "توضیحات", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام استاد", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
        }

        public class ViwTeacherFinancialStatus
        {
            public static string TableName = "viwTeacherFinancialStatus";

            public static ColumnDefinition IsSuccessorTeacher = new ColumnDefinition("isSuccessorTeacher", "استاد جایگزین", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition ContractValue = new ColumnDefinition("contractValue", "مبلغ قرارداد", TableName);
            public static ColumnDefinition ContractTypeID = new ColumnDefinition("contractTypeID", "نحوه قرارداد", TableName);
            public static ColumnDefinition PaidToTeacher = new ColumnDefinition("paidToTeacher", "پرداخت به استاد", TableName);
            public static ColumnDefinition GotFromTeacherBalance = new ColumnDefinition("gotFromTeacherBalance", "دریافت بابت تسویه", TableName);
            public static ColumnDefinition FinalPaidToTeacher = new ColumnDefinition("finalPaidToTeacher", "پرداخت نهایی", TableName);
            public static ColumnDefinition ClassRegisterationDate = new ColumnDefinition("classRegisterationDate", "تاریخ ثبت کلاس", TableName);
            public static ColumnDefinition ClassTotalPrice = new ColumnDefinition("classTotalPrice", "هزینه‌ کلاس", TableName);
            public static ColumnDefinition ReturnMoneyForTeacherAbsentAmount = new ColumnDefinition("returnMoneyForTeacherAbsentAmount", "هزینه‌ غیبت‌ها", TableName);
            public static ColumnDefinition SchoolPrice = new ColumnDefinition("schoolPrice", "هزینه‌ ثبت نام", TableName);
            public static ColumnDefinition SessionCount = new ColumnDefinition("sessionCount", "تعداد جلسات", TableName);
            public static ColumnDefinition TeacherEachSessionPortion = new ColumnDefinition("teacherEachSessionPortion", "حقوق هر جلسه", TableName);
            public static ColumnDefinition TeacherTotalPortion = new ColumnDefinition("teacherTotalPortion", "سهم استاد", TableName);
            public static ColumnDefinition MustPaySessionCount = new ColumnDefinition("mustPaySessionCount", "جلسات تشکیل شده", TableName);
            public static ColumnDefinition MustPayToTeacherAmount = new ColumnDefinition("mustPayToTeacherAmount", "طلب استاد", TableName);

            public static ColumnDefinition FinancialStatus = new ColumnDefinition("FinancialStatus", "وضعیت مالی", TableName);
            public static ColumnDefinition PayableAmount = new ColumnDefinition("PayableAmount", "پرداخت شود", TableName);
        }

        public class ViwTeacherSessionStatus
        {
            public static string TableName = "viwTeacherSessionStatus";

            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "کد استاد", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition StudentAbseneceCount = new ColumnDefinition("studentAbseneceCount", "غیبت هنرجو", TableName);
            public static ColumnDefinition ContinuousAbseneceCount = new ColumnDefinition("continuousAbseneceCount", "غیبت مستمر", TableName);
            public static ColumnDefinition TeacherAbsenceCount = new ColumnDefinition("teacherAbsenceCount", "غیبت استاد", TableName);
            public static ColumnDefinition WillHeldCount = new ColumnDefinition("willHeldCount", "مانده", TableName);
            public static ColumnDefinition HeldCount = new ColumnDefinition("heldCount", "تشکیل شده", TableName);
            public static ColumnDefinition NotlHeldCount = new ColumnDefinition("notlHeldCount", "تشکیل نشده", TableName);
            public static ColumnDefinition TotalDedicatedSessions = new ColumnDefinition("totalDedicatedSessions", "کل جلسات", TableName);
            public static ColumnDefinition SuccessorTeacherCount = new ColumnDefinition("successorTeacherCount", "استاد جایگزین", TableName);
            public static ColumnDefinition IsSuccessor = new ColumnDefinition("isSuccessor", "ملاحظات", TableName);
        }

        public class ViwTeacherSessionDetails
        {
            public static string TableName = "viwTeacherSessionDetails";

            public static ColumnDefinition IsSuccessor = new ColumnDefinition("isSuccessor", "استاد جایگزین", TableName);
            public static ColumnDefinition ClassID = new ColumnDefinition("classID", "کد کلاس", TableName);
            public static ColumnDefinition ClassName = new ColumnDefinition("className", "کلاس", TableName);
            public static ColumnDefinition ClassDate = new ColumnDefinition("classDate", "تاریخ کلاس", TableName);
            public static ColumnDefinition TimeID = new ColumnDefinition("timeID", "زمان", TableName);
            public static ColumnDefinition TeacherID = new ColumnDefinition("teacherID", "استاد", TableName);
            public static ColumnDefinition StudentAbsence = new ColumnDefinition("studentAbsence", "غیبت هنرجو", TableName);
            public static ColumnDefinition ContinuousAbsence = new ColumnDefinition("continuousAbsence", "غیبت مستمر", TableName);
            public static ColumnDefinition TeacherAbsence = new ColumnDefinition("teacherAbsence", "غیبت استاد", TableName);
            public static ColumnDefinition SuccessorTeacher = new ColumnDefinition("successorTeacher", "استاد جایگزین", TableName);
            public static ColumnDefinition SessionStatus = new ColumnDefinition("sessionStatus", "وضعیت جلسه", TableName);
            public static ColumnDefinition RoomNo = new ColumnDefinition("roomNo", "اتاق تشکیل", TableName);
            public static ColumnDefinition FirstName = new ColumnDefinition("firstName", "نام استاد", TableName);
            public static ColumnDefinition LastName = new ColumnDefinition("lastName", "نام خانوادگی", TableName);
        }

        public class DatabaseSynch
        {
            public static string TableName = "databaseSynch";

            public static ColumnDefinition DbDeviceID = new ColumnDefinition("dbDeviceID", "dbDeviceID", TableName);
            public static ColumnDefinition HerDbAddress = new ColumnDefinition("herDbAddress", "آدرس سرور مقصد", TableName);
            public static ColumnDefinition LastUpdateDate = new ColumnDefinition("lastUpdateDate", "lastUpdateDate", TableName);
            public static ColumnDefinition LastUpdateTime = new ColumnDefinition("lastUpdateTime", "lastUpdateTime", TableName);
            public static ColumnDefinition TargetDeviceNameFarsi = new ColumnDefinition("targetDeviceNameFarsi", "نام سرور", TableName);
            public static ColumnDefinition TargetDeviceNameEnglish = new ColumnDefinition("targetDeviceNameEnglish", "English Name", TableName);
            public static ColumnDefinition LastChangeID = new ColumnDefinition("lastChangeID", "lastChangeID", TableName);
            public static ColumnDefinition LastChangeDate = new ColumnDefinition("lastChangeDate", "lastChangeDate", TableName);
            public static ColumnDefinition LastChangeTime = new ColumnDefinition("lastChangeTime", "lastChangeTime", TableName);
        }




    }
}
