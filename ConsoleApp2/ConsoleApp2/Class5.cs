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
        /*
         * private constructor
         * default constructor
         * Parameterzied Constructor
         * Copy Constructor
         * static Constructor
         */
        //destructors
        //properties
        //methods
    }

    class student
    {
        private string Name;
        private int RollNo;
        private string ClassName;
        private string SchoolName;

        //<access-modifier> <class-name> (<parameters>)
        public student()
        {
            SchoolName = "Kendriya Vidyalaya";
        }

        //~ <class-name>()
        //get Input from User
        ~student()
        {

        }
        //Methods in a class
        public void GetData()
        {
            Console.WriteLine("Please enter Student Details");
            Console.WriteLine("Please enter Student Name");
            Name = Console.ReadLine(); 
            Console.WriteLine("Please enter Student Roll Number");
            RollNo = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter Student ClassName");
            ClassName = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Student Details are");
            Console.WriteLine(Name);
            Console.WriteLine(RollNo);
            Console.WriteLine(ClassName);
            Console.WriteLine(SchoolName);
        }
    }

    class Class5
    {
        static void Main5(string[] args)
        {
            //sample s1 = new sample();
            //s1.a=6;

            //Console.WriteLine(s1.a);

            //<class-name> <object-name>=new <class-Name>()

            //student s = new student();
            //s.GetData();
            //s.PrintData();
            //student s1 = new student();
            //s1.GetData();
            //s1.PrintData();

            //student s = new student();
            //s.ClassName = 4;
            //array of objects
            
            student[] studentlist = new student[2];
            for (int i = 0; i < studentlist.Length; i++)
            {
                student s = new student();
                s.GetData();
                studentlist[i] = s;
            }

            for (int i = 0; i < studentlist.Length; i++)
            {
                studentlist[i].PrintData();            
            }

        }
    }
}
