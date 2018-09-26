using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace OOPs
{
    class ThreadPerformance
    {
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i < 1000000000; i++)
            {
                Count++;
            }

            Console.WriteLine("IncrteamentCounter1:" + Count);
        }
        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i < 1000000000; i++)
            {
                Count++;
            }

            Console.WriteLine("IncrteamentCounter2:" + Count);
        }

        static void Main()
        {
            //First Stopwatch
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            IncrementCounter1();
            IncrementCounter2();
            s1.Stop();

            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);

            //Second Stopwatch
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            //Stop primery thread executing before t1 and t2
            t1.Join();
            t2.Join();

            Console.WriteLine("Time 1:" + s1.ElapsedMilliseconds);
            Console.WriteLine("Time 2:" + s2.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
