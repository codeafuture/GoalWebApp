using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoalWebApp.Models;

namespace GoalWebApp.Data
{
    public class GoalWebAppContext : DbContext
    {
        public GoalWebAppContext (DbContextOptions<GoalWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GoalWebApp.Models.Goal> Goal { get; set; } = default!;
    }
}
