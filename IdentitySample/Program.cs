using IdentitySample.Entities.Auth;
using IdentitySample.Infrasctructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationCustomUser, IdentityCustomRole>()
    .AddEntityFrameworkStores<AuthDbContext>()
    .AddDefaultTokenProviders()
    .AddSignInManager()
    .AddRoleManager<RoleManager<IdentityCustomRole>>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();
app.Run();
