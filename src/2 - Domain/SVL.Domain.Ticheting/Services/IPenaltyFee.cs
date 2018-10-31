using SVL.Domain.Devolution;
using System;

namespace SVL.Ticketing.Domain.Services
{
    public interface IPenaltyFee
    {
        void Apply(MediaDevolution media, DateTime date);
    }
}
