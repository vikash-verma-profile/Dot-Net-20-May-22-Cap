using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class Calculator
    {
        public int Number1, Number2;

        public Calculator()
        {

        }
        public Calculator(int num1,int  num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public void Print()
        {
            Console.WriteLine("Number 1="+ Number1);
            Console.WriteLine("Number 2=" + Number2);
        }

        public static Calculator operator *(Calculator c1, Calculator c2)
        {
            //Calculator c3 = new Calculator();
            //c3.Number1 = c1.Number1 + c2.Number1;
            //c3.Number2 = c1.Number2 + c2.Number2;
            return new Calculator() { Number1 = c1.Number1 * c2.Number1, Number2 = c1.Number2 * c2.Number2 };
        }
    }
    class Class2
    {
        public static void Main3()
        {
            Calculator calculator1 = new Calculator(15,20);
            Calculator calculator2 = new Calculator(20,20);
           // Calculator calculator3 = new Calculator();
            var s = calculator1 * calculator2;
            s.Print();
        }
    }
}
