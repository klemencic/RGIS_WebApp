using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Other services...

        services.AddDistributedMemoryCache(); // Required for session

        services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30); // You can adjust the timeout as needed
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        // Other configurations...
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Other middleware...

        app.UseSession();

        // Other configurations...
    }
}
