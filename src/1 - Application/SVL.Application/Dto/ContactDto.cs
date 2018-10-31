using SVL.Domain.Base.Domain.Enum;
using System;

namespace SVL.Application
{
    public class ContactDto
    {
        private string _telefone;
        private string _name;
        private string _email;
        private int _customerId;

        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
    }
}
