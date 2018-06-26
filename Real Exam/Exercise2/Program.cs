using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            int bestPosition = 0;
            int[] bestDNA = new int[DNALength];
            int maxLength = -1;
            int bestSum = 0;

            int bestSequence = 0;
            int currentSequence = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] DNA = input.Split(new char[] {' ','!'},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                int len = 0;
                int currentBestPosition = 0;
                int currentMaxLength = 0;
                int currentSum = 0;
                currentSequence++;


                for (int i = 0; i < DNALength; i++)
                {
                    if (DNA[i] == 1)
                    {
                        len++;
                        currentSum++;
                        if (len > currentMaxLength)
                        {
                            currentBestPosition = i - len + 1;
                            currentMaxLength = len;
                        }
                    }
                    else
                    {
                        len = 0;                    
                    }
                }

                
                if (currentMaxLength > maxLength)
                {
                    bestDNA = DNA;
                    bestSequence = currentSequence;
                    maxLength = currentMaxLength;
                    bestPosition = currentBestPosition;
                    bestSum = currentSum;
                }
                else if (currentMaxLength == maxLength)
                {
                    if (currentBestPosition < bestPosition)
                    {
                        bestDNA = DNA;
                        bestSequence = currentSequence;
                        maxLength = currentMaxLength;
                        bestPosition = currentBestPosition;
                        bestSum = currentSum;
                    }
                    else if (currentBestPosition == bestPosition)
                    {
                        if (currentSum > bestSum)
                        {
                            bestDNA = DNA;
                            bestSequence = currentSequence;
                            maxLength = currentMaxLength;
                            bestPosition = currentBestPosition;
                            bestSum = currentSum;
                        }
                    }
                }               

            }

            Console.WriteLine($"Best DNA sample {bestSequence} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDNA));

        }
    }
}
