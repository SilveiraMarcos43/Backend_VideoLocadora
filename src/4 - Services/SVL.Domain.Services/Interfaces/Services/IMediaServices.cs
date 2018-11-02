using FluentValidation;
using SVL.Domain.Base;
using System;
using System.Collections.Generic;

namespace SVL.Domain.Services.Interfaces.Services
{
    public interface IMediaServices<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(Guid id);

        T Get(Guid id);

        IList<T> Get();
    }
}