using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace COMP003A.FinalProject
{
    public class FriendApplication
    {
        public int Id;//
        public string ApplicationDate;//
        //9 strings plus 1 from date
        public string ApplicantName; //
        public string FavoriteMovieGenre;//
        public string FavoriteTvGenre;//
        public string FavoriteColor;
        public string FavoriteFood;
        public string FavoriteSport;
        public string FavoriteShoeBrand;
        public string FavoriteAnimal;
        public string Gender; //
        public string FavoriteCar;
       
        //6 numeric plus 1 from ID
        public int BirthMonth;//
        public int BirthYear;
        public int Siblings;
        public int FavoriteNum;
        public double ShoeSize;
        public int NumOfPets;
        //5 boolean
        public bool Bald;
        public bool Vegan;
        public bool RightHanded;
        public bool DietRestricted;
        public bool Allergies;
        // choice based
        public int DesperationLevel;
        //Status will basically be if their desperation level is too high, probably some random number depending how i write it up, then they are denied if their desperation level is close to top limit, they will only be accepted if their favorite color is green.. otherwise they are either pending or approved.
        public string Status;


        public FriendApplication(int id)
        {
            Id = id;
            ApplicationDate = DateTime.Now.ToString("MM/dd/yyyy");
            Status = "Pending...";
        }

        public void IntroInfo()
        {
            Console.WriteLine("What is your name?");
            string nameInput = Console.ReadLine();
            ApplicantName = nameInput;

            Console.WriteLine("What Month were you born? (1-12)");
            string monthInput = Console.ReadLine();
            int month = int.Parse(monthInput);
            BirthMonth = month;

            Console.WriteLine("What year were you born? (XXXX)");
            string yearInput = Console.ReadLine();
            int birthYear = int.Parse(yearInput);
            BirthYear = birthYear;

            Console.WriteLine("What is your gender? (Male/Female/Other)");
            string genderInput = Console.ReadLine();
            string gender = genderInput;

        }

        public void GetFavorites()
        {
            Console.WriteLine("Let's Find out what your favorite things are!\n");
            Console.WriteLine("What is your favorite Movie Genre?");
            string movieGenre = Console.ReadLine();
            FavoriteMovieGenre = movieGenre;

            Console.WriteLine("What is your favorite genre of Television?");
            string tvGenre = Console.ReadLine();
            FavoriteTvGenre = tvGenre;

            Console.WriteLine("What is your favorite color?");
            string colorInput = Console.ReadLine();
            FavoriteColor = colorInput;

            Console.WriteLine("What is your favorite food?");
            string foodInput = Console.ReadLine();
            FavoriteFood = foodInput;

            Console.WriteLine("What is your favorite sport?");
            string sportInput = Console.ReadLine();
            FavoriteSport = sportInput;

            Console.WriteLine("What is your favorite shoe brand?");
            string shoeInput = Console.ReadLine();
            FavoriteShoeBrand = shoeInput;

            Console.WriteLine("What is your favorite pet animal??");
            string animalInput = Console.ReadLine();
            FavoriteAnimal = animalInput;

            Console.WriteLine("What is your favorite car?");
            string carInput = Console.ReadLine();
            FavoriteCar = carInput;

            Console.WriteLine("What is your favorite number?");
            string favNumInput = Console.ReadLine();
            int favNum = int.Parse(favNumInput);    
        }
        
        public void finalDetails()
        {
            Console.WriteLine("Let's get going with the final, most important part!");
            Console.WriteLine("Do you have any food allergies? (Yes/No)");
            string allergyInput = Console.ReadLine().ToLower();
            Allergies = allergyInput.StartsWith("y");

            Console.WriteLine("Are you Vegan? (Yes/No)");
            string veganInput = Console.ReadLine().ToLower();
            Vegan = veganInput.StartsWith("y");

            Console.WriteLine("Are you Right Handed?(Yes/No)");
            string rightHandInput = Console.ReadLine().ToLower();
            RightHanded = rightHandInput.StartsWith("y");

            Console.WriteLine("Are you bald?(Yes/No)");
            string baldHead = Console.ReadLine().ToLower();
            Bald = baldHead.StartsWith("y");

            Console.WriteLine("How desperate are you for a friend?(0-10)");
            string desperateInput = Console.ReadLine();
            DesperationLevel = int.Parse(desperateInput);
        }

        public void determineAcceptance()
        {
            //if desperation 8+, auto deny. if 6-7, accept only if favorite color is green.
            if (DesperationLevel >= 8)
            {
                Status = "Denied";
            } else if (DesperationLevel >= 6)
            {
                if(FavoriteColor.ToLower() == "green")
                {
                    Status = "Accepted (but it was close)";
                } else
                {
                    Status = "Denied";
                }
            } else
            {
                Status = "Accepted";
            }
        }
    }
}
