using System;
using System.Collections.Generic;

namespace Lessons.Lesson3
{
    class Exercise_1
    {
        public int[] PrimeNumbers()
        {
            List<int> ListResult = new List<int>();
            int Sqrt = 1;
            while (Math.Sqrt(Sqrt) < 10d)
            {
                //простое ли число
                int Count = 0;
                for (int i = 1; i <= (Sqrt / 2d); i++)
                    if (Sqrt % i == 0)
                        Count++;
                if (Count <= 1)
                    ListResult.Add(Sqrt);
                Sqrt++;
            }

            int[] Result = new int[ListResult.Count];
            int j = 0;
            foreach (var item in ListResult)
            {
                Result[j] = item;
                j++;
            }
            return Result;
        }
    }
}
