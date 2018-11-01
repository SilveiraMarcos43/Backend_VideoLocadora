using FluentValidation;
using System;

namespace SVL.Domain.Location.Validators
{
    public class LocationValidators : AbstractValidator<LocationAggregate>
    {
        public LocationValidators()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto de Locação não pode ser nulo.");
                    });

            RuleFor(c => c.Date)
                .NotEmpty().WithMessage("Data Locação é Obrigatório.")
                .NotNull().WithMessage("Data Locação é Obrigatório.");

            RuleFor(c => c.Value)
                    .NotEmpty().WithMessage("Valor Locação é Obrigatório.")
                    .NotNull().WithMessage("Valor Locação é Obrigatório.");

            RuleFor(c => c.LocationStatus)
                    .NotEmpty().WithMessage("Situação da  Locação é Obrigatório.")
                    .NotNull().WithMessage("Situação da  Locação é Obrigatório.");
        }
    }
}
