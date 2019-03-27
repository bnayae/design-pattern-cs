using System;
using System.Collections.Immutable;
using Autofac.Features.Indexed;

namespace Bnaya.Samples
{
    public class ShapeChildren : IShape
    {
        #region Ctor

        public ShapeChildren() { }
        public ShapeChildren(IImmutableList<IShape> children)
        {
            Children = children;
        }

        #endregion // Ctor

        public IImmutableList<IShape> Children { get; } = ImmutableList<IShape>.Empty;

        #region Display

        public virtual void Display(IOffseter offseter)
        {
            int i = 0;
            foreach (var child in Children)
            {
                Console.WriteLine($"Display Child [{i++}]");
                offseter.Reset();
                child.Display(offseter);
                ClickToContinue();
            }
        }

        protected void ClickToContinue()
        {
            Console.ResetColor();
            Console.WriteLine();
            System.Console.WriteLine("Press any key in order to display the next shape");
            Console.ReadKey(true);
            Console.Clear();
        }

        #endregion // Display

        // Prototype pattern
        public ShapeChildren AddChild(IShape shape) => new ShapeChildren(Children.Add(shape));
        // Prototype pattern
    }
}