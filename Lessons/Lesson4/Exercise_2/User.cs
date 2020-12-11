using System;
namespace Lessons.Lesson4.Exercise_2
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public string Info() => $"Login: {Login}\nPassword: {Password}\nName: {Name}\nAge: {Age}";
    }
}
