using FluentValidation;
using SVL.Domain.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Application.Services
{
    public interface ILocationServiceApplication
    {
        /// <summary>
        /// Serviço criação da Locação
        /// </summary>
        /// <param name="customerId"></param>
        void Create(int customerId);
        /// <summary>
        /// Metodo que efetiva uma locação
        /// Usamos o conceito de Fluent Validation para validações de Aplicação
        /// </summary>
        /// <returns></returns>
        LocationAggregate EffectLocationMedia<V>(LocationAggregate locationMedia) where V : AbstractValidator<LocationAggregate>;

        /// <summary>
        /// Metodo que cancela uma Locação
        /// </summary>
        /// <returns></returns>
        void CancelLocationMedia(int LocationMediaId);

        /// <summary>
        /// Metodo que Retorna uma locação
        /// </summary>
        /// <returns></returns>
        LocationAggregate ReturnLocationMedia(int LocationId);

    }
}
