using SVL.Domain.Base.Domain.Enum;
using System;

namespace SVL.Application
{
    public class MediaDto
    {
        private string _title;
        private Boolean _isRelease;
        private DateTime _releaseDate;
        private Genero _genero;

        public string Title { get => _title; set => _title = value; }
        public bool IsRelease { get => _isRelease; set => _isRelease = value; }
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public Genero Genero { get => _genero; set => _genero = value; }
    }
}
