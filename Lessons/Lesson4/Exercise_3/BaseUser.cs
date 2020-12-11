using System;
using System.Collections.Generic;

namespace Lessons.Lesson4.Exercise_3
{
    class BaseUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Wallet { get; set; }
        public List<Product> Basket { get; set; }
        public List<BaseCoupon> Coupons { get; set; } 

        /// <summary>
        /// Выводит всю инфу о пользователе
        /// </summary>
        /// <returns></returns>
        public virtual string Info() => $"Account: User\nLogin: {Login}\nPassword: {Password}\nName: {Name}\nAge: {Age}\nWallet: {Wallet}";

        /// <summary>
        /// Выводит список товаров из корзины
        /// </summary>
        public void GetBasket()
        {
            foreach (var item in Basket)
            {
                Console.WriteLine($"Name: {item.Name}\n Price: {item.Price}");
            }
            Console.WriteLine($"Общая стоимость: {CostProducts(Basket)}");
        }

        /// <summary>
        /// Выводит стоимость всех выбранных товаров
        /// </summary>
        /// <param name="products">Список товаров</param>
        /// <returns>Общая стоимость</returns>
        public decimal CostProducts(List<Product> products)
        {
            decimal sum = 0;
            foreach (var item in products)
            {
                sum += item.Price;
            }
            return sum;
        }

        /// <summary>
        /// процесс покупки
        /// </summary>
        /// <param name="products">Список товаров на покупку</param>
        /// <returns>True: товары оплачены. False: на счету не достаточно средств</returns>
        public bool Buy(List<Product> products)
        {
            if(Wallet >= CostProducts(products))
            {
                //открывается страничка доставки если адрес не указан
                return true;
            }
            else
            {
                Console.WriteLine("У вас на счету не достаточно средств. Хотите пополнить баланс?");
                //открывается странчика для пополнения баланса
                return false;
            }
            
        }
    }
}
