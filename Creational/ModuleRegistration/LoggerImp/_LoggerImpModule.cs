using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Bnaya.Samples
{
    public class LoggerImpModule : Module
    {
        public static readonly Module Default = new LoggerImpModule();

        private LoggerImpModule() { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Logger>()
                .As<ILogger>()
                .SingleInstance();
        }

    }
}
