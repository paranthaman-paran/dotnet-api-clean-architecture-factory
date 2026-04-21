namespace FactoryPatttern.Factory
{
    public class FinalFactory : IFactoryResolverFinal
    {
        private readonly IFactoryResolver _factoryResolver;
        public FinalFactory(IFactoryResolver factoryResolver) { 
        
            _factoryResolver = factoryResolver;
        }
        public string Book(string Type)
        {
            Ifactory factory =  _factoryResolver.Resolver(Type);
            ITicket ticket = factory.BookingTicket();
            return ticket.Book();

        }
    }
}
