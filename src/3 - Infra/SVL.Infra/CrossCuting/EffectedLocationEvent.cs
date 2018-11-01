using SVL.Infra.CrossCuting;

namespace SVL.Domain.Location.Events
{
    public class IEffectedLocationEvent : INotification
    {
        private int _amount;
        private int _customerId;

        public int Amount { get => _amount; set => _amount = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
    }
}
