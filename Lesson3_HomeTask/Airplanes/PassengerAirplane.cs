namespace Lesson3_HomeTask
{
    public class PassengerAirplane : Airplane
    {
        public override uint PassengerSeats { get; }
        public override uint CarryingCapacity { get; }

        public PassengerAirplane(AirplaneManufacturer manufacturer, string model, uint flightRange,
            uint fuelConsumption, uint passengerSeats, uint carryingCapacity)
            : base(manufacturer, model, flightRange, fuelConsumption)
        {
            PassengerSeats = passengerSeats;
            CarryingCapacity = carryingCapacity;
        }

        public override string ToString()
        {
            return $"Passenger airplane: " +
                $"|{Manufacturer,30}| " +
                $"|{Model,12}| " +
                $"|{FlightRange,12}| " +
                $"|{PassengerSeats,15}| " +
                $"|{FuelConsumption,16}| " +
                $"|{CarryingCapacity,17}| ";
        }

    }
}
