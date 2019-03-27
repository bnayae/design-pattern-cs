using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Features.AttributeFilters;

namespace Exercise_Shapes_Tree.Shapes.Lines
{
    public class Rect4x2Prime : Rect
    {
        public Rect4x2Prime(
            [KeyFilter(Keys.Line4Prime)]Line data)
            : base(data)
        {
        }

        protected override int Hieght => 2; 
    }
}
