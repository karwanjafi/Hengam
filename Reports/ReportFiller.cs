using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Hengam.Reports.ReportDataSets;
using System.Windows.Forms;
using Hengam.Forms;
using System.Data.SqlClient;
using DataAccessNamespace;
using Hengam.Tools;
using Hengam.Reports.ReportPapers;
using BusinessObjectNamespace;
using Tools;

namespace Hengam.Reports
{
    class ReportFiller
    {
        private static void FillReport(CrystalDecisions.CrystalReports.Engine.ReportClass rpt, DataTable dtTable)
        {
            dsReportHeader ds = new dsReportHeader();
            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from schoolSpecification ";

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["schoolSpecification"]);
            }
            rpt.Subreports["rptHeaderArm.rpt"].SetDataSource(ds);
            rpt.Subreports["rptHeaderBackground.rpt"].SetDataSource(ds);
            rpt.Subreports["rptFooter.rpt"].SetDataSource(ds);
            rpt.SetDataSource(dtTable);
        }


        private static void FillSmallReport(CrystalDecisions.CrystalReports.Engine.ReportClass rpt, DataTable dtTable)
        {
            dsReportHeader ds = new dsReportHeader();
            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from schoolSpecification ";

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["schoolSpecification"]);
            }
            //rpt.Subreports["rptFooter.rpt"].SetDataSource(ds);
            rpt.SetDataSource(dtTable);
        }
        
        private static void FillReportWide(CrystalDecisions.CrystalReports.Engine.ReportClass rpt, DataTable dtTable)
        {
            dsReportHeader ds = new dsReportHeader();
            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from schoolSpecification ";

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["schoolSpecification"]);
            }
            rpt.Subreports["rptHeaderArmWide.rpt"].SetDataSource(ds);
            rpt.Subreports["rptHeaderBackgroundWide.rpt"].SetDataSource(ds);
            rpt.Subreports["rptFooterWide.rpt"].SetDataSource(ds);
            rpt.SetDataSource(dtTable);
        }

        private static void FillReportA5(CrystalDecisions.CrystalReports.Engine.ReportClass rpt, DataTable dtTable)
        {
            dsReportHeader ds = new dsReportHeader();
            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from schoolSpecification ";

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["schoolSpecification"]);
            }
            rpt.Subreports["rptHeaderArmA5.rpt"].SetDataSource(ds);
            rpt.Subreports["rptHeaderBackgroundA5.rpt"].SetDataSource(ds);
            rpt.Subreports["rptFooterA5.rpt"].SetDataSource(ds);
            rpt.SetDataSource(dtTable);
        }

        public static frmReportViewer GetReportForm(CrystalDecisions.CrystalReports.Engine.ReportClass rpt, string reportCaption)
        {
            frmReportViewer rptViewer = new frmReportViewer(rpt, reportCaption);
            return rptViewer;
        }

        public static frmReportViewer StudentInformation(string studentID)
        {
            dsStudentInformation ds = new dsStudentInformation();
            rptStudentInformation rpt = new rptStudentInformation();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT     student.*, degreeLevel.degreeLevelName, degreeType.degreeTypeName " +
                    " FROM         student LEFT OUTER JOIN " +
                    "                       degreeLevel ON student.degreeLevelID = degreeLevel.degreeLevelID LEFT OUTER JOIN " +
                    "                       degreeType ON student.degreeTypeID = degreeType.degreeTypeID ";

                string wherePart = " WHERE (1=1) ";
                if (studentID != null)
                    wherePart += string.Format(" AND (StudentID = '{0}') ", studentID);

                commandString += wherePart;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["StudentInformation"]);
            }

            FillReport(rpt, ds.Tables["StudentInformation"]);
            return GetReportForm(rpt, "مشخصات دانشجو");
        }

        public static frmReportViewer ReportTeacherInformation(string teacherID)
        {
            dsTeacherInformation ds = new dsTeacherInformation();
            rptTeacherInformation rpt = new rptTeacherInformation();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT   * from viwRptTeacherInformation ";

                string wherePart = " WHERE (1=1) ";
                if (teacherID != null)
                    wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                commandString += wherePart;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);
            return GetReportForm(rpt, "مشخصات استاد");
        }

        public static frmReportViewer ReportEmployeeInformation(string employeeID)
        {
            dsEmployeeInformation ds = new dsEmployeeInformation();
            rptEmployeeInformation rpt = new rptEmployeeInformation();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT   * from viwRptEmployeeInformation ";

                string wherePart = " WHERE (1=1) ";
                if (employeeID != null)
                    wherePart += string.Format(" AND (employeeID = '{0}') ", employeeID);

                commandString += wherePart;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);
            return GetReportForm(rpt, "مشخصات کارمند");
        }




        //public static Form StudentInformation(string classSecID, bool JustValids, string Caption)
        //{
        //    rptExamListReport rpt = new rptExamListReport();
        //    dsExamList ds = new dsExamList();

        //    using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "prcExamList";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@classSecID", classSecID);
        //        cmd.Parameters.AddWithValue("@financialFlagMin", JustValids ? 1 : 0);
        //        cmd.Parameters.AddWithValue("@educationFlagMin", JustValids ? 1 : 0);
        //        cmd.Connection = con;

        //        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        //        ds.EnforceConstraints = false;
        //        adap.Fill(ds.Tables["ExamList"]);
        //    }

        //    rpt.SetDataSource(ds);

        //    frmReportViewer frmView = new frmReportViewer(rpt, Caption);
        //    return frmView;
        //}

        public static object ReportStudentListOfMajor(int majorID, string dateFrom, string dateTo, string majorName, string orderText)
        {
            rptStudentListOfMajor rpt = new rptStudentListOfMajor();
            dsViwRptStudentListOfMajor ds = new dsViwRptStudentListOfMajor();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptStudentListOfMajor ";

                string wherePart = " WHERE (1=1) ";
                
                wherePart += string.Format(" AND (majorID = '{0}') ", majorID);

                if (dateFrom != null)
                    wherePart += string.Format(" AND (registrationDate >= '{0}') ", dateFrom);

                if (dateTo!= null)
                    wherePart += string.Format(" AND (registrationDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables["viwRptStudentListOfMajor"]);
            }

            FillReport(rpt, ds.Tables["viwRptStudentListOfMajor"]);
            
            rpt.SetParameterValue("prmMajorName", majorName);
            rpt.SetParameterValue("prmDateFrom", dateFrom);
            rpt.SetParameterValue("prmDateTo", dateTo);
            
            
            return rpt;
        }

        public static object ReportPaysOfTeacherInterval(string teacherID, string dateFrom, string dateTo, string teacherName, string orderText)
        {
            rptPaysOfTeacherInterval rpt = new rptPaysOfTeacherInterval();
            dsPaysOfTeacherInterval ds = new dsPaysOfTeacherInterval();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptPaysOfTeacherInterval ";

                string wherePart = " WHERE (1=1) ";

                wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                if (dateFrom != null)
                    wherePart += string.Format(" AND (payDate >= '{0}') ", dateFrom);

                if (dateTo != null)
                    wherePart += string.Format(" AND (payDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);

            rpt.SetParameterValue("prmTeacherName", teacherName);
            rpt.SetParameterValue("prmDateFrom", dateFrom);
            rpt.SetParameterValue("prmDateTo", dateTo);


            return rpt;
        }

        public static object ReportSessionsOfTeacherInterval(string teacherID, string dateFrom, string dateTo, string teacherName, string orderText)
        {
            rptSessionsOfTeacherInterval rpt = new rptSessionsOfTeacherInterval();
            dsViwRptSessionsOfTeacherInterval ds = new dsViwRptSessionsOfTeacherInterval();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptSessionsOfTeacherInterval ";

                string wherePart = " WHERE (1=1) ";

                wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                if (dateFrom != null)
                    wherePart += string.Format(" AND (classDate >= '{0}') ", dateFrom);

                if (dateTo != null)
                    wherePart += string.Format(" AND (classDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReportWide(rpt, ds.Tables[0]);

            rpt.SetParameterValue("prmTeacherName", teacherName);
            rpt.SetParameterValue("prmDateFrom", dateFrom);
            rpt.SetParameterValue("prmDateTo", dateTo);


            return rpt;
        }

        //Added by Hanieh --------------------------------------
        public static object ReportSessionsOfTeacher3months(string teacherID, string dateFrom, string orderText)
        {
            rptSessionsOfTeacher3months rpt = new rptSessionsOfTeacher3months();
            dsviwRptSessionsOfTeacher3months ds = new dsviwRptSessionsOfTeacher3months();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptSessionsOfTeacher3months ";

                string wherePart = " WHERE (1=1) ";

                wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                if (dateFrom != null)
                    wherePart += string.Format(" AND (classDate = '{0}') ", dateFrom);

                //if (dateTo != null)
                //    wherePart += string.Format(" AND (classDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReportWide(rpt, ds.Tables[0]);

            //rpt.SetParameterValue("prmTeacherName", teacherName);
            rpt.SetParameterValue("prmDateFrom", dateFrom);
            //rpt.SetParameterValue("prmDateTo", dateTo);


            return rpt;
        }
        //------------------------------------------------------
        public static object ReportRegisterationStudentFactor(string studentID, int classID, string orderText)
        {
            rptRegisterationStudentFactor rpt = new rptRegisterationStudentFactor();
            dsViwRptRegisterationStudentFactor ds = new dsViwRptRegisterationStudentFactor();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptRegisterationStudentFactor ";

                string wherePart = " WHERE (1=1) ";

                wherePart += string.Format(" AND (studentID = '{0}') ", studentID);

                wherePart += string.Format(" AND (classID = {0}) ", classID);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);

            return rpt;
        }

        public static object ReportMinistryReport(string dateFrom, string dateTo, string orderText)
        {
            rptMinistryReport rpt = new rptMinistryReport();
            dsViwRptMinistryReport ds = new dsViwRptMinistryReport();
            dsSchoolSpecification dsSchool = new dsSchoolSpecification();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " select viwRptMinistryReport.* , isnull(viwUnder18.under18count,0) as under18count from viwRptMinistryReport left outer join  " +
                    " (SELECT     class_1.classID as classID, COUNT(student.studentID) AS under18Count " +
                    " FROM         class AS class_1 INNER JOIN " +
                    "                       registration ON class_1.classID = registration.classID INNER JOIN " +
                    "                       student ON registration.studentID = student.studentID " +
                    " where dbo.age(birthdate, @ageDay)<'0018/00/00' " +
                    " GROUP BY class_1.classID) viwUnder18 " +
                    " on viwRptMinistryReport.classID = viwUnder18.classID ";

                string wherePart = " WHERE (1=1) ";

                if (dateFrom != null)
                    wherePart += string.Format(" AND (classRegisterationDate >= '{0}') ", dateFrom);

                if (dateTo != null)
                    wherePart += string.Format(" AND (classRegisterationDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Parameters.AddWithValue("@ageday", FaDate.CurrentFaDateString);

                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);

            }

            //FillReportWide(rpt, ds.Tables[0]);
            rpt.SetDataSource(ds);

            List<SchoolSpecificationBO> schools = SchoolSpecificationBO.List();
            if (schools.Count > 0)
            {
                SchoolSpecificationBO school = schools[0];
                rpt.SetParameterValue("pSchoolName", UtilityTxt.GetString( school.SchoolName));
                rpt.SetParameterValue("pManagerFirstName", UtilityTxt.GetString(school.ManagerFirstName));
                rpt.SetParameterValue("pManagerLastName", UtilityTxt.GetString(school.ManagerLastName));
                rpt.SetParameterValue("pManagerBirthDate", UtilityTxt.GetString(school.ManagerBirthDate));
                rpt.SetParameterValue("pManagerStudyMajor", UtilityTxt.GetString(school.ManagerStudeyMajor));
                rpt.SetParameterValue("pWorkHour", UtilityTxt.GetString(school.WorkHour));
                rpt.SetParameterValue("pProvince", UtilityTxt.GetString(school.Province));
                rpt.SetParameterValue("pCity", UtilityTxt.GetString(school.City));
                rpt.SetParameterValue("pStreet", UtilityTxt.GetString(school.Street));
                rpt.SetParameterValue("pEmployeeNumber", UtilityTxt.GetString(school.EmployeeNumber.ToString()));
                rpt.SetParameterValue("pFondYear", UtilityTxt.GetString(school.FondYear));
                rpt.SetParameterValue("pSchoolGrade", UtilityTxt.GetString(school.SchoolGrade));
                rpt.SetParameterValue("pPostalCode", UtilityTxt.GetString(school.PostalCode));
                rpt.SetParameterValue("pTell", UtilityTxt.GetString(school.Tell));
                rpt.SetParameterValue("pJustificationNumber", UtilityTxt.GetString(school.JustificationID));
            }



            return rpt;
        }

        public static object ReportClassesOfTeacherInterval(string teacherID, string dateFrom, string dateTo, string teacherName, string orderText)
        {
            rptClassesOfTeacherInterval rpt = new rptClassesOfTeacherInterval();
            dsViwRptClassesOfTeacherInterval ds = new dsViwRptClassesOfTeacherInterval();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptClassesOfTeacherInterval ";

                string wherePart = " WHERE (1=1) ";

                wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                if (dateFrom != null)
                    wherePart += string.Format(" AND (classRegisterationDate >= '{0}') ", dateFrom);

                if (dateTo != null)
                    wherePart += string.Format(" AND (classRegisterationDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReportWide(rpt, ds.Tables[0]);

            rpt.SetParameterValue("prmTeacherName", teacherName);
            rpt.SetParameterValue("prmDateFrom", dateFrom);
            rpt.SetParameterValue("prmDateTo", dateTo);


            return rpt;
        }

        public static object ReportStudentPayFactor(string studentID, int? classID, int? payID, string orderText)
        {
            rptStudentPayFactor rpt = new rptStudentPayFactor();
            dsStudentPayFactor ds = new dsStudentPayFactor();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptStudentPayFactor ";

                string wherePart = " WHERE (1=1) ";

                if (studentID != null)
                    wherePart += string.Format(" AND (studentID = '{0}') ", studentID);

                if (classID != null)
                    wherePart += string.Format(" AND (classID = {0}) ", classID);

                if (payID != null)
                    wherePart += string.Format(" AND (payID = {0}) ", payID);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillSmallReport(rpt, ds.Tables[0]);
            rpt.SetParameterValue("prmFooterDesc", SchoolSpecificationBO.List()[0].ReportPayFactorFooterDesc);
            return rpt;
        }

        public static object ReportTypicalOutcomeYear(string payYear)
        {
            rptTypicalOutcomeYear rpt = new rptTypicalOutcomeYear();
            dsTypcialOutcomeYear ds = new dsTypcialOutcomeYear();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "prcRptTypicalOutcomeYearly";
                cmd.Parameters.AddWithValue("@payYear", payYear);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);

            }

            FillReport(rpt, ds.Tables[0]);
            //rpt.SetDataSource(ds);

            return rpt;
        }

        public static object ReportIncomeInterval( string dateFrom, string dateTo, string orderText)
        {
            rptIncomeInterval rpt = new rptIncomeInterval();
            dsIncomeInterval ds = new dsIncomeInterval();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptIncomeInterval ";

                string wherePart = " WHERE (1=1) ";


                if (dateFrom != null)
                    wherePart += string.Format(" AND (payDate >= '{0}') ", dateFrom);

                if (dateTo != null)
                    wherePart += string.Format(" AND (payDate <= '{0}') ", dateTo);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);

            rpt.SetParameterValue("prmDateFrom", dateFrom);
            rpt.SetParameterValue("prmDateTo", dateTo);


            return rpt;
        }

        public static object ReportRegisteredStudentsPerEmployee(string regYear)
        {
            rptRegisteredStudentsPerEmployee rpt = new rptRegisteredStudentsPerEmployee();
            dsRegisteredStudentsPerEmployee ds = new dsRegisteredStudentsPerEmployee();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "prcRptRegisteredStudentsPerEmployee";
                cmd.Parameters.AddWithValue("@regYear", regYear);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);

            }

            FillReport(rpt, ds.Tables[0]);
            //rpt.SetDataSource(ds);

            return rpt;
        }
        public static object ReportTeacherPayFactor(string teacherID, int? classID, string groupPayID, string orderText)
        {
            rptTeacherPayFactor rpt = new rptTeacherPayFactor();
            dsTeacherPayFactor ds = new dsTeacherPayFactor();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                
                string commandString =
                    " SELECT a.*,b.willheldcount,b.heldcount,b.notlHeldCount-b.continuousAbseneceCount notlHeldCount from viwRptTeacherPayFactor a,viwStudentSessionStatus b "; //hanieh

               // string wherePart = " WHERE (1=1) ";
                string wherePart = " WHERE a.classID=b.classID "; //hanieh

                if (teacherID != null)
                    wherePart += string.Format(" AND (teacherID = '{0}') ", teacherID);

                if (groupPayID != null)
                    wherePart += string.Format(" AND (groupPayID = '{0}') ", groupPayID);

                if (classID != null)  //hanieh
                    wherePart += string.Format(" AND (a.classID = {0}) ", classID); //hanieh

                //if (payID != null)
                //    wherePart += string.Format(" AND (payID = {0}) ", payID);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReportA5(rpt, ds.Tables[0]);

            return rpt;
        }

        public static object ReportEmployeePayFactor(string employeeID, int? payID, string orderText)
        {
            rptEmployeePayFactor rpt = new rptEmployeePayFactor();
            dsEmployeePayFactor ds = new dsEmployeePayFactor();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptEmployeePayFactor ";

                string wherePart = " WHERE (1=1) ";

                if (employeeID != null)
                    wherePart += string.Format(" AND (employeeID = '{0}') ", employeeID);

                if (payID != null)
                    wherePart += string.Format(" AND (payID = {0}) ", payID);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReportA5(rpt, ds.Tables[0]);

            return rpt;
        }

        public static object ReportStudentsOfPublicClass(int classID, string orderText)
        {
            rptStudentsOfPublicClass rpt = new rptStudentsOfPublicClass();
            dsStudentsOfPublicClass ds = new dsStudentsOfPublicClass();

            // Filling dataset...
            using (SqlConnection con = new SqlConnection(DataAccess.connectionString))
            {
                SqlCommand cmd = new SqlCommand();

                string commandString =
                    " SELECT * from viwRptStudentsOfPublicClass ";

                string wherePart = " WHERE (1=1) ";


                wherePart += string.Format(" AND (classID = {0}) ", classID);

                commandString += wherePart + orderText;

                cmd.CommandText = commandString;
                cmd.Connection = con;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                ds.EnforceConstraints = false;
                JobLogger.FillDataTable(adap, ds.Tables[0]);
            }

            FillReport(rpt, ds.Tables[0]);

            return rpt;
        }
    }
}
