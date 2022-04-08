using FluentValidation;
using Hepsiburada.Application.Commands;

namespace Hepsiburada.Application.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name)
             .NotNull()
             .NotEmpty();
            RuleFor(p => p.CurrentPrice)
             .NotNull()
             .NotEmpty();
            RuleFor(p => p.ProductCode)
             .NotNull()
             .NotEmpty();
            RuleFor(p => p.Stock)
             .NotNull()
             .NotEmpty();
        }
    }
}
