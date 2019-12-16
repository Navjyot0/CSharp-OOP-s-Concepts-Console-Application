using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    public delegate void RectDelegate(double Width, double Height);

    public delegate string GreetingsDelegate(string name);

    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);
    class GenericDelegate
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLenght(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        
        public void Main()
        {
            Delegate1 d1 = AddNums1;
            double result = d1(10, 20, 30);
            Console.WriteLine(result);
            //or
            Func<int, float, double, double> obj1 = AddNums1;
            result = obj1(11, 22, 33);
            Console.WriteLine(result);

            Delegate2 d2 = AddNums2;
            d2(20, 30, 40);
            //or
            Action<int, float, double> obj2 = AddNums2;
            obj2(22, 33, 44);


            Delegate3 d3 = CheckLenght;
            bool flag=d3("Navjyot");
            Console.WriteLine(flag);
            //or
            Predicate<string> obj3 = CheckLenght;
            obj3("Navjyot");
        }
    }

    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area:" + (Width * Height));
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter:" + (2*(Width + Height)));
        }

        GreetingsDelegate obj = (name)=>
        {
            return "Hello " + name + " a very good morning!";
        };

        public void Main()
        {
            Rectangle rectangle = new Rectangle();
            RectDelegate rectDelegate = rectangle.GetArea;
            rectDelegate += rectangle.GetPerimeter;

            rectDelegate.Invoke(10, 20);
            Console.ReadKey();


        }
    }
    class Delegate
    {
        /*
         * Links:
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
         * 
         * A delegate is a type that represents references to methods with a particular parameter list and return type.
         * When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
         * You can invoke (or call) the method through the delegate instance.
         * Delegates are used to pass methods as arguments to other methods. 
         * Event handlers are nothing more than methods that are invoked through delegates.
         * You create a custom method, and a class such as a windows control can call your method when a certain event occurs.
         */

        //The following example shows a delegate declaration:
        public delegate int PerformCalculation(int x, int y);

        /* 
         * Any method from any accessible class or struct that matches the delegate type can be assigned to the delegate.
         * Method can be either static or an instance method. 
         * this makes it possible to programmatically change method calls, and also and plug new code into existing classes.
         * 
         * Note: In the Context of method overloading, the signature of a method does not include the return type value.
         * But in the context of delegate, the signature does include the return type value. In other words, a method must have the same return type as delegate
         * 
         * This ability to refer to a method as a parameter makes delegates ideal for defining callback methods.
         * For example, a reference to a method that compares two objects could be passed as an argument to a sort algorithm.
         * Because the comparison code is in a separate procedure, the sort algorithm can be written in a more general way.
         * 
         * Delegates have the following properties:
         * 1. Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
         * 2. Delegates allow methods to be passed as parameters.
         * 3. Delegates can be used to define callback methods.
         * 4. Delegates can be chained together; for example, multiple methods can be called on a single event.
         * 5. Methods do not have to match the delegate type exactly. For more information, see Using Variance in Delegates.
         * 
         * Using Delegates:
         * A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++.
         * Unlike C function pointers, delegates are object-oriented, type safe, and secure.
         * The type of a delegate is defined by the name of the delegate.
         * The following example declares a delegate named Del that can encapsulate a method that takes a string as an argument and returns void
         */
        public delegate void Del(string message);
        /*
         * A delegate object is normally constructed by providing the name of the method the delegate will wrap, or with an anonymous function.
         * Once a delegate is instantiated, a method call made to the delegate will be passed by the delegate to that method.
         * The parameters passed to the delegate by the caller are passed to the method, and the return value, if any, from the method is returned to the caller by the delegate.
         * This is known as invoking the delegate. 
         * An instantiated delegate can be invoked as if it were the wrapped method itself. For example:
         */
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        /*
         * Delegate types are derived from the Delegate class in the .NET Framework.
         * Delegate types are sealed they cannot be derived from and it is not possible to derive custom classes from Delegate.
         * Because the instantiated delegate is an object, it can be passed as a parameter, or assigned to a property.
         * This allows a method to accept a delegate as a parameter, and call the delegate at some later time. 
         * This is known as an asynchronous callback, and is a common method of notifying a caller when a long process has completed.
         * When a delegate is used in this fashion, the code using the delegate does not need any knowledge of the implementation of the method being used.
         * The functionality is similar to the encapsulation interfaces provide.
         * Another common use of callbacks is defining a custom comparison method and passing that delegate to a sort method.
         * It allows the caller's code to become part of the sort algorithm. The following example method uses the Del type as a parameter:
         */
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
        /*
         * You can then pass the delegate created above to that method:
         * 
         * MethodWithCallback(1, 2, handler);
         * 
         * Using the delegate as an abstraction, MethodWithCallback does not need to call the console directly—it does not have to be designed with a console in mind. 
         * What MethodWithCallback does is simply prepare a string and pass the string to another method. 
         * This is especially powerful since a delegated method can use any number of parameters.
         * When a delegate is constructed to wrap an instance method, the delegate references both the instance and the method. 
         * A delegate has no knowledge of the instance type aside from the method it wraps, 
         * so a delegate can refer to any type of object as long as there is a method on that object that matches the delegate signature. 
         * When a delegate is constructed to wrap a static method, it only references the method. 
         * Consider the following declarations:
         */
        public class MethodClass
        {
            public void Method1(string message) { }
            public void Method2(string message) { }
        }

        public static void Main()
        {
            var obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            //Both types of assignment are valid.
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
            allMethodsDelegate("Hello World");

            //To remove a method from the invocation list
            //remove Method1
            allMethodsDelegate -= d1;

            // copy AllMethodsDelegate while removing d2
            Del oneMethodDelegate = allMethodsDelegate - d2;
        }

        /*
         * At this point allMethodsDelegate contains three methods in its invocation list—Method1, Method2, and DelegateMethod.
         * The original three delegates, d1, d2, and d3, remain unchanged.
         * When allMethodsDelegate is invoked, all three methods are called in order.
         * If the delegate uses reference parameters, the reference is passed sequentially to each of the three methods in turn, 
         * and any changes by one method are visible to the next method.
         * When any of the methods throws an exception that is not caught within the method, 
         * that exception is passed to the caller of the delegate and no subsequent methods in the invocation list are called.
         * If the delegate has a return value and/or out parameters, it returns the return value and parameters of the last method invoked.
         * 
         * Multicast delegates are used extensively in event handling.
         * 
         * 
         */


    }
}
