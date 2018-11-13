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
        public void CreateLocation(LocationAggregate locationAggregate)
        {
            this._baseContexto.Add(locationAggregate);
            this._baseContexto.SaveChanges();
        }

        public LocationAggregate EffectLocationMedia(Domain.Location.LocationAggregate locationMedia)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Metodo que Retorna uma locação
        /// </summary>
        /// <returns></returns>
        public LocationAggregate ReturnLocationMedia(int LocationId)
        {
            return _baseContexto.Set<LocationAggregate>().Find(LocationId);
        }


    }
}
