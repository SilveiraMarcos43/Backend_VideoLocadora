using SVL.Application;
using SVL.Domain.Base;
using SVL.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.Entities
{
    public class MediaBuilder
    {
        public Media Build(MediaDto mediaDto)
        {
            Media media = new Media();
            media.Title = mediaDto.Title;
            media.Genero = mediaDto.Genero;
            media.IsRelease = mediaDto.IsRelease;
            media.ReleaseDate = mediaDto.ReleaseDate;
            return media;
        }
    }
}
