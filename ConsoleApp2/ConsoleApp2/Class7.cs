using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    //That class cannot be inherit
    //Members inside a static class should be static only
    static class StaticClass
    {
        public static string Topic = "Static Class";

       // public string sample;
    }

    class StaticVariable
    {
        public static string Topic = "Static Variable";

        public static void Sample()
        {
            Console.WriteLine("Static Method");
        }
    }

    //static COnstructor
    /*
     * it can't be called directly
     * when it is executing then we have no control
     * it does not take access mofifiers or any parameter
     * it is called automatically to initialze the class before the first instance increated
     */
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("I am coming from static constructor");
        }
        public StaticConstructor()
        {
            Console.WriteLine("Hi ");
        }
    }

    class Class7
    {
        //static is a modifier in c# which we use 

        /*
         * class
         * variables
         * Methods
         * Constructors
         */
        public static void Main()
        {
            //Console.WriteLine(StaticVariable.Topic);
            //StaticVariable.Sample();

            StaticConstructor s = new StaticConstructor();



        }
    }
}
