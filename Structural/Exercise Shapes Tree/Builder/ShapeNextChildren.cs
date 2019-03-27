using System;
using System.Collections.Immutable;
using Autofac.Features.Indexed;

namespace Bnaya.Samples
{
    public class ShapeNextChildren: ShapeChildren
    {
        private readonly Keys _key;
        #region Ctor


        public ShapeNextChildren(Keys key, IShape value): base()
        {
            _key = key;
            Value = value;
        }
        public ShapeNextChildren(Keys key, IShape value, IImmutableList<IShape> children): base (children)
        {
            _key = key;
            Value = value;
        }

        public ShapeNextChildren(Keys key, IShape value, IShape next, IImmutableList<IShape> children)
            : base(children)
        {
            _key = key;
            Value = value;
            Next = next;
        }

        #endregion // Ctor

        public IShape Value { get; } = NullShape.Default;
        public IShape Next { get; } = NullShape.Default;

        #region Display

        public override void Display(IOffseter offseter)
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~  Start Display of [{_key}] ~~~~~~~~~~~~~~~~~");
            Value.Display(offseter);
            ClickToContinue();
            base.Display(offseter);
            Next.Display(offseter);
            ClickToContinue();
        }

        #endregion // Display

        // Prototype pattern
        public ShapeNextChildren AddChild(Keys key, IShape shape) => new ShapeNextChildren(key, Value, Next, Children.Add(shape));
        // Prototype pattern
        public ShapeNextChildren SetNext(Keys key, IShape shape) => new ShapeNextChildren(key, Value, shape, Children);
    }
}