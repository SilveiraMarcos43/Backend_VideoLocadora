using System.Threading;
using System.Threading.Tasks;
using SVL.Domain.Wallet.Interfaces.Repository;
using SVL.Infra.Event;

namespace SVL.Infra.DomainEventHandlers
{
    public class UpdateCreditValueWallet : IUpdateCreditValueWallet
    {
        private IWalletRepository _walletRepository;

        public UpdateCreditValueWallet(IWalletRepository walletRepository)
        {
            this._walletRepository = walletRepository;

        }

        /// <summary>
        /// Implementação que Assina o Evento de Dominio CreditValueOfTheCustomerPortfolioDomainEvent
        /// </summary>
        public async Task Handle(CreditValueOfTheCustomerPortfolioDomainEvent notification, CancellationToken cancellationToken)
        {
           await _walletRepository.CreditValueWalletCustomer(notification._CustomerId, notification._Value);

        }
    }
}
