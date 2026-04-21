namespace FactoryPatttern.Booking.Implementation
{
    public class Trainline : ITicket
    {
        public string Book()
        {
            return "Booking Train Ticket Successfully";
        }
    }
}
