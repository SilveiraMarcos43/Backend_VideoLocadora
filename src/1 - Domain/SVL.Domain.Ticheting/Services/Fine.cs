using SVL.Domain.Devolution;
using SVL.Domain.Location;
using SVL.Ticketing.Domain.Services;
using System;

namespace SVL.Ticketing.Domain
{
    public class Fine: IFine
    {
        public void Apply(MediaDevolution media, DateTime dataDevolucao) { }
    }
}
