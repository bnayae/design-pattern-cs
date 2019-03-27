using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class FaceWink : ComplexShape
    {

        public FaceWink(
            [KeyFilter(Keys.Rect2x2Prime)]IShape eye1,
            [KeyFilter(Keys.Rect2x2Second)]IShape eye2,
            [KeyFilter(Keys.Rect2x2Prime)]IShape nose,
            [KeyFilter(Keys.Smile)]IShape mouth)
            : base (
                  (eye1, 1, 1),
                  (eye2, 7, 1),
                  (nose, 3, 5),
                  (mouth, 2, 9))
        {
        }
    }
}
