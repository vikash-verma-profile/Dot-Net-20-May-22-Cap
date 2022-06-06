using System;
using System.Collections.Generic;

namespace ConsoleApp4
{

    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public double Average(IList<Person> person)
        {
            double sum = 0.00;
            foreach (var item in person)
            {
                sum = sum + item.Age;
            }

            return sum / person.Count;
        }

        public int Max(IList<Person> person)
        {
            int max = person[0].Age;

            foreach (var item in person)
            {
                if (item.Age > max)
                {
                    max = item.Age;
                }
            }
            return max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person s = new Person();
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });

            Console.WriteLine(s.Average(p));
            Console.WriteLine(s.Max(p));
        }
    }
}
