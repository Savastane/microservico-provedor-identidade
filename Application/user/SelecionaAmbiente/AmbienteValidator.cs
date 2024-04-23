using FluentValidation;

// <Nullable>enable</Nullable>
namespace System.API.Application
{
    public class AmbienteValidator : AbstractValidator<AmbienteRequest>
    {
        public AmbienteValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email Inválido")
                .NotEmpty()
                .WithMessage("Email é um campo requerido");

            

        }
    }
}
