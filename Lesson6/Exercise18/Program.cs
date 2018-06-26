using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            try
            {
                long temp1 = Convert.ToInt64(n);
                Console.WriteLine("{0} can fit in:",n);
                if (temp1 >= -128 && temp1 <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (temp1 >= 0 && temp1 <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (temp1 >= -32768 && temp1 <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (temp1 >= 0 && temp1 <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (temp1 >= -2147483648 && temp1 <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (temp1 >= 0 && temp1 <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (temp1 >= -9223372036854775808 && temp1 <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type",n); 
                
            }
        }
    }
}
