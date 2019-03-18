namespace IoC_Exercise
{
    public interface ISkewSetting
    {
        float DegreeX { get; }
        float DegreeY { get; }

        void Deconstruct(out float degreeX, out float degreeY);

    }
}   