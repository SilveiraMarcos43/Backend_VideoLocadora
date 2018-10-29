using SVL.Domain.Location;
using SVL.Domain.Location.Interfaces.Repository;
using SVL.Infra.Data;

namespace SVL.Infra.Repository
{
    public class EFLocationRepository : ILocationRepository
    {
        private BaseContexto _baseContexto;

        public EFLocationRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;

        }

        public void AddMedia(Media media)
        {
            throw new System.NotImplementedException();
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
            this._baseContexto.Add(new LocationMedia(customerId));
            this._baseContexto.SaveChanges();
        }

        public LocationMedia EffectLocationMedia(LocationMedia locationMedia)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveMedia(int mediaId)
        {
            throw new System.NotImplementedException();
        }
    }
}
