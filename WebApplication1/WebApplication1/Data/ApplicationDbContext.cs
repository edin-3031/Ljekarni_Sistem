using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pacijent> Pacijent { get; set; }
        public DbSet<Spol> Spol{ get; set; }
        public DbSet<Prijem> Prijem{ get; set; }
        public DbSet<Ljekar> Ljekar { get; set; }
        public DbSet<Titula> Titula { get; set; }
        public DbSet<Nalaz> Nalaz { get; set; }
    }
}