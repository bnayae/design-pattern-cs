using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class FaceWink : ComplexShape
    {

        public FaceWink(
            [KeyFilter(Keys.EyeClosed)]IShape eye1,
            [KeyFilter(Keys.EyeOpened)]IShape eye2,
            [KeyFilter(Keys.BoxNose)]IShape nose,
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
