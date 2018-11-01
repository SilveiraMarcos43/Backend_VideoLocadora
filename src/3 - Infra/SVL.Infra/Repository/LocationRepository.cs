using SVL.Domain.Location;
using SVL.Domain.Location.Interfaces.Repository;
using SVL.Infra.Data;

namespace SVL.Infra.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private BaseContexto _baseContexto;

        public LocationRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;

        }        

        public void CancelLocationMedia(int LocationMediaId)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Implementação do metodo de criação da locação
        /// </summary>
        /// <param name="customerId"></param>
        public void CreateLocation(int customerId)
        {
            this._baseContexto.Add(new LocationAggregate(customerId));
            this._baseContexto.SaveChanges();
        }

        public LocationAggregate EffectLocationMedia(Domain.Location.LocationAggregate locationMedia)
        {
            throw new System.NotImplementedException();
        }


    }
}
