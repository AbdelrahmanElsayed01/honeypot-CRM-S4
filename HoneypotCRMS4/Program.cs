using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HoneypotCRMS4.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HoneypotCRMS4Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HoneypotCRMS4Context") ?? throw new InvalidOperationException("Connection string 'HoneypotCRMS4Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", options =>
{
    options.Cookie.Name = "CookieAuth";
    options.LoginPath = "/Account";
    options.LogoutPath = "/Account/Logout";
}
            );
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MustBeAdmin",
        policy => policy.RequireClaim("admin", "admin"));
}
);

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}/{id?}");

app.Run();