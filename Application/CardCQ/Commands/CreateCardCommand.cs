using Application.CardCQ.ViewModels;
using MediatR;

namespace Application.CardCQ;

public record CreateCardCommand : IRequest<CarInfoViewModel>
{
    
}