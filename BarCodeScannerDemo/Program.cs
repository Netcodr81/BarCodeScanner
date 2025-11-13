using BarCodeScannerDemo;
using BarCodeScannerDemo.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure HttpClient with API base URL from appsettings.json
var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7080";

builder.Services.AddHttpClient(Constants.ProductsApiClient, client =>
{
    client.BaseAddress = new Uri(apiBaseUrl ?? throw new InvalidOperationException("BarcodeApiBaseUrl is not configured."));
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.Timeout = TimeSpan.FromSeconds(30);
});

builder.Services.AddScoped<IFlowbiteService, FlowbiteService>();

await builder.Build().RunAsync();
