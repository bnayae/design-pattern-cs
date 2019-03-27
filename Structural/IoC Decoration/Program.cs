using System;
using Autofac;
using FakeItEasy;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterDecorator<BarDecorator, IFoo>();
            builder.RegisterDecorator<FooDecorator, IFoo>();
            builder.RegisterDecorator<BarDecorator, IFoo>();
            
            builder.RegisterType<Foo>()
                .As<IFoo>()
                .SingleInstance();
            builder.RegisterType<Manager>()
                .As<IManager>()
                .SingleInstance();
            var setting = A.Fake<ISetting>();
            A.CallTo(() => setting.Active).Returns(true);
            builder.RegisterInstance(setting);
            var ioc = builder.Build();
            var m = ioc.Resolve<IManager>();
            m.Run();

            Console.ReadKey();
        }
    }
}
