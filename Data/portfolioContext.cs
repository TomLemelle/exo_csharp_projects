using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Data
{
    public class portfolioContext : DbContext
    {
        public portfolioContext (DbContextOptions<portfolioContext> options)
            : base(options)
        {
        }

        public DbSet<portfolio.Models.Project> Project { get; set; }

    }
}
