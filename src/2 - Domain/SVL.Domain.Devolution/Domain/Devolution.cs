using SVL.Domain.Base;
using SVL.Domain.Devolution.Domain.Enum;
using System;

namespace SVL.Domain.Devolution
{
    public class Devolution : BaseEntity
    {
        private int _locationId;
        private int _customerId;
        private Boolean _isFinished;
        private DevolutionStatus _devolutionStatus;

        /// <summary>
        /// ID da Locação 
        /// </summary>
        public int LocationId { get => _locationId; set => _locationId = value; }

        /// <summary>
        /// ID do Cliente
        /// </summary>
        public int CustomerId { get => _customerId; set => _customerId = value; }
        /// <summary>
        /// Identifica se a Locação esta finalizada
        /// </summary>
        public Boolean IsFinished { get => _isFinished; set => _isFinished = value; }
        /// <summary>
        /// Status da Locação "Finalizada, Aberta"
        /// </summary>
        public DevolutionStatus DevolutionStatus { get => _devolutionStatus; set => _devolutionStatus = value; }

        private void ReturnMedia(Media media) { }

        private void IsComplete() { }
    }
}
