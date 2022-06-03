using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface Isample2
    {

    }
    interface ISample
    {
        void sample();
    }

    class Dummy : ISample, Isample2
    {
        public void sample()
        {
            Console.WriteLine("hI");
        }
    }
    class Class5
    {

        //Interfaces

        //Interface is equivalent to fully abstract class
        //Interface
        //we can implement multiple inhertiance by using interfaces
        //Interface specify what a class must do
        //Interface can't have private members
        //by default all members are public and abstarct
        //interface cannot contain fields because they represent a particular implementation of data
        public static void Main6()
        {

        }
    }
}
