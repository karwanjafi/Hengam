using System;
using System.Collections.Generic;
using System.Text;

namespace Hengam.Tools
{
    public class MessageCreator
    {

        /// <summary>
        /// "شما در حال حذف " + str + " هستید، آیا مطمئنید؟"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SureToRemove(string str)
        {
            string res = "";
            res += "شما در حال حذف " + str + " هستید، آیا مطمئنید؟";
            return res;
        }

        /// <summary>
        /// str + " از سیستم حذف شد.";
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Removed(string str)
        {
            string res = "";
            res += str + " از سیستم حذف شد.";
            return res;
        }

        /// <summary>
        /// str + " به سیستم اضافه شد.";
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Added(string str)
        {
            string res = "";
            res += str + " به سیستم اضافه شد.";
            return res;
        }

        public static string ErrorInAdding()
        {
            return "مشکلی در هنگام اضافه کردن پیش آمد.";
        }

        public static string ErrorInRemoving()
        {
            return "مشکلی در هنگام حذف پیش آمد.";
        }

        public static string ErrorInUpdating()
        {
            return "مشکلی در هنگام اعمال تغییرات پیش آمد.";
        }

        /// <summary>
        /// "تغییرات مربوط به " + str + " در سیستم اعمال شد.";
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Updated(string str)
        {
            string res = "";
            res += "تغییرات مربوط به " + str + " در سیستم اعمال شد.";
            return res;
        }
        /// <summary>
        /// res += str + " در سیستم وجود دارد";
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string IsDuplicate(string str)
        {
            string res = "";
            res += str + " در سیستم وجود دارد";
            return res;
        }
    }
}
