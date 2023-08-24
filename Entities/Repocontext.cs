using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Repocontext:DbContext
    {
        public Repocontext(DbContextOptions options) :base(options){ }
        public DbSet<User>Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}
