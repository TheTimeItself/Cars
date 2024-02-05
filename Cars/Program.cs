using CarsBL.Interfaces;
using CarsBL.Services;
using CarsDL.Interfaces;
using CarsDL.Repositories;
using FluentValidation.AspNetCore;
using FluentValidation;
using Cars.HealthChecks;

namespace Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<ICarRepository, CarRepository>();
            builder.Services.AddSingleton<ICarService, CarService>();
            builder.Services.AddSingleton<IManufacturerRepository, ManufacturerRepository>();
            builder.Services.AddSingleton<IManufacturerService, ManufacturerService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services.AddHealthChecks()
            .AddCheck<HealthCheck>(nameof(HealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}