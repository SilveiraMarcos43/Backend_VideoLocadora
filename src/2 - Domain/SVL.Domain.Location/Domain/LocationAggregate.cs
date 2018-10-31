using SVL.Domain.Base;
using System;
using System.Collections.Generic;

/// <summary>
/// Classe Aggregate
/// </summary>
namespace SVL.Domain.Location
{
    public class LocationAggregate : BaseEntity
    {
        private DateTime _date;
        private float _value;
        private int _customerId;

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
        public float Value { get => _value; set => _value = value; }

        /// <summary>
        /// Cliente da Locação
        /// </summary>
        public int CustomerId { get => _customerId; set => _customerId = value; }
    }
}
