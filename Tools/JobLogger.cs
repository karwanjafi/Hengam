using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessNamespace;
using Tools;

namespace Hengam.Tools
{
    public class JobLogger
    {
        public static int BufferSize = 1;
        public static Guid loginID;
        public static bool Enabled = true;

        //public string jobDate;
        //public string jobTime;
        private double Duration;
        private string Query;
        private string Parameteres;
        private string Result;
        private string Description;


        private static List<JobLogger> UnCommittedJobs = new List<JobLogger>();

        public static void AddJobToCommit(JobLogger job)
        {
            UnCommittedJobs.Add(job);
        }

        public static int CommitAll()
        {
            if (!Enabled) return 0;
            string commandString =
                " INSERT INTO activityLog " +
                " (loginID, jobQuery, jobParameters, jobDuration, jobDescription, jobResult, jobType, jobTime) " +
                " VALUES     (@loginID,@jobQuery,@jobParameters,@jobDuration,@jobDescription,@jobResult, @jobType, @jobTime) ";
            SqlCommand command = new SqlCommand();
            command.CommandText = commandString;

            int counter = 0;
            using (SqlConnection connection = new SqlConnection(DataAccess.connectionString))
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = commandString;

                while (UnCommittedJobs.Count > 0)
                {
                    JobLogger job = UnCommittedJobs[0];
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@loginID", JobLogger.loginID);
                    command.Parameters.AddWithValue("@jobQuery", job.Query);
                    command.Parameters.AddWithValue("@jobParameters", job.Parameteres);
                    command.Parameters.AddWithValue("@jobDuration", job.Duration);
                    command.Parameters.AddWithValue("@jobDescription", job.Description);
                    command.Parameters.AddWithValue("@jobResult", job.Result);
                    command.Parameters.AddWithValue("@jobType", 0);
                    command.Parameters.AddWithValue("@jobTime", FaDate.CurrentTimeString);
                    if (command.ExecuteNonQuery() == 1)
                        counter++;
                    UnCommittedJobs.RemoveAt(0);
                }
            }
            return counter;
        }



        public void Start(string inQuery, string inParameters, string inDescription)
        {
            Query = inQuery;
            Parameteres = inParameters;
            Description = inDescription;
            AddJobToCommit(this);
            // Add code to store uncommitteds in a txt file. so it can recover after failure.
        }

        public void Finished(string inResult, double inDuration)
        {
            Result = inResult;
            Duration = inDuration;
            if (UnCommittedJobs.Count >= BufferSize)
                CommitAll();
        }

        public static int RunCommandNonQuery(SqlCommand command)
        {
            SqlException sqlExcept = null;
            Exception except = null;
            string resStr = "";
            int res = 0;
            JobLogger job = new JobLogger();
            job.Start(command.CommandText, ParameterToString(command.Parameters), "Nothing");
            DateTime now = DateTime.Now;
            try
            {
                res = command.ExecuteNonQuery();
                resStr = res.ToString() + " rows affected.";
            }
            catch (SqlException sqlEx)
            {
                resStr = "Err.SqlEx" + (sqlEx.Number.ToString() + "\n" + sqlEx.Message);
                sqlExcept = sqlEx;
            }
            catch (Exception ex)
            {
                resStr = "Err.Ex\n" + ex.Message;
                except = ex;
            }
            finally
            {
                TimeSpan dif = (DateTime.Now - now);
                resStr = resStr.Substring(0, Math.Min(resStr.Length, 200));
                job.Finished(resStr, dif.TotalSeconds);
            }

            if (sqlExcept != null) throw sqlExcept;
            if (except != null) throw except;

            return res;
        }

        public static SqlDataReader RunCommandReader(SqlCommand command)
        {
            SqlException sqlExcept = null;
            Exception except = null;
            string resStr = "";

            SqlDataReader res = null;
            JobLogger job = new JobLogger();
            job.Start(command.CommandText, ParameterToString(command.Parameters), "Nothing");
            DateTime now = DateTime.Now;
            try
            {
                res = command.ExecuteReader();
                resStr = "DataReader Executed.";
            }
            catch (SqlException sqlEx)
            {
                resStr = "Err.SqlEx" + (sqlEx.Number.ToString() + "\n" + sqlEx.Message);
                sqlExcept = sqlEx;
            }
            catch (Exception ex)
            {
                resStr = "Err.Ex\n" + ex.Message;
                except = ex;
            }
            finally
            {
                TimeSpan dif = (DateTime.Now - now);
                resStr = resStr.Substring(0, Math.Min(resStr.Length, 200));
                job.Finished(resStr, dif.TotalSeconds);
            }

            //if (sqlExcept != null) throw sqlExcept;
            if (except != null) throw except;

            return res;
        }

        public static string ParameterToString(SqlParameterCollection pars)
        {
            string res = "";
            foreach (SqlParameter par in pars)
            {
                res +=
                    par.ParameterName + "=" + (par.Value == null ? "NULL" : par.Value.ToString()) + ", ";
            }
            return res;
        }

        public static void FillDataTable(SqlDataAdapter adap, DataTable table)
        {
            SqlException sqlExcept = null;
            Exception except = null;
            string resStr = "";
            int res = 0;

            JobLogger job = new JobLogger();
            job.Start(adap.SelectCommand.CommandText, ParameterToString(adap.SelectCommand.Parameters), "Report");
            DateTime now = DateTime.Now;
            try
            {
                res = adap.Fill(table);
                resStr = res.ToString() + " rows affected.";
            }
            catch (SqlException sqlEx)
            {
                resStr = "Err.SqlEx" + (sqlEx.Number.ToString() + "\n" + sqlEx.Message);
                sqlExcept = sqlEx;
            }
            catch (Exception ex)
            {
                resStr = "Err.Ex\n" + ex.Message;
                except = ex;
            }
            finally
            {
                TimeSpan dif = (DateTime.Now - now);
                resStr = resStr.Substring(0, Math.Min(resStr.Length, 200));
                job.Finished(resStr, dif.TotalSeconds);
            }

            if (sqlExcept != null) throw sqlExcept;
            if (except != null) throw except;

        }


    }
}
