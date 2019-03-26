using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Sample
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
