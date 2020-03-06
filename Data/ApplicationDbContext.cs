using System;
using System.Collections.Generic;
using System.Text;
using ApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CasaShow> CasaShows {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}