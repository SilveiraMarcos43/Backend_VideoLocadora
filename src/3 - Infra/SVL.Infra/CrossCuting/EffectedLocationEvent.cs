using SVL.Infra.CrossCuting;
using MediatR;

namespace SVL.Domain.Location.Events
{
    public class EffectedLocationEvent : MediatR.INotification
    {
        public int amount { get; set; }
        public int customerId { get; set; }

        public EffectedLocationEvent(int Amount, int CustomerId)
        {
            amount = amount;
            customerId = customerId;
        }

        //public int Amount { get => _amount; set => _amount = value; }
        //public int CustomerId { get => _customerId; set => _customerId = value; }
    }
}
