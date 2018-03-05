using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntities = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> listOfProductsWithPrices = new Dictionary<string, decimal>();
            Dictionary<string, Dictionary<string, int>> shopingList = new Dictionary<string, Dictionary<string, int>>();
            List<string> products = new List<string>();
            string nameOfProduct = String.Empty;
            decimal priceOfProduct = 0.0M;

            for (int i = 0; i < numberOfEntities; i++)
            {
                string[] listOfEntities = Console.ReadLine().Split('-').ToArray();
                products.Add(listOfEntities[0]);
                nameOfProduct = listOfEntities[0];
                priceOfProduct = decimal.Parse(listOfEntities[1]);

                if (!listOfProductsWithPrices.ContainsKey(nameOfProduct))
                {
                    listOfProductsWithPrices.Add(nameOfProduct, priceOfProduct);
                }
                else
                {
                    listOfProductsWithPrices[nameOfProduct] = priceOfProduct;
                }
            }

            string input = Console.ReadLine();
            string nameOfCustomer = String.Empty;
            string nameOfProductToBuy = String.Empty;
            int amountOfProduct = 0;

            while (true)
            {
                if (input == "end of clients")
                {
                    break;
                }

                string[] inputOfClients = input.Split(new char[] { '-', ',' }).ToArray();
                nameOfCustomer = inputOfClients[0];
                nameOfProductToBuy = inputOfClients[1];
                amountOfProduct = int.Parse(inputOfClients[2]);

                if (!shopingList.ContainsKey(nameOfCustomer))
                {
                    if (products.Distinct().Contains(nameOfProductToBuy))
                    {
                        shopingList.Add(nameOfCustomer, new Dictionary<string, int>());
                        shopingList[nameOfCustomer].Add(nameOfProductToBuy, amountOfProduct);
                    }
                }
                else if (shopingList.ContainsKey(nameOfCustomer))
                {
                    if (products.Distinct().Contains(nameOfProductToBuy))
                    {
                        if (shopingList[nameOfCustomer].ContainsKey(nameOfProductToBuy))
                        {
                            shopingList[nameOfCustomer][nameOfProductToBuy] += amountOfProduct;
                        }
                        else if (!shopingList[nameOfCustomer].ContainsKey(nameOfProductToBuy))
                        {
                            shopingList[nameOfCustomer].Add(nameOfProductToBuy, amountOfProduct);
                        }
                    }
                }
                input = Console.ReadLine();

            }
            decimal totalBill = 0.0M;

            foreach (var customer in shopingList.OrderBy(x => x.Key))
            {
                decimal billForEachPerson = 0.0M;
                Console.WriteLine($"{customer.Key}");

                foreach (KeyValuePair<string, int> items in customer.Value)
                {
                    Console.WriteLine($"-- {items.Key} - {items.Value}");

                    foreach (var product in listOfProductsWithPrices.Distinct())
                    {
                        if (items.Key == product.Key)
                        {
                            billForEachPerson += items.Value * product.Value;
                        }
                    }
                }

                totalBill += billForEachPerson;
                Console.WriteLine($"Bill: {billForEachPerson:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}