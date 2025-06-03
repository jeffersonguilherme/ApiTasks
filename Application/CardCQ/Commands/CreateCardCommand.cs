using Application.CardCQ.ViewModels;
using MediatR;

namespace Application.CardCQ;

public record CreateCardCommand : IRequest<CarInfoViewModel>
{
    public string? Title { get; set; }
    public string? Description { get; set; }

}