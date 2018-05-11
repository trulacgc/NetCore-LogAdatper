using Microsoft.Extensions.Logging;

namespace RestfulApi.Common.Logging.NLog
{
    /// <summary>
    /// The NLog extensions class.
    /// </summary>
    public static class NLogBuilderExtensions
    {
        /// <summary>
        /// Adds the Nlog.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>The <see cref="ILoggingBuilder"/>.</returns>
        public static ILoggingBuilder AddNLog(this ILoggingBuilder builder)
        {
            return builder;
        }
    }
}
