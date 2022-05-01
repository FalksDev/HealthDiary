using HealthDiary.Application.Commands.User;
using HealthDiary.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HealthDiary.Application.Ioc;

public static class DependecyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(AddUserCommand).Assembly);
    }
}