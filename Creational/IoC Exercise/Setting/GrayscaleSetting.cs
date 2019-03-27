using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp.Processing;

namespace Bnaya.Samples
{
    public class GrayscaleSetting : IGrayscaleSetting
    {
        public GrayscaleMode Mode => GrayscaleMode.Bt601;
    }
}
