using System;

namespace Lessons.Lesson5.Exercise_3
{
    
    class Exercise1
    {
        public Exercise1()
        {
            Console.Clear();
            Console.WriteLine("Задание 3\n");
            Shop platform = new Shop();
            BaseUser user = null;
            do
            {
                #region SignIn or SignUp
                do
                {
                    Console.WriteLine("Вы хотите зарегистрироваться(0) или авторизоваться(1)?");
                    int result;
                    while (!int.TryParse(Console.ReadLine(), out result) && (result == 0 || result == 1))
                        Console.WriteLine("Не корректно введены данные. Попробуйте снова");

                    if (result == 0)
                    {
                        platform.SetUser();
                    }
                    else
                    {
                        platform.SignIn(out user);
                    }
                } while (user == null);
                #endregion
                do
                {
                    switch (platform.GetAction(user))
                    {
                        case 0:
                            //да я в курсе что goto лучше не использовать
                            //но break для выхода из цикла сюда не запихнуть xD
                            goto exit;
                        case 1:
                            user = null;
                            break;
                        case 2:
                            user.Info();
                            break;
                        case 3:
                            user.GetBasket();
                            break;
                        case 4:
                            user.Buy(platform.GetProducts());
                            break;
                        case 5:
                            platform.GetProducts();
                            break;
                        case 6:
                            platform.UniqueAction(user);
                            break;
                        default:
                            Console.WriteLine("Некорректно введены данные.");
                            break;
                    }
                } while (user != null);
            } while (true);

            exit:
            Console.WriteLine("ББ");
        }
    }
}
