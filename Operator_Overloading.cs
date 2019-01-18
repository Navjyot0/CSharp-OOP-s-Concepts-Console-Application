using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /* https://www.c-sharpcorner.com/article/operator-overloading-in-C-Sharp2/ //(Please Refer Link)
     * 
     * Operator Overloading :-
     * All unary and binary operators have pre-defined implementations, that are automatically available in any expressions.
     * In addition to this pre-defined implementations, user defined implementations can also be introduced in C#.
     * The mechanism of giving a special meaning to a standard C# operator with respect to a user defined data type such as classes or structures is known as operator overloading.
     * Remember that it is not possible to overload all operators in C#.
     * In C#, a special function called operator function is used for overloading purpose.
     * [These special function or method must be public and static and They can take only value arguments.]
     * [The ref and out parameters are not allowed as arguments to operator functions.]
     * The general form of an operator function is as follows. 
     * 
     * Syntax : public static return_type operator Operator_Name (argument list)
     * 
     * For Overloading the unary operator, there is only 1 argument. and for overloading a binary operator there are two arguments.
     * [Remember that at least one of the arguments must be a user-defined type such as class or struct type.]
     * 
     * The general form of operator function for unary operators is as follows. 
     * 
     * public static return_type operator op (Type t)
     * {
     * // Statements
     * }
     * 
     * Where Type must be a class or struct.
     * 
     * [The return type can be any type except void for unary operators like +, ~, ! and dot (.) but the return type must be the type of 'Type' for ++ and - operators and must be a bool type for true and false operators. 
     * Also remember that the true and false operators can be overloaded only as pairs. The compilation error occurs if a class declares one of these operators without declaring the other.]
     * 
     * 
     * 
     * ____________________________
     * Operators (Overloadability)
     * ____________________________
     * +, -, *, /, %, &, |, <<, >>	(All C# binary operators can be overloaded).
     * +, -, !,  ~, ++, --, true, false	(All C# unary operators can be overloaded).
     * ==, !=, <, >, <= , >=	(All relational operators can be overloaded, but only as pairs).
     * &&, ||	(They can't be overloaded).
     * [] (Array index operator)	(They can't be overloaded).
     * () (Conversion operator)	(They can't be overloaded).
     * +=, -=, *=, /=, %=	(These compound assignment operators can be overloaded. But in C#, these operators are automatically overloaded when the respective binary operator is overloaded).
     * =, . , ?:, ->, new, is, as, sizeof	(These operators can't be overloaded in C#).
     * 
     */
    class Matrix
    {
        int a, b, c, d;

        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix obj;
            return obj = new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
        }

        public static Matrix operator ++(Matrix M1)
        {
            return new Matrix(M1.a + 1, M1.b + 1, M1.c + 1, M1.d + 1);
        }

        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "" + "\n";
        }
    }

    class Operator_Overloading
    {
        public static void Main()
        {
            Matrix M1 = new Matrix(12, 14, 24, 34);
            Matrix M2 = new Matrix(22, 34, 44, 54);
            Matrix M3 = M1 + M2;

            Console.WriteLine(M1.ToString());
            Console.WriteLine(M2.ToString());
            Console.WriteLine(M3.ToString());

            M3++;

            Console.WriteLine(M3.ToString());
        }
    }
}
