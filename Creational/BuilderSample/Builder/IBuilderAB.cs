namespace Bnaya.Samples
{
    public interface IBuilderAB : IBuilder
    {
        IBuilderB A();
        IBuilderA B();
    }
}