using System;

namespace Lessons.Lesson4.Exercise_3
{
    /// <summary>
    /// Придумать класс, который описывает любую сущность из предметной области интернет-магазинов: продукт, ценник, посылка и т.п.​
    ///1)Описать свойства классов​
    ///2)Описать поведение классов(методы).​
    ///3)Придумать наследников класса(классов)
    /// </summary>
    class Exercise3
    {
        public Exercise3()
        {
            Console.WriteLine("Задание 3\n");

            Shop shop = new Shop();
            int action;
            do
            {
                Console.WriteLine("Что делать?");
                while (!int.TryParse(Console.ReadLine(),out action))
                    Console.WriteLine("Некорректно введены данные. Попробуйте еще раз");
                switch (action)
                {
                    case 1:
                        shop.AddProduct();
                        break;
                    case 2:
                        shop.ShowProducts();
                        break;
                }
                
            } while (true);
        }
    }
}
