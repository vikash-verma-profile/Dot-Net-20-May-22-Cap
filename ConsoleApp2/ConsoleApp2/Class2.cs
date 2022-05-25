using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class2
    {
        //<return-type> <name-of -function> (<parameters> )
        //body
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a choice what you want to perform \n 1.Add \n 2.Sub ");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter Number 1:");
            //int Number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter Number 2:");
            //int Number2 = Convert.ToInt32(Console.ReadLine());
            //switch (choice)
            //{
            //    case 1:
            //        Sum(Number1,Number2);
            //        break;
            //    case 2:
            //        Sub(Number1, Number2);
            //        break;
            //    default:
            //        break;
            //}
            //Sum(3,4);

            string FullName=GetFullName("Vikash", "Verma");
            Console.WriteLine(FullName);
        }

        static void Sum(int a,int b)
        {
            Console.WriteLine(a+"+"+b+"="+(a+b+1));
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static string GetFullName(string FirstName,string LastName)
        {
            return (FirstName + "-----" + LastName);
        }
    }
}
