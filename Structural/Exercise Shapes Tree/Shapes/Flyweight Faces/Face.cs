using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Bnaya.Samples
{
    public class Face : ComplexShape
    {

        public Face(
            [KeyFilter(Keys.Rect2x2Prime)]IShape eye,
            [KeyFilter(Keys.SlideNose)]IShape nose,
            [KeyFilter(Keys.Rect4x2Prime)]IShape mouth)
            : base (
                  (eye, 1, 1),
                  (eye, 7, 1),
                  (nose, 3, 5),
                  (mouth, 2, 9))
        {
        }
    }
}
