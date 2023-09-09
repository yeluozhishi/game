using Microsoft.Extensions.Configuration;
using System;

namespace mine_game.src.common
{
    public static class ExampleHelper
    {
        static ExampleHelper()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(ProcessDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();
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
