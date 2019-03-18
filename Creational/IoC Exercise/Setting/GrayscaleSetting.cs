using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp.Processing;

namespace IoC_Exercise
{
    public class GrayscaleSetting : IGrayscaleSetting
    {
        public GrayscaleMode Mode => GrayscaleMode.Bt601;
    }
}
