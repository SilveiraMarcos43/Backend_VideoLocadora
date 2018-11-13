using SVL.Common.CrossCuting;
using SVL.Domain.Wallet.Event;

namespace SVL.Infra.DomainEventHandlers
{
    /// <summary>
    /// Interface que Assina o Evento de Dominio CreditValueOfTheCustomerPortfolioDomainEvent
    /// </summary>
    public interface IUpdateCreditValueWallet : INotificationHandler<CreditValueOfTheCustomerPortfolioDomainEvent>
    {

    }
}
