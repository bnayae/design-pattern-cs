using System;
using Autofac;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Logger>()
                   .As<ILogger>()
                   .SingleInstance();
            //builder.RegisterType<DevLogger>()
            //       .WithAttributeFiltering()
            //       .As<ILogger>()
            //       .SingleInstance();
            builder.Register(ctx =>
            {
                ILogColor logColor = ctx.Resolve<ILogColor>();
                return new ConsoleLogProvider(logColor);
            })
            .As<ILoggerProvider>()
            .Keyed<ILoggerProvider>("C")
            .SingleInstance();
            builder.RegisterType<TraceLogProvider>()
                   .As<ILoggerProvider>()
                   .Keyed<ILoggerProvider>("T")
                   .SingleInstance();
            builder.RegisterType<LogColor>()
                .As<ILogColor>()
                .SingleInstance();

            builder.RegisterType<Greeting>()
                .As<IGreet>()
                .SingleInstance();

            builder.RegisterType<Hello>()
                .Keyed<IGreet>(DayOfWeek.Sunday)
                .SingleInstance();
            builder.RegisterType<Goodbye>()
                .Keyed<IGreet>(DayOfWeek.Monday)
                .SingleInstance();

            IContainer ioc = builder.Build();


            var p = ioc.ResolveKeyed<ILoggerProvider>("C");
            var logger = ioc.Resolve<ILogger>();

            logger.Info("Some info");
            logger.Error("Problem", new ArgumentException("X"));


            var greet = ioc.Resolve<IGreet>();
            greet.Greet();
            Console.ReadKey();


        }
    }
}
