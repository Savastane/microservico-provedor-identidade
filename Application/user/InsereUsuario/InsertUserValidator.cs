using Academico.Domain;
using FluentValidation;

// <Nullable>enable</Nullable>
namespace System.API.Application
{
    public class InsertUserValidator : AbstractValidator<InsertUserRequest>
    {
        public InsertUserValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email Inválido")
                .NotEmpty()
                .WithMessage("Email é um campo requerido");


            //RuleFor(x => x.Senha)
            //   .NotEmpty()
            //   .WithMessage("Senha é um campo requerido")
            //   .MinimumLength(8)
            //   .WithMessage("Número mínimo de caracteres permitido na senha 8");


            //RuleFor(x => x.Ambiente)
            //   .NotEmpty()
            //   .WithMessage("Ambiente IdAplication,IdAOrganizacao,Organização são campos requeridos");



            RuleFor(x => x.Roles)
               .NotNull()               
               .WithMessage("Roles é um campo requerido");
            
        }
    }
}
