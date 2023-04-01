using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


/*Methode 1: avec constructeur par défaut(non paramétré)*/

/*Plane plane = new Plane();
plane.PlaneType = PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = new DateTime(2023, 03, 11);
Console.WriteLine(plane.ToString());*/


/*Methode 2 : avec constructeur specifique: paramétré*/
/*Plane plane = new Plane(new DateTime(2023, 03, 11), 200, PlaneType.Airbus);*/


/*Methode 3: instantiation intuitive*/
/*Plane plane = new Plane {Capacity=200,ManufactureDate= new DateTime(2023,03,11),PlaneType=PlaneType.Airbus};*/

Passenger passenger = new Passenger { FirstName = "foulen", LastName = "ben foulen"};
/*Console.WriteLine(passenger.CheckProfile("foulen", "ben foulen"));
Console.WriteLine(passenger.CheckProfile("foulen", "ben foulen", "foulen.benfoulen@gamail.com"));


Staff staff = new Staff { FirstName = "test1", LastName = "test2", EmailAddress="testtest" };
Traveller traveller = new Traveller { FirstName = "test2", LastName = "test3", EmailAddress = "testtesttest" };
staff.PassengerType();
traveller.PassengerType();*/


/*ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;*/

/*Console.WriteLine("Flight date to Madrid ");
List<DateTime> list = sf.GetFlightDates("Madrid");
/*for(int i=0; i< list.Count; i++)
{
    Console.WriteLine(list[i].ToString());
}*/
/*foreach (DateTime date in list)
{
    Console.WriteLine(date.ToString());

}*/

//sf.ShowFlightDetails(TestData.Airbusplane);
//Console.WriteLine(sf.ProgrammedFlightNumber(new DateTime(2022,01,01)).ToString());
//Console.WriteLine("duration average to Madrid = " + sf.DurationAverage("Madrid").ToString());

passenger.UpperFullName();

Console.WriteLine("FirstName = " + passenger.FirstName + " lastName = " + passenger.LastName);

