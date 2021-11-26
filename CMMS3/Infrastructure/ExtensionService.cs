using System;
using CMMS3.Models;
using CMMS3.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PersianTranslation.Identity;

namespace CMMS3.Infrastructure
{
    public static class ExtensionService
    {
        public static void ConfigRepository(this IServiceCollection service)
        {
            //service.AddTransient<UnitOfWork<CmmsContext>>();
            service.AddScoped<IUnitOfWork<CmmsContext>, UnitOfWork<CmmsContext>>();
        }


        public static void ConfigLoggerManager(this IServiceCollection service)
        {
            service.AddScoped<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureDbIdentity(this IServiceCollection service)
        {
            service.AddDbContext<CmmsContext>();
            service.AddIdentity<UserApplication, IdentityRole>(options =>
             {
                 options.Password.RequiredUniqueChars = 0;
                 options.User.RequireUniqueEmail = true;
                 options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
             })
                .AddEntityFrameworkStores<CmmsContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<PersianIdentityErrorDescriber>();
        }
    }
}