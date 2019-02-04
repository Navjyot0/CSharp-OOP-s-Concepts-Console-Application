using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circle
    {
        public static double Radius { get; set; }

        public static double Calculate(Func<double, double> op)
        {
            return op(Radius);
        }


        static void Main()
        {
            Radius=12;
            var Ans = Calculate(r => 2 * System.Math.PI * r);
            Console.WriteLine(Ans);
            var Person = new Tuple<string, string, byte>("Navjyot", "Gurhale", 24);
            Console.Write(Person.Item1 +" ");
            Console.Write(Person.Item2 +" (");
            Console.WriteLine(Person.Item3 + ") ");
            Console.ReadKey();
        }
    }
}