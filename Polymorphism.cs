﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    /*
     * ==========Polymorphism=========
     * 
     * Polymorphism means having Many Forms.
     * Polymorphism is a Greek word meaning "one name many forms". 
     * In other words, one object has many forms or has one name with multiple functionalities.
     * "Poly" means many and "morph" means forms. 
     * Polymorphism provides the ability to class multiple implementations with the same name. 
     * It is one principle concept in Object Oriented Programming after encapsulation and inheritance.
     * 
     * Types of Polymorphism:
     * 1. Static (CompileTime) (Method/Operator Overloading)
     * 2. Dynamic (RunTime) (Method Overriding)
     * 
     *                                                    ___1. Method Overloading
     *                                               *Ex |
     *                   ___ 1. Static / CompileTime --->|
     *                  |                                |___2. Operator Overloading 
     * #Polymorphism--->|                           *Ex
     *                  |___ 2. Dynamic / RunTime-------> 1. Virual/Overriding
     *                  
     * 
     * 1. Static / CompileTime Polymorphism
     * It is also known as early binding.
     * Method overloading is example of static polymorphism
     * In Overloading, the method / function has the same name but different signatures.
     * It is also known as Compile Time Polymorphism because the decision of which method is to be called is made at compile time.
     * Overloading is the concept in which method names are the same with a different set of parameters.
     * 
     * 2. Dynamic / Runtime Polymorphism
     * Dynamic / runtime polymorphism is also known as late binding.
     * Here, the method name and the method signature (number of parameters and parameter type must be the same and may have a different implementation). 
     * Method overriding is an example of dynamic polymorphism.
     * Method overriding can be done using inheritance. 
     * With method overriding it is possible for the base class and derived class to have the same method name and same something.
     * The compiler would not be aware of the method available for overriding the functionality,so the compiler does not throw an error at compile time. 
     * We can prevent a derived class from overriding virtual members.
     * We can access a base class virtual member from the derived class.
     * 
     * https://www.c-sharpcorner.com/UploadFile/8911c4/different-between-method-overriding-method-hiding-new-keyw/
     * Method overriding/Hiding/Shadowing
     * The "override" modifier extends the base class method, and the "new" modifier hides it.
     * The "virtual" keyword modifies a method, property, indexer, or event declared in the base class and allows it to be overridden in the derived class.
     * The "override" keyword extends or modifies a virtual/abstract method, property, indexer, or event of the base class into the derived class.
     * The "new" keyword is used to hide a method, property, indexer, or event of the base class into the derived class.
     * If a method is not overriding the derived method then it is hiding it. A hiding method must be declared using the new keyword.
     * Shadowing is another commonly used term for hiding. The C# specification only uses "hiding" but either is acceptable. Shadowing is a VB concept.
     * 
     * Differences between method hiding and overriding in C#?
     * 1. For hiding the base class method from derived class simply declare the derived class method with the new keyword. 
     * Whereas in C#, for overriding the base class method in a derived class, you need to declare the base class method as virtual and the derived class method as overriden.
     * 2. If a method is simply hidden then the implementation to call is based on the compile-time type of the argument "this".
     * Whereas if a method is overridden then the implementation to be called is based on the run-time type of the argument "this".
     * 3. New is reference-type specific, overriding is object-type specific.
     * 
     * Differences between method hiding and method shadowing?
     * Shadowing is a VB concept. In C#, this concept is called hiding.
     * The two terms mean the same in C#.
     * Method hiding == shadowing
     * In short, name "hiding" in C# (new modifier) is called shadowing in VB.NET (keyword Shadows).
     * In C# parlance, when you say "hiding" you're usually talking about inheritance, where a more derived method "hides" a base-class method from the normal inherited method call chain.
     * When you say "shadow" you're usually talking about scope; an identifier in an inner scope is "shadowing" an identifier at a higher scope.
     * In other languages, what is called "hiding" in C# is sometimes called "shadowing" as well.
     * 
     * 
     */
    class PolymorphismA
    {
        public virtual void displayName(string Name)
        {
            Console.WriteLine("From Base class " + Name);
        }

        public void testHidding()
        {
            Console.WriteLine("Hiding of Method:Base Class Method");
        }
    }

    class Polymorphism : PolymorphismA
    {
        //Method Overloading Example
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s2 + s1);
        }
        public void Add(int num1, string s1) // Can have order change compiler will detect the differnce
        {
            Console.WriteLine(num1 + s1);
        }

        //Best Example of operator overloading is "+" this can be used for both concatination and addition 

        //Method Overriding 
        public override void displayName(string Name)
        {
            //base.displayName(Name); //to execute base class method
            Console.WriteLine("From Child Class " + Name);
        }


        //Method hidding 
        //public void testHidding() //Warning : Use the new keyword if hiding is intended
        //new public void testHidding() 
        //or 
        public new void testHidding()
        {
            Console.WriteLine("Hiding of Method : Child Class Method");
        }
        static void Main()
        {
            try
            {
                Polymorphism P1 = new Polymorphism();
                (P1 as PolymorphismA).displayName("Gurhale");//this means your method is completely override with variable 
                P1.displayName("Navjyot");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
