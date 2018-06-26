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
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m = m + 30;
            if (m>59)
            {
                h++;
                m = m - 60;
            }
            if (h==24)
            {
                h = 0;
            }

            Console.WriteLine("{0}:{1:D2}",h,m);
        }
    }
}
