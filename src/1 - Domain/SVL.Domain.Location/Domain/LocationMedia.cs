using SVL.Domain.Base;
using System;
using System.Collections.Generic;

namespace SVL.Domain.Location
{
    public class LocationMedia : BaseEntity
    {
        private DateTime _date;
        private float _value;
        private int _customerId;
        private ICollection<Media> _medias;

        public LocationMedia(int customerId)
        {
            this._customerId = customerId;
        }

        /// <summary>
        /// Data de Locação
        /// </summary>
        DateTime Date { get => _date; set => _date = value; }

        /// <summary>
        /// Valor da Locação
        /// </summary>
        float Value { get => _value; set => _value = value; }

        /// <summary>
        /// Cliente da Locação
        /// </summary>
        public int CustomerId { get => _customerId; set => _customerId = value; }
        /// <summary>
        ///  Significa que a Locação pode ter uma lista de VHF
        /// </summary>
        public ICollection<Media> medias { get => _medias; set => _medias = value; }

    }
}
