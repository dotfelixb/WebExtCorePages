using Microsoft.AspNetCore.Builder;
using System;

namespace Barebone
{
    public class ConfigureAction : ExtCore.Infrastructure.Actions.IConfigureAction
    {
        public int Priority => 1000;

        public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseRouting();

            applicationBuilder.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
