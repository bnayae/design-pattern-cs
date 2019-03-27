namespace Bnaya.Samples
{
    public interface IShapeTreeBuilder
    {
        IShapeTreeBuilder AddChild(Keys key);
        IShapeTreeBuilder AddNext(Keys key);

        IShape Build();
    }
}