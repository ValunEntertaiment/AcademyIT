using System;

namespace Lessons.Lesson5.Exercise_3
{
    class BaseCoupon
    {
        public float Discount 
        { 
            get 
            {
                return Discount;
            } 
            set 
            {
                //микро защита от багов
                if (value < 90 || value > 0)
                    Discount = value;
            }
        }
    }
}
