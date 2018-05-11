using System;

namespace RestfulApi.Common.Logging.Default
{
    public class LogEntry
    {
        public int Id { get; set; }

        /// <summary>
        /// Other name: Application in Log4Net, NLog
        /// </summary>
        public string ModuleName { get; set; }

        public string Category { get; set; }

        public string Level { get; set; }

        public string Message { get; set; }

        public DateTime LogTime { get; set; }

        /// <summary>
        /// Other name: EventId in Log4Net, Callsite in NLog
        /// </summary>
        public string Thread { get; set; }

        /// <summary>
        /// Other name: Logger in Log4Net, NLog
        /// </summary>
        public string Source { get; set; }

        public string Exception { get; set; }
    }
}
