using SVL.Domain.Location.Interfaces.DomainEvents;

namespace SVL.Domain.Location.Domain.Events
{
    public class LocationMediaDomainEvent : ILocationMediaDomainEvent
    {
        /// <summary>
        /// Evento disparado quando uma Locação é Efetuada
        /// </summary>
        /// <param name="locationMedia"></param>
        public void LeaseHold(LocationAggregate locationMedia)
        {
            
        }

    }
}
