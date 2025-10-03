using System;
using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Entities.Auth;

public class ApplicationCustomUserRole : IdentityUserRole<Guid>
{
    public required DateTime AssignedDate { get; set; }
}
