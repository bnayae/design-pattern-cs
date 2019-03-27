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
    public class Grayscale : IEffect
    {
        private readonly GrayscaleMode _mode;

        public Grayscale(IGrayscaleSetting setting)
        {
            _mode = setting.Mode;
        }
        public void Apply(IImageProcessingContext<Rgba32> source)
        {
            source.Grayscale();
        }
    }
}
