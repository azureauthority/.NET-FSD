using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication13.Models;

namespace WebApplication13.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    //  Add aditional DbSet Properties same as other examples 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Convert ALL bool properties to NUMBER(1)
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties())
            {
                if (property.ClrType == typeof(bool) || property.ClrType == typeof(bool?))
                {
                    property.SetColumnType("NUMBER(1)");
                }
            }
        }

        // Identity string columns (optional but prevents LONG NVARCHAR2 issues)
        builder.Entity<IdentityRole>(entity =>
        {
            entity.Property(e => e.ConcurrencyStamp).HasColumnType("NVARCHAR2(2000)");
        });

        builder.Entity<ApplicationUser>(entity =>
        {
            entity.Property(e => e.ConcurrencyStamp).HasColumnType("NVARCHAR2(2000)");
            entity.Property(e => e.SecurityStamp).HasColumnType("NVARCHAR2(2000)");
            entity.Property(e => e.PasswordHash).HasColumnType("NVARCHAR2(2000)");
        });
    }
}
