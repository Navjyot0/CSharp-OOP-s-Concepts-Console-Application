using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOPs
{
    /*
     * ========Multi-Threading========== *
     * Thread(Every Application By default thread called Main thread * So every program by default is single threaded model)
     * Multithreading enables your C# program to perform concurrent proccessing so that you can perform more than one operations at time
     * Threads enables your program to perform concurent processes
     * Namespace : System.Threading
     * Treads share application resources 
     * By default every program has one thread however auxilary threads can be created and used to execute code parallel with primery/main thread these threads are often called worker threads
     * worker threads can be used to perform time-consuming or time-critical tasks without tying up the primery thread
     * It works based on time shareing 
     * Advantage is Maximum utilisation of CPU resources (i.e. using resources to its fullest)
     * (operating system alocate time for each method and all method has same weightage)
     * T1.Join(); // Can't exit main from program before T1.
     * T1.Join(3000); // Can't exit main from program before T1.(wait for 3-Sec)
     */

    class MultiThreading
    {
        static void Test1()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("Test1:" + i);
        }

        static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                    Thread.Sleep(5000);
            }
        }

        static void Test3()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("Test3:" + i);
        }

        static void Test4(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test4:" + i);
            }
        }

        static void Main()
        {
            //======First Program=========
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine(Thread.CurrentThread.Name);
            

            //======Second Program========
            //Test1();
            //Test2();
            //Test3();


            //======Third Program=========
            //Thread T1 = new Thread(Test1);
            //Thread T2 = new Thread(Test2);
            //Thread T3 = new Thread(Test3);
            //T1.Start(); T2.Start(); T3.Start();


            //======Fourth Program=========
            //ThreadStart obj = new ThreadStart(Test1);
            //====OR=====
            //ThreadStart obj = Test1;
            //====OR=====
            //ThreadStart obj = delegate() { Test1(); };
            //Thread T1 = new Thread(Test1); // Implicitly create ThreadStart by CLR
            //====OR=====
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test4);
            Thread T1 = new Thread(obj); // Explecitly we create ThreadStart
            T1.Start(123);
            Console.ReadKey();
        }
    }
}
