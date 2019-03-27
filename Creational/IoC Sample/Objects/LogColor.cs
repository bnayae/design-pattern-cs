using System;
using System.Collections.Generic;
using System.Text;

namespace Bnaya.Samples
{
    public class LogColor : ILogColor
    {
        public ConsoleColor GetColor(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Info:
                    return ConsoleColor.White;
                case LogLevel.Error:
                    return ConsoleColor.Magenta;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
