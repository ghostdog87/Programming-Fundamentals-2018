using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        static bool IsPalindrome(int num)
        {
            string tempNum2 = num.ToString();
            int counter = tempNum2.Length;
            for (int i = 0; i < counter; i++)
            {
                if (tempNum2[i] != tempNum2[counter-1])
                {
                    return false;
                }
                counter--;
            }
            return true;

        }
        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsEvenDigit(int num)
        {
            while (num != 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
