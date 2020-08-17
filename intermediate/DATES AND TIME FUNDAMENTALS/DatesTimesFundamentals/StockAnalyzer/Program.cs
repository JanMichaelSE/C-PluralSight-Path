using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            var timeSpan = new TimeSpan(60, 100, 200);

            Console.WriteLine(timeSpan.Hours);

            //var lines = File.ReadAllLines("StockData.csv");

            //foreach (var line in lines.Skip(1))
            //{
            //    var segments = line.Split(',');

            //    var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));

            //    Console.WriteLine(tradeDate.ToLongDateString());
            //}




            //#region Parsing a date and time given a specific format
            //var date = "9/10/2019 10:00:00 PM";

            //var parsedDate = DateTimeOffset.ParseExact(date,
            //    "M/d/yyyy h:mm:ss tt",
            //    CultureInfo.InvariantCulture);

            //Console.WriteLine(parsedDate);
            //#endregion
              
            //#region Formatting a date and time as ISO 8601
            //Console.WriteLine(parsedDate.ToString("o"));
            //#endregion

            //#region Finding time zones for a given offset
            //var now = DateTimeOffset.Now;

            //foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if (timeZone.GetUtcOffset(now) == now.Offset)
            //    {
            //        Console.WriteLine(timeZone);
            //    }
            //}
            //#endregion

            Console.ReadLine();

            
        }
    }
}
