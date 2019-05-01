using System;
using System.Collections.Generic;
using System.Collections;

namespace Lab_10_Circle
{
    public class Circle
    {

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return (Math.Round((2 * Math.PI * radius), 2));
        }

        public double GetArea()
        {
            return (Math.Round((Math.PI * Math.Pow(radius, 2)), 2));
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The RADIUS is {radius}.");
            Console.WriteLine($"The AREA is {GetArea()}.");
            Console.WriteLine($"The CIRCUMFERENCE is {GetCircumference()}.");
        }

    }
}
