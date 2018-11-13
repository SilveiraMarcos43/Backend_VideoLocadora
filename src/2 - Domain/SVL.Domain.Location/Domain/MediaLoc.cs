using SVL.Domain.Base;
using SVL.Common.CrossCuting;

namespace SVL.Domain.Location
{
    public class MediaLoc: BaseEntity
    {
        private LocationAggregate _location;
        private Media _media;

        /// <summary>
        /// Relacionamento com a Locação
        /// </summary>
        public int LocationID { get; set; }
        public virtual LocationAggregate Location { get => _location; set => _location = value; }

        /// <summary>
        /// Relacionamento com a Midia
        /// </summary>
        public int MediaID { get; set; }
        public virtual Media media { get => _media; set => _media = value; }

    }
}
