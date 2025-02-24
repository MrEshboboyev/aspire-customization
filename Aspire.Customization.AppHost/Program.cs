using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedis("Cache");

var apiService = builder.AddProject<Projects.ApiService>("apiservice");

var name = "swagger-ui-docs";
var displayName = "Swagger UI Documentation";
var openApiUiPath = "swagger";
apiService.WithCommand(
    name,
    displayName,
    executeCommand: async _ =>
    {
        try
        {
            // Base URL
            var endpoint = apiService.GetEndpoint("https");

            var url = $"{endpoint.Url}/{openApiUiPath}";

            Process.Start(new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            });

            return new ExecuteCommandResult { Success = true};
        }
        catch (Exception ex)
        {
            return new ExecuteCommandResult 
            { 
                Success = false, 
                ErrorMessage = ex.ToString() 
            };
        }
    }, 
    updateState: context => context.ResourceSnapshot.HealthStatus == HealthStatus.Healthy
        ? ResourceCommandState.Enabled : ResourceCommandState.Disabled,
    iconName: "Document",
    iconVariant: IconVariant.Filled);

builder.Build().Run();
