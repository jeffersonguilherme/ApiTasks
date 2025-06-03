using Application.CardCQ.ViewModels;
using Domain.Entity;
using Infra.Persistence;
using MediatR;

namespace Application.CardCQ.Handlers;

public class CreateCardCommandHandler(TasksDbContext context) : IRequestHandler<CreateCardCommand, CarInfoViewModel>
{
    private readonly TasksDbContext _tasksDbContext = context;
    public async Task<CarInfoViewModel> Handle(CreateCardCommand request, CancellationToken cancellationToken)
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

        var cardInfo = new CarInfoViewModel()
        {
            Title = card.Title,
            Description = card.Description,
            Deadline = card.Deadline,
            Status = card.Status
        };
        return cardInfo;
    }
}