using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Generics
    {
        public static bool Compaire<T>(T num1, T num2)
        {
            dynamic d1 = num1;
            dynamic d2 = num2;
            if (d1 == d2)
                return true;
            return false;
        }

        static void Main()
        {
            try
            {
                //Console.WriteLine(Compaire<int>(10, 10));
                //Console.WriteLine(Compaire<int>(10, 10));
                //myGenericType<int>.Add(100, 20);
                //myGenericType<int>.Sub(100, 20);
                //myGenericType<int>.Mul(100, 20);
                //myGenericType<int>.Div(100, 20);

                List<Customer> Customer = new List<Customer>();

                Customer c1 = new Customer { Id = 101, Name = "Scott", Salary = 12200, Locaion = "Pune" };
                Customer c2 = new Customer { Id = 102, Name = "John", Salary = 42200, Locaion = "Hyderabad" };
                Customer c3 = new Customer { Id = 103, Name = "Syndy", Salary = 52200, Locaion = "Delhi" };
                Customer c4 = new Customer { Id = 104, Name = "Mark", Salary = 92200, Locaion = "Mumbai" };

                Customer.Add(c1);
                Customer.Add(c2);
                Customer.Add(c3);
                Customer.Add(c4);

                foreach (Customer c in Customer)
                    Console.WriteLine(c.Id + "|" + c.Name + "|" + c.Salary + "|" + c.Locaion);

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

    class myGenericType<T>
    {
        public static void Add(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num2;
            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2));
        }

        public static void Sub(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num2;
            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));
        }

        public static void Mul(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num2;
            Console.WriteLine(n1 + "*" + n2 + "=" + (n1 * n2));
        }

        public static void Div(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num2;
            Console.WriteLine(n1 + "/" + n2 + "=" + (n1 / n2));
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Locaion { get; set; }
    }
}
