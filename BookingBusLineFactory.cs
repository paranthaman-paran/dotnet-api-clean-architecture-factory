using FactoryPatttern.Booking.Implementation;

namespace FactoryPatttern.Factory
{
    public class BookingBusLineFactory : Ifactory
    {

        string Ifactory.Type => "BusLine";

        public ITicket BookingTicket()
        {
            return new Busline();            
                
        }
    }
}
