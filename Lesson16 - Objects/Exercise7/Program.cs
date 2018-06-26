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
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentProduct = Console.ReadLine().Split('-');
                string product = currentProduct[0];
                decimal price = decimal.Parse(currentProduct[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, price);
                }
                else
                {
                    shop[product] = price;
                }
            }

            List<Customer> customers = new List<Customer>();

            

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of clients")
                {
                    break;
                }

                string[] buyer = line.Split(new char[] { '-', ',' });
                string name = buyer[0];
                string product = buyer[1];
                int quantity = int.Parse(buyer[2]);

                if (shop.ContainsKey(product))
                {
                    Customer currentCustomer = new Customer();
                    currentCustomer.Name = name;
                    currentCustomer.ShopList = new Dictionary<string, int>();
                    currentCustomer.ShopList.Add(product, quantity);
                    currentCustomer.Bill = quantity * shop[product];


                    if (customers.Any(x => x.Name == currentCustomer.Name))
                    {
                        Customer existingCustomer = customers
                            .First(x => x.Name == currentCustomer.Name);

                        if (existingCustomer.ShopList.ContainsKey(product))
                        {
                            existingCustomer.ShopList[product] += quantity;
                            existingCustomer.Bill += quantity * shop[product];
                        }
                        else
                        {
                            existingCustomer.ShopList[product] = quantity;
                            existingCustomer.Bill += quantity * shop[product];
                        }
                    }
                    else
                    {
                        customers.Add(currentCustomer);
                    }
                }

                


            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):f2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; } = new Dictionary<string, int>();
        public decimal Bill { get; set; }



    }
}
