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
            builder.RegisterType<DotPrime>()
                .WithAttributeFiltering()
                .Keyed<IShape>(Keys.DotPrime)
                .SingleInstance();
            builder.RegisterType<DotSecond>()
                .Keyed<IShape>(Keys.DotSecond)
                .SingleInstance();
            //builder.Register(c =>
            //{
            //    var sign = c.Resolve<IDrawingChar>();
            //    return new Line2Prime(sign);
            //})
            builder.RegisterType<Line2Prime>()
               .Keyed<IShape>(Keys.Line2Prime)
               .SingleInstance();
            builder.RegisterType<Line2Second>()
               .Keyed<IShape>(Keys.Line2Second)
               .SingleInstance();
            builder.RegisterType<Line4Prime>()
               .Keyed<IShape>(Keys.Line4Prime)
               .SingleInstance();
            builder.RegisterType<Line4Second>()
               .Keyed<IShape>(Keys.Line4Second)
               .SingleInstance();
            builder.RegisterType<Smile>()
                .WithAttributeFiltering()
               .Keyed<IShape>(Keys.Smile)
               .SingleInstance();
            builder.RegisterType<SlideNose>()
                .WithAttributeFiltering()
               .Keyed<IShape>(Keys.SlideNose)
               .SingleInstance();
            //builder.Register(c =>
            //{
            //    var d = c.ResolveKeyed<IShape>(Keys.Line2Prime);
            //    return new Rect2x2Prime(d);
            //})
            builder.RegisterType<Rect2x2Prime>()
                .WithAttributeFiltering()
               .Keyed<IShape>(Keys.Rect2x2Prime)
               .SingleInstance();
            builder.RegisterType<Rect2x2Second>()
                .WithAttributeFiltering()
               .Keyed<IShape>(Keys.Rect2x2Second)
               .SingleInstance();
            builder.RegisterType<Rect4x2Prime>()
                .WithAttributeFiltering()
               .Keyed<IShape>(Keys.Rect4x2Prime)
               .SingleInstance();
            builder.Register<Face>(c =>
            {
                var eye = c.ResolveKeyed<IShape>(Keys.Rect2x2Prime);
                var nose = c.ResolveKeyed<IShape>(Keys.SlideNose);
                var mouth = c.ResolveKeyed<IShape>(Keys.Rect4x2Prime);
                return new Face(eye, nose, mouth);
            })
                .Keyed<IShape>(Keys.Face)
                .SingleInstance();
            builder.RegisterType<FaceWink>()
                .WithAttributeFiltering()
                .Keyed<IShape>(Keys.FaceWink)
                .SingleInstance();

            var drawingChar = new DrawingChar('#', 'V');
            builder.RegisterInstance(drawingChar).As<IDrawingChar>();

            builder.RegisterType<ShapeTreeBuilder>()
               .As<IShapeBuilderFactory>()
               .As<IShapeTreeBuilder>()
               .SingleInstance();

            var ioc = builder.Build();

            var shapeBuilder = ioc.Resolve<IShapeBuilderFactory>();

            IShape shape = shapeBuilder.Create(Keys.Face)
                        .AddNext(Keys.FaceWink)
                        .Build();

            var offseter = new Offseter(2, 2);
            shape.Display(offseter);

            Console.WriteLine();
        }
    }
}
