﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fakt = 1;
            for (int i = 1; i <= n; i++)
            {
                fakt *= i;
            }
            Console.WriteLine(fakt);
        }

    }
}
