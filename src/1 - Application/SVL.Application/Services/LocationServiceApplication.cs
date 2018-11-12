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
            _locationService.Create(customerId);

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
