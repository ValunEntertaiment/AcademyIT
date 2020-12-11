using System;
using System.Collections.Generic;

namespace Lessons.Lesson4.Exercise_1
{
    /// <summary>
    /// Задание 1. Создайте класс товар с базовыми свойствами и на основе класса создайте два объекта.
    /// Вычислите насколько один товар дороже другого​
    /// </summary>
    class Exercise1
    {
        List<Product> Products = new List<Product>();


        public Exercise1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1\n");

            //Console.WriteLine("Сколько товаров хотите добавить?");
            //int count;
            //while (Int32.TryParse(Console.ReadLine(),out count))
            //    Console.WriteLine("Введены не корректные данные. Попробуйте еще раз");
            //Console.Clear();

            SetProduct();
            Console.WriteLine(ComparePrice(Products[0], Products[1]));
        }

        /// <summary>
        /// Создает указанное количество продуктов
        /// </summary>
        /// <param name="Count">Число продуктов которое вы хоите добавить</param>
        public void SetProduct()
        {
            for (int i = 0; i < 2; i++)
            {
                Product product = new Product();

                Console.WriteLine("Введите название продукта");
                    product.Name = Console.ReadLine();
                Console.WriteLine("Введите цену продукта");

                int price;
                while (!Int32.TryParse(Console.ReadLine(), out price))
                    Console.WriteLine("Не корректно введены данные. Введите снова");
                    product.Price = price;

                Console.WriteLine("Введите описание продукта");
                    product.Description = Console.ReadLine();
                Products.Add(product);
                Console.Clear();
            }
        }

        /// <summary>
        /// Сравнинает стоимость двух товаров и выводит соответствующее сообщение
        /// </summary>
        /// <param name="pr1">Первый товар</param>
        /// <param name="pr2">Второй товар</param>
        /// <returns>Сообщение о стоимости товаров</returns>
        public string ComparePrice(Product pr1, Product pr2)
        {
            if (pr1.Price == pr2.Price)
                return $"Оба товара стоят одинаково {pr2.Price}";
            else
                return pr1.Price > pr2.Price ? $"Товар {pr1.Name} дороже на {pr1.Price - pr2.Price}" : $"Товар {pr2.Name} дороже на {pr2.Price - pr1.Price}";
        }
    }
}
