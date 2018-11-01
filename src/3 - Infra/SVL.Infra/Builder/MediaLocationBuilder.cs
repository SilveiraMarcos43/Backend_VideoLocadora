using SVL.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.Entities
{
    public class MediaLocationBuilder
    {
        public MediaLocation Build(MediaLocationDto mediaLocationDto)
        {
            var mediaLocation = new MediaLocation();
            mediaLocation.LocationID = mediaLocationDto.LocationId;
            mediaLocation.MediaID = mediaLocationDto.MediaId;
            return mediaLocation;
        }
    }
}
