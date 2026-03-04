using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.FinalProject
{
    public class FriendApplication
    {
        public int Id;
        public string ApplicationDate;
        //4 strings plus 1 from date
        public string ApplicantName;
        public string FavoriteMovieGenre;
        public string FavoriteColor;
        public string FavoriteFood;
        //4 numeric plus 1 from ID
        public int BirthMonth;
        public int BirthYear;
        public int Siblings;
        public int FavoriteNum;
        //3 boolean
        public bool RightHanded;
        public bool DietRestricted;
        public bool Allergies;
        // choice based
        public int DesperationLevel;
        //Status will basically be if their desperation level is too high, probably some random number depending how i write it up, then they are denied if their desperation level is close to top limit, they will only be accepted if their favorite color is green.. otherwise they are either pending or approved.
        public int Status;


        public FriendApplication(int id)
        {
            Id = id;
            ApplicationDate = DateTime.Now.ToString("MM/dd/yyyy");
            
        }


        
    }
}
