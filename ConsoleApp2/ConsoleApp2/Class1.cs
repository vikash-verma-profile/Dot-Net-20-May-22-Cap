using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[][] jaggged_array=new int[][] 
            { 
                new int[] { 1,2},
                new int[] { 1,2,3,4,5},
                new int[] { 1,2,3,4,5,6,7,8},
                new int[] { 1,2,3,4,5,6,7,8,9,10}
            };

            for (int i = 0; i < jaggged_array.Length; i++)
            {
                for (int j = 0; j < jaggged_array[i].Length; j++)
                {
                    Console.Write(jaggged_array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
