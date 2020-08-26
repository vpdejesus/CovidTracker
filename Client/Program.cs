using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client.Services;
using Syncfusion.Blazor;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk4NDk1QDMxMzgyZTMxMmUzMExnNC91SDJBYjB4WXVMWjJaTk9tbi9qc09yK0poa3A5c2c5azNNZnBndDQ9;Mjk4NDk2QDMxMzgyZTMxMmUzMEFJVndiTlBBcUlPUlFoMFdqcytOb0VMUnVQTGE0Z3FXVzF2VzUxRkd6OWc9;Mjk4NDk3QDMxMzgyZTMxMmUzMGtnL1NXRjdFMS9yeGg5UWxLVHZsbWNKN0UxaVljM0wzeTNYMmJ4UHpPRG89;Mjk4NDk4QDMxMzgyZTMxMmUzMFA5bDVWTjVzS2VtdXovRGw0K3pKN0QvKzBDVHZsOHc0ck9sZ084MEVuRmM9;Mjk4NDk5QDMxMzgyZTMxMmUzMFRPeUUxbUdRaU9KdmtUakxxWlhoREFudHNVeHlIdEpXZjB2YUlWTVFsY0E9;Mjk4NTAwQDMxMzgyZTMxMmUzMGszeWZJMWsrcmFud1BqMWNUSmtlTXBDbXdpVnNKam1Wb2VIQ1N0MDNhUHc9;Mjk4NTAxQDMxMzgyZTMxMmUzMEx1M0cwRVhQQ2pNdldZMXVid2s0eUJkanU1MkVPNzRTREk1MFpRdUlSOWc9;Mjk4NTAyQDMxMzgyZTMxMmUzMGpacm40SVBtNmtQRGhkYXcwQXRvRmJWZnVWTDl2UW1EWGQ5SFJ0Tmc2Mm89;Mjk4NTAzQDMxMzgyZTMxMmUzMEN3TWZjaWFPYStCZndyWFA1WHgya1lLdTJDdE5wdnltTlFZamFoU3ZzTlk9;NT8mJyc2IWhia31ifWN9ZmpoYmF8YGJ8ampqanNiYmlmamlmanMDHmglIzc2OTYgJiATND4yOj99MDw+;Mjk4NTA0QDMxMzgyZTMxMmUzMFNWbnIyZ2gwUjR4cEJiZHgwNUl2RDRRNkpmVUJRQXBKdGRiN1lySjFROHc9");            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AttributeService>();
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
