using MediatR;
using SVL.Domain.Base;
using SVL.Domain.Location;
using SVL.Domain.Location.Events;
using SVL.Infra.Interfaces;
using SVL.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SVL.Infra.Handler
{
    public class DebitFromWalletWhenLocationIsEffectedEventHandler : INotificationHandler<EffectedLocationEvent>
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IRepository<Customer> _customerRepository;

        public DebitFromWalletWhenLocationIsEffectedEventHandler(IWalletRepository walletRepository, IRepository<Customer> customerRepository)
        {
            _walletRepository = walletRepository;
            _customerRepository = customerRepository;
        }

        public async Task Handle(EffectedLocationEvent effectedLocationEvent, CancellationToken cancellationToken)
        {   
            var wallet = _walletRepository.FindByCustomerId(effectedLocationEvent.customerId);
            await _walletRepository.Update(wallet);
        }
    }
}
