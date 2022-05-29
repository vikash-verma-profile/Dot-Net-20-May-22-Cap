using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
    }
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is : "+age);
        }
    }
    class Teacher: Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class Class12
    {
        public static void Main11()
        {
            Person p = new Person();
            p.Greet();
            Student s = new Student();
            s.SetAge(18);
            s.Greet();
            s.ShowAge();
            Teacher t = new Teacher();
            t.SetAge(40);
            t.Greet();
            t.Explain();

        }
    }
}
