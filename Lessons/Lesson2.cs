using System;

namespace Lessons
{
    class Lesson2
    {
        static void Main()
        {
            #region Задание 1
            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите число которое необходимо возвести в степень");
            int x, y;
            while (!Int32.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Не корректно введены данные. Введите число снова");

            Console.WriteLine("Введите степень");

            while (!Int32.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Не корректно введены данные. Введите число снова");
            Console.WriteLine($"{x} в степени {y} равно {Exercise_1(x, y)}");
            #endregion

            #region Задание 2

            #endregion
        }

        /// <summary>
        /// Создать метод вычисления степени числа, используя рекурсию
        /// </summary>
        /// <param name="x">Число которое нужно возвести в степень</param>
        /// <param name="y">Степень</param>
        /// <returns>результат возведения числа X в степень Y</returns>
        static int Exercise_1(int x, int y)
        {
            return y == 0 ? 1 : x * Exercise_1(x, y - 1);
        }


        static void Exercise_2()
        {

        }
    }
}
