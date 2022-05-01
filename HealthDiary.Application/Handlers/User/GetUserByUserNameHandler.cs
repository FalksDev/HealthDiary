using HealthDiary.Application.Queries.User;
using HealthDiary.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HealthDiary.Application.Handlers.User;

public class GetUserByUserNameHandler : IRequestHandler<GetUserByUserNameQuery, Core.Entities.User>
{
    private readonly ApplicationDBContext _dbContext;

    public GetUserByUserNameHandler(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Core.Entities.User> Handle(GetUserByUserNameQuery request, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.Where(x => x.UserName == request.UserName).FirstOrDefaultAsync();
        if (user == null)
        {
            throw new Exception($"User with the UserName: '{request.UserName}' not found");
        }

        return user;
    }
}