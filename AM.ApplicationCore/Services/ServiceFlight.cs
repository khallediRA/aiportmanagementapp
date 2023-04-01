using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string dest)
        {
            List<DateTime> listRetour = new List<DateTime>();
            /*  for(int i= 0; i<Flights.Count; i++)
              {
                  if(Flights[i].Destination == dest)
                  {
                      listRetour.Add(Flights[i].FlightDate);
                  }
              }*/
            /*
              foreach (Flight flight in Flights)
              {
                  if (flight.Destination == dest)
                  {
                      listRetour.Add(flight.FlightDate);
                  }
              }*/

            var query1 = from flight in Flights where flight.Destination == dest select flight.FlightDate;
            var query2 = Flights.Where(f => f.Destination == dest).Select(f => f.FlightDate);
            return query2.ToList();
        }
        public double DurationAverage(string destination)
        {
            var query1 = (from flight in Flights where flight.Destination == destination select flight.EstimatedDuration).Average();
            var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();
            return query2;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }

                    break;
                case "FlightDate":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }

                    break;
                case "EffectiveArrival":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }

                    break;

                default:
                    Console.WriteLine("choix erroné");
                    break;
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query1 = from f in Flights where DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7 select f;
            var query2 = Flights.Where(f => DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7).Select(f => f.FlightDate);
            return query2.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query1 = from f in Flights where f.Plane == plane select new { f.Destination, f.FlightDate };
            var query2 = Flights.Where(f => f.Plane == plane).Select(f => new { f.Destination, f.FlightDate });
            foreach (var f in query1)
            {
                Console.WriteLine("flight date =" + f.FlightDate.ToString() + "flight dest= " + f.Destination);
            }
        }

        public List<Flight> OrderedDurationFlights()
        {
            var query1 = from f in Flights orderby f.EstimatedDuration descending select f;
            var query2 = Flights.OrderByDescending(f => f.EstimatedDuration);
            return query2.ToList();

        }

        public List<Traveller> SeniorTravellers(Flight flight)
        {
            var query1 = (from passenger in flight.Passengers.OfType<Traveller>() orderby passenger.BirthDate select passenger).Take(3);
            var query2 = flight.Passengers.OfType<Traveller>().OrderBy(passenger => passenger.BirthDate).Take(3);
            return query2.ToList();
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var query1 = from f in Flights group f by f.Destination;
            var query2 = Flights.GroupBy(f => f.Destination);
            foreach (var grouping in query1)
            {
                Console.WriteLine("Destination = " + grouping.Key);
                foreach (var flight in grouping)
                {
                    Console.WriteLine("Décolage" + flight.FlightDate);
                }
            }
            return query1;
        }
    }
}
