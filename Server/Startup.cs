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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE4ODczQDMxMzgyZTMyMmUzMG9VcUt4RmIrbS95Q2NNTTZISjFaV1YwQmtobHhUbW5oMjh0RkNKWE04bTA9;MzE4ODc0QDMxMzgyZTMyMmUzMEU5NTRkWTB6RmdPUm1hY0o1N0QxM2c5RzFzUXI1aUkyUE1oNUx3eE5NRkk9;MzE4ODc1QDMxMzgyZTMyMmUzMFIyNk8vOU9tOFE1cVhMSExzRCsvSUR0ajh0WEswVUNVTVU3aEMxK1JhbGM9;MzE4ODc2QDMxMzgyZTMyMmUzME91bHM3Q0JpRVhMc25wSng1SWVraHd1NUtnUEdrTnNid1ZHUFhHSUNaKzA9;MzE4ODc3QDMxMzgyZTMyMmUzMEFhblF4RWlNcFNhSlRvZWUwNEVJUzF1UEt4M3pJQnZuOStCSktiOXV4RGc9;MzE4ODc4QDMxMzgyZTMyMmUzME1YTlhBRDVzN1FDdzZYSnptdnFXUWExZVpuR3ZGMFJKbTExa0VLV0ttNGc9;MzE4ODc5QDMxMzgyZTMyMmUzMEJ4TnhoYkpVMkZSZjNyNXpRR2srbndvcC93Ly9qcmFRR1VhcEk3SzNLYUU9;MzE4ODgwQDMxMzgyZTMyMmUzMGtOSFNDbGZkd1VUYyt5SVlVd1Fnd1RWS3dXQ3E0bDhaYzk3QStiMFdIbGM9;MzE4ODgxQDMxMzgyZTMyMmUzMFNBTTZJakJiU1d3MFEzWWFLdFVKeERTL2ROc3FSbjZISzRKdzN5aWdPTFU9;NT8mJyc2IWhia31hfWN9ZmZoYmF8YGJ8ampqanNiYmlmamlmanMDHmglIzc2OTYgJiATND4yOj99MDw+;MzE4ODgyQDMxMzgyZTMyMmUzME5HY2NkL3UxMlMxRG9zWGJPZG1sN051b3dYSlgyNjhDcGJHSm1XM05LZVE9");

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
