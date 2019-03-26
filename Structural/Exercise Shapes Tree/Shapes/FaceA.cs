using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class FaceA : Face
    {

        public FaceA(
            [KeyFilter("LeftEye")]IShape eye1,
            [KeyFilter("RightEye")]IShape eye2,
            [KeyFilter("Nose")]IShape nose,
            [KeyFilter("Mouth")]IShape mouth)
            : base (
                  (eye1, 1, 1),
                  (eye2, 7, 1),
                  (nose, 3, 5),
                  (mouth, 2, 8))
        {
        }
    }
}
