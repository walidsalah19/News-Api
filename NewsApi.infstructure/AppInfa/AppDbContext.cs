using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsApi.Domain.AppEntity;
using NewsApi.Domain.IdentityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace NewsApi.infstructure.AppInfa
{
   public  class AppDbContext : IdentityDbContext<Account>
    {

        public DbSet<News> News { get; set; }
        public DbSet<Banners> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }

       // DbSet<Account> accounts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
