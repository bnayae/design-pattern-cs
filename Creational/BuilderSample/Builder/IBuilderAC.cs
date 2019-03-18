namespace BuilderSample
{
    public interface IBuilderAC : IBuilder
    {
        IBuilderC A();

        IBuilderA C();
    }
}