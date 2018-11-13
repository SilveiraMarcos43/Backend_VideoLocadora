using SVL.Domain.Devolution.Interfaces.Repository;
using SVL.Domain.Location;
using SVL.Domain.Location.Interfaces.Repository;
using SVL.Domain.Wallet.Event;
using System;

namespace SVL.Domain.Devolution.Services
{
    public class MediaDevolutionService : IMediaDevolutionService
    {
        private IMediaDevolutionRepository _mediaDevolutionRepository;
        private MediaDevolution _mediaDevolution;
        private LocationAggregate _locationAggregate;
        private ILocationRepository _locationRepository;

        public MediaDevolutionService(IMediaDevolutionRepository mediaDevolutionRepository)
        {
            this._mediaDevolutionRepository = mediaDevolutionRepository;

        }

        public MediaDevolution GetMediaDevolutionById(int mediaLocationId)
        {
            return _mediaDevolutionRepository.GetMediaDevolutionById(mediaLocationId);
        }

        /// <summary>
        /// Media Devolvida Rebobinada
        /// </summary>
        /// <param name="mediaLocationId"></param>
        /// <returns></return
        public bool VerifyMediaRewound(int _customerId, int mediaLocationId, Boolean Rewound)
        {
            _mediaDevolution = GetMediaDevolutionById(mediaLocationId);

            // Não retornou Reboninada
            if (!Rewound)
            {
                _mediaDevolution.AddDomainEvent(new CreditValueOfTheCustomerPortfolioDomainEvent(_customerId, 1));
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Devolvida dentro do prazo
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="returnedOnTime"></param>
        /// <returns></returns>
        public bool MediaWasReturnedOnTime(int locationId, int mediaLocationId)
        {
            // Retorna instancia da Locação
            _locationAggregate = _locationRepository.ReturnLocationMedia(locationId);

            _mediaDevolution = GetMediaDevolutionById(mediaLocationId);
            TimeSpan date = _mediaDevolution.DeliveryDate.Subtract(_locationAggregate.Date);

            // Não retornou dentro do prazo de 24 horas gera multa
            if (date.TotalHours > 24)
            {
                _locationAggregate.AddDomainEvent(new CreditValueOfTheCustomerPortfolioDomainEvent(_locationAggregate.CustomerId, 1));
                return true;
            }
            else return false;
        }
    }
}
