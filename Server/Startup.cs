using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Services;
using Syncfusion.Blazor;

namespace Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();
            services.AddScoped<AttributeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzYyNTY5QDMxMzgyZTMzMmUzMGxqWWRTNnV1ZCtkYzYzdGRhaG1LR2NGU2hhK25WMUFxYVkxdUsxRCtCS1k9;MzYyNTcwQDMxMzgyZTMzMmUzMGNtMmpIVnRuakFod0UzYUpwT2VMV05UbEtLMXNiZHJha3pnT1pmYmczNUE9;MzYyNTcxQDMxMzgyZTMzMmUzMEI5TEZQdWtvcjlmMytIN3lsYjhoTStxNmprMThCQ0Rvc2QyazcxWHAvTHM9;MzYyNTcyQDMxMzgyZTMzMmUzMG1BZ21yZ0g0VlJqcDdMV0xPcTA4RFhvQmxnYVo5a3JKOHJTMjh5WDJDQXM9;MzYyNTczQDMxMzgyZTMzMmUzMGwremZYc3lXa3pCZmtnVWV4c09hbGFCSTByNm5VU2tlRkcybUNDOXgzWDA9;MzYyNTc0QDMxMzgyZTMzMmUzMEYyNi9BM3l0WXVzM3lCTEF4M3VqNEY4K3dvK0RZMlBWenRGbGZvN25KTWs9;MzYyNTc1QDMxMzgyZTMzMmUzMFlHclF0RVpLc1Y0bGk5bEhSWFd6VWkwVnBmMml3NmF3M2VTeTJlWFZmNUU9;MzYyNTc2QDMxMzgyZTMzMmUzMGNYUi9uMHBWWi9FMmNtRHRxa2F1K3lvTmtkU3JVWkZBNG1nd0xLeENSRGM9;MzYyNTc3QDMxMzgyZTMzMmUzMEhnZ29uck9NYlBaNVk0VmZrTXV3T0pUWFRYRTZvdEdWS25mL1BJQnREbWM9;MzYyNTc4QDMxMzgyZTMzMmUzMFJPS2NUUVc2NkJ0bkFEOWRkdUFYMUsweHoreENFT3hWYjZjdHFadm13bmc9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
