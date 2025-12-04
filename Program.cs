using System.Runtime.InteropServices;
using FootballHobby.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

if (isWindows)
{
    builder.Services.AddDbContext<FootballContext>(options =>
        options.UseSqlServer(connectionString));
}
else
{
    builder.Services.AddDbContext<FootballContext>(options =>
        options.UseSqlite(connectionString));
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.InitializeAsync(services);
}

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
