using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int GrSize = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();


            string room;
            double priceRoom = 0;
            double priceTotal = 0;

            if (GrSize <= 50)
            {
                room = "Small Hall";
                priceRoom = 2500;
            }
            else if (GrSize > 50 && GrSize <= 100)
            {
                room = "Terrace";
                priceRoom = 5000;
            }
            else if (GrSize > 100 && GrSize <= 120)
            {
                room = "Great Hall";
                priceRoom = 7500;
            }
            else
            {
                room = "error";
            }

            switch (type)
            {
                case "Normal":
                    priceTotal = (priceRoom + 500) - ((priceRoom + 500) * 5 / 100);
                    break;
                case "Gold":
                    priceTotal = (priceRoom + 750) - ((priceRoom + 750) * 10 / 100);
                    break;
                case "Platinum":
                    priceTotal = (priceRoom + 1000) - ((priceRoom + 1000) * 15 / 100);
                    break;
                default:
                    break;
            }

            if (room == "error")
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$",room,priceTotal/GrSize);
            }

        }
    }
}
