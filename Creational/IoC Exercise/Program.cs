using System;
using Autofac;

namespace IoC_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var builder = new ContainerBuilder();
            builder.RegisterType<ImageManipulator>()
                   .As<IImageManip>()
                   .SingleInstance();
            builder.RegisterType<Blur>()
                   .As<IEffect>()
                   .SingleInstance();
            builder.RegisterType<BlurSetting>()
                   .As<IBlurSetting>()
                   .SingleInstance();
            builder.RegisterType<Skew>()
                   .As<IEffect>()
                   .SingleInstance();
            builder.RegisterType<SkewSetting>()
                   .As<ISkewSetting>()
                   .SingleInstance();
            builder.RegisterType<Grayscale>()
                   .As<IEffect>()
                   .SingleInstance();
            builder.RegisterType<GrayscaleSetting>()
                   .As<IGrayscaleSetting>()
                   .SingleInstance();
            var ioc = builder.Build();

            var processor = ioc.Resolve<IImageManip>();
            processor.Execute(@"Images\Dog.jpg", "Dog.jpg");


            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
