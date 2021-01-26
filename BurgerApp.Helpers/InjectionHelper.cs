using BurgerApp.DataAccess;
using BurgerApp.DataAccess.Implementations;
using BurgerApp.DomainModels.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.Helpers
{
    public static class InjectionHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Burger>, BurgerRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();

        }
    }
}
