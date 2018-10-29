using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Domain.Base.Domain.Enum
{
    public enum SEXO
    {
        Masculino, Feminino

    }


    public class EnumSexo
    {
        private SEXO sexo;

        public SEXO GetSexo()
        {
            return this.sexo;
        }

        public void SetSexo(SEXO value)
        {
            this.sexo = value;
        }

    }
}
