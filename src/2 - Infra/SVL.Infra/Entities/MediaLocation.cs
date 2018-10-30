using SVL.Domain.Base;
using SVL.Domain.Location;
using System;
using Media = SVL.Domain.Base.Media;

namespace SVL.Infra.Entities
{
    /// <summary>
    /// Tabela associativa
    /// </summary>
    public class MediaLocation : BaseEntity
    {

        private LocationAggregate _location;
        private Media _media;
        private DateTime _date;
        private bool _isRewound;

        /// <summary>
        /// Relacionamento com a Locação
        /// </summary>
        public int LocationID { get; set; }
        public virtual LocationAggregate Location { get => _location; set => _location = value; }

        /// <summary>
        /// Relacionamento com a Midia
        /// </summary>
        public int MediaID { get; set; }
        public virtual Media Media { get => _media; set => _media = value; }

        /// <summary>
        /// Data Entrega
        /// </summary>
        public DateTime DeliveryDate { get => _date; set => _date = value; }

        public Boolean IsRewound { get => _isRewound; set => _isRewound = value; }

    }
}
