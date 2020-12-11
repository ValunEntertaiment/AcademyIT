using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson4.Exercise_2
{
    /// <summary>
    /// Платформа на которой регается пользователь
    /// </summary>
    class Platform
    {
        List<User> Users = new List<User>();

        /// <summary>
        /// Вводятся данные пользователя перед регистрацией
        /// </summary>
        public void SetUser()
        {
            User user = new User();

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
                    if(user.Password.Length != 0)
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
            user.Password=user.Password.Remove(user.Password.Length - 1);
            Console.Clear();
            #endregion

            Registration(user);
        }

        /// <summary>
        /// Регистрирует пользователя в данной платформе
        /// </summary>
        /// <param name="user">Данные пользователя</param>
        void Registration(User user)
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

        /// <summary>
        /// Авторизация пользователя.
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <returns>True: пользователь успешно авторизовался. False: пользователь не авторизовался</returns>
        public bool SignIn()
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
                List<User> users = result.ToList();
                Console.WriteLine(users[0].Info());
                return true;
            }
            else
            {
                Console.WriteLine("Не верно введены данные.");
                return false;
            }
        }
    }
}
