using System;
using System.Collections.Immutable;
using Autofac.Features.Indexed;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class ShapeNode: IShape
    {
        #region Ctor

        public ShapeNode()
        {
        }
        public ShapeNode(IShape value)
        {
            Value = value;
        }
        public ShapeNode(IShape value, IImmutableList<IShape> children)
        {
            Value = value;
            Children = children;
        }

        public ShapeNode(IShape value, IShape next, IImmutableList<IShape> children)
        {
            Value = value;
            Next = next;
            Children = children;
        }

        #endregion // Ctor

        public IShape Value { get; } = NullShape.Default;
        public IShape Next { get; } = NullShape.Default;
        public IImmutableList<IShape> Children { get; } = ImmutableList<IShape>.Empty;

        #region Display

        public void Display(IOffseter offseter)
        {
            Display(Value, offseter);
            Display(Next, offseter);
            foreach (var child in Children)
            {
                Display(child, offseter);
            }
        }

        private void Display(IShape shape, IOffseter offseter)
        {
            shape.Display(offseter);
            offseter.Next();

            Console.ResetColor();
            System.Console.WriteLine("Press any key in order to display the next shape");
            Console.Clear();
        }

        #endregion // Display

        // Prototype pattern
        public ShapeNode AddChild(IShape shape) => new ShapeNode(Value, Next, Children.Add(shape));
        // Prototype pattern
        public ShapeNode SetNext(IShape shape) => new ShapeNode(Value, shape, Children);
    }
}