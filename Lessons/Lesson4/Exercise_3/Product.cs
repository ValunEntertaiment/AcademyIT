using System.Collections.Generic;

namespace Lessons.Lesson4.Exercise_3
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<byte[]> Images { get; set; } 
        public enum Type { Phone, Laptop, PC } //и т.д.
    }
}
