using System.Collections.Generic;

namespace Lessons.Lesson7.Task1
{
    class Beverage
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Info() => $"Название: {Name}\n" +
                                $"Стоимость: {Price}\n";


    }
}
