using SVL.Domain.Base;
using SVL.Domain.Location.Domain.Enum;
using System;
using System.Collections.Generic;
using SVL.Common.CrossCuting;

/// <summary>
/// Classe Aggregate
/// </summary>
namespace SVL.Domain.Location
{
    public class LocationAggregate : BaseEntity
    {
        private DateTime _date;
        private int _value;
        private int _customerId;
        private LocationStatus _locationStatus;

        public LocationAggregate(int customerId)
        {
            this._customerId = customerId;
        }

        /// <summary>
        /// Data de Locação
        /// </summary>
        public DateTime Date { get => _date; set => _date = value; }

        /// <summary>
        /// Valor da Locação
        /// </summary>
        public int Value { get => _value; set => _value = value; }

        /// <summary>
        /// Cliente da Locação
        /// </summary>
        public int CustomerId { get => _customerId; set => _customerId = value; }

        /// <summary>
        /// Situação da locação
        /// </summary>
        public LocationStatus LocationStatus { get => _locationStatus; set => _locationStatus = value; }

    }
}
