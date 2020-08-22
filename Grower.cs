using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewAgritask
{
    public class Grower
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public List<GrowerField> MyFields;
        public int StartRoundHour;


        public Grower (string firstName, string lastName, string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            StartRoundHour = Convert.ToInt32(ConfigurationManager.AppSettings["StartTime"]);

        }


        //creating and adding a new point if succeeded return true, else return false
        //the data base will return the id of the field - identity
        public bool AddField (string name, int length, int width, DateTime startingRoundHour)
        {
            return true;
        }

        //delete field by id
        public bool DeleteField(int id)
        {
            return true;
        }

        //update field by id
        public bool UpdateField(int id)
        {
            return true;
        }

      
       

    }
}
