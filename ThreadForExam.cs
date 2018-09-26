using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOPs
{
    class ThreadForExam
    {
        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        //Paramertrised Thread
        public static void Method2(object num)
        {
            for (int i = 0; i < (int)num; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
        [ThreadStatic]
        public static int _ThreadStaticField;
        public static int _NormalField;

        public static void testThreadStatic()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _ThreadStaticField++;
                    _NormalField++;
                    Console.WriteLine("Thread 1(_ThreadStaticField) : " + _ThreadStaticField);
                    Console.WriteLine("Thread 1(_NormalField) : " + _NormalField);
                    Thread.Sleep(1000);
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _ThreadStaticField++;
                    _NormalField++;
                    Console.WriteLine("Thread 2(_ThreadStaticField) : " + _ThreadStaticField);
                    Console.WriteLine("Thread 2(_NormalField) : " + _NormalField);
                    Thread.Sleep(1000);
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _ThreadStaticField++;
                    _NormalField++;
                    Console.WriteLine("Thread 3(_ThreadStaticField) : " + _ThreadStaticField);
                    Console.WriteLine("Thread 3(_NormalField) : " + _NormalField);
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => {
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void testThreadLocal()
        {
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("A : " + i);
                    Thread.Sleep(1000);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("B : " + i);
                    Thread.Sleep(1000);
                }
            }).Start();   

        }
        static void Main()
        {
            testThreadLocal();
            Console.ReadKey();
        }
    }
}
