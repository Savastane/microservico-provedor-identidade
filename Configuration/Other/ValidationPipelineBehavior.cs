using Application.General.Exceptions;
using FluentValidation;
using MediatR;

namespace System.API.Configuration
{
    public class ValidationPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IValidator<TRequest> _validator;
        public ValidationPipelineBehavior(IValidator<TRequest> validator)
        {
            _validator = validator;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)            
                throw new BadRequestException("", validationResult.ToDictionary());                
            return await next();
        }
    }    
}
