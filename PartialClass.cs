using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    partial class PartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
    }

    partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    class PartialClassMain 
    {
        static void Main()
        {
            PartialClass PC = new PartialClass();
            PC.Method1();
            PC.Method2();
            Console.ReadKey();
        }
    }
}
