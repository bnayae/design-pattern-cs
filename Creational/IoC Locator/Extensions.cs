using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace IoC_Reduce_Parameters
{
    public static class Extensions
    {
        public static IC UseC(this IComponentContext ioc) => ioc.Resolve<IC>();
    }
}
