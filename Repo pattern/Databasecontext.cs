using Repo_pattern.Controllers;
using System.Collections.Generic;
using Repo_pattern.Models;
using Microsoft.EntityFrameworkCore;

namespace Repo_pattern
{
    public class Databasecontext:DbContext
    {
        public Databasecontext(DbContextOptions<Databasecontext> opts) : base(opts) { }

        public DbSet<Diary> Diarys { get; set; }

    }
}
