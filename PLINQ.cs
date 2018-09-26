using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class PLINQ
    {
        /*
         * PLINQ (Parallel Language Integrated Query)
         * 
         * 
         */
        static void Main()
        {
            var number = Enumerable.Range(0, 19);

            //Regular
            Console.WriteLine("LINQ");
            var sequentialResult = number.Where(i => i % 2 == 0).ToArray();
            foreach (int i in sequentialResult)
                Console.WriteLine(i);

            //With PLINQ
            Console.WriteLine("P-LINQ");
            var parallelResult = number.AsParallel().Where((i) => i % 2 == 0).ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i); //Reurened result in this are not in perticular order

            //Ordered PLINQ
            Console.WriteLine("Ordered P-LINQ");
            var OrderedParallelResult = number.AsParallel().AsOrdered().Where((i) => i % 2 == 0).ToArray();
            foreach (int i in OrderedParallelResult)
                Console.WriteLine(i); //Reurened result in this are in perticular order as in 1st code



            Console.ReadKey();
        }
    }
}
