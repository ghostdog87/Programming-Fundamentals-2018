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
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine().TrimStart('0');

            StringBuilder result = new StringBuilder();

            int biggestNum = firstNum.Length > secondNum.Length ? firstNum.Length : secondNum.Length;
            int smallestNum = firstNum.Length < secondNum.Length ? firstNum.Length : secondNum.Length;


            int remainder = 0;

            if (biggestNum == smallestNum)
            {
                for (int i = smallestNum - 1; i >= 0; i--)
                {
                    int currentSum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + remainder;
                    result.Append(currentSum % 10);

                    remainder = Remainder(currentSum);

                }
            }
            else
            {
                if (biggestNum == firstNum.Length)
                {
                    for (int i = smallestNum - 1; i >= 0; i--)
                    {
                        int currentSum = int.Parse(firstNum[i + (biggestNum - smallestNum)].ToString()) + int.Parse(secondNum[i].ToString()) + remainder;
                        result.Append(currentSum % 10);

                        remainder = Remainder(currentSum);

                    }

                    for (int i = biggestNum - smallestNum - 1; i >=0; i--)
                    {
                        int currentSum = int.Parse(firstNum[i].ToString()) + remainder;
                        result.Append(currentSum % 10);

                        remainder = Remainder(currentSum);
                    }
                }

                if (biggestNum == secondNum.Length)
                {
                    for (int i = smallestNum - 1; i >= 0; i--)
                    {
                        int currentSum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i + (biggestNum - smallestNum)].ToString()) + remainder;
                        result.Append(currentSum % 10);

                        remainder = Remainder(currentSum);

                    }

                    for (int i = biggestNum - smallestNum - 1; i >= 0; i--)
                    {
                        int currentSum = int.Parse(secondNum[i].ToString()) + remainder;
                        result.Append(currentSum % 10);

                        remainder = Remainder(currentSum);
                    }
                }
            }

            

            if (remainder > 0)
            {
                Console.Write(remainder);
            }

            var end = string.Concat(result.ToString().Reverse());

            Console.WriteLine(end.ToString());
        }

        static int Remainder(int currentSum)
        {
            if (currentSum > 9)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
