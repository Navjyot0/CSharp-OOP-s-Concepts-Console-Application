using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }; // Default its int we can specify that as byte with small size 

    //enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    //Or
    //enum Day { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };


    class Enumeration
    {
        /*
         * https://www.c-sharpcorner.com/UploadFile/puranindia/enums-in-C-Sharp/
         * https://www.c-sharpcorner.com/UploadFile/3d39b4/enumeration-in-C-Sharp/
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/enumeration-types
         * 
         * Enum : 
         * An enumeration type (also named an enumeration or an enum) provides an efficient way to define a set of named integral constants that may be assigned to a variable.
         * For example, assume that you have to define a variable whose value will represent a day of the week. There are only seven meaningful values which that variable will ever store. To define those values, you can use an enumeration type, which is declared by using the enum keyword.
         * By default the underlying type of each element in the enum is int. 
         * 
         * You can specify another integral numeric type by using a colon, as shown in the previous example.
         * 
         * The following are advantages of using an enum instead of a numeric type:
         *      You clearly specify for client code which values are valid for the variable.
         *      In Visual Studio, IntelliSense lists the defined values.
         *      
         * When you do not specify values for the elements in the enumerator list, the values are automatically incremented by 1.
         * It is an alias for the System.Enum class.
         * 
         * Some points about enum
         * Enums are enumerated data type in C#.
         * Enums are not for end-users, they are meant for developers.
         * Enums are strongly typed constants. They are strongly typed, i.e., an enum of one type may not be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
         * Enumerations (enums) make your code much more readable and understandable.
         * enum values are fixed. enum can be displayed as a string and processed as an integer.
         * The default type is int, and the approved types are byte, sbyte, short, ushort, uint, long, and ulong.
         * Every enum type automatically derives from System.Enum and thus we can use System.Enum methods on enums.
         * Enums are value types and are created on the stack and not on the heap.
         * 
         * 
         */

        public void DisplayEnum()
        {
            Console.WriteLine(Day.Monday + " " + (int)Day.Monday);
        }
    }
}