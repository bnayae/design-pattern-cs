using SixLabors.ImageSharp.Processing;

namespace Bnaya.Samples
{
    public interface IGrayscaleSetting
    {
        GrayscaleMode Mode { get; }
    }
}