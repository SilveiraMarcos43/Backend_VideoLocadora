using SVL.Domain.Base;
using System;
using SVL.Common.CrossCuting;

namespace SVL.Domain.Devolution
{
    public class MediaDevolution: BaseEntity
    {
        private DateTime _date;

        /// <summary>
        /// Data Entrega
        /// </summary>
        public DateTime DeliveryDate { get => _date; set => _date = value; }
    }
}
