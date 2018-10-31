using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using SVL.Domain.Base;
using SVL.Infra.Data;
using SVL.Infra.Interfaces;

namespace SVL.Infra.UnitOfWork
{
    public class CustomerUOW : ICustomerUOW, IDisposable
    {
        private BaseContexto _baseContext;
        private bool _disposed = false;
        private IRepository<Address> _addressRepository = null;
        private IRepository<Customer> _customerRepository = null;
        private IRepository<Contact> _contactRepository = null;

        public CustomerUOW(BaseContexto baseContext, 
                           IRepository<Address> addressRepository,
                           IRepository<Customer> customerRepository,
                           IRepository<Contact> contactRepository)
        {
            _addressRepository = addressRepository;
            _customerRepository = customerRepository;
            _contactRepository = contactRepository;
            _baseContext = baseContext;
        }

        public IRepository<Address> AddressRepository
        {
            get
            {
                if(_addressRepository == null)
                {
                    return null;
                }
                return _addressRepository;
            }
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    return null;
                }
                return _customerRepository;
            }
        }

        public IRepository<Contact> ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                {
                    return null;
                }
                return _contactRepository;
            }
        }

        public void Commit()
        {
            _baseContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _baseContext.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
