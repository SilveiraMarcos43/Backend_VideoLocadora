using SVL.Domain.Location.Domain.Enum;
using SVL.Domain.Location.Interfaces.Repository;
using SVL.Domain.Location.Validators;
using System;

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

        public void Create(int customerId)
        {
            //TODO: Regras de Negocios
            // Verifico se existe uma Locação no Banco de dados
            LocationAggregate _locationAggregate = ReturnLocationMedia(customerId);
            if (_locationAggregate.ID <= 0)
            {
                _locationAggregate.CustomerId = customerId;
                _locationAggregate.Date = DateTime.Now;
                _locationAggregate.LocationStatus = LocationStatus.Ativa;

                _locationRepository.CreateLocation(_locationAggregate);

            }
            else
            {
                //TODO: Implementar mensagem de retorno."Existe Locação aberta para este Cliente.".
            }            
            
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
