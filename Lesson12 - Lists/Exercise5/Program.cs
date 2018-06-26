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
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(new char[] { ' ' }).ToList();

                if (command[0] == "add")
                {
                    numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    for (int i = command.Count-1; i >=2 ; i--)
                    {
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "contains")
                {
                    int result = numbers.IndexOf(int.Parse(command[1]));
                    Console.WriteLine(result);
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }                  
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count-1; i++)
                    {
                        numbers[i] = numbers[i] + numbers[i+1];
                        numbers.RemoveAt(i + 1);
                        
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("[" + string.Join(", ",numbers) + "]");
        }
    }
}
