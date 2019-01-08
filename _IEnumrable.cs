using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class _IEnumrable
    {
        /*Ref :
         * 1. https://www.c-sharpcorner.com/UploadFile/0c1bb2/ienumerable-interface-in-C-Sharp/
         * 2. https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=netframework-4.7.2
         * 
         * 
         * IEnumerable in C#
         * 
         * Namespace: System.Collections
         * Assemblies: System.Runtime.dll, mscorlib.dll, netstandard.dll
         * 
         * IEnumerable interface is one of the best feature of C# language which loop over the collection
         * Many times there is need to loop through collection of classes or list which are anonymous types, IEnumerable is one of the best feature of C# language which loop over the collection.
         * 
         * What is IEnumerable Interface?
         * IEnumerable is an interface that defines one method GetEnumerator Which return an IEnumerator interface. 
         * This allows readonly access to collection that implements IEnumerable can be used with a for-each statement.
         * 
         * Key-Points
         * IEnumerable interface present in System.Collections.Generic namespace
         * IEnumerable interface is Generic Interface which allows to loop through both generic and non-generic list.
         * IEnumerable interface returns an enumerator that iterates throught the collection.
         * IEnumerable interface also works with LINQ Query Expression.
         * IEnumerable interface returns an enumerator that iterats through the collection.
         * 
         * 
         * Methods of IEnumerator
         * 1. Current() [Gets/Returns the current element in the collection.]
         * 2. Reset() [Sets the enumerator to its initial position, which is before the first element in the collection.]
         * 3. MoveNext() [Sets the enumerator to the next element of the collection, it Returns true if the enumerator was successfully set to the next element and false if the enumerator has ed the end of the collection]
         * 
         * IEnumerable vs IEnumerator interface
         * While reading these two names, it's too confusion happens in mind so let us understand the difference between these two 
         * IEnumerable and IEnumerator are both interfaces.
         * IEnumerable has just one method called GetEnumerator. This method returns another type which is an interface that interface is IEnumerator.
         * if wants to implement enumerator logic in any of collection class, it needs to implement IEnumerable interface (either generic or non-generic).
         * IEnumerable has just one method whereas IEnumerator has two methods (MoveNext and Reset) and a property Current.
         * 
         * For our understanding, we can say that  IEnumebale is a  box that contains IEnumerator inside it.
         * 
         * 
         * GetEnumerator()
         * 
         * 
         */
    }


    class _IEnumerableClass : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    //In the above example, you have seen that after implementing the IEnumerable Interface there is method called GetEnumerator along with interface IEnumerator which helps to get current element from the collection.

    class _IEnumeratorClass : IEnumerator<int>
    {


        public int Current
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    //In the above class we have implemented the IEnumerator interface which shows the above methods and property as we have already explained.


    public class Customer
    {
        private string _Name, _City;
        private long _Mobile;
        private double _Amount;

        public string Name
        {
            get { return _Name; }
            set { this._Name = value; }
        }

        public string City
        {
            get { return _City; }
            set { this._City = value; }
        }

        public long Mobile
        {
            get { return _Mobile; }
            set { this._Mobile = value; }
        }

        public double Amount
        {
            get { return _Amount; }
            set { this._Amount = value; }
        }
    }

    class Main_IEnumerableClass
    {
        Customer[] C1 = new Customer[] 
        { 
            new Customer{Name="Navjyot Gurhale", Amount=1233.9, City="Pune", Mobile=9913344567},
            new Customer{Name="Netaji Jadhav", Amount=5433.9, City="Mumbai", Mobile=9913000000},
            new Customer{Name="Nitin Kulkarni", Amount=8888.9, City="Hyderabad", Mobile=9999000000},
            new Customer{Name="Shekhar Kashid", Amount=9999.9, City="Bangalore", Mobile=9999000000}
        };

        static void Main()
        {
            //Main_IEnumerableClass obj = new Main_IEnumerableClass();
            //foreach (var c in obj.GetAllCustomers())
            //{
            //    Console.WriteLine("Name : " + c.Name);
            //    Console.WriteLine("City : " + c.City);
            //    Console.WriteLine("======================");
            //}

            IEnumerable_Person[] peopleArray = new IEnumerable_Person[3]
            {
                new IEnumerable_Person("John", "Smith"),
                new IEnumerable_Person("Jim", "Johnson"),
                new IEnumerable_Person("Sue", "Rabon"),
            };
            IEnumerable_People peopleList = new IEnumerable_People(peopleArray);
            foreach (IEnumerable_Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
            Console.ReadKey();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return C1;
        }
    }

    class IEnumerable_Person
    {
        public string firstName, lastName;
        public IEnumerable_Person(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }
    }

    class IEnumerable_People : IEnumerable<IEnumerable_Person>
    {
        private IEnumerable_Person[] _People;
        public IEnumerable_People(IEnumerable_Person[] pArray)
        {
            _People = new IEnumerable_Person[pArray.Length];
            for(int i=0; i<pArray.Length; i++)
            {
                _People[i] = pArray[i];   
            }
        }


        public IEnumerable_PeopleEnum GetEnumerator()
        {
            return new IEnumerable_PeopleEnum(_People);
        }

        IEnumerator<IEnumerable_Person> IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEnumerable_Person>)GetEnumerator();
        }
    }

    class IEnumerable_PeopleEnum : IEnumerator
    {
        public IEnumerable_Person[] _people;

        int position = -1;

        public IEnumerable_PeopleEnum(IEnumerable_Person[] list)
        {
            _people = list;
        }

        public object Current
        {
            get 
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
