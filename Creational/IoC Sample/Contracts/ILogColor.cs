using System;

namespace Bnaya.Samples
{
    public interface ILogColor
    {
        ConsoleColor GetColor(LogLevel level);
    }
}