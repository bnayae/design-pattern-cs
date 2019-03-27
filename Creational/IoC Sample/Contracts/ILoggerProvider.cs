namespace Bnaya.Samples
{
    public interface ILoggerProvider
    {
        void Write(LogLevel level, string data);
    }
}