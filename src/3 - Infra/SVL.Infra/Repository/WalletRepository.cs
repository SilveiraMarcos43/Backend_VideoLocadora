using SVL.Domain.Location;
using SVL.Infra.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SVL.Infra.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private BaseContext _context;

        public WalletRepository(BaseContext baseContexto)
        {
            _context = baseContexto;
        }

        public Wallet FindByCustomerId(int id)
        {
            return _context.wallet.Where(x => x.CustomerID == id).FirstOrDefault();
        }

        public async Task Update(Wallet wallet)
        {
            _context.wallet.Update(wallet);
            //TODO: REMOVER SAVE CHANGES E UTILIZAR UNIT OF WORK PARA RELIZAR APENAS UMA TRANSAÇÃO
            await _context.SaveChangesAsync();
        }

    }
}
