using SVL.Infra.CrossCuting;

public static class DomainEvents
{
    public static void Raise<T>(T evento) where T : INotification
    {
        var registry = ConfigurationRegistry.RegistryConfigured;
        var addressEvent = registry.ResolveAll<IEventAddress<T>>();

        foreach (var eventRegistry in addressEvent)
        {
            eventRegistry.EnderecarEvento(evento);
        }
    }
}