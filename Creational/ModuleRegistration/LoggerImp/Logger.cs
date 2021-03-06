﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    internal class Logger : ILogger
    {
        private readonly ILoggerProvider[] _providers;

        public Logger(ILoggerProvider[] providers)
        {
            _providers = providers;
        }

        public void Error(string message, Exception ex)
        {
            foreach (var p in _providers)
            {
                p.Write(LogLevel.Error, $"{message}: {ex}");
            }
        }

        public void Info(string message)
        {
            foreach (var p in _providers)
            {
                p.Write(LogLevel.Info, message);
            }
        }
    }
}
