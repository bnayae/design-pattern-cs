namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public interface IShapeTreeBuilder
    {
        IShapeTreeBuilder AddChild(string key);
        IShapeTreeBuilder AddNext(string key);
    }
}