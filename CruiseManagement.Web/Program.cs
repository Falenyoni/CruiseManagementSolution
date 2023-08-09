using CruiseManagement.Web;
using CruiseManagement.Web.Services.Contracts;
using CruiseManagement.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(" https://localhost:7267/") });
builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IReservetionService, ReservationService>();

await builder.Build().RunAsync();
