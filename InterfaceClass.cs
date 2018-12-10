using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    interface myInterface 
    {
        // 01
        //public static void Display(string Name) // Cannot be public and static 

        // 02
        //void Display(string Name) // Cant have defination
        //{
        //}

        // 03
        //abstract void Display(string Name); // Cant declare abstrct it's already abstract by default
        
        // 04
        void Display(string Name);
        
        //05
        //Interface also can have properties
        string FirstName { get; set; }
        
        //06
        //Interface can't have variables
        //string LastName; 

    }

    interface FirstInterface
    {
        void sayHello(string Name);
    }

    interface SecondInterface
    {
        void sayHello(string Name);
    }

    class InterfaceClass : myInterface, FirstInterface, SecondInterface // Must have to impliment interface method
    {
        static void Main()
        {
            InterfaceClass IC = new InterfaceClass();
            IC.Display("Navjyot");
            FirstInterface fi = new InterfaceClass();
            fi.sayHello("asd");
            byte s = 255;
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public void Display(string Name)
        {
            Console.WriteLine("Hello " + Name);
        }

        void FirstInterface.sayHello(string Name)
        {
            throw new NotImplementedException();
        }

        void SecondInterface.sayHello(string Name)
        {
            throw new NotImplementedException();
        }

    }
}
