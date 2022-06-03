using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface Vehicle
    {
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }
    class Bicycle : Vehicle
    {
        int speed;
        int gear;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void PrintStates()
        {
            Console.WriteLine("Bicycle Speed "+speed+ " Bicycle Gear: " + gear);
        }
    }
    class Bike : Vehicle
    {
        int speed;
        int gear;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void PrintStates()
        {
            Console.WriteLine("Bike Speed " + speed + " Bike Gear: " + gear);
        }
    }
    class Class6
    {
        public static void Main7()
        {
            Bicycle b = new Bicycle();
            b.changeGear(2);
            b.speedUp(3);
            b.applyBrakes(1);
            b.PrintStates();


            Bike b1 = new Bike();
            b1.changeGear(1);
            b1.speedUp(4);
            b1.applyBrakes(3);
            b1.PrintStates();
        }
    }
}
