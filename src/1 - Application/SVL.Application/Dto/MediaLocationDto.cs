using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Application.Dto
{
    public class MediaLocationDto
    {
        private int _mediaId;
        private int _locationId;

        public int MediaId { get => _mediaId; set => _mediaId = value; }
        public int LocationId { get => _locationId; set => _locationId = value; }
    }
}
