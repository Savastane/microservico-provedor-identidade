using Academico.Domain;
using FluentValidation;

// <Nullable>enable</Nullable>
namespace System.API.Application
{
    public class RoleValidator : AbstractValidator<RoleRequest>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Ambiente)
                .NotNull()
                .WithMessage("Ambiente é um campo requerido");

            RuleFor(x => x.Nivel)
                .NotNull()
                .WithMessage("Nivel é um campo requerido");



        }
    }
}
