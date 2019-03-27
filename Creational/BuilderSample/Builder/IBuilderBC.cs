namespace Bnaya.Samples
{
    public interface IBuilderBC : IBuilder
    {
        IBuilderC B();
        IBuilderB C();
    }
}