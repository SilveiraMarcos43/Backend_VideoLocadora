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

        public void CancelLocationMedia(int LocationMediaId)
        {
            throw new System.NotImplementedException();
        }

        public void Create(LocationAggregate locationAggregate)
        {
            //TODO: Regras de Negocios
            _locationRepository.CreateLocation(locationAggregate);
            
        }

        public LocationAggregate EffectLocationMedia(LocationAggregate locationMedia)
        {
            throw new System.NotImplementedException();
        }

        public LocationAggregate ReturnLocationMedia(int LocationId)
        {
            throw new System.NotImplementedException();
        }
    }
}
