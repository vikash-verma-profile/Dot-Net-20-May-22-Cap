using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class AA
    {
        public void PrintA()
        {
            Console.WriteLine("Hi i a from class AA");
        }
    }
    class BB:AA
    {
        public void PrintB()
        {
            Console.WriteLine("Hi i a from class BB");
        }
    }
    class CC:BB
    {
        public void PrintC()
        {
            Console.WriteLine("Hi i a from class CC");
        }
    }
    class Class11
    {
        public static void Main()
        {
            CC c = new CC();
            c.PrintA();
            c.PrintB();
            c.PrintC();
        }
    }

    class ABA
    {

    }
    class ABC
    {

    }
    class BCA : ABA
    {

    }
}
