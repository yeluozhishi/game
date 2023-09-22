using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace mine_game.src.common
{
    public static class ExampleHelper
    {
        static ExampleHelper()
        {
            var builder = new ConfigurationBuilder();
            builder.Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true });
            Configuration = builder.Build();
        }

        public static string ProcessDirectory
        {
            get
            {
#if NETSTANDARD2_0 || NETCOREAPP3_1_OR_GREATER || NET5_0_OR_GREATER
                return AppContext.BaseDirectory;
#else
                return AppDomain.CurrentDomain.BaseDirectory;
#endif
            }
        }

        public static IConfigurationRoot Configuration { get; }

        //public static void SetConsoleLogger() => InternalLoggerFactory.DefaultFactory = LoggerFactory.Create(builder => builder.AddConsole());
    }
}
