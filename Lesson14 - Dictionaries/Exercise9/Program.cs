using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new SortedDictionary<string, int>();
            var junk = new SortedDictionary<string, int>();

            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            bool flag = true;

            while (flag)
            {
                string line = Console.ReadLine();

                string[] loot = line.ToLower().Split();

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == "shards" || loot[i] == "fragments" || loot[i] == "motes")
                    {

                        materials[loot[i]] = materials[loot[i]] + int.Parse(loot[i - 1]);
                        if (materials[loot[i]] >= 250)
                        {
                            materials[loot[i]] = materials[loot[i]] - 250;
                            if (loot[i] == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (loot[i] == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            flag = false;
                            break;
                        }
                    }
                    else if (i % 2 != 0)
                    {
                        if (!junk.ContainsKey(loot[i]))
                        {
                            junk.Add(loot[i], int.Parse(loot[i - 1]));
                        }
                        else
                        {
                            junk[loot[i]] = junk[loot[i]] + int.Parse(loot[i - 1]);
                        }
                    }
                }

            }

            foreach (var item in materials.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        
    }
}
