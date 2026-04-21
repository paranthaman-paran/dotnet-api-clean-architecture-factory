using FactoryPatttern.Booking.Implementation;

namespace FactoryPatttern.Factory
{
    public class TrainLineFactory : Ifactory
    {
        public string Type => "TrainLine";

        public ITicket BookingTicket()
        {
            return new Trainline();
        }
    }
}
