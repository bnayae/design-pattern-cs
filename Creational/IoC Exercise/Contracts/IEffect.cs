using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing.Processors;
using SixLabors.Primitives;
using SixLabors.ImageSharp.Processing;

namespace Bnaya.Samples
{
    public interface IEffect 
    {
        void Apply(IImageProcessingContext<Rgba32> source);
    }
}
