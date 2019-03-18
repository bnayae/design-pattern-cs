using SixLabors.ImageSharp.Processing;

namespace IoC_Exercise
{
    public interface IGrayscaleSetting
    {
        GrayscaleMode Mode { get; }
    }
}