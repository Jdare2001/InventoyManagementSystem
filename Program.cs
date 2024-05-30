using InventoyManagementSystem.Components;
using Microsoft.EntityFrameworkCore;
using System;

string SQLPass = Environment.GetEnvironmentVariable("SQLPass");
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<IMDatabaseContext>(options =>
            options.UseMySql("server=localhost;database=IMSystem;user=root;password="+SQLPass,
            new MySqlServerVersion(new Version(8, 4, 0))));
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<IMDatabaseContext>();
    dbContext.Database.Migrate();
}

app.Run();






