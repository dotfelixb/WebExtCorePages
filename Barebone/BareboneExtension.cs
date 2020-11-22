namespace Barebone
{
    using ExtCore.Infrastructure;

    using ExtCore.Infrastructure.Actions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class BareboneExtension : ExtensionBase
    {
        public override string Name => "Barebone Extension";
    }

    public class ConfigureServiceAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }
    }

    public class ConfigureAction : IConfigureAction
    {
        public int Priority => 1000;

        public void Execute(IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
