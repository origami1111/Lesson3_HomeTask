using System;

namespace Lesson3_HomeTask.Controller
{
    public class ConsoleController
    {
        public static void Start()
        {
            Airplane airplaneAirbusA320a =
                new PassengerAirplane(AirplaneManufacturer.Airbus, AirplaneModels.AirbusModel, 4000, 24210, 150, 1200);
            Airplane airplaneAirBusA320b =
                new PassengerAirplane(AirplaneManufacturer.Airbus, AirplaneModels.AirbusModel, 12000, 24210, 150, 1200);
            Airplane airplaneBoeing737 =
                new PassengerAirplane(AirplaneManufacturer.Boeing, AirplaneModels.BoeingModel, 5000, 26035, 176, 2300);
            Airplane airplaneMilitary1 =
                new MilitaryAirplane(AirplaneManufacturer.Bombardier, AirplaneModels.BombardierModel, 1000, 20000, 1000);
            Airplane airplaneMilitary2 =
                new MilitaryAirplane(AirplaneManufacturer.Bombardier, AirplaneModels.BombardierModel, 1000, 20000, 1000);

            Airline airline = new Airline("New Arliana Airlines");
            airline.AddAirplane(airplaneAirbusA320a);
            airline.AddAirplane(airplaneAirBusA320b);
            airline.AddAirplane(airplaneBoeing737);
            airline.AddAirplane(airplaneMilitary1);
            airline.AddAirplane(airplaneMilitary2);

            Console.WriteLine("\nPlanes before sorting\n");
            airline.PrintAirplanes();

            Console.WriteLine($"\nDeleting plane with params manufacturer = {AirplaneManufacturer.Bombardier} and model = mil. plane\n");
            airline.DeleteAirplane(AirplaneManufacturer.Bombardier, "mil. plane");

            Console.WriteLine("\nPrinting planes after deleting...\n");
            airline.PrintAirplanes();

            Console.WriteLine("\nSorting planes by flight range...\n");
            airline.SortAirplaneByFlightRange();
            airline.PrintAirplanes();

            Console.WriteLine($"\nTotal passenger seats   = {airline.CalculateTotalPassengerSeats()}");
            Console.WriteLine($"Total carrying capacity = {airline.CalculateTotalCarryingCapacity()}");

            Console.WriteLine($"\nFinding plane by manufacturer = {AirplaneManufacturer.Boeing} and model = 737 \n");
            Console.WriteLine(airline.FindPlaneByManufacturerAndModel(AirplaneManufacturer.Boeing, "737"));

        }
    }
}
