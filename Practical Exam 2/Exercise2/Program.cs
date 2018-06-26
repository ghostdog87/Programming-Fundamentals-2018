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
            
            int[] field = new int[int.Parse(Console.ReadLine())];

            int[] bugs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            

            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] >= 0 && bugs[i] < field.Length)
                {
                    field[bugs[i]] = 1; // filling the field with bugs
                }
                
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                int currentIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);

                if (currentIndex < 0 || currentIndex > (field.Length - 1))
                {
                    continue;  // if index of the bug is out of the array, do nothing
                }

                if (field[currentIndex] == 0)
                {
                    continue; // if there is no bug on that index, do nothing
                }

                
                field[currentIndex] = 0;  // remove the bug from current index
                while (true)           // and start checking where it is going to land
                {
                    if (direction == "right")
                    {
                        if (currentIndex + flyLength > field.Length - 1)
                        {
                            break;  // it flies out of the field
                        }
                        else if (field[currentIndex + flyLength] == 1)
                        {
                            flyLength = flyLength * 2; // there is another bug on current index, fly again
                        }
                        else
                        {
                            field[currentIndex + flyLength] = 1;  // bug finally landed
                            break;
                        }
                    }

                    if (direction == "left")
                    {
                        if (currentIndex - flyLength < 0)
                        {
                            break; // it flies out of the field
                        }
                        else if (field[currentIndex - flyLength] == 1)
                        {
                            flyLength = flyLength * 2; // there is another bug on current index, fly again
                        }
                        else
                        {
                            field[currentIndex - flyLength] = 1;  // bug finally landed
                            break;
                        }
                    }
                }

                

            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
