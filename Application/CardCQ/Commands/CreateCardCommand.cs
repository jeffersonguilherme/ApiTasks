using Application.CardCQ.ViewModels;
using Application.Response;
using MediatR;

namespace Application.CardCQ;

public record CreateCardCommand : IRequest<ResponseBase<CarInfoViewModel?>>
{
    public string? Title { get; set; }
    public string? Description { get; set; }

}