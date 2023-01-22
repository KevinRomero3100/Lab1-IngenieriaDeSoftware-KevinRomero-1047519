using Lab1_Inyeccion_de_Dependencias;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ITransientC, Carrera>();
//builder.Services.AddScoped<IScopedC, Carrera>();
//builder.Services.AddSingleton<ISingeltonC, Carrera>();


builder.Services.AddTransient<ITransientE, Equipo>();
builder.Services.AddScoped<IScopedE, Equipo>();
builder.Services.AddSingleton<ISingeltonE, Equipo>();

builder.Services.AddTransient<ITransient, Pilot>();
builder.Services.AddScoped<IScoped, Pilot>();
builder.Services.AddSingleton<ISingelton, Pilot>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
