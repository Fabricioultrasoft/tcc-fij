using Agente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace AgenteTcc
{
    public class Horario
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int SetLocalTime(ref SystemTime lpSystemTime);
        //struct for date/time apis 
        public struct SystemTime
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        public static void MudarHorarioWindows(short day, short month, short year, short hour, short minute, short second)
        {
            SystemTime systNew = new SystemTime();
            //set the properties 
            systNew.wDay = day;
            systNew.wMonth = month;
            systNew.wYear = year;
            systNew.wHour = hour;
            systNew.wMinute = minute;
            systNew.wSecond = second;
            //and update using the api 
            SetLocalTime(ref systNew);
        }
        public static void MudarHorarioWindows(int day, int month, int year, int hour, int minute, int second)
        {
            SystemTime systNew = new SystemTime();
            //set the properties 
            systNew.wDay = short.Parse(day.ToString());
            systNew.wMonth = short.Parse(month.ToString());
            systNew.wYear = short.Parse(year.ToString());
            systNew.wHour = short.Parse(hour.ToString());
            systNew.wMinute = short.Parse(minute.ToString());
            systNew.wSecond = short.Parse(second.ToString());
            //and update using the api 
            SetLocalTime(ref systNew);
        }

        public static DateTime GetTimeNowFromInternet()
        {

            Agente.TimeService.TimeServiceSoapClient timeService = new Agente.TimeService.TimeServiceSoapClient("TimeServiceSoap");
            return Convert.ToDateTime(timeService.getUTCTime()).Subtract(new TimeSpan(3, 0, 0));

        }

        public static void UpdateWindowsClockFromInternet()
        {
            DateTime now = GetTimeNowFromInternet();
            MudarHorarioWindows(now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);
        }

        public static TimeSpan GetSystemUptime()
        {
            //timespan object to store the result value
            TimeSpan up = new TimeSpan();

            //management objects to interact with WMI
            ManagementClass m = new ManagementClass("Win32_OperatingSystem");

            //loop throught the WMI instances
            foreach (ManagementObject instance in m.GetInstances())
            {
                //get the LastBootUpTime date parsed (comes in CIM_DATETIME format)
                DateTime last = ParseCIM(instance["LastBootUpTime"].ToString());

                //check it value is not DateTime.MinValue
                if (last != DateTime.MinValue)
                    //get the diff between dates
                    up = DateTime.Now - last;
            }

            //return the uptime TimeSpan
            return up;
        }
        private static DateTime ParseCIM(string date)
        {
            //datetime object to store the return value
            DateTime parsed = DateTime.MinValue;

            //check date integrity
            if (date != null && date.IndexOf('.') != -1)
            {
                //obtain the date with miliseconds
                string newDate = date.Substring(0, date.IndexOf('.') + 4);

                //check the lenght
                if (newDate.Length == 18)
                {
                    //extract each date component
                    int y = Convert.ToInt32(newDate.Substring(0, 4));
                    int m = Convert.ToInt32(newDate.Substring(4, 2));
                    int d = Convert.ToInt32(newDate.Substring(6, 2));
                    int h = Convert.ToInt32(newDate.Substring(8, 2));
                    int mm = Convert.ToInt32(newDate.Substring(10, 2));
                    int s = Convert.ToInt32(newDate.Substring(12, 2));
                    int ms = Convert.ToInt32(newDate.Substring(15, 3));

                    //compose the new datetime object
                    parsed = new DateTime(y, m, d, h, mm, s, ms);
                }
            }

            //return datetime
            return parsed;
        }
    }
}
