using System;
using System.Collections.Generic;

namespace DurationFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatDuration(62));
            Console.WriteLine(FormatDuration(60));
            Console.WriteLine(FormatDuration(33243586));
            Console.WriteLine(FormatDuration(3661));
            Console.WriteLine(FormatDuration(3660));
            Console.WriteLine(FormatDuration(1));
            Console.WriteLine(FormatDuration(23));
            Console.WriteLine(FormatDuration(9183637));
        }
        public static string FormatDuration(int seconds)
        {
            if (seconds < 60) return seconds == 0 ? "now" : seconds == 1 ? "1 second" : seconds + " seconds";
            else
            {
                string secs = seconds % 60 ==0 ? null : seconds % 60==1 ? "1 second" : (seconds % 60).ToString()+" seconds";
                string mins = (seconds / 60) % 60 == 0 ? null : (seconds / 60) % 60 == 1 ? "1 minute" : ((seconds / 60) % 60).ToString()+ " minutes";
                string hours = ((seconds / 60) / 60) % 24 == 0 ? null : ((seconds / 60) / 60) % 24 == 1 ? "1 hour" : (((seconds / 60) / 60) % 24).ToString()+ " hours";
                string days = (((seconds / 60) / 60) / 24) % 365 == 0 ? null : (((seconds / 60) / 60) / 24) % 365 == 1 ? "1 day" : ((((seconds / 60) / 60) / 24) % 365).ToString()+ " days";
                string years = (((seconds / 60) / 60) / 24) / 365 == 0 ? null : (((seconds / 60) / 60) / 24) / 365 == 1 ? "1 year" : ((((seconds / 60) / 60) / 24) / 365).ToString()+ " years";
                var str = $"{years}, {days}, {hours}, {mins}, {secs}".Trim(' ', ',').Replace(" ,","");
                if (str.LastIndexOf(',') == -1) return str;
                else
                {
                    var inde = str.LastIndexOf(',');
                    return str.Remove(inde) + " and" + str.Substring(inde + 1);
                }
            }
        }
    }
}
