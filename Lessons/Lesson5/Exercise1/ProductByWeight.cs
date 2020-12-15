using System;

namespace Lessons.Lesson5.Exercise1
{
    class ProductByWeight : Product
    {
        int _cost;
        public override int Cost
        {
            get
            {
                if (_cost <= 0)
                {
                    Console.WriteLine("Товара нет в наличии");
                }
                return _cost;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Вес не может быть отрицательным");
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public override void SetProduct()
        {
            Console.Clear();
            Console.Write("Введите название товара: ");
            Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите цену за 1 кг товара: ");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректно введены данные попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Price = price;
            Console.Clear();

            Console.Write("Введите компанию-производитель товара: ");
            Company = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите количество товара в кг: ");
            while (!int.TryParse(Console.ReadLine(), out _cost))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректно введены данные попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();
        }

        public override string Info() => $"Название: {Name}\nЦена за кг: {Price}\nКомпания-производитель: {Company}\nВ наличии: {Cost} кг\n";

        public override void CostProduct(decimal weight) => Console.WriteLine($"Стоимость товара {Name} за {weight} кг стоставит {Price * weight}");
    }
}
