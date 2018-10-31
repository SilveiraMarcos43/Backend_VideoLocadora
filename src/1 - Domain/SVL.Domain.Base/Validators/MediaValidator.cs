using FluentValidation;
using SVL.Domain.Base;
using System;

namespace SVL.Base.Domain.Validators
{
    /// <summary>
    /// Classe de Validação do Objeto Media
    /// Esta classe será usada pelo CRUD nas operações
    /// </summary>
    public class MediaValidator : AbstractValidator<Media>
    {
        public MediaValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto Media não pode ser nulo.");
                });

            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("Título é Obrigatório.")
                .NotNull().WithMessage("Título é Obrigatório.");

            RuleFor(c => c.Genero)
                .NotEmpty().WithMessage("Genero é Obrigatório.")
                .NotNull().WithMessage("Genero é Obrigatório.");




        }
    }
}