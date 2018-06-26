﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    public class BePositive_broken
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    

                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        found = true;
                        Console.Write(currentNum);

                        if (found)
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    else
                    {
                        if ((j + 1) < numbers.Count)
                        {
                            currentNum += numbers[j + 1];
                            
                            if (currentNum >= 0)
                            {
                                found = true;
                                Console.Write(currentNum);

                                if (found)
                                {
                                    Console.Write(" ");
                                }

                            }
                            j++;
                        }
                        
                    }
                }
                if (found)
                {
                    Console.WriteLine();
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
