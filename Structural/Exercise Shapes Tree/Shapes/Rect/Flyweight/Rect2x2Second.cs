using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class Rect2x2Second : Rect
    {
        public Rect2x2Second(
            [KeyFilter(Keys.Line2Second)]Line data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
