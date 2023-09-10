using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure
{
        public static class DependencyInjections
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services)
            {
                services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
                return services;
            }
        }
}
