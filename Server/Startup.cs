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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk4NDk1QDMxMzgyZTMxMmUzMExnNC91SDJBYjB4WXVMWjJaTk9tbi9qc09yK0poa3A5c2c5azNNZnBndDQ9;Mjk4NDk2QDMxMzgyZTMxMmUzMEFJVndiTlBBcUlPUlFoMFdqcytOb0VMUnVQTGE0Z3FXVzF2VzUxRkd6OWc9;Mjk4NDk3QDMxMzgyZTMxMmUzMGtnL1NXRjdFMS9yeGg5UWxLVHZsbWNKN0UxaVljM0wzeTNYMmJ4UHpPRG89;Mjk4NDk4QDMxMzgyZTMxMmUzMFA5bDVWTjVzS2VtdXovRGw0K3pKN0QvKzBDVHZsOHc0ck9sZ084MEVuRmM9;Mjk4NDk5QDMxMzgyZTMxMmUzMFRPeUUxbUdRaU9KdmtUakxxWlhoREFudHNVeHlIdEpXZjB2YUlWTVFsY0E9;Mjk4NTAwQDMxMzgyZTMxMmUzMGszeWZJMWsrcmFud1BqMWNUSmtlTXBDbXdpVnNKam1Wb2VIQ1N0MDNhUHc9;Mjk4NTAxQDMxMzgyZTMxMmUzMEx1M0cwRVhQQ2pNdldZMXVid2s0eUJkanU1MkVPNzRTREk1MFpRdUlSOWc9;Mjk4NTAyQDMxMzgyZTMxMmUzMGpacm40SVBtNmtQRGhkYXcwQXRvRmJWZnVWTDl2UW1EWGQ5SFJ0Tmc2Mm89;Mjk4NTAzQDMxMzgyZTMxMmUzMEN3TWZjaWFPYStCZndyWFA1WHgya1lLdTJDdE5wdnltTlFZamFoU3ZzTlk9;NT8mJyc2IWhia31ifWN9ZmpoYmF8YGJ8ampqanNiYmlmamlmanMDHmglIzc2OTYgJiATND4yOj99MDw+;Mjk4NTA0QDMxMzgyZTMxMmUzMFNWbnIyZ2gwUjR4cEJiZHgwNUl2RDRRNkpmVUJRQXBKdGRiN1lySjFROHc9");

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
