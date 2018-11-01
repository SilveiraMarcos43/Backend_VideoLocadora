using FluentValidation;
using SVL.Domain.Base;
using System.Collections.Generic;

namespace SVL.Domain.Services.Interfaces.Services
{
    public interface IAddressServices<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}