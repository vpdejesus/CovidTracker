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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE4ODczQDMxMzgyZTMyMmUzMG9VcUt4RmIrbS95Q2NNTTZISjFaV1YwQmtobHhUbW5oMjh0RkNKWE04bTA9;MzE4ODc0QDMxMzgyZTMyMmUzMEU5NTRkWTB6RmdPUm1hY0o1N0QxM2c5RzFzUXI1aUkyUE1oNUx3eE5NRkk9;MzE4ODc1QDMxMzgyZTMyMmUzMFIyNk8vOU9tOFE1cVhMSExzRCsvSUR0ajh0WEswVUNVTVU3aEMxK1JhbGM9;MzE4ODc2QDMxMzgyZTMyMmUzME91bHM3Q0JpRVhMc25wSng1SWVraHd1NUtnUEdrTnNid1ZHUFhHSUNaKzA9;MzE4ODc3QDMxMzgyZTMyMmUzMEFhblF4RWlNcFNhSlRvZWUwNEVJUzF1UEt4M3pJQnZuOStCSktiOXV4RGc9;MzE4ODc4QDMxMzgyZTMyMmUzME1YTlhBRDVzN1FDdzZYSnptdnFXUWExZVpuR3ZGMFJKbTExa0VLV0ttNGc9;MzE4ODc5QDMxMzgyZTMyMmUzMEJ4TnhoYkpVMkZSZjNyNXpRR2srbndvcC93Ly9qcmFRR1VhcEk3SzNLYUU9;MzE4ODgwQDMxMzgyZTMyMmUzMGtOSFNDbGZkd1VUYyt5SVlVd1Fnd1RWS3dXQ3E0bDhaYzk3QStiMFdIbGM9;MzE4ODgxQDMxMzgyZTMyMmUzMFNBTTZJakJiU1d3MFEzWWFLdFVKeERTL2ROc3FSbjZISzRKdzN5aWdPTFU9;NT8mJyc2IWhia31hfWN9ZmZoYmF8YGJ8ampqanNiYmlmamlmanMDHmglIzc2OTYgJiATND4yOj99MDw+;MzE4ODgyQDMxMzgyZTMyMmUzME5HY2NkL3UxMlMxRG9zWGJPZG1sN051b3dYSlgyNjhDcGJHSm1XM05LZVE9");            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AttributeService>();
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
