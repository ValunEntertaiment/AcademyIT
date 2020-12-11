using System;
namespace Lessons.Lesson4.Exercise_2
{
    /// <summary>
    /// Создайте структуру «Пользователь». Он имеет свойство логин и пароль. 
    /// Создать метод с массивом логинов и массивом паролей. Нужно проверить авторизацию
    /// </summary>
    class Exercise2
    {
        public Exercise2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2\n");
            Platform platform = new Platform();
            do
            {
                Console.WriteLine("Вы хотите зарегистрироваться(0) или авторизоваться(1)?");
                int result;
                while(!int.TryParse(Console.ReadLine(), out result) && (result == 0 || result == 1))
                    Console.WriteLine("Не корректно введены данные. Попробуйте снова");
                
                if(result == 0)
                {
                    platform.SetUser();
                }
                else
                {
                    if (platform.SignIn())
                    {
                        //на самом деле пользователь даже не авторизовывается :) просто выводятся инфа об его акке (:
                        Console.WriteLine("Нажмите любую кнопку чтобы выйти из своей учетной записи.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            } while (true);
        }
    }
}
