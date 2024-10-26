var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Products>("products");

builder.AddProject<Projects.Store>("store");

builder.Build().Run();
