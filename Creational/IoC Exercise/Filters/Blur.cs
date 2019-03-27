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
    public class Blur : IEffect
    {
        private readonly float _sigma;

        public Blur(IBlurSetting setting)
        {
            _sigma = setting.Sigma;
        }
        public void Apply(IImageProcessingContext<Rgba32> source)
        {
            source.GaussianBlur(_sigma);
        }
    }
}
