using FluentValidation;

namespace Cluster.Domain.Models.Validations;

public class CartValidation : AbstractValidator<Cart>
{
    public CartValidation()
    {
        RuleFor(c => c.Status)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
    }
}
