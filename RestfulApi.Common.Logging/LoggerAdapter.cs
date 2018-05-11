using System;
using Microsoft.Extensions.Logging;
using RestfulApi.Common.Core;

namespace RestfulApi.Common.Logging
{
    public class LoggerAdapter : ILoggerAdapter
    {
        private ILoggerFactory _loggerFactory;

        public LoggerAdapter()
        {
            if(_loggerFactory == null)
            {
                // Create a default loggerFactory
                // _loggerFactory = new LoggerFactory();
            }
        }

        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void LogError(Exception ex, string message)
        {
            // TODO - implement
        }

        public void LogInformation(string message)
        {
            // TODO - implement
        }

        public void LogWarning(string message)
        {
            // TODO - implement
        }
    }
}
