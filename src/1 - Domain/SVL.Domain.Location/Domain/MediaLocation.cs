using SVL.Domain.Base;
using System;

namespace SVL.Domain.Location
{
    public class MediaLocation : BaseEntity
    {
        private DateTime _date;
        private float _pointsLocation;
        private LocationMedia _location;
        private bool _isRelease;

        /// <summary>
        /// é Lançamento
        /// </summary>
        Boolean IsRelease { get => _isRelease; set => _isRelease = value; }

        /// <summary>
        /// Data Entrega
        /// </summary>
        DateTime DeliveryDate { get => _date; set => _date = value; }
        /// <summary>
        /// Créditos consumidos
        /// </summary>
        float PointsLocation { get => _pointsLocation; set => _pointsLocation = value; }

        /// <summary>
        /// Relacionamento com a Locação
        /// </summary>
        public int LocationID { get; set; }
        public virtual LocationMedia Location { get => _location; set => _location = value; }

    }
}
