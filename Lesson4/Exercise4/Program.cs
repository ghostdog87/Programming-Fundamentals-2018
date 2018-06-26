using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studio = 0;
            double doub = 0;
            double suite = 0;

            if (m == "May")
            {
                if (days > 7)
                {
                    studio = (50 - (50 * 5 / 100.0)) * days;
                }
                else
                {
                    studio = 50 * days;
                }
                doub = 65 * days;
                suite = 75 * days;
            }
            if (m == "October")
            {
                if (days > 7)
                {
                    studio = (50 - (50 * 5 / 100.0)) * (days - 1);
                }
                else
                {
                    studio = 50 * days;
                }
                doub = 65 * days;
                suite = 75 * days;
            }
            if (m == "June")
            {
                studio = 60 * days;

                if (days > 14)
                {
                    doub = (72 - (72 * 10 / 100.0)) * days;
                }
                else
                {
                    doub = 72 * days;
                }
                
                suite = 82 * days;
            }
            if (m == "September")
            {
                if (days > 7)
                {
                    studio = 60 * (days - 1);
                }
                else
                {
                    studio = 60 * days;
                }

                if (days > 14)
                {
                    doub = (72 - (72 * 10 / 100.0)) * days;
                }
                else
                {
                    doub = 72 * days;
                }

                suite = 82 * days;
            }
            if (m == "July" || m == "August" || m == "December")
            {
                studio = 68 * days;
                doub = 77 * days;

                if (days > 14)
                {
                    suite = (89 - (89 * 15 / 100.0)) * days;
                }
                else
                {
                    suite = 89 * days;
                }

            }

            Console.WriteLine("Studio: {0:f2} lv.",studio);
            Console.WriteLine("Double: {0:f2} lv.", doub);
            Console.WriteLine("Suite: {0:f2} lv.", suite);
        }
    }
}
