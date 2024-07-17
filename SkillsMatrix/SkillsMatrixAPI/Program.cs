
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SkillsMatrix.Models;
using SkillsMatrix.Repository;


namespace SkillsMatrixAPI;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
        //var builder = WebApplication.CreateBuilder(args);
        //builder.AddServiceDefaults();

        //// Add services to the container.

        //builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //        options.UseMySql(Configuration.GetConnectionString("MySqlConnection"), new MySqlServerVersion(new Version(8, 0, 21))));

        //builder.Services.AddTransient<IRepository<Category>, EfRepository<Category>>();


        //builder.Services.AddControllers();
        //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        //var app = builder.Build();

        //app.MapDefaultEndpoints();

        //// Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}

        //app.UseHttpsRedirection();

        //app.UseAuthorization();


        //app.MapControllers();

        //app.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
