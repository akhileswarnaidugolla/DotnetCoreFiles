
using JWTRolebased.Context;
using JWTRolebased.Repositories;
using JWTRolebased.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace JWTRolebased
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
            builder.Services.AddDbContext<AuthContext>(x => x.UseSqlServer(connectionString));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Registering Repositoritary with AddScoped lifetime
            builder.Services.AddScoped<IAuthService,AuthService>();
            builder.Services.AddScoped<IAuthRepository,AuthRepository>();


            // JWT Authentication Configuration
            var key = Encoding.ASCII.GetBytes("I am working for Mirafra.gvjhbkjnkgvhbkjn"); // Use a secure key in a real app
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "Mirafra",
                        ValidAudience = "ClientofMirafra",
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });

            // Configure Swagger with Bearer Authentication
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AuthenticationAndAuthorizationUsingJWT", Version = "v1" });

                // Add security definitions to Swagger
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Enter JWT Bearer token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // Add Cors
            builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            // Enable Cors
            app.UseCors("MyPolicy");



            app.MapControllers();

            app.Run();
        }
    }
}
