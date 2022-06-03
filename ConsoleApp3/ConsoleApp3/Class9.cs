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

            //ArrayList al = new ArrayList();
            //string str = "Vikash";
            //int x = 7;
            //DateTime d = DateTime.Now;
            //al.Add(str);
            //al.Add(x);
            //al.Add(d);
            //al.Remove(d);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}

            Hashtable ht = new Hashtable();
            ht.Add("ora","oracle");
            ht.Add("vb", "vb.Net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            //DictionaryEntry is a class whose object represents the data in combination of key and value
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);
            }

            Console.WriteLine("================");
            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            //stack
            //LIFO
            Console.WriteLine("================");
            Stack stk = new Stack();
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
            Queue q = new Queue();
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
