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

        public LocationMedia Create(int customerId)
        {
            //TODO: Regras de Negocios
            return null;
        }
    }
}
