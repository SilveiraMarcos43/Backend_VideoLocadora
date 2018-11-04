using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Common.CrossCuting
{

    public abstract class BaseEntity
    {
        private int _iD;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ID { get => _iD; set => _iD = value; }

        private List<INotification> _domainEvents;
        /// <summary>
        /// Eventos de domínio
        /// </summary>
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents;
        /// <summary>
        /// Adiciona um evento de domínio para posterior emissão
        /// </summary>
        /// <param name="eventItem">uma instância de um evento</param>
        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }
        /// <summary>
        /// Remove a emissão de um evento de domínio
        /// </summary>
        /// <param name="eventItem">A instância que deve ser removida da emissão de eventos</param>
        public void RemoveDomainEvent(INotification eventItem)
        {
            if (_domainEvents is null)
                return;
            _domainEvents.Remove(eventItem);
        }
        /// <summary>
        /// Cancela a emissão de todos os eventos de domínio da entidade
        /// </summary>
        public void CancelDomainEvents()
        {
            _domainEvents?.Clear();
        }

    }
}
