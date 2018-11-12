using FluentValidation;
using SVL.Domain.Location;
using SVL.Domain.Location.Domain.Enum;
using SVL.Domain.Location.Domain.Services;
using System;

namespace SVL.Application.Services
{
    public class LocationServiceApplication : ILocationServiceApplication
    {
        private ILocationService _locationService;

        public LocationServiceApplication(ILocationService locationService)
        {
            this._locationService = locationService;

        }

        public void CancelLocationMedia(int LocationMediaId)
        {
            throw new NotImplementedException();
        }

        public void Create(int customerId)
        {
            // Verifico se existe uma Locação no Banco de dados
            LocationAggregate _locationAggregate = _locationService.ReturnLocationMedia(customerId);
            if (_locationAggregate.ID <= 0)
            {
                _locationAggregate.CustomerId = customerId;
                _locationAggregate.Date = DateTime.Now;
                _locationAggregate.LocationStatus = LocationStatus.Ativa;

                _locationService.Create(_locationAggregate);

            } else
            {
                //TODO: Implementar mensagem de retorno."Existe Locação aberta para este Cliente.".
            }

        }

        public LocationAggregate EffectLocationMedia<V>(LocationAggregate locationMedia) where V : AbstractValidator<LocationAggregate>
        {
            return _locationService.EffectLocationMedia(locationMedia);
        }

        public LocationAggregate ReturnLocationMedia(int LocationId)
        {
            throw new NotImplementedException();
        }
    }
}
