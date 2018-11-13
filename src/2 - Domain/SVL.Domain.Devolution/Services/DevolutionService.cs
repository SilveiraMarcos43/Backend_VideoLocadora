using SVL.Domain.Devolution.Interfaces.Repository;
using System;

namespace SVL.Domain.Devolution.Services
{

    public class DevolutionService : IDevolutionService
    {
        private IDevolutionRepository _locationRepository;

        public DevolutionService(IDevolutionRepository locationRepository)
        {
            this._locationRepository = locationRepository;

        }
        public void CreateDevolution(int locationId, int customerId)
        {
            _locationRepository.CreateDevolution(locationId, customerId);
        }

        public void UpdateDevolutionStatus(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
