using System;

namespace Lessons.Lesson5.Exercise1
{
    class Product
    {
        public string Name { get; set; }

        decimal _price;

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string Company { get; set; }

        int _cost;
        public virtual int Cost 
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество не может быть отрицательным");
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public Product()
        {
            SetProduct();
        }

        public virtual void SetProduct()
        {
            Console.Clear();
            Console.WriteLine("class Product");
            Console.Write("Введите название товара: ");
            Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите цену товара: ");
            while (!decimal.TryParse(Console.ReadLine(), out _price))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректно введены данные попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();

            Console.Write("Введите компанию-производитель товара: ");
            Company = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите количество товара: ");
            while (!int.TryParse(Console.ReadLine(), out _cost))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректно введены данные попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();
        }

        public virtual string Info() => $"Название: {Name}\nЦена за шт: {Price}\nКомпания-производитель: {Company}\nКоличество: {Cost} шт\n";

        public virtual void CostProduct(decimal weight) => Console.WriteLine($"Стоимость товара {Name} за {weight} шт стоставит {Price * weight}");
    }
}
