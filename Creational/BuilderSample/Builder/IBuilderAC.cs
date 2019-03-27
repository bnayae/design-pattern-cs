namespace Bnaya.Samples
{
    public interface IBuilderAC : IBuilder
    {
        IBuilderC A();

        IBuilderA C();
    }
}