namespace FactoryPatttern
{
    public interface IFactoryResolver
    {

        public Ifactory Resolver(string Type);
    }
}
