using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Switch
            //{}==>block
            //
            Console.Write("Enter Some Value:");

            //int s = Convert.ToInt32(Console.ReadLine());
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //Console.WriteLine("Value recieved from user:-  "+(Convert.ToInt32(s1) + Convert.ToInt32(s2)));

            int choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hi I am Case 1");
                    break;
                default:
                    Console.WriteLine("Hi I am Default Case");
                    break;
            }
        }
    }
}
