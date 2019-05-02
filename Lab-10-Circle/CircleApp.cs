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

            Console.WriteLine("Welcome to the Circle Tester.");

            bool completeLoop = true;
            double radius = 0;


            // main loop program will run until user exits and prints created circles
            while (completeLoop)
            {

                bool getValidRadius = true;
                // secondary loop to get valid circle radius
                while (getValidRadius)
                {
                    Console.Write("\nPlease input a radius for your new circle: ");

                    try
                    {
                        string r = Console.ReadLine();
                        radius = Convert.ToDouble(r);

                        if (radius <= 0)
                        {
                            throw new Exception("Only positive numbers greater than zero are allowed.");
                        }
                        else
                        {
                            getValidRadius = false;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That's not a valid number. Try again.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                
                
                // create new Circle instance with radius and add to Circle list
                Circle c = new Circle(radius);
                Circles.Add(c);



                // secondary loop to get valid reply to continue or not.
                Console.Write("\nWould you like to create another circle? (y/n) ");
                bool runOut = true;
                while (runOut)
                {
                    string cont = Console.ReadLine().ToLower();

                    if (cont[0] == 'y')
                    {
                        runOut = false;
                        completeLoop = true;

                    }
                    else if (cont[0] == 'n')
                    {
                        runOut = false;
                        completeLoop = false;

                    }
                    else
                    {
                        Console.Write("Oops. I didn't understand that. Please try again: (y/n) ");
                    }

                }
            }

            // once user doesn't want any more circles, print results
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


        // method to print all the Circles objects in the Circle list
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

