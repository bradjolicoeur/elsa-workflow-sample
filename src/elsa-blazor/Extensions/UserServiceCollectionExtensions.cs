using elsa_blazor.Activities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elsa_blazor.Extensions
{
    public static class UserServiceCollectionExtensions
    {
        public static IServiceCollection AddUserActivities(this IServiceCollection services)
        {
            return services
                .AddActivity<CreateUser>()
                .AddActivity<ActivateUser>()
                .AddActivity<DeleteUser>();
        }
    }
}
