using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonsSoftUni
{

    class Dragons
    {
        public string DragonType { get; set; }
        public string Name { get; set; }
        public decimal Damage { get; set; }
        public decimal Health { get; set; }
        public decimal Armor { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            var dragonsList = new List<Dragons>();


            for (int i = 0; i < n; i++)
            {

                var dragonAttr = Console.ReadLine().Split(' ');
                var type = dragonAttr[0];
                var drag = new Dragons();
                string name = dragonAttr[1];
                decimal damage = 45;
                decimal hp = 250;
                decimal armor = 10;
                if (dragonAttr[2] != "null")
                {
                    damage = decimal.Parse(dragonAttr[2]);
                }
                if (dragonAttr[3] != "null")
                {
                    hp = decimal.Parse(dragonAttr[3]);
                }
                if (dragonAttr[4] != "null")
                {
                    armor = decimal.Parse(dragonAttr[4]);
                }

                var currentDragon = ReadDragons(type, name, damage, hp, armor);

                if (dragonsList.Any(d => d.DragonType == currentDragon.DragonType && d.Name == currentDragon.Name))
                {
                    dragonsList.Remove(dragonsList.FirstOrDefault(d => d.DragonType == currentDragon.DragonType && d.Name == currentDragon.Name));
                }

                dragonsList.Add(currentDragon);

            }

            var grouped = dragonsList.GroupBy(d => d.DragonType);

            foreach (var item in grouped)
            {

                Console.WriteLine($"{item.Key}::({item.Average(x => x.Damage):F2}/{item.Average(x => x.Health):F2}/{item.Average(x => x.Armor):F2})");
                foreach (var drake in item.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{drake.Name} -> damage: {drake.Damage}, health: {drake.Health}, armor: {drake.Armor}");
                }
            }
        }

        static Dragons ReadDragons(string dt, string name, decimal damage, decimal hp, decimal armor)
        {

            return new Dragons
            {
                DragonType = dt,
                Name = name,
                Damage = damage,
                Health = hp,
                Armor = armor
            };
        }

    }
}