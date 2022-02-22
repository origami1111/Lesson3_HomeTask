namespace Lesson3_HomeTask
{
    public class MilitaryAirplane : Airplane
    {
        private uint passengerSeats;
        public override uint PassengerSeats
        {
            get
            {
                if (passengerSeats == 0)
                {
                    throw new IsZeroException("Military airplane can not have passenger seats");
                }

                return passengerSeats;
            }

        }
        public override uint CarryingCapacity { get; }

        public MilitaryAirplane(AirplaneManufacturer manufacturer, string model, uint flightRange,
            uint fuelConsumption, uint carryingCapacity, uint passengerSeats = 0)
            : base(manufacturer, model, flightRange, fuelConsumption)
        {
            this.passengerSeats = passengerSeats;
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
