using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3_HomeTask
{
    public class Airline
    {
        public string Name { get; private set; }
        public List<Airplane> Airplanes { get; private set; }

        public Airline(string name)
        {
            Name = name;
            Airplanes = new List<Airplane>();
        }

        public void AddAirplane(Airplane airplane)
        {
            Airplanes.Add(airplane);
        }

        public void DeleteAirplane(AirplaneManufacturer manufacturer, string model)
        {
            Airplane desiredAirplane = null;

            foreach (var airplane in Airplanes)
            {
                if (airplane.Manufacturer == manufacturer && airplane.Model == model)
                {
                    desiredAirplane = airplane;
                    break;
                }
            }

            Airplanes.Remove(desiredAirplane);
        }

        public uint CalculateTotalCarryingCapacity()
        {
            uint totalCarryingCapacity = 0;

            foreach (var airplane in Airplanes)
            {
                totalCarryingCapacity += airplane.CarryingCapacity;
            }

            return totalCarryingCapacity;
        }

        public uint CalculateTotalPassengerSeats()
        {
            uint totalPassengerSeats = 0;

            foreach (var airplane in Airplanes)
            {
                totalPassengerSeats += airplane.PassengerSeats;
            }

            return totalPassengerSeats;
        }

        public void SortAirplaneByFlightRange()
        {
            Airplanes.Sort();
        }

        public Airplane FindPlaneByManufacturerAndModel(AirplaneManufacturer manufacturer, string model)
        {
            return Airplanes.Where(plane => plane.Manufacturer == manufacturer &&
                                            plane.Model == model).FirstOrDefault();
        }

        public void PrintAirplanes()
        {
            Console.WriteLine($"Passenger airplane: " +
                $"|{"Manufacturer",30}| " +
                $"|{"Model",12}| " +
                $"|{"Flight range",8}| " +
                $"|{"Passenger seats",8}| " +
                $"|{"Fuel consumption",8}| " +
                $"|{"Carrying capacity",8}| ");

            foreach (var plane in Airplanes)
            {
                Console.WriteLine(new string('-', 139));
                Console.WriteLine(plane);
            }
        }

    }
}
