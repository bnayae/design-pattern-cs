namespace BuilderSample
{
    public interface IBuilderBC : IBuilder
    {
        IBuilderC B();
        IBuilderB C();
    }
}