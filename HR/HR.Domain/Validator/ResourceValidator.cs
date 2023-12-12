using FluentValidation;
using HR.Domain.Model;

namespace HR.Domain.Validator;
public class ResourceValidator : AbstractValidator<Resource>
{
	public ResourceValidator()
	{
		RuleFor(i => i.Id).NotNull().NotEqual(Guid.Empty);
		RuleFor(i => i.Name).NotNull().NotEmpty();
		RuleFor(i => i.Email).NotNull().NotEmpty();
	}
}
