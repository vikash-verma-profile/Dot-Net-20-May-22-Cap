using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main3(string[] args)
        {
            //for(<intialization-block>;<conditional-block>;<increment/decrement block>)
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //<intialization-block>
            int i = 5;
            //<conditional-block>
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
                //<increment/decrement block>
            }

            //  //<intialization-block>
            //int i = 5;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    < increment / decrement block >
            //} while (i < 5);
            //<conditional-block>
        }
    }
}
