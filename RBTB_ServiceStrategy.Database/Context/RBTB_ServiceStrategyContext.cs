using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RBTB_ServiceStrategy.Application;
using RBTB_ServiceStrategy.Application.Entities;

namespace RBTB_ServiceStrategy.Database.Context
{
    public class RBTB_ServiceStrategyContext : DbContext
    {
        public DbSet<SettingsEntity> Settings { get; set; }
        public DbSet<StrategyEntity> Strategies { get; set; }

        public RBTB_ServiceStrategyContext(DbContextOptions<RBTB_ServiceStrategyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
