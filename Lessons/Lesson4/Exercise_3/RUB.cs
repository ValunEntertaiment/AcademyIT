
namespace Lessons.Lesson4.Exercise_3
{
    class RUB : Price
    {
        public RUB(decimal price) : base(price)
        {
            PriceValue = price;
        }

        public override string GetPrice() => $"{PriceValue} RUB";
    }
}
