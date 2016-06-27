using System;
using System.Collections.Generic;
using System.Text;
using Tools;

namespace Hengam.Tools.LastChangeManagement
{
    public interface ILastChange
    {
        string LastChangeID { get; set; }
        string LastChangeDate { get; set; }
        string LastChangeTime { get; set; }
    }
    public class LastChangeFiller
    {
        public static string UsernameID;
        public static void SetChangesInfo(ILastChange changingRow)
        {
            changingRow.LastChangeID = UsernameID;
            changingRow.LastChangeDate = FaDate.CurrentFaDateString;
            changingRow.LastChangeTime = FaDate.CurrentTimeStringHourMin;
        }
    }
}
