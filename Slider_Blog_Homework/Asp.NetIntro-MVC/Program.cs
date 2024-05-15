using Asp.NetIntro_MVC.Data;
using Asp.NetIntro_MVC.Services;
using Asp.NetIntro_MVC.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IExpertService, ExpertService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}");
    




app.Run();
