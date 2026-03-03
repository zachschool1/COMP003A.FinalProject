using System.Collections.Generic;
using System;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Console.WriteLine("test");
            bool running = true;

            Console.WriteLine("Welcome to my Friendship Application!");

            do
            {
                Console.WriteLine("Do you want to be my friend?");
                string response = Console.ReadLine();


                if ((response.ToLower().StartsWith("y")) || (response.ToLower().StartsWith("n")))
                {

                    Console.WriteLine("not start y or n ");
                } else
                {
                    Console.WriteLine("Then I am going to need you to fill out a short application.");
                }

            } while (running);


        }
    }
}
