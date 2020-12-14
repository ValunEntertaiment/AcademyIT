using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson5.Exercise_3
{
    /// <summary>
    /// Использовал уже готовую реализацию работы с аккаунтами из задания 2. 
    /// Можно было наследовать но там потом еще переопределять все методы да и не зачем это делать 
    /// ибо сама по себе платформа имеет скудный набор действий предназанченный исключительно для задания 2
    /// </summary>
    class Shop
    {
        List<BaseUser> Users = new List<BaseUser>();

        List<Product> Products = new List<Product>();

        /// <summary>
        /// Выдает Id под которым и будет храниться товар в коллекции.
        /// Проблемы начнутя когда товаров будет больше 2147483647 из за типа данных
        /// </summary>
        /// <returns>Id под которым и будет храниться товар в коллекции</returns>
        public int GetId() => Products.Count();

        /// <summary>
        /// Все действия которые может сделать пользователь.
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Номер действия</returns>
        public int GetAction(BaseUser user)
        {
            int action;
            bool flag = true;
            do
            {
                Console.WriteLine("Что хотите сделать?");

                //Это базовые действия для всех аккаунтов
                Console.WriteLine("Выйти из аккаунта и из приложения. (0)");
                Console.WriteLine("Выйти с аккауна. (1)");
                Console.WriteLine("Вывести информацию об аккаунте. (2)");
                Console.WriteLine("Вывести корзину. (3)");
                Console.WriteLine("Купить товар. (4)");
                Console.WriteLine("Добавить товар в корзину. (5)");
                

                if (user.GetType() == typeof(Admin))
                {
                    Console.WriteLine("Добавить продукт для продажи. (6)");
                }

                if (user.GetType() == typeof(Moderator))
                {
                    Console.WriteLine("Забанить дурачка. (6)");
                }
                Console.Write("Введите цифру действий: ");

                //тут вроде как можно упростить условие(сделать на пару символов короче),
                //но у меня голова заболела пока пытался понять как именно упростить :)
                if (int.TryParse(Console.ReadLine(), out action) && (action >= 0 && action < 6))
                {
                    flag = false;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не корректно введены данные. Попробуйте снова.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            } while (flag);
            return action;
        }

        public void SetUser()
        {
            BaseUser user = new BaseUser();
            Console.Clear();
            Console.Write("Введите логин: ");
            user.Login = Console.ReadLine();
            Console.Clear();

            Console.Write("Ввеите имя: ");
            user.Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите возраст: ");
            int Age;
            while (!int.TryParse(Console.ReadLine(), out Age))
                Console.WriteLine("Не корректно введены данные");
            user.Age = Age;
            Console.Clear();

            //Можно и даже нужно повторно просить ввести пароль но мне лень :(
            Console.Write("Введите пароль: ");
            #region hidden password

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    user.Password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (user.Password.Length != 0)
                        user.Password = user.Password.Remove(user.Password.Length - 1);

                    string message = "Введите пароль: ";
                    for (int i = 0; i < user.Password.Length; i++)
                    {
                        message += "*";
                    }
                    Console.Clear();
                    Console.Write(message);
                }
            }
            while (key.Key != ConsoleKey.Enter);
            user.Password = user.Password.Remove(user.Password.Length - 1);
            Console.Clear();
            #endregion

            Registration(user);
        }

        void Registration(BaseUser user)
        {
            //метод вынесен отдельно потому что в будущем может быть добавлена доп. проверка на уникальность пользователя и пр.
            var result = from item in Users
                         where item.Login == user.Login
                         select item;
            if (result.Count() == 0)
            {
                Users.Add(user);
                Console.WriteLine("Вы успешно зарегестрировались");
            }
            else
                Console.WriteLine("Данный логин занят.");
        }

        public bool SignIn(out BaseUser user)
        {
            Console.Clear();
            Console.Write("Введите логин: ");
            string Login = Console.ReadLine();
            Console.Clear();

            Console.Write("Введите пароль: ");
            string Password = Console.ReadLine();
            Console.Clear();

            var result = from item in Users
                         where item.Login == Login && item.Password == Password
                         select item;

            if (result.Count() == 1)
            {
                List<BaseUser> users = result.ToList();
                //Console.WriteLine(users[0].Info());
                user = users[0];
                return true;
            }
                Console.WriteLine("Не верно введены данные.");
                user = null;
                return false;
        }

        public Product GetProducts()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Номер продукта: {item.Id}\nНазвание продукта: {item.Name}\nЦена товара: {item.Price}\n" );
            }
            int Id;
            while(!int.TryParse(Console.ReadLine(), out Id))
                Console.WriteLine("Не корректно введены данные. Попробуйте снова");

            return Products.First(i => i.Id == Id);
        }

        public void UniqueAction(BaseUser user)
        {

        }
    }
}
