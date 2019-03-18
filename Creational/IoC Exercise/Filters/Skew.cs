using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing.Processors;
using SixLabors.Primitives;
using SixLabors.ImageSharp.Processing;

namespace IoC_Exercise
{
    public class Skew : IEffect
    {
        private readonly ISkewSetting _setting;

        public Skew(ISkewSetting setting)
        {
            _setting = setting;
        }
        public void Apply(IImageProcessingContext<Rgba32> source)
        {
            (float x, float y) = _setting;
            source.Skew(x, y);
        }
    }
}
