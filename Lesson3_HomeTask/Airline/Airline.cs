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

        public Airline(string name, List<Airplane> airplanes)
        {
            Name = name;
            Airplanes = airplanes;
        }

        public void AddAirplane(Airplane airplane)
        {
            Airplanes.Add(airplane);
        }

        public void DeleteAirplane(AirplaneManufacturer manufacturer, string model)
        {
            Airplanes.Remove(Airplanes.Where(plane => plane.Manufacturer == manufacturer &&
                                                      plane.Model == model).FirstOrDefault());
        }

        public uint CalculateTotalCarryingCapacity()
        {
            return Convert.ToUInt32(Airplanes.Sum(plane => plane.CarryingCapacity));
        }

        public uint CalculateTotalPassengerSeats()
        {
            return Convert.ToUInt32(Airplanes.Sum(plane => plane.PassengerSeats));
        }

        public void SortAirplaneByFlightRange()
        {
            Airplanes = Airplanes.OrderBy(plane => plane.FlightRange).ToList();
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
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(plane);
            }
        }

    }
}
