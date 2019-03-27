namespace Bnaya.Samples
{
    public interface ISkewSetting
    {
        float DegreeX { get; }
        float DegreeY { get; }

        void Deconstruct(out float degreeX, out float degreeY);

    }
}   