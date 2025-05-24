using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenbankingProductMcp.Echos;
using OpenbankingProductMcp.Proxies;
using OpenbankingProductMcp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
builder.Services.AddHttpClient<IProductProxy, ProductProxy>();
builder.Services.AddSingleton<CbaProductsService>();

builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithTools<EchoProduct>();

var app = builder.Build();

app.MapMcp();

app.Run();