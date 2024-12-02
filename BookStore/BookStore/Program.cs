//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build().Run();

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

//app.Run();

using BookStore;
class Program {
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
     Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(WebBuilder => {
        WebBuilder.UseStartup<Startup>();
    });
    }