var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache").WithRedisCommander();

var api = builder.AddProject<Projects.Products>("products")
    .WithReference(cache);

builder.AddProject<Projects.Store>("store")
    .WithExternalHttpEndpoints()
    .WithReference(api);

builder.Build().Run();
