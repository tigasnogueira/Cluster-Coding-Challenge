using FluentValidation;

namespace Cluster.Domain.Models.Validations;

public class MenuItemValidation : AbstractValidator<MenuItem>
{
    public MenuItemValidation()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
    }
}
