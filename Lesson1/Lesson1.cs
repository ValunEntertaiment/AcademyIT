using System;

namespace Lesson1
{
    class Lesson1
    {
        //static void Main()
        //{
        //    #region Задание 1
            
        //    Console.WriteLine("Задание 1");
        //    Console.WriteLine("Введите стоимость разговора без учета скидки.");

        //    //проверка на корректность ввода
        //    if (decimal.TryParse(Console.ReadLine(), out decimal Prise))
        //    {
        //        Exercise_1(Prise);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введены не корректные данные.");
        //    }
        //    #endregion

        //    #region Задание 2

        //    Console.WriteLine("\n\n\n" + "Задание 2");
        //    Console.WriteLine("Введите дату начала второй мировой войны (дд.мм.гг).");
            
        //    //Проверка на кооректность ввода
        //    if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime))
        //    {
        //        Exercise_2(dateTime);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введены не корректные данные.");
        //    }
        //    #endregion

        //    #region Задание 3

        //    Console.WriteLine("\n\n\n" + "Задание 3");
        //    Console.WriteLine("Введите произвольные числа А, B, C. Где А не равна нулю.");

        //    //Проверка на кооректность ввода
        //    if (double.TryParse(Console.ReadLine(), out double a) && double.TryParse(Console.ReadLine(), out double b) && double.TryParse(Console.ReadLine(), out double c) && a != 0)
        //    {
        //        Console.WriteLine("" + Exercise_3(a, b, c));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Не корректно введены данные");
        //    }
        //    #endregion

        //    #region Задание 4

        //    Console.WriteLine("\n\n\n" + "Задание 4");
        //    Console.WriteLine("Введите произвольное число Х");

        //    //проверка на корректность ввода
        //    if (double.TryParse(Console.ReadLine(), out double X))
        //    {
        //        Console.WriteLine($"При х={X} функция S'(x)={Exercise_4(X)}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введены не корректные данные.");
        //    }
        //    //Exercise_1(1000);
        //    #endregion

        //    #region Задание 5

        //    Console.WriteLine("\n\n\n" + "Задание 5");
        //    double Result = Math.Round(Exercise_5(), 3);

        //    //Проверка на корректность ввода
        //    if (double.TryParse(Console.ReadLine(), out double Answer))
        //    {
        //        if (Result == Answer)
        //        {
        //            Console.WriteLine("Молодец возьми с полки пирожок!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Не верно, правильный ответ равен {Math.Round(Result, 3)}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Ответ Введен не корректно. Правильный ответ равен {Math.Round(Result,3)}");
        //    }
        //    #endregion
        //}

        /// <summary>
        /// Задание №1. Написать программу определения стоимости раговора по телефону 
        /// с учетом скидки 20%, предоставляемой по субботам и воскресеньям
        /// </summary>
        /// <param name="Price">Стоимость разговора без учета скидки</param>
        /// <returns>Стоимость разговора с учетом скидки 20% по субботам и воскресеньям</returns>
        static decimal Exercise_1(decimal Price)
        {
            var Date = new DayOfWeek();
            if (Convert.ToInt32(Date) == 0 || Convert.ToInt32(Date) == 6)
            {
                Price *= 0.8m;
            }
            Console.WriteLine($"Сегодня {Date} цена разговора будет составлять {Price}\n");
            return Price;
        }

        /// <summary>
        /// Задание №2. Написать программу проверки зананий начала Второй мировой войны. 
        /// При неверном ответе, программа должна выдавать правильный вариант.
        /// </summary>
        static DateTime Exercise_2(DateTime Date)
        {
            if(Date.Day == 1 && Date.Month == 9 && Date.Year == 1939)
            {
                Console.WriteLine("Молодец! Возьми с полки пирожок.");
            }
            else
            {
                Console.WriteLine("Не правильно! Вторая мировая война началась 01.09.1939г. Прокачивай свои знания и будь крутым!");
            }
            return Date;
        }

        /// <summary>
        /// Задание №3. Написать программу, решающую квадратное уравнение. 
        /// В качестве входных параметров используйте значение A, B, C с использванием методов
        /// </summary>
        /// <param name="A">Произвольное число, которое не равно 0</param>
        /// <param name="B">Произвольное число</param>
        /// <param name="C">Произвольное число</param>
        /// <returns>В случае когда корней нет выводит NULL. В иных случаях выводит массив с корнями</returns>
        static double[] Exercise_3(double A,double B, double C)
        {

            double D = Math.Sqrt(Math.Pow(B,2) - 4 * A * C);
            if (D < 0)
            {
                return null;
            }else if (D == 0)
            {
                double[] result = { -B / 2 * A};
                return result;
            }
            else
            {
                double[] result = { -B + D / 2 * A, -B - D / 2 * A };
                return result;
            }
        }

        /// <summary>
        ///  Задание №4. Подсчитать значение функции: 
        ///  
        /// </summary>
        /// <param name="x">Произвольное число</param>
        /// <returns>Возвращает ответ функции описанной выше</returns>
        static double Exercise_4(double x)
        {
            return (600 - x) / Math.Sqrt(1440000 + Math.Pow(600 + x, 2)) - (1500 - x) / Math.Sqrt(810000 + Math.Pow(1500 - x, 2));
        }

        /// <summary>
        /// Задание №5. Написать программу, предлагающую пользователю вычислить частное от деления двух рандомных чисел.
        /// При некорректном введенном значении - вывести сообщение об ошибке и вывести правильный ответ.
        /// </summary>
        /// <returns>Возвращает правильный ответ</returns>
        static double Exercise_5()
        {
            Random random = new Random();
            double a = random.Next(1000), b = random.Next(1000);
            Console.WriteLine($"Посчитай сколько будет {a} поделить на {b}. Ответ запиши с округлением до 3-х знаков после запятой");
            return 2 /3;
        }
    }
}