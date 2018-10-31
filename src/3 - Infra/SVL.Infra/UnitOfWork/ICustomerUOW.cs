using SVL.Domain.Base;
using SVL.Infra.Interfaces;

namespace SVL.Infra.UnitOfWork
{
    public interface ICustomerUOW
    {
        IRepository<Address> AddressRepository { get; }
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Contact> ContactRepository { get; }

        void Commit();
    }
}
