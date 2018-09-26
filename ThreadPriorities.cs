using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOPs
{
    class ThreadPriorities
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
                count1 += 1;
        }

        public static void IncrementCount2()
        {
            while (true)
                count2 += 1;
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            t1.Start();
            t2.Start();
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            Thread.Sleep(10000);
            t1.Abort();
            t2.Abort();
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.ReadKey();
        }
    }
}
