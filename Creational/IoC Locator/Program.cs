using System;
using Autofac;
using FakeItEasy;

namespace IoC_Reduce_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(A.Fake<IA>())
                .As<IA>()
                .SingleInstance();
            builder.RegisterInstance(A.Fake<IB>())
                .As<IB>()
                .SingleInstance();
            builder.RegisterInstance(A.Fake<IC>())
                .As<IC>()
                .SingleInstance();
            builder.RegisterInstance(A.Fake<ID>())
                .As<ID>()
                .SingleInstance();
            builder.RegisterInstance(A.Fake<IE>())
                .As<IE>()
                //.AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterType<Logic>();
            var ioc = builder.Build();
            var logic = ioc.Resolve<Logic>();
            
        }
    }
}
