using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string word = Console.ReadLine();
                
                if (word == "Bake!")
                {
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.",word);
                count++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.",count);
        }
    }
}
