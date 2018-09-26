using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class ExtentionMethods
    {
        /*
           ========Extenstion Method=========
         * It is new method that has been added in 3.0
         * Inheritance is mechanism using which we can extend the functionality of class
         * Problems in Inhertance
           1. We can't inherit sealed class
           2. If the original type is not class and it is structure.
           3. we can't call parent class by child class instance.
         * It is a mechanism of adding new methods into an existing class or structure also without modifing of source code of original type 
         * in this procces we don't need any permission from original type and the original type dosn't require any re-compilation.
         * 
         * Extention Methods are defined as static but once they are bound with any class or structure they turned in non-static
         * First parameter of the extention method should be the name of the type to which that method has to be bound with and this parameter is not taken into consideration while calling the extention method 
         * Extention method should have one and only one binding parameter and it should be in the first place of parameter list can't have (multiple binding parameter)
         * Note : If extention method is defined with n parameters then while calling it there will be n-1 parameter only because the binding parameter is excluded.
         ===================================
         */

        public void Test1()
        {
            Console.WriteLine("Method-1");
        }

        public void Test2()
        {
            Console.WriteLine("Method-2");
        }

        static void Main()
        {
            ExtentionMethods Ex = new ExtentionMethods();
            Ex.Test1();
            Ex.Test2();
            Ex.Test3();
            Ex.Test4("Name");
            Console.ReadKey();
        }
    }

    static class statClass
    {
        /*
            while calling not needed anything with parameter
         */
        public static void Test3(this ExtentionMethods Ex)
        {
            Console.WriteLine("Extension Method-3");
        }

        //If Extention Methods is defined with same name and signature of an existing method in the class then extention method is not called and 1st preference to original Method 
        public static void Test2(this ExtentionMethods Ex)
        {
            Console.WriteLine("Extension Method-2");
        }
        //How to add parametered method
        public static void Test4(this ExtentionMethods Ex, string Name)
        {
            Console.WriteLine("Hello " + Name);
        }

        public static long Factorial(this Int32 x) 
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }

        public static string ToProperCase(this String oldStr)
        {
            if (oldStr.Length > 0)
            {
                String newStr = null;
                oldStr = oldStr.ToLower();
                string[] sArr = oldStr.Split(' ');

                foreach (string str in sArr)
                {
                    char[] cArr = str.ToCharArray();
                    cArr[0] = Char.ToUpper(cArr[0]);
                    if (newStr == null)
                        newStr = new string(cArr);
                    else
                        newStr += " "+ new string(cArr);
                }
                return newStr;
            }
            else
                return oldStr;
        }
    }

    class testExtMethod
    {
        static void Main()
        {
            ExtentionMethods Ex = new ExtentionMethods();
            Ex.Test1();
            Ex.Test2();
            Ex.Test3();
            Ex.Test4("Navjyot");

            /*as int is struct can check with f12*/
            int i = 5;
            //i.factorial() //as no factorial Methos we can add 
            long result = i.Factorial(); // Now we have extention method for stuct int32

            /*string is sealed class*/
            string str = "oLd StRinG iS DirTy";
            Console.WriteLine(str.ToProperCase());

            Console.WriteLine(i + "!=" + result);
            Console.ReadKey();
        }
    }
}
