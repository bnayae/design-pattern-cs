using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Bnaya.Samples
{
    public static class Extensions
    {
        public static IC UseC(this IComponentContext ioc) => ioc.Resolve<IC>();
    }
}
