using CoursDemosBlazor;
using CoursDemosBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddScoped<IMarmosetService,FakeApiMarmosetService>();
builder.Services.AddSingleton<IMarmosetService,FakeDbMarmosetService>();

await builder.Build().RunAsync();
