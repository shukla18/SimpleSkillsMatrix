using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SkillsMatrix.Models;
using SkillsMatrix.Repository;
using SkillsMatrix.Services;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        var databaseProvider = Configuration.GetValue<string>("DatabaseProvider");

        if (databaseProvider == "SqlServer")
        {
            // services.AddDbContext<ApplicationDbContext>(options =>
               // options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
        }
        else if (databaseProvider == "MySql")
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("MySqlConnection"), new MySqlServerVersion(new Version(8, 0, 21))));
        }
        // Note: MongoDB does not use DbContext

        // Register repositories and services
        //services.AddTransient<IRepository<User>, EfRepository<User>>();

        services.AddTransient<IRepository<Category>, EfRepository<Category>>();
        
        //services.AddTransient<IRepository<Skill>, EfRepository<Skill>>();
        //services.AddTransient<UserService>();
        
        services.AddTransient<CategoryService>();

        //services.AddTransient<SkillService>();

        services.AddControllers();

        // Add Swagger services
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Skills API", Version = "v1" });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();

        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
        // specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Skills API V1");
            c.RoutePrefix = string.Empty; // To serve Swagger UI at application's root (http://localhost:<port>/)
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
