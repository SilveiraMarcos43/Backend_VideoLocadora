using SVL.Domain.Base;
using System;

namespace SVL.Domain.Devolution
{
    public class DevolutionMedia : BaseEntity
    {
        private DateTime _date;

        private DateTime Date { get => _date; set => _date = value; }
    }
}
