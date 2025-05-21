using KitDocFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace KitDocFinder
{
    /// <summary>
    /// Точка входа в приложение
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KitDocFinder начало работы...");
            var host = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));
            })
            .Build();
        }
    }
}
