using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Web.Data;
using Web.IRepository;
using Web.Models;
using Web.Services;
using Web.Validators;
using WebAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(x => x.UseSqlite(builder.Configuration["ConnectionString"]));

builder.Services.AddIdentity<User, IdentityRole>(x => {
 /*   x.SignIn.RequireConfirmedAccount = true;
    x.SignIn.RequireConfirmedPhoneNumber = false;
    x.SignIn.Re*/
    x.Password.RequireDigit = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredLength = 3;
/*
    x.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    x.Lockout.MaxFailedAccessAttempts = 5;
    x.Lockout.AllowedForNewUsers = true;*/

    x.User.AllowedUserNameCharacters = 
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
/*    x.User.RequireUniqueEmail = true;  

    x.SignIn.RequireConfirmedEmail = true;   
*//*    x.SignIn.RequireConfirmedPhoneNumber = false;*/
}).AddEntityFrameworkStores<MyDbContext>(); ;


builder.Services.AddOptions();                                        
var mailSettings = builder.Configuration.GetSection("MailSettings"); 
builder.Services.Configure<MailSettings>(mailSettings);               

/*builder.Services.AddTransient<IEmailSender, SendMailService>();*/
builder.Services.AddValidatorsFromAssemblyContaining<LoginValidator>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
});
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
