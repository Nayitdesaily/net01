using FluentValidation;
using FluentValidation.Results;
using net01.Application.Exceptions;

namespace net01.Application.Utils.Mediator
{
    public class Mediator : IMediator
    {
        private readonly IServiceProvider serviceProvider;
        public Mediator(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
        {
            var validatorType = typeof(IValidator<>).MakeGenericType(request.GetType());

            var validator = serviceProvider.GetService(validatorType);

            if (validator is not null)
            {
                var validatorMethod = validatorType.GetMethod("ValidateAsync");
                var validate = (Task)validatorMethod!.Invoke(validator, new object[] {request, CancellationToken.None })!;
                await validate.ConfigureAwait(false);
                var result = validate.GetType().GetProperty("Result");
                var validationResult = (ValidationResult)result!.GetValue(validate)!;
                if (!validationResult.IsValid)
                {
                    throw new Exceptions.ValidationException(validationResult);
                }
            }

            var useCaseType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
            var useCase = serviceProvider.GetService(useCaseType);

            if(useCase is null)
            {
                throw new MediatorException($"No se encontro un handler para {request.GetType().Name}");
            }

            var method = useCaseType.GetMethod("Handle");
            return await (Task<TResponse>)method.Invoke(useCase, new object[] { request });
        }
    }
}
