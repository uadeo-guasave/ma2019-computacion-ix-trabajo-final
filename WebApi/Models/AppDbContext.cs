using System;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
  public class AppDbContext : DbContext
  {
      public DbSet<Role> Roles { get; set; }
      public DbSet<User> Users { get; set; }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
          modelBuilder.Entity<User>(u => {
              u.HasIndex(n => n.Name).IsUnique();
              u.Property(s => s.Status).HasConversion(
                  v => v.ToString(),
                  v => (UserStatus)Enum.Parse(typeof(UserStatus), v)
              );
              u.Property(g => g.Gender).HasConversion(
                  v => v.ToString(),
                  v => (UserGender)Enum.Parse(typeof(UserGender), v)
              );
              u.Property(ip => ip.LastLoginIp).HasConversion(
                  v => v.ToString(),
                  v => (IPAddress)IPAddress.Parse(v)
              );
              u.HasOne(r => r.Role).WithMany(p => p.Users);
          });

          modelBuilder.Entity<Role>(r => {
              r.HasMany(u => u.Users).WithOne(o => o.Role);
              r.HasIndex(n => n.Name).IsUnique();
              r.HasIndex(l => l.Level).IsUnique();
          });
      }
  }
}