using FluentValidation;

// <Nullable>enable</Nullable>
namespace System.API.Application
{
    public class AuthenticateUserValidator : AbstractValidator<AuthenticateUserRequest>
    {
        public AuthenticateUserValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email Inválido")
                .NotEmpty()
                .WithMessage("Email é um campo requerido");


            RuleFor(x => x.Password)
               .NotEmpty()
               .WithMessage("Senha é um campo requerido")
               .MinimumLength(8)
               .WithMessage("Número mínimo de caracteres permitido na senha 8");


            RuleFor(x => x.Id)
               .NotEmpty()
               .WithMessage("GUID é um campo requerido");

            

        }
    }
}
