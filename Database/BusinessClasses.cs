using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using FarsiLibrary.Utils;
using DatabaseSchemaNamespace;
using DataAccessNamespace;
using Hengam.Tools;
using Tools;
using DataGridFiller;
using Cloner;
using ComboManager;
using Hengam.Tools.LastChangeManagement;
using System.Linq;

namespace BusinessObjectNamespace
{
    public abstract class BusinessObject
    {
        public abstract bool Update();
        public abstract bool Add();
        public abstract bool Delete();
        public abstract bool Find();
        public static string connectionString = @"Data Source=ST1\SQLEXPRESS;Initial Catalog=Zeitoon;Integrated Security=True";
        public abstract override string ToString();

        protected static int ConvertToInt(string intString)
        {
            return Convert.ToInt32(intString);
        }
    }

    public interface IBusinessObject
    {
        bool Add();
        bool Delete();
        bool Update();

    }

    #region Virtual Business Objects
    class Literal : IBusinessObject, IGridValue
    {
        public static bool HasDescription = false;

        public string LiteralName;
        public string LiteralDescription;
        public int LiteralID;

        static public void SetLiteral(string litTableName, ColumnDefinition litName, ColumnDefinition litID, ColumnDefinition litDesc)
        {
            TableName = litTableName;
            LiteralNameCol = litName;
            LiteralIDCol = litID;
            LiteralDescriptionCol = litDesc;

            if (LiteralDescriptionCol == null) HasDescription = false;
            else HasDescription = true;
        }
        public static string TableName = "";
        public static ColumnDefinition LiteralNameCol;
        public static ColumnDefinition LiteralIDCol;
        public static ColumnDefinition LiteralDescriptionCol;

        public bool Update()
        {
            LiteralDA lda = new LiteralDA(this);
            return lda.Update();
        }
        public bool Delete()
        {
            LiteralDA lda = new LiteralDA(this); ;
            return lda.Delete();
        }
        public bool Add()
        {
            LiteralDA lda = new LiteralDA(this);
            return lda.Add();
        }

        public static List<Literal> List()
        {
            return LiteralDA.List();
        }

        public static void FillDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<Literal> literals = List();
            foreach (Literal literal in literals)
            {
                int i = dgv.Rows.Add();
                FillRowWithLiteral(dgv.Rows[i], literal);
            }
        }

        private static void FillRowWithLiteral(System.Windows.Forms.DataGridViewRow row, Literal literal)
        {
            row.Cells[Literal.LiteralIDCol].Value = literal.LiteralID;
            row.Cells[Literal.LiteralNameCol].Value = literal.LiteralName;
            if (Literal.HasDescription) row.Cells[Literal.LiteralDescriptionCol].Value = literal.LiteralDescription;

            row.Tag = literal;
        }

        #region IGridValue Members

        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == LiteralIDCol.Name)
                    return LiteralID.ToString();
                if (columnDefinition.Name == LiteralNameCol.Name)
                    return LiteralName.ToString();
                if (columnDefinition.Name == LiteralDescriptionCol.Name)
                    return LiteralDescription.ToString();

                if (columnDefinition.Name == DatabaseSchema.Literal.LiteralID.Name)
                    return LiteralID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Literal.LiteralName.Name)
                    return LiteralName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Literal.LiteralDescription.Name)
                    return LiteralDescription.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }

        #endregion

    }

    public class Gender : IComboFillable
    {
        public Gender(bool gVal)
        {
            GenderValue = gVal;
        }
        static public List<Gender> List()
        {
            List<Gender> ans = new List<Gender>();
            ans.Add(new Gender(false));
            ans.Add(new Gender(true));
            return ans;
        }
        public bool GenderValue;
        public override string ToString()
        {
            return (GenderValue ? "مرد" : "زن");
        }
        public static implicit operator int(Gender g)
        {
            return (g.GenderValue ? 1 : 0);
        }

        #region IComboFillable Members

        public string ComboDescription
        {
            get { return ToString(); }
        }

        public string ComboText
        {
            get { return ToString(); }
        }

        #endregion

        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (Gender)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Gender it1, Gender it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.GenderValue == it2.GenderValue;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(Gender it1, Gender it2)
        {
            return !(it1 == it2);
        }
        #endregion


    }
    public class MartialStatus : IComboFillable
    {
        public MartialStatus(bool? mStatus)
        {
            MartialStatusValue = mStatus;
        }
        public MartialStatus(bool mStatus)
        {
            MartialStatusValue = mStatus;
        }
        static public List<MartialStatus> List()
        {
            List<MartialStatus> ans = new List<MartialStatus>();
            ans.Add(new MartialStatus(false));
            ans.Add(new MartialStatus(true));
            return ans;
        }
        public bool? MartialStatusValue;
        public override string ToString()
        {
            if (MartialStatusValue == null) return "";
            return (MartialStatusValue.Value ? "متاهل" : "مجرد");
        }

        #region IComboFillable Members

        public string ComboDescription
        {
            get { return ToString(); }
        }

        public string ComboText
        {
            get { return ToString(); }
        }

        #endregion

        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (MartialStatus)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MartialStatus it1, MartialStatus it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.MartialStatusValue == it2.MartialStatusValue;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(MartialStatus it1, MartialStatus it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    public class SessionStatus : IComboFillable
    {
        public SessionStatus(int mStatus)
        {
            SessionStatusValue = (SessionStatusType)mStatus;
        }

        public SessionStatus(SessionStatusType mStatus)
        {
            SessionStatusValue = mStatus;
        }
        public enum SessionStatusType
        {
            WillHold = 0,
            Held = 1,
            NotHeld = 2,
            HeldByPrint = 3,
            //HeldWithSuccessorTeacher,
            //SuspendedDueTeacherAbsence,
            //SuspendedDueStudentAbsence,
            //SuspendedDueNotification
        }


        static public List<SessionStatus> List()
        {
            List<SessionStatus> ans = new List<SessionStatus>();
            ans.Add(new SessionStatus(SessionStatusType.WillHold));
            ans.Add(new SessionStatus(SessionStatusType.Held));
            ans.Add(new SessionStatus(SessionStatusType.NotHeld));
            ans.Add(new SessionStatus(SessionStatusType.HeldByPrint));
            //ans.Add(new SessionStatus(SessionStatusType.HeldWithSuccessorTeacher));
            //ans.Add(new SessionStatus(SessionStatusType.SuspendedDueNotification));
            //ans.Add(new SessionStatus(SessionStatusType.SuspendedDueStudentAbsence));
            //ans.Add(new SessionStatus(SessionStatusType.SuspendedDueTeacherAbsence));

            return ans;
        }
        public SessionStatusType SessionStatusValue;
        public override string ToString()
        {
            switch (SessionStatusValue)
            {
                case SessionStatusType.Held:
                    return "برگزار شده";

                case SessionStatusType.NotHeld:
                    return "برگزار نشده";

                //case SessionStatusType.SuspendedDueStudentAbsence:
                //    return "غیبت هنرجویان";
                //case SessionStatusType.SuspendedDueTeacherAbsence:
                //    return "غیبت استاد";

                //case SessionStatusType.SuspendedDueNotification:
                //    return "عدم تشکیل به دلیل غیبت مستمر";

                case SessionStatusType.WillHold:
                    return "برگزار خواهد شد";
                case SessionStatusType.HeldByPrint:
                    return "برگزار شده با فیش";
                //case SessionStatusType.HeldWithSuccessorTeacher:
                //    return "استاد جایگزین";
                default:
                    return "";
            }
        }

        #region IComboFillable Members

        public string ComboDescription
        {
            get { return ToString(); }
        }

        public string ComboText
        {
            get { return ToString(); }
        }

        #endregion

        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (SessionStatus)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(SessionStatus it1, SessionStatus it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.SessionStatusValue == it2.SessionStatusValue;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(SessionStatus it1, SessionStatus it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    public class Schedule
    {
        public class ScheduleItem
        {
            public TimeBO Time;
            public DayBO Day;
            public bool IsBlinked;

            public string StartDate { get; set; }
            public string FinishDate { get; set; }
            public string Date
            {
                get { return StartDate; }
                set { StartDate = FinishDate = value; }
            }

            public object Tag;

            public void Set(ClasssessionBO session)
            {
                Time = session.RelTime;
                Day = session.RelDay;
                Date = session.ClassDate;
                IsBlinked = false;

            }

            public override string ToString()
            {
                return Day.ToString() + " " + Time.ToString() + (IsBlinked ? "(" + "یک هفته در میان" + ")" : "");
            }

            public bool HasConflict(ScheduleItem item)
            {
                if (IsBlinked & item.IsBlinked) return false;
                if (string.Compare(StartDate, item.FinishDate) > 0 || string.Compare(FinishDate, item.StartDate) < 0) return false;
                if (Day.DayID != item.Day.DayID) return false;

                int a1 = Time.StartHour * 60 + Time.StartMin;
                int a2 = Time.FinishHour * 60 + Time.FinishMin;

                int b1 = item.Time.StartHour * 60 + item.Time.StartMin;
                int b2 = item.Time.FinishHour * 60 + item.Time.FinishMin;

                int dif1 = Math.Abs(a1 - b2);
                int dif2 = Math.Abs(a2 - b1);

                int l1 = Math.Abs(a2 - a1);
                int l2 = Math.Abs(b2 - b1);

                int length = Math.Max(dif1, dif2);
                int between = Math.Min(dif1, dif2);

                if (length == l1 + l2 + between) return false;

                return true;
            }

            public PersianDate StartTimeToPersianDate()
            {
                PersianDate date = new PersianDate(Date);
                date.Hour = Time.StartHour;
                date.Minute = Time.StartMin;
                return date;
            }

            public PersianDate FinishTimeToPersianDate()
            {
                PersianDate date = new PersianDate(Date);
                date.Hour = Time.FinishHour;
                date.Minute = Time.FinishMin;
                return date;
            }
        }

        public List<ScheduleItem> scheduleItems = new List<ScheduleItem>();

        //public void Add(int TimeID, int DayID, bool isBlinked)
        //{
        //    TimeBO tmpTime = TimeBO.Find(TimeID);
        //    DayBO tmpDay = DayBO.Find(DayID);
        //    ScheduleItem item = new ScheduleItem();

        //    Add(tmpTime, tmpDay, isBlinked);
        //}

        //public void Add(TimeBO time, DayBO day, bool isBlinked)
        //{
        //    ScheduleItem item = new ScheduleItem();
        //    item.Time = time;
        //    item.Day = day;
        //    item.IsBlinked = isBlinked;

        //    scheduleItems.Add(item);
        //}

        public void Add(ScheduleItem item)
        {
            scheduleItems.Add(item);
        }

        public static bool HasConflict(Schedule s1, Schedule s2)
        {
            foreach (ScheduleItem s1Item in s1.scheduleItems)
                foreach (ScheduleItem s2Item in s2.scheduleItems)
                    if (s1Item.HasConflict(s2Item)) return true;

            return false;
        }

        public bool HasConflict(ScheduleItem schedItem)
        {
            foreach (ScheduleItem item in scheduleItems)
                if (item.HasConflict(schedItem)) return true;
            return false;
        }

        public bool SelfConflictTest()
        {
            for (int i = 0; i < scheduleItems.Count; i++)
            {
                for (int j = 0; j < scheduleItems.Count; j++)
                {
                    if (i == j) continue;
                    if (scheduleItems[i].HasConflict(scheduleItems[j])) return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string ans = "";
            foreach (ScheduleItem item in scheduleItems)
                ans += item.ToString() + ", ";

            if (ans == "")
                return "";
            else
                return ans.Trim(' ', ',') + ".";
        }


        public static Schedule GetTeacherFreeTimes(TeacherBO teacher)
        {
            List<TeacherTimeBO> freeTimes = TeacherTimeBO.List(teacher.TeacherID);
            Schedule sched = new Schedule();
            foreach (TeacherTimeBO freeTime in freeTimes)
            {
                //Schedule s = new Schedule();
                ScheduleItem si = new ScheduleItem();
                si.StartDate = freeTime.StartDate;
                si.FinishDate = freeTime.FinishDate;
                si.Day = DayBO.Find(freeTime.DayID);
                si.Time = TimeBO.Find(freeTime.TimeID);
                si.IsBlinked = false;

                sched.Add(si);
            }
            return sched;
        }

        public static Schedule GetTeacherSchedule(TeacherBO teacher)
        {
            List<ViwTeacherScheduleBO> classTimes = ViwTeacherScheduleBO.List(teacher.TeacherID, null, null, null, null, null, null, null, null, null);
            Schedule sched = new Schedule();
            foreach (ViwTeacherScheduleBO classTime in classTimes)
            {
                //Schedule s = new Schedule();
                ScheduleItem si = new ScheduleItem();
                si.Date = classTime.ClassDate;
                si.Day = classTime.RelDay;
                si.Time = classTime.RelTime;
                si.IsBlinked = false;
                si.Tag = classTime.ClassID;

                sched.Add(si);
            }
            return sched;
        }

    }

    #endregion

    #region Business Objects

    ////// Generated by DVD CodeGenerator
    ////public partial class DesktopUsersBO : IBusinessObject, ICloner<DesktopUsersBO>, IComboFillable, IGridValue
    ////{
    ////    #region Variables

    ////    public string Username { get; set; }
    ////    public string Password { get; set; }
    ////    public string LastLoginDate { get; set; }
    ////    public string LastLoginTime { get; set; }
    ////    public string EmployeeID { get; set; }
    ////    public bool CanStudentManager { get; set; }
    ////    public bool CanTimeManager { get; set; }
    ////    public bool CanEmployeeManager { get; set; }
    ////    public bool CanDBSettings { get; set; }
    ////    public bool CanTeacherManager { get; set; }
    ////    public bool CanMajorTeacherManager { get; set; }
    ////    public bool CanGuarantorManager { get; set; }
    ////    public bool CanTeacherTimeManager { get; set; }
    ////    public bool CanClassManager { get; set; }
    ////    public bool CanClassSessionManager { get; set; }
    ////    public bool CanOutcomeManager { get; set; }
    ////    public bool CanIncomeManager { get; set; }
    ////    public bool CanStudentRegisterationManager { get; set; }
    ////    public bool CanOutcomeTeacherClass { get; set; }
    ////    public bool CanStudentBalance { get; set; }
    ////    public bool CanTeacherFinancialStatus { get; set; }
    ////    public bool CanTeacherFinancialSessionDetails { get; set; }
    ////    public bool CanClassManagerPrivate { get; set; }
    ////    public bool CanClassManagerPublic { get; set; }
    ////    public bool CanPresenceManagerPrivate { get; set; }
    ////    public bool CanPresenceManagerPublic { get; set; }
    ////    public bool CanStoreStuffAvailableViewer { get; set; }
    ////    public bool CanStoreStuffTypeManager { get; set; }
    ////    public bool CanStoreStuffBuyManager { get; set; }
    ////    public bool CanStoreStuffSellItemManager { get; set; }
    ////    public bool CanStoreShopHistoryViewer { get; set; }
    ////    public bool CanStoreAffairs { get; set; }
    ////    public bool CanEmployeeSalary { get; set; }
    ////    public bool CanStudentInformationReport { get; set; }
    ////    public bool CanStudentPayForClass { get; set; }
    ////    public bool CanStudentAffairs { get; set; }
    ////    public bool CanActivityManager { get; set; }
    ////    public bool CanStoreStuffSellItem { get; set; }
    ////    public bool CanStoreSalesTracking { get; set; }
    ////    public bool CanSchoolSpecification { get; set; }
    ////    public bool CanDesktopUsers { get; set; }
    ////    public bool CanReportStudentListOfMajor { get; set; }
    ////    public bool CanReportPaysOfTeacherInterval { get; set; }
    ////    public bool CanReportSessionsOfTeacherInterval { get; set; }
    ////    public bool CanReportClassesOfTeacherInterval { get; set; }
    ////    public bool CanReportMinistryReport { get; set; }
    ////    public bool CanReportStudentPayFactor { get; set; }
    ////    public bool CanReportTypicalOutcomeYear { get; set; }
    ////    public bool CanReportIncomeInterval { get; set; }
    ////    public bool CanReportRegisteredStudentsPerEmployee { get; set; }
    ////    public bool CanReportTeacherPayFactor { get; set; }
    ////    public bool CanReportEmployeePayFactor { get; set; }
    ////    public bool CanReportStudentOfPublicClass { get; set; }
    ////    public bool CanComboManager { get; set; }
    ////    public bool CanReportAffairs { get; set; }
    ////    #endregion


    ////    #region Constructors

    ////    public DesktopUsersBO()
    ////    {
    ////        // Nothing to do...
    ////    }

    ////    public DesktopUsersBO(string username)
    ////    {
    ////        this.Username = username;
    ////    }

    ////    // Copy Constructor.
    ////    public DesktopUsersBO(DesktopUsersBO copyDesktopUsersBO)
    ////    {
    ////        this.Username = copyDesktopUsersBO.Username;
    ////        this.Password = copyDesktopUsersBO.Password;
    ////        this.LastLoginDate = copyDesktopUsersBO.LastLoginDate;
    ////        this.LastLoginTime = copyDesktopUsersBO.LastLoginTime;
    ////        this.EmployeeID = copyDesktopUsersBO.EmployeeID;
    ////        this.CanStudentManager = copyDesktopUsersBO.CanStudentManager;
    ////        this.CanTimeManager = copyDesktopUsersBO.CanTimeManager;
    ////        this.CanEmployeeManager = copyDesktopUsersBO.CanEmployeeManager;
    ////        this.CanDBSettings = copyDesktopUsersBO.CanDBSettings;
    ////        this.CanTeacherManager = copyDesktopUsersBO.CanTeacherManager;
    ////        this.CanMajorTeacherManager = copyDesktopUsersBO.CanMajorTeacherManager;
    ////        this.CanGuarantorManager = copyDesktopUsersBO.CanGuarantorManager;
    ////        this.CanTeacherTimeManager = copyDesktopUsersBO.CanTeacherTimeManager;
    ////        this.CanClassManager = copyDesktopUsersBO.CanClassManager;
    ////        this.CanClassSessionManager = copyDesktopUsersBO.CanClassSessionManager;
    ////        this.CanOutcomeManager = copyDesktopUsersBO.CanOutcomeManager;
    ////        this.CanIncomeManager = copyDesktopUsersBO.CanIncomeManager;
    ////        this.CanStudentRegisterationManager = copyDesktopUsersBO.CanStudentRegisterationManager;
    ////        this.CanOutcomeTeacherClass = copyDesktopUsersBO.CanOutcomeTeacherClass;
    ////        this.CanStudentBalance = copyDesktopUsersBO.CanStudentBalance;
    ////        this.CanTeacherFinancialStatus = copyDesktopUsersBO.CanTeacherFinancialStatus;
    ////        this.CanTeacherFinancialSessionDetails = copyDesktopUsersBO.CanTeacherFinancialSessionDetails;
    ////        this.CanClassManagerPrivate = copyDesktopUsersBO.CanClassManagerPrivate;
    ////        this.CanClassManagerPublic = copyDesktopUsersBO.CanClassManagerPublic;
    ////        this.CanPresenceManagerPrivate = copyDesktopUsersBO.CanPresenceManagerPrivate;
    ////        this.CanPresenceManagerPublic = copyDesktopUsersBO.CanPresenceManagerPublic;
    ////        this.CanStoreStuffAvailableViewer = copyDesktopUsersBO.CanStoreStuffAvailableViewer;
    ////        this.CanStoreStuffTypeManager = copyDesktopUsersBO.CanStoreStuffTypeManager;
    ////        this.CanStoreStuffBuyManager = copyDesktopUsersBO.CanStoreStuffBuyManager;
    ////        this.CanStoreStuffSellItemManager = copyDesktopUsersBO.CanStoreStuffSellItemManager;
    ////        this.CanStoreShopHistoryViewer = copyDesktopUsersBO.CanStoreShopHistoryViewer;
    ////        this.CanStoreAffairs = copyDesktopUsersBO.CanStoreAffairs;
    ////        this.CanEmployeeSalary = copyDesktopUsersBO.CanEmployeeSalary;
    ////        this.CanStudentInformationReport = copyDesktopUsersBO.CanStudentInformationReport;
    ////        this.CanStudentPayForClass = copyDesktopUsersBO.CanStudentPayForClass;
    ////        this.CanStudentAffairs = copyDesktopUsersBO.CanStudentAffairs;
    ////        this.CanActivityManager = copyDesktopUsersBO.CanActivityManager;
    ////        this.CanStoreStuffSellItem = copyDesktopUsersBO.CanStoreStuffSellItem;
    ////        this.CanStoreSalesTracking = copyDesktopUsersBO.CanStoreSalesTracking;
    ////        this.CanSchoolSpecification = copyDesktopUsersBO.CanSchoolSpecification;
    ////        this.CanDesktopUsers = copyDesktopUsersBO.CanDesktopUsers;
    ////        this.CanReportStudentListOfMajor = copyDesktopUsersBO.CanReportStudentListOfMajor;
    ////        this.CanReportPaysOfTeacherInterval = copyDesktopUsersBO.CanReportPaysOfTeacherInterval;
    ////        this.CanReportSessionsOfTeacherInterval = copyDesktopUsersBO.CanReportSessionsOfTeacherInterval;
    ////        this.CanReportClassesOfTeacherInterval = copyDesktopUsersBO.CanReportClassesOfTeacherInterval;
    ////        this.CanReportMinistryReport = copyDesktopUsersBO.CanReportMinistryReport;
    ////        this.CanReportStudentPayFactor = copyDesktopUsersBO.CanReportStudentPayFactor;
    ////        this.CanReportTypicalOutcomeYear = copyDesktopUsersBO.CanReportTypicalOutcomeYear;
    ////        this.CanReportIncomeInterval = copyDesktopUsersBO.CanReportIncomeInterval;
    ////        this.CanReportRegisteredStudentsPerEmployee = copyDesktopUsersBO.CanReportRegisteredStudentsPerEmployee;
    ////        this.CanReportTeacherPayFactor = copyDesktopUsersBO.CanReportTeacherPayFactor;
    ////        this.CanReportEmployeePayFactor = copyDesktopUsersBO.CanReportEmployeePayFactor;
    ////        this.CanReportStudentOfPublicClass = copyDesktopUsersBO.CanReportStudentOfPublicClass;
    ////        this.CanComboManager = copyDesktopUsersBO.CanComboManager;
    ////        this.CanReportAffairs = copyDesktopUsersBO.CanReportAffairs;
    ////    }
    ////    #endregion


    ////    #region Methods (IBusinessObject)

    ////    public bool Add()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Add();
    ////    }

    ////    public bool Delete()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Delete();
    ////    }

    ////    public bool Update()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Update();
    ////    }

    ////    public static List<DesktopUsersBO> List()
    ////    {
    ////        return DesktopUsersDA.List();
    ////    }
    ////    public static List<DesktopUsersBO> List(string username, string password)
    ////    {
    ////        return DesktopUsersDA.List(username, password);
    ////    }

    ////    public static DesktopUsersBO Find(string username)
    ////    {
    ////        return DesktopUsersDA.Find(username);
    ////    }
    ////    #endregion


    ////    #region Interfaces
    ////    #region IGridValue Members
    ////    public string GetGridValue(ColumnDefinition columnDefinition)
    ////    {
    ////        try
    ////        {
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Username.Name)
    ////                return Username.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Password.Name)
    ////                return Password.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginDate.Name)
    ////                return LastLoginDate.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginTime.Name)
    ////                return LastLoginTime.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.EmployeeID.Name)
    ////                return EmployeeID.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentManager.Name)
    ////                return CanStudentManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTimeManager.Name)
    ////                return CanTimeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeManager.Name)
    ////                return CanEmployeeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDBSettings.Name)
    ////                return CanDBSettings.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherManager.Name)
    ////                return CanTeacherManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanMajorTeacherManager.Name)
    ////                return CanMajorTeacherManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanGuarantorManager.Name)
    ////                return CanGuarantorManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherTimeManager.Name)
    ////                return CanTeacherTimeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManager.Name)
    ////                return CanClassManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionManager.Name)
    ////                return CanClassSessionManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeManager.Name)
    ////                return CanOutcomeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanIncomeManager.Name)
    ////                return CanIncomeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentRegisterationManager.Name)
    ////                return CanStudentRegisterationManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeTeacherClass.Name)
    ////                return CanOutcomeTeacherClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeStudentClass.Name)
    ////                return CanStudentBalance.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialDetails.Name)
    ////                return CanTeacherFinancialStatus.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialSessionDetails.Name)
    ////                return CanTeacherFinancialSessionDetails.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPrivate.Name)
    ////                return CanClassManagerPrivate.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPublic.Name)
    ////                return CanClassManagerPublic.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanPresenceManagerPrivate.Name)
    ////                return CanPresenceManagerPrivate.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanPresenceManagerPublic.Name)
    ////                return CanPresenceManagerPublic.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffAvailableViewer.Name)
    ////                return CanStoreStuffAvailableViewer.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffTypeManager.Name)
    ////                return CanStoreStuffTypeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffBuyManager.Name)
    ////                return CanStoreStuffBuyManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItemManager.Name)
    ////                return CanStoreStuffSellItemManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreShopHistoryViewer.Name)
    ////                return CanStoreShopHistoryViewer.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreAffairs.Name)
    ////                return CanStoreAffairs.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeSalary.Name)
    ////                return CanEmployeeSalary.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentInformationReport.Name)
    ////                return CanStudentInformationReport.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentPayForClass.Name)
    ////                return CanStudentPayForClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentAffairs.Name)
    ////                return CanStudentAffairs.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanActivityManager.Name)
    ////                return CanActivityManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItem.Name)
    ////                return CanStoreStuffSellItem.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreSalesTracking.Name)
    ////                return CanStoreSalesTracking.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanSchoolSpecification.Name)
    ////                return CanSchoolSpecification.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDesktopUsers.Name)
    ////                return CanDesktopUsers.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentListOfMajor.Name)
    ////                return CanReportStudentListOfMajor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportPaysOfTeacherInterval.Name)
    ////                return CanReportPaysOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportSessionsOfTeacherInterval.Name)
    ////                return CanReportSessionsOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportClassesOfTeacherInterval.Name)
    ////                return CanReportClassesOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportMinistryReport.Name)
    ////                return CanReportMinistryReport.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentPayFactor.Name)
    ////                return CanReportStudentPayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTypicalOutcomeYear.Name)
    ////                return CanReportTypicalOutcomeYear.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportIncomeInterval.Name)
    ////                return CanReportIncomeInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportRegisteredStudentsPerEmployee.Name)
    ////                return CanReportRegisteredStudentsPerEmployee.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTeacherPayFactor.Name)
    ////                return CanReportTeacherPayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportEmployeePayFactor.Name)
    ////                return CanReportEmployeePayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentOfPublicClass.Name)
    ////                return CanReportStudentOfPublicClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanComboManager.Name)
    ////                return CanComboManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportAffairs.Name)
    ////                return CanReportAffairs.ToString();
    ////        }
    ////        catch (NullReferenceException) { }
    ////        return "";
    ////    }
    ////    #endregion
    ////    #region IComboFillable
    ////    public string ComboText
    ////    {
    ////        get { return Username; }
    ////    }

    ////    public string ComboDescription
    ////    {
    ////        get { return Username; }
    ////    }
    ////    #endregion
    ////    #region ICloner<DesktopUsersBO> Members
    ////    public DesktopUsersBO Clone()
    ////    {
    ////        return new DesktopUsersBO(this);
    ////    }
    ////    #endregion
    ////    #endregion


    ////    #region Operators
    ////    public override bool Equals(object obj)
    ////    {
    ////        if (obj == null || GetType() != obj.GetType())
    ////            return false;
    ////        return this == (DesktopUsersBO)obj;
    ////    }

    ////    public override int GetHashCode()
    ////    {
    ////        return base.GetHashCode();
    ////    }

    ////    public static bool operator ==(DesktopUsersBO it1, DesktopUsersBO it2)
    ////    {
    ////        bool ans = false;
    ////        if ((object)it1 == null && (object)it2 == null)
    ////            return true;
    ////        try
    ////        {
    ////            ans = true && it1.Username == it2.Username;
    ////        }
    ////        catch (Exception) { }
    ////        return ans;
    ////    }

    ////    public static bool operator !=(DesktopUsersBO it1, DesktopUsersBO it2)
    ////    {
    ////        return !(it1 == it2);
    ////    }
    ////    #endregion
    ////}
    ////// Generated by DVD CodeGenerator
    ////public partial class DesktopUsersBO : IBusinessObject, ICloner<DesktopUsersBO>, IGridValue
    ////{
    ////    #region Variables

    ////    public string Username { get; set; }
    ////    public string Password { get; set; }
    ////    public string LastLoginDate { get; set; }
    ////    public string LastLoginTime { get; set; }
    ////    public string EmployeeID { get; set; }
    ////    public bool CanStudentManager { get; set; }
    ////    public bool CanStudentRegisterationManager { get; set; }
    ////    public bool CanStudentInformationReport { get; set; }
    ////    public bool CanStudentPayForClass { get; set; }
    ////    public bool CanStudentSessionDetails { get; set; }
    ////    public bool CanStudentFinancialDetails { get; set; }
    ////    public bool CanStudentFinancialStatus { get; set; }
    ////    public bool CanStudentClassBalance { get; set; }
    ////    public bool CanStudentAffairs { get; set; }
    ////    public bool CanTeacherFinancialStatus { get; set; }
    ////    public bool CanTeacherFinancialDetails { get; set; }
    ////    public bool CanTeacherSessionDetails { get; set; }
    ////    public bool CanTeacherManager { get; set; }
    ////    public bool CanMajorTeacherManager { get; set; }
    ////    public bool CanTeacherClassBalance { get; set; }
    ////    public bool CanTeacherPayForClass { get; set; }
    ////    public bool CanTeacherTimeSelector { get; set; }
    ////    public bool CanClassManagerPrivate { get; set; }
    ////    public bool CanClassManagerPublic { get; set; }
    ////    public bool CanClassDailyStatus { get; set; }
    ////    public bool CanPresenceManager { get; set; }
    ////    public bool CanTimeManager { get; set; }
    ////    public bool CanEmployeeManager { get; set; }
    ////    public bool CanEmployeeSalary { get; set; }
    ////    public bool CanComboManager { get; set; }
    ////    public bool CanActivityManager { get; set; }
    ////    public bool CanDBSettings { get; set; }
    ////    public bool CanGuarantorManager { get; set; }
    ////    public bool CanSchoolSpecification { get; set; }
    ////    public bool CanDesktopUsers { get; set; }
    ////    public bool CanOutcomeManager { get; set; }
    ////    public bool CanIncomeManager { get; set; }
    ////    public bool CanStoreStuffAvailableViewer { get; set; }
    ////    public bool CanStoreStuffTypeManager { get; set; }
    ////    public bool CanStoreStuffBuyManager { get; set; }
    ////    public bool CanStoreStuffSellItemManager { get; set; }
    ////    public bool CanStoreShopHistoryViewer { get; set; }
    ////    public bool CanStoreAffairs { get; set; }
    ////    public bool CanStoreStuffSellItem { get; set; }
    ////    public bool CanStoreSalesTracking { get; set; }
    ////    public bool CanReportStudentListOfMajor { get; set; }
    ////    public bool CanReportPaysOfTeacherInterval { get; set; }
    ////    public bool CanReportSessionsOfTeacherInterval { get; set; }
    ////    public bool CanReportClassesOfTeacherInterval { get; set; }
    ////    public bool CanReportMinistryReport { get; set; }
    ////    public bool CanReportStudentPayFactor { get; set; }
    ////    public bool CanReportTypicalOutcomeYear { get; set; }
    ////    public bool CanReportIncomeInterval { get; set; }
    ////    public bool CanReportRegisteredStudentsPerEmployee { get; set; }
    ////    public bool CanReportTeacherPayFactor { get; set; }
    ////    public bool CanReportEmployeePayFactor { get; set; }
    ////    public bool CanReportStudentOfPublicClass { get; set; }
    ////    public bool CanReportAffairs { get; set; }
    ////    public bool CanClassSessionStatusSetter { get; set; }
    ////    public bool CanClassSessionScheduleSetter { get; set; }
    ////    #endregion


    ////    #region Constructors

    ////    public DesktopUsersBO()
    ////    {
    ////        // Nothing to do...
    ////    }

    ////    public DesktopUsersBO(string username)
    ////    {
    ////        this.Username = username;
    ////    }

    ////    // Copy Constructor.
    ////    public DesktopUsersBO(DesktopUsersBO copyDesktopUsersBO)
    ////    {
    ////        this.Username = copyDesktopUsersBO.Username;
    ////        this.Password = copyDesktopUsersBO.Password;
    ////        this.LastLoginDate = copyDesktopUsersBO.LastLoginDate;
    ////        this.LastLoginTime = copyDesktopUsersBO.LastLoginTime;
    ////        this.EmployeeID = copyDesktopUsersBO.EmployeeID;
    ////        this.CanStudentManager = copyDesktopUsersBO.CanStudentManager;
    ////        this.CanStudentRegisterationManager = copyDesktopUsersBO.CanStudentRegisterationManager;
    ////        this.CanStudentInformationReport = copyDesktopUsersBO.CanStudentInformationReport;
    ////        this.CanStudentPayForClass = copyDesktopUsersBO.CanStudentPayForClass;
    ////        this.CanStudentSessionDetails = copyDesktopUsersBO.CanStudentSessionDetails;
    ////        this.CanStudentFinancialDetails = copyDesktopUsersBO.CanStudentFinancialDetails;
    ////        this.CanStudentFinancialStatus = copyDesktopUsersBO.CanStudentFinancialStatus;
    ////        this.CanStudentClassBalance = copyDesktopUsersBO.CanStudentClassBalance;
    ////        this.CanStudentAffairs = copyDesktopUsersBO.CanStudentAffairs;
    ////        this.CanTeacherFinancialStatus = copyDesktopUsersBO.CanTeacherFinancialStatus;
    ////        this.CanTeacherFinancialDetails = copyDesktopUsersBO.CanTeacherFinancialDetails;
    ////        this.CanTeacherSessionDetails = copyDesktopUsersBO.CanTeacherSessionDetails;
    ////        this.CanTeacherManager = copyDesktopUsersBO.CanTeacherManager;
    ////        this.CanMajorTeacherManager = copyDesktopUsersBO.CanMajorTeacherManager;
    ////        this.CanTeacherClassBalance = copyDesktopUsersBO.CanTeacherClassBalance;
    ////        this.CanTeacherPayForClass = copyDesktopUsersBO.CanTeacherPayForClass;
    ////        this.CanTeacherTimeSelector = copyDesktopUsersBO.CanTeacherTimeSelector;
    ////        this.CanClassManagerPrivate = copyDesktopUsersBO.CanClassManagerPrivate;
    ////        this.CanClassManagerPublic = copyDesktopUsersBO.CanClassManagerPublic;
    ////        this.CanClassDailyStatus = copyDesktopUsersBO.CanClassDailyStatus;
    ////        this.CanPresenceManager = copyDesktopUsersBO.CanPresenceManager;
    ////        this.CanTimeManager = copyDesktopUsersBO.CanTimeManager;
    ////        this.CanEmployeeManager = copyDesktopUsersBO.CanEmployeeManager;
    ////        this.CanEmployeeSalary = copyDesktopUsersBO.CanEmployeeSalary;
    ////        this.CanComboManager = copyDesktopUsersBO.CanComboManager;
    ////        this.CanActivityManager = copyDesktopUsersBO.CanActivityManager;
    ////        this.CanDBSettings = copyDesktopUsersBO.CanDBSettings;
    ////        this.CanGuarantorManager = copyDesktopUsersBO.CanGuarantorManager;
    ////        this.CanSchoolSpecification = copyDesktopUsersBO.CanSchoolSpecification;
    ////        this.CanDesktopUsers = copyDesktopUsersBO.CanDesktopUsers;
    ////        this.CanOutcomeManager = copyDesktopUsersBO.CanOutcomeManager;
    ////        this.CanIncomeManager = copyDesktopUsersBO.CanIncomeManager;
    ////        this.CanStoreStuffAvailableViewer = copyDesktopUsersBO.CanStoreStuffAvailableViewer;
    ////        this.CanStoreStuffTypeManager = copyDesktopUsersBO.CanStoreStuffTypeManager;
    ////        this.CanStoreStuffBuyManager = copyDesktopUsersBO.CanStoreStuffBuyManager;
    ////        this.CanStoreStuffSellItemManager = copyDesktopUsersBO.CanStoreStuffSellItemManager;
    ////        this.CanStoreShopHistoryViewer = copyDesktopUsersBO.CanStoreShopHistoryViewer;
    ////        this.CanStoreAffairs = copyDesktopUsersBO.CanStoreAffairs;
    ////        this.CanStoreStuffSellItem = copyDesktopUsersBO.CanStoreStuffSellItem;
    ////        this.CanStoreSalesTracking = copyDesktopUsersBO.CanStoreSalesTracking;
    ////        this.CanReportStudentListOfMajor = copyDesktopUsersBO.CanReportStudentListOfMajor;
    ////        this.CanReportPaysOfTeacherInterval = copyDesktopUsersBO.CanReportPaysOfTeacherInterval;
    ////        this.CanReportSessionsOfTeacherInterval = copyDesktopUsersBO.CanReportSessionsOfTeacherInterval;
    ////        this.CanReportClassesOfTeacherInterval = copyDesktopUsersBO.CanReportClassesOfTeacherInterval;
    ////        this.CanReportMinistryReport = copyDesktopUsersBO.CanReportMinistryReport;
    ////        this.CanReportStudentPayFactor = copyDesktopUsersBO.CanReportStudentPayFactor;
    ////        this.CanReportTypicalOutcomeYear = copyDesktopUsersBO.CanReportTypicalOutcomeYear;
    ////        this.CanReportIncomeInterval = copyDesktopUsersBO.CanReportIncomeInterval;
    ////        this.CanReportRegisteredStudentsPerEmployee = copyDesktopUsersBO.CanReportRegisteredStudentsPerEmployee;
    ////        this.CanReportTeacherPayFactor = copyDesktopUsersBO.CanReportTeacherPayFactor;
    ////        this.CanReportEmployeePayFactor = copyDesktopUsersBO.CanReportEmployeePayFactor;
    ////        this.CanReportStudentOfPublicClass = copyDesktopUsersBO.CanReportStudentOfPublicClass;
    ////        this.CanReportAffairs = copyDesktopUsersBO.CanReportAffairs;
    ////        this.CanClassSessionStatusSetter = copyDesktopUsersBO.CanClassSessionStatusSetter;
    ////        this.CanClassSessionScheduleSetter = copyDesktopUsersBO.CanClassSessionScheduleSetter;
    ////    }
    ////    #endregion


    ////    #region Methods (IBusinessObject)

    ////    public bool Add()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Add();
    ////    }

    ////    public bool Delete()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Delete();
    ////    }

    ////    public bool Update()
    ////    {
    ////        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    ////        return tmpDesktopUsersDA.Update();
    ////    }

    ////    public static List<DesktopUsersBO> List()
    ////    {
    ////        return DesktopUsersDA.List();
    ////    }
    ////    public static List<DesktopUsersBO> List(string username, string password)
    ////    {
    ////        return DesktopUsersDA.List(username, password);
    ////    }

    ////    public static DesktopUsersBO Find(string username)
    ////    {
    ////        return DesktopUsersDA.Find(username);
    ////    }
    ////    #endregion


    ////    #region Interfaces
    ////    #region IGridValue Members
    ////    public string GetGridValue(ColumnDefinition columnDefinition)
    ////    {
    ////        try
    ////        {
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Username.Name)
    ////                return Username.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Password.Name)
    ////                return Password.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginDate.Name)
    ////                return LastLoginDate.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginTime.Name)
    ////                return LastLoginTime.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.EmployeeID.Name)
    ////                return RelEmployee.FullName;
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentManager.Name)
    ////                return CanStudentManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentRegisterationManager.Name)
    ////                return CanStudentRegisterationManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentInformationReport.Name)
    ////                return CanStudentInformationReport.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentPayForClass.Name)
    ////                return CanStudentPayForClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentSessionDetails.Name)
    ////                return CanStudentSessionDetails.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialDetails.Name)
    ////                return CanStudentFinancialDetails.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialStatus.Name)
    ////                return CanStudentFinancialStatus.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentClassBalance.Name)
    ////                return CanStudentClassBalance.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentAffairs.Name)
    ////                return CanStudentAffairs.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialStatus.Name)
    ////                return CanTeacherFinancialStatus.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialDetails.Name)
    ////                return CanTeacherFinancialDetails.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherSessionDetails.Name)
    ////                return CanTeacherSessionDetails.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherManager.Name)
    ////                return CanTeacherManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanMajorTeacherManager.Name)
    ////                return CanMajorTeacherManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherClassBalance.Name)
    ////                return CanTeacherClassBalance.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherPayForClass.Name)
    ////                return CanTeacherPayForClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherTimeSelector.Name)
    ////                return CanTeacherTimeSelector.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPrivate.Name)
    ////                return CanClassManagerPrivate.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPublic.Name)
    ////                return CanClassManagerPublic.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassDailyStatus.Name)
    ////                return CanClassDailyStatus.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanPresenceManager.Name)
    ////                return CanPresenceManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTimeManager.Name)
    ////                return CanTimeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeManager.Name)
    ////                return CanEmployeeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeSalary.Name)
    ////                return CanEmployeeSalary.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanComboManager.Name)
    ////                return CanComboManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanActivityManager.Name)
    ////                return CanActivityManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDBSettings.Name)
    ////                return CanDBSettings.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanGuarantorManager.Name)
    ////                return CanGuarantorManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanSchoolSpecification.Name)
    ////                return CanSchoolSpecification.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDesktopUsers.Name)
    ////                return CanDesktopUsers.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeManager.Name)
    ////                return CanOutcomeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanIncomeManager.Name)
    ////                return CanIncomeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffAvailableViewer.Name)
    ////                return CanStoreStuffAvailableViewer.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffTypeManager.Name)
    ////                return CanStoreStuffTypeManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffBuyManager.Name)
    ////                return CanStoreStuffBuyManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItemManager.Name)
    ////                return CanStoreStuffSellItemManager.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreShopHistoryViewer.Name)
    ////                return CanStoreShopHistoryViewer.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreAffairs.Name)
    ////                return CanStoreAffairs.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItem.Name)
    ////                return CanStoreStuffSellItem.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreSalesTracking.Name)
    ////                return CanStoreSalesTracking.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentListOfMajor.Name)
    ////                return CanReportStudentListOfMajor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportPaysOfTeacherInterval.Name)
    ////                return CanReportPaysOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportSessionsOfTeacherInterval.Name)
    ////                return CanReportSessionsOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportClassesOfTeacherInterval.Name)
    ////                return CanReportClassesOfTeacherInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportMinistryReport.Name)
    ////                return CanReportMinistryReport.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentPayFactor.Name)
    ////                return CanReportStudentPayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTypicalOutcomeYear.Name)
    ////                return CanReportTypicalOutcomeYear.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportIncomeInterval.Name)
    ////                return CanReportIncomeInterval.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportRegisteredStudentsPerEmployee.Name)
    ////                return CanReportRegisteredStudentsPerEmployee.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTeacherPayFactor.Name)
    ////                return CanReportTeacherPayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportEmployeePayFactor.Name)
    ////                return CanReportEmployeePayFactor.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentOfPublicClass.Name)
    ////                return CanReportStudentOfPublicClass.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportAffairs.Name)
    ////                return CanReportAffairs.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionStatusSetter.Name)
    ////                return CanClassSessionStatusSetter.ToString();
    ////            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionScheduleSetter.Name)
    ////                return CanClassSessionScheduleSetter.ToString();
    ////        }
    ////        catch (NullReferenceException) { }
    ////        return "";
    ////    }
    ////    #endregion
    ////    #region ICloner<DesktopUsersBO> Members
    ////    public DesktopUsersBO Clone()
    ////    {
    ////        return new DesktopUsersBO(this);
    ////    }
    ////    #endregion
    ////    #endregion


    ////    #region Operators
    ////    public override bool Equals(object obj)
    ////    {
    ////        if (obj == null || GetType() != obj.GetType())
    ////            return false;
    ////        return this == (DesktopUsersBO)obj;
    ////    }

    ////    public override int GetHashCode()
    ////    {
    ////        return base.GetHashCode();
    ////    }

    ////    public static bool operator ==(DesktopUsersBO it1, DesktopUsersBO it2)
    ////    {
    ////        bool ans = false;
    ////        if ((object)it1 == null && (object)it2 == null)
    ////            return true;
    ////        try
    ////        {
    ////            ans = true && it1.Username == it2.Username;
    ////        }
    ////        catch (Exception) { }
    ////        return ans;
    ////    }

    ////    public static bool operator !=(DesktopUsersBO it1, DesktopUsersBO it2)
    ////    {
    ////        return !(it1 == it2);
    ////    }
    ////    #endregion
    ////}

    //// Generated by DVD CodeGenerator
    //public partial class DesktopUsersBO : IBusinessObject, ICloner<DesktopUsersBO>, IGridValue
    //{
    //    #region Variables

    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public string LastLoginDate { get; set; }
    //    public string LastLoginTime { get; set; }
    //    public string EmployeeID { get; set; }
    //    public bool CanStudentManager { get; set; }
    //    public bool CanStudentRegisterationManager { get; set; }
    //    public bool CanStudentInformationReport { get; set; }
    //    public bool CanStudentPayForClass { get; set; }
    //    public bool CanStudentSessionDetails { get; set; }
    //    public bool CanStudentFinancialDetails { get; set; }
    //    public bool CanStudentFinancialStatus { get; set; }
    //    public bool CanStudentClassBalance { get; set; }
    //    public bool CanStudentAffairs { get; set; }
    //    public bool CanTeacherFinancialStatus { get; set; }
    //    public bool CanTeacherFinancialDetails { get; set; }
    //    public bool CanTeacherSessionDetails { get; set; }
    //    public bool CanTeacherManager { get; set; }
    //    public bool CanMajorTeacherManager { get; set; }
    //    public bool CanTeacherClassBalance { get; set; }
    //    public bool CanTeacherPayForClass { get; set; }
    //    public bool CanTeacherTimeSelector { get; set; }
    //    public bool CanClassSessionStatusSetter { get; set; }
    //    public bool CanClassSessionScheduleSetter { get; set; }
    //    public bool CanClassManagerPrivate { get; set; }
    //    public bool CanClassManagerPublic { get; set; }
    //    public bool CanClassDailyStatus { get; set; }
    //    public bool CanPresenceManager { get; set; }
    //    public bool CanTimeManager { get; set; }
    //    public bool CanEmployeeManager { get; set; }
    //    public bool CanEmployeeSalary { get; set; }
    //    public bool CanComboManager { get; set; }
    //    public bool CanActivityManager { get; set; }
    //    public bool CanDBSettings { get; set; }
    //    public bool CanGuarantorManager { get; set; }
    //    public bool CanSchoolSpecification { get; set; }
    //    public bool CanDesktopUsers { get; set; }
    //    public bool CanOutcomeManager { get; set; }
    //    public bool CanIncomeManager { get; set; }
    //    public bool CanStoreStuffAvailableViewer { get; set; }
    //    public bool CanStoreStuffTypeManager { get; set; }
    //    public bool CanStoreStuffBuyManager { get; set; }
    //    public bool CanStoreStuffSellItemManager { get; set; }
    //    public bool CanStoreShopHistoryViewer { get; set; }
    //    public bool CanStoreAffairs { get; set; }
    //    public bool CanStoreStuffSellItem { get; set; }
    //    public bool CanStoreSalesTracking { get; set; }
    //    public bool CanReportStudentListOfMajor { get; set; }
    //    public bool CanReportPaysOfTeacherInterval { get; set; }
    //    public bool CanReportSessionsOfTeacherInterval { get; set; }
    //    public bool CanReportClassesOfTeacherInterval { get; set; }
    //    public bool CanReportMinistryReport { get; set; }
    //    public bool CanReportStudentPayFactor { get; set; }
    //    public bool CanReportTypicalOutcomeYear { get; set; }
    //    public bool CanReportIncomeInterval { get; set; }
    //    public bool CanReportRegisteredStudentsPerEmployee { get; set; }
    //    public bool CanReportTeacherPayFactor { get; set; }
    //    public bool CanReportEmployeePayFactor { get; set; }
    //    public bool CanReportStudentOfPublicClass { get; set; }
    //    public bool CanReportAffairs { get; set; }
    //    #endregion


    //    #region Constructors

    //    public DesktopUsersBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public DesktopUsersBO(string username)
    //    {
    //        this.Username = username;
    //    }

    //    // Copy Constructor.
    //    public DesktopUsersBO(DesktopUsersBO copyDesktopUsersBO)
    //    {
    //        this.Username = copyDesktopUsersBO.Username;
    //        this.Password = copyDesktopUsersBO.Password;
    //        this.LastLoginDate = copyDesktopUsersBO.LastLoginDate;
    //        this.LastLoginTime = copyDesktopUsersBO.LastLoginTime;
    //        this.EmployeeID = copyDesktopUsersBO.EmployeeID;
    //        this.CanStudentManager = copyDesktopUsersBO.CanStudentManager;
    //        this.CanStudentRegisterationManager = copyDesktopUsersBO.CanStudentRegisterationManager;
    //        this.CanStudentInformationReport = copyDesktopUsersBO.CanStudentInformationReport;
    //        this.CanStudentPayForClass = copyDesktopUsersBO.CanStudentPayForClass;
    //        this.CanStudentSessionDetails = copyDesktopUsersBO.CanStudentSessionDetails;
    //        this.CanStudentFinancialDetails = copyDesktopUsersBO.CanStudentFinancialDetails;
    //        this.CanStudentFinancialStatus = copyDesktopUsersBO.CanStudentFinancialStatus;
    //        this.CanStudentClassBalance = copyDesktopUsersBO.CanStudentClassBalance;
    //        this.CanStudentAffairs = copyDesktopUsersBO.CanStudentAffairs;
    //        this.CanTeacherFinancialStatus = copyDesktopUsersBO.CanTeacherFinancialStatus;
    //        this.CanTeacherFinancialDetails = copyDesktopUsersBO.CanTeacherFinancialDetails;
    //        this.CanTeacherSessionDetails = copyDesktopUsersBO.CanTeacherSessionDetails;
    //        this.CanTeacherManager = copyDesktopUsersBO.CanTeacherManager;
    //        this.CanMajorTeacherManager = copyDesktopUsersBO.CanMajorTeacherManager;
    //        this.CanTeacherClassBalance = copyDesktopUsersBO.CanTeacherClassBalance;
    //        this.CanTeacherPayForClass = copyDesktopUsersBO.CanTeacherPayForClass;
    //        this.CanTeacherTimeSelector = copyDesktopUsersBO.CanTeacherTimeSelector;
    //        this.CanClassSessionStatusSetter = copyDesktopUsersBO.CanClassSessionStatusSetter;
    //        this.CanClassSessionScheduleSetter = copyDesktopUsersBO.CanClassSessionScheduleSetter;
    //        this.CanClassManagerPrivate = copyDesktopUsersBO.CanClassManagerPrivate;
    //        this.CanClassManagerPublic = copyDesktopUsersBO.CanClassManagerPublic;
    //        this.CanClassDailyStatus = copyDesktopUsersBO.CanClassDailyStatus;
    //        this.CanPresenceManager = copyDesktopUsersBO.CanPresenceManager;
    //        this.CanTimeManager = copyDesktopUsersBO.CanTimeManager;
    //        this.CanEmployeeManager = copyDesktopUsersBO.CanEmployeeManager;
    //        this.CanEmployeeSalary = copyDesktopUsersBO.CanEmployeeSalary;
    //        this.CanComboManager = copyDesktopUsersBO.CanComboManager;
    //        this.CanActivityManager = copyDesktopUsersBO.CanActivityManager;
    //        this.CanDBSettings = copyDesktopUsersBO.CanDBSettings;
    //        this.CanGuarantorManager = copyDesktopUsersBO.CanGuarantorManager;
    //        this.CanSchoolSpecification = copyDesktopUsersBO.CanSchoolSpecification;
    //        this.CanDesktopUsers = copyDesktopUsersBO.CanDesktopUsers;
    //        this.CanOutcomeManager = copyDesktopUsersBO.CanOutcomeManager;
    //        this.CanIncomeManager = copyDesktopUsersBO.CanIncomeManager;
    //        this.CanStoreStuffAvailableViewer = copyDesktopUsersBO.CanStoreStuffAvailableViewer;
    //        this.CanStoreStuffTypeManager = copyDesktopUsersBO.CanStoreStuffTypeManager;
    //        this.CanStoreStuffBuyManager = copyDesktopUsersBO.CanStoreStuffBuyManager;
    //        this.CanStoreStuffSellItemManager = copyDesktopUsersBO.CanStoreStuffSellItemManager;
    //        this.CanStoreShopHistoryViewer = copyDesktopUsersBO.CanStoreShopHistoryViewer;
    //        this.CanStoreAffairs = copyDesktopUsersBO.CanStoreAffairs;
    //        this.CanStoreStuffSellItem = copyDesktopUsersBO.CanStoreStuffSellItem;
    //        this.CanStoreSalesTracking = copyDesktopUsersBO.CanStoreSalesTracking;
    //        this.CanReportStudentListOfMajor = copyDesktopUsersBO.CanReportStudentListOfMajor;
    //        this.CanReportPaysOfTeacherInterval = copyDesktopUsersBO.CanReportPaysOfTeacherInterval;
    //        this.CanReportSessionsOfTeacherInterval = copyDesktopUsersBO.CanReportSessionsOfTeacherInterval;
    //        this.CanReportClassesOfTeacherInterval = copyDesktopUsersBO.CanReportClassesOfTeacherInterval;
    //        this.CanReportMinistryReport = copyDesktopUsersBO.CanReportMinistryReport;
    //        this.CanReportStudentPayFactor = copyDesktopUsersBO.CanReportStudentPayFactor;
    //        this.CanReportTypicalOutcomeYear = copyDesktopUsersBO.CanReportTypicalOutcomeYear;
    //        this.CanReportIncomeInterval = copyDesktopUsersBO.CanReportIncomeInterval;
    //        this.CanReportRegisteredStudentsPerEmployee = copyDesktopUsersBO.CanReportRegisteredStudentsPerEmployee;
    //        this.CanReportTeacherPayFactor = copyDesktopUsersBO.CanReportTeacherPayFactor;
    //        this.CanReportEmployeePayFactor = copyDesktopUsersBO.CanReportEmployeePayFactor;
    //        this.CanReportStudentOfPublicClass = copyDesktopUsersBO.CanReportStudentOfPublicClass;
    //        this.CanReportAffairs = copyDesktopUsersBO.CanReportAffairs;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    //        return tmpDesktopUsersDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    //        return tmpDesktopUsersDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
    //        return tmpDesktopUsersDA.Update();
    //    }

    //    public static List<DesktopUsersBO> List()
    //    {
    //        return DesktopUsersDA.List();
    //    }
    //    public static List<DesktopUsersBO> List(string username, string password)
    //    {
    //        return DesktopUsersDA.List(username, password);
    //    }

    //    public static DesktopUsersBO Find(string username)
    //    {
    //        return DesktopUsersDA.Find(username);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Username.Name)
    //                return Username.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Password.Name)
    //                return Password.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginDate.Name)
    //                return LastLoginDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginTime.Name)
    //                return LastLoginTime.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.EmployeeID.Name)
    //                return RelEmployee.FullName;
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentManager.Name)
    //                return CanStudentManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentRegisterationManager.Name)
    //                return CanStudentRegisterationManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentInformationReport.Name)
    //                return CanStudentInformationReport.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentPayForClass.Name)
    //                return CanStudentPayForClass.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentSessionDetails.Name)
    //                return CanStudentSessionDetails.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialDetails.Name)
    //                return CanStudentFinancialDetails.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialStatus.Name)
    //                return CanStudentFinancialStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentClassBalance.Name)
    //                return CanStudentClassBalance.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentAffairs.Name)
    //                return CanStudentAffairs.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialStatus.Name)
    //                return CanTeacherFinancialStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialDetails.Name)
    //                return CanTeacherFinancialDetails.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherSessionDetails.Name)
    //                return CanTeacherSessionDetails.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherManager.Name)
    //                return CanTeacherManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanMajorTeacherManager.Name)
    //                return CanMajorTeacherManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherClassBalance.Name)
    //                return CanTeacherClassBalance.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherPayForClass.Name)
    //                return CanTeacherPayForClass.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherTimeSelector.Name)
    //                return CanTeacherTimeSelector.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionStatusSetter.Name)
    //                return CanClassSessionStatusSetter.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionScheduleSetter.Name)
    //                return CanClassSessionScheduleSetter.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPrivate.Name)
    //                return CanClassManagerPrivate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPublic.Name)
    //                return CanClassManagerPublic.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassDailyStatus.Name)
    //                return CanClassDailyStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanPresenceManager.Name)
    //                return CanPresenceManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTimeManager.Name)
    //                return CanTimeManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeManager.Name)
    //                return CanEmployeeManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeSalary.Name)
    //                return CanEmployeeSalary.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanComboManager.Name)
    //                return CanComboManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanActivityManager.Name)
    //                return CanActivityManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDBSettings.Name)
    //                return CanDBSettings.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanGuarantorManager.Name)
    //                return CanGuarantorManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanSchoolSpecification.Name)
    //                return CanSchoolSpecification.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDesktopUsers.Name)
    //                return CanDesktopUsers.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeManager.Name)
    //                return CanOutcomeManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanIncomeManager.Name)
    //                return CanIncomeManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffAvailableViewer.Name)
    //                return CanStoreStuffAvailableViewer.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffTypeManager.Name)
    //                return CanStoreStuffTypeManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffBuyManager.Name)
    //                return CanStoreStuffBuyManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItemManager.Name)
    //                return CanStoreStuffSellItemManager.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreShopHistoryViewer.Name)
    //                return CanStoreShopHistoryViewer.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreAffairs.Name)
    //                return CanStoreAffairs.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItem.Name)
    //                return CanStoreStuffSellItem.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreSalesTracking.Name)
    //                return CanStoreSalesTracking.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentListOfMajor.Name)
    //                return CanReportStudentListOfMajor.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportPaysOfTeacherInterval.Name)
    //                return CanReportPaysOfTeacherInterval.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportSessionsOfTeacherInterval.Name)
    //                return CanReportSessionsOfTeacherInterval.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportClassesOfTeacherInterval.Name)
    //                return CanReportClassesOfTeacherInterval.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportMinistryReport.Name)
    //                return CanReportMinistryReport.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentPayFactor.Name)
    //                return CanReportStudentPayFactor.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTypicalOutcomeYear.Name)
    //                return CanReportTypicalOutcomeYear.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportIncomeInterval.Name)
    //                return CanReportIncomeInterval.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportRegisteredStudentsPerEmployee.Name)
    //                return CanReportRegisteredStudentsPerEmployee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTeacherPayFactor.Name)
    //                return CanReportTeacherPayFactor.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportEmployeePayFactor.Name)
    //                return CanReportEmployeePayFactor.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentOfPublicClass.Name)
    //                return CanReportStudentOfPublicClass.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportAffairs.Name)
    //                return CanReportAffairs.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<DesktopUsersBO> Members
    //    public DesktopUsersBO Clone()
    //    {
    //        return new DesktopUsersBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (DesktopUsersBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(DesktopUsersBO it1, DesktopUsersBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.Username == it2.Username;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(DesktopUsersBO it1, DesktopUsersBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class DesktopUsersBO : IBusinessObject, ICloner<DesktopUsersBO>, IComboFillable, IGridValue
    {
        #region Variables

        public string Username { get; set; }
        public string Password { get; set; }
        public string LastLoginDate { get; set; }
        public string LastLoginTime { get; set; }
        public string EmployeeID { get; set; }
        public bool CanStudentManager { get; set; }
        public bool CanStudentRegisterationManager { get; set; }
        public bool CanStudentInformationReport { get; set; }
        public bool CanStudentPayForClass { get; set; }
        public bool CanStudentSessionDetails { get; set; }
        public bool CanStudentFinancialDetails { get; set; }
        public bool CanStudentFinancialStatus { get; set; }
        public bool CanStudentClassBalance { get; set; }
        public bool CanStudentAffairs { get; set; }
        public bool CanTeacherFinancialStatus { get; set; }
        public bool CanTeacherFinancialDetails { get; set; }
        public bool CanTeacherSessionDetails { get; set; }
        public bool CanTeacherManager { get; set; }
        public bool CanMajorTeacherManager { get; set; }
        public bool CanTeacherClassBalance { get; set; }
        public bool CanTeacherPayForClass { get; set; }
        public bool CanTeacherTimeSelector { get; set; }
        public bool CanClassSessionStatusSetter { get; set; }
        public bool CanClassSessionScheduleSetter { get; set; }
        public bool CanClassManagerPrivate { get; set; }
        public bool CanClassManagerPublic { get; set; }
        public bool CanClassDailyStatus { get; set; }
        public bool CanPresenceManager { get; set; }
        public bool CanTimeManager { get; set; }
        public bool CanEmployeeManager { get; set; }
        public bool CanEmployeeSalary { get; set; }
        public bool CanComboManager { get; set; }
        public bool CanActivityManager { get; set; }
        public bool CanDBSettings { get; set; }
        public bool CanGuarantorManager { get; set; }
        public bool CanSchoolSpecification { get; set; }
        public bool CanDesktopUsers { get; set; }
        public bool CanOutcomeManager { get; set; }
        public bool CanIncomeManager { get; set; }
        public bool CanSynchDatabase { get; set; }
        public bool CanStoreStuffAvailableViewer { get; set; }
        public bool CanStoreStuffTypeManager { get; set; }
        public bool CanStoreStuffBuyManager { get; set; }
        public bool CanStoreStuffSellItemManager { get; set; }
        public bool CanStoreShopHistoryViewer { get; set; }
        public bool CanStoreAffairs { get; set; }
        public bool CanStoreStuffSellItem { get; set; }
        public bool CanStoreSalesTracking { get; set; }
        public bool CanReportStudentListOfMajor { get; set; }
        public bool CanReportPaysOfTeacherInterval { get; set; }
        public bool CanReportSessionsOfTeacherInterval { get; set; }
        public bool CanReportClassesOfTeacherInterval { get; set; }
        public bool CanReportMinistryReport { get; set; }
        public bool CanReportStudentPayFactor { get; set; }
        public bool CanReportTypicalOutcomeYear { get; set; }
        public bool CanReportIncomeInterval { get; set; }
        public bool CanReportRegisteredStudentsPerEmployee { get; set; }
        public bool CanReportTeacherPayFactor { get; set; }
        public bool CanReportEmployeePayFactor { get; set; }
        public bool CanReportStudentOfPublicClass { get; set; }
        public bool CanReportAffairs { get; set; }
        #endregion


        #region Constructors

        public DesktopUsersBO()
        {
            // Nothing to do...
        }

        public DesktopUsersBO(string username)
        {
            this.Username = username;
        }

        // Copy Constructor.
        public DesktopUsersBO(DesktopUsersBO copyDesktopUsersBO)
        {
            this.Username = copyDesktopUsersBO.Username;
            this.Password = copyDesktopUsersBO.Password;
            this.LastLoginDate = copyDesktopUsersBO.LastLoginDate;
            this.LastLoginTime = copyDesktopUsersBO.LastLoginTime;
            this.EmployeeID = copyDesktopUsersBO.EmployeeID;
            this.CanStudentManager = copyDesktopUsersBO.CanStudentManager;
            this.CanStudentRegisterationManager = copyDesktopUsersBO.CanStudentRegisterationManager;
            this.CanStudentInformationReport = copyDesktopUsersBO.CanStudentInformationReport;
            this.CanStudentPayForClass = copyDesktopUsersBO.CanStudentPayForClass;
            this.CanStudentSessionDetails = copyDesktopUsersBO.CanStudentSessionDetails;
            this.CanStudentFinancialDetails = copyDesktopUsersBO.CanStudentFinancialDetails;
            this.CanStudentFinancialStatus = copyDesktopUsersBO.CanStudentFinancialStatus;
            this.CanStudentClassBalance = copyDesktopUsersBO.CanStudentClassBalance;
            this.CanStudentAffairs = copyDesktopUsersBO.CanStudentAffairs;
            this.CanTeacherFinancialStatus = copyDesktopUsersBO.CanTeacherFinancialStatus;
            this.CanTeacherFinancialDetails = copyDesktopUsersBO.CanTeacherFinancialDetails;
            this.CanTeacherSessionDetails = copyDesktopUsersBO.CanTeacherSessionDetails;
            this.CanTeacherManager = copyDesktopUsersBO.CanTeacherManager;
            this.CanMajorTeacherManager = copyDesktopUsersBO.CanMajorTeacherManager;
            this.CanTeacherClassBalance = copyDesktopUsersBO.CanTeacherClassBalance;
            this.CanTeacherPayForClass = copyDesktopUsersBO.CanTeacherPayForClass;
            this.CanTeacherTimeSelector = copyDesktopUsersBO.CanTeacherTimeSelector;
            this.CanClassSessionStatusSetter = copyDesktopUsersBO.CanClassSessionStatusSetter;
            this.CanClassSessionScheduleSetter = copyDesktopUsersBO.CanClassSessionScheduleSetter;
            this.CanClassManagerPrivate = copyDesktopUsersBO.CanClassManagerPrivate;
            this.CanClassManagerPublic = copyDesktopUsersBO.CanClassManagerPublic;
            this.CanClassDailyStatus = copyDesktopUsersBO.CanClassDailyStatus;
            this.CanPresenceManager = copyDesktopUsersBO.CanPresenceManager;
            this.CanTimeManager = copyDesktopUsersBO.CanTimeManager;
            this.CanEmployeeManager = copyDesktopUsersBO.CanEmployeeManager;
            this.CanEmployeeSalary = copyDesktopUsersBO.CanEmployeeSalary;
            this.CanComboManager = copyDesktopUsersBO.CanComboManager;
            this.CanActivityManager = copyDesktopUsersBO.CanActivityManager;
            this.CanDBSettings = copyDesktopUsersBO.CanDBSettings;
            this.CanGuarantorManager = copyDesktopUsersBO.CanGuarantorManager;
            this.CanSchoolSpecification = copyDesktopUsersBO.CanSchoolSpecification;
            this.CanDesktopUsers = copyDesktopUsersBO.CanDesktopUsers;
            this.CanOutcomeManager = copyDesktopUsersBO.CanOutcomeManager;
            this.CanIncomeManager = copyDesktopUsersBO.CanIncomeManager;
            this.CanSynchDatabase = copyDesktopUsersBO.CanSynchDatabase;
            this.CanStoreStuffAvailableViewer = copyDesktopUsersBO.CanStoreStuffAvailableViewer;
            this.CanStoreStuffTypeManager = copyDesktopUsersBO.CanStoreStuffTypeManager;
            this.CanStoreStuffBuyManager = copyDesktopUsersBO.CanStoreStuffBuyManager;
            this.CanStoreStuffSellItemManager = copyDesktopUsersBO.CanStoreStuffSellItemManager;
            this.CanStoreShopHistoryViewer = copyDesktopUsersBO.CanStoreShopHistoryViewer;
            this.CanStoreAffairs = copyDesktopUsersBO.CanStoreAffairs;
            this.CanStoreStuffSellItem = copyDesktopUsersBO.CanStoreStuffSellItem;
            this.CanStoreSalesTracking = copyDesktopUsersBO.CanStoreSalesTracking;
            this.CanReportStudentListOfMajor = copyDesktopUsersBO.CanReportStudentListOfMajor;
            this.CanReportPaysOfTeacherInterval = copyDesktopUsersBO.CanReportPaysOfTeacherInterval;
            this.CanReportSessionsOfTeacherInterval = copyDesktopUsersBO.CanReportSessionsOfTeacherInterval;
            this.CanReportClassesOfTeacherInterval = copyDesktopUsersBO.CanReportClassesOfTeacherInterval;
            this.CanReportMinistryReport = copyDesktopUsersBO.CanReportMinistryReport;
            this.CanReportStudentPayFactor = copyDesktopUsersBO.CanReportStudentPayFactor;
            this.CanReportTypicalOutcomeYear = copyDesktopUsersBO.CanReportTypicalOutcomeYear;
            this.CanReportIncomeInterval = copyDesktopUsersBO.CanReportIncomeInterval;
            this.CanReportRegisteredStudentsPerEmployee = copyDesktopUsersBO.CanReportRegisteredStudentsPerEmployee;
            this.CanReportTeacherPayFactor = copyDesktopUsersBO.CanReportTeacherPayFactor;
            this.CanReportEmployeePayFactor = copyDesktopUsersBO.CanReportEmployeePayFactor;
            this.CanReportStudentOfPublicClass = copyDesktopUsersBO.CanReportStudentOfPublicClass;
            this.CanReportAffairs = copyDesktopUsersBO.CanReportAffairs;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
            return tmpDesktopUsersDA.Add();
        }

        public bool Delete()
        {
            DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
            return tmpDesktopUsersDA.Delete();
        }

        public bool Update()
        {
            DesktopUsersDA tmpDesktopUsersDA = new DesktopUsersDA(this);
            return tmpDesktopUsersDA.Update();
        }

        public static List<DesktopUsersBO> List()
        {
            return DesktopUsersDA.List();
        }
        public static List<DesktopUsersBO> List(string username, string password)
        {
            return DesktopUsersDA.List(username, password);
        }

        public static DesktopUsersBO Find(string username)
        {
            return DesktopUsersDA.Find(username);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Username.Name)
                    return Username.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.Password.Name)
                    return Password.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginDate.Name)
                    return LastLoginDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.LastLoginTime.Name)
                    return LastLoginTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.EmployeeID.Name)
                    return RelEmployee.FullName;
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentManager.Name)
                    return CanStudentManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentRegisterationManager.Name)
                    return CanStudentRegisterationManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentInformationReport.Name)
                    return CanStudentInformationReport.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentPayForClass.Name)
                    return CanStudentPayForClass.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentSessionDetails.Name)
                    return CanStudentSessionDetails.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialDetails.Name)
                    return CanStudentFinancialDetails.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentFinancialStatus.Name)
                    return CanStudentFinancialStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentClassBalance.Name)
                    return CanStudentClassBalance.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStudentAffairs.Name)
                    return CanStudentAffairs.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialStatus.Name)
                    return CanTeacherFinancialStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherFinancialDetails.Name)
                    return CanTeacherFinancialDetails.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherSessionDetails.Name)
                    return CanTeacherSessionDetails.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherManager.Name)
                    return CanTeacherManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanMajorTeacherManager.Name)
                    return CanMajorTeacherManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherClassBalance.Name)
                    return CanTeacherClassBalance.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherPayForClass.Name)
                    return CanTeacherPayForClass.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTeacherTimeSelector.Name)
                    return CanTeacherTimeSelector.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionStatusSetter.Name)
                    return CanClassSessionStatusSetter.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassSessionScheduleSetter.Name)
                    return CanClassSessionScheduleSetter.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPrivate.Name)
                    return CanClassManagerPrivate.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassManagerPublic.Name)
                    return CanClassManagerPublic.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanClassDailyStatus.Name)
                    return CanClassDailyStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanPresenceManager.Name)
                    return CanPresenceManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanTimeManager.Name)
                    return CanTimeManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeManager.Name)
                    return CanEmployeeManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanEmployeeSalary.Name)
                    return CanEmployeeSalary.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanComboManager.Name)
                    return CanComboManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanActivityManager.Name)
                    return CanActivityManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDBSettings.Name)
                    return CanDBSettings.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanGuarantorManager.Name)
                    return CanGuarantorManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanSchoolSpecification.Name)
                    return CanSchoolSpecification.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanDesktopUsers.Name)
                    return CanDesktopUsers.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanOutcomeManager.Name)
                    return CanOutcomeManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanIncomeManager.Name)
                    return CanIncomeManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanSynchDatabase.Name)
                    return CanSynchDatabase.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffAvailableViewer.Name)
                    return CanStoreStuffAvailableViewer.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffTypeManager.Name)
                    return CanStoreStuffTypeManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffBuyManager.Name)
                    return CanStoreStuffBuyManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItemManager.Name)
                    return CanStoreStuffSellItemManager.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreShopHistoryViewer.Name)
                    return CanStoreShopHistoryViewer.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreAffairs.Name)
                    return CanStoreAffairs.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreStuffSellItem.Name)
                    return CanStoreStuffSellItem.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanStoreSalesTracking.Name)
                    return CanStoreSalesTracking.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentListOfMajor.Name)
                    return CanReportStudentListOfMajor.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportPaysOfTeacherInterval.Name)
                    return CanReportPaysOfTeacherInterval.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportSessionsOfTeacherInterval.Name)
                    return CanReportSessionsOfTeacherInterval.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportClassesOfTeacherInterval.Name)
                    return CanReportClassesOfTeacherInterval.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportMinistryReport.Name)
                    return CanReportMinistryReport.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentPayFactor.Name)
                    return CanReportStudentPayFactor.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTypicalOutcomeYear.Name)
                    return CanReportTypicalOutcomeYear.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportIncomeInterval.Name)
                    return CanReportIncomeInterval.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportRegisteredStudentsPerEmployee.Name)
                    return CanReportRegisteredStudentsPerEmployee.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportTeacherPayFactor.Name)
                    return CanReportTeacherPayFactor.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportEmployeePayFactor.Name)
                    return CanReportEmployeePayFactor.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportStudentOfPublicClass.Name)
                    return CanReportStudentOfPublicClass.ToString();
                if (columnDefinition.Name == DatabaseSchema.DesktopUsers.CanReportAffairs.Name)
                    return CanReportAffairs.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return Username; }
        }

        public string ComboDescription
        {
            get { return Username; }
        }
        #endregion
        #region ICloner<DesktopUsersBO> Members
        public DesktopUsersBO Clone()
        {
            return new DesktopUsersBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (DesktopUsersBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(DesktopUsersBO it1, DesktopUsersBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.Username == it2.Username;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(DesktopUsersBO it1, DesktopUsersBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    class LoginDetailsBO : BusinessObject
    {
        public Guid loginID;
        public string loginDate;
        public string loginTime;
        public string privilegedGrant;
        public string username;




        public override bool Update()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool Add()
        {
            LoginDetailsDA lda = new LoginDetailsDA(this);
            return lda.Add();
        }

        public override bool Delete()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool Find()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override string ToString()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }

    public class DayCodeBO : BusinessObject
    {
        public int DayCodeID;
        public string DayName;

        public static List<DayCodeBO> List()
        {
            return DayCodeDA.List();
        }

        public static void FillCombo(ComboBox cbo)
        {
            cbo.Items.Clear();
            List<DayCodeBO> items = List();
            foreach (DayCodeBO item in items)
            {
                cbo.Items.Add(item);
            }
        }

        public override bool Update()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool Add()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool Delete()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool Find()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public static DayCodeBO Find(int DayCodeID)
        {
            return DayCodeDA.Find(DayCodeID);
        }

        public override string ToString()
        {
            return DayName;
        }
    }

    // Generated by DVD CodeGenerator
    // Added, IActivityManager
    public partial class StudentBO : IBusinessObject, ICloner<StudentBO>, IGridValue, ILastChange, IActivityManager<StudentBO>
    {
        #region Variables

        public string StudentID;
        public string FirstName;
        public string LastName;
        public string FatherName;
        public bool Gender;
        public string CertificationNumber;
        public string NationalNumber;
        public string BirthDate;
        public string BornPlace;
        public string BornProvince;
        public string BornCountry;
        public string IssuePlace;
        public bool MartialStatus;
        public int? AreaID;
        public string AddressHome;
        public string TellHome;
        public string AddressWork;
        public string TellWork;
        public string CellPhone;
        public int? DegreeTypeID;
        public int? DegreeLevelID;
        public string StudyMajor;
        public bool StudyStatus;
        public string Job;
        public int? HowtoFindID;
        public string SchoolName;
        public bool ActivityStatus;
        public Image Image;
        public string Username;
        public string Password;
        public string ParentUserName;
        public string ParentPassword;
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        #endregion

        #region Constructors

        public StudentBO()
        {
            // Nothing to do...
            ActivityStatus = true;
        }

        public StudentBO(string studentID)
        {
            this.StudentID = studentID;
        }

        // Copy Constructor.
        public StudentBO(StudentBO copyStudentBO)
        {
            this.StudentID = copyStudentBO.StudentID;
            this.FirstName = copyStudentBO.FirstName;
            this.LastName = copyStudentBO.LastName;
            this.FatherName = copyStudentBO.FatherName;
            this.Gender = copyStudentBO.Gender;
            this.CertificationNumber = copyStudentBO.CertificationNumber;
            this.NationalNumber = copyStudentBO.NationalNumber;
            this.BirthDate = copyStudentBO.BirthDate;
            this.BornPlace = copyStudentBO.BornPlace;
            this.BornProvince = copyStudentBO.BornProvince;
            this.BornCountry = copyStudentBO.BornCountry;
            this.IssuePlace = copyStudentBO.IssuePlace;
            this.MartialStatus = copyStudentBO.MartialStatus;
            this.AreaID = copyStudentBO.AreaID;
            this.AddressHome = copyStudentBO.AddressHome;
            this.TellHome = copyStudentBO.TellHome;
            this.AddressWork = copyStudentBO.AddressWork;
            this.TellWork = copyStudentBO.TellWork;
            this.CellPhone = copyStudentBO.CellPhone;
            this.DegreeTypeID = copyStudentBO.DegreeTypeID;
            this.DegreeLevelID = copyStudentBO.DegreeLevelID;
            this.StudyMajor = copyStudentBO.StudyMajor;
            this.StudyStatus = copyStudentBO.StudyStatus;
            this.Job = copyStudentBO.Job;
            this.HowtoFindID = copyStudentBO.HowtoFindID;
            this.SchoolName = copyStudentBO.SchoolName;
            this.ActivityStatus = copyStudentBO.ActivityStatus;
            this.Image = copyStudentBO.Image;
            this.Username = copyStudentBO.Username;
            this.Password = copyStudentBO.Password;
            this.ParentUserName = copyStudentBO.ParentUserName;
            this.ParentPassword = copyStudentBO.ParentPassword;
            this.LastChangeID = copyStudentBO.LastChangeID;
            this.LastChangeDate = copyStudentBO.LastChangeDate;
            this.LastChangeTime = copyStudentBO.LastChangeTime;
        }
        #endregion

        #region Methods (IBusinessObject)

        public bool Add()
        {
            StudentDA tmpStudentDA = new StudentDA(this);
            return tmpStudentDA.Add();
        }

        public bool Delete()
        {
            StudentDA tmpStudentDA = new StudentDA(this);
            return tmpStudentDA.Delete();
        }

        public bool Update()
        {
            StudentDA tmpStudentDA = new StudentDA(this);
            return tmpStudentDA.Update();
        }

        public static List<StudentBO> List()
        {
            return StudentDA.List();
        }


        public static List<StudentBO> List(int? areaID, int? howtoFindID, bool? activityStatus)
        {
            return StudentDA.List(areaID, howtoFindID, activityStatus);
        }

        //public static List<StudentBO> List(bool? activityStatus)
        //{
        //    return StudentDA.List(activityStatus);
        //}

        public static StudentBO Find(string studentID)
        {
            return StudentDA.Find(studentID);
        }

        //added by hanieh-------------
        public static List<string> BirthdayList(string date)
        {
            return StudentDA.BirthdayList(date);
        }
        //----------------------------
        #endregion

        public static string GenerateKey(int Year, int Season)
        {
            string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
            List<string> keys = StudentDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + UtilityTxt.To3Digit(i);
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000";
        }


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Student.StudentID.Name)
                    return StudentID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.FirstName.Name)
                    return FirstName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.LastName.Name)
                    return LastName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.FatherName.Name)
                    return FatherName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.Job.Name)
                    return Job.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.TellHome.Name)
                    return TellHome.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.TellWork.Name)
                    return TellWork.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.CellPhone.Name)
                    return CellPhone.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.ActivityStatus.Name)
                    return ActivityStatus ? "فعال" : "غیر فعال";
                else if (columnDefinition.Name == DatabaseSchema.Student.Gender.Name)
                    return Gender.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.CertificationNumber.Name)
                    return CertificationNumber.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.NationalNumber.Name)
                    return NationalNumber.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.BirthDate.Name)
                    return BirthDate.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.BornPlace.Name)
                    return BornPlace.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.BornProvince.Name)
                    return BornProvince.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.BornCountry.Name)
                    return BornCountry.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.IssuePlace.Name)
                    return IssuePlace.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.MartialStatus.Name)
                    return MartialStatus.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.AreaID.Name)
                    return AreaID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.AddressHome.Name)
                    return AddressHome.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.AddressWork.Name)
                    return AddressWork.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.DegreeTypeID.Name)
                    return DegreeTypeID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.DegreeLevelID.Name)
                    return DegreeLevelID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.StudyMajor.Name)
                    return StudyMajor.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.StudyStatus.Name)
                    return StudyStatus.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.HowtoFindID.Name)
                    return HowtoFindID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.SchoolName.Name)
                    return SchoolName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.Image.Name)
                    return Image.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.Username.Name)
                    return Username.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.Password.Name)
                    return Password.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.ParentUserName.Name)
                    return ParentUserName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.ParentPassword.Name)
                    return ParentPassword.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.LastChangeID.Name)
                    return LastChangeID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Student.LastChangeTime.Name)
                    return LastChangeTime.ToString();

            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<StudentBO> Members
        public StudentBO Clone()
        {
            return new StudentBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (StudentBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(StudentBO it1, StudentBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StudentID == it2.StudentID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(StudentBO it1, StudentBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

        #region IActivityManager<StudentBO> Members

        public List<StudentBO> List(bool? activityStatus)
        {
            return StudentDA.List(activityStatus);
        }

        public List<StudentBO> ListDeactiveCandidates()
        {
            return StudentDA.ListDeactivateCandidates(null);
        }

        public List<ColumnDefinition> StatusInfoColumns
        {
            get
            {
                return new List<ColumnDefinition>()
                {
                    DatabaseSchema.Student.StudentID,
                    DatabaseSchema.Student.FirstName,
                    DatabaseSchema.Student.LastName,
                    DatabaseSchema.Student.FatherName,
                    DatabaseSchema.Student.ActivityStatus
                };
            }
        }

        public string CaseName
        {
            get { return "هنرجو"; }
        }

        public string CaseNameI
        {
            get { return "هنرجویی"; }
        }

        public string DeactiveRule
        {
            get { return "هنرجویانی که در حال حاضر در کلاس فعالی ثبت‌نام نکرده‌اند و یا 3 ماه از آخرین کلاس آنها گذشته باشد."; }
        }

        public bool SetStatus(bool newStatus)
        {
            ActivitySetter setter = new ActivitySetter("student", "activityStatus", new List<ActivitySetter.KeyInfo>
            {
                new ActivitySetter.KeyInfo("studentID", "'" + StudentID + "'")
            });
            return setter.SetStatus(newStatus);
        }

        bool IActivityStatus.ActivityStatus
        {
            get { return ActivityStatus; }
        }

        public string StatusDescription
        {
            get
            {
                List<ClassBO> classes = ClassBO.ListClassesOfStudent(StudentID, null);
                string classStr = "";
                foreach (ClassBO cls in classes)
                {
                    classStr += cls.ClassName + "(" + cls.GetGridValue(DatabaseSchema.Class.ActivityStatus) + "), ";
                }
                classStr = classStr.TrimEnd(',', ' ');
                if (classes.Count == 0)
                    AdditionalInformation = "دانشجو در کلاسی ثبت نام نکرده است.";
                else
                {
                    AdditionalInformation = "لیست کلاس‌ها: \n" + classStr;
                }
                if (StudentDA.ListDeactivateCandidates(StudentID).Count > 0)
                    return "این هنرجو برای غیر فعال شدن پیشنهاد می‌شود.";
                return (ActivityStatus ? "هنرجو فعال است" : "هنرجو غیرفعال است");
            }
        }

        public string AdditionalInformation
        {
            get;
            set;
        }

        public bool IsDeactiveCandidate()
        {
            if (StudentDA.ListDeactivateCandidates(StudentID).Count > 0)
                return true;
            else
                return false;
        }

        #endregion
    }
    public partial class TmpStudentBO : IGridValue
    {
        #region Variables

        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string AddressHome { get; set; }
        public string TellHome { get; set; }
        public string TellWork { get; set; }
        public string CellPhone { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        #endregion

        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            throw new NotImplementedException();
        }
    }

    // Generated by DVD CodeGenerator
    public partial class AreaBO : IBusinessObject, ICloner<AreaBO>, IComboFillable, IGridValue
    {
        #region Variables

        public int AreaID;
        public string AreaName;
        public string AreaDescription;
        public bool ActivityStatus;
        public string LastChangeID;
        public string LastChangeDate;
        public string LastChangeTime;
        #endregion


        #region Constructors

        public AreaBO()
        {
            // Nothing to do...
        }

        public AreaBO(int areaID)
        {
            this.AreaID = areaID;
        }

        // Copy Constructor.
        public AreaBO(AreaBO copyAreaBO)
        {
            this.AreaID = copyAreaBO.AreaID;
            this.AreaName = copyAreaBO.AreaName;
            this.AreaDescription = copyAreaBO.AreaDescription;
            this.ActivityStatus = copyAreaBO.ActivityStatus;
            this.LastChangeID = copyAreaBO.LastChangeID;
            this.LastChangeDate = copyAreaBO.LastChangeDate;
            this.LastChangeTime = copyAreaBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            AreaDA tmpAreaDA = new AreaDA(this);
            return tmpAreaDA.Add();
        }

        public bool Delete()
        {
            AreaDA tmpAreaDA = new AreaDA(this);
            return tmpAreaDA.Delete();
        }

        public bool Update()
        {
            AreaDA tmpAreaDA = new AreaDA(this);
            return tmpAreaDA.Update();
        }

        public static List<AreaBO> List()
        {
            return AreaDA.List();
        }

        public static AreaBO Find(int areaID)
        {
            return AreaDA.Find(areaID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            if (columnDefinition.Name == DatabaseSchema.Area.AreaID.Name)
                return AreaID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.AreaName.Name)
                return AreaName.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.AreaDescription.Name)
                return AreaDescription.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.ActivityStatus.Name)
                return ActivityStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.LastChangeID.Name)
                return LastChangeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.LastChangeDate.Name)
                return LastChangeDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.Area.LastChangeTime.Name)
                return LastChangeTime.ToString();
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return AreaName; }
        }

        public string ComboDescription
        {
            get { return AreaDescription; }
        }
        #endregion
        #region ICloner<AreaBO> Members
        public AreaBO Clone()
        {
            return new AreaBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (AreaBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(AreaBO it1, AreaBO it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.AreaID == it2.AreaID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(AreaBO it1, AreaBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class DegreeLevelBO : IBusinessObject, ICloner<DegreeLevelBO>, IComboFillable, IGridValue
    {
        #region Variables

        public int DegreeLevelID;
        public string DegreeLevelName;
        public string DegreeLevelDescription;
        public bool ActivityStatus;
        public string LastChangeID;
        public string LastChangeDate;
        public string LastChangeTime;
        #endregion


        #region Constructors

        public DegreeLevelBO()
        {
            // Nothing to do...
        }

        public DegreeLevelBO(int degreeLevelID)
        {
            this.DegreeLevelID = degreeLevelID;
        }

        // Copy Constructor.
        public DegreeLevelBO(DegreeLevelBO copyDegreeLevelBO)
        {
            this.DegreeLevelID = copyDegreeLevelBO.DegreeLevelID;
            this.DegreeLevelName = copyDegreeLevelBO.DegreeLevelName;
            this.DegreeLevelDescription = copyDegreeLevelBO.DegreeLevelDescription;
            this.ActivityStatus = copyDegreeLevelBO.ActivityStatus;
            this.LastChangeID = copyDegreeLevelBO.LastChangeID;
            this.LastChangeDate = copyDegreeLevelBO.LastChangeDate;
            this.LastChangeTime = copyDegreeLevelBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            DegreeLevelDA tmpDegreeLevelDA = new DegreeLevelDA(this);
            return tmpDegreeLevelDA.Add();
        }

        public bool Delete()
        {
            DegreeLevelDA tmpDegreeLevelDA = new DegreeLevelDA(this);
            return tmpDegreeLevelDA.Delete();
        }

        public bool Update()
        {
            DegreeLevelDA tmpDegreeLevelDA = new DegreeLevelDA(this);
            return tmpDegreeLevelDA.Update();
        }

        public static List<DegreeLevelBO> List()
        {
            return DegreeLevelDA.List();
        }

        public static DegreeLevelBO Find(int degreeLevelID)
        {
            return DegreeLevelDA.Find(degreeLevelID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.DegreeLevelID.Name)
                return DegreeLevelID.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.DegreeLevelName.Name)
                return DegreeLevelName.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.DegreeLevelDescription.Name)
                return DegreeLevelDescription.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.ActivityStatus.Name)
                return ActivityStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.LastChangeID.Name)
                return LastChangeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.LastChangeDate.Name)
                return LastChangeDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeLevel.LastChangeTime.Name)
                return LastChangeTime.ToString();
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return DegreeLevelName; }
        }

        public string ComboDescription
        {
            get { return DegreeLevelDescription; }
        }
        #endregion
        #region ICloner<DegreeLevelBO> Members
        public DegreeLevelBO Clone()
        {
            return new DegreeLevelBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (DegreeLevelBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(DegreeLevelBO it1, DegreeLevelBO it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.DegreeLevelID == it2.DegreeLevelID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(DegreeLevelBO it1, DegreeLevelBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class DegreeTypeBO : IBusinessObject, ICloner<DegreeTypeBO>, IComboFillable, IGridValue
    {
        #region Variables

        public int DegreeTypeID;
        public string DegreeTypeName;
        public string DegreeTypeDescription;
        public bool? ActivityStatus;
        public string LastChangeID;
        public string LastChangeDate;
        public string LastChangeTime;
        #endregion


        #region Constructors

        public DegreeTypeBO()
        {
            // Nothing to do...
        }

        public DegreeTypeBO(int degreeTypeID)
        {
            this.DegreeTypeID = degreeTypeID;
        }

        // Copy Constructor.
        public DegreeTypeBO(DegreeTypeBO copyDegreeTypeBO)
        {
            this.DegreeTypeID = copyDegreeTypeBO.DegreeTypeID;
            this.DegreeTypeName = copyDegreeTypeBO.DegreeTypeName;
            this.DegreeTypeDescription = copyDegreeTypeBO.DegreeTypeDescription;
            this.ActivityStatus = copyDegreeTypeBO.ActivityStatus;
            this.LastChangeID = copyDegreeTypeBO.LastChangeID;
            this.LastChangeDate = copyDegreeTypeBO.LastChangeDate;
            this.LastChangeTime = copyDegreeTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            DegreeTypeDA tmpDegreeTypeDA = new DegreeTypeDA(this);
            return tmpDegreeTypeDA.Add();
        }

        public bool Delete()
        {
            DegreeTypeDA tmpDegreeTypeDA = new DegreeTypeDA(this);
            return tmpDegreeTypeDA.Delete();
        }

        public bool Update()
        {
            DegreeTypeDA tmpDegreeTypeDA = new DegreeTypeDA(this);
            return tmpDegreeTypeDA.Update();
        }

        public static List<DegreeTypeBO> List()
        {
            return DegreeTypeDA.List();
        }

        public static DegreeTypeBO Find(int degreeTypeID)
        {
            return DegreeTypeDA.Find(degreeTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            if (columnDefinition.Name == DatabaseSchema.DegreeType.DegreeTypeID.Name)
                return DegreeTypeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.DegreeTypeName.Name)
                return DegreeTypeName.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.DegreeTypeDescription.Name)
                return DegreeTypeDescription.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.ActivityStatus.Name)
                return ActivityStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.LastChangeID.Name)
                return LastChangeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.LastChangeDate.Name)
                return LastChangeDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.DegreeType.LastChangeTime.Name)
                return LastChangeTime.ToString();
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return DegreeTypeName; }
        }

        public string ComboDescription
        {
            get { return DegreeTypeDescription; }
        }
        #endregion
        #region ICloner<DegreeTypeBO> Members
        public DegreeTypeBO Clone()
        {
            return new DegreeTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (DegreeTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(DegreeTypeBO it1, DegreeTypeBO it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.DegreeTypeID == it2.DegreeTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(DegreeTypeBO it1, DegreeTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class HowtoFindBO : IBusinessObject, ICloner<HowtoFindBO>, IComboFillable, IGridValue
    {
        #region Variables

        public int HowtoFindID;
        public string HowtoFindName;
        public string HowtoFindDescription;
        public bool ActivityStatus;
        public string LastChangeID;
        public string LastChangeDate;
        public string LastChangeTime;
        #endregion


        #region Constructors

        public HowtoFindBO()
        {
            // Nothing to do...
        }

        public HowtoFindBO(int howtoFindID)
        {
            this.HowtoFindID = howtoFindID;
        }

        // Copy Constructor.
        public HowtoFindBO(HowtoFindBO copyHowtoFindBO)
        {
            this.HowtoFindID = copyHowtoFindBO.HowtoFindID;
            this.HowtoFindName = copyHowtoFindBO.HowtoFindName;
            this.HowtoFindDescription = copyHowtoFindBO.HowtoFindDescription;
            this.ActivityStatus = copyHowtoFindBO.ActivityStatus;
            this.LastChangeID = copyHowtoFindBO.LastChangeID;
            this.LastChangeDate = copyHowtoFindBO.LastChangeDate;
            this.LastChangeTime = copyHowtoFindBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            HowtoFindDA tmpHowtoFindDA = new HowtoFindDA(this);
            return tmpHowtoFindDA.Add();
        }

        public bool Delete()
        {
            HowtoFindDA tmpHowtoFindDA = new HowtoFindDA(this);
            return tmpHowtoFindDA.Delete();
        }

        public bool Update()
        {
            HowtoFindDA tmpHowtoFindDA = new HowtoFindDA(this);
            return tmpHowtoFindDA.Update();
        }

        public static List<HowtoFindBO> List()
        {
            return HowtoFindDA.List();
        }

        public static HowtoFindBO Find(int howtoFindID)
        {
            return HowtoFindDA.Find(howtoFindID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.HowtoFindID.Name)
                return HowtoFindID.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.HowtoFindName.Name)
                return HowtoFindName.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.HowtoFindDescription.Name)
                return HowtoFindDescription.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.ActivityStatus.Name)
                return ActivityStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.LastChangeID.Name)
                return LastChangeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.LastChangeDate.Name)
                return LastChangeDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.HowtoFind.LastChangeTime.Name)
                return LastChangeTime.ToString();
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return HowtoFindName; }
        }

        public string ComboDescription
        {
            get { return HowtoFindDescription; }
        }
        #endregion
        #region ICloner<HowtoFindBO> Members
        public HowtoFindBO Clone()
        {
            return new HowtoFindBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (HowtoFindBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(HowtoFindBO it1, HowtoFindBO it2)
        {
            bool ans = false;
            try
            {
                ans = true && it1.HowtoFindID == it2.HowtoFindID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(HowtoFindBO it1, HowtoFindBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class EmployeeBO : IBusinessObject, ICloner<EmployeeBO>, ILastChange, IGridValue
    {
        #region Variables

        public string EmployeeID;
        public string FirstName;
        public string LastName;
        public string FatherName;
        public bool Gender;
        public string CertificationNumber;
        public string NationalNumber;
        public string BirthDate;
        public string BornPlace;
        public string BornProvince;
        public string BornCountry;
        public string IssuePlace;
        public bool MartialStatus;
        public string HomeAddress;
        public string HomeTell;
        public string CellPhone;
        public int? DegreeTypeID;
        public int? DegreeLevelID;
        public string StudyMajor;
        public bool StudyStatus;
        public string Job;
        public int? HowtoFindID;
        public string School;
        public bool ActivityStatus;
        public string GuarantorID;
        public Image Image;
        // Change: get;set added;

        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private GuarantorBO relGuarantor;
        public GuarantorBO RelGuarantor
        {
            get
            {
                if (relGuarantor == null)
                    relGuarantor = GuarantorBO.Find(GuarantorID);
                return relGuarantor;
            }
            set { relGuarantor = value; }
        }

        public string FullName { get { return FirstName + " " + LastName; } }


        #region Constructors

        public EmployeeBO()
        {
            // Nothing to do...
        }

        public EmployeeBO(string employeeID)
        {
            this.EmployeeID = employeeID;
        }

        // Copy Constructor.
        public EmployeeBO(EmployeeBO copyEmployeeBO)
        {
            this.EmployeeID = copyEmployeeBO.EmployeeID;
            this.FirstName = copyEmployeeBO.FirstName;
            this.LastName = copyEmployeeBO.LastName;
            this.FatherName = copyEmployeeBO.FatherName;
            this.Gender = copyEmployeeBO.Gender;
            this.CertificationNumber = copyEmployeeBO.CertificationNumber;
            this.NationalNumber = copyEmployeeBO.NationalNumber;
            this.BirthDate = copyEmployeeBO.BirthDate;
            this.BornPlace = copyEmployeeBO.BornPlace;
            this.BornProvince = copyEmployeeBO.BornProvince;
            this.BornCountry = copyEmployeeBO.BornCountry;
            this.IssuePlace = copyEmployeeBO.IssuePlace;
            this.MartialStatus = copyEmployeeBO.MartialStatus;
            this.HomeAddress = copyEmployeeBO.HomeAddress;
            this.HomeTell = copyEmployeeBO.HomeTell;
            this.CellPhone = copyEmployeeBO.CellPhone;
            this.DegreeTypeID = copyEmployeeBO.DegreeTypeID;
            this.DegreeLevelID = copyEmployeeBO.DegreeLevelID;
            this.StudyMajor = copyEmployeeBO.StudyMajor;
            this.StudyStatus = copyEmployeeBO.StudyStatus;
            this.Job = copyEmployeeBO.Job;
            this.HowtoFindID = copyEmployeeBO.HowtoFindID;
            this.School = copyEmployeeBO.School;
            this.ActivityStatus = copyEmployeeBO.ActivityStatus;
            this.GuarantorID = copyEmployeeBO.GuarantorID;
            this.Image = copyEmployeeBO.Image;
            this.LastChangeID = copyEmployeeBO.LastChangeID;
            this.LastChangeDate = copyEmployeeBO.LastChangeDate;
            this.LastChangeTime = copyEmployeeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            EmployeeDA tmpEmployeeDA = new EmployeeDA(this);
            return tmpEmployeeDA.Add();
        }

        public bool Delete()
        {
            EmployeeDA tmpEmployeeDA = new EmployeeDA(this);
            return tmpEmployeeDA.Delete();
        }

        public bool Update()
        {
            EmployeeDA tmpEmployeeDA = new EmployeeDA(this);
            return tmpEmployeeDA.Update();
        }

        public static List<EmployeeBO> List()
        {
            return EmployeeDA.List();
        }
        public static List<EmployeeBO> List(int? degreeTypeID, int? degreeLevelID)
        {
            return EmployeeDA.List(degreeTypeID, degreeLevelID);
        }
        public static List<EmployeeBO> List(int? howtoFindID)
        {
            return EmployeeDA.List(howtoFindID);
        }

        public static EmployeeBO Find(string employeeID)
        {
            return EmployeeDA.Find(employeeID);
        }
        #endregion

        public static string GenerateKey(int Year, int Season)
        {
            string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
            List<string> keys = EmployeeDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + UtilityTxt.To3Digit(i);
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000";
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            if (columnDefinition.Name == DatabaseSchema.Employee.EmployeeID.Name)
                return EmployeeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.FirstName.Name)
                return FirstName.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.LastName.Name)
                return LastName.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.FatherName.Name)
                return FatherName.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.Gender.Name)
                return Gender.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.CertificationNumber.Name)
                return CertificationNumber.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.NationalNumber.Name)
                return NationalNumber.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.BirthDate.Name)
                return BirthDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.BornPlace.Name)
                return BornPlace.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.BornProvince.Name)
                return BornProvince.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.BornCountry.Name)
                return BornCountry.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.IssuePlace.Name)
                return IssuePlace.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.MartialStatus.Name)
                return MartialStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.HomeAddress.Name)
                return HomeAddress.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.HomeTell.Name)
                return HomeTell.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.CellPhone.Name)
                return CellPhone.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.DegreeTypeID.Name)
                return DegreeTypeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.DegreeLevelID.Name)
                return DegreeLevelID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.StudyMajor.Name)
                return StudyMajor.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.StudyStatus.Name)
                return StudyStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.Job.Name)
                return Job.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.HowtoFindID.Name)
                return HowtoFindID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.School.Name)
                return School.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.ActivityStatus.Name)
                return ActivityStatus.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.GuarantorID.Name)
                return GuarantorID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.Image.Name)
                return Image.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.LastChangeID.Name)
                return LastChangeID.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.LastChangeDate.Name)
                return LastChangeDate.ToString();
            if (columnDefinition.Name == DatabaseSchema.Employee.LastChangeTime.Name)
                return LastChangeTime.ToString();
            return "";
        }
        #endregion
        #region ICloner<EmployeeBO> Members
        public EmployeeBO Clone()
        {
            return new EmployeeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (EmployeeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(EmployeeBO it1, EmployeeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.EmployeeID == it2.EmployeeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(EmployeeBO it1, EmployeeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class GuarantorBO : IBusinessObject, ICloner<GuarantorBO>, ILastChange, IGridValue
    {
        #region Variables

        public string GuarantorID;
        public string FirstName;
        public string LastName;
        public string FatherName;
        public bool Gender;
        public string CertificationNumber;
        public string NationalNumber;
        public string BirthDate;
        public string BornPlace;
        public string IssuePlace;
        public bool MartialStatus;
        public string HomeAddress;
        public string HomeTell;
        public string WorkAddress;
        public string WorkTell;
        public string CellPhone;
        public string Job;
        public int DegreeLevelID;
        public string StudyMajor;
        public string Guarantee;
        public Image Image;
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion



        public string FullName { get { return FirstName + " " + LastName; } }


        #region Constructors

        public GuarantorBO()
        {
            // Nothing to do...
        }

        public GuarantorBO(string guarantorID)
        {
            this.GuarantorID = guarantorID;
        }

        // Copy Constructor.
        public GuarantorBO(GuarantorBO copyGuarantorBO)
        {
            this.GuarantorID = copyGuarantorBO.GuarantorID;
            this.FirstName = copyGuarantorBO.FirstName;
            this.LastName = copyGuarantorBO.LastName;
            this.FatherName = copyGuarantorBO.FatherName;
            this.Gender = copyGuarantorBO.Gender;
            this.CertificationNumber = copyGuarantorBO.CertificationNumber;
            this.NationalNumber = copyGuarantorBO.NationalNumber;
            this.BirthDate = copyGuarantorBO.BirthDate;
            this.BornPlace = copyGuarantorBO.BornPlace;
            this.IssuePlace = copyGuarantorBO.IssuePlace;
            this.MartialStatus = copyGuarantorBO.MartialStatus;
            this.HomeAddress = copyGuarantorBO.HomeAddress;
            this.HomeTell = copyGuarantorBO.HomeTell;
            this.WorkAddress = copyGuarantorBO.WorkAddress;
            this.WorkTell = copyGuarantorBO.WorkTell;
            this.CellPhone = copyGuarantorBO.CellPhone;
            this.Job = copyGuarantorBO.Job;
            this.DegreeLevelID = copyGuarantorBO.DegreeLevelID;
            this.StudyMajor = copyGuarantorBO.StudyMajor;
            this.Guarantee = copyGuarantorBO.Guarantee;
            this.Image = copyGuarantorBO.Image;
            this.LastChangeID = copyGuarantorBO.LastChangeID;
            this.LastChangeDate = copyGuarantorBO.LastChangeDate;
            this.LastChangeTime = copyGuarantorBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            GuarantorDA tmpGuarantorDA = new GuarantorDA(this);
            return tmpGuarantorDA.Add();
        }

        public bool Delete()
        {
            GuarantorDA tmpGuarantorDA = new GuarantorDA(this);
            return tmpGuarantorDA.Delete();
        }

        public bool Update()
        {
            GuarantorDA tmpGuarantorDA = new GuarantorDA(this);
            return tmpGuarantorDA.Update();
        }

        public static List<GuarantorBO> List()
        {
            return GuarantorDA.List();
        }
        public static List<GuarantorBO> List(int? degreeLevelID)
        {
            return GuarantorDA.List(degreeLevelID);
        }

        public static GuarantorBO Find(string guarantorID)
        {
            return GuarantorDA.Find(guarantorID);
        }
        #endregion

        public static string GenerateKey(int Year, int Season)
        {
            string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
            List<string> keys = GuarantorDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + UtilityTxt.To3Digit(i);
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000";
        }


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Guarantor.GuarantorID.Name)
                    return GuarantorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.FatherName.Name)
                    return FatherName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.Gender.Name)
                    return Gender.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.CertificationNumber.Name)
                    return CertificationNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.NationalNumber.Name)
                    return NationalNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.BirthDate.Name)
                    return BirthDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.BornPlace.Name)
                    return BornPlace.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.IssuePlace.Name)
                    return IssuePlace.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.MartialStatus.Name)
                    return MartialStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.HomeAddress.Name)
                    return HomeAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.HomeTell.Name)
                    return HomeTell.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.WorkAddress.Name)
                    return WorkAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.WorkTell.Name)
                    return WorkTell.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.CellPhone.Name)
                    return CellPhone.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.Job.Name)
                    return Job.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.DegreeLevelID.Name)
                    return DegreeLevelID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.StudyMajor.Name)
                    return StudyMajor.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.Guarantee.Name)
                    return Guarantee.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.Image.Name)
                    return Image.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Guarantor.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<GuarantorBO> Members
        public GuarantorBO Clone()
        {
            return new GuarantorBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (GuarantorBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(GuarantorBO it1, GuarantorBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.GuarantorID == it2.GuarantorID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(GuarantorBO it1, GuarantorBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ContractTypeBO : IBusinessObject, ICloner<ContractTypeBO>, IComboFillable, ILastChange, IGridValue
    {
        public enum ContractTypeEnum
        {
            Session = 1,
            Percent = 2
        }

        #region Variables

        public int ContractTypeID;
        public string ContractTypeName;
        public string ContractTypeDescription;
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public ContractTypeBO()
        {
            // Nothing to do...
        }

        public ContractTypeBO(int contractTypeID)
        {
            this.ContractTypeID = contractTypeID;
        }

        // Copy Constructor.
        public ContractTypeBO(ContractTypeBO copyContractTypeBO)
        {
            this.ContractTypeID = copyContractTypeBO.ContractTypeID;
            this.ContractTypeName = copyContractTypeBO.ContractTypeName;
            this.ContractTypeDescription = copyContractTypeBO.ContractTypeDescription;
            this.LastChangeID = copyContractTypeBO.LastChangeID;
            this.LastChangeDate = copyContractTypeBO.LastChangeDate;
            this.LastChangeTime = copyContractTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ContractTypeDA tmpContractTypeDA = new ContractTypeDA(this);
            return tmpContractTypeDA.Add();
        }

        public bool Delete()
        {
            ContractTypeDA tmpContractTypeDA = new ContractTypeDA(this);
            return tmpContractTypeDA.Delete();
        }

        public bool Update()
        {
            ContractTypeDA tmpContractTypeDA = new ContractTypeDA(this);
            return tmpContractTypeDA.Update();
        }

        public static List<ContractTypeBO> List()
        {
            return ContractTypeDA.List();
        }

        public static ContractTypeBO Find(int contractTypeID)
        {
            return ContractTypeDA.Find(contractTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ContractType.ContractTypeID.Name)
                    return ContractTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ContractType.ContractTypeName.Name)
                    return ContractTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ContractType.ContractTypeDescription.Name)
                    return ContractTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.ContractType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ContractType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ContractType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return ContractTypeName; }
        }

        public string ComboDescription
        {
            get { return ContractTypeDescription; }
        }
        #endregion
        #region ICloner<ContractTypeBO> Members
        public ContractTypeBO Clone()
        {
            return new ContractTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ContractTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ContractTypeBO it1, ContractTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ContractTypeID == it2.ContractTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ContractTypeBO it1, ContractTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class TeacherBO : IBusinessObject, ICloner<TeacherBO>, ILastChange, IGridValue, IActivityManager<TeacherBO>
    {
        #region Variables

        public string TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public bool Gender { get; set; }
        public string CertificationNumber { get; set; }
        public string NationalNumber { get; set; }
        public string BirthDate { get; set; }
        public string BornPlace { get; set; }
        public string BornProvince { get; set; }
        public string BornCountry { get; set; }
        public string IssuePlace { get; set; }
        public bool MartialStatus { get; set; }
        public string HomeAddress { get; set; }
        public string HomeTell { get; set; }
        public string WorkAddress { get; set; }
        public string WorkTell { get; set; }
        public string CellPhone { get; set; }
        public int DegreeTypeID { get; set; }
        public int DegreeLevelID { get; set; }
        public string StudyMajor { get; set; }
        public bool StudyStatus { get; set; }
        public string Job { get; set; }
        public string Introducer { get; set; }
        public string QulificationCardID { get; set; }
        public string Teachers { get; set; }
        public string TeachingExprience { get; set; }
        public string School { get; set; }
        public int ContractTypeID { get; set; }
        public int ContractValue { get; set; }
        public Image Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool ActivityStatus { get; set; }
        public bool CanShowOnWeb { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        public string FullName { get { return FirstName + " " + LastName; } }


        #region Constructors

        public TeacherBO()
        {
            // Nothing to do...
        }

        public TeacherBO(string teacherID)
        {
            this.TeacherID = teacherID;
        }

        // Copy Constructor.
        public TeacherBO(TeacherBO copyTeacherBO)
        {
            this.TeacherID = copyTeacherBO.TeacherID;
            this.FirstName = copyTeacherBO.FirstName;
            this.LastName = copyTeacherBO.LastName;
            this.FatherName = copyTeacherBO.FatherName;
            this.Gender = copyTeacherBO.Gender;
            this.CertificationNumber = copyTeacherBO.CertificationNumber;
            this.NationalNumber = copyTeacherBO.NationalNumber;
            this.BirthDate = copyTeacherBO.BirthDate;
            this.BornPlace = copyTeacherBO.BornPlace;
            this.BornProvince = copyTeacherBO.BornProvince;
            this.BornCountry = copyTeacherBO.BornCountry;
            this.IssuePlace = copyTeacherBO.IssuePlace;
            this.MartialStatus = copyTeacherBO.MartialStatus;
            this.HomeAddress = copyTeacherBO.HomeAddress;
            this.HomeTell = copyTeacherBO.HomeTell;
            this.WorkAddress = copyTeacherBO.WorkAddress;
            this.WorkTell = copyTeacherBO.WorkTell;
            this.CellPhone = copyTeacherBO.CellPhone;
            this.DegreeTypeID = copyTeacherBO.DegreeTypeID;
            this.DegreeLevelID = copyTeacherBO.DegreeLevelID;
            this.StudyMajor = copyTeacherBO.StudyMajor;
            this.StudyStatus = copyTeacherBO.StudyStatus;
            this.Job = copyTeacherBO.Job;
            this.Introducer = copyTeacherBO.Introducer;
            this.QulificationCardID = copyTeacherBO.QulificationCardID;
            this.Teachers = copyTeacherBO.Teachers;
            this.TeachingExprience = copyTeacherBO.TeachingExprience;
            this.School = copyTeacherBO.School;
            this.ContractTypeID = copyTeacherBO.ContractTypeID;
            this.ContractValue = copyTeacherBO.ContractValue;
            this.Image = copyTeacherBO.Image;
            this.Username = copyTeacherBO.Username;
            this.Password = copyTeacherBO.Password;
            this.ActivityStatus = copyTeacherBO.ActivityStatus;
            this.CanShowOnWeb = copyTeacherBO.CanShowOnWeb;
            this.LastChangeID = copyTeacherBO.LastChangeID;
            this.LastChangeDate = copyTeacherBO.LastChangeDate;
            this.LastChangeTime = copyTeacherBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            TeacherDA tmpTeacherDA = new TeacherDA(this);
            return tmpTeacherDA.Add();
        }

        public bool Delete()
        {
            TeacherDA tmpTeacherDA = new TeacherDA(this);
            return tmpTeacherDA.Delete();
        }

        public bool Update()
        {
            TeacherDA tmpTeacherDA = new TeacherDA(this);
            return tmpTeacherDA.Update();
        }

        public static List<TeacherBO> List()
        {
            return TeacherDA.List();
        }
        public static List<TeacherBO> List(int? degreeTypeID, int? degreeLevelID, int? contractTypeID)
        {
            return TeacherDA.List(degreeTypeID, degreeLevelID, contractTypeID);
        }

        public static List<TeacherBO> List(int? majorID, bool? activityStatus)
        {
            return TeacherDA.List(majorID, activityStatus);
        }

        public static TeacherBO Find(string teacherID)
        {
            return TeacherDA.Find(teacherID);
        }
        #endregion

        public static string GenerateKey(int Year, int Season)
        {
            string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
            List<string> keys = TeacherDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + UtilityTxt.To3Digit(i);
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000";
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Teacher.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.FatherName.Name)
                    return FatherName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Gender.Name)
                    return Gender.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.CertificationNumber.Name)
                    return CertificationNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.NationalNumber.Name)
                    return NationalNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.BirthDate.Name)
                    return BirthDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.BornPlace.Name)
                    return BornPlace.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.BornProvince.Name)
                    return BornProvince.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.BornCountry.Name)
                    return BornCountry.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.IssuePlace.Name)
                    return IssuePlace.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.MartialStatus.Name)
                    return MartialStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.HomeAddress.Name)
                    return HomeAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.HomeTell.Name)
                    return HomeTell.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.WorkAddress.Name)
                    return WorkAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.WorkTell.Name)
                    return WorkTell.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.CellPhone.Name)
                    return CellPhone.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.DegreeTypeID.Name)
                    return DegreeTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.DegreeLevelID.Name)
                    return DegreeLevelID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.StudyMajor.Name)
                    return StudyMajor.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.StudyStatus.Name)
                    return StudyStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Job.Name)
                    return Job.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Introducer.Name)
                    return Introducer.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.QulificationCardID.Name)
                    return QulificationCardID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Teachers.Name)
                    return Teachers.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.TeachingExprience.Name)
                    return TeachingExprience.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.School.Name)
                    return School.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.ContractTypeID.Name)
                    return ContractTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.ContractValue.Name)
                    return ContractValue.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Image.Name)
                    return Image.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Username.Name)
                    return Username.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.Password.Name)
                    return Password.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<TeacherBO> Members
        public TeacherBO Clone()
        {
            return new TeacherBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (TeacherBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(TeacherBO it1, TeacherBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.TeacherID == it2.TeacherID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(TeacherBO it1, TeacherBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

        #region IActivityManager<TeacherBO> Members

        public List<TeacherBO> List(bool? activityStatus)
        {
            return TeacherDA.List(null, activityStatus);
        }

        public List<TeacherBO> ListDeactiveCandidates()
        {
            return TeacherDA.ListDeactivateCandidates(null);
        }

        #endregion

        #region IActivityStatus Members

        public bool SetStatus(bool newStatus)
        {
            ActivitySetter setter = new ActivitySetter("teacher", "activityStatus", new List<ActivitySetter.KeyInfo>
            {
                new ActivitySetter.KeyInfo("teacherID", "'" + TeacherID + "'")
            });
            return setter.SetStatus(newStatus);
        }

        public string StatusDescription
        {
            get
            {
                List<ClassBO> classes = ClassBO.List(null, TeacherID, null, null, null);
                string classStr = "";
                foreach (ClassBO cls in classes)
                {
                    classStr += cls.ClassName + "(" + cls.GetGridValue(DatabaseSchema.Class.ActivityStatus) + "), ";
                }
                classStr = classStr.TrimEnd(',', ' ');
                if (classes.Count == 0)
                    AdditionalInformation = "این استاد در هیچ کلاسی تدریس نکرده است.";
                else
                {
                    AdditionalInformation = "لیست کلاس‌ها: \n" + classStr;
                }
                if (TeacherDA.ListDeactivateCandidates(TeacherID).Count > 0)
                    return "این استاد برای غیر فعال شدن پیشنهاد می‌شود.";
                return (ActivityStatus ? "استاد فعال است" : "استاد غیرفعال است");
            }
        }

        public string AdditionalInformation
        {
            get;
            set;
        }

        public bool IsDeactiveCandidate()
        {
            if (TeacherDA.ListDeactivateCandidates(TeacherID).Count > 0)
                return true;
            else
                return false;
        }

        public List<ColumnDefinition> StatusInfoColumns
        {
            get
            {
                return new List<ColumnDefinition>()
                {
                    DatabaseSchema.Teacher.TeacherID,
                    DatabaseSchema.Teacher.FirstName,
                    DatabaseSchema.Teacher.LastName,
                    DatabaseSchema.Teacher.ActivityStatus
                };
            }
        }

        public string CaseName
        {
            get { return "استاد"; }
        }

        public string CaseNameI
        {
            get { return "استادی"; }
        }

        public string DeactiveRule
        {
            get { return "استادی که در حال حاضر کلاس فعالی در موسسه ندارد."; }
        }

        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class MajorBO : IBusinessObject, ICloner<MajorBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int MajorID;
        public string MajorName;
        public string MajorDescription;
        public bool ActivityStatus;
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public MajorBO()
        {
            // Nothing to do...
        }

        public MajorBO(int majorID)
        {
            this.MajorID = majorID;
        }

        // Copy Constructor.
        public MajorBO(MajorBO copyMajorBO)
        {
            this.MajorID = copyMajorBO.MajorID;
            this.MajorName = copyMajorBO.MajorName;
            this.MajorDescription = copyMajorBO.MajorDescription;
            this.ActivityStatus = copyMajorBO.ActivityStatus;
            this.LastChangeID = copyMajorBO.LastChangeID;
            this.LastChangeDate = copyMajorBO.LastChangeDate;
            this.LastChangeTime = copyMajorBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            MajorDA tmpMajorDA = new MajorDA(this);
            return tmpMajorDA.Add();
        }

        public bool Delete()
        {
            MajorDA tmpMajorDA = new MajorDA(this);
            return tmpMajorDA.Delete();
        }

        public bool Update()
        {
            MajorDA tmpMajorDA = new MajorDA(this);
            return tmpMajorDA.Update();
        }

        public static List<MajorBO> List()
        {
            return MajorDA.List();
        }
        public static List<MajorBO> List(bool? activityStatus)
        {
            return MajorDA.List(activityStatus);
        }

        public static MajorBO Find(int majorID)
        {
            return MajorDA.Find(majorID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Major.MajorID.Name)
                    return MajorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.MajorName.Name)
                    return MajorName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.MajorDescription.Name)
                    return MajorDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return MajorName; }
        }

        public string ComboDescription
        {
            get { return MajorDescription; }
        }
        #endregion
        #region ICloner<MajorBO> Members
        public MajorBO Clone()
        {
            return new MajorBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (MajorBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MajorBO it1, MajorBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.MajorID == it2.MajorID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(MajorBO it1, MajorBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class MajorTeacherBO : IBusinessObject, ICloner<MajorTeacherBO>, ILastChange, IGridValue
    {
        #region Variables

        public int MajorID;
        public string TeacherID;
        public bool SpecialMajorFlag;
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private MajorBO relMajor;
        public MajorBO RelMajor
        {
            get
            {
                if (relMajor == null)
                    relMajor = MajorBO.Find(MajorID);
                return relMajor;
            }
            set { relMajor = value; }
        }

        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                    relTeacher = TeacherBO.Find(TeacherID);
                return relTeacher;
            }
            set { relTeacher = value; }
        }


        #region Constructors

        public MajorTeacherBO()
        {
            // Nothing to do...
        }

        public MajorTeacherBO(int majorID, string teacherID)
        {
            this.MajorID = majorID;
            this.TeacherID = teacherID;
        }

        // Copy Constructor.
        public MajorTeacherBO(MajorTeacherBO copyMajorTeacherBO)
        {
            this.MajorID = copyMajorTeacherBO.MajorID;
            this.TeacherID = copyMajorTeacherBO.TeacherID;
            this.SpecialMajorFlag = copyMajorTeacherBO.SpecialMajorFlag;
            this.LastChangeID = copyMajorTeacherBO.LastChangeID;
            this.LastChangeDate = copyMajorTeacherBO.LastChangeDate;
            this.LastChangeTime = copyMajorTeacherBO.LastChangeTime;

            try
            {
                this.relMajor = relMajor.Clone();
                this.relTeacher = relTeacher.Clone();
            }
            catch (Exception) { }
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            MajorTeacherDA tmpMajorTeacherDA = new MajorTeacherDA(this);
            return tmpMajorTeacherDA.Add();
        }

        public bool Delete()
        {
            MajorTeacherDA tmpMajorTeacherDA = new MajorTeacherDA(this);
            return tmpMajorTeacherDA.Delete();
        }

        public bool Update()
        {
            MajorTeacherDA tmpMajorTeacherDA = new MajorTeacherDA(this);
            return tmpMajorTeacherDA.Update();
        }

        public static List<MajorTeacherBO> List()
        {
            return MajorTeacherDA.List();
        }
        public static List<MajorTeacherBO> List(bool? specialMajorFlag)
        {
            return MajorTeacherDA.List(specialMajorFlag);
        }

        public static List<MajorTeacherBO> List(int? majorID, string teacherID, bool? specialMajorFlag)
        {
            return MajorTeacherDA.List(majorID, teacherID, specialMajorFlag);
        }

        public static MajorTeacherBO Find(int majorID, string teacherID)
        {
            return MajorTeacherDA.Find(majorID, teacherID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.MajorID.Name)
                    return MajorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.SpecialMajorFlag.Name)
                    return UtilityTxt.GetString(SpecialMajorFlag);
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.MajorTeacher.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Major.MajorName)
                    return RelMajor.MajorName;
                if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName)
                    return RelTeacher.FullName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<MajorTeacherBO> Members
        public MajorTeacherBO Clone()
        {
            return new MajorTeacherBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (MajorTeacherBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MajorTeacherBO it1, MajorTeacherBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.MajorID == it2.MajorID && it1.TeacherID == it2.TeacherID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(MajorTeacherBO it1, MajorTeacherBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class DayBO : IBusinessObject, ICloner<DayBO>, IComboFillable, IGridValue
    {
        #region Variables

        public int DayID { get; set; }
        public string DayName { get; set; }
        #endregion

        public enum Day
        {
            Saturday = 0,
            Sunday,
            Monday,
            Thusday,
            Wednesday,
            Thursday,
            Friday
        }

        #region Constructors

        public DayBO()
        {
            // Nothing to do...
        }

        public DayBO(int dayID)
        {
            this.DayID = dayID;
        }

        // Copy Constructor.
        public DayBO(DayBO copyDayBO)
        {
            this.DayID = copyDayBO.DayID;
            this.DayName = copyDayBO.DayName;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            DayDA tmpDayDA = new DayDA(this);
            return tmpDayDA.Add();
        }

        public bool Delete()
        {
            DayDA tmpDayDA = new DayDA(this);
            return tmpDayDA.Delete();
        }

        public bool Update()
        {
            DayDA tmpDayDA = new DayDA(this);
            return tmpDayDA.Update();
        }

        public static List<DayBO> List()
        {
            return DayDA.List();
        }

        public static DayBO Find(int dayID)
        {
            return DayDA.Find(dayID);
        }
        #endregion

        public static DayBO GetDay(string dayName)
        {
            switch (dayName.Trim())
            {
                case "شنبه":
                    return DayBO.Find(0);

                case "یکشنبه":
                    return DayBO.Find(1);

                case "دوشنبه":
                    return DayBO.Find(2);

                case "سه‌شنبه":
                case "سه شنبه":
                case "ﺳﻪشنبه":
                    return DayBO.Find(3);

                case "چهار شنبه":
                case "چهارشنبه":
                case "چهار‌شنبه":
                    return DayBO.Find(4);

                case "پنجشنبه":
                    return DayBO.Find(5);

                case "جمعه":
                    return DayBO.Find(6);

                default:
                    return null;
            }
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Day.DayID.Name)
                    return DayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Day.DayName.Name)
                    return DayName.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return DayName; }
        }

        public string ComboDescription
        {
            get { return DayName; }
        }
        #endregion
        #region ICloner<DayBO> Members
        public DayBO Clone()
        {
            return new DayBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (DayBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(DayBO it1, DayBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.DayID == it2.DayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(DayBO it1, DayBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class TimeBO : IBusinessObject, ICloner<TimeBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int TimeID { get; set; }
        public int StartHour { get; set; }
        public int StartMin { get; set; }
        public int FinishHour { get; set; }
        public int FinishMin { get; set; }
        public bool Activitystatuse { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public TimeBO()
        {
            // Nothing to do...
        }

        public TimeBO(int timeID)
        {
            this.TimeID = timeID;
        }

        // Copy Constructor.
        public TimeBO(TimeBO copyTimeBO)
        {
            this.TimeID = copyTimeBO.TimeID;
            this.StartHour = copyTimeBO.StartHour;
            this.StartMin = copyTimeBO.StartMin;
            this.FinishHour = copyTimeBO.FinishHour;
            this.FinishMin = copyTimeBO.FinishMin;
            this.Activitystatuse = copyTimeBO.Activitystatuse;
            this.LastChangeID = copyTimeBO.LastChangeID;
            this.LastChangeDate = copyTimeBO.LastChangeDate;
            this.LastChangeTime = copyTimeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            TimeDA tmpTimeDA = new TimeDA(this);
            return tmpTimeDA.Add();
        }

        public bool Delete()
        {
            TimeDA tmpTimeDA = new TimeDA(this);
            return tmpTimeDA.Delete();
        }

        public bool Update()
        {
            TimeDA tmpTimeDA = new TimeDA(this);
            return tmpTimeDA.Update();
        }

        public static List<TimeBO> List()
        {
            return TimeDA.List();
        }
        public static List<TimeBO> List(bool? activitystatuse)
        {
            return TimeDA.List(activitystatuse);
        }

        public static TimeBO Find(int startHour, int startMin, int finishHour, int finishMin)
        {
            return TimeDA.Find(startHour, startMin, finishHour, finishMin);
        }

        public static TimeBO Find(int timeID)
        {
            return TimeDA.Find(timeID);
        }
        #endregion

        public TimeSpan TimeSpan
        {
            get
            {
                DateTime start = new DateTime(2000, 1, 1, StartHour, StartMin, 0);
                DateTime finish = new DateTime(2000, 1, 1, FinishHour, FinishMin, 0);
                TimeSpan t = finish - start;
                return t;
            }
        }

        public string TimeSpanString()
        {
            return TimeSpan.Hours.ToString() + ":" + TimeSpan.Minutes.ToString();
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Time.TimeID.Name)
                    return TimeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.StartHour.Name)
                    return StartHour.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.StartMin.Name)
                    return StartMin.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.FinishHour.Name)
                    return FinishHour.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.FinishMin.Name)
                    return FinishMin.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.Activitystatuse.Name)
                    return Activitystatuse.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.TimeName.Name)
                    return ToString();
                if (columnDefinition.Name == DatabaseSchema.Time.Duration.Name)
                    return UtilityTxt.To3Digit(((FinishHour - StartHour) * 60 + (FinishMin - StartMin)));

            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return ToString(); }
        }

        public string ComboDescription
        {
            get { return ToString(); }
        }
        #endregion
        #region ICloner<TimeBO> Members
        public TimeBO Clone()
        {
            return new TimeBO(this);
        }
        #endregion
        #endregion

        public override string ToString()
        {
            return string.Format("{0}:{1} " + "تا" + " {2}:{3}", StartHour, StartMin, FinishHour, FinishMin);
        }

        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (TimeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(TimeBO it1, TimeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.TimeID == it2.TimeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(TimeBO it1, TimeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

        public static List<TimeBO> CreateTimeInterval(int startHour, int startMin, int finishHour, int finishMin, int duration, int gap)
        {
            PersianDate date = new PersianDate(1386, 2, 2, startHour, startMin);
            PersianCalendar c = new PersianCalendar();

            List<TimeBO> ans = new List<TimeBO>();

            while (date.Hour <= finishHour || (date.Hour == finishHour && date.Minute <= finishMin))
            {
                TimeBO time = new TimeBO();
                time.StartHour = date.Hour;
                time.StartMin = date.Minute;

                date = c.AddMinutes(date, duration);

                time.FinishHour = date.Hour;
                time.FinishMin = date.Minute;

                if (date.Hour <= finishHour || (date.Hour == finishHour && date.Minute <= finishMin))
                    ans.Add(time);
                else
                    break;

                date = c.AddMinutes(date, gap);
            }
            return ans;
        }
    }

    // Generated by DVD CodeGenerator
    public partial class TeacherTimeBO : IBusinessObject, ICloner<TeacherTimeBO>, ILastChange, IGridValue
    {
        #region Variables

        public string TeacherID { get; set; }
        public int TimeID { get; set; }
        public int DayID { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                    relTeacher = TeacherBO.Find(TeacherID);
                return relTeacher;
            }
            set { relTeacher = value; }
        }

        private TimeBO relTime;
        public TimeBO RelTime
        {
            get
            {
                if (relTime == null)
                    relTime = TimeBO.Find(TimeID);
                return relTime;
            }
            set { relTime = value; }
        }

        private DayBO relDay;
        public DayBO RelDay
        {
            get
            {
                if (relDay == null)
                    relDay = DayBO.Find(DayID);
                return relDay;
            }
            set { relDay = value; }
        }

        #region Constructors

        public TeacherTimeBO()
        {
            // Nothing to do...
        }

        public TeacherTimeBO(string teacherID, int timeID, int dayID)
        {
            this.TeacherID = teacherID;
            this.TimeID = timeID;
            this.DayID = dayID;
        }

        // Copy Constructor.
        public TeacherTimeBO(TeacherTimeBO copyTeacherTimeBO)
        {
            this.TeacherID = copyTeacherTimeBO.TeacherID;
            this.TimeID = copyTeacherTimeBO.TimeID;
            this.DayID = copyTeacherTimeBO.DayID;
            this.StartDate = copyTeacherTimeBO.StartDate;
            this.FinishDate = copyTeacherTimeBO.FinishDate;
            this.LastChangeID = copyTeacherTimeBO.LastChangeID;
            this.LastChangeDate = copyTeacherTimeBO.LastChangeDate;
            this.LastChangeTime = copyTeacherTimeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            TeacherTimeDA tmpTeacherTimeDA = new TeacherTimeDA(this);
            return tmpTeacherTimeDA.Add();
        }

        public bool Delete()
        {
            TeacherTimeDA tmpTeacherTimeDA = new TeacherTimeDA(this);
            return tmpTeacherTimeDA.Delete();
        }

        public bool Update()
        {
            TeacherTimeDA tmpTeacherTimeDA = new TeacherTimeDA(this);
            return tmpTeacherTimeDA.Update();
        }

        public static List<TeacherTimeBO> List()
        {
            return TeacherTimeDA.List();
        }
        public static List<TeacherTimeBO> List(int? dayID)
        {
            return TeacherTimeDA.List(dayID);
        }
        public static List<TeacherTimeBO> List(string teacherID)
        {
            return TeacherTimeDA.List(teacherID);
        }

        public static TeacherTimeBO Find(string teacherID, int timeID, int dayID)
        {
            return TeacherTimeDA.Find(teacherID, timeID, dayID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.TimeID.Name)
                    return RelTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.DayID.Name)
                    return DayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.StartDate.Name)
                    return StartDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.FinishDate.Name)
                    return FinishDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.TeacherTime.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName.Name)
                    return RelTeacher.FullName;
                if (columnDefinition.Name == DatabaseSchema.Day.DayName.Name)
                    return RelDay.DayName;


            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<TeacherTimeBO> Members
        public TeacherTimeBO Clone()
        {
            return new TeacherTimeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (TeacherTimeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(TeacherTimeBO it1, TeacherTimeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.TeacherID == it2.TeacherID && it1.TimeID == it2.TimeID && it1.DayID == it2.DayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(TeacherTimeBO it1, TeacherTimeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    //public partial class ClassBOOld : IBusinessObject, ICloner<ClassBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int ClassID { get; set; }
    //    public string ClassName { get; set; }
    //    public int MajorID { get; set; }
    //    public string TeacherID { get; set; }
    //    public int Price { get; set; }
    //    public int SchoolPrice { get; set; }
    //    public int SessionCount { get; set; }
    //    public string ClassDescription { get; set; }
    //    public bool GroupFlag { get; set; }
    //    public string RegistrationExpireDate { get; set; }
    //    public bool ActivityStatus { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    public int ContractTypeID { get; set; }
    //    public int ContractValue { get; set; }
    //    #endregion

    //    private TeacherBO relTeacher;
    //    public TeacherBO RelTeacher
    //    {
    //        get
    //        {
    //            if (relTeacher == null)
    //                relTeacher = TeacherBO.Find(TeacherID);
    //            return relTeacher;
    //        }
    //        set { relTeacher = value; }
    //    }

    //    private MajorBO relMajor;
    //    public MajorBO RelMajor
    //    {
    //        get
    //        {
    //            if (relMajor == null)
    //                relMajor = MajorBO.Find(MajorID);
    //            return relMajor;
    //        }
    //        set { relMajor = value; }
    //    }

    //    #region Constructors

    //    public ClassBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public ClassBO(int classID)
    //    {
    //        this.ClassID = classID;
    //    }

    //    // Copy Constructor.
    //    public ClassBO(ClassBO copyClassBO)
    //    {
    //        this.ClassID = copyClassBO.ClassID;
    //        this.ClassName = copyClassBO.ClassName;
    //        this.MajorID = copyClassBO.MajorID;
    //        this.TeacherID = copyClassBO.TeacherID;
    //        this.Price = copyClassBO.Price;
    //        this.SchoolPrice = copyClassBO.SchoolPrice;
    //        this.SessionCount = copyClassBO.SessionCount;
    //        this.ClassDescription = copyClassBO.ClassDescription;
    //        this.GroupFlag = copyClassBO.GroupFlag;
    //        this.RegistrationExpireDate = copyClassBO.RegistrationExpireDate;
    //        this.ActivityStatus = copyClassBO.ActivityStatus;
    //        this.LastChangeID = copyClassBO.LastChangeID;
    //        this.LastChangeDate = copyClassBO.LastChangeDate;
    //        this.LastChangeTime = copyClassBO.LastChangeTime;
    //        this.ContractTypeID = copyClassBO.ContractTypeID;
    //        this.ContractValue = copyClassBO.ContractValue;
    //    }
    //    #endregion

    //    public int GetTeacherSessionPrice()
    //    {
    //        switch (ContractTypeID)
    //        {
    //            case 1:
    //                return ContractValue / SessionCount;

    //            case 2:
    //                return (ContractValue / 100) * SchoolPrice / SessionCount;

    //            default:
    //                return 0;
    //        }
    //    }


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        ClassDA tmpClassDA = new ClassDA(this);
    //        return tmpClassDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        ClassDA tmpClassDA = new ClassDA(this);
    //        return tmpClassDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        ClassDA tmpClassDA = new ClassDA(this);
    //        return tmpClassDA.Update();
    //    }

    //    public static List<ClassBO> List()
    //    {
    //        return ClassDA.List();
    //    }
    //    public static List<ClassBO> List(int? majorID, string teacherID, bool? activityStatus, bool? groupFlag)
    //    {
    //        return ClassDA.List(majorID, teacherID, activityStatus, groupFlag);
    //    }

    //    public static ClassBO Find(int classID)
    //    {
    //        return ClassDA.Find(classID);
    //    }
    //    #endregion

    //    public static string GenerateKey(int Year, int Season)
    //    {
    //        string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
    //        List<string> keys = ClassDA.GetKeyPattern(firstPart);
    //        for (int i = 1; i < 1000; i++)
    //        {
    //            string candidKey = firstPart + UtilityTxt.To3Digit(i);
    //            bool found = false;
    //            foreach (string key in keys)
    //            {
    //                if (key.Trim() == candidKey)
    //                {
    //                    found = true;
    //                    break;
    //                }
    //            }
    //            if (!found)
    //            {
    //                return candidKey;
    //            }
    //        }
    //        return "0000000";
    //    }

    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.Class.ClassID.Name)
    //                return ClassID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
    //                return ClassName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.MajorID.Name)
    //                return MajorID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.TeacherID.Name)
    //                return TeacherID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.Price.Name)
    //                return Price.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.SchoolPrice.Name)
    //                return SchoolPrice.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.SessionCount.Name)
    //                return SessionCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.ClassDescription.Name)
    //                return ClassDescription.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.GroupFlag.Name)
    //                return GroupFlag.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.RegistrationExpireDate.Name)
    //                return RegistrationExpireDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.ActivityStatus.Name)
    //                return ActivityStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.ContractTypeID.Name)
    //                return ContractTypeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Class.ContractValue.Name)
    //                return ContractValue.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<ClassBO> Members
    //    public ClassBO Clone()
    //    {
    //        return new ClassBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (ClassBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(ClassBO it1, ClassBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.ClassID == it2.ClassID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(ClassBO it1, ClassBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}


    // Generated by DVD CodeGenerator

    // Generated by DVD CodeGenerator
    public partial class ClassBO : IBusinessObject, ICloner<ClassBO>, ILastChange, IGridValue, IActivityManager<ClassBO>
    {
        #region Variables

        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int MajorID { get; set; }
        public string TeacherID { get; set; }
        public int Price { get; set; }
        public int SchoolPrice { get; set; }
        public int SessionCount { get; set; }
        public string ClassDescription { get; set; }
        public bool GroupFlag { get; set; }
        public string RegistrationExpireDate { get; set; }
        public bool ActivityStatus { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public int ContractTypeID { get; set; }
        public int ContractValue { get; set; }
        public bool IsBalancedFinalWithTeacher { get; set; }
        #endregion

        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                    relTeacher = TeacherBO.Find(TeacherID);
                return relTeacher;
            }
            set { relTeacher = value; }
        }

        private MajorBO relMajor;
        public MajorBO RelMajor
        {
            get
            {
                if (relMajor == null)
                    relMajor = MajorBO.Find(MajorID);
                return relMajor;
            }
            set { relMajor = value; }
        }

        #region Constructors

        public ClassBO()
        {
            // Nothing to do...
        }

        public ClassBO(int classID)
        {
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ClassBO(ClassBO copyClassBO)
        {
            this.ClassID = copyClassBO.ClassID;
            this.ClassName = copyClassBO.ClassName;
            this.MajorID = copyClassBO.MajorID;
            this.TeacherID = copyClassBO.TeacherID;
            this.Price = copyClassBO.Price;
            this.SchoolPrice = copyClassBO.SchoolPrice;
            this.SessionCount = copyClassBO.SessionCount;
            this.ClassDescription = copyClassBO.ClassDescription;
            this.GroupFlag = copyClassBO.GroupFlag;
            this.RegistrationExpireDate = copyClassBO.RegistrationExpireDate;
            this.ActivityStatus = copyClassBO.ActivityStatus;
            this.LastChangeID = copyClassBO.LastChangeID;
            this.LastChangeDate = copyClassBO.LastChangeDate;
            this.LastChangeTime = copyClassBO.LastChangeTime;
            this.ContractTypeID = copyClassBO.ContractTypeID;
            this.ContractValue = copyClassBO.ContractValue;
            this.IsBalancedFinalWithTeacher = copyClassBO.IsBalancedFinalWithTeacher;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ClassDA tmpClassDA = new ClassDA(this);
            return tmpClassDA.Add();
        }

        public bool Delete()
        {
            ClassDA tmpClassDA = new ClassDA(this);
            return tmpClassDA.Delete();
        }

        public bool Update()
        {
            ClassDA tmpClassDA = new ClassDA(this);
            return tmpClassDA.Update();
        }

        public static List<ClassBO> List(int? majorID, string teacherID, bool? groupFlag, bool? activityStatus, bool? isBalancedFinalWithTeacher)
        {
            return ClassDA.List(majorID, teacherID, groupFlag, activityStatus, isBalancedFinalWithTeacher);
        }
        public static List<ClassBO> List()
        {
            return ClassDA.List();
        }

        public static ClassBO Find(int classID)
        {
            return ClassDA.Find(classID);
        }
        #endregion

        public static List<ClassBO> ListClassesOfStudent(string studentID, bool? activityStatus)
        {
            return ClassDA.ListClassesOfStudent(studentID, activityStatus);
        }

        public static List<ClassBO> ListClassesOfTeacher(string teacherID, bool? activityStatus)
        {
            return ClassDA.ListClassesOfTeacher(teacherID, activityStatus);
        }

        public int GetTeacherSessionPrice()
        {
            switch (ContractTypeID)
            {
                case 1:
                    return ContractValue / SessionCount;

                case 2:
                    return (ContractValue / 100) * SchoolPrice / SessionCount;

                default:
                    return 0;
            }
        }

        public static string GenerateKey(int Year, int Season)
        {
            string firstPart = UtilityTxt.To2Digit(Year) + UtilityTxt.To2Digit(Season);
            List<string> keys = ClassDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + UtilityTxt.To3Digit(i);
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000";
        }

        public bool SetTeacherBalance(bool isBalanced)
        {
            return new ClassDA(this).SetTeacherBalance(isBalanced);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Class.ClassID.Name)
                    return ClassID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
                    return ClassName.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.ClassDescription.Name)
                    return ClassDescription.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.MajorID.Name)
                    return MajorID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName.Name)
                    return RelTeacher.FullName;
                else if (columnDefinition.Name == DatabaseSchema.Class.TeacherID.Name)
                    return TeacherID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.Price.Name)
                    return Price.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.SchoolPrice.Name)
                    return SchoolPrice.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.SessionCount.Name)
                    return SessionCount.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.GroupFlag.Name)
                    return GroupFlag.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.RegistrationExpireDate.Name)
                    return RegistrationExpireDate.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.ActivityStatus.Name)
                    return ActivityStatus ? "فعال" : "غیرفعال";
                else if (columnDefinition.Name == DatabaseSchema.Class.LastChangeID.Name)
                    return LastChangeID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.ContractTypeID.Name)
                    return ContractTypeID.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.ContractValue.Name)
                    return ContractValue.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Class.IsBalancedFinalWithTeacher.Name)
                    return IsBalancedFinalWithTeacher.ToString();
                else if (columnDefinition.Name == DatabaseSchema.Major.MajorName.Name)
                    return RelMajor.MajorName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ClassBO> Members
        public ClassBO Clone()
        {
            return new ClassBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ClassBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ClassBO it1, ClassBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ClassBO it1, ClassBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

        #region IActivityManager<ClassBO> Members

        public List<ClassBO> List(bool? activityStatus)
        {
            return ClassDA.List(null, null, null, activityStatus, null);
        }

        public List<ClassBO> ListDeactiveCandidates()
        {
            return ClassDA.ListDeactiveCandidates(null);
        }

        #endregion

        #region IActivityStatus Members

        public bool SetStatus(bool newStatus)
        {
            bool result = true;
            ActivitySetter setter = new ActivitySetter("Class", "activityStatus", new List<ActivitySetter.KeyInfo>
            {
                new ActivitySetter.KeyInfo("ClassID", ClassID.ToString())
            });
            result &= setter.SetStatus(newStatus);

            // Setting Registerations...
            List<RegistrationBO> regs = RegistrationBO.List(ClassID, null, !newStatus, null);
            foreach (RegistrationBO reg in regs)
            {
                ActivitySetter regSetter = new ActivitySetter("registration", "activityStatus", new List<ActivitySetter.KeyInfo>
                {
                    new ActivitySetter.KeyInfo("ClassID", reg.ClassID.ToString()),
                    new ActivitySetter.KeyInfo("StudentID", reg.StudentID)
                });
                result &= regSetter.SetStatus(newStatus);
            }
            return result;
        }

        public string StatusDescription
        {
            get
            {
                string ans = "";
                if (IsDeactiveCandidate())
                    ans = "این کلاس برای غیرفعال‌سازی پیشنهاد می‌شود.";
                else if (ActivityStatus)
                    ans = "کلاس فعال است.";
                else
                    ans = "کلاس غیرفعال است.";

                AdditionalInformation = "";
                if (IsBalancedFinalWithTeacher)
                    AdditionalInformation += "با استاد تسویه حساب شده‌است." + "\n";
                else
                    AdditionalInformation += "هنوز با استاد تسویه حساب نشده‌است." + "\n";

                List<RegistrationBO> regList = RegistrationBO.List(ClassID, null, null, null);
                int totalStuds = regList.Count;
                int balancedStuds = regList.Where(reg => reg.IsBalancedFinalWithStudent).Count();

                AdditionalInformation += "\n" + "تعداد " + balancedStuds.ToString() + " هنرجو از " + totalStuds.ToString() + " هنرجو تسویه حساب کرده‌اند.";

                List<ClasssessionBO> sessionList = ClasssessionBO.List(ClassID);


                AdditionalInformation += "\n" + "تعداد " + sessionList.Where(ses => ses.SessionStatus != (int)SessionStatus.SessionStatusType.WillHold).Count().ToString() + " جلسه از " + SessionCount.ToString() + " جلسه گذشته است.";

                return ans;


            }
        }

        public string AdditionalInformation
        {
            get;
            set;
        }

        public bool IsDeactiveCandidate()
        {
            if (ClassDA.ListDeactiveCandidates(ClassID).Count == 0)
                return false;
            else
                return true;
        }

        public List<ColumnDefinition> StatusInfoColumns
        {
            get
            {
                return new List<ColumnDefinition>()
                {
                    DatabaseSchema.Class.ClassID,
                    DatabaseSchema.Class.ClassName,
                };
            }
        }

        public string CaseName
        {
            get { return "کلاس"; }
        }

        public string CaseNameI
        {
            get { return "کلاسی"; }
        }

        public string DeactiveRule
        {
            get { return "کلاس‌های که جلسات آن تمام شده است و با استاد و هنرجویان مربوط به کلاس تسویه‌حساب شده است."; }
        }

        #endregion
    }

    public partial class RoomsBO : IBusinessObject, ICloner<RoomsBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int RoomNo { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public RoomsBO()
        {
            // Nothing to do...
        }

        public RoomsBO(int roomNo)
        {
            this.RoomNo = roomNo;
        }

        // Copy Constructor.
        public RoomsBO(RoomsBO copyRoomsBO)
        {
            this.RoomNo = copyRoomsBO.RoomNo;
            this.RoomName = copyRoomsBO.RoomName;
            this.RoomDescription = copyRoomsBO.RoomDescription;
            this.LastChangeID = copyRoomsBO.LastChangeID;
            this.LastChangeDate = copyRoomsBO.LastChangeDate;
            this.LastChangeTime = copyRoomsBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            RoomsDA tmpRoomsDA = new RoomsDA(this);
            return tmpRoomsDA.Add();
        }

        public bool Delete()
        {
            RoomsDA tmpRoomsDA = new RoomsDA(this);
            return tmpRoomsDA.Delete();
        }

        public bool Update()
        {
            RoomsDA tmpRoomsDA = new RoomsDA(this);
            return tmpRoomsDA.Update();
        }

        public static List<RoomsBO> List()
        {
            return RoomsDA.List();
        }

        public static RoomsBO Find(int roomNo)
        {
            return RoomsDA.Find(roomNo);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Rooms.RoomNo.Name)
                    return RoomNo.ToString();
                if (columnDefinition.Name == DatabaseSchema.Rooms.RoomName.Name)
                    return RoomName.ToString();
                if (columnDefinition.Name == DatabaseSchema.Rooms.RoomDescription.Name)
                    return RoomDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.Rooms.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Rooms.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Rooms.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return RoomName; }
        }

        public string ComboDescription
        {
            get { return RoomDescription; }
        }
        #endregion
        #region ICloner<RoomsBO> Members
        public RoomsBO Clone()
        {
            return new RoomsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (RoomsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(RoomsBO it1, RoomsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.RoomNo == it2.RoomNo;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(RoomsBO it1, RoomsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ClasssessionBO : IBusinessObject, ICloner<ClasssessionBO>, ILastChange, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string ClassDate { get; set; }
        public int TimeID { get; set; }
        public bool StudentAbsence { get; set; }
        public bool TeacherAbsence { get; set; }
        public bool ContinuousAbsence { get; set; }
        //public int DayID { get; set; }
        public int SessionStatus { get; set; }
        public int? RoomNo { get; set; }
        public string SuccessorTeacher { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private TeacherBO relSuccessorTeacher;
        public TeacherBO RelSuccessorTeacher
        {
            get
            {
                if (relSuccessorTeacher == null)
                    relSuccessorTeacher = TeacherBO.Find(SuccessorTeacher);
                if (relSuccessorTeacher == null) return new TeacherBO();
                return relSuccessorTeacher;
            }
            set { relSuccessorTeacher = value; }
        }

        private TimeBO relTime;
        public TimeBO RelTime
        {
            get
            {
                if (relTime == null)
                    relTime = TimeBO.Find(TimeID);
                return relTime;
            }
            set { relTime = value; }
        }

        private DayBO relDay;
        public DayBO RelDay
        {
            get
            {
                if (relDay == null)
                {
                    PersianDate date = new PersianDate(ClassDate);
                    return DayBO.GetDay(date.LocalizedWeekDayName);
                }
                return relDay;
            }
            set { relDay = value; }
        }

        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                {
                    List<RegistrationBO> regs = RegistrationBO.List(ClassID, null, null, null);
                    relStudent = regs[0].RelStudent;
                }
                return relStudent;
            }
        }

        private ViwStudentSessionStatusBO relViwStudentSessionStatusBO;
        private ViwStudentSessionStatusBO RelViwStudentSessionStatusBO
        {
            get
            {
                if (relViwStudentSessionStatusBO == null)
                    relViwStudentSessionStatusBO = ViwStudentSessionStatusBO.Find(RelStudent.StudentID, ClassID);
                return relViwStudentSessionStatusBO;
            }
        }

        private ViwStudentFinancialStatusBO relViwStudentFinancialStatus;
        public ViwStudentFinancialStatusBO RelViwStudentFinancialStatus
        {
            get
            {
                if (relViwStudentFinancialStatus == null)
                    relViwStudentFinancialStatus = ViwStudentFinancialStatusBO.Find(ClassID, RelStudent.StudentID);
                return relViwStudentFinancialStatus;
            }
        }

        #region Constructors

        public ClasssessionBO()
        {
            // Nothing to do...
        }

        public ClasssessionBO(int classID, string classDate, int timeID)
        {
            this.ClassID = classID;
            this.ClassDate = classDate;
            this.TimeID = timeID;
        }

        // Copy Constructor.
        public ClasssessionBO(ClasssessionBO copyClasssessionBO)
        {
            this.ClassID = copyClasssessionBO.ClassID;
            this.ClassDate = copyClasssessionBO.ClassDate;
            this.TimeID = copyClasssessionBO.TimeID;
            this.StudentAbsence = copyClasssessionBO.StudentAbsence;
            this.TeacherAbsence = copyClasssessionBO.TeacherAbsence;
            this.SessionStatus = copyClasssessionBO.SessionStatus;
            this.ContinuousAbsence = copyClasssessionBO.ContinuousAbsence;
            this.RoomNo = copyClasssessionBO.RoomNo;
            this.SuccessorTeacher = copyClasssessionBO.SuccessorTeacher;
            this.LastChangeID = copyClasssessionBO.LastChangeID;
            this.LastChangeDate = copyClasssessionBO.LastChangeDate;
            this.LastChangeTime = copyClasssessionBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ClasssessionDA tmpClasssessionDA = new ClasssessionDA(this);
            return tmpClasssessionDA.Add();
        }

        public bool Delete()
        {
            ClasssessionDA tmpClasssessionDA = new ClasssessionDA(this);
            return tmpClasssessionDA.Delete();
        }

        public bool Update()
        {
            ClasssessionDA tmpClasssessionDA = new ClasssessionDA(this);
            return tmpClasssessionDA.Update();
        }

        public static List<ClasssessionBO> List()
        {
            return ClasssessionDA.List();
        }
        public static List<ClasssessionBO> List(int? timeID, int? dayID, int? sessionStatus, int? roomNo)
        {
            return ClasssessionDA.List(timeID, dayID, sessionStatus, roomNo);
        }

        public static List<ClasssessionBO> List(int? classID)
        {
            return ClasssessionDA.List(classID);
        }

        public static List<ClasssessionBO> ListSessions(string dateFrom, string dateTo)
        {
            return ClasssessionDA.ListSessions(dateFrom, dateTo);
        }

        public static ClasssessionBO Find(int classID, string classDate, int timeID)
        {
            return ClasssessionDA.Find(classID, classDate, timeID);
        }
        #endregion

        public static List<ClasssessionBO> CreateWeeklySchedule(ClassBO classObj, TimeBO timeObj, DayBO dayObj, int weekCount, string startDate)
        {
            PersianDate date = new PersianDate(startDate);
            DayBO day = DayBO.GetDay(date.LocalizedWeekDayName);
            PersianCalendar c = new PersianCalendar();
            while (day != dayObj)
            {
                date = c.AddDays(date, 1);
                day = DayBO.GetDay(date.LocalizedWeekDayName);
            }

            List<ClasssessionBO> ans = new List<ClasssessionBO>();
            for (int i = 0; i < weekCount; i++)
            {
                ClasssessionBO session = new ClasssessionBO();
                session.ClassID = classObj.ClassID;
                session.ClassDate = date.ToString().Substring(0, 10);
                session.SessionStatus = (int)BusinessObjectNamespace.SessionStatus.SessionStatusType.WillHold;
                session.StudentAbsence = false;
                session.SuccessorTeacher = null;
                session.TeacherAbsence = false;
                session.ContinuousAbsence = false;
                session.TimeID = timeObj.TimeID;

                ans.Add(session);
                date = c.AddDays(date, 7);
            }
            return ans;


        }

        public override string ToString()
        {
            return ClassDate + " " + RelTime.ToString();
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Classsession.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.ClassDate.Name)
                    return ClassDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.TimeID.Name)
                    return RelTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Day.DayName.Name)
                    return RelDay.DayName;
                if (columnDefinition.Name == DatabaseSchema.Classsession.StudentAbsence.Name)
                    return StudentAbsence.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.TeacherAbsence.Name)
                    return TeacherAbsence.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.SessionStatus.Name)
                    return new SessionStatus(SessionStatus).ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.RoomNo.Name)
                    return RoomNo.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.SuccessorTeacher.Name)
                    return RelSuccessorTeacher.FullName;
                if (columnDefinition.Name == DatabaseSchema.Classsession.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Classsession.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName)
                    return RelSuccessorTeacher.FullName;
                if (columnDefinition.Name == DatabaseSchema.Day.DayName)
                    return new PersianDate(ClassDate).LocalizedWeekDayName;
                if (columnDefinition.Name == DatabaseSchema.Class.ClassName)
                    return RelClass.ClassName;
                if (columnDefinition.Name == DatabaseSchema.Major.MajorName)
                    return RelClass.RelMajor.MajorName;

                if (columnDefinition.Name == DatabaseSchema.Student.LastName)
                {
                    if (RelStudent != null)
                    {
                        return RelStudent.FullName;
                    }
                    return "";
                }
                if (columnDefinition.Name == DatabaseSchema.Classsession.RemainedSessions)
                {
                    //var cls = ViwClassHoldDetailsBO.Find(ClassID);
                    //return (RelClass.SessionCount - cls.HeldCount - cls.SuspendedDueNotificationCount -
                    //       cls.SuspendedDueStudentCount - cls.SuspendendDueTeacherCount).ToString();

                    if (RelStudent != null)
                    {
                        //ViwStudentSessionStatusBO sessions = ViwStudentSessionStatusBO.Find(RelStudent.StudentID, ClassID);
                        return (RelViwStudentSessionStatusBO.WillHeldCount ?? 0).ToString();
                    }
                }
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay)
                {
                    if (RelStudent != null)
                    {
                        return (RelViwStudentFinancialStatus.StudentMustPay).ToString();
                    }
                }
                if (columnDefinition.Name == DatabaseSchema.Student.TellHome)
                {
                    if (RelStudent != null)
                    {
                        return (RelStudent.TellHome).ToString();
                    }
                }

            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ClasssessionBO> Members
        public ClasssessionBO Clone()
        {
            return new ClasssessionBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ClasssessionBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ClasssessionBO it1, ClasssessionBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.ClassDate == it2.ClassDate && it1.TimeID == it2.TimeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ClasssessionBO it1, ClasssessionBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    //public partial class OutcomeTypicalBO : IBusinessObject, ICloner<OutcomeTypicalBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int PayID { get; set; }
    //    public int OutcomeTypicalTypeID { get; set; }
    //    public int Fee { get; set; }
    //    public int? Discount { get; set; }
    //    public string PayDate { get; set; }
    //    public string CheckDate { get; set; }
    //    public string Tag { get; set; }
    //    public string Description { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    #endregion

    //    private string relTagName = null;

    //    public string RelTagName
    //    {
    //        get
    //        {
    //            if (relTagName == null)
    //            {
    //                OutcomeTypicalTypeBO.OutcomeTypicalType type = (OutcomeTypicalTypeBO.OutcomeTypicalType)OutcomeTypicalTypeID;
    //                relTagName = "";
    //                try
    //                {
    //                    switch (type)
    //                    {
    //                        case OutcomeTypicalTypeBO.OutcomeTypicalType.EmployeeSalary:
    //                            EmployeeBO emp = EmployeeBO.Find(Tag);
    //                            relTagName = emp.FullName;
    //                            break;

    //                        case OutcomeTypicalTypeBO.OutcomeTypicalType.Student:
    //                            StudentBO stud = StudentBO.Find(Tag);
    //                            relTagName = stud.FullName;
    //                            break;

    //                        case OutcomeTypicalTypeBO.OutcomeTypicalType.TeacherSalary:
    //                            TeacherBO teacher = TeacherBO.Find(Tag);
    //                            relTagName = teacher.FullName;
    //                            break;

    //                        default:
    //                            relTagName = "نامعلوم";
    //                            break;
    //                    }
    //                }
    //                catch (NullReferenceException) { }
    //            }
    //            return relTagName;
    //        }
    //    }

    //    #region Constructors

    //    public OutcomeTypicalBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public OutcomeTypicalBO(int payID)
    //    {
    //        this.PayID = payID;
    //    }

    //    // Copy Constructor.
    //    public OutcomeTypicalBO(OutcomeTypicalBO copyOutcomeTypicalBO)
    //    {
    //        this.PayID = copyOutcomeTypicalBO.PayID;
    //        this.OutcomeTypicalTypeID = copyOutcomeTypicalBO.OutcomeTypicalTypeID;
    //        this.Fee = copyOutcomeTypicalBO.Fee;
    //        this.Discount = copyOutcomeTypicalBO.Discount;
    //        this.PayDate = copyOutcomeTypicalBO.PayDate;
    //        this.CheckDate = copyOutcomeTypicalBO.CheckDate;
    //        this.Tag = copyOutcomeTypicalBO.Tag;
    //        this.Description = copyOutcomeTypicalBO.Description;
    //        this.LastChangeID = copyOutcomeTypicalBO.LastChangeID;
    //        this.LastChangeDate = copyOutcomeTypicalBO.LastChangeDate;
    //        this.LastChangeTime = copyOutcomeTypicalBO.LastChangeTime;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
    //        return tmpOutcomeTypicalDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
    //        return tmpOutcomeTypicalDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
    //        return tmpOutcomeTypicalDA.Update();
    //    }

    //    public static List<OutcomeTypicalBO> List()
    //    {
    //        return OutcomeTypicalDA.List();
    //    }
    //    public static List<OutcomeTypicalBO> List(int? outcomeTypicalTypeID, string payDate, string checkDate)
    //    {
    //        return OutcomeTypicalDA.List(outcomeTypicalTypeID, payDate, checkDate);
    //    }
    //    public static List<OutcomeTypicalBO> List(int? outcomeTypicalTypeID, int? fee, int? discount)
    //    {
    //        return OutcomeTypicalDA.List(outcomeTypicalTypeID, fee, discount);
    //    }

    //    public static OutcomeTypicalBO Find(int payID)
    //    {
    //        return OutcomeTypicalDA.Find(payID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.PayID.Name)
    //                return PayID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.OutcomeTypicalTypeID.Name)
    //                return OutcomeTypicalTypeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Fee.Name)
    //                return Fee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Discount.Name)
    //                return Discount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.PayDate.Name)
    //                return PayDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.CheckDate.Name)
    //                return CheckDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Tag.Name)
    //                return Tag.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Description.Name)
    //                return Description.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<OutcomeTypicalBO> Members
    //    public OutcomeTypicalBO Clone()
    //    {
    //        return new OutcomeTypicalBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (OutcomeTypicalBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(OutcomeTypicalBO it1, OutcomeTypicalBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.PayID == it2.PayID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(OutcomeTypicalBO it1, OutcomeTypicalBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class OutcomeTypicalBO : IBusinessObject, ICloner<OutcomeTypicalBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public int OutcomeTypicalTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public int PayTypeID { get; set; }
        public string CheckNumber { get; set; }
        #endregion


        #region Constructors

        public OutcomeTypicalBO()
        {
            // Nothing to do...
        }

        public OutcomeTypicalBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public OutcomeTypicalBO(OutcomeTypicalBO copyOutcomeTypicalBO)
        {
            this.PayID = copyOutcomeTypicalBO.PayID;
            this.OutcomeTypicalTypeID = copyOutcomeTypicalBO.OutcomeTypicalTypeID;
            this.Fee = copyOutcomeTypicalBO.Fee;
            this.Discount = copyOutcomeTypicalBO.Discount;
            this.PayDate = copyOutcomeTypicalBO.PayDate;
            this.CheckDate = copyOutcomeTypicalBO.CheckDate;
            this.Tag = copyOutcomeTypicalBO.Tag;
            this.Description = copyOutcomeTypicalBO.Description;
            this.LastChangeID = copyOutcomeTypicalBO.LastChangeID;
            this.LastChangeDate = copyOutcomeTypicalBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeTypicalBO.LastChangeTime;
            this.PayTypeID = copyOutcomeTypicalBO.PayTypeID;
            this.CheckNumber = copyOutcomeTypicalBO.CheckNumber;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
            return tmpOutcomeTypicalDA.Add();
        }

        public bool Delete()
        {
            OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
            return tmpOutcomeTypicalDA.Delete();
        }

        public bool Update()
        {
            OutcomeTypicalDA tmpOutcomeTypicalDA = new OutcomeTypicalDA(this);
            return tmpOutcomeTypicalDA.Update();
        }

        public static List<OutcomeTypicalBO> List(int? outcomeTypicalTypeID, string payDate, string checkDate, int? payTypeID, string checkNumber)
        {
            return OutcomeTypicalDA.List(outcomeTypicalTypeID, payDate, checkDate, payTypeID, checkNumber);
        }
        public static List<OutcomeTypicalBO> List()
        {
            return OutcomeTypicalDA.List();
        }

        public static OutcomeTypicalBO Find(int payID)
        {
            return OutcomeTypicalDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.OutcomeTypicalTypeID.Name)
                    return OutcomeTypicalTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Tag.Name)
                    return Tag.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypical.CheckNumber.Name)
                    return CheckNumber.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<OutcomeTypicalBO> Members
        public OutcomeTypicalBO Clone()
        {
            return new OutcomeTypicalBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeTypicalBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeTypicalBO it1, OutcomeTypicalBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeTypicalBO it1, OutcomeTypicalBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    // Generated by DVD CodeGenerator
    public partial class OutcomeTypicalTypeBO : IBusinessObject, ICloner<OutcomeTypicalTypeBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int OutcomeTypicalTypeID { get; set; }
        public string OutcomeTypicalTypeName { get; set; }
        public string OutcomeTypicalTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        public enum OutcomeTypicalType
        {
            TeacherSalary = 1,
            EmployeeSalary,
            Student,
            Others
        }

        #region Constructors

        public OutcomeTypicalTypeBO()
        {
            // Nothing to do...
        }

        public OutcomeTypicalTypeBO(int outcomeTypicalTypeID)
        {
            this.OutcomeTypicalTypeID = outcomeTypicalTypeID;
        }

        // Copy Constructor.
        public OutcomeTypicalTypeBO(OutcomeTypicalTypeBO copyOutcomeTypicalTypeBO)
        {
            this.OutcomeTypicalTypeID = copyOutcomeTypicalTypeBO.OutcomeTypicalTypeID;
            this.OutcomeTypicalTypeName = copyOutcomeTypicalTypeBO.OutcomeTypicalTypeName;
            this.OutcomeTypicalTypeDescription = copyOutcomeTypicalTypeBO.OutcomeTypicalTypeDescription;
            this.LastChangeID = copyOutcomeTypicalTypeBO.LastChangeID;
            this.LastChangeDate = copyOutcomeTypicalTypeBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeTypicalTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeTypicalTypeDA tmpOutcomeTypicalTypeDA = new OutcomeTypicalTypeDA(this);
            return tmpOutcomeTypicalTypeDA.Add();
        }

        public bool Delete()
        {
            OutcomeTypicalTypeDA tmpOutcomeTypicalTypeDA = new OutcomeTypicalTypeDA(this);
            return tmpOutcomeTypicalTypeDA.Delete();
        }

        public bool Update()
        {
            OutcomeTypicalTypeDA tmpOutcomeTypicalTypeDA = new OutcomeTypicalTypeDA(this);
            return tmpOutcomeTypicalTypeDA.Update();
        }

        public static List<OutcomeTypicalTypeBO> List()
        {
            return OutcomeTypicalTypeDA.List();
        }

        public static OutcomeTypicalTypeBO Find(int outcomeTypicalTypeID)
        {
            return OutcomeTypicalTypeDA.Find(outcomeTypicalTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeID.Name)
                    return OutcomeTypicalTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeName.Name)
                    return OutcomeTypicalTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeDescription.Name)
                    return OutcomeTypicalTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTypicalType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return OutcomeTypicalTypeName; }
        }

        public string ComboDescription
        {
            get { return OutcomeTypicalTypeDescription; }
        }
        #endregion
        #region ICloner<OutcomeTypicalTypeBO> Members
        public OutcomeTypicalTypeBO Clone()
        {
            return new OutcomeTypicalTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeTypicalTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeTypicalTypeBO it1, OutcomeTypicalTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.OutcomeTypicalTypeID == it2.OutcomeTypicalTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeTypicalTypeBO it1, OutcomeTypicalTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    //// Generated by DVD CodeGenerator
    //public partial class ViwOutcomeOveralBO : IBusinessObject, ICloner<ViwOutcomeOveralBO>, IGridValue
    //{
    //    #region Variables

    //    public int PayID { get; set; }
    //    public int? OutcomeOveralTypeID { get; set; }
    //    public int Fee { get; set; }
    //    public int? Discount { get; set; }
    //    public string PayDate { get; set; }
    //    public string CheckDate { get; set; }
    //    public string Description { get; set; }
    //    public string PayName { get; set; }
    //    #endregion


    //    #region Constructors

    //    public ViwOutcomeOveralBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public ViwOutcomeOveralBO(int payID)
    //    {
    //        this.PayID = payID;
    //    }

    //    // Copy Constructor.
    //    public ViwOutcomeOveralBO(ViwOutcomeOveralBO copyViwOutcomeOveralBO)
    //    {
    //        this.PayID = copyViwOutcomeOveralBO.PayID;
    //        this.OutcomeOveralTypeID = copyViwOutcomeOveralBO.OutcomeOveralTypeID;
    //        this.Fee = copyViwOutcomeOveralBO.Fee;
    //        this.Discount = copyViwOutcomeOveralBO.Discount;
    //        this.PayDate = copyViwOutcomeOveralBO.PayDate;
    //        this.CheckDate = copyViwOutcomeOveralBO.CheckDate;
    //        this.Description = copyViwOutcomeOveralBO.Description;
    //        this.PayName = copyViwOutcomeOveralBO.PayName;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
    //        return tmpViwOutcomeOveralDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
    //        return tmpViwOutcomeOveralDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
    //        return tmpViwOutcomeOveralDA.Update();
    //    }

    //    public static List<ViwOutcomeOveralBO> List()
    //    {
    //        return ViwOutcomeOveralDA.List();
    //    }
    //    public static List<ViwOutcomeOveralBO> List(int? outcomeOveralTypeID, string payDate, string checkDate)
    //    {
    //        return ViwOutcomeOveralDA.List(outcomeOveralTypeID, payDate, checkDate);
    //    }
    //    public static List<ViwOutcomeOveralBO> List(int? outcomeOveralTypeID, int? fee, int? discount)
    //    {
    //        return ViwOutcomeOveralDA.List(outcomeOveralTypeID, fee, discount);
    //    }

    //    public static ViwOutcomeOveralBO Find(int payID)
    //    {
    //        return ViwOutcomeOveralDA.Find(payID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayID.Name)
    //                return PayID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.OutcomeOveralTypeID.Name)
    //                return OutcomeOveralTypeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Fee.Name)
    //                return Fee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Discount.Name)
    //                return Discount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayDate.Name)
    //                return PayDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.CheckDate.Name)
    //                return CheckDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Description.Name)
    //                return Description.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayName.Name)
    //                return PayName.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<ViwOutcomeOveralBO> Members
    //    public ViwOutcomeOveralBO Clone()
    //    {
    //        return new ViwOutcomeOveralBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (ViwOutcomeOveralBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(ViwOutcomeOveralBO it1, ViwOutcomeOveralBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.PayID == it2.PayID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(ViwOutcomeOveralBO it1, ViwOutcomeOveralBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class ViwOutcomeOveralBO : IBusinessObject, ICloner<ViwOutcomeOveralBO>, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public int OutcomeOveralTypeID { get; set; }
        public int Fee { get; set; }
        public int Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string Description { get; set; }
        public string PayName { get; set; }
        public string CheckNumber { get; set; }
        public int PayTypeID { get; set; }
        #endregion


        #region Constructors

        public ViwOutcomeOveralBO()
        {
            // Nothing to do...
        }


        // Copy Constructor.
        public ViwOutcomeOveralBO(ViwOutcomeOveralBO copyViwOutcomeOveralBO)
        {
            this.PayID = copyViwOutcomeOveralBO.PayID;
            this.OutcomeOveralTypeID = copyViwOutcomeOveralBO.OutcomeOveralTypeID;
            this.Fee = copyViwOutcomeOveralBO.Fee;
            this.Discount = copyViwOutcomeOveralBO.Discount;
            this.PayDate = copyViwOutcomeOveralBO.PayDate;
            this.CheckDate = copyViwOutcomeOveralBO.CheckDate;
            this.Description = copyViwOutcomeOveralBO.Description;
            this.PayName = copyViwOutcomeOveralBO.PayName;
            this.CheckNumber = copyViwOutcomeOveralBO.CheckNumber;
            this.PayTypeID = copyViwOutcomeOveralBO.PayTypeID;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
            return tmpViwOutcomeOveralDA.Add();
        }

        public bool Delete()
        {
            ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
            return tmpViwOutcomeOveralDA.Delete();
        }

        public bool Update()
        {
            ViwOutcomeOveralDA tmpViwOutcomeOveralDA = new ViwOutcomeOveralDA(this);
            return tmpViwOutcomeOveralDA.Update();
        }

        public static List<ViwOutcomeOveralBO> List()
        {
            return ViwOutcomeOveralDA.List();
        }
        public static List<ViwOutcomeOveralBO> List(int? outcomeOveralTypeID, string payDate, string checkDate, string checkNumber, int? payTypeID)
        {
            return ViwOutcomeOveralDA.List(outcomeOveralTypeID, payDate, checkDate, checkNumber, payTypeID);
        }

        public static ViwOutcomeOveralBO Find()
        {
            return ViwOutcomeOveralDA.Find();
        }
        #endregion
        public static List<ViwOutcomeOveralBO> List(int? outcomeOveralTypeID, string payDateFrom, string payDateTo, string checkDate, string checkNumber, int? payTypeID)
        {
            return ViwOutcomeOveralDA.List(outcomeOveralTypeID, payDateFrom, payDateTo, checkDate, checkNumber, payTypeID);
        }


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.OutcomeOveralTypeID.Name)
                    return OutcomeOveralTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayName.Name)
                    return PayName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwOutcomeOveral.PayTypeID.Name)
                    return PayTypeID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwOutcomeOveralBO> Members
        public ViwOutcomeOveralBO Clone()
        {
            return new ViwOutcomeOveralBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwOutcomeOveralBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwOutcomeOveralBO it1, ViwOutcomeOveralBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwOutcomeOveralBO it1, ViwOutcomeOveralBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class PayTypeBO : IBusinessObject, ICloner<PayTypeBO>, IComboFillable, ILastChange, IGridValue
    {
        public enum PayType
        {
            Check = 1,
            Havale = 2,
            Fish = 3,
            Cash = 4
        }
        #region Variables

        public int PayTypeID { get; set; }
        public string PayTypeName { get; set; }
        public string PayTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public PayTypeBO()
        {
            // Nothing to do...
        }

        public PayTypeBO(int payTypeID)
        {
            this.PayTypeID = payTypeID;
        }

        // Copy Constructor.
        public PayTypeBO(PayTypeBO copyPayTypeBO)
        {
            this.PayTypeID = copyPayTypeBO.PayTypeID;
            this.PayTypeName = copyPayTypeBO.PayTypeName;
            this.PayTypeDescription = copyPayTypeBO.PayTypeDescription;
            this.LastChangeID = copyPayTypeBO.LastChangeID;
            this.LastChangeDate = copyPayTypeBO.LastChangeDate;
            this.LastChangeTime = copyPayTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            PayTypeDA tmpPayTypeDA = new PayTypeDA(this);
            return tmpPayTypeDA.Add();
        }

        public bool Delete()
        {
            PayTypeDA tmpPayTypeDA = new PayTypeDA(this);
            return tmpPayTypeDA.Delete();
        }

        public bool Update()
        {
            PayTypeDA tmpPayTypeDA = new PayTypeDA(this);
            return tmpPayTypeDA.Update();
        }

        public static List<PayTypeBO> List()
        {
            return PayTypeDA.List();
        }

        public static PayTypeBO Find(int payTypeID)
        {
            return PayTypeDA.Find(payTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeName.Name)
                    return PayTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeDescription.Name)
                    return PayTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.PayType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.PayType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.PayType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return PayTypeName; }
        }

        public string ComboDescription
        {
            get { return PayTypeDescription; }
        }
        #endregion
        #region ICloner<PayTypeBO> Members
        public PayTypeBO Clone()
        {
            return new PayTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (PayTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(PayTypeBO it1, PayTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayTypeID == it2.PayTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(PayTypeBO it1, PayTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class OutcomeOveralTypeBO : IBusinessObject, ICloner<OutcomeOveralTypeBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int OutcomeOveralTypeID { get; set; }
        public string OutcomeOveralTypeName { get; set; }
        public string OutcomeOveralTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        public enum OutcomeOveralType
        {
            Typical = 1,
            BuyStuff,
            Teacher,
            Employee,
            Student
        }

        #region Constructors

        public OutcomeOveralTypeBO()
        {
            // Nothing to do...
        }

        public OutcomeOveralTypeBO(int outcomeOveralTypeID)
        {
            this.OutcomeOveralTypeID = outcomeOveralTypeID;
        }

        // Copy Constructor.
        public OutcomeOveralTypeBO(OutcomeOveralTypeBO copyOutcomeOveralTypeBO)
        {
            this.OutcomeOveralTypeID = copyOutcomeOveralTypeBO.OutcomeOveralTypeID;
            this.OutcomeOveralTypeName = copyOutcomeOveralTypeBO.OutcomeOveralTypeName;
            this.OutcomeOveralTypeDescription = copyOutcomeOveralTypeBO.OutcomeOveralTypeDescription;
            this.LastChangeID = copyOutcomeOveralTypeBO.LastChangeID;
            this.LastChangeDate = copyOutcomeOveralTypeBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeOveralTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeOveralTypeDA tmpOutcomeOveralTypeDA = new OutcomeOveralTypeDA(this);
            return tmpOutcomeOveralTypeDA.Add();
        }

        public bool Delete()
        {
            OutcomeOveralTypeDA tmpOutcomeOveralTypeDA = new OutcomeOveralTypeDA(this);
            return tmpOutcomeOveralTypeDA.Delete();
        }

        public bool Update()
        {
            OutcomeOveralTypeDA tmpOutcomeOveralTypeDA = new OutcomeOveralTypeDA(this);
            return tmpOutcomeOveralTypeDA.Update();
        }

        public static List<OutcomeOveralTypeBO> List()
        {
            return OutcomeOveralTypeDA.List();
        }

        public static OutcomeOveralTypeBO Find(int outcomeOveralTypeID)
        {
            return OutcomeOveralTypeDA.Find(outcomeOveralTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.OutcomeOveralTypeID.Name)
                    return OutcomeOveralTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.OutcomeOveralTypeName.Name)
                    return OutcomeOveralTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.OutcomeOveralTypeDescription.Name)
                    return OutcomeOveralTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeOveralType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return OutcomeOveralTypeName; }
        }

        public string ComboDescription
        {
            get { return OutcomeOveralTypeDescription; }
        }
        #endregion
        #region ICloner<OutcomeOveralTypeBO> Members
        public OutcomeOveralTypeBO Clone()
        {
            return new OutcomeOveralTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeOveralTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeOveralTypeBO it1, OutcomeOveralTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.OutcomeOveralTypeID == it2.OutcomeOveralTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeOveralTypeBO it1, OutcomeOveralTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    //public partial class OutcomeBuyStuffBO : IBusinessObject, ICloner<OutcomeBuyStuffBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int PayID { get; set; }
    //    public int Fee { get; set; }
    //    public int? Discount { get; set; }
    //    public string PayDate { get; set; }
    //    public string CheckDate { get; set; }
    //    public string StuffName { get; set; }
    //    public int? StuffCount { get; set; }
    //    public string Description { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    #endregion


    //    #region Constructors

    //    public OutcomeBuyStuffBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public OutcomeBuyStuffBO(int payID)
    //    {
    //        this.PayID = payID;
    //    }

    //    // Copy Constructor.
    //    public OutcomeBuyStuffBO(OutcomeBuyStuffBO copyOutcomeBuyStuffBO)
    //    {
    //        this.PayID = copyOutcomeBuyStuffBO.PayID;
    //        this.Fee = copyOutcomeBuyStuffBO.Fee;
    //        this.Discount = copyOutcomeBuyStuffBO.Discount;
    //        this.PayDate = copyOutcomeBuyStuffBO.PayDate;
    //        this.CheckDate = copyOutcomeBuyStuffBO.CheckDate;
    //        this.StuffName = copyOutcomeBuyStuffBO.StuffName;
    //        this.StuffCount = copyOutcomeBuyStuffBO.StuffCount;
    //        this.Description = copyOutcomeBuyStuffBO.Description;
    //        this.LastChangeID = copyOutcomeBuyStuffBO.LastChangeID;
    //        this.LastChangeDate = copyOutcomeBuyStuffBO.LastChangeDate;
    //        this.LastChangeTime = copyOutcomeBuyStuffBO.LastChangeTime;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Update();
    //    }

    //    public static List<OutcomeBuyStuffBO> List()
    //    {
    //        return OutcomeBuyStuffDA.List();
    //    }
    //    public static List<OutcomeBuyStuffBO> List(string payDate, string checkDate)
    //    {
    //        return OutcomeBuyStuffDA.List(payDate, checkDate);
    //    }

    //    public static OutcomeBuyStuffBO Find(int payID)
    //    {
    //        return OutcomeBuyStuffDA.Find(payID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.PayID.Name)
    //                return PayID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Fee.Name)
    //                return Fee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Discount.Name)
    //                return Discount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.PayDate.Name)
    //                return PayDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.CheckDate.Name)
    //                return CheckDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.StuffName.Name)
    //                return StuffName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.StuffCount.Name)
    //                return StuffCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Description.Name)
    //                return Description.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<OutcomeBuyStuffBO> Members
    //    public OutcomeBuyStuffBO Clone()
    //    {
    //        return new OutcomeBuyStuffBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (OutcomeBuyStuffBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(OutcomeBuyStuffBO it1, OutcomeBuyStuffBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.PayID == it2.PayID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(OutcomeBuyStuffBO it1, OutcomeBuyStuffBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    //public partial class OutcomeBuyStuffBO : IBusinessObject, ICloner<OutcomeBuyStuffBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int PayID { get; set; }
    //    public int Fee { get; set; }
    //    public int? Discount { get; set; }
    //    public string PayDate { get; set; }
    //    public string CheckDate { get; set; }
    //    public string StuffName { get; set; }
    //    public int? StuffCount { get; set; }
    //    public string Description { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    public string CheckNumber { get; set; }
    //    public int PayTypeID { get; set; }
    //    #endregion


    //    #region Constructors

    //    public OutcomeBuyStuffBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public OutcomeBuyStuffBO(int payID)
    //    {
    //        this.PayID = payID;
    //    }

    //    // Copy Constructor.
    //    public OutcomeBuyStuffBO(OutcomeBuyStuffBO copyOutcomeBuyStuffBO)
    //    {
    //        this.PayID = copyOutcomeBuyStuffBO.PayID;
    //        this.Fee = copyOutcomeBuyStuffBO.Fee;
    //        this.Discount = copyOutcomeBuyStuffBO.Discount;
    //        this.PayDate = copyOutcomeBuyStuffBO.PayDate;
    //        this.CheckDate = copyOutcomeBuyStuffBO.CheckDate;
    //        this.StuffName = copyOutcomeBuyStuffBO.StuffName;
    //        this.StuffCount = copyOutcomeBuyStuffBO.StuffCount;
    //        this.Description = copyOutcomeBuyStuffBO.Description;
    //        this.LastChangeID = copyOutcomeBuyStuffBO.LastChangeID;
    //        this.LastChangeDate = copyOutcomeBuyStuffBO.LastChangeDate;
    //        this.LastChangeTime = copyOutcomeBuyStuffBO.LastChangeTime;
    //        this.CheckNumber = copyOutcomeBuyStuffBO.CheckNumber;
    //        this.PayTypeID = copyOutcomeBuyStuffBO.PayTypeID;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        OutcomeBuyStuffDA tmpOutcomeBuyStuffDA = new OutcomeBuyStuffDA(this);
    //        return tmpOutcomeBuyStuffDA.Update();
    //    }

    //    public static List<OutcomeBuyStuffBO> List()
    //    {
    //        return OutcomeBuyStuffDA.List();
    //    }

    //    public static OutcomeBuyStuffBO Find(int payID)
    //    {
    //        return OutcomeBuyStuffDA.Find(payID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.PayID.Name)
    //                return PayID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Fee.Name)
    //                return Fee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Discount.Name)
    //                return Discount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.PayDate.Name)
    //                return PayDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.CheckDate.Name)
    //                return CheckDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.StuffName.Name)
    //                return StuffName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.StuffCount.Name)
    //                return StuffCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.Description.Name)
    //                return Description.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.CheckNumber.Name)
    //                return CheckNumber.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.OutcomeBuyStuff.PayTypeID.Name)
    //                return PayTypeID.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<OutcomeBuyStuffBO> Members
    //    public OutcomeBuyStuffBO Clone()
    //    {
    //        return new OutcomeBuyStuffBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (OutcomeBuyStuffBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(OutcomeBuyStuffBO it1, OutcomeBuyStuffBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.PayID == it2.PayID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(OutcomeBuyStuffBO it1, OutcomeBuyStuffBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class OutcomeStudentBO : IBusinessObject, ICloner<OutcomeStudentBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string StudentID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public int ClassID { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                    relStudent = StudentBO.Find(StudentID);
                return relStudent;
            }
            set { relStudent = value; }
        }

        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        private PayTypeBO relPayType;
        public PayTypeBO RelPayType
        {
            get
            {
                if (relPayType == null)
                    relPayType = PayTypeBO.Find(PayTypeID);
                return relPayType;
            }
            set { relPayType = value; }
        }

        #region Constructors

        public OutcomeStudentBO()
        {
            // Nothing to do...
        }

        public OutcomeStudentBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public OutcomeStudentBO(OutcomeStudentBO copyOutcomeStudentBO)
        {
            this.PayID = copyOutcomeStudentBO.PayID;
            this.StudentID = copyOutcomeStudentBO.StudentID;
            this.PayTypeID = copyOutcomeStudentBO.PayTypeID;
            this.Fee = copyOutcomeStudentBO.Fee;
            this.Discount = copyOutcomeStudentBO.Discount;
            this.PayDate = copyOutcomeStudentBO.PayDate;
            this.CheckDate = copyOutcomeStudentBO.CheckDate;
            this.CheckNumber = copyOutcomeStudentBO.CheckNumber;
            this.Description = copyOutcomeStudentBO.Description;
            this.ClassID = copyOutcomeStudentBO.ClassID;
            this.LastChangeID = copyOutcomeStudentBO.LastChangeID;
            this.LastChangeDate = copyOutcomeStudentBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeStudentBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeStudentDA tmpOutcomeStudentDA = new OutcomeStudentDA(this);
            return tmpOutcomeStudentDA.Add();
        }

        public bool Delete()
        {
            OutcomeStudentDA tmpOutcomeStudentDA = new OutcomeStudentDA(this);
            return tmpOutcomeStudentDA.Delete();
        }

        public bool Update()
        {
            OutcomeStudentDA tmpOutcomeStudentDA = new OutcomeStudentDA(this);
            return tmpOutcomeStudentDA.Update();
        }

        public static List<OutcomeStudentBO> List()
        {
            return OutcomeStudentDA.List();
        }
        public static List<OutcomeStudentBO> List(string studentID, int? payTypeID, string payDate, string checkDate, string checkNumber, int? classID)
        {
            return OutcomeStudentDA.List(studentID, payTypeID, payDate, checkDate, checkNumber, classID);
        }

        public static OutcomeStudentBO Find(int payID)
        {
            return OutcomeStudentDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStudent.LastChangeTime.Name)
                    return LastChangeTime.ToString();

                if (columnDefinition.Name == DatabaseSchema.Student.FirstName.Name)
                    return RelStudent.FullName;
                if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
                    return RelClass.ClassName;
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeName.Name)
                    return RelPayType.PayTypeName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<OutcomeStudentBO> Members
        public OutcomeStudentBO Clone()
        {
            return new OutcomeStudentBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeStudentBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeStudentBO it1, OutcomeStudentBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeStudentBO it1, OutcomeStudentBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class OutcomeEmployeeBO : IBusinessObject, ICloner<OutcomeEmployeeBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string EmployeeID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private EmployeeBO relEmployee;
        public EmployeeBO RelEmployee
        {
            get
            {
                if (relEmployee == null)
                    relEmployee = EmployeeBO.Find(EmployeeID);
                return relEmployee;
            }
            set { relEmployee = value; }
        }

        #region Constructors

        public OutcomeEmployeeBO()
        {
            // Nothing to do...
        }

        public OutcomeEmployeeBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public OutcomeEmployeeBO(OutcomeEmployeeBO copyOutcomeEmployeeBO)
        {
            this.PayID = copyOutcomeEmployeeBO.PayID;
            this.EmployeeID = copyOutcomeEmployeeBO.EmployeeID;
            this.PayTypeID = copyOutcomeEmployeeBO.PayTypeID;
            this.Fee = copyOutcomeEmployeeBO.Fee;
            this.Discount = copyOutcomeEmployeeBO.Discount;
            this.PayDate = copyOutcomeEmployeeBO.PayDate;
            this.CheckDate = copyOutcomeEmployeeBO.CheckDate;
            this.CheckNumber = copyOutcomeEmployeeBO.CheckNumber;
            this.Description = copyOutcomeEmployeeBO.Description;
            this.DateFrom = copyOutcomeEmployeeBO.DateFrom;
            this.DateTo = copyOutcomeEmployeeBO.DateTo;
            this.LastChangeID = copyOutcomeEmployeeBO.LastChangeID;
            this.LastChangeDate = copyOutcomeEmployeeBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeEmployeeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeEmployeeDA tmpOutcomeEmployeeDA = new OutcomeEmployeeDA(this);
            return tmpOutcomeEmployeeDA.Add();
        }

        public bool Delete()
        {
            OutcomeEmployeeDA tmpOutcomeEmployeeDA = new OutcomeEmployeeDA(this);
            return tmpOutcomeEmployeeDA.Delete();
        }

        public bool Update()
        {
            OutcomeEmployeeDA tmpOutcomeEmployeeDA = new OutcomeEmployeeDA(this);
            return tmpOutcomeEmployeeDA.Update();
        }

        public static List<OutcomeEmployeeBO> List()
        {
            return OutcomeEmployeeDA.List();
        }
        public static List<OutcomeEmployeeBO> List(string employeeID, int? payTypeID, string payDate, string checkDate, string checkNumber, string dateFrom, string dateTo)
        {
            return OutcomeEmployeeDA.List(employeeID, payTypeID, payDate, checkDate, checkNumber, dateFrom, dateTo);
        }

        public static OutcomeEmployeeBO Find(int payID)
        {
            return OutcomeEmployeeDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.EmployeeID.Name)
                    return EmployeeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.DateFrom.Name)
                    return DateFrom.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.DateTo.Name)
                    return DateTo.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeEmployee.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<OutcomeEmployeeBO> Members
        public OutcomeEmployeeBO Clone()
        {
            return new OutcomeEmployeeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeEmployeeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeEmployeeBO it1, OutcomeEmployeeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeEmployeeBO it1, OutcomeEmployeeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class OutcomeTeacherBO : IBusinessObject, ICloner<OutcomeTeacherBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string TeacherID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public int ClassID { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public string GroupPayID { get; set; }
        #endregion


        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                    relTeacher = TeacherBO.Find(TeacherID);
                return relTeacher;
            }
            set { relTeacher = value; }
        }

        private PayTypeBO relPayType;
        public PayTypeBO RelPayType
        {
            get
            {
                if (relPayType == null)
                    relPayType = PayTypeBO.Find(PayTypeID);
                return relPayType;
            }
            set { relPayType = value; }
        }

        #region Constructors

        public OutcomeTeacherBO()
        {
            // Nothing to do...
            GroupPayID = Guid.NewGuid().ToString();
        }

        public OutcomeTeacherBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public OutcomeTeacherBO(OutcomeTeacherBO copyOutcomeTeacherBO)
        {
            this.PayID = copyOutcomeTeacherBO.PayID;
            this.TeacherID = copyOutcomeTeacherBO.TeacherID;
            this.PayTypeID = copyOutcomeTeacherBO.PayTypeID;
            this.Fee = copyOutcomeTeacherBO.Fee;
            this.Discount = copyOutcomeTeacherBO.Discount;
            this.PayDate = copyOutcomeTeacherBO.PayDate;
            this.CheckDate = copyOutcomeTeacherBO.CheckDate;
            this.CheckNumber = copyOutcomeTeacherBO.CheckNumber;
            this.Description = copyOutcomeTeacherBO.Description;
            this.ClassID = copyOutcomeTeacherBO.ClassID;
            this.LastChangeID = copyOutcomeTeacherBO.LastChangeID;
            this.LastChangeDate = copyOutcomeTeacherBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeTeacherBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeTeacherDA tmpOutcomeTeacherDA = new OutcomeTeacherDA(this);
            return tmpOutcomeTeacherDA.Add();
        }

        public bool Delete()
        {
            OutcomeTeacherDA tmpOutcomeTeacherDA = new OutcomeTeacherDA(this);
            return tmpOutcomeTeacherDA.Delete();
        }

        public bool Update()
        {
            OutcomeTeacherDA tmpOutcomeTeacherDA = new OutcomeTeacherDA(this);
            return tmpOutcomeTeacherDA.Update();
        }

        public static List<OutcomeTeacherBO> List()
        {
            return OutcomeTeacherDA.List();
        }
        public static List<OutcomeTeacherBO> List(string teacherID, int? payTypeID, string payDate, string checkDate, string checkNumber, int? classID)
        {
            return OutcomeTeacherDA.List(teacherID, payTypeID, payDate, checkDate, checkNumber, classID);
        }

        public static OutcomeTeacherBO Find(int payID)
        {
            return OutcomeTeacherDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.PayTypeID.Name)
                    return PayTypeBO.Find(PayTypeID).PayTypeName;
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeTeacher.LastChangeTime.Name)
                    return LastChangeTime.ToString();

                if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName.Name)
                    return RelTeacher.FullName;
                if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
                    return RelClass.ClassName;
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeName.Name)
                    return RelPayType.PayTypeName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<OutcomeTeacherBO> Members
        public OutcomeTeacherBO Clone()
        {
            return new OutcomeTeacherBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeTeacherBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeTeacherBO it1, OutcomeTeacherBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeTeacherBO it1, OutcomeTeacherBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

    }

    // Generated by DVD CodeGenerator
    public partial class IncomeTypicalTypeBO : IBusinessObject, ICloner<IncomeTypicalTypeBO>, IComboFillable, ILastChange, IGridValue
    {
        #region Variables

        public int IncomeTypicalTypeID { get; set; }
        public string IncomeTypicalTypeName { get; set; }
        public string IncomeTypicalTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        public enum IncomeTypicalType
        {
            Others = 1,
            MinistryHelp,
            StudentGift
        }

        #region Constructors

        public IncomeTypicalTypeBO()
        {
            // Nothing to do...
        }

        public IncomeTypicalTypeBO(int incomeTypicalTypeID)
        {
            this.IncomeTypicalTypeID = incomeTypicalTypeID;
        }

        // Copy Constructor.
        public IncomeTypicalTypeBO(IncomeTypicalTypeBO copyIncomeTypicalTypeBO)
        {
            this.IncomeTypicalTypeID = copyIncomeTypicalTypeBO.IncomeTypicalTypeID;
            this.IncomeTypicalTypeName = copyIncomeTypicalTypeBO.IncomeTypicalTypeName;
            this.IncomeTypicalTypeDescription = copyIncomeTypicalTypeBO.IncomeTypicalTypeDescription;
            this.LastChangeID = copyIncomeTypicalTypeBO.LastChangeID;
            this.LastChangeDate = copyIncomeTypicalTypeBO.LastChangeDate;
            this.LastChangeTime = copyIncomeTypicalTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeTypicalTypeDA tmpIncomeTypicalTypeDA = new IncomeTypicalTypeDA(this);
            return tmpIncomeTypicalTypeDA.Add();
        }

        public bool Delete()
        {
            IncomeTypicalTypeDA tmpIncomeTypicalTypeDA = new IncomeTypicalTypeDA(this);
            return tmpIncomeTypicalTypeDA.Delete();
        }

        public bool Update()
        {
            IncomeTypicalTypeDA tmpIncomeTypicalTypeDA = new IncomeTypicalTypeDA(this);
            return tmpIncomeTypicalTypeDA.Update();
        }

        public static List<IncomeTypicalTypeBO> List()
        {
            return IncomeTypicalTypeDA.List();
        }

        public static IncomeTypicalTypeBO Find(int incomeTypicalTypeID)
        {
            return IncomeTypicalTypeDA.Find(incomeTypicalTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeID.Name)
                    return IncomeTypicalTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeName.Name)
                    return IncomeTypicalTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeDescription.Name)
                    return IncomeTypicalTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypicalType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return IncomeTypicalTypeName; }
        }

        public string ComboDescription
        {
            get { return IncomeTypicalTypeDescription; }
        }
        #endregion
        #region ICloner<IncomeTypicalTypeBO> Members
        public IncomeTypicalTypeBO Clone()
        {
            return new IncomeTypicalTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeTypicalTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeTypicalTypeBO it1, IncomeTypicalTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.IncomeTypicalTypeID == it2.IncomeTypicalTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeTypicalTypeBO it1, IncomeTypicalTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class IncomeOveralTypeBO : IBusinessObject, ICloner<IncomeOveralTypeBO>, ILastChange, IGridValue
    {
        #region Variables

        public int IncomeOveralTypeID { get; set; }
        public string IncomeOveralTypeName { get; set; }
        public string IncomeOveralTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        public enum IncomeOveralType
        {
            Typical = 1,
            SellStuff,
            StudentFee,
            TeacherBalance
        }

        #region Constructors

        public IncomeOveralTypeBO()
        {
            // Nothing to do...
        }

        public IncomeOveralTypeBO(int incomeOveralTypeID)
        {
            this.IncomeOveralTypeID = incomeOveralTypeID;
        }

        // Copy Constructor.
        public IncomeOveralTypeBO(IncomeOveralTypeBO copyIncomeOveralTypeBO)
        {
            this.IncomeOveralTypeID = copyIncomeOveralTypeBO.IncomeOveralTypeID;
            this.IncomeOveralTypeName = copyIncomeOveralTypeBO.IncomeOveralTypeName;
            this.IncomeOveralTypeDescription = copyIncomeOveralTypeBO.IncomeOveralTypeDescription;
            this.LastChangeID = copyIncomeOveralTypeBO.LastChangeID;
            this.LastChangeDate = copyIncomeOveralTypeBO.LastChangeDate;
            this.LastChangeTime = copyIncomeOveralTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeOveralTypeDA tmpIncomeOveralTypeDA = new IncomeOveralTypeDA(this);
            return tmpIncomeOveralTypeDA.Add();
        }

        public bool Delete()
        {
            IncomeOveralTypeDA tmpIncomeOveralTypeDA = new IncomeOveralTypeDA(this);
            return tmpIncomeOveralTypeDA.Delete();
        }

        public bool Update()
        {
            IncomeOveralTypeDA tmpIncomeOveralTypeDA = new IncomeOveralTypeDA(this);
            return tmpIncomeOveralTypeDA.Update();
        }

        public static List<IncomeOveralTypeBO> List()
        {
            return IncomeOveralTypeDA.List();
        }

        public static IncomeOveralTypeBO Find(int incomeOveralTypeID)
        {
            return IncomeOveralTypeDA.Find(incomeOveralTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.IncomeOveralTypeID.Name)
                    return IncomeOveralTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.IncomeOveralTypeName.Name)
                    return IncomeOveralTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.IncomeOveralTypeDescription.Name)
                    return IncomeOveralTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeOveralType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<IncomeOveralTypeBO> Members
        public IncomeOveralTypeBO Clone()
        {
            return new IncomeOveralTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeOveralTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeOveralTypeBO it1, IncomeOveralTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.IncomeOveralTypeID == it2.IncomeOveralTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeOveralTypeBO it1, IncomeOveralTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class IncomeTypicalBO : IBusinessObject, ICloner<IncomeTypicalBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public int IncomeTypicalTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string CheckNumber { get; set; }
        public int PayTypeID { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public IncomeTypicalBO()
        {
            // Nothing to do...
        }

        public IncomeTypicalBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public IncomeTypicalBO(IncomeTypicalBO copyIncomeTypicalBO)
        {
            this.PayID = copyIncomeTypicalBO.PayID;
            this.IncomeTypicalTypeID = copyIncomeTypicalBO.IncomeTypicalTypeID;
            this.Fee = copyIncomeTypicalBO.Fee;
            this.Discount = copyIncomeTypicalBO.Discount;
            this.PayDate = copyIncomeTypicalBO.PayDate;
            this.CheckDate = copyIncomeTypicalBO.CheckDate;
            this.Tag = copyIncomeTypicalBO.Tag;
            this.Description = copyIncomeTypicalBO.Description;
            this.CheckNumber = copyIncomeTypicalBO.CheckNumber;
            this.PayTypeID = copyIncomeTypicalBO.PayTypeID;
            this.LastChangeID = copyIncomeTypicalBO.LastChangeID;
            this.LastChangeDate = copyIncomeTypicalBO.LastChangeDate;
            this.LastChangeTime = copyIncomeTypicalBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeTypicalDA tmpIncomeTypicalDA = new IncomeTypicalDA(this);
            return tmpIncomeTypicalDA.Add();
        }

        public bool Delete()
        {
            IncomeTypicalDA tmpIncomeTypicalDA = new IncomeTypicalDA(this);
            return tmpIncomeTypicalDA.Delete();
        }

        public bool Update()
        {
            IncomeTypicalDA tmpIncomeTypicalDA = new IncomeTypicalDA(this);
            return tmpIncomeTypicalDA.Update();
        }

        public static List<IncomeTypicalBO> List()
        {
            return IncomeTypicalDA.List();
        }
        public static List<IncomeTypicalBO> List(int? incomeTypicalTypeID, string payDate, string checkDate, string checkNumber)
        {
            return IncomeTypicalDA.List(incomeTypicalTypeID, payDate, checkDate, checkNumber);
        }

        public static IncomeTypicalBO Find(int payID)
        {
            return IncomeTypicalDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.IncomeTypicalTypeID.Name)
                    return IncomeTypicalTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.Tag.Name)
                    return Tag.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTypical.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<IncomeTypicalBO> Members
        public IncomeTypicalBO Clone()
        {
            return new IncomeTypicalBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeTypicalBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeTypicalBO it1, IncomeTypicalBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeTypicalBO it1, IncomeTypicalBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    //// Generated by DVD CodeGenerator
    //public partial class IncomeSellStuffBO : IBusinessObject, ICloner<IncomeSellStuffBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int PayID { get; set; }
    //    public int Fee { get; set; }
    //    public int? Discount { get; set; }
    //    public string PayDate { get; set; }
    //    public string CheckDate { get; set; }
    //    public string StuffName { get; set; }
    //    public int? StuffCount { get; set; }
    //    public string Description { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    public string CheckNumber { get; set; }
    //    #endregion


    //    #region Constructors

    //    public IncomeSellStuffBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public IncomeSellStuffBO(int payID)
    //    {
    //        this.PayID = payID;
    //    }

    //    // Copy Constructor.
    //    public IncomeSellStuffBO(IncomeSellStuffBO copyIncomeSellStuffBO)
    //    {
    //        this.PayID = copyIncomeSellStuffBO.PayID;
    //        this.Fee = copyIncomeSellStuffBO.Fee;
    //        this.Discount = copyIncomeSellStuffBO.Discount;
    //        this.PayDate = copyIncomeSellStuffBO.PayDate;
    //        this.CheckDate = copyIncomeSellStuffBO.CheckDate;
    //        this.StuffName = copyIncomeSellStuffBO.StuffName;
    //        this.StuffCount = copyIncomeSellStuffBO.StuffCount;
    //        this.Description = copyIncomeSellStuffBO.Description;
    //        this.LastChangeID = copyIncomeSellStuffBO.LastChangeID;
    //        this.LastChangeDate = copyIncomeSellStuffBO.LastChangeDate;
    //        this.LastChangeTime = copyIncomeSellStuffBO.LastChangeTime;
    //        this.CheckNumber = copyIncomeSellStuffBO.CheckNumber;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        IncomeSellStuffDA tmpIncomeSellStuffDA = new IncomeSellStuffDA(this);
    //        return tmpIncomeSellStuffDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        IncomeSellStuffDA tmpIncomeSellStuffDA = new IncomeSellStuffDA(this);
    //        return tmpIncomeSellStuffDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        IncomeSellStuffDA tmpIncomeSellStuffDA = new IncomeSellStuffDA(this);
    //        return tmpIncomeSellStuffDA.Update();
    //    }

    //    public static List<IncomeSellStuffBO> List()
    //    {
    //        return IncomeSellStuffDA.List();
    //    }
    //    public static List<IncomeSellStuffBO> List(string payDate, string checkDate, string checkNumber)
    //    {
    //        return IncomeSellStuffDA.List(payDate, checkDate, checkNumber);
    //    }

    //    public static IncomeSellStuffBO Find(int payID)
    //    {
    //        return IncomeSellStuffDA.Find(payID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.PayID.Name)
    //                return PayID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.Fee.Name)
    //                return Fee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.Discount.Name)
    //                return Discount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.PayDate.Name)
    //                return PayDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.CheckDate.Name)
    //                return CheckDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.StuffName.Name)
    //                return StuffName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.StuffCount.Name)
    //                return StuffCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.Description.Name)
    //                return Description.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.IncomeSellStuff.CheckNumber.Name)
    //                return CheckNumber.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<IncomeSellStuffBO> Members
    //    public IncomeSellStuffBO Clone()
    //    {
    //        return new IncomeSellStuffBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (IncomeSellStuffBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(IncomeSellStuffBO it1, IncomeSellStuffBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.PayID == it2.PayID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(IncomeSellStuffBO it1, IncomeSellStuffBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class ViwIncomeOveralBO : IBusinessObject, ICloner<ViwIncomeOveralBO>, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public int IncomeOveralTypeID { get; set; }
        public int Fee { get; set; }
        public int Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string Description { get; set; }
        public string PayName { get; set; }
        public string CheckNumber { get; set; }
        #endregion


        #region Constructors

        public ViwIncomeOveralBO()
        {
            // Nothing to do...
        }


        // Copy Constructor.
        public ViwIncomeOveralBO(ViwIncomeOveralBO copyViwIncomeOveralBO)
        {
            this.PayID = copyViwIncomeOveralBO.PayID;
            this.IncomeOveralTypeID = copyViwIncomeOveralBO.IncomeOveralTypeID;
            this.Fee = copyViwIncomeOveralBO.Fee;
            this.Discount = copyViwIncomeOveralBO.Discount;
            this.PayDate = copyViwIncomeOveralBO.PayDate;
            this.CheckDate = copyViwIncomeOveralBO.CheckDate;
            this.Description = copyViwIncomeOveralBO.Description;
            this.PayName = copyViwIncomeOveralBO.PayName;
            this.CheckNumber = copyViwIncomeOveralBO.CheckNumber;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwIncomeOveralDA tmpViwIncomeOveralDA = new ViwIncomeOveralDA(this);
            return tmpViwIncomeOveralDA.Add();
        }

        public bool Delete()
        {
            ViwIncomeOveralDA tmpViwIncomeOveralDA = new ViwIncomeOveralDA(this);
            return tmpViwIncomeOveralDA.Delete();
        }

        public bool Update()
        {
            ViwIncomeOveralDA tmpViwIncomeOveralDA = new ViwIncomeOveralDA(this);
            return tmpViwIncomeOveralDA.Update();
        }

        public static List<ViwIncomeOveralBO> List(int? incomeOveralTypeID, string payDate, string checkDate, string checkNumber)
        {
            return ViwIncomeOveralDA.List(incomeOveralTypeID, payDate, checkDate, checkNumber);
        }
        public static List<ViwIncomeOveralBO> List()
        {
            return ViwIncomeOveralDA.List();
        }

        public static ViwIncomeOveralBO Find()
        {
            return ViwIncomeOveralDA.Find();
        }
        #endregion

        public static List<ViwIncomeOveralBO> List(int? incomeOveralTypeID, string payDateFrom, string payDateTo, string checkDate, string checkNumber)
        {
            return ViwIncomeOveralDA.List(incomeOveralTypeID, payDateFrom, payDateTo, checkDate, checkNumber);
        }
        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.IncomeOveralTypeID.Name)
                    return IncomeOveralTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.PayName.Name)
                    return PayName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwIncomeOveral.CheckNumber.Name)
                    return CheckNumber.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwIncomeOveralBO> Members
        public ViwIncomeOveralBO Clone()
        {
            return new ViwIncomeOveralBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwIncomeOveralBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwIncomeOveralBO it1, ViwIncomeOveralBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwIncomeOveralBO it1, ViwIncomeOveralBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    //public partial class RegistrationBO : IBusinessObject, ICloner<RegistrationBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public int ClassID { get; set; }
    //    public string StudentID { get; set; }
    //    public string RegistrationDate { get; set; }
    //    public bool ActivityStatus { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    #endregion

    //    private StudentBO relStudent;
    //    public StudentBO RelStudent
    //    {
    //        get
    //        {
    //            if (relStudent == null)
    //                relStudent = StudentBO.Find(StudentID);
    //            return relStudent;
    //        }
    //        set { relStudent = value; }
    //    }

    //    private ClassBO relClass;
    //    public ClassBO RelClass
    //    {
    //        get
    //        {
    //            if (relClass == null)
    //                relClass = ClassBO.Find(ClassID);
    //            return relClass;
    //        }
    //        set { relClass = value; }
    //    }

    //    #region Constructors

    //    public RegistrationBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public RegistrationBO(int classID, string studentID)
    //    {
    //        this.ClassID = classID;
    //        this.StudentID = studentID;
    //    }

    //    // Copy Constructor.
    //    public RegistrationBO(RegistrationBO copyRegistrationBO)
    //    {
    //        this.ClassID = copyRegistrationBO.ClassID;
    //        this.StudentID = copyRegistrationBO.StudentID;
    //        this.RegistrationDate = copyRegistrationBO.RegistrationDate;
    //        this.ActivityStatus = copyRegistrationBO.ActivityStatus;
    //        this.LastChangeID = copyRegistrationBO.LastChangeID;
    //        this.LastChangeDate = copyRegistrationBO.LastChangeDate;
    //        this.LastChangeTime = copyRegistrationBO.LastChangeTime;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
    //        return tmpRegistrationDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
    //        return tmpRegistrationDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
    //        return tmpRegistrationDA.Update();
    //    }

    //    public static List<RegistrationBO> List()
    //    {
    //        return RegistrationDA.List();
    //    }
    //    public static List<RegistrationBO> List(bool? activityStatus)
    //    {
    //        return RegistrationDA.List(activityStatus);
    //    }
    //    public static List<RegistrationBO> List(int? classID, string studentID, bool? activityStatus)
    //    {
    //        return RegistrationDA.List(classID, studentID, activityStatus);
    //    }

    //    public static RegistrationBO Find(int classID, string studentID)
    //    {
    //        return RegistrationDA.Find(classID, studentID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.Registration.ClassID.Name)
    //                return ClassID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.StudentID.Name)
    //                return StudentID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.RegistrationDate.Name)
    //                return RegistrationDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.ActivityStatus.Name)
    //                return ActivityStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeTime.Name)
    //                return LastChangeTime.ToString();

    //            //if (columnDefinition.Name == DatabaseSchema.Student.FirstName.Name)
    //            //    return RelStudent.FullName;
    //            if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
    //                return RelClass.ClassName;
    //            if (columnDefinition.Name == DatabaseSchema.Teacher.FirstName.Name)
    //                return RelClass.RelTeacher.FullName;

    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<RegistrationBO> Members
    //    public RegistrationBO Clone()
    //    {
    //        return new RegistrationBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (RegistrationBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(RegistrationBO it1, RegistrationBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.ClassID == it2.ClassID && it1.StudentID == it2.StudentID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(RegistrationBO it1, RegistrationBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class RegistrationBO : IBusinessObject, ICloner<RegistrationBO>, ILastChange, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string StudentID { get; set; }
        public string RegistrationDate { get; set; }
        public bool ActivityStatus { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public bool IsBalancedFinalWithStudent { get; set; }
        #endregion

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                    relStudent = StudentBO.Find(StudentID);
                return relStudent;
            }
            set { relStudent = value; }
        }

        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        #region Constructors

        public RegistrationBO()
        {
            // Nothing to do...
        }

        public RegistrationBO(int classID, string studentID)
        {
            this.ClassID = classID;
            this.StudentID = studentID;
        }

        // Copy Constructor.
        public RegistrationBO(RegistrationBO copyRegistrationBO)
        {
            this.ClassID = copyRegistrationBO.ClassID;
            this.StudentID = copyRegistrationBO.StudentID;
            this.RegistrationDate = copyRegistrationBO.RegistrationDate;
            this.ActivityStatus = copyRegistrationBO.ActivityStatus;
            this.LastChangeID = copyRegistrationBO.LastChangeID;
            this.LastChangeDate = copyRegistrationBO.LastChangeDate;
            this.LastChangeTime = copyRegistrationBO.LastChangeTime;
            this.IsBalancedFinalWithStudent = copyRegistrationBO.IsBalancedFinalWithStudent;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
            return tmpRegistrationDA.Add();
        }

        public bool Delete()
        {
            RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
            return tmpRegistrationDA.Delete();
        }

        public bool Update()
        {
            RegistrationDA tmpRegistrationDA = new RegistrationDA(this);
            return tmpRegistrationDA.Update();
        }

        public static List<RegistrationBO> List()
        {
            return RegistrationDA.List();
        }
        public static List<RegistrationBO> List(bool? activityStatus)
        {
            return RegistrationDA.List(activityStatus);
        }
        public static List<RegistrationBO> List(int? classID, string studentID, bool? activityStatus, bool? isBalancedFinalWithStudent)
        {
            return RegistrationDA.List(classID, studentID, activityStatus, isBalancedFinalWithStudent);
        }

        public static RegistrationBO Find(int classID, string studentID)
        {
            return RegistrationDA.Find(classID, studentID);
        }
        #endregion

        public bool SetBalanced(bool isBalanced)
        {
            return new RegistrationDA(this).SetBalanced(isBalanced);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.Registration.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.RegistrationDate.Name)
                    return RegistrationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Registration.IsBalancedFinalWithStudent.Name)
                    return IsBalancedFinalWithStudent.ToString();
                if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
                    return RelClass.ClassName;
                if (columnDefinition == DatabaseSchema.Teacher.TeacherID)
                    return RelClass.RelTeacher.FullName;
                if (columnDefinition == DatabaseSchema.Student.FirstName)
                    return RelStudent.FullName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<RegistrationBO> Members
        public RegistrationBO Clone()
        {
            return new RegistrationBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (RegistrationBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(RegistrationBO it1, RegistrationBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.StudentID == it2.StudentID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(RegistrationBO it1, RegistrationBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    //// Generated by DVD CodeGenerator
    //public partial class ViwTeacherFinancialStatusBOOld : IBusinessObject, ICloner<ViwTeacherFinancialStatusBO>, IGridValue
    //{
    //    #region Variables

    //    public int ClassID { get; set; }
    //    public string ClassName { get; set; }
    //    public string TeacherID { get; set; }
    //    public string FullName { get; set; }
    //    public int HeldSessionsValue { get; set; }
    //    public int HavePaidValue { get; set; }
    //    public int MustPayValue { get; set; }
    //    public bool IsSuccessor { get; set; }
    //    public string Description { get; set; }
    //    #endregion


    //    #region Constructors

    //    public ViwTeacherFinancialStatusBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public ViwTeacherFinancialStatusBO(int classID, string teacherID)
    //    {
    //        this.ClassID = classID;
    //        this.TeacherID = teacherID;
    //    }

    //    // Copy Constructor.
    //    public ViwTeacherFinancialStatusBO(ViwTeacherFinancialStatusBO copyViwTeacherFinancialStatusBO)
    //    {
    //        this.ClassID = copyViwTeacherFinancialStatusBO.ClassID;
    //        this.ClassName = copyViwTeacherFinancialStatusBO.ClassName;
    //        this.TeacherID = copyViwTeacherFinancialStatusBO.TeacherID;
    //        this.FullName = copyViwTeacherFinancialStatusBO.FullName;
    //        this.HeldSessionsValue = copyViwTeacherFinancialStatusBO.HeldSessionsValue;
    //        this.HavePaidValue = copyViwTeacherFinancialStatusBO.HavePaidValue;
    //        this.MustPayValue = copyViwTeacherFinancialStatusBO.MustPayValue;
    //        this.IsSuccessor = copyViwTeacherFinancialStatusBO.IsSuccessor;
    //        this.Description = copyViwTeacherFinancialStatusBO.Description;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
    //        return tmpViwTeacherFinancialStatusDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
    //        return tmpViwTeacherFinancialStatusDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
    //        return tmpViwTeacherFinancialStatusDA.Update();
    //    }

    //    public static List<ViwTeacherFinancialStatusBO> List()
    //    {
    //        return ViwTeacherFinancialStatusDA.List();
    //    }
    //    public static List<ViwTeacherFinancialStatusBO> List(int? classID, string teacherID, int? heldSessionsValue, int? havePaidValue, int? mustPayValue, bool? isSuccessor)
    //    {
    //        return ViwTeacherFinancialStatusDA.List(classID, teacherID, heldSessionsValue, havePaidValue, mustPayValue, isSuccessor);
    //    }

    //    public static ViwTeacherFinancialStatusBO Find(int classID, string teacherID)
    //    {
    //        return ViwTeacherFinancialStatusDA.Find(classID, teacherID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassID.Name)
    //                return ClassID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassName.Name)
    //                return ClassName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.TeacherID.Name)
    //                return TeacherID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.FullName.Name)
    //                return FullName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.HeldSessionsValue.Name)
    //                return HeldSessionsValue.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.HavePaidValue.Name)
    //                return HavePaidValue.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.MustPayValue.Name)
    //                return MustPayValue.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.IsSuccessor.Name)
    //                return IsSuccessor.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.Description.Name)
    //                return Description.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<ViwTeacherFinancialStatusBO> Members
    //    public ViwTeacherFinancialStatusBO Clone()
    //    {
    //        return new ViwTeacherFinancialStatusBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (ViwTeacherFinancialStatusBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(ViwTeacherFinancialStatusBO it1, ViwTeacherFinancialStatusBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.ClassID == it2.ClassID && it1.TeacherID == it2.TeacherID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(ViwTeacherFinancialStatusBO it1, ViwTeacherFinancialStatusBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class ViwClassesPrivateBO : IBusinessObject, ICloner<ViwClassesPrivateBO>, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentID { get; set; }
        public string StudentLastName { get; set; }
        public string RegistrationDate { get; set; }
        public string MajorName { get; set; }
        public string TeacherID { get; set; }
        public int MajorID { get; set; }
        public bool ActivityStatus { get; set; }
        #endregion


        #region Constructors

        public ViwClassesPrivateBO()
        {
            // Nothing to do...
        }

        public ViwClassesPrivateBO(int classID)
        {
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ViwClassesPrivateBO(ViwClassesPrivateBO copyViwClassesPrivateBO)
        {
            this.ClassID = copyViwClassesPrivateBO.ClassID;
            this.ClassName = copyViwClassesPrivateBO.ClassName;
            this.TeacherFirstName = copyViwClassesPrivateBO.TeacherFirstName;
            this.TeacherLastName = copyViwClassesPrivateBO.TeacherLastName;
            this.StudentFirstName = copyViwClassesPrivateBO.StudentFirstName;
            this.StudentID = copyViwClassesPrivateBO.StudentID;
            this.StudentLastName = copyViwClassesPrivateBO.StudentLastName;
            this.RegistrationDate = copyViwClassesPrivateBO.RegistrationDate;
            this.MajorName = copyViwClassesPrivateBO.MajorName;
            this.TeacherID = copyViwClassesPrivateBO.TeacherID;
            this.MajorID = copyViwClassesPrivateBO.MajorID;
            this.ActivityStatus = copyViwClassesPrivateBO.ActivityStatus;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwClassesPrivateDA tmpViwClassesPrivateDA = new ViwClassesPrivateDA(this);
            return tmpViwClassesPrivateDA.Add();
        }

        public bool Delete()
        {
            ViwClassesPrivateDA tmpViwClassesPrivateDA = new ViwClassesPrivateDA(this);
            return tmpViwClassesPrivateDA.Delete();
        }

        public bool Update()
        {
            ViwClassesPrivateDA tmpViwClassesPrivateDA = new ViwClassesPrivateDA(this);
            return tmpViwClassesPrivateDA.Update();
        }

        public static List<ViwClassesPrivateBO> List()
        {
            return ViwClassesPrivateDA.List();
        }
        public static List<ViwClassesPrivateBO> List(int? classID, string studentID, string teacherID, int? majorID, bool? activityStatus)
        {
            return ViwClassesPrivateDA.List(classID, studentID, teacherID, majorID, activityStatus);
        }

        public static ViwClassesPrivateBO Find(int classID)
        {
            return ViwClassesPrivateDA.Find(classID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.TeacherFirstName.Name)
                    return TeacherFirstName + " " + TeacherLastName;
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.TeacherLastName.Name)
                    return TeacherLastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.StudentFirstName.Name)
                    return StudentFirstName + " " + StudentLastName;
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.StudentLastName.Name)
                    return StudentLastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.RegistrationDate.Name)
                    return RegistrationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.MajorName.Name)
                    return MajorName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassesPrivate.MajorID.Name)
                    return MajorID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwClassesPrivateBO> Members
        public ViwClassesPrivateBO Clone()
        {
            return new ViwClassesPrivateBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwClassesPrivateBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwClassesPrivateBO it1, ViwClassesPrivateBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwClassesPrivateBO it1, ViwClassesPrivateBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwTeacherScheduleBO : IBusinessObject, ICloner<ViwTeacherScheduleBO>, IGridValue
    {
        #region Variables

        public string TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDate { get; set; }
        public int TimeID { get; set; }
        public int StartHour { get; set; }
        public int StartMin { get; set; }
        public int FinishHour { get; set; }
        public int FinishMin { get; set; }
        public int DayID { get; set; }
        public string DayName { get; set; }
        public string MajorName { get; set; }
        public int MajorID { get; set; }
        #endregion


        private TimeBO relTime;
        public TimeBO RelTime
        {
            get
            {
                if (relTime == null)
                {
                    relTime = new TimeBO();
                    relTime.TimeID = TimeID;
                    relTime.StartHour = StartHour;
                    relTime.StartMin = StartMin;
                    relTime.FinishHour = FinishHour;
                    relTime.FinishMin = FinishMin;
                }
                return relTime;
            }
        }

        private DayBO relDay;
        public DayBO RelDay
        {
            get
            {
                if (relDay == null)
                {
                    relDay = new DayBO();
                    relDay.DayID = DayID;
                    relDay.DayName = DayName;
                }
                return relDay;
            }
        }

        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                {
                    relTeacher = new TeacherBO();
                    relTeacher.TeacherID = TeacherID;
                    relTeacher.FirstName = FirstName;
                    relTeacher.LastName = LastName;
                }
                return relTeacher;
            }
        }

        #region Constructors

        public ViwTeacherScheduleBO()
        {
            // Nothing to do...
        }


        // Copy Constructor.
        public ViwTeacherScheduleBO(ViwTeacherScheduleBO copyViwTeacherScheduleBO)
        {
            this.TeacherID = copyViwTeacherScheduleBO.TeacherID;
            this.FirstName = copyViwTeacherScheduleBO.FirstName;
            this.LastName = copyViwTeacherScheduleBO.LastName;
            this.ClassID = copyViwTeacherScheduleBO.ClassID;
            this.ClassName = copyViwTeacherScheduleBO.ClassName;
            this.ClassDate = copyViwTeacherScheduleBO.ClassDate;
            this.TimeID = copyViwTeacherScheduleBO.TimeID;
            this.StartHour = copyViwTeacherScheduleBO.StartHour;
            this.StartMin = copyViwTeacherScheduleBO.StartMin;
            this.FinishHour = copyViwTeacherScheduleBO.FinishHour;
            this.FinishMin = copyViwTeacherScheduleBO.FinishMin;
            this.DayID = copyViwTeacherScheduleBO.DayID;
            this.DayName = copyViwTeacherScheduleBO.DayName;
            this.MajorName = copyViwTeacherScheduleBO.MajorName;
            this.MajorID = copyViwTeacherScheduleBO.MajorID;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwTeacherScheduleDA tmpViwTeacherScheduleDA = new ViwTeacherScheduleDA(this);
            return tmpViwTeacherScheduleDA.Add();
        }

        public bool Delete()
        {
            ViwTeacherScheduleDA tmpViwTeacherScheduleDA = new ViwTeacherScheduleDA(this);
            return tmpViwTeacherScheduleDA.Delete();
        }

        public bool Update()
        {
            ViwTeacherScheduleDA tmpViwTeacherScheduleDA = new ViwTeacherScheduleDA(this);
            return tmpViwTeacherScheduleDA.Update();
        }

        public static List<ViwTeacherScheduleBO> List()
        {
            return ViwTeacherScheduleDA.List();
        }
        public static List<ViwTeacherScheduleBO> List(string teacherID, int? classID, string classDate, int? timeID, int? startHour, int? startMin, int? finishHour, int? finishMin, int? dayID, int? majorID)
        {
            return ViwTeacherScheduleDA.List(teacherID, classID, classDate, timeID, startHour, startMin, finishHour, finishMin, dayID, majorID);
        }

        public static ViwTeacherScheduleBO Find()
        {
            return ViwTeacherScheduleDA.Find();
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.FirstName.Name)
                    return RelTeacher.FullName;
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.ClassDate.Name)
                    return ClassDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.TimeID.Name)
                    return RelTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.StartHour.Name)
                    return StartHour.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.StartMin.Name)
                    return StartMin.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.FinishHour.Name)
                    return FinishHour.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.FinishMin.Name)
                    return FinishMin.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.DayID.Name)
                    return DayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.DayName.Name)
                    return RelDay.DayName;
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.MajorName.Name)
                    return MajorName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSchedule.MajorID.Name)
                    return MajorID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwTeacherScheduleBO> Members
        public ViwTeacherScheduleBO Clone()
        {
            return new ViwTeacherScheduleBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwTeacherScheduleBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwTeacherScheduleBO it1, ViwTeacherScheduleBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwTeacherScheduleBO it1, ViwTeacherScheduleBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwClassHoldDetailsBO : IBusinessObject, ICloner<ViwClassHoldDetailsBO>, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public int HeldCount { get; set; }
        public int WillHoldCount { get; set; }
        public int HeldWithSuccessorTeacherCount { get; set; }
        public int SuspendendDueTeacherCount { get; set; }
        public int SuspendedDueStudentCount { get; set; }
        public int SuspendedDueNotificationCount { get; set; }
        public string ClassName { get; set; }
        public int MajorID { get; set; }
        public string TeacherID { get; set; }
        #endregion


        #region Constructors

        public ViwClassHoldDetailsBO()
        {
            // Nothing to do...
        }

        public ViwClassHoldDetailsBO(int classID)
        {
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ViwClassHoldDetailsBO(ViwClassHoldDetailsBO copyViwClassHoldDetailsBO)
        {
            this.ClassID = copyViwClassHoldDetailsBO.ClassID;
            this.HeldCount = copyViwClassHoldDetailsBO.HeldCount;
            this.WillHoldCount = copyViwClassHoldDetailsBO.WillHoldCount;
            this.HeldWithSuccessorTeacherCount = copyViwClassHoldDetailsBO.HeldWithSuccessorTeacherCount;
            this.SuspendendDueTeacherCount = copyViwClassHoldDetailsBO.SuspendendDueTeacherCount;
            this.SuspendedDueStudentCount = copyViwClassHoldDetailsBO.SuspendedDueStudentCount;
            this.SuspendedDueNotificationCount = copyViwClassHoldDetailsBO.SuspendedDueNotificationCount;
            this.ClassName = copyViwClassHoldDetailsBO.ClassName;
            this.MajorID = copyViwClassHoldDetailsBO.MajorID;
            this.TeacherID = copyViwClassHoldDetailsBO.TeacherID;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwClassHoldDetailsDA tmpViwClassHoldDetailsDA = new ViwClassHoldDetailsDA(this);
            return tmpViwClassHoldDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwClassHoldDetailsDA tmpViwClassHoldDetailsDA = new ViwClassHoldDetailsDA(this);
            return tmpViwClassHoldDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwClassHoldDetailsDA tmpViwClassHoldDetailsDA = new ViwClassHoldDetailsDA(this);
            return tmpViwClassHoldDetailsDA.Update();
        }

        public static List<ViwClassHoldDetailsBO> List()
        {
            return ViwClassHoldDetailsDA.List();
        }
        public static List<ViwClassHoldDetailsBO> List(int? classID, int? HeldCount, int? WillHoldCount, int? HeldWithSuccessorTeacherCount, int? SuspendendDueTeacherCount, int? SuspendedDueStudentCount, int? SuspendedDueNotificationCount, int? majorID, string teacherID)
        {
            return ViwClassHoldDetailsDA.List(classID, HeldCount, WillHoldCount, HeldWithSuccessorTeacherCount, SuspendendDueTeacherCount, SuspendedDueStudentCount, SuspendedDueNotificationCount, majorID, teacherID);
        }

        public static ViwClassHoldDetailsBO Find(int classID)
        {
            return ViwClassHoldDetailsDA.Find(classID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.HeldCount.Name)
                    return HeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.WillHoldCount.Name)
                    return WillHoldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.HeldWithSuccessorTeacherCount.Name)
                    return HeldWithSuccessorTeacherCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.SuspendendDueTeacherCount.Name)
                    return SuspendendDueTeacherCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.SuspendedDueStudentCount.Name)
                    return SuspendedDueStudentCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.SuspendedDueNotificationCount.Name)
                    return SuspendedDueNotificationCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.MajorID.Name)
                    return MajorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwClassHoldDetails.TeacherID.Name)
                    return TeacherID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwClassHoldDetailsBO> Members
        public ViwClassHoldDetailsBO Clone()
        {
            return new ViwClassHoldDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwClassHoldDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwClassHoldDetailsBO it1, ViwClassHoldDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwClassHoldDetailsBO it1, ViwClassHoldDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    //// Generated by DVD CodeGenerator
    //public partial class ObseleteViwStudentFinancialStatusBO : IBusinessObject, ICloner<ViwStudentFinancialStatusBO>, IGridValue
    //{
    //    #region Variables

    //    public int ClassID { get; set; }
    //    public string ClassName { get; set; }
    //    public string StudentID { get; set; }
    //    public string FullName { get; set; }
    //    public int RegisterationFee { get; set; }
    //    public int HavePaidValue { get; set; }
    //    public int MustPayValue { get; set; }
    //    public string Description { get; set; }
    //    #endregion


    //    #region Constructors

    //    public ViwStudentFinancialStatusBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public ViwStudentFinancialStatusBO(int classID, string studentID)
    //    {
    //        this.ClassID = classID;
    //        this.StudentID = studentID;
    //    }

    //    // Copy Constructor.
    //    public ViwStudentFinancialStatusBO(ViwStudentFinancialStatusBO copyViwStudentFinancialStatusBO)
    //    {
    //        this.ClassID = copyViwStudentFinancialStatusBO.ClassID;
    //        this.ClassName = copyViwStudentFinancialStatusBO.ClassName;
    //        this.StudentID = copyViwStudentFinancialStatusBO.StudentID;
    //        this.FullName = copyViwStudentFinancialStatusBO.FullName;
    //        this.RegisterationFee = copyViwStudentFinancialStatusBO.RegisterationFee;
    //        this.HavePaidValue = copyViwStudentFinancialStatusBO.HavePaidValue;
    //        this.MustPayValue = copyViwStudentFinancialStatusBO.MustPayValue;
    //        this.Description = copyViwStudentFinancialStatusBO.Description;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
    //        return tmpViwStudentFinancialStatusDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
    //        return tmpViwStudentFinancialStatusDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
    //        return tmpViwStudentFinancialStatusDA.Update();
    //    }

    //    public static List<ViwStudentFinancialStatusBO> List()
    //    {
    //        return ViwStudentFinancialStatusDA.List();
    //    }
    //    public static List<ViwStudentFinancialStatusBO> List(int? classID, string studentID)
    //    {
    //        return ViwStudentFinancialStatusDA.List(classID, studentID);
    //    }

    //    public static ViwStudentFinancialStatusBO Find(int classID, string studentID)
    //    {
    //        return ViwStudentFinancialStatusDA.Find(classID, studentID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassID.Name)
    //                return ClassID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassName.Name)
    //                return ClassName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentID.Name)
    //                return StudentID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.FullName.Name)
    //                return FullName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.RegisterationFee.Name)
    //                return RegisterationFee.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.HavePaidValue.Name)
    //                return HavePaidValue.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.MustPayValue.Name)
    //                return MustPayValue.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.Description.Name)
    //                return Description.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<ViwStudentFinancialStatusBO> Members
    //    public ViwStudentFinancialStatusBO Clone()
    //    {
    //        return new ViwStudentFinancialStatusBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (ViwStudentFinancialStatusBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(ViwStudentFinancialStatusBO it1, ViwStudentFinancialStatusBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.ClassID == it2.ClassID && it1.StudentID == it2.StudentID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(ViwStudentFinancialStatusBO it1, ViwStudentFinancialStatusBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class SessionPresenceBO : IBusinessObject, ICloner<SessionPresenceBO>, ILastChange, IGridValue
    {


        #region Variables

        public int ClassID { get; set; }
        public string ClassDate { get; set; }
        public int TimeID { get; set; }
        public string StudentID { get; set; }
        public int PresenceStatusID { get; set; }
        public string Description { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                    relStudent = StudentBO.Find(StudentID);
                return relStudent;
            }
            set { relStudent = value; }
        }

        private TimeBO relTime;
        public TimeBO RelTime
        {
            get
            {
                if (relTime == null)
                    relTime = TimeBO.Find(TimeID);
                return relTime;
            }
            set { relTime = value; }
        }

        private PresenceStatusBO relPresenceStatus;
        public PresenceStatusBO RelPresenceStatus
        {
            get
            {
                if (relPresenceStatus == null)
                    relPresenceStatus = PresenceStatusBO.Find(PresenceStatusID);
                return relPresenceStatus;
            }
            set { relPresenceStatus = value; }
        }

        private DayBO relDay;
        public DayBO RelDay
        {
            get
            {
                if (relDay == null)
                    relDay = DayBO.GetDay(new PersianDate(ClassDate).LocalizedWeekDayName);
                return relDay;
            }
            set { relDay = value; }
        }

        #region Constructors

        public SessionPresenceBO()
        {
            // Nothing to do...
        }

        public SessionPresenceBO(int classID, string classDate, int timeID, string studentID)
        {
            this.ClassID = classID;
            this.ClassDate = classDate;
            this.TimeID = timeID;
            this.StudentID = studentID;
        }

        // Copy Constructor.
        public SessionPresenceBO(SessionPresenceBO copySessionPresenceBO)
        {
            this.ClassID = copySessionPresenceBO.ClassID;
            this.ClassDate = copySessionPresenceBO.ClassDate;
            this.TimeID = copySessionPresenceBO.TimeID;
            this.StudentID = copySessionPresenceBO.StudentID;
            this.PresenceStatusID = copySessionPresenceBO.PresenceStatusID;
            this.Description = copySessionPresenceBO.Description;
            this.LastChangeID = copySessionPresenceBO.LastChangeID;
            this.LastChangeDate = copySessionPresenceBO.LastChangeDate;
            this.LastChangeTime = copySessionPresenceBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            SessionPresenceDA tmpSessionPresenceDA = new SessionPresenceDA(this);
            return tmpSessionPresenceDA.Add();
        }

        public bool Delete()
        {
            SessionPresenceDA tmpSessionPresenceDA = new SessionPresenceDA(this);
            return tmpSessionPresenceDA.Delete();
        }

        public bool Update()
        {
            SessionPresenceDA tmpSessionPresenceDA = new SessionPresenceDA(this);
            return tmpSessionPresenceDA.Update();
        }

        public static List<SessionPresenceBO> List()
        {
            return SessionPresenceDA.List();
        }
        public static List<SessionPresenceBO> List(int? classID, string classDate, int? timeID, string studentID, int? presenceStatusID)
        {
            return SessionPresenceDA.List(classID, classDate, timeID, studentID, presenceStatusID);
        }

        public static SessionPresenceBO Find(int classID, string classDate, int timeID, string studentID)
        {
            return SessionPresenceDA.Find(classID, classDate, timeID, studentID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.ClassDate.Name)
                    return ClassDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.TimeID.Name)
                    return RelTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.PresenceStatusID.Name)
                    return PresenceStatusID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.SessionPresence.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.Student.FirstName.Name)
                    return RelStudent.FullName;
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.PresenceStatusName.Name)
                    return RelPresenceStatus.PresenceStatusName;
                if (columnDefinition.Name == DatabaseSchema.Day.DayName.Name)
                    return RelDay.DayName;

            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<SessionPresenceBO> Members
        public SessionPresenceBO Clone()
        {
            return new SessionPresenceBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (SessionPresenceBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(SessionPresenceBO it1, SessionPresenceBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.ClassDate == it2.ClassDate && it1.TimeID == it2.TimeID && it1.StudentID == it2.StudentID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(SessionPresenceBO it1, SessionPresenceBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class PresenceStatusBO : IBusinessObject, ICloner<PresenceStatusBO>, IComboFillable, ILastChange, IGridValue
    {
        public enum PresenceStatus
        {
            NotHeldYet = 0,
            Present,
            Absent,
            NotHeld
        }
        #region Variables

        public int PresenceStatusID { get; set; }
        public string PresenceStatusName { get; set; }
        public string PresenceStatusDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public PresenceStatusBO()
        {
            // Nothing to do...
        }

        public PresenceStatusBO(int presenceStatusID)
        {
            this.PresenceStatusID = presenceStatusID;
        }

        // Copy Constructor.
        public PresenceStatusBO(PresenceStatusBO copyPresenceStatusBO)
        {
            this.PresenceStatusID = copyPresenceStatusBO.PresenceStatusID;
            this.PresenceStatusName = copyPresenceStatusBO.PresenceStatusName;
            this.PresenceStatusDescription = copyPresenceStatusBO.PresenceStatusDescription;
            this.LastChangeID = copyPresenceStatusBO.LastChangeID;
            this.LastChangeDate = copyPresenceStatusBO.LastChangeDate;
            this.LastChangeTime = copyPresenceStatusBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            PresenceStatusDA tmpPresenceStatusDA = new PresenceStatusDA(this);
            return tmpPresenceStatusDA.Add();
        }

        public bool Delete()
        {
            PresenceStatusDA tmpPresenceStatusDA = new PresenceStatusDA(this);
            return tmpPresenceStatusDA.Delete();
        }

        public bool Update()
        {
            PresenceStatusDA tmpPresenceStatusDA = new PresenceStatusDA(this);
            return tmpPresenceStatusDA.Update();
        }

        public static List<PresenceStatusBO> List()
        {
            return PresenceStatusDA.List();
        }

        public static PresenceStatusBO Find(int presenceStatusID)
        {
            return PresenceStatusDA.Find(presenceStatusID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.PresenceStatusID.Name)
                    return PresenceStatusID.ToString();
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.PresenceStatusName.Name)
                    return PresenceStatusName.ToString();
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.PresenceStatusDescription.Name)
                    return PresenceStatusDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.PresenceStatus.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return PresenceStatusName; }
        }

        public string ComboDescription
        {
            get { return PresenceStatusDescription; }
        }
        #endregion
        #region ICloner<PresenceStatusBO> Members
        public PresenceStatusBO Clone()
        {
            return new PresenceStatusBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (PresenceStatusBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(PresenceStatusBO it1, PresenceStatusBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PresenceStatusID == it2.PresenceStatusID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(PresenceStatusBO it1, PresenceStatusBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class IncomeStudentBO : IBusinessObject, ICloner<IncomeStudentBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string StudentID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public int ClassID { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                    relStudent = StudentBO.Find(StudentID);
                return relStudent;
            }
            set { relStudent = value; }
        }

        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        private PayTypeBO relPayType;
        public PayTypeBO RelPayType
        {
            get
            {
                if (relPayType == null)
                    relPayType = PayTypeBO.Find(PayTypeID);
                return relPayType;
            }
            set { relPayType = value; }
        }

        #region Constructors

        public IncomeStudentBO()
        {
            // Nothing to do...
        }

        public IncomeStudentBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public IncomeStudentBO(IncomeStudentBO copyIncomeStudentBO)
        {
            this.PayID = copyIncomeStudentBO.PayID;
            this.StudentID = copyIncomeStudentBO.StudentID;
            this.PayTypeID = copyIncomeStudentBO.PayTypeID;
            this.Fee = copyIncomeStudentBO.Fee;
            this.Discount = copyIncomeStudentBO.Discount;
            this.PayDate = copyIncomeStudentBO.PayDate;
            this.CheckDate = copyIncomeStudentBO.CheckDate;
            this.CheckNumber = copyIncomeStudentBO.CheckNumber;
            this.Description = copyIncomeStudentBO.Description;
            this.ClassID = copyIncomeStudentBO.ClassID;
            this.LastChangeID = copyIncomeStudentBO.LastChangeID;
            this.LastChangeDate = copyIncomeStudentBO.LastChangeDate;
            this.LastChangeTime = copyIncomeStudentBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeStudentDA tmpIncomeStudentDA = new IncomeStudentDA(this);
            return tmpIncomeStudentDA.Add();
        }

        public bool Delete()
        {
            IncomeStudentDA tmpIncomeStudentDA = new IncomeStudentDA(this);
            return tmpIncomeStudentDA.Delete();
        }

        public bool Update()
        {
            IncomeStudentDA tmpIncomeStudentDA = new IncomeStudentDA(this);
            return tmpIncomeStudentDA.Update();
        }

        public static List<IncomeStudentBO> List()
        {
            return IncomeStudentDA.List();
        }
        public static List<IncomeStudentBO> List(int? payID, string studentID, int? payTypeID, string payDate, string checkDate, string checkNumber, int? classID)
        {
            return IncomeStudentDA.List(payID, studentID, payTypeID, payDate, checkDate, checkNumber, classID);
        }

        public static IncomeStudentBO Find(int payID)
        {
            return IncomeStudentDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.Student.FirstName.Name)
                    return RelStudent.FullName;
                if (columnDefinition.Name == DatabaseSchema.Class.ClassName.Name)
                    return RelClass.ClassName;
                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeName.Name)
                    return RelPayType.PayTypeName;

                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStudent.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<IncomeStudentBO> Members
        public IncomeStudentBO Clone()
        {
            return new IncomeStudentBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeStudentBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeStudentBO it1, IncomeStudentBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeStudentBO it1, IncomeStudentBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class IncomeTeacherBO : IBusinessObject, ICloner<IncomeTeacherBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string TeacherID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public int ClassID { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion

        private ClassBO relClass;
        public ClassBO RelClass
        {
            get
            {
                if (relClass == null)
                    relClass = ClassBO.Find(ClassID);
                return relClass;
            }
            set { relClass = value; }
        }

        private TeacherBO relTeacher;
        public TeacherBO RelTeacher
        {
            get
            {
                if (relTeacher == null)
                    relTeacher = TeacherBO.Find(TeacherID);
                return relTeacher;
            }
            set { relTeacher = value; }
        }

        private PayTypeBO relPayType;
        public PayTypeBO RelPayType
        {
            get
            {
                if (relPayType == null)
                    relPayType = PayTypeBO.Find(PayTypeID);
                return relPayType;
            }
            set { relPayType = value; }
        }


        #region Constructors

        public IncomeTeacherBO()
        {
            // Nothing to do...
        }

        public IncomeTeacherBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public IncomeTeacherBO(IncomeTeacherBO copyIncomeTeacherBO)
        {
            this.PayID = copyIncomeTeacherBO.PayID;
            this.TeacherID = copyIncomeTeacherBO.TeacherID;
            this.PayTypeID = copyIncomeTeacherBO.PayTypeID;
            this.Fee = copyIncomeTeacherBO.Fee;
            this.Discount = copyIncomeTeacherBO.Discount;
            this.PayDate = copyIncomeTeacherBO.PayDate;
            this.CheckDate = copyIncomeTeacherBO.CheckDate;
            this.CheckNumber = copyIncomeTeacherBO.CheckNumber;
            this.Description = copyIncomeTeacherBO.Description;
            this.ClassID = copyIncomeTeacherBO.ClassID;
            this.LastChangeID = copyIncomeTeacherBO.LastChangeID;
            this.LastChangeDate = copyIncomeTeacherBO.LastChangeDate;
            this.LastChangeTime = copyIncomeTeacherBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeTeacherDA tmpIncomeTeacherDA = new IncomeTeacherDA(this);
            return tmpIncomeTeacherDA.Add();
        }

        public bool Delete()
        {
            IncomeTeacherDA tmpIncomeTeacherDA = new IncomeTeacherDA(this);
            return tmpIncomeTeacherDA.Delete();
        }

        public bool Update()
        {
            IncomeTeacherDA tmpIncomeTeacherDA = new IncomeTeacherDA(this);
            return tmpIncomeTeacherDA.Update();
        }

        public static List<IncomeTeacherBO> List(string teacherID, int? payTypeID, int? classID)
        {
            return IncomeTeacherDA.List(teacherID, payTypeID, classID);
        }
        public static List<IncomeTeacherBO> List()
        {
            return IncomeTeacherDA.List();
        }

        public static IncomeTeacherBO Find(int payID)
        {
            return IncomeTeacherDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeTeacher.LastChangeTime.Name)
                    return LastChangeTime.ToString();

                if (columnDefinition.Name == DatabaseSchema.PayType.PayTypeName.Name)
                    return RelPayType.PayTypeName;
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<IncomeTeacherBO> Members
        public IncomeTeacherBO Clone()
        {
            return new IncomeTeacherBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeTeacherBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeTeacherBO it1, IncomeTeacherBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeTeacherBO it1, IncomeTeacherBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    // Generated by DVD CodeGenerator
    //public partial class StoreStuffBOOld : IBusinessObject, ICloner<StoreStuffBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public string StuffID { get; set; }
    //    public int StuffTypeID { get; set; }
    //    public string StuffName { get; set; }
    //    public string BuyDate { get; set; }
    //    public int StuffCount { get; set; }
    //    public bool ActivityStatus { get; set; }
    //    public bool IsBalanced { get; set; }
    //    public bool IsSalesPersonAware { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    #endregion


    //    #region Constructors

    //    public StoreStuffBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public StoreStuffBO(string stuffID)
    //    {
    //        this.StuffID = stuffID;
    //    }

    //    // Copy Constructor.
    //    public StoreStuffBO(StoreStuffBO copyStoreStuffBO)
    //    {
    //        this.StuffID = copyStoreStuffBO.StuffID;
    //        this.StuffTypeID = copyStoreStuffBO.StuffTypeID;
    //        this.StuffName = copyStoreStuffBO.StuffName;
    //        this.BuyDate = copyStoreStuffBO.BuyDate;
    //        this.StuffCount = copyStoreStuffBO.StuffCount;
    //        this.ActivityStatus = copyStoreStuffBO.ActivityStatus;
    //        this.IsBalanced = copyStoreStuffBO.IsBalanced;
    //        this.IsSalesPersonAware = copyStoreStuffBO.IsSalesPersonAware;
    //        this.LastChangeID = copyStoreStuffBO.LastChangeID;
    //        this.LastChangeDate = copyStoreStuffBO.LastChangeDate;
    //        this.LastChangeTime = copyStoreStuffBO.LastChangeTime;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
    //        return tmpStoreStuffDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
    //        return tmpStoreStuffDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
    //        return tmpStoreStuffDA.Update();
    //    }

    //    public static List<StoreStuffBO> List()
    //    {
    //        return StoreStuffDA.List();
    //    }
    //    public static List<StoreStuffBO> List(int? stuffTypeID, string buyDate, bool? activityStatus, bool? isBalanced, bool? isSalesPersonAware)
    //    {
    //        return StoreStuffDA.List(stuffTypeID, buyDate, activityStatus, isBalanced, isSalesPersonAware);
    //    }

    //    public static StoreStuffBO Find(string stuffID)
    //    {
    //        return StoreStuffDA.Find(stuffID);
    //    }
    //    #endregion

    //    public static string GenerateKey(int stuffTypeID)
    //    {
    //        string firstPart = stuffTypeID.ToString().PadLeft(6, '0');
    //        List<string> keys = StoreStuffDA.GetKeyPattern(firstPart);
    //        for (int i = 1; i < 1000; i++)
    //        {
    //            string candidKey = firstPart + i.ToString().PadLeft(10, '0');
    //            bool found = false;
    //            foreach (string key in keys)
    //            {
    //                if (key.Trim() == candidKey)
    //                {
    //                    found = true;
    //                    break;
    //                }
    //            }
    //            if (!found)
    //            {
    //                return candidKey;
    //            }
    //        }
    //        return "0000000000000000";
    //    }

    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffID.Name)
    //                return StuffID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffTypeID.Name)
    //                return StuffTypeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffName.Name)
    //                return StuffName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.BuyDate.Name)
    //                return BuyDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffCount.Name)
    //                return StuffCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.ActivityStatus.Name)
    //                return ActivityStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.IsBalanced.Name)
    //                return IsBalanced.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.IsSalesPersonAware.Name)
    //                return IsSalesPersonAware.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<StoreStuffBO> Members
    //    public StoreStuffBO Clone()
    //    {
    //        return new StoreStuffBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (StoreStuffBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(StoreStuffBO it1, StoreStuffBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.StuffID == it2.StuffID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(StoreStuffBO it1, StoreStuffBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class StoreStuffBO : IBusinessObject, ICloner<StoreStuffBO>, ILastChange, IGridValue, IActivityManager<StoreStuffBO>
    {
        #region Variables

        public string StuffID { get; set; }
        public int StuffTypeID { get; set; }
        public string StuffName { get; set; }
        public string BuyDate { get; set; }
        public int StuffCount { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsBalanced { get; set; }
        public bool IsSalesPersonAware { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public int StuffPrice { get; set; }
        #endregion

        private StuffTypeBO _relStuffType;
        public StuffTypeBO RelStuffType
        {
            get
            {
                if (_relStuffType == null)
                    _relStuffType = StuffTypeBO.Find(StuffTypeID);
                return _relStuffType;
            }
            set { _relStuffType = value; }
        }

        private ViwStuffAvailableDetailsBO _relViwStuffAvailableDetails;
        public ViwStuffAvailableDetailsBO RelViwStuffAvailableDetails
        {
            get
            {
                if (_relViwStuffAvailableDetails == null)
                    _relViwStuffAvailableDetails = ViwStuffAvailableDetailsBO.Find(StuffID);
                return _relViwStuffAvailableDetails;
            }
            set { _relViwStuffAvailableDetails = value; }
        }

        #region Constructors

        public StoreStuffBO()
        {
            // Nothing to do...
        }

        public StoreStuffBO(string stuffID)
        {
            this.StuffID = stuffID;
        }

        // Copy Constructor.
        public StoreStuffBO(StoreStuffBO copyStoreStuffBO)
        {
            this.StuffID = copyStoreStuffBO.StuffID;
            this.StuffTypeID = copyStoreStuffBO.StuffTypeID;
            this.StuffName = copyStoreStuffBO.StuffName;
            this.BuyDate = copyStoreStuffBO.BuyDate;
            this.StuffCount = copyStoreStuffBO.StuffCount;
            this.ActivityStatus = copyStoreStuffBO.ActivityStatus;
            this.IsBalanced = copyStoreStuffBO.IsBalanced;
            this.IsSalesPersonAware = copyStoreStuffBO.IsSalesPersonAware;
            this.LastChangeID = copyStoreStuffBO.LastChangeID;
            this.LastChangeDate = copyStoreStuffBO.LastChangeDate;
            this.LastChangeTime = copyStoreStuffBO.LastChangeTime;
            this.StuffPrice = copyStoreStuffBO.StuffPrice;


        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
            return tmpStoreStuffDA.Add();
        }

        public bool Delete()
        {
            StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
            return tmpStoreStuffDA.Delete();
        }

        public bool Update()
        {
            StoreStuffDA tmpStoreStuffDA = new StoreStuffDA(this);
            return tmpStoreStuffDA.Update();
        }

        public static List<StoreStuffBO> List(int? stuffTypeID, string buyDate, int? stuffCount, bool? activityStatus, bool? isBalanced, bool? isSalesPersonAware, int? stuffPrice)
        {
            return StoreStuffDA.List(stuffTypeID, buyDate, stuffCount, activityStatus, isBalanced, isSalesPersonAware, stuffPrice);
        }
        public static List<StoreStuffBO> List()
        {
            return StoreStuffDA.List();
        }

        public static StoreStuffBO Find(string stuffID)
        {
            return StoreStuffDA.Find(stuffID);
        }
        #endregion

        public static string GenerateKey(int stuffTypeID)
        {
            string firstPart = stuffTypeID.ToString().PadLeft(6, '0');
            List<string> keys = StoreStuffDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + i.ToString().PadLeft(10, '0');
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "0000000000000000";
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffName.Name)
                    return StuffName.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.BuyDate.Name)
                    return BuyDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffCount.Name)
                    return StuffCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.IsBalanced.Name)
                    return IsBalanced.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.IsSalesPersonAware.Name)
                    return IsSalesPersonAware.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreStuff.StuffPrice.Name)
                    return StuffPrice.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.StuffTypeName.Name)
                    return _relStuffType.StuffTypeName;
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.InitCount.Name)
                    return _relViwStuffAvailableDetails.InitCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.SoldCount.Name)
                    return _relViwStuffAvailableDetails.SoldCount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<StoreStuffBO> Members
        public StoreStuffBO Clone()
        {
            return new StoreStuffBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (StoreStuffBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(StoreStuffBO it1, StoreStuffBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StuffID == it2.StuffID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(StoreStuffBO it1, StoreStuffBO it2)
        {
            return !(it1 == it2);
        }
        #endregion

        #region IActivityManager<StoreStuffBO> Members

        public List<StoreStuffBO> List(bool? activityStatus)
        {
            return StoreStuffDA.List(null, null, null, activityStatus, null, null, null);
        }

        public List<StoreStuffBO> ListDeactiveCandidates()
        {
            return StoreStuffDA.ListDeactiveCandidates(null);
        }

        #endregion

        #region IActivityStatus Members

        public bool SetStatus(bool newStatus)
        {
            bool result = true;
            ActivitySetter setter = new ActivitySetter("storeStuff", "activityStatus", new List<ActivitySetter.KeyInfo>
            {
                new ActivitySetter.KeyInfo("stuffID", "'" + StuffID.ToString() + "'")
            });
            result &= setter.SetStatus(newStatus);

            // Setting Shops...
            List<StoreShopBO> shops = StoreShopBO.List(StuffID, null, null, null, null, null, null, null);
            foreach (StoreShopBO shop in shops)
            {
                ActivitySetter shopSetter = new ActivitySetter("storeShop", "activityStatus", new List<ActivitySetter.KeyInfo>
                {
                    new ActivitySetter.KeyInfo("shopID", "'"+ shop.ShopID.ToString()+"'")
                });
                result &= shopSetter.SetStatus(newStatus);
            }
            return result;
        }

        public string StatusDescription
        {
            get
            {
                string ans = "";
                if (IsDeactiveCandidate())
                    ans = "این کالا برای غیرفعال‌سازی پیشنهاد می‌شود.";
                else if (ActivityStatus)
                    ans = "کالا فعال است.";
                else
                    ans = "کالا غیرفعال است.";

                int initCount = RelViwStuffAvailableDetails.InitCount;
                int soldCount = RelViwStuffAvailableDetails.SoldCount.HasValue ? RelViwStuffAvailableDetails.SoldCount.Value : 0;

                AdditionalInformation = "تعداد " + soldCount.ToString() + " از " + initCount.ToString() + " کالای اولیه فروخته شده است.";

                return ans;
            }
        }

        public string AdditionalInformation
        {
            get;
            set;
        }

        public bool IsDeactiveCandidate()
        {
            if (StoreStuffDA.ListDeactiveCandidates(StuffID).Count == 0)
                return false;
            else
                return true;
        }

        public List<ColumnDefinition> StatusInfoColumns
        {
            get
            {
                return new List<ColumnDefinition>
                {
                    DatabaseSchema.StoreStuff.StuffID,
                    DatabaseSchema.StoreStuff.StuffName,
                    DatabaseSchema.StoreStuff.BuyDate,
                    DatabaseSchema.StuffType.StuffTypeName,
                    DatabaseSchema.ViwStuffAvailableDetails.InitCount,
                    DatabaseSchema.ViwStuffAvailableDetails.SoldCount
                };
            }
        }

        public string CaseName
        {
            get { return "کالا"; }
        }

        public string CaseNameI
        {
            get { return "کالایی"; }
        }

        public string DeactiveRule
        {
            get { return "کالا‌هایی که تمام اقلام خریدش به فروش رسیده باشد و مدیر آن‌ها را تائید کرده باشد برای غیرفعال‌سازی پیشنهاد می‌شوند."; }
        }

        #endregion
    }


    // Generated by DVD CodeGenerator
    //public partial class StoreShopBO : IBusinessObject, ICloner<StoreShopBO>, ILastChange, IGridValue
    //{
    //    #region Variables

    //    public string ShopID { get; set; }
    //    public string StuffID { get; set; }
    //    public string CustomerID { get; set; }
    //    public string CustomerName { get; set; }
    //    public int ShopCount { get; set; }
    //    public string ShopDescription { get; set; }
    //    public bool ActivityStatus { get; set; }
    //    public bool IsManagerAware { get; set; }
    //    public string LastChangeID { get; set; }
    //    public string LastChangeDate { get; set; }
    //    public string LastChangeTime { get; set; }
    //    #endregion


    //    #region Constructors

    //    public StoreShopBO()
    //    {
    //        // Nothing to do...
    //    }

    //    public StoreShopBO(string shopID)
    //    {
    //        this.ShopID = shopID;
    //    }

    //    // Copy Constructor.
    //    public StoreShopBO(StoreShopBO copyStoreShopBO)
    //    {
    //        this.ShopID = copyStoreShopBO.ShopID;
    //        this.StuffID = copyStoreShopBO.StuffID;
    //        this.CustomerID = copyStoreShopBO.CustomerID;
    //        this.CustomerName = copyStoreShopBO.CustomerName;
    //        this.ShopCount = copyStoreShopBO.ShopCount;
    //        this.ShopDescription = copyStoreShopBO.ShopDescription;
    //        this.ActivityStatus = copyStoreShopBO.ActivityStatus;
    //        this.IsManagerAware = copyStoreShopBO.IsManagerAware;
    //        this.LastChangeID = copyStoreShopBO.LastChangeID;
    //        this.LastChangeDate = copyStoreShopBO.LastChangeDate;
    //        this.LastChangeTime = copyStoreShopBO.LastChangeTime;
    //    }
    //    #endregion


    //    #region Methods (IBusinessObject)

    //    public bool Add()
    //    {
    //        StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
    //        return tmpStoreShopDA.Add();
    //    }

    //    public bool Delete()
    //    {
    //        StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
    //        return tmpStoreShopDA.Delete();
    //    }

    //    public bool Update()
    //    {
    //        StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
    //        return tmpStoreShopDA.Update();
    //    }

    //    public static List<StoreShopBO> List()
    //    {
    //        return StoreShopDA.List();
    //    }
    //    public static List<StoreShopBO> List(string stuffID, string customerID, string customerName, int? shopCount, string shopDescription, bool? activityStatus, bool? isManagerAware)
    //    {
    //        return StoreShopDA.List(stuffID, customerID, customerName, shopCount, shopDescription, activityStatus, isManagerAware);
    //    }

    //    public static StoreShopBO Find(string shopID)
    //    {
    //        return StoreShopDA.Find(shopID);
    //    }
    //    #endregion


    //    #region Interfaces
    //    #region IGridValue Members
    //    public string GetGridValue(ColumnDefinition columnDefinition)
    //    {
    //        try
    //        {
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopID.Name)
    //                return ShopID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.StuffID.Name)
    //                return StuffID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.CustomerID.Name)
    //                return CustomerID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.CustomerName.Name)
    //                return CustomerName.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopCount.Name)
    //                return ShopCount.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopDescription.Name)
    //                return ShopDescription.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.ActivityStatus.Name)
    //                return ActivityStatus.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.IsManagerAware.Name)
    //                return IsManagerAware.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeID.Name)
    //                return LastChangeID.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeDate.Name)
    //                return LastChangeDate.ToString();
    //            if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeTime.Name)
    //                return LastChangeTime.ToString();
    //        }
    //        catch (NullReferenceException) { }
    //        return "";
    //    }
    //    #endregion
    //    #region ICloner<StoreShopBO> Members
    //    public StoreShopBO Clone()
    //    {
    //        return new StoreShopBO(this);
    //    }
    //    #endregion
    //    #endregion


    //    #region Operators
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;
    //        return this == (StoreShopBO)obj;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public static bool operator ==(StoreShopBO it1, StoreShopBO it2)
    //    {
    //        bool ans = false;
    //        if ((object)it1 == null && (object)it2 == null)
    //            return true;
    //        try
    //        {
    //            ans = true && it1.ShopID == it2.ShopID;
    //        }
    //        catch (Exception) { }
    //        return ans;
    //    }

    //    public static bool operator !=(StoreShopBO it1, StoreShopBO it2)
    //    {
    //        return !(it1 == it2);
    //    }
    //    #endregion
    //}

    // Generated by DVD CodeGenerator
    public partial class StoreShopBO : IBusinessObject, ICloner<StoreShopBO>, ILastChange, IGridValue
    {
        #region Variables

        public string ShopID { get; set; }
        public string StuffID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int ShopCount { get; set; }
        public string ShopDescription { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsManagerAware { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public string ShopDate { get; set; }
        #endregion


        #region Constructors

        public StoreShopBO()
        {
            // Nothing to do...
        }

        public StoreShopBO(string shopID)
        {
            this.ShopID = shopID;
        }

        // Copy Constructor.
        public StoreShopBO(StoreShopBO copyStoreShopBO)
        {
            this.ShopID = copyStoreShopBO.ShopID;
            this.StuffID = copyStoreShopBO.StuffID;
            this.CustomerID = copyStoreShopBO.CustomerID;
            this.CustomerName = copyStoreShopBO.CustomerName;
            this.ShopCount = copyStoreShopBO.ShopCount;
            this.ShopDescription = copyStoreShopBO.ShopDescription;
            this.ActivityStatus = copyStoreShopBO.ActivityStatus;
            this.IsManagerAware = copyStoreShopBO.IsManagerAware;
            this.LastChangeID = copyStoreShopBO.LastChangeID;
            this.LastChangeDate = copyStoreShopBO.LastChangeDate;
            this.LastChangeTime = copyStoreShopBO.LastChangeTime;
            this.ShopDate = copyStoreShopBO.ShopDate;
        }
        #endregion

        private StudentBO relStudent;
        public StudentBO RelStudent
        {
            get
            {
                if (relStudent == null)
                    relStudent = StudentBO.Find(CustomerID);
                return relStudent;
            }
            set { relStudent = value; }
        }

        private StoreStuffBO relStuff;
        public StoreStuffBO RelStuff
        {
            get
            {
                if (relStuff == null)
                    relStuff = StoreStuffBO.Find(StuffID);
                return relStuff;
            }
            set { relStuff = value; }
        }

        public string FinalCustomerName
        {
            get
            {
                if (CustomerID != null)
                    return RelStudent.FullName;
                else
                    return CustomerName;
            }
        }

        #region Methods (IBusinessObject)

        public bool Add()
        {
            StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
            return tmpStoreShopDA.Add();
        }

        public bool Delete()
        {
            StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
            if (!tmpStoreShopDA.Delete()) return false;
            List<IncomeStoreSellBO> pays = IncomeStoreSellBO.List(ShopID, null, null, null, null, null, null);
            foreach (IncomeStoreSellBO pay in pays)
            {
                if (!pay.Delete()) return false;
            }
            return true;
        }

        public bool Update()
        {
            StoreShopDA tmpStoreShopDA = new StoreShopDA(this);
            return tmpStoreShopDA.Update();
        }

        public static List<StoreShopBO> List()
        {
            return StoreShopDA.List();
        }
        public static List<StoreShopBO> List(string stuffID, string customerID, string customerName, int? shopCount, string shopDescription, bool? activityStatus, bool? isManagerAware, string shopDate)
        {
            return StoreShopDA.List(stuffID, customerID, customerName, shopCount, shopDescription, activityStatus, isManagerAware, shopDate);
        }

        public static StoreShopBO Find(string shopID)
        {
            return StoreShopDA.Find(shopID);
        }
        #endregion

        public static string GenerateKey(string stuffID)
        {
            string firstPart = stuffID.PadLeft(16, '0');
            List<string> keys = StoreShopDA.GetKeyPattern(firstPart);
            for (int i = 1; i < 1000; i++)
            {
                string candidKey = firstPart + i.ToString().PadLeft(4, '0');
                bool found = false;
                foreach (string key in keys)
                {
                    if (key.Trim() == candidKey)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return candidKey;
                }
            }
            return "00000000000000000000";
        }

        public bool SetManagerAware(bool isManagerAware)
        {
            return new StoreShopDA(this).SetManagerAware(isManagerAware);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopID.Name)
                    return ShopID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.CustomerID.Name)
                    return CustomerID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.CustomerName.Name)
                    return CustomerName.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopCount.Name)
                    return ShopCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopDescription.Name)
                    return ShopDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.IsManagerAware.Name)
                    return IsManagerAware.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.StoreShop.ShopDate.Name)
                    return ShopDate.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<StoreShopBO> Members
        public StoreShopBO Clone()
        {
            return new StoreShopBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (StoreShopBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(StoreShopBO it1, StoreShopBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ShopID == it2.ShopID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(StoreShopBO it1, StoreShopBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    // Generated by DVD CodeGenerator
    public partial class StuffTypeBO : IBusinessObject, ICloner<StuffTypeBO>, ILastChange, IGridValue, IComboFillable
    {
        #region Variables

        public int StuffTypeID { get; set; }
        public string StuffTypeName { get; set; }
        public string StuffTypeDescription { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public StuffTypeBO()
        {
            // Nothing to do...
        }

        public StuffTypeBO(int stuffTypeID)
        {
            this.StuffTypeID = stuffTypeID;
        }

        // Copy Constructor.
        public StuffTypeBO(StuffTypeBO copyStuffTypeBO)
        {
            this.StuffTypeID = copyStuffTypeBO.StuffTypeID;
            this.StuffTypeName = copyStuffTypeBO.StuffTypeName;
            this.StuffTypeDescription = copyStuffTypeBO.StuffTypeDescription;
            this.LastChangeID = copyStuffTypeBO.LastChangeID;
            this.LastChangeDate = copyStuffTypeBO.LastChangeDate;
            this.LastChangeTime = copyStuffTypeBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            StuffTypeDA tmpStuffTypeDA = new StuffTypeDA(this);
            return tmpStuffTypeDA.Add();
        }

        public bool Delete()
        {
            StuffTypeDA tmpStuffTypeDA = new StuffTypeDA(this);
            return tmpStuffTypeDA.Delete();
        }

        public bool Update()
        {
            StuffTypeDA tmpStuffTypeDA = new StuffTypeDA(this);
            return tmpStuffTypeDA.Update();
        }

        public static List<StuffTypeBO> List()
        {
            return StuffTypeDA.List();
        }

        public static StuffTypeBO Find(int stuffTypeID)
        {
            return StuffTypeDA.Find(stuffTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.StuffType.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.StuffTypeName.Name)
                    return StuffTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.StuffTypeDescription.Name)
                    return StuffTypeDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.StuffType.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region IComboFillable
        public string ComboText
        {
            get { return StuffTypeName; }
        }

        public string ComboDescription
        {
            get { return StuffTypeDescription; }
        }
        #endregion
        #region ICloner<StuffTypeBO> Members
        public StuffTypeBO Clone()
        {
            return new StuffTypeBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (StuffTypeBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(StuffTypeBO it1, StuffTypeBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StuffTypeID == it2.StuffTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(StuffTypeBO it1, StuffTypeBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStuffAvailableDetailsBO : IBusinessObject, ICloner<ViwStuffAvailableDetailsBO>, IGridValue
    {
        #region Variables

        public string StuffID { get; set; }
        public int StuffTypeID { get; set; }
        public string StuffName { get; set; }
        public string BuyDate { get; set; }
        public int InitCount { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsBalanced { get; set; }
        public bool IsSalesPersonAware { get; set; }
        public int? SoldCount { get; set; }
        public int? AvailableCount { get; set; }
        #endregion


        #region Constructors

        public ViwStuffAvailableDetailsBO()
        {
            // Nothing to do...
        }

        public ViwStuffAvailableDetailsBO(string stuffID)
        {
            this.StuffID = stuffID;
        }

        // Copy Constructor.
        public ViwStuffAvailableDetailsBO(ViwStuffAvailableDetailsBO copyViwStuffAvailableDetailsBO)
        {
            this.StuffID = copyViwStuffAvailableDetailsBO.StuffID;
            this.StuffTypeID = copyViwStuffAvailableDetailsBO.StuffTypeID;
            this.StuffName = copyViwStuffAvailableDetailsBO.StuffName;
            this.BuyDate = copyViwStuffAvailableDetailsBO.BuyDate;
            this.InitCount = copyViwStuffAvailableDetailsBO.InitCount;
            this.ActivityStatus = copyViwStuffAvailableDetailsBO.ActivityStatus;
            this.IsBalanced = copyViwStuffAvailableDetailsBO.IsBalanced;
            this.IsSalesPersonAware = copyViwStuffAvailableDetailsBO.IsSalesPersonAware;
            this.SoldCount = copyViwStuffAvailableDetailsBO.SoldCount;
            this.AvailableCount = copyViwStuffAvailableDetailsBO.AvailableCount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStuffAvailableDetailsDA tmpViwStuffAvailableDetailsDA = new ViwStuffAvailableDetailsDA(this);
            return tmpViwStuffAvailableDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwStuffAvailableDetailsDA tmpViwStuffAvailableDetailsDA = new ViwStuffAvailableDetailsDA(this);
            return tmpViwStuffAvailableDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwStuffAvailableDetailsDA tmpViwStuffAvailableDetailsDA = new ViwStuffAvailableDetailsDA(this);
            return tmpViwStuffAvailableDetailsDA.Update();
        }

        public static List<ViwStuffAvailableDetailsBO> List()
        {
            return ViwStuffAvailableDetailsDA.List();
        }
        public static List<ViwStuffAvailableDetailsBO> List(int? stuffTypeID, string stuffName, string buyDate, int? initCount, bool? activityStatus, bool? isBalanced, bool? isSalesPersonAware, int? soldCount, int? availableCount)
        {
            return ViwStuffAvailableDetailsDA.List(stuffTypeID, stuffName, buyDate, initCount, activityStatus, isBalanced, isSalesPersonAware, soldCount, availableCount);
        }

        public static ViwStuffAvailableDetailsBO Find(string stuffID)
        {
            return ViwStuffAvailableDetailsDA.Find(stuffID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.StuffName.Name)
                    return StuffName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.BuyDate.Name)
                    return BuyDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.InitCount.Name)
                    return InitCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.IsBalanced.Name)
                    return IsBalanced.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.IsSalesPersonAware.Name)
                    return IsSalesPersonAware.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.SoldCount.Name)
                    return SoldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffAvailableDetails.AvailableCount.Name)
                    return AvailableCount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStuffAvailableDetailsBO> Members
        public ViwStuffAvailableDetailsBO Clone()
        {
            return new ViwStuffAvailableDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStuffAvailableDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStuffAvailableDetailsBO it1, ViwStuffAvailableDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StuffID == it2.StuffID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStuffAvailableDetailsBO it1, ViwStuffAvailableDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStuffTypeAvailableDetailsBO : IBusinessObject, ICloner<ViwStuffTypeAvailableDetailsBO>, IGridValue
    {
        #region Variables

        public int StuffTypeID { get; set; }
        public string StuffTypeName { get; set; }
        public int? InitCount { get; set; }
        public int? SoldCount { get; set; }
        public int? AvailableCount { get; set; }
        #endregion


        #region Constructors

        public ViwStuffTypeAvailableDetailsBO()
        {
            // Nothing to do...
        }

        public ViwStuffTypeAvailableDetailsBO(int stuffTypeID)
        {
            this.StuffTypeID = stuffTypeID;
        }

        // Copy Constructor.
        public ViwStuffTypeAvailableDetailsBO(ViwStuffTypeAvailableDetailsBO copyViwStuffTypeAvailableDetailsBO)
        {
            this.StuffTypeID = copyViwStuffTypeAvailableDetailsBO.StuffTypeID;
            this.StuffTypeName = copyViwStuffTypeAvailableDetailsBO.StuffTypeName;
            this.InitCount = copyViwStuffTypeAvailableDetailsBO.InitCount;
            this.SoldCount = copyViwStuffTypeAvailableDetailsBO.SoldCount;
            this.AvailableCount = copyViwStuffTypeAvailableDetailsBO.AvailableCount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStuffTypeAvailableDetailsDA tmpViwStuffTypeAvailableDetailsDA = new ViwStuffTypeAvailableDetailsDA(this);
            return tmpViwStuffTypeAvailableDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwStuffTypeAvailableDetailsDA tmpViwStuffTypeAvailableDetailsDA = new ViwStuffTypeAvailableDetailsDA(this);
            return tmpViwStuffTypeAvailableDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwStuffTypeAvailableDetailsDA tmpViwStuffTypeAvailableDetailsDA = new ViwStuffTypeAvailableDetailsDA(this);
            return tmpViwStuffTypeAvailableDetailsDA.Update();
        }

        public static List<ViwStuffTypeAvailableDetailsBO> List()
        {
            return ViwStuffTypeAvailableDetailsDA.List();
        }
        public static List<ViwStuffTypeAvailableDetailsBO> List(int? stuffTypeID, int? initCount, int? soldCount, int? availableCount)
        {
            return ViwStuffTypeAvailableDetailsDA.List(stuffTypeID, initCount, soldCount, availableCount);
        }

        public static ViwStuffTypeAvailableDetailsBO Find(int stuffTypeID)
        {
            return ViwStuffTypeAvailableDetailsDA.Find(stuffTypeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStuffTypeAvailableDetails.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffTypeAvailableDetails.StuffTypeName.Name)
                    return StuffTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffTypeAvailableDetails.InitCount.Name)
                    return InitCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffTypeAvailableDetails.SoldCount.Name)
                    return SoldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStuffTypeAvailableDetails.AvailableCount.Name)
                    return AvailableCount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStuffTypeAvailableDetailsBO> Members
        public ViwStuffTypeAvailableDetailsBO Clone()
        {
            return new ViwStuffTypeAvailableDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStuffTypeAvailableDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStuffTypeAvailableDetailsBO it1, ViwStuffTypeAvailableDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StuffTypeID == it2.StuffTypeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStuffTypeAvailableDetailsBO it1, ViwStuffTypeAvailableDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwShopSalesPersonBO : IBusinessObject, ICloner<ViwShopSalesPersonBO>, IGridValue
    {
        #region Variables

        public string ShopID { get; set; }
        public string StuffID { get; set; }
        public string CustomerName { get; set; }
        public int ShopCount { get; set; }
        public string ShopDate { get; set; }
        public string ShopDescription { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsManagerAware { get; set; }
        public string StudentID { get; set; }
        public string StuffName { get; set; }
        public int StuffTypeID { get; set; }
        public int StuffPrice { get; set; }
        public int PaidAmount { get; set; }
        #endregion


        #region Constructors

        public ViwShopSalesPersonBO()
        {
            // Nothing to do...
        }

        public ViwShopSalesPersonBO(string shopID)
        {
            this.ShopID = shopID;
        }

        // Copy Constructor.
        public ViwShopSalesPersonBO(ViwShopSalesPersonBO copyViwShopSalesPersonBO)
        {
            this.ShopID = copyViwShopSalesPersonBO.ShopID;
            this.StuffID = copyViwShopSalesPersonBO.StuffID;
            this.CustomerName = copyViwShopSalesPersonBO.CustomerName;
            this.ShopCount = copyViwShopSalesPersonBO.ShopCount;
            this.ShopDate = copyViwShopSalesPersonBO.ShopDate;
            this.ShopDescription = copyViwShopSalesPersonBO.ShopDescription;
            this.ActivityStatus = copyViwShopSalesPersonBO.ActivityStatus;
            this.IsManagerAware = copyViwShopSalesPersonBO.IsManagerAware;
            this.StudentID = copyViwShopSalesPersonBO.StudentID;
            this.StuffName = copyViwShopSalesPersonBO.StuffName;
            this.StuffTypeID = copyViwShopSalesPersonBO.StuffTypeID;
            this.StuffPrice = copyViwShopSalesPersonBO.StuffPrice;
            this.PaidAmount = copyViwShopSalesPersonBO.PaidAmount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwShopSalesPersonDA tmpViwShopSalesPersonDA = new ViwShopSalesPersonDA(this);
            return tmpViwShopSalesPersonDA.Add();
        }

        public bool Delete()
        {
            ViwShopSalesPersonDA tmpViwShopSalesPersonDA = new ViwShopSalesPersonDA(this);
            return tmpViwShopSalesPersonDA.Delete();
        }

        public bool Update()
        {
            ViwShopSalesPersonDA tmpViwShopSalesPersonDA = new ViwShopSalesPersonDA(this);
            return tmpViwShopSalesPersonDA.Update();
        }

        public static List<ViwShopSalesPersonBO> List()
        {
            return ViwShopSalesPersonDA.List();
        }
        public static List<ViwShopSalesPersonBO> List(string stuffID, string customerName, int? shopCount, string shopDate, bool? activityStatus, bool? isManagerAware, string studentID, string stuffName, int? stuffTypeID, int? stuffPrice, int? paidAmount)
        {
            return ViwShopSalesPersonDA.List(stuffID, customerName, shopCount, shopDate, activityStatus, isManagerAware, studentID, stuffName, stuffTypeID, stuffPrice, paidAmount);
        }

        public static ViwShopSalesPersonBO Find(string shopID)
        {
            return ViwShopSalesPersonDA.Find(shopID);
        }
        #endregion

        public static List<ViwShopSalesPersonBO> ListInterval(int? stuffTypeID, string shopDateFrom, string shopDateTo)
        {
            return ViwShopSalesPersonDA.ListInterval(stuffTypeID, shopDateFrom, shopDateTo);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.ShopID.Name)
                    return ShopID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.CustomerName.Name)
                    return CustomerName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.StuffName.Name)
                    return StuffName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.ShopCount.Name)
                    return ShopCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.PaidAmount.Name)
                    return PaidAmount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.ShopDate.Name)
                    return ShopDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.ShopDescription.Name)
                    return ShopDescription.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.IsManagerAware.Name)
                    return IsManagerAware.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwShopSalesPerson.StuffPrice.Name)
                    return StuffPrice.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwShopSalesPersonBO> Members
        public ViwShopSalesPersonBO Clone()
        {
            return new ViwShopSalesPersonBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwShopSalesPersonBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwShopSalesPersonBO it1, ViwShopSalesPersonBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ShopID == it2.ShopID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwShopSalesPersonBO it1, ViwShopSalesPersonBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class IncomeStoreSellBO : IBusinessObject, ICloner<IncomeStoreSellBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string ShopID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public int PayTypeID { get; set; }
        public string CheckDate { get; set; }
        public string Description { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public string CheckNumber { get; set; }
        #endregion

        private StoreShopBO relShop;
        public StoreShopBO RelShop
        {
            get
            {
                if (relShop == null)
                    relShop = StoreShopBO.Find(ShopID);
                return relShop;
            }
            set { relShop = value; }
        }

        #region Constructors

        public IncomeStoreSellBO()
        {
            // Nothing to do...
        }

        public IncomeStoreSellBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public IncomeStoreSellBO(IncomeStoreSellBO copyIncomeStoreSellBO)
        {
            this.PayID = copyIncomeStoreSellBO.PayID;
            this.ShopID = copyIncomeStoreSellBO.ShopID;
            this.Fee = copyIncomeStoreSellBO.Fee;
            this.Discount = copyIncomeStoreSellBO.Discount;
            this.PayDate = copyIncomeStoreSellBO.PayDate;
            this.PayTypeID = copyIncomeStoreSellBO.PayTypeID;
            this.CheckDate = copyIncomeStoreSellBO.CheckDate;
            this.Description = copyIncomeStoreSellBO.Description;
            this.LastChangeID = copyIncomeStoreSellBO.LastChangeID;
            this.LastChangeDate = copyIncomeStoreSellBO.LastChangeDate;
            this.LastChangeTime = copyIncomeStoreSellBO.LastChangeTime;
            this.CheckNumber = copyIncomeStoreSellBO.CheckNumber;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            IncomeStoreSellDA tmpIncomeStoreSellDA = new IncomeStoreSellDA(this);
            return tmpIncomeStoreSellDA.Add();
        }

        public bool Delete()
        {
            IncomeStoreSellDA tmpIncomeStoreSellDA = new IncomeStoreSellDA(this);
            return tmpIncomeStoreSellDA.Delete();
        }

        public bool Update()
        {
            IncomeStoreSellDA tmpIncomeStoreSellDA = new IncomeStoreSellDA(this);
            return tmpIncomeStoreSellDA.Update();
        }

        public static List<IncomeStoreSellBO> List()
        {
            return IncomeStoreSellDA.List();
        }
        public static List<IncomeStoreSellBO> List(string shopID, int? fee, int? discount, string payDate, int? payTypeID, string checkDate, string checkNumber)
        {
            return IncomeStoreSellDA.List(shopID, fee, discount, payDate, payTypeID, checkDate, checkNumber);
        }

        public static IncomeStoreSellBO Find(int payID)
        {
            return IncomeStoreSellDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.ShopID.Name)
                    return ShopID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.IncomeStoreSell.CheckNumber.Name)
                    return CheckNumber.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<IncomeStoreSellBO> Members
        public IncomeStoreSellBO Clone()
        {
            return new IncomeStoreSellBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (IncomeStoreSellBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(IncomeStoreSellBO it1, IncomeStoreSellBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(IncomeStoreSellBO it1, IncomeStoreSellBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class OutcomeStoreBuyBO : IBusinessObject, ICloner<OutcomeStoreBuyBO>, ILastChange, IGridValue
    {
        #region Variables

        public int PayID { get; set; }
        public string StuffID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public int PayTypeID { get; set; }
        public string CheckDate { get; set; }
        public string Description { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public string CheckNumber { get; set; }
        #endregion

        private StoreStuffBO relStuff;
        public StoreStuffBO RelStuff
        {
            get
            {
                if (relStuff == null)
                    relStuff = StoreStuffBO.Find(StuffID);
                return relStuff;
            }
            set { relStuff = value; }
        }

        #region Constructors

        public OutcomeStoreBuyBO()
        {
            // Nothing to do...
        }

        public OutcomeStoreBuyBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public OutcomeStoreBuyBO(OutcomeStoreBuyBO copyOutcomeStoreBuyBO)
        {
            this.PayID = copyOutcomeStoreBuyBO.PayID;
            this.StuffID = copyOutcomeStoreBuyBO.StuffID;
            this.Fee = copyOutcomeStoreBuyBO.Fee;
            this.Discount = copyOutcomeStoreBuyBO.Discount;
            this.PayDate = copyOutcomeStoreBuyBO.PayDate;
            this.PayTypeID = copyOutcomeStoreBuyBO.PayTypeID;
            this.CheckDate = copyOutcomeStoreBuyBO.CheckDate;
            this.Description = copyOutcomeStoreBuyBO.Description;
            this.LastChangeID = copyOutcomeStoreBuyBO.LastChangeID;
            this.LastChangeDate = copyOutcomeStoreBuyBO.LastChangeDate;
            this.LastChangeTime = copyOutcomeStoreBuyBO.LastChangeTime;
            this.CheckNumber = copyOutcomeStoreBuyBO.CheckNumber;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            OutcomeStoreBuyDA tmpOutcomeStoreBuyDA = new OutcomeStoreBuyDA(this);
            return tmpOutcomeStoreBuyDA.Add();
        }

        public bool Delete()
        {
            OutcomeStoreBuyDA tmpOutcomeStoreBuyDA = new OutcomeStoreBuyDA(this);
            return tmpOutcomeStoreBuyDA.Delete();
        }

        public bool Update()
        {
            OutcomeStoreBuyDA tmpOutcomeStoreBuyDA = new OutcomeStoreBuyDA(this);
            return tmpOutcomeStoreBuyDA.Update();
        }

        public static List<OutcomeStoreBuyBO> List()
        {
            return OutcomeStoreBuyDA.List();
        }
        public static List<OutcomeStoreBuyBO> List(string stuffID, int? fee, int? discount, string payDate, int? payTypeID, string checkDate, string checkNumber)
        {
            return OutcomeStoreBuyDA.List(stuffID, fee, discount, payDate, payTypeID, checkDate, checkNumber);
        }

        public static OutcomeStoreBuyBO Find(int payID)
        {
            return OutcomeStoreBuyDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.LastChangeTime.Name)
                    return LastChangeTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.OutcomeStoreBuy.CheckNumber.Name)
                    return CheckNumber.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<OutcomeStoreBuyBO> Members
        public OutcomeStoreBuyBO Clone()
        {
            return new OutcomeStoreBuyBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (OutcomeStoreBuyBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(OutcomeStoreBuyBO it1, OutcomeStoreBuyBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(OutcomeStoreBuyBO it1, OutcomeStoreBuyBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    // Generated by DVD CodeGenerator
    public partial class ViwStoreSalesHistoryBO : IBusinessObject, ICloner<ViwStoreSalesHistoryBO>, IGridValue
    {
        #region Variables

        public string ShopID { get; set; }
        public string StuffID { get; set; }
        public int StuffTypeID { get; set; }
        public string StuffName { get; set; }
        public string StuffTypeName { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public bool IsManagerAware { get; set; }
        public string ShopDate { get; set; }
        public int ShopCount { get; set; }
        public int? CustomerCount { get; set; }
        #endregion


        #region Constructors

        public ViwStoreSalesHistoryBO()
        {
            // Nothing to do...
        }

        public ViwStoreSalesHistoryBO(string shopID)
        {
            this.ShopID = shopID;
        }

        // Copy Constructor.
        public ViwStoreSalesHistoryBO(ViwStoreSalesHistoryBO copyViwStoreSalesHistoryBO)
        {
            this.ShopID = copyViwStoreSalesHistoryBO.ShopID;
            this.StuffID = copyViwStoreSalesHistoryBO.StuffID;
            this.StuffTypeID = copyViwStoreSalesHistoryBO.StuffTypeID;
            this.StuffName = copyViwStoreSalesHistoryBO.StuffName;
            this.StuffTypeName = copyViwStoreSalesHistoryBO.StuffTypeName;
            this.CustomerID = copyViwStoreSalesHistoryBO.CustomerID;
            this.CustomerName = copyViwStoreSalesHistoryBO.CustomerName;
            this.Fee = copyViwStoreSalesHistoryBO.Fee;
            this.Discount = copyViwStoreSalesHistoryBO.Discount;
            this.IsManagerAware = copyViwStoreSalesHistoryBO.IsManagerAware;
            this.ShopDate = copyViwStoreSalesHistoryBO.ShopDate;
            this.ShopCount = copyViwStoreSalesHistoryBO.ShopCount;
            this.CustomerCount = copyViwStoreSalesHistoryBO.CustomerCount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStoreSalesHistoryDA tmpViwStoreSalesHistoryDA = new ViwStoreSalesHistoryDA(this);
            return tmpViwStoreSalesHistoryDA.Add();
        }

        public bool Delete()
        {
            ViwStoreSalesHistoryDA tmpViwStoreSalesHistoryDA = new ViwStoreSalesHistoryDA(this);
            return tmpViwStoreSalesHistoryDA.Delete();
        }

        public bool Update()
        {
            ViwStoreSalesHistoryDA tmpViwStoreSalesHistoryDA = new ViwStoreSalesHistoryDA(this);
            return tmpViwStoreSalesHistoryDA.Update();
        }

        public static List<ViwStoreSalesHistoryBO> List()
        {
            return ViwStoreSalesHistoryDA.List();
        }
        public static List<ViwStoreSalesHistoryBO> List(string stuffID, int? stuffTypeID, string stuffName, string stuffTypeName, string customerID, string customerName, int? fee, int? discount, bool? isManagerAware, string shopDate, int? shopCount, int? customerCount)
        {
            return ViwStoreSalesHistoryDA.List(stuffID, stuffTypeID, stuffName, stuffTypeName, customerID, customerName, fee, discount, isManagerAware, shopDate, shopCount, customerCount);
        }

        public static ViwStoreSalesHistoryBO Find(string shopID)
        {
            return ViwStoreSalesHistoryDA.Find(shopID);
        }
        #endregion

        public static List<ViwStoreSalesHistoryBO> ListGroup(int? stuffTypeID, string shopDateFrom, string shopDateTo)
        {
            return ViwStoreSalesHistoryDA.ListGroup(stuffTypeID, shopDateFrom, shopDateTo);
        }

        public static List<ViwStoreSalesHistoryBO> ListInterval(int? stuffTypeID, string shopDateFrom, string shopDateTo, bool? isManagerAware)
        {
            return ViwStoreSalesHistoryDA.ListInterval(stuffTypeID, shopDateFrom, shopDateTo, isManagerAware);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.ShopID.Name)
                    return ShopID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.StuffName.Name)
                    return StuffName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.StuffTypeName.Name)
                    return StuffTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.CustomerID.Name)
                    return CustomerID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.CustomerName.Name)
                    return CustomerName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.IsManagerAware.Name)
                    return UtilityTxt.GetString(IsManagerAware);
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.ShopDate.Name)
                    return ShopDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.ShopCount.Name)
                    return ShopCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStoreSalesHistory.CustomerCount.Name)
                    return CustomerCount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStoreSalesHistoryBO> Members
        public ViwStoreSalesHistoryBO Clone()
        {
            return new ViwStoreSalesHistoryBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStoreSalesHistoryBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStoreSalesHistoryBO it1, ViwStoreSalesHistoryBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ShopID == it2.ShopID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStoreSalesHistoryBO it1, ViwStoreSalesHistoryBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwSalesTrackingBO : IBusinessObject, ICloner<ViwSalesTrackingBO>, IGridValue
    {
        #region Variables

        public bool IsSale { get; set; }
        public string IsSaleText { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public string ItemDate { get; set; }
        public int StuffTypeID { get; set; }
        public string StuffID { get; set; }
        public bool ActivityStatus { get; set; }
        #endregion


        #region Constructors

        public ViwSalesTrackingBO()
        {
            // Nothing to do...
        }

        public ViwSalesTrackingBO(string itemDate, int stuffTypeID, string stuffID)
        {
            this.ItemDate = itemDate;
            this.StuffTypeID = stuffTypeID;
            this.StuffID = stuffID;
        }

        // Copy Constructor.
        public ViwSalesTrackingBO(ViwSalesTrackingBO copyViwSalesTrackingBO)
        {
            this.IsSale = copyViwSalesTrackingBO.IsSale;
            this.IsSaleText = copyViwSalesTrackingBO.IsSaleText;
            this.ItemName = copyViwSalesTrackingBO.ItemName;
            this.ItemCount = copyViwSalesTrackingBO.ItemCount;
            this.ItemDate = copyViwSalesTrackingBO.ItemDate;
            this.StuffTypeID = copyViwSalesTrackingBO.StuffTypeID;
            this.StuffID = copyViwSalesTrackingBO.StuffID;
            this.ActivityStatus = copyViwSalesTrackingBO.ActivityStatus;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwSalesTrackingDA tmpViwSalesTrackingDA = new ViwSalesTrackingDA(this);
            return tmpViwSalesTrackingDA.Add();
        }

        public bool Delete()
        {
            ViwSalesTrackingDA tmpViwSalesTrackingDA = new ViwSalesTrackingDA(this);
            return tmpViwSalesTrackingDA.Delete();
        }

        public bool Update()
        {
            ViwSalesTrackingDA tmpViwSalesTrackingDA = new ViwSalesTrackingDA(this);
            return tmpViwSalesTrackingDA.Update();
        }

        public static List<ViwSalesTrackingBO> List()
        {
            return ViwSalesTrackingDA.List();
        }
        public static List<ViwSalesTrackingBO> List(int? isSale, string itemName, int? itemCount, string itemDate, int? stuffTypeID, string stuffID, bool? activityStatus)
        {
            return ViwSalesTrackingDA.List(isSale, itemName, itemCount, itemDate, stuffTypeID, stuffID, activityStatus);
        }

        public static ViwSalesTrackingBO Find(string itemDate, int stuffTypeID, string stuffID)
        {
            return ViwSalesTrackingDA.Find(itemDate, stuffTypeID, stuffID);
        }
        #endregion

        public static List<ViwSalesTrackingBO> ListInterval(bool? isSale, string itemName, int? itemCount, string itemDateFrom, string itemDateTo, int? stuffTypeID, string stuffID, bool? activityStatus)
        {
            return ViwSalesTrackingDA.ListInterval(isSale, itemName, itemCount, itemDateFrom, itemDateTo, stuffTypeID, stuffID, activityStatus);
        }

        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.IsSale.Name)
                    return IsSale.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.IsSaleText.Name)
                    return IsSaleText.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.ItemName.Name)
                    return ItemName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.ItemCount.Name)
                    return ItemCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.ItemDate.Name)
                    return ItemDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.StuffTypeID.Name)
                    return StuffTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.StuffID.Name)
                    return StuffID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwSalesTracking.ActivityStatus.Name)
                    return ActivityStatus.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwSalesTrackingBO> Members
        public ViwSalesTrackingBO Clone()
        {
            return new ViwSalesTrackingBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwSalesTrackingBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwSalesTrackingBO it1, ViwSalesTrackingBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ItemDate == it2.ItemDate && it1.StuffTypeID == it2.StuffTypeID && it1.StuffID == it2.StuffID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwSalesTrackingBO it1, ViwSalesTrackingBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwEmployeeSalaryDetailsBO : IBusinessObject, ICloner<ViwEmployeeSalaryDetailsBO>, IGridValue
    {
        #region Variables

        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ActivityStatus { get; set; }
        public int PayID { get; set; }
        public int Fee { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Description { get; set; }
        public int PayTypeID { get; set; }
        public int Discount { get; set; }
        #endregion


        #region Constructors

        public ViwEmployeeSalaryDetailsBO()
        {
            // Nothing to do...
        }

        public ViwEmployeeSalaryDetailsBO(int payID)
        {
            this.PayID = payID;
        }

        // Copy Constructor.
        public ViwEmployeeSalaryDetailsBO(ViwEmployeeSalaryDetailsBO copyViwEmployeeSalaryDetailsBO)
        {
            this.EmployeeID = copyViwEmployeeSalaryDetailsBO.EmployeeID;
            this.FirstName = copyViwEmployeeSalaryDetailsBO.FirstName;
            this.LastName = copyViwEmployeeSalaryDetailsBO.LastName;
            this.ActivityStatus = copyViwEmployeeSalaryDetailsBO.ActivityStatus;
            this.PayID = copyViwEmployeeSalaryDetailsBO.PayID;
            this.Fee = copyViwEmployeeSalaryDetailsBO.Fee;
            this.PayDate = copyViwEmployeeSalaryDetailsBO.PayDate;
            this.CheckDate = copyViwEmployeeSalaryDetailsBO.CheckDate;
            this.CheckNumber = copyViwEmployeeSalaryDetailsBO.CheckNumber;
            this.DateFrom = copyViwEmployeeSalaryDetailsBO.DateFrom;
            this.DateTo = copyViwEmployeeSalaryDetailsBO.DateTo;
            this.Description = copyViwEmployeeSalaryDetailsBO.Description;
            this.PayTypeID = copyViwEmployeeSalaryDetailsBO.PayTypeID;
            this.Discount = copyViwEmployeeSalaryDetailsBO.Discount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwEmployeeSalaryDetailsDA tmpViwEmployeeSalaryDetailsDA = new ViwEmployeeSalaryDetailsDA(this);
            return tmpViwEmployeeSalaryDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwEmployeeSalaryDetailsDA tmpViwEmployeeSalaryDetailsDA = new ViwEmployeeSalaryDetailsDA(this);
            return tmpViwEmployeeSalaryDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwEmployeeSalaryDetailsDA tmpViwEmployeeSalaryDetailsDA = new ViwEmployeeSalaryDetailsDA(this);
            return tmpViwEmployeeSalaryDetailsDA.Update();
        }

        public static List<ViwEmployeeSalaryDetailsBO> List()
        {
            return ViwEmployeeSalaryDetailsDA.List();
        }
        public static List<ViwEmployeeSalaryDetailsBO> List(string employeeID, string firstName, string lastName, bool? activityStatus, int? payID, int? fee, string payDate, string checkDate, string checkNumber, string dateFrom, string dateTo, string description, int? payTypeID, int? discount)
        {
            return ViwEmployeeSalaryDetailsDA.List(employeeID, firstName, lastName, activityStatus, payID, fee, payDate, checkDate, checkNumber, dateFrom, dateTo, description, payTypeID, discount);
        }

        public static ViwEmployeeSalaryDetailsBO Find(int payID)
        {
            return ViwEmployeeSalaryDetailsDA.Find(payID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.EmployeeID.Name)
                    return EmployeeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.ActivityStatus.Name)
                    return ActivityStatus.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.DateFrom.Name)
                    return DateFrom.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.DateTo.Name)
                    return DateTo.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwEmployeeSalaryDetails.Discount.Name)
                    return Discount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwEmployeeSalaryDetailsBO> Members
        public ViwEmployeeSalaryDetailsBO Clone()
        {
            return new ViwEmployeeSalaryDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwEmployeeSalaryDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwEmployeeSalaryDetailsBO it1, ViwEmployeeSalaryDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.PayID == it2.PayID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwEmployeeSalaryDetailsBO it1, ViwEmployeeSalaryDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class SchoolSpecificationBO : IBusinessObject, ICloner<SchoolSpecificationBO>, ILastChange, IGridValue
    {
        #region Variables

        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public Image SchoolLogo { get; set; }
        public string Address { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerBirthDate { get; set; }
        public int? DegreeLevelID { get; set; }
        public string ManagerStudeyMajor { get; set; }
        public string JustificationID { get; set; }
        public string JustificationName { get; set; }
        public string FondYear { get; set; }
        public int? EmployeeNumber { get; set; }
        public string WorkHour { get; set; }
        public string SchoolGrade { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Tell { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public Image BackgroundImage { get; set; }
        public string ReportTitle { get; set; }
        public Image ReportLogo { get; set; }
        public string ReportAddress { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        public string ReportPayFactorFooterDesc { get; set; }
        #endregion


        #region Constructors

        public SchoolSpecificationBO()
        {
            // Nothing to do...
        }

        public SchoolSpecificationBO(int schoolID)
        {
            this.SchoolID = schoolID;
        }

        // Copy Constructor.
        public SchoolSpecificationBO(SchoolSpecificationBO copySchoolSpecificationBO)
        {
            this.SchoolID = copySchoolSpecificationBO.SchoolID;
            this.SchoolName = copySchoolSpecificationBO.SchoolName;
            this.SchoolLogo = copySchoolSpecificationBO.SchoolLogo;
            this.Address = copySchoolSpecificationBO.Address;
            this.ManagerFirstName = copySchoolSpecificationBO.ManagerFirstName;
            this.ManagerLastName = copySchoolSpecificationBO.ManagerLastName;
            this.ManagerBirthDate = copySchoolSpecificationBO.ManagerBirthDate;
            this.DegreeLevelID = copySchoolSpecificationBO.DegreeLevelID;
            this.ManagerStudeyMajor = copySchoolSpecificationBO.ManagerStudeyMajor;
            this.JustificationID = copySchoolSpecificationBO.JustificationID;
            this.JustificationName = copySchoolSpecificationBO.JustificationName;
            this.FondYear = copySchoolSpecificationBO.FondYear;
            this.EmployeeNumber = copySchoolSpecificationBO.EmployeeNumber;
            this.WorkHour = copySchoolSpecificationBO.WorkHour;
            this.SchoolGrade = copySchoolSpecificationBO.SchoolGrade;
            this.Province = copySchoolSpecificationBO.Province;
            this.City = copySchoolSpecificationBO.City;
            this.Street = copySchoolSpecificationBO.Street;
            this.PostalCode = copySchoolSpecificationBO.PostalCode;
            this.Tell = copySchoolSpecificationBO.Tell;
            this.Fax = copySchoolSpecificationBO.Fax;
            this.Mail = copySchoolSpecificationBO.Mail;
            this.BackgroundImage = copySchoolSpecificationBO.BackgroundImage;
            this.ReportTitle = copySchoolSpecificationBO.ReportTitle;
            this.ReportLogo = copySchoolSpecificationBO.ReportLogo;
            this.ReportAddress = copySchoolSpecificationBO.ReportAddress;
            this.LastChangeID = copySchoolSpecificationBO.LastChangeID;
            this.LastChangeDate = copySchoolSpecificationBO.LastChangeDate;
            this.LastChangeTime = copySchoolSpecificationBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            SchoolSpecificationDA tmpSchoolSpecificationDA = new SchoolSpecificationDA(this);
            return tmpSchoolSpecificationDA.Add();
        }

        public bool Delete()
        {
            SchoolSpecificationDA tmpSchoolSpecificationDA = new SchoolSpecificationDA(this);
            return tmpSchoolSpecificationDA.Delete();
        }

        public bool Update()
        {
            SchoolSpecificationDA tmpSchoolSpecificationDA = new SchoolSpecificationDA(this);
            return tmpSchoolSpecificationDA.Update();
        }

        public static List<SchoolSpecificationBO> List()
        {
            return SchoolSpecificationDA.List();
        }

        public static SchoolSpecificationBO Find(int schoolID)
        {
            return SchoolSpecificationDA.Find(schoolID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.SchoolID.Name)
                    return SchoolID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.SchoolName.Name)
                    return SchoolName.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.SchoolLogo.Name)
                    return SchoolLogo.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Address.Name)
                    return Address.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ManagerFirstName.Name)
                    return ManagerFirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ManagerLastName.Name)
                    return ManagerLastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ManagerBirthDate.Name)
                    return ManagerBirthDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.DegreeLevelID.Name)
                    return DegreeLevelID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ManagerStudeyMajor.Name)
                    return ManagerStudeyMajor.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.JustificationID.Name)
                    return JustificationID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.JustificationName.Name)
                    return JustificationName.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.FondYear.Name)
                    return FondYear.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.EmployeeNumber.Name)
                    return EmployeeNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.WorkHour.Name)
                    return WorkHour.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Province.Name)
                    return Province.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.City.Name)
                    return City.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Street.Name)
                    return Street.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.PostalCode.Name)
                    return PostalCode.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Tell.Name)
                    return Tell.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Fax.Name)
                    return Fax.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.Mail.Name)
                    return Mail.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.BackgroundImage.Name)
                    return BackgroundImage.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ReportTitle.Name)
                    return ReportTitle.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ReportLogo.Name)
                    return ReportLogo.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.ReportAddress.Name)
                    return ReportAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.SchoolSpecification.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<SchoolSpecificationBO> Members
        public SchoolSpecificationBO Clone()
        {
            return new SchoolSpecificationBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (SchoolSpecificationBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(SchoolSpecificationBO it1, SchoolSpecificationBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.SchoolID == it2.SchoolID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(SchoolSpecificationBO it1, SchoolSpecificationBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStudentFinancialDetailsBO : IBusinessObject, ICloner<ViwStudentFinancialDetailsBO>, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string StudentID { get; set; }
        public string ClassName { get; set; }
        public int PayID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public int IsIncome { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MajorID { get; set; }
        public string ClassRegisterationDate { get; set; }
        public string PayTypeName { get; set; }
        #endregion


        #region Constructors

        public ViwStudentFinancialDetailsBO()
        {
            // Nothing to do...
        }


        // Copy Constructor.
        public ViwStudentFinancialDetailsBO(ViwStudentFinancialDetailsBO copyViwStudentFinancialDetailsBO)
        {
            this.ClassID = copyViwStudentFinancialDetailsBO.ClassID;
            this.StudentID = copyViwStudentFinancialDetailsBO.StudentID;
            this.ClassName = copyViwStudentFinancialDetailsBO.ClassName;
            this.PayID = copyViwStudentFinancialDetailsBO.PayID;
            this.PayTypeID = copyViwStudentFinancialDetailsBO.PayTypeID;
            this.Fee = copyViwStudentFinancialDetailsBO.Fee;
            this.Discount = copyViwStudentFinancialDetailsBO.Discount;
            this.PayDate = copyViwStudentFinancialDetailsBO.PayDate;
            this.CheckDate = copyViwStudentFinancialDetailsBO.CheckDate;
            this.CheckNumber = copyViwStudentFinancialDetailsBO.CheckNumber;
            this.Description = copyViwStudentFinancialDetailsBO.Description;
            this.IsIncome = copyViwStudentFinancialDetailsBO.IsIncome;
            this.FirstName = copyViwStudentFinancialDetailsBO.FirstName;
            this.LastName = copyViwStudentFinancialDetailsBO.LastName;
            this.MajorID = copyViwStudentFinancialDetailsBO.MajorID;
            this.ClassRegisterationDate = copyViwStudentFinancialDetailsBO.ClassRegisterationDate;
            this.PayTypeName = copyViwStudentFinancialDetailsBO.PayTypeName;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStudentFinancialDetailsDA tmpViwStudentFinancialDetailsDA = new ViwStudentFinancialDetailsDA(this);
            return tmpViwStudentFinancialDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwStudentFinancialDetailsDA tmpViwStudentFinancialDetailsDA = new ViwStudentFinancialDetailsDA(this);
            return tmpViwStudentFinancialDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwStudentFinancialDetailsDA tmpViwStudentFinancialDetailsDA = new ViwStudentFinancialDetailsDA(this);
            return tmpViwStudentFinancialDetailsDA.Update();
        }

        public static List<ViwStudentFinancialDetailsBO> List()
        {
            return ViwStudentFinancialDetailsDA.List();
        }
        public static List<ViwStudentFinancialDetailsBO> List(int? classID, string studentID, int? majorID, string classRegisterationDate)
        {
            return ViwStudentFinancialDetailsDA.List(classID, studentID, majorID, classRegisterationDate);
        }

        public static ViwStudentFinancialDetailsBO Find()
        {
            return ViwStudentFinancialDetailsDA.Find();
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.IsIncome.Name)
                    return IsIncome == 1 ? "دریافتی از هنرجو" : "پرداختی بابت تسویه";
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.MajorID.Name)
                    return MajorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.ClassRegisterationDate.Name)
                    return ClassRegisterationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialDetails.PayTypeName.Name)
                    return PayTypeName.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStudentFinancialDetailsBO> Members
        public ViwStudentFinancialDetailsBO Clone()
        {
            return new ViwStudentFinancialDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStudentFinancialDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStudentFinancialDetailsBO it1, ViwStudentFinancialDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStudentFinancialDetailsBO it1, ViwStudentFinancialDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStudentFinancialStatusBO : IBusinessObject, ICloner<ViwStudentFinancialStatusBO>, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string StudentID { get; set; }
        public int StudentPayedAmount { get; set; }
        public int BalancedAmount { get; set; }
        public int StudentFinalPay { get; set; }
        public int StudentMustPay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string ClassRegisterationDate { get; set; }
        public int ClassTotalPrice { get; set; }
        public int ReturnMoneyForTeacherAbsentCount { get; set; }
        public int ReturnMoneyForTeacherAbsentAmount { get; set; }
        #endregion

        public int FinalClassPrice { get { return ClassTotalPrice - ReturnMoneyForTeacherAbsentAmount; } }

        #region Constructors

        public ViwStudentFinancialStatusBO()
        {
            // Nothing to do...
        }

        public ViwStudentFinancialStatusBO(int classID, string studentID)
        {
            this.ClassID = classID;
            this.StudentID = studentID;
        }

        // Copy Constructor.
        public ViwStudentFinancialStatusBO(ViwStudentFinancialStatusBO copyViwStudentFinancialStatusBO)
        {
            this.ClassID = copyViwStudentFinancialStatusBO.ClassID;
            this.StudentID = copyViwStudentFinancialStatusBO.StudentID;
            this.StudentPayedAmount = copyViwStudentFinancialStatusBO.StudentPayedAmount;
            this.BalancedAmount = copyViwStudentFinancialStatusBO.BalancedAmount;
            this.StudentFinalPay = copyViwStudentFinancialStatusBO.StudentFinalPay;
            this.StudentMustPay = copyViwStudentFinancialStatusBO.StudentMustPay;
            this.FirstName = copyViwStudentFinancialStatusBO.FirstName;
            this.LastName = copyViwStudentFinancialStatusBO.LastName;
            this.ClassName = copyViwStudentFinancialStatusBO.ClassName;
            this.ClassRegisterationDate = copyViwStudentFinancialStatusBO.ClassRegisterationDate;
            this.ClassTotalPrice = copyViwStudentFinancialStatusBO.ClassTotalPrice;
            this.ReturnMoneyForTeacherAbsentAmount = copyViwStudentFinancialStatusBO.ReturnMoneyForTeacherAbsentAmount;
            this.ReturnMoneyForTeacherAbsentCount = copyViwStudentFinancialStatusBO.ReturnMoneyForTeacherAbsentCount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
            return tmpViwStudentFinancialStatusDA.Add();
        }

        public bool Delete()
        {
            ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
            return tmpViwStudentFinancialStatusDA.Delete();
        }

        public bool Update()
        {
            ViwStudentFinancialStatusDA tmpViwStudentFinancialStatusDA = new ViwStudentFinancialStatusDA(this);
            return tmpViwStudentFinancialStatusDA.Update();
        }

        public static List<ViwStudentFinancialStatusBO> List()
        {
            return ViwStudentFinancialStatusDA.List();
        }
        public static List<ViwStudentFinancialStatusBO> List(int? classID, string studentID, bool? activityStatus)
        {
            return ViwStudentFinancialStatusDA.List(classID, studentID, activityStatus);
        }

        public static ViwStudentFinancialStatusBO Find(int classID, string studentID)
        {
            return ViwStudentFinancialStatusDA.Find(classID, studentID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentPayedAmount.Name)
                    return UtilityTxt.ToFarsiCurrency(StudentPayedAmount.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.BalancedAmount.Name)
                    return UtilityTxt.ToFarsiCurrency(BalancedAmount.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentFinalPay.Name)
                    return UtilityTxt.ToFarsiCurrency(StudentFinalPay.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.StudentMustPay.Name)
                    return UtilityTxt.ToFarsiCurrency(StudentMustPay.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassRegisterationDate.Name)
                    return ClassRegisterationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ClassTotalPrice.Name)
                    return UtilityTxt.ToFarsiCurrency(ClassTotalPrice.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ReturnMoneyForTeacherAbsentAmount.Name)
                    return UtilityTxt.ToFarsiCurrency(ReturnMoneyForTeacherAbsentAmount.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.ReturnMoneyForTeacherAbsentCount.Name)
                    return ReturnMoneyForTeacherAbsentCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.FinalClassPrice.Name)
                    return UtilityTxt.ToFarsiCurrency(FinalClassPrice.ToString());
                if (columnDefinition.Name == DatabaseSchema.ViwStudentFinancialStatus.FinancialStatus.Name)
                {
                    RegistrationBO reg = RegistrationBO.Find(ClassID, StudentID);
                    string res = "";
                    if (reg == null)
                    {
                        return "نا مشخص";
                    }
                    else
                    {
                        ViwStudentFinancialStatusBO status = ViwStudentFinancialStatusBO.Find(ClassID, StudentID);
                        if (status != null)
                        {
                            if (status.StudentMustPay == 0)
                                res = "بی حساب";
                            else
                                res = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(status.StudentMustPay).ToString()) + " "
                                    + (status.StudentMustPay > 0 ? "بدهکار" : "طلبکار") + " است.";
                        }
                        if (reg.IsBalancedFinalWithStudent) res += " - " + "تسویه شده";
                        return res;
                    }
                }
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStudentFinancialStatusBO> Members
        public ViwStudentFinancialStatusBO Clone()
        {
            return new ViwStudentFinancialStatusBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStudentFinancialStatusBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStudentFinancialStatusBO it1, ViwStudentFinancialStatusBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.StudentID == it2.StudentID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStudentFinancialStatusBO it1, ViwStudentFinancialStatusBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStudentSessionStatusBO : IBusinessObject, ICloner<ViwStudentSessionStatusBO>, IGridValue
    {
        #region Variables

        public string StudentID { get; set; }
        public int? StudentAbseneceCount { get; set; }
        public int? ContinuousAbseneceCount { get; set; }
        public int? TeacherAbsenceCount { get; set; }
        public int ClassID { get; set; }
        public int? WillHeldCount { get; set; }
        public int? HeldCount { get; set; }
        public int? NotlHeldCount { get; set; }
        public int? TotalDedicatedSessions { get; set; }
        #endregion


        #region Constructors

        public ViwStudentSessionStatusBO()
        {
            // Nothing to do...
        }

        public ViwStudentSessionStatusBO(string studentID, int classID)
        {
            this.StudentID = studentID;
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ViwStudentSessionStatusBO(ViwStudentSessionStatusBO copyViwStudentSessionStatusBO)
        {
            this.StudentID = copyViwStudentSessionStatusBO.StudentID;
            this.StudentAbseneceCount = copyViwStudentSessionStatusBO.StudentAbseneceCount;
            this.ContinuousAbseneceCount = copyViwStudentSessionStatusBO.ContinuousAbseneceCount;
            this.TeacherAbsenceCount = copyViwStudentSessionStatusBO.TeacherAbsenceCount;
            this.ClassID = copyViwStudentSessionStatusBO.ClassID;
            this.WillHeldCount = copyViwStudentSessionStatusBO.WillHeldCount;
            this.HeldCount = copyViwStudentSessionStatusBO.HeldCount;
            this.NotlHeldCount = copyViwStudentSessionStatusBO.NotlHeldCount;
            this.TotalDedicatedSessions = copyViwStudentSessionStatusBO.TotalDedicatedSessions;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStudentSessionStatusDA tmpViwStudentSessionStatusDA = new ViwStudentSessionStatusDA(this);
            return tmpViwStudentSessionStatusDA.Add();
        }

        public bool Delete()
        {
            ViwStudentSessionStatusDA tmpViwStudentSessionStatusDA = new ViwStudentSessionStatusDA(this);
            return tmpViwStudentSessionStatusDA.Delete();
        }

        public bool Update()
        {
            ViwStudentSessionStatusDA tmpViwStudentSessionStatusDA = new ViwStudentSessionStatusDA(this);
            return tmpViwStudentSessionStatusDA.Update();
        }

        public static List<ViwStudentSessionStatusBO> List()
        {
            return ViwStudentSessionStatusDA.List();
        }
        public static List<ViwStudentSessionStatusBO> List(string studentID, int? classID)
        {
            return ViwStudentSessionStatusDA.List(studentID, classID);
        }

        public static ViwStudentSessionStatusBO Find(string studentID, int classID)
        {
            return ViwStudentSessionStatusDA.Find(studentID, classID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.StudentAbseneceCount.Name)
                    return StudentAbseneceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.ContinuousAbseneceCount.Name)
                    return ContinuousAbseneceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.TeacherAbsenceCount.Name)
                    return TeacherAbsenceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.WillHeldCount.Name)
                    return WillHeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.HeldCount.Name)
                    return HeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.NotlHeldCount.Name)
                    return NotlHeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionStatus.TotalDedicatedSessions.Name)
                    return TotalDedicatedSessions.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStudentSessionStatusBO> Members
        public ViwStudentSessionStatusBO Clone()
        {
            return new ViwStudentSessionStatusBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStudentSessionStatusBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStudentSessionStatusBO it1, ViwStudentSessionStatusBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.StudentID == it2.StudentID && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStudentSessionStatusBO it1, ViwStudentSessionStatusBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwStudentSessionDetailsBO : IBusinessObject, ICloner<ViwStudentSessionDetailsBO>, IGridValue
    {
        #region Variables

        public int ClassID { get; set; }
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string ClassDate { get; set; }
        public int TimeID { get; set; }
        public bool StudentAbsence { get; set; }
        public bool ContinuousAbsence { get; set; }
        public bool TeacherAbsence { get; set; }
        public string SuccessorTeacher { get; set; }
        public int SessionStatus { get; set; }
        public int? RoomNo { get; set; }
        public string TeacherID { get; set; }
        #endregion


        #region Constructors

        public ViwStudentSessionDetailsBO()
        {
            // Nothing to do...
        }

        public ViwStudentSessionDetailsBO(int classID, string studentID, string classDate, int timeID)
        {
            this.ClassID = classID;
            this.StudentID = studentID;
            this.ClassDate = classDate;
            this.TimeID = timeID;
        }

        // Copy Constructor.
        public ViwStudentSessionDetailsBO(ViwStudentSessionDetailsBO copyViwStudentSessionDetailsBO)
        {
            this.ClassID = copyViwStudentSessionDetailsBO.ClassID;
            this.StudentID = copyViwStudentSessionDetailsBO.StudentID;
            this.FirstName = copyViwStudentSessionDetailsBO.FirstName;
            this.LastName = copyViwStudentSessionDetailsBO.LastName;
            this.ClassName = copyViwStudentSessionDetailsBO.ClassName;
            this.ClassDate = copyViwStudentSessionDetailsBO.ClassDate;
            this.TimeID = copyViwStudentSessionDetailsBO.TimeID;
            this.StudentAbsence = copyViwStudentSessionDetailsBO.StudentAbsence;
            this.ContinuousAbsence = copyViwStudentSessionDetailsBO.ContinuousAbsence;
            this.TeacherAbsence = copyViwStudentSessionDetailsBO.TeacherAbsence;
            this.SuccessorTeacher = copyViwStudentSessionDetailsBO.SuccessorTeacher;
            this.SessionStatus = copyViwStudentSessionDetailsBO.SessionStatus;
            this.RoomNo = copyViwStudentSessionDetailsBO.RoomNo;
            this.TeacherID = copyViwStudentSessionDetailsBO.TeacherID;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwStudentSessionDetailsDA tmpViwStudentSessionDetailsDA = new ViwStudentSessionDetailsDA(this);
            return tmpViwStudentSessionDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwStudentSessionDetailsDA tmpViwStudentSessionDetailsDA = new ViwStudentSessionDetailsDA(this);
            return tmpViwStudentSessionDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwStudentSessionDetailsDA tmpViwStudentSessionDetailsDA = new ViwStudentSessionDetailsDA(this);
            return tmpViwStudentSessionDetailsDA.Update();
        }

        public static List<ViwStudentSessionDetailsBO> List()
        {
            return ViwStudentSessionDetailsDA.List();
        }
        public static List<ViwStudentSessionDetailsBO> List(int? classID, string studentID, string classDate, int? timeID, bool? studentAbsence, bool? continuousAbsence, bool? teacherAbsence, string successorTeacher, int? sessionStatus, int? roomNo, string teacherID)
        {
            return ViwStudentSessionDetailsDA.List(classID, studentID, classDate, timeID, studentAbsence, continuousAbsence, teacherAbsence, successorTeacher, sessionStatus, roomNo, teacherID);
        }

        public static ViwStudentSessionDetailsBO Find(int classID, string studentID, string classDate, int timeID)
        {
            return ViwStudentSessionDetailsDA.Find(classID, studentID, classDate, timeID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.StudentID.Name)
                    return StudentID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.ClassDate.Name)
                    return ClassDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.TimeID.Name)
                {
                    ClasssessionBO session = ClasssessionBO.Find(ClassID, ClassDate, TimeID);
                    return session.RelDay.DayName + " " + session.RelTime.ToString();
                }
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.StudentAbsence.Name)
                    return UtilityTxt.GetString(StudentAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.ContinuousAbsence.Name)
                    return UtilityTxt.GetString(ContinuousAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.TeacherAbsence.Name)
                    return UtilityTxt.GetString(TeacherAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.SuccessorTeacher.Name)
                    return UtilityTxt.GetString(SuccessorTeacher ?? "-");
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.SessionStatus.Name)
                    return new SessionStatus(SessionStatus).ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.RoomNo.Name)
                    return RoomNo.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwStudentSessionDetails.TeacherID.Name)
                    return TeacherID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwStudentSessionDetailsBO> Members
        public ViwStudentSessionDetailsBO Clone()
        {
            return new ViwStudentSessionDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwStudentSessionDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwStudentSessionDetailsBO it1, ViwStudentSessionDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.StudentID == it2.StudentID && it1.ClassDate == it2.ClassDate && it1.TimeID == it2.TimeID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwStudentSessionDetailsBO it1, ViwStudentSessionDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwTeacherFinancialDetailsBO : IBusinessObject, ICloner<ViwTeacherFinancialDetailsBO>, IGridValue
    {
        #region Variables

        public int IsSuccessorTeacher { get; set; }
        public string ClassName { get; set; }
        public int IsIncome { get; set; }
        public int MajorID { get; set; }
        public string ClassRegisterationDate { get; set; }
        public string PayTypeName { get; set; }
        public int PayID { get; set; }
        public int PayTypeID { get; set; }
        public int Fee { get; set; }
        public int? Discount { get; set; }
        public string PayDate { get; set; }
        public string CheckDate { get; set; }
        public string CheckNumber { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassID { get; set; }
        public string TeacherID { get; set; }
        #endregion


        #region Constructors

        public ViwTeacherFinancialDetailsBO()
        {
            // Nothing to do...
        }

        public ViwTeacherFinancialDetailsBO(int classID, string teacherID)
        {
            this.ClassID = classID;
            this.TeacherID = teacherID;
        }

        // Copy Constructor.
        public ViwTeacherFinancialDetailsBO(ViwTeacherFinancialDetailsBO copyViwTeacherFinancialDetailsBO)
        {
            this.IsSuccessorTeacher = copyViwTeacherFinancialDetailsBO.IsSuccessorTeacher;
            this.ClassName = copyViwTeacherFinancialDetailsBO.ClassName;
            this.IsIncome = copyViwTeacherFinancialDetailsBO.IsIncome;
            this.MajorID = copyViwTeacherFinancialDetailsBO.MajorID;
            this.ClassRegisterationDate = copyViwTeacherFinancialDetailsBO.ClassRegisterationDate;
            this.PayTypeName = copyViwTeacherFinancialDetailsBO.PayTypeName;
            this.PayID = copyViwTeacherFinancialDetailsBO.PayID;
            this.PayTypeID = copyViwTeacherFinancialDetailsBO.PayTypeID;
            this.Fee = copyViwTeacherFinancialDetailsBO.Fee;
            this.Discount = copyViwTeacherFinancialDetailsBO.Discount;
            this.PayDate = copyViwTeacherFinancialDetailsBO.PayDate;
            this.CheckDate = copyViwTeacherFinancialDetailsBO.CheckDate;
            this.CheckNumber = copyViwTeacherFinancialDetailsBO.CheckNumber;
            this.Description = copyViwTeacherFinancialDetailsBO.Description;
            this.FirstName = copyViwTeacherFinancialDetailsBO.FirstName;
            this.LastName = copyViwTeacherFinancialDetailsBO.LastName;
            this.ClassID = copyViwTeacherFinancialDetailsBO.ClassID;
            this.TeacherID = copyViwTeacherFinancialDetailsBO.TeacherID;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwTeacherFinancialDetailsDA tmpViwTeacherFinancialDetailsDA = new ViwTeacherFinancialDetailsDA(this);
            return tmpViwTeacherFinancialDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwTeacherFinancialDetailsDA tmpViwTeacherFinancialDetailsDA = new ViwTeacherFinancialDetailsDA(this);
            return tmpViwTeacherFinancialDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwTeacherFinancialDetailsDA tmpViwTeacherFinancialDetailsDA = new ViwTeacherFinancialDetailsDA(this);
            return tmpViwTeacherFinancialDetailsDA.Update();
        }

        public static List<ViwTeacherFinancialDetailsBO> List()
        {
            return ViwTeacherFinancialDetailsDA.List();
        }
        public static List<ViwTeacherFinancialDetailsBO> List(int? isSuccessorTeacher, int? IsIncome, int? majorID, int? payTypeID, int? classID, string teacherID)
        {
            return ViwTeacherFinancialDetailsDA.List(isSuccessorTeacher, IsIncome, majorID, payTypeID, classID, teacherID);
        }

        public static ViwTeacherFinancialDetailsBO Find(int classID, string teacherID)
        {
            return ViwTeacherFinancialDetailsDA.Find(classID, teacherID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.IsSuccessorTeacher.Name)
                    return IsSuccessorTeacher.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.IsIncome.Name)
                    return IsIncome == 0 ? "پرداخت حقوق" : "دریافت بابت تسویه حساب";
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.MajorID.Name)
                    return MajorID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.ClassRegisterationDate.Name)
                    return ClassRegisterationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.PayTypeName.Name)
                    return PayTypeName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.PayID.Name)
                    return PayID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.PayTypeID.Name)
                    return PayTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.Fee.Name)
                    return Fee.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.Discount.Name)
                    return Discount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.PayDate.Name)
                    return PayDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.CheckDate.Name)
                    return CheckDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.CheckNumber.Name)
                    return CheckNumber.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.Description.Name)
                    return Description.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.LastName.Name)
                    return LastName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialDetails.TeacherID.Name)
                    return TeacherID.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwTeacherFinancialDetailsBO> Members
        public ViwTeacherFinancialDetailsBO Clone()
        {
            return new ViwTeacherFinancialDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwTeacherFinancialDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwTeacherFinancialDetailsBO it1, ViwTeacherFinancialDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.TeacherID == it2.TeacherID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwTeacherFinancialDetailsBO it1, ViwTeacherFinancialDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwTeacherFinancialStatusBO : IBusinessObject, ICloner<ViwTeacherFinancialStatusBO>, IGridValue
    {
        #region Variables

        public int IsSuccessorTeacher { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string TeacherID { get; set; }
        public int ContractValue { get; set; }
        public int ContractTypeID { get; set; }
        public int? PaidToTeacher { get; set; }
        public int? GotFromTeacherBalance { get; set; }
        public int? FinalPaidToTeacher { get; set; }
        public string ClassRegisterationDate { get; set; }
        public int ClassTotalPrice { get; set; }
        public int? ReturnMoneyForTeacherAbsentAmount { get; set; }
        public int SchoolPrice { get; set; }
        public int SessionCount { get; set; }
        public int? TeacherEachSessionPortion { get; set; }
        public int? TeacherTotalPortion { get; set; }
        public int MustPaySessionCount { get; set; }
        public int MustPayToTeacherAmount { get; set; }
        #endregion

        private int? payableAmount;
        public int PayableAmount
        {
            get
            {
                if (payableAmount == null)
                    payableAmount = MustPayToTeacherAmount;
                return payableAmount.Value;
            }
            set
            {
                payableAmount = value;
            }
        }


        #region Constructors

        public ViwTeacherFinancialStatusBO()
        {
            // Nothing to do...
        }

        public ViwTeacherFinancialStatusBO(int classID, string teacherID)
        {
            this.ClassID = classID;
            this.TeacherID = teacherID;
        }

        // Copy Constructor.
        public ViwTeacherFinancialStatusBO(ViwTeacherFinancialStatusBO copyViwTeacherFinancialStatusBO)
        {
            this.IsSuccessorTeacher = copyViwTeacherFinancialStatusBO.IsSuccessorTeacher;
            this.ClassID = copyViwTeacherFinancialStatusBO.ClassID;
            this.ClassName = copyViwTeacherFinancialStatusBO.ClassName;
            this.TeacherID = copyViwTeacherFinancialStatusBO.TeacherID;
            this.ContractValue = copyViwTeacherFinancialStatusBO.ContractValue;
            this.ContractTypeID = copyViwTeacherFinancialStatusBO.ContractTypeID;
            this.PaidToTeacher = copyViwTeacherFinancialStatusBO.PaidToTeacher;
            this.GotFromTeacherBalance = copyViwTeacherFinancialStatusBO.GotFromTeacherBalance;
            this.FinalPaidToTeacher = copyViwTeacherFinancialStatusBO.FinalPaidToTeacher;
            this.ClassRegisterationDate = copyViwTeacherFinancialStatusBO.ClassRegisterationDate;
            this.ClassTotalPrice = copyViwTeacherFinancialStatusBO.ClassTotalPrice;
            this.ReturnMoneyForTeacherAbsentAmount = copyViwTeacherFinancialStatusBO.ReturnMoneyForTeacherAbsentAmount;
            this.SchoolPrice = copyViwTeacherFinancialStatusBO.SchoolPrice;
            this.SessionCount = copyViwTeacherFinancialStatusBO.SessionCount;
            this.TeacherEachSessionPortion = copyViwTeacherFinancialStatusBO.TeacherEachSessionPortion;
            this.TeacherTotalPortion = copyViwTeacherFinancialStatusBO.TeacherTotalPortion;
            this.MustPaySessionCount = copyViwTeacherFinancialStatusBO.MustPaySessionCount;
            this.MustPayToTeacherAmount = copyViwTeacherFinancialStatusBO.MustPayToTeacherAmount;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
            return tmpViwTeacherFinancialStatusDA.Add();
        }

        public bool Delete()
        {
            ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
            return tmpViwTeacherFinancialStatusDA.Delete();
        }

        public bool Update()
        {
            ViwTeacherFinancialStatusDA tmpViwTeacherFinancialStatusDA = new ViwTeacherFinancialStatusDA(this);
            return tmpViwTeacherFinancialStatusDA.Update();
        }

        public static List<ViwTeacherFinancialStatusBO> List()
        {
            return ViwTeacherFinancialStatusDA.List();
        }
        public static List<ViwTeacherFinancialStatusBO> List(int? isSuccessorTeacher, int? classID, string teacherID, bool? activityStatus)
        {
            return ViwTeacherFinancialStatusDA.List(isSuccessorTeacher, classID, teacherID, activityStatus);
        }

        public static ViwTeacherFinancialStatusBO Find(int classID, string teacherID)
        {
            return ViwTeacherFinancialStatusDA.Find(classID, teacherID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.IsSuccessorTeacher.Name)
                    return IsSuccessorTeacher == 1 ? "استاد جایگزین" : "-";
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ContractValue.Name)
                    return ContractValue.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ContractTypeID.Name)
                    return ContractTypeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.PaidToTeacher.Name)
                    return PaidToTeacher.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.GotFromTeacherBalance.Name)
                    return GotFromTeacherBalance.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.FinalPaidToTeacher.Name)
                    return FinalPaidToTeacher.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassRegisterationDate.Name)
                    return ClassRegisterationDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ClassTotalPrice.Name)
                    return ClassTotalPrice.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.ReturnMoneyForTeacherAbsentAmount.Name)
                    return ReturnMoneyForTeacherAbsentAmount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.SchoolPrice.Name)
                    return SchoolPrice.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.SessionCount.Name)
                    return SessionCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.TeacherEachSessionPortion.Name)
                    return TeacherEachSessionPortion.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.TeacherTotalPortion.Name)
                    return TeacherTotalPortion.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.MustPaySessionCount.Name)
                    return MustPaySessionCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.MustPayToTeacherAmount.Name)
                    return MustPayToTeacherAmount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.FinancialStatus.Name)
                {
                    string res = "";
                    if (MustPayToTeacherAmount == 0)
                        res = "بی حساب";
                    else
                        res = "استاد " + UtilityTxt.ToFarsiCurrency(Math.Abs(MustPayToTeacherAmount).ToString()) + " "
                            + (MustPayToTeacherAmount > 0 ? "طلبکار" : "بدهکار") + " است.";
                    if (ClassBO.Find(ClassID).IsBalancedFinalWithTeacher) res += " - " + "تسویه شده";
                    return res;
                }
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherFinancialStatus.PayableAmount.Name)
                    return PayableAmount.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwTeacherFinancialStatusBO> Members
        public ViwTeacherFinancialStatusBO Clone()
        {
            return new ViwTeacherFinancialStatusBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwTeacherFinancialStatusBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwTeacherFinancialStatusBO it1, ViwTeacherFinancialStatusBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID && it1.TeacherID == it2.TeacherID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwTeacherFinancialStatusBO it1, ViwTeacherFinancialStatusBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwTeacherSessionStatusBO : IBusinessObject, ICloner<ViwTeacherSessionStatusBO>, IGridValue
    {
        #region Variables

        public string TeacherID { get; set; }
        public int ClassID { get; set; }
        public int? StudentAbseneceCount { get; set; }
        public int? ContinuousAbseneceCount { get; set; }
        public int? TeacherAbsenceCount { get; set; }
        public int? WillHeldCount { get; set; }
        public int? HeldCount { get; set; }
        public int? NotlHeldCount { get; set; }
        public int? TotalDedicatedSessions { get; set; }
        public int? SuccessorTeacherCount { get; set; }
        public bool IsSuccessor { get; set; }
        #endregion


        #region Constructors

        public ViwTeacherSessionStatusBO()
        {
            // Nothing to do...
        }

        public ViwTeacherSessionStatusBO(int classID)
        {
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ViwTeacherSessionStatusBO(ViwTeacherSessionStatusBO copyViwTeacherSessionStatusBO)
        {
            this.TeacherID = copyViwTeacherSessionStatusBO.TeacherID;
            this.ClassID = copyViwTeacherSessionStatusBO.ClassID;
            this.StudentAbseneceCount = copyViwTeacherSessionStatusBO.StudentAbseneceCount;
            this.ContinuousAbseneceCount = copyViwTeacherSessionStatusBO.ContinuousAbseneceCount;
            this.TeacherAbsenceCount = copyViwTeacherSessionStatusBO.TeacherAbsenceCount;
            this.WillHeldCount = copyViwTeacherSessionStatusBO.WillHeldCount;
            this.HeldCount = copyViwTeacherSessionStatusBO.HeldCount;
            this.NotlHeldCount = copyViwTeacherSessionStatusBO.NotlHeldCount;
            this.TotalDedicatedSessions = copyViwTeacherSessionStatusBO.TotalDedicatedSessions;
            this.SuccessorTeacherCount = copyViwTeacherSessionStatusBO.SuccessorTeacherCount;
            this.IsSuccessor = copyViwTeacherSessionStatusBO.IsSuccessor;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwTeacherSessionStatusDA tmpViwTeacherSessionStatusDA = new ViwTeacherSessionStatusDA(this);
            return tmpViwTeacherSessionStatusDA.Add();
        }

        public bool Delete()
        {
            ViwTeacherSessionStatusDA tmpViwTeacherSessionStatusDA = new ViwTeacherSessionStatusDA(this);
            return tmpViwTeacherSessionStatusDA.Delete();
        }

        public bool Update()
        {
            ViwTeacherSessionStatusDA tmpViwTeacherSessionStatusDA = new ViwTeacherSessionStatusDA(this);
            return tmpViwTeacherSessionStatusDA.Update();
        }

        public static List<ViwTeacherSessionStatusBO> List()
        {
            return ViwTeacherSessionStatusDA.List();
        }
        public static List<ViwTeacherSessionStatusBO> List(string teacherID, int? classID)
        {
            return ViwTeacherSessionStatusDA.List(teacherID, classID);
        }

        public static ViwTeacherSessionStatusBO Find(int classID)
        {
            return ViwTeacherSessionStatusDA.Find(classID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.StudentAbseneceCount.Name)
                    return StudentAbseneceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.ContinuousAbseneceCount.Name)
                    return ContinuousAbseneceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.TeacherAbsenceCount.Name)
                    return TeacherAbsenceCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.WillHeldCount.Name)
                    return WillHeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.HeldCount.Name)
                    return HeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.NotlHeldCount.Name)
                    return NotlHeldCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.TotalDedicatedSessions.Name)
                    return TotalDedicatedSessions.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.SuccessorTeacherCount.Name)
                    return SuccessorTeacherCount.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionStatus.IsSuccessor.Name)
                    return IsSuccessor.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwTeacherSessionStatusBO> Members
        public ViwTeacherSessionStatusBO Clone()
        {
            return new ViwTeacherSessionStatusBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwTeacherSessionStatusBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwTeacherSessionStatusBO it1, ViwTeacherSessionStatusBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwTeacherSessionStatusBO it1, ViwTeacherSessionStatusBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class ViwTeacherSessionDetailsBO : IBusinessObject, ICloner<ViwTeacherSessionDetailsBO>, IGridValue
    {
        #region Variables

        public int IsSuccessor { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDate { get; set; }
        public int TimeID { get; set; }
        public string TeacherID { get; set; }
        public bool StudentAbsence { get; set; }
        public bool ContinuousAbsence { get; set; }
        public bool TeacherAbsence { get; set; }
        public string SuccessorTeacher { get; set; }
        public int SessionStatus { get; set; }
        public int? RoomNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion


        #region Constructors

        public ViwTeacherSessionDetailsBO()
        {
            // Nothing to do...
        }

        public ViwTeacherSessionDetailsBO(int classID)
        {
            this.ClassID = classID;
        }

        // Copy Constructor.
        public ViwTeacherSessionDetailsBO(ViwTeacherSessionDetailsBO copyViwTeacherSessionDetailsBO)
        {
            this.IsSuccessor = copyViwTeacherSessionDetailsBO.IsSuccessor;
            this.ClassID = copyViwTeacherSessionDetailsBO.ClassID;
            this.ClassName = copyViwTeacherSessionDetailsBO.ClassName;
            this.ClassDate = copyViwTeacherSessionDetailsBO.ClassDate;
            this.TimeID = copyViwTeacherSessionDetailsBO.TimeID;
            this.TeacherID = copyViwTeacherSessionDetailsBO.TeacherID;
            this.StudentAbsence = copyViwTeacherSessionDetailsBO.StudentAbsence;
            this.ContinuousAbsence = copyViwTeacherSessionDetailsBO.ContinuousAbsence;
            this.TeacherAbsence = copyViwTeacherSessionDetailsBO.TeacherAbsence;
            this.SuccessorTeacher = copyViwTeacherSessionDetailsBO.SuccessorTeacher;
            this.SessionStatus = copyViwTeacherSessionDetailsBO.SessionStatus;
            this.RoomNo = copyViwTeacherSessionDetailsBO.RoomNo;
            this.FirstName = copyViwTeacherSessionDetailsBO.FirstName;
            this.LastName = copyViwTeacherSessionDetailsBO.LastName;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            ViwTeacherSessionDetailsDA tmpViwTeacherSessionDetailsDA = new ViwTeacherSessionDetailsDA(this);
            return tmpViwTeacherSessionDetailsDA.Add();
        }

        public bool Delete()
        {
            ViwTeacherSessionDetailsDA tmpViwTeacherSessionDetailsDA = new ViwTeacherSessionDetailsDA(this);
            return tmpViwTeacherSessionDetailsDA.Delete();
        }

        public bool Update()
        {
            ViwTeacherSessionDetailsDA tmpViwTeacherSessionDetailsDA = new ViwTeacherSessionDetailsDA(this);
            return tmpViwTeacherSessionDetailsDA.Update();
        }

        public static List<ViwTeacherSessionDetailsBO> List(int? isSuccessor, int? classID, string classDate, int? timeID, string teacherID)
        {
            return ViwTeacherSessionDetailsDA.List(isSuccessor, classID, classDate, timeID, teacherID);
        }
        public static List<ViwTeacherSessionDetailsBO> List()
        {
            return ViwTeacherSessionDetailsDA.List();
        }

        public static ViwTeacherSessionDetailsBO Find(int classID)
        {
            return ViwTeacherSessionDetailsDA.Find(classID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.IsSuccessor.Name)
                    return IsSuccessor == 1 ? "استاد جایگزین" : "-";
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.ClassID.Name)
                    return ClassID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.ClassName.Name)
                    return ClassName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.ClassDate.Name)
                    return ClassDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.TimeID.Name)
                    return TimeBO.Find(TimeID).ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.TeacherID.Name)
                    return TeacherID.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.StudentAbsence.Name)
                    return UtilityTxt.GetString(StudentAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.ContinuousAbsence.Name)
                    return UtilityTxt.GetString(ContinuousAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.TeacherAbsence.Name)
                    return UtilityTxt.GetString(TeacherAbsence);
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.SuccessorTeacher.Name)
                    return TeacherBO.Find(SuccessorTeacher).FullName;
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.SessionStatus.Name)
                    return new SessionStatus(SessionStatus).ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.RoomNo.Name)
                    return RoomNo.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.FirstName.Name)
                    return FirstName.ToString();
                if (columnDefinition.Name == DatabaseSchema.ViwTeacherSessionDetails.LastName.Name)
                    return LastName.ToString();

            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<ViwTeacherSessionDetailsBO> Members
        public ViwTeacherSessionDetailsBO Clone()
        {
            return new ViwTeacherSessionDetailsBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (ViwTeacherSessionDetailsBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ViwTeacherSessionDetailsBO it1, ViwTeacherSessionDetailsBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.ClassID == it2.ClassID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(ViwTeacherSessionDetailsBO it1, ViwTeacherSessionDetailsBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }

    // Generated by DVD CodeGenerator
    public partial class DatabaseSynchBO : IBusinessObject, ICloner<DatabaseSynchBO>, ILastChange, IGridValue
    {
        #region Variables

        public int DbDeviceID { get; set; }
        public string HerDbAddress { get; set; }
        public string LastUpdateDate { get; set; }
        public string LastUpdateTime { get; set; }
        public string TargetDeviceNameFarsi { get; set; }
        public string TargetDeviceNameEnglish { get; set; }
        public string LastChangeID { get; set; }
        public string LastChangeDate { get; set; }
        public string LastChangeTime { get; set; }
        #endregion


        #region Constructors

        public DatabaseSynchBO()
        {
            // Nothing to do...
        }

        public DatabaseSynchBO(int dbDeviceID)
        {
            this.DbDeviceID = dbDeviceID;
        }

        // Copy Constructor.
        public DatabaseSynchBO(DatabaseSynchBO copyDatabaseSynchBO)
        {
            this.DbDeviceID = copyDatabaseSynchBO.DbDeviceID;
            this.HerDbAddress = copyDatabaseSynchBO.HerDbAddress;
            this.LastUpdateDate = copyDatabaseSynchBO.LastUpdateDate;
            this.LastUpdateTime = copyDatabaseSynchBO.LastUpdateTime;
            this.TargetDeviceNameFarsi = copyDatabaseSynchBO.TargetDeviceNameFarsi;
            this.TargetDeviceNameEnglish = copyDatabaseSynchBO.TargetDeviceNameEnglish;
            this.LastChangeID = copyDatabaseSynchBO.LastChangeID;
            this.LastChangeDate = copyDatabaseSynchBO.LastChangeDate;
            this.LastChangeTime = copyDatabaseSynchBO.LastChangeTime;
        }
        #endregion


        #region Methods (IBusinessObject)

        public bool Add()
        {
            DatabaseSynchDA tmpDatabaseSynchDA = new DatabaseSynchDA(this);
            return tmpDatabaseSynchDA.Add();
        }

        public bool Delete()
        {
            DatabaseSynchDA tmpDatabaseSynchDA = new DatabaseSynchDA(this);
            return tmpDatabaseSynchDA.Delete();
        }

        public bool Update()
        {
            DatabaseSynchDA tmpDatabaseSynchDA = new DatabaseSynchDA(this);
            return tmpDatabaseSynchDA.Update();
        }

        public static List<DatabaseSynchBO> List()
        {
            return DatabaseSynchDA.List();
        }
        public static List<DatabaseSynchBO> List(string targetDeviceNameFarsi, string targetDeviceNameEnglish)
        {
            return DatabaseSynchDA.List(targetDeviceNameFarsi, targetDeviceNameEnglish);
        }

        public static DatabaseSynchBO Find(int dbDeviceID)
        {
            return DatabaseSynchDA.Find(dbDeviceID);
        }
        #endregion


        #region Interfaces
        #region IGridValue Members
        public string GetGridValue(ColumnDefinition columnDefinition)
        {
            try
            {
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.DbDeviceID.Name)
                    return DbDeviceID.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.HerDbAddress.Name)
                    return HerDbAddress.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.LastUpdateDate.Name)
                    return LastUpdateDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.LastUpdateTime.Name)
                    return LastUpdateTime.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.TargetDeviceNameFarsi.Name)
                    return TargetDeviceNameFarsi.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.TargetDeviceNameEnglish.Name)
                    return TargetDeviceNameEnglish.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.LastChangeID.Name)
                    return LastChangeID.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.LastChangeDate.Name)
                    return LastChangeDate.ToString();
                if (columnDefinition.Name == DatabaseSchema.DatabaseSynch.LastChangeTime.Name)
                    return LastChangeTime.ToString();
            }
            catch (NullReferenceException) { }
            return "";
        }
        #endregion
        #region ICloner<DatabaseSynchBO> Members
        public DatabaseSynchBO Clone()
        {
            return new DatabaseSynchBO(this);
        }
        #endregion
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (DatabaseSynchBO)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(DatabaseSynchBO it1, DatabaseSynchBO it2)
        {
            bool ans = false;
            if ((object)it1 == null && (object)it2 == null)
                return true;
            try
            {
                ans = true && it1.DbDeviceID == it2.DbDeviceID;
            }
            catch (Exception) { }
            return ans;
        }

        public static bool operator !=(DatabaseSynchBO it1, DatabaseSynchBO it2)
        {
            return !(it1 == it2);
        }
        #endregion
    }


    #endregion





    // Not AutoGenerated.
    public partial class DesktopUsersBO
    {
        private EmployeeBO relEmployee = null;
        public EmployeeBO RelEmployee
        {
            get
            {
                if (relEmployee == null)
                {
                    relEmployee = EmployeeBO.Find(EmployeeID);
                }
                return relEmployee;
            }
        }

        public override string ToString()
        {
            return ComboText;
        }

        public static void FillCombo(ComboBox cbo)
        {
            cbo.Items.Clear();
            List<DesktopUsersBO> items = List();
            foreach (DesktopUsersBO item in items)
            {
                if (item.Username.Trim().ToLower() != "admin")
                    cbo.Items.Add(item);
            }
        }

        public static DesktopUsersBO Find(string username, string password)
        {
            return DesktopUsersDA.Find(username, password);
        }


        public static bool ChagePassword(string username, string lastPass, string newPass)
        {
            return DesktopUsersDA.ChangePassword(username, lastPass, newPass);
        }

        public static bool SetLoginTime(string username, string loginDate, string loginTime)
        {
            return DesktopUsersDA.SetLoginTime(username, loginDate, loginTime);
        }
    }


}
