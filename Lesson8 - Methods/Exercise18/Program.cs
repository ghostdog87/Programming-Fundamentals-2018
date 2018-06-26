using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    public class SequenceOfCommands_broken
    {

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            decimal[] array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string line = Console.ReadLine().Trim();
                string[] stringParams = line.Split(' ');


                if (line == "stop")
                {
                    break;
                }
                int[] args = new int[2];

                if (stringParams[0].Equals("add") || stringParams[0].Equals("subtract") || stringParams[0].Equals("multiply"))
                {
                    
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, stringParams[0], args);
                }
                if (stringParams[0].Equals("lshift") || stringParams[0].Equals("rshift"))
                {
                    args[0] = 0;
                    args[1] = 0;
                    PerformAction(array, stringParams[0], args);
                }
                
                Console.WriteLine();

                
            }
        }

        static void PerformAction(decimal[] arr, string action, int[] args)
        {
            decimal[] array = arr;
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    PrintArray(array);
                    break;
                case "add":
                    array[pos - 1] += value;
                    PrintArray(array);
                    break;
                case "subtract":
                    array[pos - 1] -= value;
                    PrintArray(array);
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            
        }

        private static void ArrayShiftRight(decimal[] array)
        {
            decimal tempLast = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
                
            }
            array[0] = tempLast;
            PrintArray(array);
        }

        private static void ArrayShiftLeft(decimal[] array)
        {
            decimal tempFirst = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = tempFirst;
            PrintArray(array);
        }

        private static void PrintArray(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
