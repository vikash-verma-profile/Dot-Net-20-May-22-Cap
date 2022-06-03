using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    //Generic collections
    //specific type
    class Class10
    {
        public static void Main11()
        {

            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(101);
            lst.Add(102);
            lst.Add(103);
            lst.Add(104);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1,"cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "asp.net");
            dct.Add(4, "fs.net");

            foreach (KeyValuePair<int,string> item in dct)
            {
                Console.WriteLine(item.Key+"=========>"+item.Value);
            }

            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList<string,string> sl = new SortedList<string,string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            //stack
            //LIFO
            Console.WriteLine("================");
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            //queue
            //FIFO
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
