using System.Collections.Generic;

namespace Lessons.Lesson5.Exercise_3
{
    class Product
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<byte[]> Images { get; set; } 
        public enum Type { Phone, Laptop, PC } //и т.д.

        //да сюда нужно добавить количество товара дз и так огномное получается
    }
}
