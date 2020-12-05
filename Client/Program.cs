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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzYyNTY5QDMxMzgyZTMzMmUzMGxqWWRTNnV1ZCtkYzYzdGRhaG1LR2NGU2hhK25WMUFxYVkxdUsxRCtCS1k9;MzYyNTcwQDMxMzgyZTMzMmUzMGNtMmpIVnRuakFod0UzYUpwT2VMV05UbEtLMXNiZHJha3pnT1pmYmczNUE9;MzYyNTcxQDMxMzgyZTMzMmUzMEI5TEZQdWtvcjlmMytIN3lsYjhoTStxNmprMThCQ0Rvc2QyazcxWHAvTHM9;MzYyNTcyQDMxMzgyZTMzMmUzMG1BZ21yZ0g0VlJqcDdMV0xPcTA4RFhvQmxnYVo5a3JKOHJTMjh5WDJDQXM9;MzYyNTczQDMxMzgyZTMzMmUzMGwremZYc3lXa3pCZmtnVWV4c09hbGFCSTByNm5VU2tlRkcybUNDOXgzWDA9;MzYyNTc0QDMxMzgyZTMzMmUzMEYyNi9BM3l0WXVzM3lCTEF4M3VqNEY4K3dvK0RZMlBWenRGbGZvN25KTWs9;MzYyNTc1QDMxMzgyZTMzMmUzMFlHclF0RVpLc1Y0bGk5bEhSWFd6VWkwVnBmMml3NmF3M2VTeTJlWFZmNUU9;MzYyNTc2QDMxMzgyZTMzMmUzMGNYUi9uMHBWWi9FMmNtRHRxa2F1K3lvTmtkU3JVWkZBNG1nd0xLeENSRGM9;MzYyNTc3QDMxMzgyZTMzMmUzMEhnZ29uck9NYlBaNVk0VmZrTXV3T0pUWFRYRTZvdEdWS25mL1BJQnREbWM9;MzYyNTc4QDMxMzgyZTMzMmUzMFJPS2NUUVc2NkJ0bkFEOWRkdUFYMUsweHoreENFT3hWYjZjdHFadm13bmc9");            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AttributeService>();
            builder.RootComponents.Add<App>("app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
