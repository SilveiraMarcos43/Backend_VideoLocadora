using SVL.Domain.Base;
using SVL.Domain.Base.Domain.Enum;
using System;

namespace SVL.Domain.Location
{

    public class Media : BaseEntity
    {
        private string _title;
        private Boolean _isRelease;
        private DateTime _releaseDate;
        private Genero _genero;

        /// <summary>
        /// Titulo do Filme
        /// </summary>
        public string Title { get => _title; set => _title = value; }

        /// <summary>
        /// é Lançamento
        /// </summary>
        Boolean IsRelease { get => _isRelease; set => _isRelease = value; }

        /// <summary>
        /// Data de Lançamento
        /// </summary>
        DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }

        /// <summary>
        /// Genero do Filme
        /// </summary>
        Genero Genero { get => _genero; set => _genero = value; }





    }
}
