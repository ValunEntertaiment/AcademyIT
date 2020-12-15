using System;

namespace Lessons.Lesson5.Exercise1
{
    /// <summary>
    /// Создать структуру классов ведения товарной номенклатуры.​
    ///Есть абстрактный товар.​
    ///
    ///Есть цифровой товар, штучный физический товар и товар на вес.​
    ///
    ///У каждого есть метод подсчёта финальной стоимости.​
    ///У цифрового товара стоимость постоянная и дешевле штучного товара в два раза,
    ///у штучного товара обычная стоимость, у весового – в зависимости от продаваемого количества
    ///в килограммах.У всех формируется в конечном итоге доход с продаж.​
    ///
    ///Что можно вынести в абстрактный класс, наследование?​
    /// </summary>
    class Exercise1
    {
        public Exercise1()
        {
            Console.WriteLine("Задание 1\n");

            Shop shop = new Shop();
            int action;
            do
            {
                Console.WriteLine("Что делать?\nДобавить продукт(1)\nПоказать список продуктов(2)\n");
                while (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректно введены данные попробуйте снова.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Какой тип товара добавить?\nЦифровой(1)\nШтучный(2)\nНа развес(3)\n");
                        switch(Console.ReadLine())
                        {
                            case "1":
                                shop.AddProduct(new DigitalProduct());
                                break;
                            case "2":
                                shop.AddProduct(new Product());
                                break;
                            case "3":
                                shop.AddProduct(new ProductByWeight());
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Некорректно введены данные.");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        break;
                    case 2:
                        shop.ShowProducts();
                        break;
                }
            } while (true);
        }
    }
}
