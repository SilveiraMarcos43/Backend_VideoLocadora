using System.Threading.Tasks;

namespace SVL.Domain.Wallet.Interfaces.Repository
{
    public interface IWalletRepository
    {
        /// <summary>
        /// Debita o valor da Carteira do Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="ValueCredit"></param>
        Task CreditValueWalletCustomer(int CustomerId, int ValueCredit);

        /// <summary>
        /// Credita o valor da Carteira do Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="ValueDebit"></param>
        Task DebitValueWalletCustomer(int CustomerId, int ValueDebit);

    }
}
