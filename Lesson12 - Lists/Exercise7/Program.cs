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
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> specials = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int power = specials[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specials[0])
                {
                    int bomb = i;
                    //left side
                    for (int b = bomb; b >= bomb - power && b >= 0; b--)
                    {
                        numbers[b] = 0;
                    }

                    //right side
                    for (int b = bomb; b <= bomb + power && b < numbers.Count; b++)
                    {
                        numbers[b] = 0;
                    }
                }
                
            }

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

        }
    }
}
