using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /*
      * private constructor
      * default constructor
      * Parameterzied Constructor
      * Copy Constructor
      * static Constructor
      */

    class SampleClass
    {
        private int a;
        private int b;

        //default 
       //public SampleClass()
       // {

       // }
       // //parameterized
       // public SampleClass(int _a)
       // {
       //     a = _a;
       // }

        public SampleClass() { }

        //A Constructor that create an object by coping variables from another object or that copies that data
        //from one object into another object


        //Copy Constructor
        public SampleClass(SampleClass c)
        {
            a = c.a;
            b = c.b;
        }

        public void SetValue(int _a)
        {
            a = _a;
        }
        public void printValue()
        {
            Console.WriteLine(a);
        }
    }
    class Class6
    {
        public static void Main6()
        {
            SampleClass S = new SampleClass();
            S.SetValue(1);
            SampleClass S1 = new SampleClass(S);
            S1.printValue();
        }
    }
}
