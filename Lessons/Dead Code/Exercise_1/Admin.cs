﻿using System;
namespace Lessons.Lesson5.Exercise_3
{
    class Admin : BaseUser
    {
        public override string Info() => $"Account: Admin\nLogin: {Login}\nPassword: {Password}\nName: {Name}\nAge: {Age}\nWallet: {Wallet}";

        public Product AddProduct(uint Id)
        {
            Product product = new Product();

            product.Id = Id;

            Console.Write("Введите название товара: ");
            product.Name = Console.ReadLine();

            Console.Write("Введите цену товара: ");
            decimal Price;
            while(!decimal.TryParse(Console.ReadLine(), out Price))
                Console.WriteLine("Не корректно введены данные.");
            product.Price = Price;

            Console.WriteLine("Загрузите картинки своего продукта. Желательно с котиками :3");
            //типа загрузил картинки в консоль
            return product;
        }
    }
}
