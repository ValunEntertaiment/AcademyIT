using System;

namespace Lessons.Lesson5.Exercise1
{
    class DigitalProduct : Product
    {
        public override void SetProduct()
        {
            Console.Clear();
            Console.WriteLine("class DigitalProduct");
            Console.Write("Введите название товара: ");
            Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите цену товара: ");
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
        }

        public override string Info() => $"Название: {Name}\nЦена: {Price}\nКомпания-производитель: {Company}\n";
        
        public override void CostProduct(decimal weight) => Console.WriteLine($"Стоимость товара {Name} за {weight} устройство стоставит {Price * weight}");
    }
}
