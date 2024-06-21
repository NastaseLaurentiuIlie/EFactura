using Amazon.Extensions.NETCore.Setup;
using Amazon.SecretsManager;
using EFactura.AWS;
using EFactura.Database;
using EFactura.Files;
using EFactura.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;

namespace EFactura
{
    public class ServiceManager
    {
        public IServiceProvider ConfigureServices()
        {
            // Build configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("C:\\Users\\Laurentiu\\source\\repos\\EFactura\\EFactura\\ConfigSettings\\appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Create service collection
            ServiceCollection services = new ServiceCollection();

            // Register JsonManager
            services.AddSingleton<JsonManager>();

            // Register DatabaseManager with connection string from configuration
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddSingleton<IDatabaseManager>(provider => new DatabaseManager(connectionString));
            services.AddScoped<FileGeneratorFactory>();
            services.AddScoped<PDFGenerator>()
                    .AddScoped<IFileGenerator, PDFGenerator>(provider => provider.GetService<PDFGenerator>());

            services.AddScoped<XmlGenerator>()
                    .AddScoped<IFileGenerator, XmlGenerator>(provider => provider.GetService<XmlGenerator>());

            // Build service provider
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}