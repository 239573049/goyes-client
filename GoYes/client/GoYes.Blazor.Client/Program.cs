using GoYes.Blazor.Client;
using GoYes.Client.Pages;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
await builder.Services.AddClientPage(builder.Configuration);

var app = builder.Build();

await app.RunAsync();
