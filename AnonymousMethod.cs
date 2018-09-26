using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    delegate void addNums(int num1, int num2);

    class AnonymousMethod
    {
        static void Main()
        {
            /*
             * Anonymous method is method without name which is pointed to delegate
             * Anonymous Method are only recommended for very less line of code
             *
             * We don't need to define return type as delegate targeting has return type 
             * So why needed to define return type too 
             * So in C# 5.0 lambda expression get in presence 
             */

            //Anonymous Method 
            addNums delAdd=delegate(int num1, int num2)//(You have to create delegate variable for creating anonymous method)
            {
                Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            };
            //With Lambda Expression
            addNums delAdd1 = (num1, num2) =>
            {
                Console.WriteLine(num1 + num2);
            };

            delAdd(10, 20);
            delAdd1(11, 11);
            Console.ReadKey();
        }
    }
}
