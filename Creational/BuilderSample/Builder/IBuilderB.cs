namespace BuilderSample
{
    public interface IBuilderB : IBuilder
    {
        IBuilder B();
    }
}