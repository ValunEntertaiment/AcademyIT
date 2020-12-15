using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson5.Exercise1
{
    class Shop
    {
        List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ShowProducts()
        {
            if (Products.Count != 0)
                foreach (var item in Products)
                    Console.WriteLine(item.Info());
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Список продуктов пуст");
                Console.ForegroundColor = ConsoleColor.White;
            }
                
        }
    }
}
