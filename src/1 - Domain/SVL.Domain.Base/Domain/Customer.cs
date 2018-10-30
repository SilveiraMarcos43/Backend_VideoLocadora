using SVL.Domain.Base.Domain.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SVL.Domain.Base
{

    public class Customer : Person
    {
        public Customer()
        {

        }

        private string _cpf;
        private ICollection<Contact> _Contacts;
        private ICollection<Address> _addresses;
        private SEXO _sexo;

        /// <summary>
        /// CPF
        /// </summary>
        public string Cpf { get => _cpf; set => _cpf = value; }
        /// <summary>
        /// Sexo
        /// </summary>
        public SEXO Sexo { get => _sexo; set => _sexo = value; }

        /// <summary>
        ///  Significa que o Cliente pode ter uma lista de Contacts
        /// </summary>
        public ICollection<Contact> Contacts { get => _Contacts; set => _Contacts = value; }

        /// <summary>
        /// Cliente pode ter N Endereços
        /// </summary>
        public ICollection<Address> Addresses { get => _addresses; set => _addresses = value; }

    }
}
