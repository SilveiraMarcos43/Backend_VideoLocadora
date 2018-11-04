using SVL.Domain.Location;
using SVL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SVL.Infra.Repository
{
    public interface IWalletRepository
    {
        Wallet FindByCustomerId(int id);
        Task Update(Wallet wallet);
    }
}
