using Application.CardCQ.ViewModels;
using MediatR;

namespace Application.CardCQ.Handlers;

public class CreateCardCommandHandler : IRequestHandler<CreateCardCommand, CarInfoViewModel>
{
    public Task<CarInfoViewModel> Handle(CreateCardCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}