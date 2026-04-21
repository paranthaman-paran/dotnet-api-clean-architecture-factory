namespace FactoryPatttern
{
    public interface Ifactory
    {
        public string Type { get;}

        public ITicket BookingTicket();
    }
}
