using SVL.Application;
using SVL.Domain.Base;

namespace SVL.Infra.Entities
{
    public class AddressBuilder
    {
        public Address Build(AddressDto AddressDto)
        {
            var address = new Address();
            address.Cep = AddressDto.Cep;
            address.City = AddressDto.City;
            address.District = AddressDto.District;
            address.State = AddressDto.State;
            address.StreetDescription = AddressDto.StreetDescription;

            return address;
        }
    }
}
