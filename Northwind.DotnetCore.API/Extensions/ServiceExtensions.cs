using Microsoft.Extensions.DependencyInjection;
using Northwind.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DotnetCore.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<LoggerManager, LoggerManager>();
        }
    }
}
