using System;
using System.Collections;

//Non-Genric collections
namespace ConsoleApp3
{

    //arraylist
    class Class9
    {
        public static void Main()
        {

            ArrayList al = new ArrayList();
            string str = "Vikash";
            int x = 7;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(d);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
