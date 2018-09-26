using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OOPs
{
    class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class LINQ
    {
        /* ============== What is LINQ? ====================
         * LINQ : Language intergrated Query (LINQ) is uniform query syntax in C# used to retive data from diffrent sources
         * OR
         * LINQ is nothing but collection of extention methods for classes that implements IEnumerable and IQueryable interface
         * 
         * SQL is Structured Query Language used to save and retreive data from a database
         * like same Linq is structrued query syntax used for saving and retriving data from diffrent sources like an object collection, SQL sever collecection, XML etc
         * 
         * ============== Why We Need LINQ? ==================
         * Iterating some conditions through the loops is not easy and efficent its cumbersome, not maintainable and not readable with LINQ this tasks get easier.
         * We can have errors at compile time unlike SP's execution
         * with LINQ code get reduced 
         * Has Intellisence support
         * 
         * ============= LINQ API ==========================
         * LINQ is nothing but collection of extention of methods for class that impliments IEnumerable and IQueryable
         * 
         * ========== 1. IEnumerable ======
         * IEnumerable class includes extention methods for classes that includes IEnumerable<T> interface that includes all collection types 
           Stack<T>, Queue<T>, LinkedList<T> SortedList<T>, List<T>, Dictionary<T>, HashSet<T> 
          
         * Namespace : System.Linq; 
          
         * Extention Methods : 
         * System.Linq.Enumrable.
                                 Aggregate<>
                                 All<>
                                 Any<>
                                 AsEnumerable<>
                                 ...
         * ======== 2. IQueryable =========
         * IQuerable class includes extention methods foe classes that implements IQueryable<T> interface. 
         * from data-source 
         * 
         * Namespace : System.Linq.Qureyable
         *                                  .Aggregate<>
         *                                  .All<>
         *                                  .ANy<>
         *                                  .AsQuerable<>
         *                                  ...
         *                                  
         * =========== LINQ Query Syntax ============
         * 1. Query / Query Expression 
         * 2. Method / Method Expresion / Fluent
         * 
         * 
         */
        static void Main()
        {
            //Simple List<> Data
            List<string> List1 = new List<string>() { "Smith", "John", "Syndy", "Kate", "Mike" };
            ArrayList AL = new ArrayList() { "Smith", 23, "John", 'S', "Syndy", "Kate", "Mike", true, 12.34 };
            //foreach (string s in List1.OrderBy(X => X))
            //    Console.WriteLine(s);

            //List<person> Data
            //List<person> p1 = new List<person>() { new person() { FirstName = "FirstName1", LastName = "LastName3" }, new person() { FirstName = "FirstName2", LastName = "LastName2" }, new person() { FirstName = "FirstName3", LastName = "LastName1" } };
            //foreach (person p in p1.OrderByDescending(x => x.LastName))
            //    Console.WriteLine(p.FirstName + " " + p.LastName);

            //1. Dictionary<>
            //var i = from industry in Industries.AllIndustries where industry.Key.Contains("/") orderby industry.Key descending select industry.Key;
            //foreach (string s in i)
            //    Console.WriteLine(s);

            //2. Dictionary<>
            //foreach (var industry in (from i in Industries.AllIndustries select i))
            //{
            //    Console.WriteLine(industry.Key);
            //    foreach (var subIndustry in industry.Value)
            //        Console.WriteLine(" - " + subIndustry.ToString());
            //}

            //Filtering Operators
            ////1. Where
            //foreach (string s in (from name in List1 where name.StartsWith("S") select name))//Query Syntax
            //    Console.WriteLine(s);
            ////OR 
            //foreach (string s in List1.Where(name => name.StartsWith("S"))) //Method Syntax
            //    Console.WriteLine(s);

            ////2. OfType
            //foreach(string s in (from s1 in AL.OfType<string>() select s1))
            //    Console.WriteLine(s);
            ////or
            //foreach (double s in AL.OfType<double>())
            //    Console.WriteLine(s);

            ////3. OrderBy
            //foreach (string s in (from s1 in List1 orderby s1 select s1))
            //    Console.WriteLine(s);
            //foreach (string s in (from s1 in List1 orderby s1 descending select s1))
            //    Console.WriteLine(s);
            ////or
            //foreach (string s in List1.OrderBy(s1 => s1))
            //    Console.WriteLine(s);
            //foreach (string s in List1.OrderByDescending(s1 => s1))
            //    Console.WriteLine(s);

            ////4. ThenBy
            //foreach (person p in p1.OrderBy(p2=>p2.FirstName).ThenByDescending(p3=>p3.LastName))
            //{
            //    Console.Write(p.FirstName + " ");
            //    Console.WriteLine(p.LastName);
            //}

            Console.ReadKey();
        }
    }
}
