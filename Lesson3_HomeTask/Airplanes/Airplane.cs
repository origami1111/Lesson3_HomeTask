using System;

namespace Lesson3_HomeTask
{
    public abstract class Airplane : IComparable<Airplane>
    {
        public AirplaneManufacturer Manufacturer { get; }
        public string Model { get; }
        public uint FlightRange { get; }
        public uint FuelConsumption { get; }

        public abstract uint PassengerSeats { get; }
        public abstract uint CarryingCapacity { get; }

        public Airplane(AirplaneManufacturer manufacturer, string model, uint flightRange, uint fuelConsumption)
        {
            Manufacturer = manufacturer;
            Model = model;
            FlightRange = flightRange;
            FuelConsumption = fuelConsumption;
        }

        public int CompareTo(Airplane other)
        {
            return FlightRange.CompareTo(other.FlightRange);
        }
    }
}
