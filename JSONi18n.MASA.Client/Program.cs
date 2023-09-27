using JSONi18n.MASA.Rcl;
using JSONi18n.MASA.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddMasaBlazor();
await builder.Services.AddMasaBlazor().AddI18nForWasmAsync(Path.Combine(builder.HostEnvironment.BaseAddress , "i18n"));


await builder.Build().RunAsync();
