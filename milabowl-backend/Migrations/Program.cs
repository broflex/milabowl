﻿using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Milabowl;
using Milabowl.Business.Api;
using Milabowl.Business.Import;
using Milabowl.Business.Mappers;
using Milabowl.Infrastructure.Contexts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

const string CONNECTION_STRING = "Persist Security Info=False;UID=SA;Pwd=!5omeSup3rF4ncyPwd!;Database=fantasy;Server=localhost,1431; Connection Timeout=30;TrustServerCertificate=True";

var configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile("./dockerappsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = configurationBuilder.Build();
Startup.Configuration = configuration;

if (args[0] == "Migrate")
{
    await Migrate();
}
else if (args[0] == "Import")
{
    await Migrate();
    await Import();
}

static async Task Migrate()
{
    Console.WriteLine("Running migrations...");
    var dbContextBuilder = new DbContextOptionsBuilder<FantasyContext>(new DbContextOptions<FantasyContext>());
    dbContextBuilder.UseSqlServer(CONNECTION_STRING);
    await using var db = new FantasyContext(dbContextBuilder.Options);
    await db.Database.MigrateAsync();
    Console.WriteLine("Finished running migrations");
}

static async Task Import()
{
    Console.WriteLine("Importing data");
    var serviceProvider = DI.GetServiceProvider(CONNECTION_STRING);
    var dataImportService = serviceProvider.GetService<IDataImportService>()!;
    var milaPointsProcessorService = serviceProvider.GetService<IMilaPointsProcessorService>()!;
    var milaResultsService = serviceProvider.GetService<IMilaResultsService>()!;

    await dataImportService.ImportData();
    await milaPointsProcessorService.UpdateMilaPoints();
    var milaResults = await milaResultsService.GetMilaResults();
    var json = JsonConvert.SerializeObject(milaResults, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() } });
    await File.WriteAllTextAsync("C:\\Programming\\Other\\milabowl\\game_state.json", json);
    Console.WriteLine("Finished importing data");
}

public static class DI
{
    public static IServiceProvider GetServiceProvider(string connectionString)
    {
        var services = new ServiceCollection();
        services.AddScoped<IMilaResultsService, MilaResultsService>();
        services.AddScoped<IDataImportBusiness, DataImportBusiness>();
        services.AddScoped<IMilaPointsProcessorService, MilaPointsProcessorService>();
        services.AddScoped<IMilaRuleBusiness, MilaRuleBusiness>();
        services.AddScoped<IDataImportService, DataImportService>();
        services.AddScoped<IMilaResultsBusiness, MilaResultsBusiness>();
        services.AddScoped<IDataImportProvider, DataImportProvider>();
        services.AddScoped<IFantasyMapper, FantasyMapper>();
        services.AddDbContext<FantasyContext>(optionsBuilder =>
        {
            optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
        });
        services.AddHttpClient();

        return services.BuildServiceProvider(); ;
    }
}


