using SVL.Domain.Base;
using System;
using SVL.Common.CrossCuting;

namespace SVL.Domain.Devolution
{
    public class MediaDevolution : BaseEntity
    {
        private DateTime _date;
        private bool _rewound;
        private bool _returnedTime;

        /// <summary>
        /// Data Entrega
        /// </summary>
        public DateTime DeliveryDate { get => _date; set => _date = value; }

        /// <summary>
        /// Midia foi devolvida rebobinada
        /// </summary>
        public Boolean Rewound { get => _rewound; set => _rewound = value; }

        /// <summary>
        /// Retornou dentro do prazo
        /// </summary>
        public Boolean ReturnedTime { get => _returnedTime; set => _returnedTime = value; }

    }
}
