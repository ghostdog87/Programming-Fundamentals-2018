using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = "";
            if (word.EndsWith("y"))
            {
                result = word.Remove(word.Length - 1, 1) + "ies";
            }
            else if(word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                result = word + "es";
            }
            else
            {
                result = word + "s";
            }

                Console.WriteLine(result);
        }
    }
}
