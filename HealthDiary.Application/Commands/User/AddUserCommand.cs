using MediatR;

namespace HealthDiary.Application.Commands.User;

public record AddUserCommand(Guid Id, string UserName, string Password) : IRequest<Core.Entities.User>;