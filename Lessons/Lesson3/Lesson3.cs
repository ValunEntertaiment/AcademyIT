using System;

namespace Lessons.Lesson3
{
    class Lesson3
    {
        static void Main()
        {
            #region Задание 1

            Console.WriteLine("Задание 1\nВсе простые числа корень которых меньше 10");

            int[] mass = new Exercise_1().PrimeNumbers();
            foreach (var item in mass)
            {
                Console.WriteLine(item + " ");
            }
            #endregion

            #region Задание 2

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите предложение");

            Scanner scanner = new Scanner();
            scanner.Spliter(Console.ReadLine());

            foreach (var item in scanner.StatsRecorder())
            {
                if (item.Сharacter != '\0')
                    Console.WriteLine($"Буква {item.Сharacter} встречается в тексте в {item.Percent}% случаях\n");
            }
            #endregion

            #region Задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите адрес электронной почты");
            string Email = Console.ReadLine();
            if (new Exercise_3().GetRegexMail().IsMatch(Email))
                Console.WriteLine("Email подтвержден");
            else
                Console.WriteLine("Не корректно введен Email");

            Console.WriteLine("Введите IP адрес");
            string IP = Console.ReadLine();
            if (new Exercise_3().GetRegexIP().IsMatch(IP))
                Console.WriteLine("IP подтвержден");
            else
                Console.WriteLine("Не корректно введен IP");
            #endregion

            #region Задание 4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите количество работников");
            int Count = Convert.ToInt32(Console.ReadLine());
            Company company = new Company();

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Введите ФИО работника");
                    string FIO = Console.ReadLine();

                Console.WriteLine("Введтие возраст работника");
                    int Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите зарплату работника");
                    int Salary = Convert.ToInt32(Console.ReadLine());

                company.AddWorker(new Worker(FIO, Age, Salary));
            }
            Console.Clear();
            company.ShowWorkers();
            #endregion
        }
    }
}