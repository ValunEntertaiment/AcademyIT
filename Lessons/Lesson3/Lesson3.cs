using System;

namespace Lessons.Lesson3
{
    class Lesson3
    {
        static void Main()
        {
            #region Задание 1

            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите предложение");

            Scanner scanner = new Scanner();
            scanner.Spliter(Console.ReadLine());

            foreach (var item in scanner.StatsRecorder())
            {
                if (item.Сharacter != '\0')
                    Console.WriteLine($"Буква {item.Сharacter} встречается в тексте в {item.Percent}% случаях\n");
            }
            #endregion

            #region Задание 2

            #endregion
        }
    }
}
