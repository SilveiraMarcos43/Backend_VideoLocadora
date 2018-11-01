using FluentValidation;
using SVL.Domain.Services.Interfaces.Services;
using SVL.Infra.Interfaces;
using System;
using System.Collections.Generic;

namespace SVL.Domain.Base.Services
{
    public class BaseService<T> : IMediaServices<T> where T : BaseEntity
    {
        private IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            this._repository = repository;
        }

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            _repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            _repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            _repository.Delete(id);
        }

        public IList<T> Get() => _repository.Select();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            return _repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
