using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("\n\n\n" + " Задание 2");
            Console.WriteLine("Введите длину числа от 4 до 9");

            //проверка на корректность ввода длины массива
            while ((!Int32.TryParse(Console.ReadLine(), out x) && x > 3 && x < 10) || x == -1)
                Console.WriteLine("Не корректно введены данные. Введите снова цифру от 4 до 9");

            int[] GenerationsArray = Generation(x);
            int[] Answer = new int[x];
            bool flag;

            while (x != -1)
            {
                //проверка на корректность ввода массива
                do
                {
                    flag = false;
                    Console.WriteLine($"Введите {x} цифр(ы) через пробел.");
                    string[] StringAnswer = Console.ReadLine().Split(' ');
                    if(StringAnswer[1] == "-1")
                        break;
                    if (StringAnswer.Length == x)
                    {
                        int i = 0;
                        foreach (var item in StringAnswer)
                        {
                            if (!Int32.TryParse(item, out Answer[i]))
                            {
                                flag = true;
                                Console.WriteLine("Цифры введены не корректно");
                                break;
                            }
                            else
                            {
                                if (Answer[i] < 1 || Answer[i] > 9)
                                {
                                    flag = true;
                                    Console.WriteLine("Необходимо вводить цифры от 1 до 9");
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine($"Необходимо ввести {x} цифр. \n Введите {x} цифр от 1 до 9");
                    }
                }
                while (flag);

                Console.WriteLine(Exercise_2(Answer, GenerationsArray));
                if (Answer.SequenceEqual(GenerationsArray))
                {
                    Console.WriteLine("Введите длину числа от 4 до 9");
                    while (!Int32.TryParse(Console.ReadLine(), out x) && x > 3 && x < 10)
                        Console.WriteLine("Не корректно введены данные. Введите снова цифру от 4 до 9");
                    GenerationsArray = Generation();
                }
            }
            Console.WriteLine("Спасибо что поиграл со мной! Заходи еще");
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

        /// <summary>
        /// Компьютер загадывает число из 4х уникальных цифр. 
        /// При ответе аользователя нужно сообщать количество быков и коров в случае неверного ответа.
        /// Если быков будет 4 - игрок угадал искомое число.
        /// </summary>
        /// <param name="Numbers">Массив уникальных цифр</param>
        /// <returns>Сообщение с количеством быков и коров</returns>
        static string Exercise_2(int[] Numbers, int[] GenerationsNumbers)
        {
            int Bik = 0, Korova = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == GenerationsNumbers[i])
                {
                    Bik++;
                }
                else
                {
                    for (int j = 0; j < Numbers.Length; j++)
                    {
                        if(Numbers[i] == GenerationsNumbers[j])
                        {
                            Korova++;
                            break;
                        }
                    }
                }
            }
            if(Bik == Numbers.Length)
            {
                return "Поздравляю вы победили!";
            }
            else
            {
                return $"Б: {Bik} \nК: {Korova}";
            }
        }


        /// <summary>
        /// Генерирует массив из уникальныйх цифр от 0 до 9.
        /// </summary>
        /// <param name="Length">Длинна массива которая должна быть от 4 до 9</param>
        /// <returns>Сгенерированный массив из уникальных цифр от 0 до 9</returns>
        static int[] Generation(int Length = 4)
        {
            Random random = new Random();
            //List<int> Result = new List<int>();
            int[] Result = new int[Length];
            int Number;
            int i = 0;
            while (i < Length)
            {
                Number = random.Next(1, 9);
                int n = i;
                for (int j = 0; j <= n; j++)
                {
                    if(Result[j] == Number)
                    {
                        break;
                    }
                    if (j == i)
                    {
                        Result[i] = Number;
                        i++;
                    }
                }
            }
            return Result;
        }
    }
}
