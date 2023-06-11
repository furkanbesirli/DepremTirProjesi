using DepremTirProjesi.Models;
using DepremTirProjesi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionsql")));
builder.Services.AddScoped<KategoriRepository, KategoriRepository>();
builder.Services.AddScoped<MalzemeRepository, MalzemeRepository>();
builder.Services.AddScoped<TirÝcerikBilgisiRepository, TirÝcerikBilgisiRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Kategori}/{action=Index}/{id?}");

app.Run();
