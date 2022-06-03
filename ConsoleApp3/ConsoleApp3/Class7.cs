using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car : IVehicle
    {
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public int Fuel { get; set; }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("No Fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel = Fuel + amount;
            return true;
        }
    }
    class Class7
    {
        public static void Main()
        {
            Car car = new Car(0);
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
