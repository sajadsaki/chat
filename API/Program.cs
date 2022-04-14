using API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistent;

namespace WebApplication1
{
    public class Program
    {
      public static async Task Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
           using var scope = host.Services.CreateScope();
           var service = scope.ServiceProvider;

           try
           {
                var context = service.GetRequiredService<DataContext>();
                context.Database.Migrate();
                   await Seed.SeedData(context);
           }
           catch(Exception ex)
           {
               var logger = service.GetRequiredService<ILogger<Program>>();
               logger.LogError(ex, "خطایی در حین ایجاد ماگریشن رخ داده است");
           }

           host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
