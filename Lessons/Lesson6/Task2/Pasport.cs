using System;
using System.Text.RegularExpressions;

namespace Lessons.Lesson6.Task2
{
    class Pasport
    {
        string _series = "";
        public string Series
        {
            get
            {
                return _series;
            }
            set
            {
                if (Regex.IsMatch(value, @"\d{4}"))
                {
                    _series = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Серия должна содержать в себе 4 цифры");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        string _number = "";
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (Regex.IsMatch(value, @"\d{6}"))
                {
                    _number = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Номер должен содержать в себе 6 цифры");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        string _fio = "";
        public string FIO
        {
            get
            {
                return _fio;
            }
            set
            {
                if(value != "")
                {
                    _fio = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ФИО не было введено");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        /// <summary>
        /// Рандомный номер паспорта
        /// </summary>
        /// <returns>Рандомный номер паспорта в виде строки</returns>
        public string RandomNumber() => Convert.ToString(new Random().Next(100000, 999999));

        /// <summary>
        /// Рандомная серия паспорта
        /// </summary>
        /// <returns>Рандомная серия паспорта в виде строки</returns>
        public string RandomSeries() => Convert.ToString(new Random().Next(1000, 9999));

        public string Info() => $"Серия: {Series}\nНомер: {Number}\nФИО: {FIO}\n";
    }
}
