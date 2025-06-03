using Application.CardCQ.ViewModels;
using Application.Response;
using Domain.Entity;
using Infra.Persistence;
using MediatR;

namespace Application.CardCQ.Handlers;

public class CreateCardCommandHandler(TasksDbContext context) : IRequestHandler<CreateCardCommand, ResponseBase<CarInfoViewModel?>>
{
    private readonly TasksDbContext _tasksDbContext = context;
    public async Task<ResponseBase<CarInfoViewModel>> Handle(CreateCardCommand request, CancellationToken cancellationToken)
    {
        var card = new Card()
        {
            Title = request.Title,
            Description = request.Description,
            CreatedAt = DateTime.Now,
            Deadline = DateTime.Now.AddDays(3),
            Status = Domain.Enum.StatusCardEnum.Todo
        };
        _tasksDbContext.Cards.Add(card);
        _tasksDbContext.SaveChanges();

        return new ResponseBase<CarInfoViewModel>
        {
            ResponseInfo = null,
            Value = new()
            {
            Title = card.Title,
            Description = card.Description,
            Deadline = card.Deadline,
            Status = card.Status
            }
        };
    }
}