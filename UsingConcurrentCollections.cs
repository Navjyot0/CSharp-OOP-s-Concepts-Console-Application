using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace OOPs
{
    class UsingConcurrentCollections
    {
        /*
           ###Concurent Collections###
         
         - There are the collections added in .Net for Thread safty 
           Regular collection blowups when used in a multithreaded scenario because item might removed by one Thread while other thread is trying to read it.
         
            1. BlockingCollection<T>
            2. ConcurrentBag<T>
            3. ConcurrentDictionary<TKey, T>
            4. ConcurrentQueue<T>
            5. ConcurrentStack<T>
         
         - Blocking Collection
         * 
         
         
         */

        #region BlockingCollection<T>
        public static void BlockingCollectionMethod()
        {
            BlockingCollection<string> BC = new BlockingCollection<string>(10);
            //List<string> BC = new List<string>();
            Task Read = new Task(() => {
                foreach (string s in BC)
                    Console.WriteLine(s);
            });
            Task Write = new Task(() =>
            {
                BC.Add("A");
                BC.Add("B");
                BC.Add("C");
                BC.Add("D");
                BC.Add("E");
                BC.Add("F");
                BC.Add("G");
                Thread.Sleep(4000);
                BC.Add("H");
                BC.Add("I");
                BC.Add("J");
                BC.Add("K");
                BC.Add("L");
                BC.Add("M");
                BC.Add("N");
                BC.Add("O");
                
            });
            Write.Start();
            Read.Start();
            Write.Wait();
            Read.Wait();
        }
        #endregion

        static void Main()
        {
            BlockingCollectionMethod();
            Console.ReadKey();
        }
    }
}
