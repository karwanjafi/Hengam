using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseSchemaNamespace;
using System.Data.SqlClient;
using Tools;
using Hengam.Tools;

namespace Hengam.Tools
{

    class ActivitySetter : DataAccessNamespace.DataAccess
    {
        public class KeyInfo
        {
            public KeyInfo()
            {

            }

            public KeyInfo(string KeyName, string KeyValueString)
            {
                this.KeyName = KeyName;
                this.KeyValueString = KeyValueString;
            }
            public string KeyName;
            public string KeyValueString;
        }

        public ActivitySetter(string TableName, string StatusColumnName, List<KeyInfo> Keys)
        {
            this.TableName = TableName;
            this.ColumnName = StatusColumnName;
            this.Keys = Keys;
        }

        public string TableName { get; set; }

        public string ColumnName { get; set; }

        public List<KeyInfo> Keys = new List<KeyInfo>();

        public bool SetStatus(bool newStatus)
        {
            string keysStr = "";
            foreach(KeyInfo key in Keys)
            {
                keysStr += string.Format(" AND {0}={1} ", key.KeyName, key.KeyValueString);
            }

            string commandString = string.Format(
            " UPDATE {0} SET " +
            " 	{1} = @columnName " +
            " WHERE (1=1) " +
            "  {2}	 "
            , TableName, ColumnName, keysStr );

            SqlCommand command = new SqlCommand();
            command.CommandText = commandString;

            // Adding Parameters...
            UtilityDB.AddParameter(command.Parameters, "@columnName", newStatus);

            // Doing Database part...
            using (/*SqlConnection connection = new SqlConnection(connectionString)*/connection)
            {
                checkConnectionState(connection); connection.Open();//hanieh
                command.Connection = connection;
                if ((JobLogger.RunCommandNonQuery(command)) == 1)
                    return true;
                else
                    return false;
            }
        }
    }

    public interface IActivityStatus
    {
        bool SetStatus(bool newStatus);
        bool ActivityStatus { get; }
        string StatusDescription { get; }
        string AdditionalInformation { get; }
        bool IsDeactiveCandidate();
        List<ColumnDefinition> StatusInfoColumns { get; }
        string CaseName { get; }
        string CaseNameI { get; }
        string DeactiveRule { get; }
    }

    public interface IActivityManager<T> : IActivityStatus
    {
        List<T> List(bool? activityStatus);
        List<T> ListDeactiveCandidates();
    }
}
