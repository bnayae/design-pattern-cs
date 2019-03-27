using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Autofac;

namespace Bnaya.Samples
{
    public class TraceLogProvider : ILoggerProvider
    {
        //private readonly IContainer _container;

        //public TraceLogProvider(IContainer container)
        //{
        //    _container = container; // service locator
        //}

        public void Write(LogLevel level, string data)
        {
            //var logColor = _container.Resolve<ILogColor>();
            //var color = logColor.GetColor(level);
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss}: {level}, {data}");
        }
    }
}
