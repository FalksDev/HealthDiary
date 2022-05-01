using HealthDiary.Application.Commands.User;
using HealthDiary.Infrastructure.Data;
using MediatR;

namespace HealthDiary.Application.Handlers.User;

public class AddUserHandler : IRequestHandler<AddUserCommand, Core.Entities.User>
{
    private readonly ApplicationDBContext _dbContext;

    public AddUserHandler(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Core.Entities.User> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var newUser = new Core.Entities.User
        {
            Id = request.Id,
            UserName = request.UserName,
            Password = request.Password
        };

        var user = await _dbContext.Users.AddAsync(newUser);
        await _dbContext.SaveChangesAsync();
        
        return user.Entity;
    }
}