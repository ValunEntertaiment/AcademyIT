using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lessons.Lesson6.Task1
{
    class Task1
    {
        List<Visitor> Visitors = new List<Visitor>();
        
         public Task1()
         {
            var notary = new Notary();
            cycle();
            while (true)
                notary.Next(ref Visitors);
         }

        async void cycle()
        {
            await Task.Run(() => Order());
        }

        /// <summary>
        /// Клиенты всё приходят и занимают очередь
        /// </summary>
        void Order()
        {
            int index = 0;
            while (true)
            {
                Thread.Sleep(new Random().Next(1000, 10000));
                var vis = new Visitor();
                Console.WriteLine($"В очередь присоеденился Клиент №{++index}");
                vis.Name = $"Клиент №{index}";
                Visitors.Add(vis);
            }
        }
    }
}
