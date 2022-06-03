using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    public class Shape
    {
        protected Location c;

        public string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.00;
        }
        public double Parimeter()
        {
            return 0.00;
        }
    }

    public class Rectangle : Shape
    {

        protected double side1, side2;
    }
    public class Circle : Shape
    {

        protected double radius;
    }

    public class Location
    {
        private double x, y;
    }
    class Class8
    {
        public static void Main()
        {

        }
    }
}
