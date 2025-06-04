using Application.UserCQ.Commands;
using FluentValidation;

namespace Application.UserCQ.Validators;

public class CreateUserCommandValidator :AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Email).NotEmpty().WithMessage("O campo do email não pode ser vazio")
                            .EmailAddress().WithMessage("O campo email não é valido");

        RuleFor(x => x.Username).MinimumLength(1).WithMessage("O campo username não pode estar vazio");                            
    }
}