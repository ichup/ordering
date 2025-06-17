using Ordering.Core;
using Ordering.Infrastructure;
using Ordering.Services;

var builder = WebApplication.CreateBuilder(args);

#region Depndency Injection
builder.Services.AddServices();
builder.Services.AddInfrastructure();
builder.Services.AddCore();
#endregion

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<OrderHistoryService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
