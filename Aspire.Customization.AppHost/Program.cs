using Aspire.Customization.AppHost;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ApiService>("apiservice")
    .WithSwaggerUI()
    .WithScalar()
    .WithReDoc();

builder.Build().Run();
