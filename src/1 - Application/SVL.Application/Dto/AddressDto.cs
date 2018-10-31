using SVL.Domain.Base.Domain.Enum;
using System;

namespace SVL.Application
{
    public class AddressDto
    {
        private string _cep;
        private string _streetDescription;
        private string _city;
        private string _district;
        private string _state;
        
        public string Cep { get => _cep; set => _cep = value; }
        public string StreetDescription { get => _streetDescription; set => _streetDescription = value; }
        public string City { get => _city; set => _city = value; }
        public string District { get => _district; set => _district = value; }
        public string State { get => _state; set => _state = value; }
    }
}
