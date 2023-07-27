using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Database.Context;
using RBTB_ServiceStrategy.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Database
{
    public static class ServiceCollection
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("RBTB_ConnectionString");
            services.AddDbContext<RBTB_ServiceStrategyContext>(options => options.UseNpgsql(connectionString));
            services.AddTransient<IRepository<SettingsEntity>, SettingsRepository>();
            services.AddTransient<IRepository<StrategyEntity>, StrategyRepository>();
        }
    }
}
