using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BookStore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection service) { 
        service.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is the first pieline");
            //    await next();
            //    await context.Response.WriteAsync("This is the first 2 pieline");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is the Second pipeline");
            //    await next();
            //    await context.Response.WriteAsync("This is the Second 2 pipeline");
            //    await next();
            //});

            //app.UseRouting();
            //app.UseEndpoints(endpointRoute =>
            //{
            //    endpointRoute.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            //app.UseEndpoints(endpointRoute =>
            //{
            //    endpointRoute.Map("/Sanjay", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello ------ Sanjay");
            //    });
            //});

            app.UseRouting();
            app.UseEndpoints(endpoints => {
            endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
