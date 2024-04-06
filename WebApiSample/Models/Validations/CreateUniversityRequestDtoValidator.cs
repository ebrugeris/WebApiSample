using FluentValidation;
using WebApiSample.Models.DTO;

namespace WebApiSample.Models.Validations
{
    public class CreateUniversityRequestDtoValidator : AbstractValidator<CreateUniversityRequestDto>
    {
        public CreateUniversityRequestDtoValidator()
        {
            RuleFor(X => X.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
        }
    }
}
