using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class ConsoleLogProvider : ILoggerProvider
    {
        public ConsoleLogProvider()
        {
        }
        public void Write(LogLevel level, string data)
        {
            Console.WriteLine(data);
        }
    }
}
