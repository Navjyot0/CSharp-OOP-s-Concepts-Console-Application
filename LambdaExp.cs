using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class LambdaExp
    {
        static void Main()
        {
            addNums delAdd = (num1, num2) => //Lamba-Expresion
            {
                Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            };

            delAdd.Invoke(12, 23);
            Console.ReadKey();
        }
    }

    //Func, Action, Predicate
}
