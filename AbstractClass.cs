using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    /*
     * =========== Abstraction ============= 
     * Abstraction is one of the principle of object oriented programming. 
     * It is used to display only necessary and essential features of an object to ouside the world.
     * Means displaying what is necessary and encapsulate the unnecessary things to outside the world.
     * 
     * We cannot create intsance of abstract class/interface
     * 
     * An abstract class can inherit from a class and one or more interfaces.
     * An abstract class can implement code with non-Abstract methods.
     * An Abstract class can have modifiers for methods, properties etc.
     * An Abstract class can have constants and fields.
     * An abstract class can implement a property.
     * An abstract class can have constructors or destructors.
     * An abstract class cannot be inherited from by structures.
     * An abstract class cannot support multiple inheritance.
     */

    //class AbstractClass // Can not have abstract method in non-abstract class but can have non-abstract method in abstact class
    abstract class AbstractClass
    {
        public abstract void addXY(int x, int y);//virtual or abstract methods can't be private(it can be public/protected/interal/Protected-Internal except private).
        //Cannot have body for abstract Method
        //{
        //    Console.WriteLine(x * y);
        //}

        public void Display() // Can have non-abstract Method in abstract class
        {
            
        }
    }
    //Non-abstract class can't have abstract method
    //class Ab1
    //{
    //    public abstract void add111();
    //}

    class AbstractClassMain : AbstractClass
    {
        static void Main()
        {
            //AbstractClass AC = new AbstractClass(); // Can not create instance of Abstract class or Interface
            AbstractClassMain AC = new AbstractClassMain();
            AC.addXY(12, 12);
            Bike bike1 = new Bike();
            bike1.FuelInfo();
            Console.ReadKey();

        }
        //Must have to impliment the abstract method by derived class
        public override void addXY(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }

    //Real-Time Example For Abstraction 

    enum Fuel {Petrol, Diesel, LiquefiedPetroliumGas, CompressedNaturalGas, Ethenol, Biodiesel, NA}

    abstract class Vehicle
    {
        public byte Year { get; set; }
        public string Engine { get; set; }
        public Fuel FuelType { get; set; }
        public string ManufactureCompany { get; set; }

        public abstract void EngineInfo();
        public abstract void FuelInfo();
    }

    class Car:Vehicle
    {
        public override void EngineInfo()
        {
            throw new NotImplementedException();
        }

        public override void FuelInfo()
        {
            throw new NotImplementedException();
        }
    }

    class Bike : Vehicle
    {
        public override void EngineInfo()
        {
            throw new NotImplementedException();
        }

        public override void FuelInfo()
        {
            throw new NotImplementedException();
        }
    }

    class Truck : Vehicle
    {
        public override void EngineInfo()
        {
            throw new NotImplementedException();
        }

        public override void FuelInfo()
        {
            throw new NotImplementedException();
        }
    }

    class Bus : Vehicle
    {
        public override void EngineInfo()
        {
            throw new NotImplementedException();
        }

        public override void FuelInfo()
        {
            throw new NotImplementedException();
        }
    }

    /*
     * When to use Abstract class over Interface?
     * If there is need of method implimentation then Abstract class is importent 
     * but if there is need of multiple inheritance then Interface is importent
     */
}
