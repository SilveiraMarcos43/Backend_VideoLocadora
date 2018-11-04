﻿using FluentValidation;
using SVL.Common.CrossCuting;
using SVL.Domain.Base;
using System.Collections.Generic;

namespace SVL.Domain.Services.Interfaces.Services
{
    public interface IMediaServices<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}