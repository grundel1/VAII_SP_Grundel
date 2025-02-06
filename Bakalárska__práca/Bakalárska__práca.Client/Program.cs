using Bakalárska__práca.Client;
using Bakalárska__práca.Shared.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
builder.Services.AddScoped<IOrderService, ClientOrderService>();
builder.Services.AddScoped<IDentistService, ClientDentistService>();
builder.Services.AddScoped<IReviewService, ClientReviewService>();
builder.Services.AddScoped<IUserService, ClientUserService>();

await builder.Build().RunAsync();
