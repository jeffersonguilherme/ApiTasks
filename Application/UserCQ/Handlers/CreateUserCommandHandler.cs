using Application.Response;
using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using Domain.Entity;
using Infra.Persistence;
using MediatR;

namespace Application.UserCQ.Handlers;

public class CreateUserCommandHandler(TasksDbContext context) : IRequestHandler<CreateUserCommand, ResponseBase<UserInforViewModel?>>
{
    private readonly TasksDbContext _tasksDbContext = context;
    public async Task<ResponseBase<UserInforViewModel?>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            Name = request.Name,
            Surname = request.Surname,
            Email = request.Email,
            PasswordHash = request.Password,
            Username = request.Username,
            RefreshToken = Guid.NewGuid().ToString(),
            RefreshTokenExpirationTime = DateTime.Now.AddDays(5)

        };

        _tasksDbContext.Users.Add(user);
        _tasksDbContext.SaveChanges();

        return new ResponseBase<UserInforViewModel?>
        {
            ResponseInfo = null,
            Value = new()
            {
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            Username = user.Username,
            RefreshToken = user.RefreshToken,
            RefreshTokenExpirationTime = user.RefreshTokenExpirationTime,
            TokenJWT = Guid.NewGuid().ToString()
            }
        };

    }
}