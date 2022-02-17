namespace Lesson3_HomeTask
{
    public class MilitaryAirplane : Airplane
    {
        public override uint PassengerSeats { get; }
        public override uint CarryingCapacity { get; }

        public MilitaryAirplane(AirplaneManufacturer manufacturer, string model, uint flightRange,
            uint fuelConsumption, uint carryingCapacity)
            : base(manufacturer, model, flightRange, fuelConsumption)
        {
            PassengerSeats = 0;
            CarryingCapacity = carryingCapacity;
        }

        public override string ToString()
        {
            return $"Military airplane:  " +
                $"|{Manufacturer,30}| " +
                $"|{Model,12}| " +
                $"|{FlightRange,12}| " +
                $"|{"---",15}| " +
                $"|{FuelConsumption,16}| " +
                $"|{CarryingCapacity,17}| ";
        }

    }
}
