using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    //public
    //protected
    //internal
    //private
    //protected internal


    //A class is a UDT that is composed of field data(member variables) and methods(member functions)
    //that act on this data

    /*<class> <name-of class>{}
     * 
     */
    class sample {
        //fields

        public int a;
    //constructors
    //destructors
    //properties
    //methods
    }

    class student
    {
        public string Name;
        public int RollNo;
        public string ClassName;
    }

    class Class5
    {
        static void Main(string[] args)
        {
            sample s1 = new sample();
            s1.a=6;

            Console.WriteLine(s1.a);

            //<class-name> <object-name>=new <class-Name>()

            student s = new student();
            s.Name = "Ravi";
            s.RollNo = 101;
            s.ClassName = "I";

            Console.WriteLine("Student Details are");
            Console.WriteLine(s.Name);
            Console.WriteLine(s.RollNo);
            Console.WriteLine(s.ClassName);
        }
    }
}
