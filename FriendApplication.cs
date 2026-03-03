using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.FinalProject
{
    public class FriendApplication
    {
        public int Id;
        public string ApplicantName;
        public string ApplicationDate = DateTime.Now.ToString("MM/dd/yyyy");

        public FriendApplication(int id, string name)
        {
            Id = id;
            ApplicantName = name;
            ApplicationDate = DateTime.Now.ToString("MM/dd/yyyy");
            
        }
        
    }
}
