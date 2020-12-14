using System;
using System.Collections.Generic;

namespace Lessons.Lesson4.Exercise_3
{
    class Shop
    {
        List<Product> Products = new List<Product>();

        public void AddProduct()
        {
            Product product = new Product();

            Console.Write("Введите название товара: ");
            product.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Выберите валюту RUB(1), USD(2)");
            string str = Console.ReadLine();
            if (str == "1")
            {
                Console.Write("Введите цену товара: ");
                decimal price;
                while (!decimal.TryParse(Console.ReadLine(), out price))
                    Console.WriteLine("Некорректно введены дынные попробуйте снова.");

                product.Price = new RUB(price);
            }else if(str == "2")
            {
                Console.Write("Введите цену товара: ");
                decimal price;
                while (!decimal.TryParse(Console.ReadLine(), out price))
                    Console.WriteLine("Некорректно введены дынные попробуйте снова.");

                product.Price = new USD(price);
            }
            else
            {
                Console.WriteLine("Валюта не была выбрана");

                Console.Write("Введите цену товара: ");
                decimal price;
                while (!decimal.TryParse(Console.ReadLine(), out price))
                    Console.WriteLine("Некорректно введены дынные попробуйте снова.");
            }
            Console.Clear();

            Console.WriteLine("Введите компанию-производитель товара: ");
            product.Company = Console.ReadLine();
            Console.Clear();

            Products.Add(product);
        }

        public void ShowProducts()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Название: {item.Name}\nЦена: {item.Price.GetPrice()}\nКомпания-производитель: {item.Company}\n");
            }
        }
    }
}
