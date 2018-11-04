using SVL.Common.CrossCuting;

namespace SVL.Infra.Event
{
    /// <summary>
    /// Evento CreateDebitoWalletEvent
    /// Event responsável por Debitar Creditos da Carteira do Cliente
    /// </summary>
    public class CreditValueOfTheCustomerPortfolioDomainEvent : INotification
    {
        /// <summary>
        /// Id da Locação
        /// </summary>
        public int _LocationId { get; }
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int _CustomerId { get; }
        /// <summary>
        /// Valor a Debitar
        /// </summary>
        public int _Value { get; }

        public CreditValueOfTheCustomerPortfolioDomainEvent(int LocationId, int CustomerId, int Value)
        {
            _LocationId = LocationId;
            _CustomerId = CustomerId;
            _Value = Value;

        }

    }
    
}
