
namespace SVL.Domain.Location.Interfaces.DomainEvents
{
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : ILocationMediaDomainEvent
        {
            //var handles = SimpleInjectorContainer

        }
    }
}
