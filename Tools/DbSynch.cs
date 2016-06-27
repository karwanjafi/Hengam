using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Management.Common;

namespace Hengam.Tools.DbSynch
{
    class DbSynch
    {
        public static SqlConnection TargetConnection;
        public static string sourceConnectionString;

        private bool UpdateRow(string tableName, List<Pair> whereList, List<Pair> updateList)
        {
            try
            {
                string upStr = "";
                updateList.ForEach(p=>upStr += string.Format("[{0}] = {1},\n", p.ColumnName, p.ParameterName)); 
                upStr = upStr.TrimEnd(',', '\n', ' ');

                string whereStr = "";
                whereList.ForEach(p=>whereStr += string.Format("([{0}] = {1}) AND\n", p.ColumnName, p.ParameterName)); 
                whereStr = whereStr.TrimEnd('A', '\n', 'N', 'D', ' ');
                
                
                string updateCommandString =
                    string.Format(" UPDATE {0} SET\n", tableName) +
                    upStr + 
                    " WHERE " +
                    whereStr;

                string varStr = "";
                whereList.ForEach(p=>varStr += string.Format("[{0}],\n", p.ColumnName)); 
                updateList.ForEach(p=>varStr += string.Format("[{0}],\n", p.ColumnName)); 
                varStr = varStr.TrimEnd(',', '\n', ' ');

                string parStr = "";
                whereList.ForEach(p=>parStr += string.Format("{0},\n", p.ParameterName)); 
                updateList.ForEach(p=>parStr += string.Format("{0},\n", p.ParameterName)); 
                parStr = parStr.TrimEnd(',', '\n', ' ');

                string insertCommandString =
                    string.Format(" INSERT INTO {0} (", tableName) +
                    varStr +
                    " ) " + 
                    " VALUES ( " + 
                    parStr +
                    " ) ";

                SqlCommand comInsert = new SqlCommand();
                comInsert.CommandText = insertCommandString;

                SqlCommand comUpdate = new SqlCommand();
                comUpdate.CommandText = updateCommandString;

                comUpdate.CommandType = comInsert.CommandType = System.Data.CommandType.Text;

                foreach (Pair p in whereList)
                {
                    comInsert.Parameters.AddWithValue(p.ParameterName, p.Val);
                    comUpdate.Parameters.AddWithValue(p.ParameterName, p.Val);
                }

                foreach (Pair p in updateList)
                {
                    comInsert.Parameters.AddWithValue(p.ParameterName, p.Val);
                    comUpdate.Parameters.AddWithValue(p.ParameterName, p.Val);
                }
            
                comUpdate.Connection = comInsert.Connection = TargetConnection;
                int resUpdate = 0;
                int resInsert = 0;
                try
                {
                    resUpdate = comUpdate.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                }
                catch (Exception) { }
                if (resUpdate == 0)
                {
                    try
                    {
                        resInsert = comInsert.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                    }
                    catch (Exception) { }
                }

                if (resUpdate == 0 && resInsert == 0)
                    return false;
                return true;
            }
            catch (SqlException sqlEx)
            {
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        private List<Pair> GetWhereList(Table tableSchema, DataRow row)
        {
            List<Pair> res = new List<Pair>();
            foreach (Column col in tableSchema.Columns)
            {
                if (col.InPrimaryKey)
                    res.Add(new Pair(col.Name, row[col.Name]));
            }
            return res;
        }

        private List<Pair> GetUpdateList(Table tableSchema, DataRow row)
        {
            List<Pair> res = new List<Pair>();
            foreach (Column col in tableSchema.Columns)
            {
                if (!col.InPrimaryKey)
                    res.Add(new Pair(col.Name, row[col.Name]));
            }
            return res;
        }

        public bool SyncTable(string tableName, string dateFrom, string timeFrom)
        {
            SqlConnection sqlCon = new SqlConnection(sourceConnectionString);
            ServerConnection con = new ServerConnection(sqlCon);
            //con.ConnectionString = sourceConnectionString;

            Server svr = new Server(con);

            Table tableSchema = null;
            DataTable tableData = new DataTable();
            try
            {
                tableSchema = svr.Databases[sqlCon.Database].Tables[tableName];

                SqlDataAdapter adapter = new SqlDataAdapter(
                    string.Format(" SELECT * FROM {0} WHERE lastChangeDate >= '{1}' OR " +
                                  " ( lastChangeDate = '{1}' AND lastChangeTime >= '{2}') ", tableName, dateFrom, timeFrom),
                    sqlCon);

                adapter.Fill(tableData);
            }
            catch (Exception) { }

            int totalCount = tableData.Rows.Count;
            int updatedCount = 0;
            bool res = true;
            foreach (DataRow row in tableData.Rows)
            {
                List<Pair> whereList = GetWhereList(tableSchema, row);
                List<Pair> updateList = GetUpdateList(tableSchema, row);
                res &= UpdateRow(tableName, whereList, updateList);
                if (ProgressChanged != null) ProgressChanged(this, (updatedCount++) * 100 / totalCount);
            }
            return true;
        }

        class Pair
        {
            public Pair()
            {
            }

            public Pair(string columnName, object val)
                : this()
            {
                this.columnName = columnName;
                this.val = val;
            }
            private string columnName;

            public string ColumnName
            {
                get { return columnName; }
                set { columnName = value; }
            }
            private object val;

            public object Val
            {
                get { return val; }
                set { val = value; }
            }

            public string ParameterName
            {
                get { return "@" + columnName; }
            }
        }

        public event ProgressChangedEventHandler ProgressChanged;
    }

    delegate void ProgressChangedEventHandler(object sender, int newProgressValue);

    interface ISynchable
    {
        string ItemName { get; set; }
        int EstimatedEffort { get; set; }
        bool SynchItem(string dateFrom, string dateTo);
        int ProgressValue { get; set; }
        event ProgressChangedEventHandler ProgressChanged;
    }

    class TypicalSynchable : ISynchable
    {
        public TypicalSynchable()
        {
        }

        public TypicalSynchable(string ItemName, string TableName, int EstimatedEffort)
        {
            this.ItemName = ItemName;
            this.TableName = TableName;
            this.EstimatedEffort = EstimatedEffort;
            //this.TargetConnection = TargetConnection;
        }

        //public SqlConnection TargetConnection;

        public string TableName { get; set; }

        #region ISynchable Members

        public string ItemName
        {
            get;
            set;
        }

        public int EstimatedEffort
        {
            get;
            set;
        }

        public bool SynchItem(string dateFrom, string dateTo)
        {
            DbSynch syncher = new DbSynch();
            syncher.ProgressChanged += ProgressChanged;

            return syncher.SyncTable(TableName, dateFrom, dateTo);
        }

        int progressValue = 0;
        public int ProgressValue
        {
            get{return progressValue;}
            set{progressValue = value;}
        }

        public event ProgressChangedEventHandler ProgressChanged;

        #endregion
    }


    class Syncher
    {
        public string SourceConnectionString = "";

        public string DateFrom = null;
        public string DateTo = null;

        public List<ISynchable> synchables
        {
            get
            {
                return new List<ISynchable>
                {
                    new TypicalSynchable("", "howToFind", 30)
                    //new TypicalSynchable("", "teacher", 10)
                };
            }
        }

        
        public bool Synch(SqlConnection connection)
        {
            DbSynch.sourceConnectionString = SourceConnectionString;
            DbSynch.TargetConnection = connection;

            //DbSynch.TargetConnection.Open();

            bool res = true;

            //try
            {
                foreach (ISynchable synchable in synchables)
                {
                    synchable.ProgressChanged += new ProgressChangedEventHandler(synchable_ProgressChanged);
                    res &= synchable.SynchItem(DateFrom, DateTo);
                }
            }
            //catch (Exception) { }

            //DbSynch.TargetConnection.Close();
            return res;
        }

        void synchable_ProgressChanged(object sender, int newProgressValue)
        {
            if (ProgressChanged != null)
                ProgressChanged(sender, newProgressValue);
        }


        public event ProgressChangedEventHandler ProgressChanged;
    }

}
