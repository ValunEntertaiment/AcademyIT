using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lessons.Lesson7.Task1
{
    class CoffeeMachine
    {
        Dictionary<int, Beverage> Beverages = new Dictionary<int, Beverage>()
        {
            { 0, new Beverage() { Name = "Эспрессо", Price = 50 } },
            { 1, new Beverage() { Name = "Американо", Price = 80 } },
            { 2, new Beverage() { Name = "Капучино", Price = 70 } },
            { 3, new Beverage() { Name = "Латте", Price = 55 } },
            { 4, new Beverage() { Name = "Мокачино", Price = 85 } }
        };

        public CoffeeMachine()
        {
            Console.WriteLine("Установить стандартный набор напитков? Да(1) Нет(2)");

            string action = Console.ReadLine();
            while (!new Regex(@"[1-2]{1}").IsMatch(action)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не корректно введены данные");
                Console.ForegroundColor = ConsoleColor.White;
                action = Console.ReadLine();
            }

            if(action == "2")
            {
                SetBevareges();
            }

            do
            {
                Console.WriteLine($"Вывести список напитков(0) или выбрать напиток(1-{Beverages.Count})");

                action = action = Console.ReadLine();
                while (!new Regex(@"\d").IsMatch(action))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не корректно введены данные");
                    Console.ForegroundColor = ConsoleColor.White;
                    action = Console.ReadLine();
                }

                if (Beverages.Count >= int.Parse(action) && int.Parse(action) > 0)
                    Console.WriteLine(Beverages[int.Parse(action) - 1].Info());
                else if (int.Parse(action) == 0)
                    ShowBeverage();
                else
                    Console.WriteLine("Такого напитка нет");
            } while (true);
        }

        void SetBevareges()
        {
            Beverages = new Dictionary<int, Beverage>();
            Console.WriteLine("Сколько напитков добавить?");
            string action = Console.ReadLine();
            while (!new Regex(@"\d").IsMatch(action))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не корректно введены данные");
                Console.ForegroundColor = ConsoleColor.White;
                action = Console.ReadLine();
            }

            Beverage beverage;
            for (int i = 0; i < Convert.ToInt32(action); i++)
            {
                beverage = new Beverage();
                Console.Clear();
                
                Console.Write("Название напитка: ");
                beverage.Name = Console.ReadLine();

                Console.Clear();
                Console.Write("Цена напитка: ");
                int price;
                while (!int.TryParse(Console.ReadLine(),out price))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не корректно введены данные");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                beverage.Price = price;

                Beverages.Add(i, beverage);
            }
        }

        public void ShowBeverage()
        {
            foreach (var item in Beverages)
            {
                Console.WriteLine($"Номер напитка: {item.Key + 1}\n"+ item.Value.Info());
            }
        }
    }
}
