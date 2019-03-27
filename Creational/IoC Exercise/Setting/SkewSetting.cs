using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp.Processing;

namespace Bnaya.Samples
{
    public class SkewSetting : ISkewSetting
    {
        public float DegreeX => 15;

        public float DegreeY => 45;

        public void Deconstruct(out float degreeX, out float degreeY)
        {
            degreeX = DegreeX;
            degreeY = DegreeY;
        }
    }
}
