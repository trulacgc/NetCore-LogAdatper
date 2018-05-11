using Microsoft.Extensions.Logging;

namespace RestfulApi.Common.Logging.Log4Net
{
    /// <summary>
    /// The log4net extensions class.
    /// </summary>
    public static class Log4NetBuilderExtensions
    {
        /// <summary>
        /// Adds the log4net.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="log4NetConfigFile">The log4net Config File.</param>
        /// <returns>The <see cref="ILoggingBuilder"/>.</returns>
        public static ILoggingBuilder AddLog4Net(this ILoggingBuilder builder, string log4NetConfigFile)
        {
            return builder;
        }

        /// <summary>
        /// Adds the log4net.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>The <see cref="ILoggingBuilder"/>.</returns>
        public static ILoggingBuilder AddLog4Net(this ILoggingBuilder builder)
        {
            return builder;
        }
    }
}
