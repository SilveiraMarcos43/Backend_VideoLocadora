using SVL.Domain.Location.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.CrossCuting
{
    public abstract class EventEntity
    {
        private List<INotification> _domainEvents;

        public void DebitEvent(EffectedLocationEvent effectedLocationEvent)
        {

        }
    }
}
