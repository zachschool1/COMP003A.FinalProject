using System.Collections.Generic;
using System;
using System.ComponentModel.Design;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int refusalCounter = 0;
            
            bool running = true;

            List<FriendApplication> friendApplications = new List<FriendApplication>();

            Console.WriteLine("Welcome to my Friendship Application!");

            do
            {
                Console.WriteLine("Do you want to be my friend?");
                string response = Console.ReadLine();


                if ((response.ToLower().StartsWith("y")))
                {
                    Console.WriteLine("Then I am going to need you to fill out a short application.");
                    Console.WriteLine("Do you wish to continue with my short friendship application?");

                    string continueResponse = Console.ReadLine();
                    if (continueResponse.ToLower().StartsWith("y"))
                    {
                        Console.WriteLine("Please fill out this short application...");


                        //logic here for taking friend application input and creating one.


                    }
                    else if (continueResponse.ToLower().StartsWith("n"))
                    {
                        Console.WriteLine("I didn't want to be your friend anyways.");
                        running = false;
                    }
                } else if (response.ToLower().StartsWith("n"))
                {
                    refusalCounter++;
                    Console.WriteLine("Why would you be so rude?");
                    

                    if (refusalCounter >= 4)
                    {
                        Console.WriteLine("Okay, fine. I get it. I have plenty of other people looking to be my friend anyways. What makes you special? Maybe you should be asking if I would even want to be friends with YOU! and you stink!");
                        running = false;
                    }
                } else
                {
                    Console.WriteLine("Please answer using Yes/No");
                }

            } while (running);


        }
    }
}
