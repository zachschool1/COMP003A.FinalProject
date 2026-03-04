using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Transactions;

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

                    bool inMenu = true;

                    while (inMenu)
                    {
                        Console.WriteLine("1. Show All");
                        Console.WriteLine("2. Search ");
                        Console.WriteLine("3. Search and Delete");
                        Console.WriteLine("4. Exit");
                        Console.Write("Choice: ");

                        string menuString = Console.ReadLine();
                        
                        try {
                            int menuInput = int.Parse(menuString);

                            switch (menuInput)
                            {
                                case 1:
                                    Console.WriteLine("Showing All Applications");

                                    foreach (FriendApplication friend in friendApplications)
                                    {
                                        friend.ShowApplicationInfo();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Search for an application by First Name:");

                                    string nameSearch = Console.ReadLine().ToLower();
                                    foreach (FriendApplication friend in friendApplications)
                                    {
                                        if (friend.ApplicantName.ToLower() == nameSearch)
                                        {
                                            friend.ShowApplicationInfo();
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Search for an application to delete by First Name");
                                    string nameDeleteInput = Console.ReadLine().ToLower();

                                    FriendApplication foundPerson = null;

                                    foreach (FriendApplication friend in friendApplications)
                                    {
                                        if (friend.ApplicantName == nameDeleteInput)
                                        {
                                            foundPerson = friend;
                                            break;
                                                                                        
                                        }
                                    }

                                    if (foundPerson != null)
                                    {
                                        Console.WriteLine($"Found {foundPerson.ApplicantName}. Delete? (yes/no)");
                                        string confirmDelete = Console.ReadLine().ToLower();

                                        if ( confirmDelete.StartsWith("y"))
                                        {
                                            friendApplications.Remove(foundPerson);
                                            Console.WriteLine("Application Deleted");
                                        }
                                    } 
                                    else
                                    {
                                        Console.WriteLine("No Application Found");
                                    }
                                        break;


                                   
                                case 4:
                                    Console.WriteLine("Exiting Menu");
                                    inMenu = false;
                                    break;
                                default:
                                    Console.WriteLine("Enter a number 1-4");

                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e}."); 

                        }
                    }
                } else
                {
                    Console.WriteLine("Please answer Yes or No");
                }


            } while (running);


        }
    }
}
