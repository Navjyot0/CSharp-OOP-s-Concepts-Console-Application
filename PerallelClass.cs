using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPs
{
    class PerallelClass
    {
        //Parallel class is also used for parallel processing
        //with (For/For<>/Foreach<>) Looping
        static void Main() 
        {
            Parallel.For(0, 10, (i) => {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            var Range = Enumerable.Range(0, 10);

            Parallel.ForEach(Range, (i) => {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            Console.ReadKey();    
        }
    }
}
