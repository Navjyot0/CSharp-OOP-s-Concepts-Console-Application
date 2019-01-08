using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class DataTypes
    {
        /* ===========Data-Types===========
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
