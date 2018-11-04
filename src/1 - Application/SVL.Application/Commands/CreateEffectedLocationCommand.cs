using System;
using System.Collections.Generic;
using System.Text;
using System;
using MediatR;
using System.Runtime.Serialization;

namespace SVL.Application.Commands
{
    public class CreateEffectedLocationCommand : IRequest<bool>
    {
        public CreateEffectedLocationCommand(int amount, int customerId)
        {
            this.amount = amount;
            this.customerId = customerId;
        }
        [DataMember]
        public int amount { get; set; }
        [DataMember]
        public int customerId { get; set; }

        public class EffectedLocationDto
        {
            public int amount { get; set; }
            public int customerId { get; set; }
        }
    }
}
