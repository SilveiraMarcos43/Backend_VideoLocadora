using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Domain.Base.Domain.Enum
{
    public enum Genero
    {
        Ação, Animação, Aventura, Chanchada, Comédia, romântico, Drama, Cultura,
        Documentários, Espionagem, Erótico, Fantasia, Faroeste,  Científica, Séries, Guerra
    }

    public class EnumGenerosMovies
    {
        private Genero genero;

        public Genero GetGenero()
        {
            return this.genero;
        }

        public void SetGenero(Genero value)
        {
            this.genero = value;
        }

    }
}
