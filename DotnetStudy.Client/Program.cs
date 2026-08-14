// using Microsoft.AspNetCore.Components.Web;
// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
// using DotnetStudy.Client;

// var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.RootComponents.Add<App>("#app");
// builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// builder.Services.AddFluentUIComponents();

// await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFluentUIComponents();

await builder.Build().RunAsync();
