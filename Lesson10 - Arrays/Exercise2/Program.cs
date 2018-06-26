using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < k; i++)
            {
                RotateArray(arr);
                SumArrays(arr, arr2);
            }
            Console.WriteLine(String.Join(" ",arr2));           
        }

        static void RotateArray(int[] arr)
        {
            int tempLast = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];

            }
            arr[0] = tempLast;
        }
        static void SumArrays(int[] arr, int[] arr2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] += arr[i]; 
            }
        }
    }
}
