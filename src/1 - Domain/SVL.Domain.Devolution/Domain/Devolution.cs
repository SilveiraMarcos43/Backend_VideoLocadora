using SVL.Domain.Base;
using System;
using System.Collections.Generic;

namespace SVL.Domain.Devolution
{
    public class Devolution : BaseEntity
    {
        private int _locationId;
        private int _customerId;
        private ICollection<DevolutionMedia> _medias;
        private Boolean _isFinished;

        /// <summary>
        /// ID da Locação 
        /// </summary>
        public int LocationId { get => _locationId; set => _locationId = value; }

        private int CustomerI { get => _customerId; set => _customerId = value; }
        /// <summary>
        /// Identifica se a Locação esta finalizada
        /// </summary>
        public Boolean IsFinished { get => _isFinished; set => _isFinished = value; }


        public ICollection<DevolutionMedia>  Medias { get => _medias; set => _medias = value; } 

        private void ReturnMedia(DevolutionMedia media) { }

        private void IsComplete() { }
    }
}
