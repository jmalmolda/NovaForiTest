using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using todolist.Data;
using todolist.Data.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<todolistContext>(options =>
    options.UseInMemoryDatabase("ToDoListDatabase"));

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IToDoTaskRepository, ToDoTaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

app.Run();
