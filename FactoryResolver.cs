namespace FactoryPatttern.Factory
{
    public class FactoryResolver : IFactoryResolver
    {
        Dictionary<string, Ifactory> Dict;
        
        public FactoryResolver(IEnumerable<Ifactory> Factories) 
        {
           Dict = Factories.ToDictionary(v => v.Type, j => j, StringComparer.OrdinalIgnoreCase);
            
        } 

        public Ifactory Resolver(string Type)
        {
           Dict.TryGetValue(Type, out var value);
            return value;
        }
    }
}
