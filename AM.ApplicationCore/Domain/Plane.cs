using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
       /* public Plane(DateTime manufactureDate, int capacity, PlaneType planeType)
        {
            ManufactureDate = manufactureDate;
            Capacity = capacity;
            PlaneType = planeType;
        }*/

        public int PlaneId { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return "PlaneType: " + PlaneType + " ManuFactureDate: " + ManufactureDate + " Capacity: " + Capacity;
        }
    }

    public enum PlaneType {
        Boing, 
        Airbus
    }



}
