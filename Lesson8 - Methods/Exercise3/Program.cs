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
            string a = Console.ReadLine();

            Console.WriteLine(LastDigit(a)); 
        }
        static string LastDigit(string a)
        {
            string lastDigit = "";
            string b = a;


            switch (Convert.ToInt32( b[b.Length-1]))
            {
                case '0':
                    lastDigit = "zero";
                    break;
                case '1':
                    lastDigit = "one";
                    break;
                case '2':
                    lastDigit = "two";
                    break;
                case '3':
                    lastDigit = "three";
                    break;
                case '4':
                    lastDigit = "four";
                    break;
                case '5':
                    lastDigit = "five";
                    break;
                case '6':
                    lastDigit = "six";
                    break;
                case '7':
                    lastDigit = "seven";
                    break;
                case '8':
                    lastDigit = "eight";
                    break;
                case '9':
                    lastDigit = "nine";
                    break;
                default:
                    break;
            }
            return lastDigit;
        }
    }
}
