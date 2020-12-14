using System;

namespace Lessons.Lesson5.Exercise_3
{
    class Moderator : BaseUser
    {
        public override string Info() => $"Account: Moderator\nLogin: {Login}\nPassword: {Password}\nName: {Name}\nAge: {Age}\nWallet: {Wallet}";
        public void Ban(BaseUser user)
        {
            if(user.GetType() == typeof(Moderator))
            {
                Console.WriteLine("Ты не можешь забанить модератора");
            }
            else
            {
                //Ыыыыы)00)0))
                Console.WriteLine("Ха-ха-ха отлетел очередняра xD");
            }
        }
    }
}
