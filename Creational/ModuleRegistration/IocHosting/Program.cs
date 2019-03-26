using System;
using Autofac;
using IoC_Sample;

namespace IocHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(ConsoleLoggerModule.Default);
            builder.RegisterModule(LoggerImpModule.Default);

            var ioc = builder.Build();
            var logger = ioc.Resolve<ILogger>();

            logger.Info("Hi");
            Console.WriteLine("Hello World!");
        }
    }
}
