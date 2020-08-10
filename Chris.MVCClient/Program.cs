using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Chris.MVCClient
{
    /// <summary>
    /// Interactive Applications with ASP.NET Core && ASP.NET Core and API access
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
