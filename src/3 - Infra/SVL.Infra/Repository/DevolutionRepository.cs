using SVL.Domain.Devolution;
using SVL.Domain.Devolution.Interfaces.Repository;
using SVL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.Repository
{
    public class DevolutionRepository : IDevolutionRepository
    {
        private BaseContexto _baseContexto;

        public DevolutionRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;

        }

        public void CreateDevolution(int locationId, int customerId)
        {
            this._baseContexto.Add(new Devolution(locationId, customerId));
            this._baseContexto.SaveChanges();
        }

        public void UpdateDevolutionStatus(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
