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
            char[] letters1 = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] letters2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(letters1.Length,letters2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (letters1[i] == letters2[i])
                {
                    if (i == minLength - 1)
                    {
                        if (minLength == letters1.Length)
                        {
                            Console.WriteLine(string.Join("", letters1));
                            Console.WriteLine(string.Join("", letters2));
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", letters2));
                            Console.WriteLine(string.Join("", letters1));
                        }
                    }
                }
                else
                {
                    if (letters1[i] > letters2[i])
                    {
                        Console.WriteLine(string.Join("", letters2));
                        Console.WriteLine(string.Join("", letters1));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", letters1));
                        Console.WriteLine(string.Join("", letters2));
                    }
                    break;
                }
            }


        }
    }
}
