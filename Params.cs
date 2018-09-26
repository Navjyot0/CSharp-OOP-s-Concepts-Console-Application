using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Params
    {
        public static void ParamsChek(int[] iArr, params string[] sArr)
        { 
            foreach(int i in iArr)
            {
                Console.WriteLine(i);
            }

            foreach (string str in sArr)
            {
                Console.WriteLine(str);
            }
        }
        static void Main() 
        {
            int[] muNewArr={1, 2, 3, 4};
            ParamsChek(muNewArr, "sdsdfsd", "sdgfsdf");
            Console.ReadKey();
        }
    }
}
