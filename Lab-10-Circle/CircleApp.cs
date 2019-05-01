using System;
using System.Collections.Generic;
using System.Collections;


namespace Lab_10_Circle
{
    public class CircleApp
    {
        public List<Circle> Circles = new List<Circle>();

        public CircleApp()
        {

        }

        public void Run()
        {

            Console.WriteLine("Welcome to the Circle Tester.\n");

            bool run = true;
            double radius = 0;

            while (run)
            {
                Console.Write("\nPlease input a radius for your new circle: ");

                try
                {
                    string r = Console.ReadLine();
                    radius = Convert.ToDouble(r);
                    run = false;

                }
                catch (FormatException)
                {
                    Console.Write("That's not a valid number. Try again ");
                }
            

                Circle c = new Circle(radius);

                Circles.Add(c);


                Console.Write("\nWould you like to create another circle? (y/n) ");
                bool runOut = true;
                while (runOut)
                {
                    string cont = Console.ReadLine();

                    if (cont[0] == 'y')
                    {
                        runOut = false;
                        run = true;
                    }
                    else if (cont[0] == 'n')
                    {

                        runOut = false;
                        run = false;
                    }
                    else
                    {
                        Console.Write("Oops. I didn't understand that. Please try again: (y/n) ");
                    }

                }




            }

            if (Circles.Count == 1)
            {
                Console.WriteLine("\nGoodbye. You created 1 Circle object.\n");
            }
            else
            {
                Console.WriteLine($"\nGoodbye. You created {Circles.Count} Circle objects.\n");
            }

            PrintCircles();
        }






        public void PrintCircles()
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Console.WriteLine($"Circle {i + 1}:");

                Circles[i].PrintInfo();

                Console.WriteLine("\n-+-+-+-+-+-+-+-+\n");

            }

        }

    }
}
