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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY2NTQ5QDMxMzgyZTMxMmUzMFdhYnpLckNXeWNrczhOOXF0MmlYTmhNcWhmMVVBMGRqWndoTGZ3VG1DVDQ9;MjY2NTUwQDMxMzgyZTMxMmUzMG1lZ1RLam80a2NVVjlzWU9PemJTR3FUZnpoRjJVN0JSRlZhUW8rTmVOU1E9;MjY2NTUxQDMxMzgyZTMxMmUzMEM5MGx0b1lqN3N6Y2JXTWZsT2V0R0J0eDhGWmYvQVVYL3pxem1ydk56RnM9;MjY2NTUyQDMxMzgyZTMxMmUzMFFVZkpwUlRxNk9YVkpoVWVsZVFUbDZWUjRDYW1lb1J5U2tScVdjWlc1WG89;MjY2NTUzQDMxMzgyZTMxMmUzMGtSUjUrUTJPQVVDYXZiSWdvZ0xWUU10dDNLUzRJb2cxM1VSR3V6SmFLKzQ9;MjY2NTU0QDMxMzgyZTMxMmUzMFllN1ZpMExKRlhqVElVa2tBYkFKK2NzZWZUOHdQd294S3RwMlpVWXIzeXM9;MjY2NTU1QDMxMzgyZTMxMmUzMEJOUFJIb0U3a3A3TmkyZzJrbitBaE1zZzk1TWx3Mk9GTlh1OFVpT3Fpc1k9;MjY2NTU2QDMxMzgyZTMxMmUzMEkwVzRlemx0aHFxNzZyZG5ZVFNGVkIrQmUzR2ppQnBGdGUrYUVJU284Qlk9;MjY2NTU3QDMxMzgyZTMxMmUzMEZ4S05Rdk5FZGNiUzIwVDlnNDV4TWgwV2VKS1FYSnBNOHNLVGFNakJwRjQ9;NT8mJyc2IWhia31ifWN9ZmZoYmF8YGJ8ampqanNiYmlmamlmanMDHmglIzc2OTYgJiATND4yOj99MDw+;MjY2NTU4QDMxMzgyZTMxMmUzMEpJTjNPNGlMYnpCdFNNa3RneFZMTkhDa0Q3dHdTemFnNWgwWXpzMWtDekE9");

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
