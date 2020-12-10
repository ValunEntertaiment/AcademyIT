using System.Collections.Generic;

namespace Lessons.Lesson3
{
    class Company
    {
        /// <summary>
        /// Список работников
        /// </summary>
        List<Worker> workers = new List<Worker>();
        
        /// <summary>
        /// Добавляет работника в компанию
        /// </summary>
        /// <param name="FIO">Фамилия Имя Отчество</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Salary">Зарплата</param>
        public void AddWorker(string FIO, int Age, int Salary)
        {
            workers.Add(new Worker(FIO, Age, Salary));
        }

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }

        /// <summary>
        /// Выдет список добавленных работников
        /// </summary>
        /// <returns>список работников</returns>
        public Worker[] GetWorkers()
        {
            int i = 0;
            Worker[] MassWorkers = new Worker[this.workers.Count];
            foreach (var item in workers)
            {
                MassWorkers[i] = item;
                i++;
            }
            return MassWorkers;
        }

        /// <summary>
        /// Выводит информацию всех работников.
        /// </summary>
        public void ShowWorkers()
        {
            foreach (var item in workers)
            {
                System.Console.WriteLine($"ФИО: {item.FIO} \nВозраст: {item.Age} \nЗарплата: {item.Salary}");
            }
        }
    }
}
