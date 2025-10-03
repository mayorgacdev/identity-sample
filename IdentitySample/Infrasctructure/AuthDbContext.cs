using IdentitySample.Entities.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentitySample.Infrasctructure;

public class AuthDbContext : IdentityDbContext<ApplicationCustomUser, IdentityCustomRole, Guid>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }
    
    override protected void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationCustomUserRole>().ToTable("UserRoles");
        builder.Entity<ApplicationCustomUser>().ToTable("Users");
        builder.Entity<IdentityCustomRole>().ToTable("Roles");
        base.OnModelCreating(builder);
    }
}
