using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        public int id { get; set; }
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " BirthDate: " + BirthDate.ToString();
        }


        public bool CheckProfile(string FirstName, string LastName)
        {
            return FirstName == FirstName && LastName == LastName;
        }

        public bool CheckProfile(string FirstName, string LastName, string EmailAddress)
        {
            return FirstName == LastName && LastName == LastName && EmailAddress == EmailAddress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");

        }
    }
}
