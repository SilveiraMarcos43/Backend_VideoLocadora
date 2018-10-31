using SVL.Application;
using SVL.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.Entities
{
    public class ContactBuilder
    {
        public List<Contact> Build(ICollection<ContactDto> contactDto)
        {
            List<Contact> contacts = new List<Contact>();
            foreach(var dto in contactDto)
            {
                Contact contact = new Contact();
                contact.Name = dto.Name;
                contact.Email = dto.Email;
                contact.Telefone = dto.Telefone;
                contact.CustomerId = dto.CustomerId;
                contacts.Add(contact);
            }
            return contacts;
        }
    }
}
