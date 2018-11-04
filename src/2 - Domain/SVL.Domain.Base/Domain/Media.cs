using SVL.Domain.Base.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using SVL.Common.CrossCuting;

namespace SVL.Domain.Base
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
        public Boolean IsRelease { get => _isRelease; set => _isRelease = value; }

        /// <summary>
        /// Data de Lançamento
        /// </summary>
        [Column(TypeName="date")]
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }

        /// <summary>
        /// Genero do Filme
        /// </summary>
        public Genero Genero { get => _genero; set => _genero = value; }


    }
}
