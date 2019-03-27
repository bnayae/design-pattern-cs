using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class ConsoleLogProvider : ILoggerProvider
    {
        private readonly ILogColor _logColor;

        public ConsoleLogProvider(ILogColor logColor)
        {
            _logColor = logColor;
        }
        public void Write(LogLevel level, string data)
        {
            var color = _logColor.GetColor(level);
            Console.ForegroundColor = color;
            Console.WriteLine(data);
            Console.ResetColor();
        }
    }
}
