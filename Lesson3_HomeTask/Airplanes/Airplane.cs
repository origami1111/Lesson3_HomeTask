namespace Lesson3_HomeTask
{
    public abstract class Airplane
    {
        public AirplaneManufacturer Manufacturer { get; private set; }
        public string Model { get; private set; }
        public uint FlightRange { get; private set; }
        public uint FuelConsumption { get; private set; }

        public abstract uint PassengerSeats { get; }
        public abstract uint CarryingCapacity { get; }

        public Airplane(AirplaneManufacturer manufacturer, string model, uint flightRange, uint fuelConsumption)
        {
            Manufacturer = manufacturer;
            Model = model;
            FlightRange = flightRange;
            FuelConsumption = fuelConsumption;
        }

    }
}
