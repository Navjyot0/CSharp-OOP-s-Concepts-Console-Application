using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace OOPs
{
    /*
     * Collection 
     * Arrays are simple data-structure used to store data items of specific type.
     * Collection is prepackaged data-structure that provides greater facilities than traditional Arrays
     * System.Collections
     * 1. Stack
     * 2. Queue
     * 3. LinkedList
     * 4. SortedList
     * 5. ArrayList (Mostly Used)
     * 6. HashTable
     */
    class Collection
    {
        static void stackTest()
        {
            Stack Stack = new Stack();
            Stack.Push(12);
            Stack.Push("Tom");
            Stack.Push(true);
            Stack.Push(12000.23);

            foreach (object s in Stack)
            {
                Console.WriteLine(s.ToString());
            }
        }

        static void queueTest()
        {
            Queue Queue = new Queue();
            Queue.Enqueue(12);
            Queue.Enqueue("Tom");
            Queue.Enqueue(true);
            Queue.Enqueue(12000.23);

            foreach (object s in Queue)
            {
                Console.WriteLine(s.ToString());
            }
        }

        static void sortedListTest()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("ID", 101); 
            sortedList.Add("Name", "Tom");
            sortedList.Add("Active", true);
            sortedList.Add("Salary", 12000.34);

            foreach (object obj in sortedList.Values)
                Console.WriteLine(obj.ToString());
        }

        static void linkedListTest()
        {
            LinkedList<string> ll=new LinkedList<string>();
            ll.AddFirst("Navjyot");
            Console.WriteLine(ll);
        }

        static void arrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("Tom");
            arrayList.Add(true);
            arrayList.Add(12000.23);

            foreach (object s in arrayList)
            {
                Console.WriteLine(s.ToString());
            }
        }

        static void Main()
        {
            //stackTest();
            //queueTest();
            //sortedListTest();
            //arrayList();
            linkedListTest();
            Console.ReadKey();
        }
    }
}
