using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{
    class IComparable_IComparer_DelegateCompare
    {
        public static int CompareByName(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
        static void Main()
        {
            Student s1 = new Student { Sid = 101, Name="Ross", Class=10, Marks=91.3f};
            Student s2 = new Student { Sid = 102, Name = "Joye", Class = 11, Marks = 50.3f };
            Student s3 = new Student { Sid = 103, Name = "Chandler", Class = 9, Marks = 80.3f };
            Student s4 = new Student { Sid = 104, Name = "Monica", Class = 8, Marks = 98.3f };
            List<Student> StudentsList = new List<Student>() { s1, s2, s3, s4 };
            
            //Console.WriteLine("===========IComparable========");
            //StudentsList.Sort(); // Directly It gives error as ambugity in sorting parameter so need to Intrface IComparable
            //foreach (Student s in StudentsList)
            //    Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);
            
            //Console.WriteLine("===========IComparer==========");
            //sortStudentbyMarks obj = new sortStudentbyMarks();
            //StudentsList.Sort(obj);
            //foreach (Student s in StudentsList)
            //    Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);
            
            Console.WriteLine("===========Delegate==========");
            //Comparison<Student> obj = new Comparison<Student>(IComparable_IComparer.CompareByName);
            //StudentsList.Sort(obj);
            // Or You can call directly 
            //StudentsList.Sort(CompareByName);//Internally Comparison delegate obj is created 
            //Or can call with Anonymous Method
            //StudentsList.Sort(delegate(Student stu1, Student stu2) {
            //    return s1.Name.CompareTo(s2.Name);
            //});
            //Or Can use Lambda Expresion
            StudentsList.Sort((stu1, stu2) =>s1.Name.CompareTo(s2.Name));
            foreach (Student s in StudentsList)
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);

            Console.ReadKey();
        }
    }

    class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)//Interface must implement method
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }

    class sortStudentbyMarks : IComparer<Student>
    {
        public int Compare(Student x, Student y)//Interface must implement method
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
