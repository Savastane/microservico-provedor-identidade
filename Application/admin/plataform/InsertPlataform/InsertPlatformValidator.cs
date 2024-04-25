using Academico.Domain;
using FluentValidation;

// <Nullable>enable</Nullable>
namespace System.API.Application
{
    public class InsertPlatformValidator : AbstractValidator<InsertPlatformRequest>
    {
        public InsertPlatformValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome é um campo requerido"); ;
            RuleFor(x => x.Apelido).NotEmpty().WithMessage("Apelido é um campo requerido");
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("Descricao é um campo requerido");

            
        }
    }
}
