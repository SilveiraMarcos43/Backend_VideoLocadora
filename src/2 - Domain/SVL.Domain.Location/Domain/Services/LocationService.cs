using SVL.Domain.Location.Interfaces.Repository;

namespace SVL.Domain.Location.Domain.Services
{
    public class LocationService : ILocationService  
    {
        private ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            this._locationRepository = locationRepository;

        }

        public void Create(int customerId)
        {
            //TODO: Regras de Negocios
            _locationRepository.CreateLocation(customerId);
        }

        public void CancelLocationMedia(int LocationMediaId)
        {
            throw new System.NotImplementedException();
        }

        public LocationAggregate EffectLocationMedia(LocationAggregate locationMedia)
        {
            throw new System.NotImplementedException();
        }
    }
}
