using Microsoft.Extensions.Logging;

namespace RestfulApi.Common.Logging.Default
{
    /// <summary>
    /// The default builder extensions using ado.net/ef-core.
    /// </summary>
    public static class DefaultBuilderExtensions
    {
        /// <summary>
        /// Adds the Ado.Net default log.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>The <see cref="ILoggingBuilder"/>.</returns>
        public static ILoggingBuilder AddDbContext(this ILoggingBuilder builder)
        {
            return builder;
        }
    }
}
