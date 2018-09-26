using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    public interface ITest
    {
        void add(int num1, int num2);
    }

    class Interface : ITest
    {
        public void add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        static void Main()
        {
            Interface iObj = new Interface();
            iObj.add(10, 20);
            Console.ReadKey();   
        }
    }
}
