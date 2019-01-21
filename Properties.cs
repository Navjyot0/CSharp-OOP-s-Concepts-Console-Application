using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /* https://www.c-sharpcorner.com/article/understanding-properties-in-C-Sharp/
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties (Very Imp Must and should refer)
     * 
     * 
     * Properties : 
     * A property in C# is a member of a class that provides a flexible mechanism for classes to expose private fields.
     * Properties can be used as if they are public data members, but they are actually special methods called accessors.
     * his enables data to be accessed easily and still helps promote the safety and flexibility of methods.
     * Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
     * A get property accessor is used to return the property value
     * and a set property accessor is used to assign a new value. These accessors can have different access levels.
     * The value keyword is used to define the value being assigned by the set accessor.
     * Properties can be read-write (they have both a get and a set accessor), read-only (they have a get accessor but no set accessor), or write-only (they have a set accessor, but no get accessor). 
     * Write-only properties are rare and are most commonly used to restrict access to sensitive data.
     * 
     * One basic pattern for implementing a property involves using a private backing field for setting and retrieving the property value. 
     * The get accessor returns the value of the private field, and the set accessor may perform some data validation before assigning a value to the private field.
     * Both accessors may also perform some conversion or computation on the data before it is stored or returned.
     * 
     * 
     * The following example illustrates this pattern. 
     * In this example, the TimePeriod class represents an interval of time. 
     * Internally, the class stores the time interval in seconds in a private field named _seconds. 
     * A read-write property named Hours allows the customer to specify the time interval in hours. 
     * Both the get and the set accessors perform the necessary conversion between hours and seconds. 
     * In addition, the set accessor validates the data and throws an ArgumentOutOfRangeException if the number of hours is invalid.
     * 
     * using System;
     * class TimePeriod
     * {
     *      private double _seconds;
     *      public double Hours
     *      {
     *          get { return _seconds / 3600; }
     *          set { 
     *              if (value < 0 || value > 24)
     *              throw new ArgumentOutOfRangeException(
     *              $"{nameof(value)} must be between 0 and 24.");
     *              _seconds = value * 3600; 
     *          }
     *      }
     * }
     * class Program
     * {
     *      static void Main()
     *      {
     *          TimePeriod t = new TimePeriod();
     *          // The property assignment causes the 'set' accessor to be called.
     *          t.Hours = 24;
     *          // Retrieving the property causes the 'get' accessor to be called.
     *          Console.WriteLine($"Time in hours: {t.Hours}");
     *      }
     * }
     * 
     * // The example displays the following output:
     * // Time in hours: 24
     * 
     * 
     * Expression body definitions
     * 
     * Property accessors often consist of single-line statements that just assign or return the result of an expression. 
     * You can implement these properties as expression-bodied members. 
     * Expression body definitions consist of the => symbol followed by the expression to assign to or retrieve from the property.
     * 
     * 
     * Starting with C# 6, read-only properties can implement the get accessor as an expression-bodied member. 
     * In this case, neither the get accessor keyword nor the return keyword is used. 
     * The following example implements the read-only Name property as an expression-bodied member.
     * 
     * using System;
     * public class Person
     * {
     *      private string _firstName;
     *      private string _lastName;
     *      public Person(string first, string last)
     *      {
     *          _firstName = first;
     *          _lastName = last;
     *      }
     * 
     *      public string Name => $"{_firstName} {_lastName}";   
     * }
     * 
     * public class Example
     * {
     *      public static void Main()
     *      {
     *          var person = new Person("Isabelle", "Butts");
     *          Console.WriteLine(person.Name);
     *      }
     * }
     * // The example displays the following output:
     * // Isabelle Butts
     * 
     * You can create properties like below too...
     * 
     * Example : 
     * 1.
     * public string Name 
     * {
     *      get => _name;
     *      set => _name = value;
     * }
     * 
     * 2. 
     * public decimal Price
     * {
     *    get => _cost;
     *    set => _cost = value; 
     * }
     * 
     * Properties combine aspects of both fields and methods.
     * 
     * 
     */
    class Properties
    {
        private string _firstName, _lastName;

        public Properties(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        //public string Name => $"({_firstName} {_lastName})"; //(C# 7.0)

        public static void Main()
        { 
           
        }
    }
}
