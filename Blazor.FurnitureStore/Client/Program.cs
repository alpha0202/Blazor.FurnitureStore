using Blazor.FurnitureStore.Client;
using Blazor.FurnitureStore.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

namespace Blazor.FurnitureStore.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("Blazor.FurnitureStore.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
            builder.Services.AddScoped<IProductService, ProductService>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Blazor.FurnitureStore.ServerAPI"));

            builder.Services.AddApiAuthorization();

            builder.Services.AddRadzenComponents();

            await builder.Build().RunAsync();
        }
    }
}