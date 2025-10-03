using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Entities.Auth;

public class IdentityCustomRole : IdentityRole<Guid>
{
    public required string CompanyName { get; set; }
}


public class IdentityCustomRoleClaim : IdentityRoleClaim<Guid>
{
    public required string CompanyName { get; set; }
}