
using Microsoft.EntityFrameworkCore;
using System;

namespace OneToOneRelationship
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //retriving connectionString from appsettings.json file
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            //Adding DbContext class and connection strings
            builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
