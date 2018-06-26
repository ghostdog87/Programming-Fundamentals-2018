using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentNumber = numbers[i].ToString();
                string newNum = "";

                for (int a = currentNumber.Length-1; a >=0; a--)
                {
                    newNum += currentNumber[a];
                }

                numbers[i] = int.Parse(newNum);
            }

            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }

            Console.WriteLine(result);
        }

    }
}
