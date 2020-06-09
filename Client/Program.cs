using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Client.Services;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDAxQDMxMzgyZTMxMmUzMFhkdm1XbFZraHZUa2tCOUxaaDUzRGN0SExZM1J2OUpuS1FiOGY2LzRmN3M9");
            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AttributeService>();
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
           
            builder.Services.AddSyncfusionBlazor(true);
            await builder.Build().RunAsync();
        }
    }
}
