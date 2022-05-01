using MediatR;

namespace HealthDiary.Application.Queries.User;

public record GetUserByUserNameQuery(string UserName) : IRequest<Core.Entities.User>;