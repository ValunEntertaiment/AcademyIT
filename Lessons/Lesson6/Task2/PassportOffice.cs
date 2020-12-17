using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lessons.Lesson6.Task2
{
    class PassportOffice
    {
        List<Pasport> Pasports = new List<Pasport>();

        public PassportOffice()
        {
            int action;
            Pasport pasport = new Pasport();
            bool flag = true;
            string Series;
            string Number;
            do
            {
                Console.WriteLine("Что делать?\n" +
                                  "(0)Выйти из программы\n" +
                                  "(1)Создать паспорт с случайным Номером и Серией\n" +
                                  "(2)Создать паспорт с конкретной Серией и случайным Номером\n" +
                                  "(3)Вывести список паспортов\n" +
                                  "(4)Найти ФИО по Номеру паспорта\n");
                int.TryParse(Console.ReadLine(), out action);
                switch (action)
                {
                    case 0:
                        goto Exit;
                    case 1:
                        flag = true;
                        do
                        {
                            Console.Clear();
                            Number = pasport.RandomNumber();
                            Series = pasport.RandomSeries();
                            var result = from item in Pasports
                                         where item.Number == Number && item.Series == Series
                                         select item;
                            if (result.Count() == 0)
                            {
                                flag = false;
                                pasport = new Pasport();
                                pasport.Number = Number;
                                pasport.Series = Series;
                                Console.WriteLine("Введите ФИО");
                                pasport.FIO = Console.ReadLine();
                                Pasports.Add(pasport);
                            }
                                
                        } while (flag);
                        break;
                    case 2:
                        Console.WriteLine("Введите серию паспорта");
                        Series = Console.ReadLine();
                        while (!new Regex(@"\d{4}").IsMatch(Series))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Серия должна содержать в себе 4 цифры");
                            Console.ForegroundColor = ConsoleColor.White;
                            Series = Console.ReadLine();
                        }

                        Console.WriteLine("Сколько паспартов добавить?");
                        int Length;
                        while (!int.TryParse(Console.ReadLine(), out Length) && Length > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Введено некорректные данные или число меньше нуля");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        for (int i = 1; i <= Length; i++)
                        {
                            flag = true;
                            do
                            {
                                Console.Clear();
                                Number = pasport.RandomNumber();
                                var result = from item in Pasports
                                             where item.Number == Number && item.Series == Series
                                             select item;
                                if (result.Count() == 0)
                                {
                                    flag = false;
                                    pasport = new Pasport();
                                    pasport.Number = Number;
                                    pasport.Series = Series;
                                    Console.WriteLine("Введите ФИО");
                                    pasport.FIO = Console.ReadLine();
                                    Pasports.Add(pasport);
                                }

                            } while (flag);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        foreach (var item in Pasports)
                        {
                            Console.WriteLine(item.Info());
                        }
                        break;
                    case 4:
                        pasport = new Pasport();
                        Console.Clear();

                        Console.WriteLine("Введите Серию паспорта");
                        pasport.Series = Console.ReadLine();
                        while (pasport.Series == "")
                            pasport.Series = Console.ReadLine();

                        Console.WriteLine("Введите Номер паспорта");
                        pasport.Number = Console.ReadLine();
                        while (pasport.Number == "")
                            pasport.Number = Console.ReadLine();

                        var Search = from item in Pasports
                                     where item.Number == pasport.Number && item.Series == pasport.Series
                                     select item;

                        if(Search.Count() == 0)
                            Console.WriteLine("паспорт не найдет");
                        else
                            Console.WriteLine(Search.First().Info());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет таких действий");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }



            } while (true);
        Exit:;
        }

    }
}
