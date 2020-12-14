
namespace Lessons.Lesson4.Exercise_3
{
    class USD : Price
    {
        public USD(decimal price) : base(price)
        {
            PriceValue = price;
        }

        public override string GetPrice() => $"{PriceValue} USD";
    }
}
