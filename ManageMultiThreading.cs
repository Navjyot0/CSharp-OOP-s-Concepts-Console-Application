using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class ManageMultiThreading
    {
        static void Main() 
        {
            int n = 0;
            object obj=new object();
            var up = new Task(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock(obj)
                    {
                        n++;
                    }
                }
            });
            up.Start();

            for (int i = 0; i < 1000000; i++)
                lock (obj)
                {
                    n--;
                }
            up.Wait();
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
