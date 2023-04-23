using FA.JustBlog.Core.Repository.UnitOfWork;
using FA.JustBlog.UI.Areas.Identity.Data;
using FA.JustBlog.UI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


//context
var connectionString = builder.Configuration.GetConnectionString("FAJustBlogUIContextConnection");
builder.Services.AddDbContext<FAJustBlogUIContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<FAJustBlogUIUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>().AddEntityFrameworkStores<FAJustBlogUIContext>();

// add lifetime service
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = $"/Areas/Identity/Pages/Account/Login.cshtml";
    option.LogoutPath = $"/Areas/Identity/Pages/Account/Logout.cshtml";
    option.AccessDeniedPath = $"/hanchetruycap.cshtml";
});


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
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "areaRoute",
    pattern: "{area:exists}/{controller}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
