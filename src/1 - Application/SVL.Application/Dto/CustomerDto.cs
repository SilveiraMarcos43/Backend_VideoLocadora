using SVL.Domain.Base.Domain.Enum;
using System;

namespace SVL.Application
{
    public class CustomerDto
    {
        private string _name;
        private string _cpf;
        private DateTime _dateBirth;
        private EnumGender _gender;

        public string Name { get => _name; set => _name = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public DateTime DateBirth { get => _dateBirth; set => _dateBirth = value; }
        public EnumGender Gender { get => _gender; set => _gender = value; }
    }
}
