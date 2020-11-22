using Microsoft.Extensions.DependencyInjection;
using System;

namespace Barebone
{
    public class ConfigureServiceAction : ExtCore.Infrastructure.Actions.IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddRazorPages();
        }
    }
}
