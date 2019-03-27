namespace Bnaya.Samples
{
    public interface IShapeBuilderFactory
    {
        IShapeTreeBuilder Create(Keys key);
    }
}