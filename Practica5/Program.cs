using Microsoft.EntityFrameworkCore;
using Practica5.tables;
using Practica5.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EscuelaContext>(
    options => {
        options.UseSqlServer("name = SqlEscuela");

    });
builder.Services.AddScoped<IAlumno, AlumnoRepositorio>();
builder.Services.AddScoped<ICiclos, CiclosRepositorio>();
builder.Services.AddScoped<ICursos, CursosRepositorio>();
builder.Services.AddScoped<IProfesor, ProfesorRepositorio>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
