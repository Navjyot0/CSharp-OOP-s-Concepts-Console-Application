using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    public delegate void Math(int n1, int n2);

    class OperatorOverloading_Matrix
    {
        int _1, _2, _3, _4;
        
        public OperatorOverloading_Matrix(int _1, int _2, int _3, int _4)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
        }

        public static OperatorOverloading_Matrix operator ++(OperatorOverloading_Matrix m1)
        {
            return new OperatorOverloading_Matrix(++m1._1, ++m1._2, ++m1._3, ++m1._4);
        }

        public override string ToString()
        {
            return _1 + " " + _2 + "\n" + _3 + " " + _4 + "\n";
        }
    }

    static class MethodExtention_Demo
    { 
        //Creating Extention for String class and Int32 class
        public static string ToProperCase(this String oldStr)
        {
            if (oldStr.Length > 0)
            {
                string newStr = "";
                oldStr = oldStr.ToLower();
                string[] sArr = oldStr.Split(' ');

                foreach (string str in sArr)
                {
                    char[] cArr = str.ToCharArray();
                    cArr[0] = char.ToUpper(cArr[0]);
                    if (newStr == null)
                        newStr = new string(cArr);
                    else
                        newStr += " " + new string(cArr);
                }

                return newStr.Trim();
            }
            else
                return oldStr;
        }

        public static long Factorial(this Int32 oldValue)
        {
            long newValue=1;
            if (oldValue == 0 || oldValue == 1)
                return 1;
            else
            {
                for (int i = oldValue; i > 1; i--)
                    newValue *= i;

                return newValue;
            }
        }
    }

    class KeepInMind
    {
        public static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public static void Multiplication(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        public static void Main()
        {
            //Operator overloading
            OperatorOverloading_Matrix oom = new OperatorOverloading_Matrix(21, 32, 54, 65);
            Console.WriteLine(oom.ToString());
            oom++;
            Console.WriteLine(oom.ToString());

            //Method Extention
            string myString = "naVjYot GuRHaLE";//Console.ReadLine();
            Console.WriteLine(myString.ToProperCase());
            Int32 myInt = 5;//int.Parse(Console.ReadLine());
            Console.WriteLine(myInt.Factorial());
            
            //Delegate
            Math obj1 = new Math(Add);
            obj1.Invoke(10, 20);
            
            //Multicast Delegate
            Math obj2 = Add;
            obj2 += Multiplication;
            obj2(10, 10);

            //Anonymous Method
            Math obj3 = delegate(int i1,int i2)
            {
                Console.WriteLine(i1-i2);
            };
            obj3(10, 10);

            //Anonymous Method with Lambda Expression
            Math obj4 = (i1, i2) =>
            {
                Console.WriteLine(i1 / i2);
            };

            obj4(10, 10);

            //Func, Action, Predicate (With Lambda Expresion)
            //1. Func (Return any value)
            Func<int, int, int, int> obj5 = (x, y, z) => x + y + z;
            Console.WriteLine(obj5(10, 10, 10));

            //2. Action (Void)
            Action<int, int, int> obj6 = (x, y, z) => Console.WriteLine(x * y * z);
            obj6(10, 10, 10);

            //3. Predicate (Boolean)
            Predicate<string> obj7 = (str) => {
                if (str.Length > 7)
                    return true;
                return false;
            };
            Console.WriteLine(obj7("Navjyot Gurhale"));

            //or (Without Lambda Expresion/ i.e with delegate keyword (Anonymous function) )
            
            //1. Func (Return any value)
            Func<int, int, int, int> obj05 = delegate(int x, int y, int z)
            {
                return x + y + z;
            };
            Console.WriteLine(obj5(10, 10, 10));

            //2. Action (Void)
            Action<int, int, int> obj06 = delegate(int x, int y, int z)
            { 
                Console.WriteLine(x * y * z); 
            };
            obj6(10, 10, 10);

            //3. Predicate (Boolean)
            Predicate<string> obj07 = delegate(string str)
            {
                if (str.Length > 7)
                    return true;
                return false;
            };
            Console.WriteLine(obj7("Navjyot Gurhale"));

            Console.ReadKey();
        }
    }
}
