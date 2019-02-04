using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /*
     * Dependency Injection 
     * Dependency Injection (DI) is a software design pattern.
     * It allows us to develop loosely-coupled code. 
     * The intent of Dependency Injection is to make code maintainable. 
     * Dependency Injection helps to reduce the tight coupling among software components.
     * DI reduces the hard-coded dependencies among your classes by injecting those dependencies at run time instead of design time technically.
     * 
     * 1. Constructor Injection
     * 2. Property/Setter Injection
     * 3. Method Injection
     * 
     */

    interface IPerson
    {
        void PersonDetails();
    }

    class Employee : IPerson
    {
        public void PersonDetails()
        {
            Console.WriteLine("Employee Details");
        }
    }
    class Customer : IPerson
    {
        public void PersonDetails()
        {
            Console.WriteLine("Customer Details");
        }
    }

    class DependencyInjection
    {
        

        //1. Constructor Injection
        //IPerson p1;
        //public DependencyInjection(IPerson p1)
        //{
        //    this.p1 = p1;
        //}


        //2. Property/Setter Injection
        //public IPerson p1 { get; set; }
        //public void print()
        //{
        //    p1.PersonDetails();
        //}

        //3. Method Injection
        IPerson p1;
        public void print(IPerson person)
        {
            this.p1 = person;
            p1.PersonDetails();
        }
    }

    class DI_Check
    {
        static void Main()
        {
            //1. Constructor Injection
            //DependencyInjection DI = new DependencyInjection(new Customer());
            //OR
            //DependencyInjection DI = new DependencyInjection(new Employee());
            //DI.print();


            //2. Property/Setter Injection
            //DependencyInjection DI = new DependencyInjection();
            //DI.p1 = new Employee();
            //or
            //DI.p1 = new Customer();

            //3. Method Injection
            DependencyInjection DI = new DependencyInjection();
            DI.print(new Employee());
            DI.print(new Customer());
            Console.ReadKey();
        }
    }
}
