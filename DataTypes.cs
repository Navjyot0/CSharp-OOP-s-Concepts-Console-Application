using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class DataTypes
    {
        /* ===========Data-Types===========
         * 
         * Reference Links:
         * https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
         * 
         * Types And Variables:-
         * There are two Kinds of Types in C#.
         * 1. Value type (Variables of value types value type contains their data) 
         * 2. Reference type (where as variables of refernece types strore refrences to their data)
         * 
         * With Reference type it is possible for two variables to refrence the same object and thus possible for operations on one variable to affect the object referenced by other variable
         * With value types, the variables each have their own copy of the data, and it is not possible for operations on one to affect the other (except in the case of ref and out parameter variables).
         * 
         * C# value types are further divided into 
         * 1. Simple Type
         * 2. enum type
         * 3. struct type
         * 4. nullable value type
         * 
         * And Refrence Type Divide into 
         * 1. Class Types
         * 2. Interface Types
         * 3. Array Types
         * 4. Delegate Types
         * 
         * C# Type System
         * 
         * 1. Value Type
         * |_1. Simple Type
         * |         |_Signed Integral (sbyte, short, int, long)
         * |         |_Unsigned Integral (byte, ushort, uint, ulong)
         * |         |_Unicode Characters (char)
         * |         |_IEEE Floating Point (float, double)
         * |         |_High Precision decimal (decimal)
         * |         |_Boolean (bool)
         * |
         * |_2. Enum Type
         * |         |_User defined type of form (enum E{...})
         * |
         * |_3. Struct Type
         * |         |_User defined type of form (Struct S {...})
         * |
         * |_4. Nullable value Type
         *           |_Extention for all other value Types with a null value
         *  
         * 2. Refrence Type
         * |_1. Class types
         * |         |_Ultimate base class of all other types: object
         * |         |_Unicode strings: string
         * |         |_User-defined types of the form class C {...}
         * |
         * |_2. Interface types
         * |         |_User-defined types of the form interface I {...} 
         * |
         * |_3. Array types
         * |         |_Single- and multi-dimensional, for example, int[] and int[,]
         * |_4. Delegate types
         *           |_User-defined types of the form delegate int D(...)
         *           
         * The eight integral types provide support for 8-bit, 16-bit, 32-bit, and 64-bit values in signed or unsigned form.
         * The two floating-point types, float and double, are represented using the 32-bit single-precision and 64-bit double-precision respectively
         * The decimal type is a 128-bit data type suitable for financial and monetary calculations.
         * C#'s bool type is used to represent Boolean values—values that are either true or false.
         * Character and string processing in C# uses Unicode encoding. The char type represents a UTF-16 code unit, and the string type represents a sequence of UTF-16 code units.
         * 
         * This summarizes C#’s numeric types.
         * 
         * Signed Integral
         *      sbyte: 8 bits, range from -128 - 127
         *      short: 16 bits, range from -32,768 - 32,767
         *      int : 32 bits, range from -2,147,483,648 - 2,147,483,647
         *      long : 64 bits, range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
         * 
         * Unsigned integral
         *      byte : 8 bits, range from 0 - 255
         *      ushort : 16 bits, range from 0 - 65,535
         *      uint : 32 bits, range from 0 - 4,294,967,295
         *      ulong : 64 bits, range from 0 - 18,446,744,073,709,551,615
         * 
         * Floating point
         *      float : 32 bits, range from 1.5 × 10−45 - 3.4 × 1038, 7-digit precision
         *      double : 64 bits, range from 5.0 × 10−324 - 1.7 × 10308, 15-digit precision
         * 
         * Decimal
         *      decimal : 128 bits, range is at least –7.9 × 10−28 - 7.9 × 1028, with at least 28-digit precision
         * 
         * C# programs use type declarations to create new types. A type declaration specifies the name and the members of the new type. 
         * Five of C#’s categories of types are user-definable: class types, struct types, interface types, enum types, and delegate types.
         * 
         * A class type defines a data structure that contains data members (fields) and function members (methods, properties, and others). 
         * Class types support single inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.
         * 
         * A struct type is similar to a class type in that it represents a structure with data members and function members. 
         * However, unlike classes, structs are value types and do not typically require heap allocation. 
         * Struct types do not support user-specified inheritance, and all struct types implicitly inherit from type object.
         * 
         * An interface type defines a contract as a named set of public function members. 
         * A class or struct that implements an interface must provide implementations of the interface’s function members. 
         * An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.
         * 
         * A delegate type represents references to methods with a particular parameter list and return type. 
         * Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters. 
         * Delegates are analogous to function types provided by functional languages. 
         * They are also similar to the concept of function pointers found in some other languages, but unlike function pointers, delegates are object-oriented and type-safe.
         * 
         * The class, struct, interface and delegate types all support generics, whereby they can be parameterized with other types.
         * 
         * An enum type is a distinct type with named constants. Every enum type has an underlying type, which must be one of the eight integral types. 
         * The set of values of an enum type is the same as the set of values of the underlying type.
         * 
         * C# supports single- and multi-dimensional arrays of any type. Unlike the types listed above, array types do not have to be declared before they can be used. 
         * Instead, array types are constructed by following a type name with square brackets. For example, int[] is a single-dimensional array of int, int[,] is a two-dimensional array of int, and int[][] is a single-dimensional array of single-dimensional array of int.
         * 
         * Nullable value types also do not have to be declared before they can be used. 
         * For each non-nullable value type T there is a corresponding nullable value type T?, which can hold an additional value, null. 
         * For instance, int? is a type that can hold any 32-bit integer or the value null
         * 
         * C#’s type system is unified such that a value of any type can be treated as an object. 
         * Every type in C# directly or indirectly derives from the object class type, and object is the ultimate base class of all types. 
         * Values of reference types are treated as objects simply by viewing the values as type object. 
         * Values of value types are treated as objects by performing boxing and unboxing operations. 
         * In the following example, an int value is converted to object and back again to int.
         * 
         * Example :-
         * using System;
         * class BoxingExample
         * {
         *  static void Main()
         *  {
         *      int i = 123;
         *      object o = i;    // Boxing
         *      int j = (int)o;  // Unboxing
         *  }
         * }
         * 
         * 
         * 
         * Some Special :-
         * 
         * Types of Datatype:
         * 1. Value Type (Stack Memory) (Predefined:int/double/float/bool)(UserDefined:Struct/Enum) (this type directly contains their data where variable of ref type store there ref of data)
         * 2. Reference Type (Heap Memory) (Predefined:strings/objects)(UserDefined:Class/Interface)
         * 3. Pointer Type
         * 
         * Boxing/Unboxing:
         * Boxing is process of converting a value type to object or any interface type by this value type.
         * When CLR boxes a value type, it wraps the value inside a System.Object and stores it on managed heap.
         * Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit. 
         * The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.
         * For the unboxing of value types to succeed at run time, the item being unboxed must be a reference to an object that was previously created by boxing an instance of that value type. 
         * According to performance it is good to avoid Boxing/Unboxing.(More than 20% uneficient)
         * 
         * Type-Casting:
         * Typecasting is possible only if two datatypes are compatible and smaller size datatype is converted in to bigger datatype
         * 1. Implicit type conversion − These conversions are performed by C# in a type-safe manner. For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.
         * 2. Explicit type conversion − These conversions are done explicitly by users using the pre-defined functions. Explicit conversions require a cast operator.
         * 
         * Why Boolean is not 1-bit? why it is 8-bit?
         * 
         * 
         * Difference between Boxing/Unboxing and Type-Casting?
         * Boxing/Unboxing is Implicit while Type-casting is External
         * Boxing/Unboxing need value type for changing.
         *  ____________________________________________________________________________________________________________________________________
            |Alias	 |.NET Type	|Type	                               | Size (bits)|Range (values)                                             |
            |________|__________|______________________________________|____________|___________________________________________________________|
            |byte	 |Byte	    |Unsigned integer	                   | 8(1 byte)	| 0 to 255                                                  |
            |sbyte	 |SByte	    |Signed integer	                       | 8(1 byte)  | -128 to 127                                               |
            |int	 |Int32	    |Signed integer	                       | 32(4 byte) | -2,147,483,648 to 2,147,483,647                           |
            |uint	 |UInt32	|Unsigned integer	                   | 32(4 byte) | 0 to 4294967295                                           |
            |short	 |Int16	    |Signed integer	                       | 16(2 byte) | -32,768 to 32,767                                         |
            |ushort	 |UInt16	|Unsigned integer	                   | 16(2 byte) | 0 to 65,535                                               |
            |long	 |Int64	    |Signed integer	                       | 64(8 byte) | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807   |
            |ulong	 |UInt64	|Unsigned integer	                   | 64(8 byte) | 0 to 18,446,744,073,709,551,615                           |
            |float	 |Single	|Single-precision floating point type  | 32(4 byte) | -3.402823e38 to 3.402823e38                               |
            |double	 |Double	|Double-precision floating point type  | 64(8 byte) | -1.79769313486232e308 to 1.79769313486232e308             |
            |char	 |Char	    |A single Unicode character	           | 16(2 byte) | Unicode symbols used in text                              |
            |bool	 |Boolean	|Logical Boolean type	               | 8(1 byte)  | True or False                                             |
            |object	 |Object	|Base type of all other types		   |            |                                                           |
            |string	 |String	|A sequence of characters		       |            |                                                           |
            |decimal |Decimal	|Precise fractional or integral type   |128(16byte) | (+ or -)1.0 x 10e-28 to 7.9 x 10e28                       |
            |        |          |that can represent decimal numbers    |            |                                                           |      
            |        |          |with 29 significant digits	           |            |                                                           |
            |DateTime|DateTime	|Represents date and time		       | 0:00:00am  | 1/1/01 to 11:59:59pm 12/31/9999                           |
            |________|__________|______________________________________|____________|___________________________________________________________|
         * 
         * Type-safety in C#?
         * 
         * How to manage overflow of integer?
         * Not sure of ans but May be(try catch and exception of overflow)
         * Can use if-else with size condition 
         *
         *
         */

        static void Main()
        {
            int i = 333;
            object o = i;//(boxing)
            i = (int)o;//(unboxing)

            //byte s1 = 333;//Constant value '333' cannot be converted to a 'byte';
            byte s1=(byte)i;// will reset and start again at multiple of 256 after range;
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
