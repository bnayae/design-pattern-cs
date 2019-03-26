using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using IoC_Sample;

namespace System
{
    public class ConsoleLoggerModule : Module
    {
        public static readonly Module Default = new ConsoleLoggerModule();

        private ConsoleLoggerModule() { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleLogProvider>()
                .As<ILoggerProvider>()
                .SingleInstance();
        }

    }
}
