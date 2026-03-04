using System.Collections.Generic;
using System;
using System.ComponentModel.Design;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int applicationNumber = 1;
            int refusalCounter = 0;
            
            bool running = true;

            List<FriendApplication> friendApplications = new List<FriendApplication>();

            Console.WriteLine("Welcome to my Friendship Application!");

            do
            {
                Console.WriteLine("Do you want to be my friend? (Type 'Show' to show every application) ");
                string response = Console.ReadLine();


                if ((response.ToLower().StartsWith("y")))
                {
                    Console.WriteLine("Then I am going to need you to fill out a short application.");
                    Console.WriteLine("Do you wish to continue with my short friendship application?");

                    string continueResponse = Console.ReadLine();
                    if (continueResponse.ToLower().StartsWith("y"))
                    {
                        Console.WriteLine("Please fill out this short application...");

                        FriendApplication app1 = new FriendApplication(applicationNumber);

                        app1.IntroInfo();
                        Console.WriteLine("Good Job! Let's Move on to the next part!");
                        app1.GetFavorites();
                        Console.WriteLine("Great, Thats another part down. we're almost done!");
                        app1.NumberOfThings();
                        Console.WriteLine("Last set of questions!");
                        app1.finalDetails();

                        Console.WriteLine("You were...");
                        app1.determineAcceptance();
                        Console.WriteLine(app1.Status);
                        friendApplications.Add(app1);
                        applicationNumber++;
                        Console.WriteLine("Thank you for submitting!");
                        
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
                } else if (response.ToLower().Contains("show")) {
                    Console.WriteLine("Showing List");
                    foreach(FriendApplication friend in friendApplications)
                    {
                        friend.ShowApplicationInfo();
                    }
                } else
                {
                    Console.WriteLine("Please answer Yes or No");
                }


            } while (running);


        }
    }
}
