using System;
using FinchAPI;

namespace Exam2
{
    class Program
    {

        static void Main(string[] args)
        {
            //**************************
            // App: Super Finch (Exam 2)
            // Author: Witte, Hannah
            // Date: 4.10.19
            //**************************

            //
            // Level 1
            //
            string ShieldLevel;
            bool finchDead = false;
            double TempThreshold = 0;
            double LightThreshold = 0;

            Finch superFinch;
            superFinch = new Finch();
            superFinch.connect();

            TempThreshold = superFinch.getTemperature() - 2;
            LightThreshold = superFinch.getLeftLightSensor() + 20;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to Super Finch!");
            Console.WriteLine("SuperFinch, the superhero robot, is going into battle");
            Console.WriteLine("She will encounter both lasers and freeze rays.");
            Console.WriteLine();
            Console.WriteLine("Please Enter Shield Level for Super Finch");
            ShieldLevel = Console.ReadLine();
            Console.WriteLine("Super Finch is moving into battle!");

            while (!finchDead)
            {
                switch (ShieldLevel)
                {
                    case "1":
                        if (superFinch.getLeftLightSensor() > LightThreshold || superFinch.getTemperature() < TempThreshold)
                        {
                            finchDead = true;
                        }
                        break;
                    case "2":
                        if (superFinch.getLeftLightSensor() > LightThreshold)
                        {
                            finchDead = true;
                        }
                        break;
                    case "3":
                        if (superFinch.getLeftLightSensor() > LightThreshold && superFinch.getTemperature() < TempThreshold)
                        {
                            finchDead = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu choice (1, 2, 3).");
                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("HIT!");
            Console.WriteLine();
            Console.WriteLine("Game Over!");
        }
    }
}
