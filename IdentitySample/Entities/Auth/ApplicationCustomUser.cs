using System;
using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Entities.Auth;

public class ApplicationCustomUser : IdentityUser<Guid>
{
    public required string AddressHome { get; set; }
}
