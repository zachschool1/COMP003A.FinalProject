using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace COMP003A.FinalProject
{
    public class FriendApplication
    {
        public int Id;
        public string ApplicationDate;
        //9 strings plus 1 from date
        public string ApplicantName; //
        public string FavoriteMovieGenre;
        public string FavoriteTvGenre;
        public string FavoriteColor;
        public string FavoriteFood;
        public string FavoriteSport;
        public string FavoriteShoeBrand;
        public string FavoriteAnimal;
        public string Gender;
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

            Console.WriteLine("What Month were you born? (1-12)");
            string monthInput = Console.ReadLine();
            int month = int.Parse(monthInput);

            Console.WriteLine("What year were you born? (XXXX)");
            string yearInput = Console.ReadLine();
            int birthYear = int.Parse(yearInput);

            Console.WriteLine("What is your gender? (Male/Female/Other)");
            string genderInput = Console.ReadLine();


            
        }
        
    }
}
