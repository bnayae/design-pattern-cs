using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace IoC_Sample
{
    public class DevLogger : ILogger
    {
        private readonly ILoggerProvider _provider;

        public DevLogger([KeyFilter("C")]ILoggerProvider provider)
        {
            _provider = provider;
        }

        public void Error(string message, Exception ex)
        {
            _provider.Write(LogLevel.Error, $"{message}: {ex}");
        }

        public void Info(string message)
        {
            _provider.Write(LogLevel.Info, message);
        }
    }
}
