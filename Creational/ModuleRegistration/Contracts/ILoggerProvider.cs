namespace IoC_Sample
{
    public interface ILoggerProvider
    {
        void Write(LogLevel level, string data);
    }
}