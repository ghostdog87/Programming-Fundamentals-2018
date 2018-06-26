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
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            int shorterString = input.Min(x => x.Length);
            int longerString = input.Max(x => x.Length);

            Dictionary<char, char> characters = new Dictionary<char, char>();

            bool flag = true;

            if (shorterString == longerString)
            {
                for (int i = 0; i < shorterString; i++)
                {
                    if (!characters.ContainsKey(firstString[i]) && !characters.ContainsValue(secondString[i]))
                    {
                        characters.Add(firstString[i], secondString[i]);
                    }
                    else if (!characters.ContainsKey(firstString[i]) && characters.ContainsValue(secondString[i]))
                    {

                        flag = false;
                    }
                }
            }

            if (shorterString != longerString)
            {
                
                if (shorterString == firstString.Length)
                {
                    for (int i = 0; i < shorterString; i++)
                    {
                        if (!characters.ContainsKey(firstString[i]) && !characters.ContainsValue(secondString[i]))
                        {
                            characters.Add(firstString[i], secondString[i]);
                        }
                        else if (!characters.ContainsKey(firstString[i]) && characters.ContainsValue(secondString[i]))
                        {
                            flag = false;
                        }
                    }

                    for (int i = shorterString; i < longerString; i++)
                    {
                        if (!characters.ContainsValue(secondString[i]))
                        {
                            flag = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < shorterString; i++)
                    {
                        if (!characters.ContainsKey(secondString[i]) && !characters.ContainsValue(firstString[i]))
                        {
                            characters.Add(secondString[i], firstString[i]);
                        }
                        else if (!characters.ContainsKey(secondString[i]) && characters.ContainsValue(firstString[i]))
                        {
                            flag = false;
                        }
                    }

                    for (int i = shorterString; i < longerString; i++)
                    {
                        if (!characters.ContainsValue(firstString[i]))
                        {
                            flag = false;
                        }
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            

            
        }
    }
}
