using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //<data-type>  <variable-name>
            int a=5;
            int b = 5;
            //string name = "Vikash Verma";
            //Console.WriteLine(name);
            //Console.Write(a+b);
            // Console.Write(a);


            //whether a number is positive or not
            int positiveNumber = 0;
            Console.WriteLine();
            if (positiveNumber > 0)
            {
                Console.WriteLine(positiveNumber +" is a positive Number");
            }
            else if(positiveNumber<0)
            {
                Console.WriteLine(positiveNumber + " is not a positive Number");
            }
            else
            {
                Console.WriteLine(positiveNumber + " is neither postive nor negative");
            }
        }
    }
}
