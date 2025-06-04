using FluentValidation;

namespace Application.CardCQ.Validators;

public class CreateCardCommandValidator : AbstractValidator<CreateCardCommand>
{
    public CreateCardCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Adicione o titulo do card");
    }
}