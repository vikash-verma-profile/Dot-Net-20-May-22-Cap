using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();

    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("dog is Eating.");
        }
    }
    class Class4
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}
