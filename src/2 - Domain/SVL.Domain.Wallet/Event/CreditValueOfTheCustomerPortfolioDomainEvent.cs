using SVL.Common.CrossCuting;

namespace SVL.Domain.Wallet.Event
{
    /// <summary>
    /// Evento CreateDebitoWalletEvent
    /// Event responsável por Retirar Creditos da Carteira do Cliente
    /// </summary>
    public class CreditValueOfTheCustomerPortfolioDomainEvent : INotification
    {
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int _CustomerId { get; }
        /// <summary>
        /// Valor a Creditar
        /// </summary>
        public int _Value { get; }

        public CreditValueOfTheCustomerPortfolioDomainEvent(int CustomerId, int Value)
        {
            _CustomerId = CustomerId;
            _Value = Value;

        }

    }
    
}
