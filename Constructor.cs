using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Constructor
    {

        /*
         * =========Constructor==========
         * It is special type of method which has same name as class and it invokes at creation of object instance creation of class.
         * The Main use of constructor is to initialize the members of class
         * It has same name as Class/Structure name.
         * When you have not created a constructor in the class, the compiler will automatically create a default constructor in the class. 
         * The default constructor initializes all numeric fields in the class to zero and all string and object fields to null. 
         * 
         * ========= Some Key Points ====
         * Constructors must be accsessible or we nighter create Instance nor inherit with other class.
         * In default constructors all Ref types(string/object, etc) are initialized with null and all value types(int, double, etc) are initialized with 0, boolean is initialised with false.
         * If we define constructor (Parametrised/Parameterless) in class default constructor is no more exists in class. ( above statement is still true unless we are not changing them)
         * Everytime when we create object instance constructs fires/executes.
         * If we want multiple instances with same value we can use copy constructor.
         * If class contains any static variable then only implicit static constructors are available or else we need do define them explicitly where as non static constructors are available in every class 
         * In every class static constructors are 1st to execute.
         * Static constructors never be parametrized. So overloading of static constructors is not possible.
         * Class can have any no of Constructor
         * Constructor doesn't have any return type not even void.
         * Within class we can have only one static constructor.
         * static constructor can't have parameter(it should parameterless)
         * 
         * ========= Types of Constructor =======
         * 1. Default/Parameterless Constructor
         * 2. Parametrized/User defined Constructor
         * 3. Static Constructor (it is used to initialize static fields. It gets invoked before crating 1st instance of class and it invokes only once.)
         *           (C# static constructor cannot have any modifier or parameter.)
         *           (C# static constructor is invoked implicitly. It can't be called explicitly.)
         *           (static class can't contain instance constructor)
         * 4. Copy Constructor
         * 5. Private Constructor
         * 
         * ======== 1. Default Constructor ========
         * A constructor without parameter is Default constructor.
         * 
         * Drowback of this is all values are initialised to same value
         * all numeric fields of class to zero
         * and all string and object to null
         * and bool to false
         * 
         * ======= 2. Parametrized Constructor ======
         * Constructor with at least one constructor is parametrized constructor
         * 
         * Advantage of this you can initialise class fields at object creationpassing value;
         * 
         * ======= 3. Copy Constructor =======
         * The constructor which creates an object by copying variables from another object is called a copy constructor.
         * 
         * ======= 4. Static Constructor =======
         * It will be invoked only once for all of instances of the class 
         * It is invoked during the creation of the first instance of the class or the first reference to a static member in the class. 
         * A static constructor is used to initialize static fields of the class and to write the code that needs to be executed only once.
         * A static constructor does not take access modifiers or have parameters.
         * A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
         * A static constructor cannot be called directly.
         * The user has no control on when the static constructor is executed in the program.
         * A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
         * 
         * ======= 5. Private Constructor ======
         * When a constructor is private, it is not possible for other classes to derive from this class, 
         * neither is it possible to create an instance of this class. 
         * They are usually used in classes that contain static members only.
         * It provides an implementation of a singleton class pattern
         * Once we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class.
         * 
         */

        public bool flag;
        public string Name;
        public int i;
        public double dbl;
        public float flt;
        public object obj1;
        public string s;
        public bool b;
        //Default Constructor
        //public Constructor()
        //{
        //    Console.WriteLine("===Default Constructor===");
        //}

        //Parametrised Constructor
        public Constructor(int i, string s, bool b)
        {
            //i = 10;
            //s = "Name";
            //b = true;//default value of bool is false
            this.i = i;
            this.s = s;
            this.b = b;
            Console.WriteLine("===Parametrised Constructor===");
            Console.WriteLine("int:" + this.i + "\nstring:" + this.s + "\nbool:" + this.b);
        }

        //Copy Constructor
        public Constructor(Constructor C1)
        {
            this.i = C1.i;
            this.s = C1.s;
            this.b = C1.b;
            Console.WriteLine("===Copy Constructor===");
            Console.WriteLine("int:" + this.i + "\nstring:" + this.s + "\nbool:" + this.b);
        }

        //public static Constructor() //access modifiers(by default:public) are not allowed on static constructors
        static Constructor()
        {
            Console.WriteLine("===Static Constructor===");
        }

        //Private Constructor
        private Constructor()
        {
            Console.WriteLine("===Private Constructor===");
            //We can not call this create instance of class in other class id constructor is private.
            //We can create intance in the same class
        }

        static void Main()
        {
            Constructor obj = new Constructor();
            Console.WriteLine(obj.obj1);
            Console.WriteLine(obj.flag);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.i);
            Console.WriteLine(obj.dbl);
            Console.WriteLine(obj.flt);
            Constructor obj1 = new Constructor(20, "23", false);
            Constructor obj2 = new Constructor(obj1);
            Console.ReadKey();
        }
    }

    class ConstructorTest //: Constructor
    /*
     * We can not inherit class from other class if constructor is private
     */
    { 
        public void Method1()
        {
            //Constructor c1 = new Constructor();
            /*
             * We can not craete instance of class in other class if constructor is private 
             * although we can create instance in the same class
             */
        }
    }
}
