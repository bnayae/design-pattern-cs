namespace BuilderSample
{
    public interface IBuilderAB : IBuilder
    {
        IBuilderB A();
        IBuilderA B();
    }
}