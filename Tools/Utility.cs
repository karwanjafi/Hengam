using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using DatabaseSchemaNamespace;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using FarsiMessageBox;
using FarsiLibrary.Utils;
using Hengam.Tools;
using System.Reflection;
using System.Linq;


namespace Tools
{
    class UtilityDB
    {
        public static void AddParameter(SqlParameterCollection parameters, string parName, object parValue)
        {
            if (parValue == null)
                parameters.AddWithValue(parName, DBNull.Value);
            else
            {
                parameters.AddWithValue(parName, parValue);
            }
        }

        private static ImageConverter im = new ImageConverter();
        private static Image img;
        public static T ReadReader<T>(object readObject)
        {
            if (readObject is T)
                return (T)readObject;

            if (typeof(T) == typeof(Image) && readObject.GetType() == typeof(byte[]))
            {
               // ImageConverter im = new ImageConverter(); //hanieh
                if (readObject != DBNull.Value)
                {
                    byte[] b = (byte[])readObject;
                    img = (Image)im.ConvertFrom(b);
                    return (T)((object)img);
                }
                else
                {
                    return default(T);
                }
            }

            return default(T);

        }

        public static bool AddPictureToParameters(SqlParameterCollection parameters, string parName, Image picture)
        {
            if (picture == null)
            {
                parameters.Add(parName, SqlDbType.Image).Value = DBNull.Value;
            }
            else
            {
                ImageConverter im = new ImageConverter();
                byte[] b = (byte[])im.ConvertTo(picture, typeof(byte[]));
                parameters.AddWithValue(parName, b);
            }
            return true;
        }

        public static bool AddNullableValueToParameters(SqlParameterCollection parameters, string parName, object obj)
        {
            if (obj == null)
            {
                parameters.AddWithValue(parName, DBNull.Value);
                return true;
            }
            else if (obj.GetType() == typeof(int?) || obj.GetType() == typeof(int))
            {
                int? num = (int?)obj;
                if (num.HasValue)
                    parameters.AddWithValue(parName, num.Value);
                else
                    parameters.AddWithValue(parName, DBNull.Value);

            }
            else if (obj.GetType() == typeof(string))
            {
                string str = (string)obj;
                if (str != null)
                    parameters.AddWithValue(parName, str);
                else
                    parameters.AddWithValue(parName, DBNull.Value);
            }
            else
            {
                MessageBox.Show(string.Format("Can not Add Value of type '{0}' to Parameter.", obj.GetType().ToString()));
                throw new Exception("Internal Program Error.");
            }
            return true;
        }

        private void ChangeHeader(DataGridView dgv, ColumnDefinition col, bool Vis)
        {
            dgv.Columns[col].HeaderText = col.Caption;
            dgv.Columns[col].Visible = Vis;
        }

        public static string GetDBString(bool? val)
        {
            if (!val.HasValue) return null;
            return val.Value ? "1" : "0";
        }
    }

    class UtilityTxt
    {
        public static string GetString(string str)
        {
            if (str == null) return "";
            else return str;
        }

        public static string GetString(int num)
        {
            return num.ToString();
        }

        public static string GetString(int? num)
        {
            if (num.HasValue)
                return num.ToString();
            else
                return "";
        }

        public static string GetString(long num)
        {
            return num.ToString();
        }

        public static string GetString(bool? val)
        {
            if (!val.HasValue) return "نامعلوم";
            return val.Value?"بلی": "خیر";
        }

        public static int GetInt(string num)
        {
            return int.Parse(num);
        }

        public static long GetLong(string num)
        {
            return long.Parse(num);
        }

        public static string To3Digit(int number)
        {
            number %= 1000;
            if (number < 10)
                return "00" + number.ToString();
            else if (number < 100)
                return "0" + number.ToString();
            else
                return number.ToString();
        }

        public static string ToFarsiCurrency(string currency)
        {
            string ans = "";

            for (int i = currency.Length - 1; i >= 0; i--)
            {
                int j = currency.Length - i - 1;
                if (j > 1 && j % 3 == 0)
                    ans = "," + ans;
                ans = currency[i] + ans;
            }
            return ans;
        }

        /// <summary>
        /// This function resolves the KY problem in Farsi/Arabic.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsEqualString(string s1, string s2)
        {
            return (CorrectKY(s1) == CorrectKY(s2));
        }

        public static string CorrectKY(string inStr)
        {
            string res = inStr;

            string badK = "ك";
            string goodK = "ک";
            res = res.Replace(badK, goodK);

            string badY = "ي";
            string goodY = "ی";
            res = res.Replace(badY, goodY);

            return res;
        }

        /// <summary>
        /// ApplicationPath + '\' at the end of string.
        /// </summary>
        /// <returns></returns>
        public static string ApplicationPath()
        {
            string[] parts = Application.ExecutablePath.Split('\\');
            string path = "";
            for (int i = 0; i < parts.Length - 1; i++)
            {
                path += parts[i] + "\\";
            }
            return path;
        }

        public static string To2Digit(int number)
        {
            //number = int.Parse(number.ToString().Substring(0, Math.Min(2, number.ToString().Length)));
            number %= 100;
            if (number < 10)
                return "0" + number.ToString();
            else
                return number.ToString();
        }


    }

    public class Utility
    {
        //public static bool SelectObjInCombo(ComboBox cbo, string StringToSelect)
        //{
        //    // ToDo: Selecting Objects in Combo May not work properly, Check it again.
        //    string str = StringToSelect;
        //    for (int i = 0; i < cbo.Items.Count; i++)
        //    {
        //        //MajorBO m = (MajorBO)cbo.Items[i];
        //        if (cbo.Items[i].ToString() == str)
        //        {
        //            cbo.SelectedIndex = i;
        //            return true;
        //        }
        //    }
        //    cbo.SelectedItem = null;
        //    return false;
        //}

        //public static bool ConvertToInt(TextBox t, out int res)
        //{
        //    if (!int.TryParse(t.Text, out res))
        //    {
        //        //if (t.Tag == null)
        //        //{
        //        //    MessageBox.Show(t.ToString() + "\n" + t.Name + " \nHas not Tag value.");
        //        //    return false;
        //        //}
        //        return false;
        //    }
        //    return true;
        //}

        //public static bool ConvertToInt(string str, out int res)
        //{
        //    if (!int.TryParse(str, out res))
        //    {
        //        //if (t.Tag == null)
        //        //{
        //        //    MessageBox.Show(t.ToString() + "\n" + t.Name + " \nHas not Tag value.");
        //        //    return false;
        //        //}
        //        return false;
        //    }
        //    return true;
        //}

        /// <summary>
        /// ApplicationPath + '\' at the end of string.
        /// </summary>
        /// <returns></returns>
        public static string ApplicationPath()
        {
            string[] parts = Application.ExecutablePath.Split('\\');
            string path = "";
            for (int i = 0; i < parts.Length - 1; i++)
            {
                path += parts[i] + "\\";
            }
            return path;
        }

        /// <summary>
        /// Tries to make an object of type T with Constructor(int).
        /// If key is null returns null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetObject<T>(int? key)
        {
            if (key.HasValue)
            {
                Type t = typeof(T);
                ConstructorInfo[] constractors = t.GetConstructors();
                ConstructorInfo construct = constractors.First(c => { return  c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType == typeof(int); });
                if (construct == null) return default(T);
                object[] objs = new object[] { key.Value };
                return (T)construct.Invoke(objs);
            }
            else return default(T);
        }

        /// <summary>
        /// Tries to make an object of type T with Constructor(int).
        /// If key is null returns null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetObject<T>(int key)
        {
            Type t = typeof(T);
            ConstructorInfo[] constractors = t.GetConstructors();
            ConstructorInfo construct = constractors.First(c => { return c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType == typeof(int); });
            if (construct == null) return default(T);
            object[] objs = new object[] { key };
            return (T)construct.Invoke(objs);
        }

        /// <summary>
        /// Tries to make an object of type T with Constructor(bool).
        /// If key is null returns null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetObject<T>(bool key)
        {
            Type t = typeof(T);
            ConstructorInfo[] constractors = t.GetConstructors();
            ConstructorInfo construct = constractors.FirstOrDefault(c => { return c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType == typeof(bool); });
            if (construct == null) return default(T);
            object[] objs = new object[] { key };
            return (T)construct.Invoke(objs);
        }

    }

    class FaDate
    {
        private static DateTime loginTime = DateTime.Now;
        private static DateTime serverTimeAtLogin = DateTime.Now;

        public static PersianDate Now
        {
            get
            {
                TimeSpan ts = (serverTimeAtLogin - loginTime);
                DateTime realNow = DateTime.Now;
                realNow = realNow.Add(ts);
                return PersianDateConverter.ToPersianDate(realNow);


            }
        }

        public static bool SynchWithServer()
        {
            string commandString = " SELECT getdate() as NowDate ";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = DataAccessNamespace.DataAccess.connectionString;
                connection.Open();

                // ToDo: String Command is ready (Not tested yet);

                SqlCommand command = connection.CreateCommand();
                command.CommandText = commandString;

                SqlDataReader reader = (JobLogger.RunCommandReader(command));

                //List<ConstantFeeBO> ans = new List<ConstantFeeBO>();
                DateTime ans = DateTime.Now;
                if (reader.Read())
                {
                    ans = (DateTime)(reader["NowDate"]);

                }
                loginTime = DateTime.Now;
                serverTimeAtLogin = ans;

                return true;
            }
        }
        public FaDate()
        {
        }
        
        /// <summary>
        /// 1386/05/04
        /// </summary>
        public static string CurrentFaDateString
        {
            get
            {
                string res = "";
                res = FarsiLibrary.Utils.PersianDate.Now.Year.ToString() + "/" + UtilityTxt.To2Digit(PersianDate.Now.Month) + "/" + UtilityTxt.To2Digit(PersianDate.Now.Day);
                return res;
            }
        }

        /// <summary>
        /// چهارشنبه 3 بهمن 1386
        /// </summary>
        public static string CurrentFaDateToWritten
        {
            get
            {
                return PersianDate.Now.ToWritten();
            }
        }

        public static string CurrentTimeString
        {
            get { return Now.Time.ToString(); }
        }

        /// <summary>
        /// 150835 (15:08:35)
        /// </summary>
        public static string CurrentTimeStringHourMin
        {
            get { return Now.Time.ToString().Substring(0, 5).Replace(":", ""); }
        }
    }

    public class ApplicationConfig
    {
        public string ServerAddress;
        public string ConnectionString;


        public bool Save(string filePath)
        {
            TextWriter writer = new StreamWriter(filePath);
            XmlSerializer xmlser = new XmlSerializer(typeof(ApplicationConfig));

            xmlser.Serialize(writer, this);
            writer.Close();
            return true;
        }

        public bool Load(string filePath)
        {
            TextReader reader = new StreamReader(filePath);
            XmlSerializer xmlser = new XmlSerializer(typeof(ApplicationConfig));

            ApplicationConfig config = (ApplicationConfig)xmlser.Deserialize(reader);

            ServerAddress = config.ServerAddress;
            ConnectionString = config.ConnectionString;

            reader.Close();

            return true;
        }
    }


    
}
