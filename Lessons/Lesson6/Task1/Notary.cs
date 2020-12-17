using System;
using System.Collections.Generic;
using System.Threading;

namespace Lessons.Lesson6.Task1
{
    class Notary
    {
        public void Next(ref List<Visitor> visitors)
        {
            if(visitors.Count > 5)
            {
                Console.WriteLine($"{visitors[0].Name} может войти");
                visitors.Remove(visitors[0]);
            }
            //типо идет прием
            Thread.Sleep(new Random().Next(1000, 10000));
        }
    }
}
