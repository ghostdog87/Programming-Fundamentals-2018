using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateText = Console.ReadLine();
            string endDateText = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int counter = 0;
            

            List<DateTime> holidays = new List<DateTime> {
                DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool isHoliday = false;

                if (i.DayOfWeek.Equals(DayOfWeek.Saturday) || i.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    isHoliday = true;
                }


                for (int j = 0; j < holidays.Count; j++)
                {
                    if (i.Day == holidays[j].Day && i.Month == holidays[j].Month)
                    {
                        isHoliday = true;
                    }
                }

                if (!isHoliday)
                {
                    counter++;
                }

                
            }

            Console.WriteLine(counter);
        }
    }
}
