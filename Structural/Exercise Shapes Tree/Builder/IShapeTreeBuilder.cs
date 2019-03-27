namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public interface IShapeTreeBuilder
    {
        IShapeTreeBuilder AddChild(Keys key);
        IShapeTreeBuilder AddNext(Keys key);
    }
}