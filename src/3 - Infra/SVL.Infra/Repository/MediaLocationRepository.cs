using SVL.Domain.Location;
using SVL.Domain.Location.Domain.Services;
using SVL.Infra.Data;
using SVL.Infra.Entities;
using SVL.Infra.Event;
using SVL.Infra.Interfaces;

namespace SVL.Infra.Repository
{
    public class MediaLocationRepository : IMediaLocationRepository
    {
        private ILocationService _locationService;
        private LocationAggregate _locationAggregate;
        private BaseContexto _baseContexto;

        public MediaLocationRepository(BaseContexto baseContexto)
        {
            this._baseContexto = baseContexto;
        }

        public void RemoveMedia(int mediaId)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Efetivando a Locação da Media, neste momento devemos Creditar os valores  da Carteira do Cliente
        /// </summary>
        /// <param name="media"></param>
        public void AddMedia(MediaLocation media)
        {
            _baseContexto.Add(media);
            _baseContexto.SaveChanges();

            // Retorna instancia da Locação
            _locationAggregate = _locationService.ReturnLocationMedia(media.LocationID);

            // Adiciona Evento de Dominio para Atualizar Creditos na Carteira
            media.AddDomainEvent(new CreditValueOfTheCustomerPortfolioDomainEvent(_locationAggregate.CustomerId, 1));
    
        }
    }
}
