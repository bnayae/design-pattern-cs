using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace Bnaya.Samples
{
    public class ImageManipulator : IImageManip
    {
        private readonly IEffect[] _effects;

        public ImageManipulator(IEffect[] effects)
        {
            _effects = effects;
        }

        public void Execute(string src, string dest)
        {
            byte[] image = File.ReadAllBytes(src);
            Image<Rgba32> imageProcessor = Image.Load(image);
            imageProcessor.Mutate(x =>
            {
                foreach (IEffect e in _effects)
                {
                    e.Apply(x);
                }
            });

            using (var outStream = File.OpenWrite(dest))
            {
                imageProcessor.SaveAsJpeg(outStream);
            }
        }
    }
}
