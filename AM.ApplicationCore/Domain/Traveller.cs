using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {
        public string HealthInfo { get; set; }
        public string Nationality { get; set; }


        public override void PassengerType()
        {
            Console.WriteLine("I am a traveller");

        }
    }
}
