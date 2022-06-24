using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OmahaMRG.Application;
using OmahaMTG.Infrastructure;
using OmahaMTG.Web;
using OmahaMTG.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddTransient<UserContext>(() => new UserContext("1", "bob", ApplicationRoles.Admin, true));

builder.Services.AddInfrastructure(new OmahaMTG.Application.UserGroupsConfig(connectionString));
builder.Services.AddRazorPages();
builder.Services.AddApplication();
var app = builder.Build();


app.MapRoutes();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseBlazorFrameworkFiles(new PathString("/admin"));


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapFallbackToFile("/admin/{*path:nonfile}", "admin/index.html");
app.Run();
