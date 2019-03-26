namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public interface IShapeTree
    {
        IShape Shape { get; }

        void AddChild(IShape child);
    }
}