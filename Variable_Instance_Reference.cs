using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Variable_Instance_Reference
    {
        static void Main()
        {
            int i; string s; bool b; Variable_Instance_Reference_test1 virt1; // Variable
            Variable_Instance_Reference_test1 virt12 = new Variable_Instance_Reference_test1(); // Instance
            //Reference
            Console.WriteLine("Variable_Instance_Reference");
        }
    }

    class Variable_Instance_Reference_test1
    { 
        //public void Method1()
        //{
        //    Console.WriteLine("Test1 Method1");
        //}

        //public void Method2()
        //{
        //    Console.WriteLine("Test1 Method2");
        //}
    }

    class Variable_Instance_Reference_test2
    {
        //public void Method1()
        //{
        //    Console.WriteLine("Test2 Method1");
        //}

        //public void Method2()
        //{
        //    Console.WriteLine("Test2 Method2");
        //}
    }
}
