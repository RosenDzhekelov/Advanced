using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, List<Product>>();

            string input = Console.ReadLine();
            while(input?.ToUpper()!="REVISION")
            {
                string[] splitted = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if(!shops.ContainsKey(splitted[0]))
                {
                    shops.Add(splitted[0], new List<Product>());
                }
                Product product = new Product();
                product.Name = splitted[1];
                product.Price = double.Parse(splitted[2]);
                shops[splitted[0]].Add(product);

                input = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Name}, Price: {item.Price}");
                }
            }
               
        }
    }
    class Product
        {
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
