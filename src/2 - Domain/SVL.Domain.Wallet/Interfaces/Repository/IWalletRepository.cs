using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SVL.Domain.Wallet.Interfaces.Repository
{
    public interface IWalletRepository
    {
        /// <summary>
        /// Credita o valor da Carteira do Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="ValueCredit"></param>
        Task CreditValueWalletCustomer(int CustomerId, int ValueCredit);

    }
}
