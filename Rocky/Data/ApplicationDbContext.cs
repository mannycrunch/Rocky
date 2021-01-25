using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Rocky.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<YEAR_TERM_TABLE>()
        //    //    .HasAlternateKey(c => new { c.YR_CDE, c.TRM_CDE });

        //    modelBuilder.Entity<STUDENT_CRS_HIST>()
        //        .HasOne(c => c.YEAR_TERM_TABLE)
        //        .WithMany(y => y.STUDENT_CRS_HIST)
        //        .HasForeignKey(c => new { c.YR_CDE, c.TRM_CDE })
        //        .HasPrincipalKey(c => new { c.YR_CDE, c.TRM_CDE });
        //}

        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
