using FluentValidation;
using WebApiSample.Models.DTO;

namespace WebApiSample.Models.Validations
{
    public class UpdateStudentRequestDtoValidator : AbstractValidator<UpdateStudentRequestDto>
    {
        public UpdateStudentRequestDtoValidator() 
        {
            RuleFor(X => X.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Email is not valid");
        }
    }
}
