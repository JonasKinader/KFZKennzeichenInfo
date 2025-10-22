using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KFZKennzeichenInfo.Data;

namespace KFZKennzeichenInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<KFZKennzeichenInfoContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("KFZKennzeichenInfoContext") ?? throw new InvalidOperationException("Connection string 'KFZKennzeichenInfoContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
