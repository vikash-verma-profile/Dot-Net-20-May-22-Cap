using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4
    {
        public static void Main()
        {
            int[] ar = new int[5];

            int[] ar1 = new int[] { 1, 2, 3, 4, 5 };


            int n = 5;
            int[] ar3 = new int[n];


            //Console.WriteLine(ar1[2]);
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            string name = "vikash";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
