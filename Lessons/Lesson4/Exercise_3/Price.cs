namespace Lessons.Lesson4.Exercise_3
{
    class Price
    {
        decimal _priceValue = 0;
        public decimal PriceValue

        {
            get
            {
                return _priceValue;
            }
            set
            {
                if (value > 0)
                {
                    _priceValue = value;
                }
                else
                {
                    System.Console.WriteLine("Цена не может быть отрицательной либо нулевой.");
                }
            }
        }

        public Price(decimal price)
        {
            PriceValue = price;
        }
        public virtual string GetPrice() => $"{_priceValue} Валюта не указана";
    }
}
