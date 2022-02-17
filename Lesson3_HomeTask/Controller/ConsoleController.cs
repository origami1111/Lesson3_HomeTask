using System;

namespace Lesson3_HomeTask.Controller
{
    public class ConsoleController
    {
        public static void Start()
        {
            Airplane airplaneAirbusA320a =
                new PassengerAirplane(AirplaneManufacturer.Airbus, "A320", 4000, 24210, 150, 1200);
            Airplane airplaneAirBusA320b =
                new PassengerAirplane(AirplaneManufacturer.Airbus, "A320", 12000, 24210, 150, 1200);
            Airplane airplaneBoeing737 =
                new PassengerAirplane(AirplaneManufacturer.Boeing, "737", 5000, 26035, 176, 2300);
            Airplane airplaneMilitary1 =
                new MilitaryAirplane(AirplaneManufacturer.Bombardier, "mil. plane", 1000, 20000, 1000);
            Airplane airplaneMilitary2 =
                new MilitaryAirplane(AirplaneManufacturer.Bombardier, "mil. plane", 1000, 20000, 1000);

            Airline airline = new Airline("New Airline");
            airline.AddAirplane(airplaneAirbusA320a);
            airline.AddAirplane(airplaneAirBusA320b);
            airline.AddAirplane(airplaneBoeing737);
            airline.AddAirplane(airplaneMilitary1);
            airline.AddAirplane(airplaneMilitary2);

            Console.WriteLine();
            Console.WriteLine("Planes before sorting");
            Console.WriteLine();
            airline.PrintAirplanes();

            Console.WriteLine();
            Console.WriteLine($"Deleting plane with params manufacturer = {AirplaneManufacturer.Bombardier} and model = mil. plane");
            airline.DeleteAirplane(AirplaneManufacturer.Bombardier, "mil. plane");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Printing planes after deleting...");
            Console.WriteLine();
            airline.PrintAirplanes();

            Console.WriteLine();
            Console.WriteLine("Sorting planes by flight range...");
            Console.WriteLine();
            airline.SortAirplaneByFlightRange();
            airline.PrintAirplanes();

            Console.WriteLine();
            Console.WriteLine($"Total passenger seats   = {airline.CalculateTotalPassengerSeats()}");
            Console.WriteLine($"Total carrying capacity = {airline.CalculateTotalCarryingCapacity()}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Finding plane by manufacturer = {AirplaneManufacturer.Boeing} and model = 737");
            Console.WriteLine(airline.FindPlaneByManufacturerAndModel(AirplaneManufacturer.Boeing, "737"));
            Console.WriteLine();

        }
    }
}
