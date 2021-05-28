using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System.IO;
using SerilogCustom;
using Serilog.Services.CustomSerilog;

namespace SerilogProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultDataBase");

            ColumnOptions columnsOptions = SerilogColumnOptions.GetColumnOptions();

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo
                .MSSqlServer(connectionString, sinkOptions: new MSSqlServerSinkOptions { SchemaName = "EventLogging", TableName = "Logs", AutoCreateSqlTable=true }, null, null, LogEventLevel.Information, null, columnOptions: columnsOptions, null, null)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
                .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>()
                     .ConfigureAppConfiguration(ConfigureApp);

                 }).UseSerilog();

        private static void ConfigureApp(WebHostBuilderContext context, IConfigurationBuilder configuration)
        {
            configuration.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
    }
}
