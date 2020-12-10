namespace Lessons.Lesson3
{
    class Worker
    {
        /// <summary>
        /// Фамилия Имя Отчество работника
        /// </summary>
        public string FIO;

        /// <summary>
        /// Возраст работника
        /// </summary>
        public int Age;

        /// <summary>
        /// Зарплата работника
        /// </summary>
        public int Salary;

        public Worker(string FIO, int Age, int Salary)
        {
            this.FIO = FIO;
            this.Age = Age;
            this.Salary = Salary;
        }
    }
}
