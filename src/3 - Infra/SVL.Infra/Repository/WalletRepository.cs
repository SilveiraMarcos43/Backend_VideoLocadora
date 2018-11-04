using Microsoft.AspNetCore.Authentication;
using SVL.Domain.Wallet.Domain;
using SVL.Domain.Wallet.Interfaces.Repository;
using SVL.Infra.Data;
using System.Threading.Tasks;

namespace SVL.Infra.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private BaseContexto _baseContexto;
        private Wallet _CustomerWallet;

        public WalletRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;

        }

        /// <summary>
        /// Credita valor da Carteira do Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="ValueCredit"></param>
        public async Task CreditValueWalletCustomer(int CustomerId, int ValueCredit)
        {
            _CustomerWallet = new Wallet(CustomerId);
            _CustomerWallet.CreditPoints = ValueCredit;
            await _baseContexto.SaveChangesAsync();

        }
    }
}
