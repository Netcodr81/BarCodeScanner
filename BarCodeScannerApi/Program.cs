using BarCodeScannerApi;
using BarCodeScannerApi.Data;
using BarCodeScannerApi.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using SharedKernel.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContextFactory<BarcodeContext>();

using var scope = builder.Services.BuildServiceProvider().CreateScope();
var dbContextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<BarcodeContext>>();

var db = dbContextFactory.CreateDbContext();
DbSeeder.Seed(db);

builder.Services.AddHttpClient(ConfigurationConstants.BarCodeApiClient, client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BarcodeApiBaseUrl") ?? throw new InvalidOperationException("BarcodeApiBaseUrl is not configured."));
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.Timeout = TimeSpan.FromSeconds(30);
});

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options => { options.WithTheme(ScalarTheme.Moon); });
}

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
});

app.MapGet("/api/products", async Task<IResult> (
        IDbContextFactory<BarcodeContext> contextFactory,
        IConfiguration configuration,
        IHttpClientFactory httpClientFactory,
        [FromQuery] long upc) =>
    {
        var useFakeService = configuration.GetValue<bool>("UseFakeBarcodeService");

        if (upc <= 0)
        {
            return TypedResults.BadRequest("UPC query parameter is required.");
        }

        if (useFakeService)
        {
            using var context = contextFactory.CreateDbContext();

            var items = context.Items.Where(x => x.UPC == upc).ToList();

            return TypedResults.Ok(new BarcodeResponse {Total = items.Count, Items = items});
        }

        var client = httpClientFactory.CreateClient(ConfigurationConstants.BarCodeApiClient);
        var response = await client.GetAsync($"/prod/trial/lookup?upc={upc}");

        if (response.IsSuccessStatusCode)
        {
            var barcodeResponse = await response.Content.ReadFromJsonAsync<BarcodeResponse>();
            return TypedResults.Ok(
                new BarcodeResponse
                {
                    Total = barcodeResponse?.Total ?? 0,
                    Items = barcodeResponse?.Items ?? new List<Item>()
                });
        }

        return TypedResults.StatusCode((int) response.StatusCode);
    })
    .WithName("Get Products By Upc")
    .WithTags("Products");

app.UseHttpsRedirection();


app.Run();