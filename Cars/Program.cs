using CarsDL.Interfaces;
using CarsDL.Repositories;
using CarsBL.Services;
using CarsBL.Interfaces;
using CarsModels.Models;

namespace Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            builder.Services.AddSingleton<ICarRepository, CarRepository>();

            builder.Services.AddSingleton<ICarService, CarService>();

            builder.Services.AddSingleton<IManufactorerRepository, ManufactorerRepository>();

            builder.Services.AddSingleton<IManufactorerService, ManufactorerService>();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}