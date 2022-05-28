using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class3
    {

        //Value Type and Reference Types
        static void Main(string[] args)
        {
            int x=5, y= 6;
            Console.WriteLine("Before Swapping \na=" + x + "  b=" + y);
            Swap(ref x, ref y);
            Console.WriteLine("After Swapping \na=" + x + "  b=" + y);
        }

        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("In Swap Method \na="+a+"  b="+b);
        }
    }
}
