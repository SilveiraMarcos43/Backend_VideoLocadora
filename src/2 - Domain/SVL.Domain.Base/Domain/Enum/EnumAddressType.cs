using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Domain.Base.Domain.Enum
{
    public enum TypeAddress
    {
        Comercial, Residencial

    }

    public class EnumAddressType
    {
        private TypeAddress _typeaddress;

        public TypeAddress GetTypeAddress()
        {
            return this._typeaddress;
        }

        public void SetTypeAddress(TypeAddress value)
        {
            this._typeaddress = value;
        }


    }
}
