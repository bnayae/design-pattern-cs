using System;

namespace IoC_Sample
{
    public interface ILogColor
    {
        ConsoleColor GetColor(LogLevel level);
    }
}