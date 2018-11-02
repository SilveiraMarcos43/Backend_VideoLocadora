using SVL.Domain.Base.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Domain.Base
{

    public class Customer : Person
    {
        public Customer()
        {

        }

        private string _cpf;
        private ICollection<Contact> _Contacts;
        private Guid _addressId;
        private EnumGender _gender;

        /// <summary>
        /// CPF
        /// </summary>
        public string Cpf { get => _cpf; set => _cpf = value; }
        /// <summary>
        /// Sexo
        /// </summary>
        public EnumGender Sexo { get => _gender; set => _gender = value; }

        /// <summary>
        ///  Significa que o Cliente pode ter uma lista de Contacts
        /// </summary>
        public ICollection<Contact> Contacts { get => _Contacts; set => _Contacts = value; }

        [ForeignKey("addressId")]
        public Guid AddressId { get => _addressId; set => _addressId = value; }
    }
}
