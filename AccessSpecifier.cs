using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class AccessSpecifier
    {
        /* Links :  
         * https://www.c-sharpcorner.com/UploadFile/84c85b/oop-series-sharp2-understanding-access-specifier-with-C-Sharp/
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
         * 
         * ===========Access modifiers or specifiers============
         * Access modifiers and/or specifiers are keywords (private, public, internal, protected and protected internal) to specify the accessibility of a type and its members.
         * C# has 5 access specifier or access modifier keywords; those are 
         * 1. Private
         * 2. Public
         * 3. Internal
         * 4. Protected
         * 5. Protected-Internal.
         * 
         * =========1. private========
         * limits the accessibility of a member to within the defined type, 
         * for example if a variable or a functions is being created in a ClassA and declared as private then another ClassB can't access that.
         * 
         * =========2. public=========
         * has no limits, any members or types defined as public can be accessed within the class, assembly even outside the assembly. 
         * Most DLLs are known to be produced by public class and members written in a .cs file.
         * 
         * =========3. internal=======
         * internal plays an important role when you want your class members to be accessible within the assembly. 
         * An assembly is the produced .dll or .exe from your .NET Language code (C#). 
         * Hence, if you have a C# project that has ClassA, ClassB and ClassC then any internal type and members will become accessible across the classes with in the assembly.
         * 
         * =========4. protected======
         * plays a role only when inheritance is used. 
         * In other words any protected type or member becomes accessible when a child is inherited by the parent. 
         * In other cases (when no inheritance) protected members and types are not visible.
         * 
         * =========5. Protected internal========
         * it is a combination of protected and internal both. 
         * A protected internal will be accessible within the assembly due to its internal flavor and also via inheritance due to its protected flavor.
         * 
         * Note:-
         * The "this" keyword refers to the current instance of the class and accesses its members.
         * In the image above this keyword shows all the available members with the class.
         * By default members of classes are Private.
         * By default classes are Internal.
         * By default namespaces are Public but we are not supposed to specify the public keyword.
         * Namespace will not have access modifier.
         * Default access modifier for class ,struct, Interface, Enum, Delegate is Internal.
         * 
         * Default :-
         * _____________________________________________________________________________
         * |Member      |Default member accessibility   |Allowed Member accessibility   |
         * |____________|_______________________________|_______________________________|
         * |enum        |Public                         |None                           |
         * |____________|_______________________________|_______________________________|
         * |class       |private                        |public, protected, internal,   |
         * |            |                               |private, protected-interal     |
         * |____________|_______________________________|_______________________________|
         * |interface   |public                         |None                           |
         * |____________|_______________________________|_______________________________|
         * |struct      |private                        |public, interal, private       |
         * |____________|_______________________________|_______________________________|
         * 
         * Scope of Access Specifier :-
         * __________________________________________________________________________________________
         * |Access Spicifier      	 | Within class |Derived Class |Outside Class | Within Assembly |   
         * |_________________________|______________|______________|______________|_________________|
         * |Public       	         | Yes      	|Yes    	   |Yes     	  |Yes              |
         * |Private     	         | Yes    	    |No     	   |No     	      |No               |
         * |Protected     	         | Yes     	    |Yes           |No    	      |No               |
         * |Internal    	         | Yes    	    |No   	       |No   	      |Yes              |
         * |Protected Internal     	 | Yes   	    |Yes     	   |No      	  |Yes              |
         * |_________________________|______________|______________|______________|_________________|
         */
        static void Main()
        {
            Console.WriteLine("Access Specifier.");
            Console.ReadKey();
        }
    }
    //private enum Day { Mon, Tue, Wed, Thu, Fri } //Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal
    enum Day { Mon, Tue, Wed, Thu, Fri } //Default access-specifier is public can define as public (but not other, otherwise above error)

    delegate void addition(int num1, int num2, int num3);//default access-specifier Internal

    struct student//default access-specifier Internal
    {
        //default members access-specifier is private
    }

    public class AccessModifier//default Internal
    {
        //default members access-specifier is private

        //Available only to the container Class 
        private string privateVariable;

        //Available in entire assembly across the classes 
        internal string internalVariable;

        //Available in the container class and the derived class   
        protected string protectedVariable;

        //Available to the container class, entire assembly and to outside    
        public string publicVariable;

        //Available to the derived class and entire assembly as well 
        protected internal string protectedInternalVariable;

        private string PrivateFunction()
        {
            return privateVariable;
        }

        internal string InternalFunction()
        {
            return internalVariable;
        }

        protected string ProtectedFunction()
        {
            return protectedVariable;
        }

        public string PublicFunction()
        {
            return publicVariable;
        }

        protected internal string ProtectedInternalFunction()
        {
            return protectedInternalVariable;
        }
    } 
}
