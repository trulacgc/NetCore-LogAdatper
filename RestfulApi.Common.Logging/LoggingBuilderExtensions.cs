using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestfulApi.Common.Logging.Log4Net;
using RestfulApi.Common.Logging.Default;

namespace RestfulApi.Common.Logging
{
    public static class LoggingBuilderExtensions
    {
        public static ILoggingBuilder UseConfiguration(this ILoggingBuilder loggingBuilder, IConfigurationSection configurationSection)
        {
            var provider = GetProvider(configurationSection);

            if(provider == ProviderType.Unknown)
            {
                return loggingBuilder;
            }

            // TODO - dynamic call to each of builder
            switch (provider)
            {
                case ProviderType.Log4Net:
                    loggingBuilder.AddLog4Net();
                    break;
                case ProviderType.NLog:
                    break;
                case ProviderType.Serilog:
                    break;
                default:
                    loggingBuilder.AddDbContext();
                    break;
            }

            return loggingBuilder;
        }

        public static ProviderType GetProvider(IConfigurationSection configurationSection)
        {
            var config = new ProviderConfiguration();

            try
            {
                configurationSection.Bind(config);
            }
            catch
            {
                config.Name = ProviderType.Default;
            }

            return config.Name;
        }
    }
}
