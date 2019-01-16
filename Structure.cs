using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class Structure
    {
        /*
         * https://docs.microsoft.com/en-us/dotnet/csharp/structs
         * 
         * Structs : 
         * A Struct is value type
         * When a struct is created, the variable to which the struct is assigned holds the struct's actual data.
         * When the struct is assigned to a new variable, it is copied. 
         * The new variable and the original variable therefore contain two separate copies of the same data. 
         * Changes made to one copy do not affect the other copy.
         * 
         * Value type variables directly contain their values, which means that the memory is allocated inline in whatever context the variable is declared. 
         * There is no separate heap allocation or garbage collection overhead for value-type variables.
         * There are two categories of value types: struct and enum.
         * 
         * Value types are sealed you cannot define a struct to inherit from any user-defined class or struct because a struct can only inherit from ValueType
         */
    }

    interface Person
    {
        void getPersonDetailsByID(int Id);
        void FindPersonDetailsByName(string Name);
    }

    struct Student : Person // Structure can be inherited with interface only 
    {
        private string Name; // variables are allowed

        public int StudentID { get; set; } // Properties are allowed

        public void Display() // Method is also allowed
        {
            Console.WriteLine("Display Method");
        }

        public void getPersonDetailsByID(int Id)
        {
            throw new NotImplementedException();
        }

        public void FindPersonDetailsByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}