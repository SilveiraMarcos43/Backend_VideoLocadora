using SVL.Domain.Base;
using SVL.Domain.Base.Domain.Enum;
using System;
using System.Collections.Generic;

namespace SVL.Application
{
    public class CustomerDto
    {
        private string _name;
        private string _cpf;
        private DateTime _dateBirth;
        private EnumGender _gender;
        private AddressDto _addressDto;
        private ICollection<ContactDto> _contacts;

        public string Name { get => _name; set => _name = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public DateTime DateBirth { get => _dateBirth; set => _dateBirth = value; }
        public EnumGender Gender { get => _gender; set => _gender = value; }
        public AddressDto AddressDto { get => _addressDto; set => _addressDto = value; }
        public ICollection<ContactDto> Contacts { get => _contacts; set => _contacts = value; }
    }
}
