using SVL.Domain.Base;
using System;

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
