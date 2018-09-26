using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Inheritance
    {
        /*
         * =====Inheritance=====(good if refer : https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance )
         * Inheritance is one of the fundamental attributes of object-oriented programming. 
         * It allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. 
         * The class whose members are inherited is called the base class. 
         * The class that inherits the members of the base class is called the derived class.
         * C# and .NET support single inheritance only. That is, a class can only inherit from a single class. 
         * However, inheritance is transitive, which allows you to define an inheritance hierarchy for a set of types.
         * 
         * Not all the members can inherit 
         * 
         * Member of class at Following conditions dont inherit
         * 
         * 1. Static Constructor (which initialize the static data of a class.)
         * 2. Instance constructors (which you call to create a new instance of the class. Each class must define its own constructors)
         * 3. Finalizers (which are called by the runtime's garbage collector to destroy instances of a class.)
         * 4. Private Members (are visible only in derived classes that are nested in their base class.)
         * 5. Protected members (are only visible in derived class)
         * 6. same with other access specifiers
         * 
         * Inheritance and an "is a" relationship
         * Ordinarily, inheritance is used to express an "is a" relationship between a base class and one or more derived classes, where the derived classes are specialized versions of the base class; the derived class is a type of the base class.
         * the Publication class represents a publication of any kind, and the Book and Magazine classes represent specific types of publications.
         * 
         * Types of Inheritance : 
         * 1. Single
         * 2. Hierarchical
         * 3. Multi-Level
         * 4. Multiple (Not supported in C#)(But can achive with Interface)
         * 
         * Base class - is the class from which features are to be inherited into another class.
         * Derived class - it is the class in which the base class features are inherited.
         * 
         * Some Special :
         * Need to remember some inheritance for parent class (following are some)
         * ______________________________________________________
         * |Type category	|Implicitly inherits from           |
         * |________________|___________________________________|
         * |class	        |Object                             |
         * |struct	        |ValueType, Object                  |
         * |enum	        |Enum, ValueType, Object            |
         * |delegate	    |MulticastDelegate, Delegate, Object|
         * |________________|___________________________________|
         * 
         */

        static void Main()
        {
            try
            {
                //A a1 = new A();
                //B b1 = new B();
                //b1.Display();
                //(b1 as A).Display(); //This is How we can call base class method with child class instance;(condition that should not be virtual/overriden)

                //Realtime Examples
                //Example-1
                Publication p1 = new Publication("Publisher 1", "Title 1", PublicationType.Article);
                Book Book1 = new Book("Publisher 2", "Title", "Auther 2");
                Book1.Copyright("Navjyot Gurhale");

                //Example-2
                Square Square1 = new Square(25);
                Console.WriteLine("Square Side:" + Square1.Side);
                Console.WriteLine("Area:" + Square1.Area);
                Console.WriteLine("Parimeter:" + Square1.Parimeter);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally {
                Console.ReadKey();
            }
        }
    }

    public class A
    {
        public string value1 = "Base Public";
        private string value2 = "Base Private";
        protected string value3 = "Base Protected";
        internal string value4 = "Base internal";
        protected internal string value5 = "Base Protected internal";

        public void Display()
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }
    }

    class B : A 
    {
        public string value6 = "Child Public";
        private string value7 = "Child Private";
        protected string value8 = "Child Protected";
        internal string value9 = "Child internal";
        protected internal string value10 = "Child Protected internal";

        //This method is called Method Hiding or Shadowing (Method hiding == shadowing) 
        //Shadowing is a VB concept. In C#, this concept is called hiding.
        //public new void Display() // "new" keyword requied to hide the method else warning
        //or
        new public void Display()
        {
            //base.Display(); //To call base class method in child class method
            Console.WriteLine(value6);
            Console.WriteLine(value7);
            Console.WriteLine(value8);
            Console.WriteLine(value9);
            Console.WriteLine(value10);
        }
    }


    //Real-Time Examples
    //Example-1
    enum PublicationType { Book, Magazine, Article }

    class Publication
    {
        //private bool IsPublished;
        //private DateTime DatePublished;

        public string Publisher { get; private set; }
        public string Title { get; private set; }
        public PublicationType Type { get; private set; }
        public string CopyrightName { get; private set; }

        public Publication(string publisher, string title, PublicationType type)
        {
            if (string.IsNullOrEmpty(publisher))
                throw new ArgumentNullException("The Publisher can't be null");
            else if (string.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("Publisher can't have only whitespace");
            Publisher = publisher;
            
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Title can't be null");
            else if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title can't have only whitespace");
            Title = title;

            Type = type;

        }

        public void Copyright(string copyrightName)
        {
            if (copyrightName == null)
                throw new ArgumentNullException("The name of the copyright holder cannot be null.");
            else if (String.IsNullOrWhiteSpace(copyrightName))
                throw new ArgumentException("The name of the copyright holder cannot consist only of white space.");
            CopyrightName = copyrightName;
        }
    }

    sealed class Book:Publication
    {
        public Decimal Price { get; private set; }
        public string Currency { get; private set; }
        public string Auther { get; private set; }

        public Book(string publisher, string title, string auther)
            : base(publisher, title, PublicationType.Book)//like this you can pass the parameters of constructor to the base class
        {
            if (string.IsNullOrEmpty(auther))
                throw new ArgumentNullException("Auther cannot be null or Empty");
            else if (string.IsNullOrWhiteSpace(auther))
                throw new ArgumentException("Auther Name can not only white-space");
            Auther = auther;
        }

        public Decimal SetPrice(Decimal price, string currency)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException("The price cannot be negative.");
            Decimal oldValue = Price;
            Price = price;

            if (currency.Length != 3)
                throw new ArgumentException("The ISO currency symbol is a 3-character string.");
            Currency = currency;

            return oldValue;
        }
    }

    class Magazine
    {
        //Need Implimentation with Publisher
    }

    class Article
    {
        //Need Implimentation with Publisher
    }
    
    //Example-2
    abstract class shape
    {
        public abstract double Area { get; }
        public abstract double Parimeter { get; }
    }

    class Square : shape
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            if(side<0)
                throw new ArgumentException("Side should be > 0");
            Side=side;
        }

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }

        public override double Parimeter
        {
            get
            {
                return Side * 4;
            }
        }
    }
}
